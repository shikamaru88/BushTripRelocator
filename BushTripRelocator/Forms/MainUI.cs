using BushTripRelocator.Models;
using BushTripRelocator.Services;
using BushTripRelocator.Services.Implementation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BushTripRelocator
{
    public partial class MainUI : Form
    {
        private readonly IDatabaseService databaseService;
        private readonly ISimConnectService simConnectService;

        public MainUI(IDatabaseService databaseService, ISimConnectService simConnectService)
        {
            this.databaseService = databaseService;
            this.simConnectService = simConnectService;

            string appDir = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\BushTripRelocator";
            if (!Directory.Exists(appDir))
            {
                Directory.CreateDirectory(appDir);
            }


            databaseService.InitDatabase();

            InitializeComponent();

            LoadCheckPoints();
        }

        protected override void DefWndProc(ref Message m)
        {
            if (m.Msg == SimConnectServiceImplementation.WM_USER_SIMCONNECT)
            {
                if (!simConnectService.IsConnected())
                {
                    LostConnectionLabel("Connection closed");
                }
            }
            else
            {
                base.DefWndProc(ref m);
            }
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            this.Text = $"BushTripRelocator - {Application.ProductVersion}";

            LostConnectionLabel("Sim not connected");

        }

        private void DisplayNotConnectedModal()
        {
            DialogResult res = MessageBox.Show("Do you want connect now?", "Not connected to sim", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                simConnectService.Connect();
            }
            
        }

        public void UpdateEnvironmentalDataForm(EnvironmentData environmentData)
        {
            AircraftNameLabel.Text = environmentData.title;
        }

        public void UpdateLocationDataForm(LocationData locationData)
        {

        }

        public void UpdateFuelData(FuelData fuelData)
        {
            LeftFuelTankText.Text = fuelData.leftTankQuantity.ToString("N2");
            RightFuelTankText.Text = fuelData.rightTankQuantity.ToString("N2");
            MaxCapacityLeftTank.Text = fuelData.fuelLeftCapacity.ToString("N2");
            MaxCapacityRightTank.Text = fuelData.fuelRightCapacity.ToString("N2");
        }

        public void SetConnectionOpened()
        {
            ActiveConnectionLabel("Connected to sim");
        }

        public void SetConnectionClosed()
        {
            LostConnectionLabel("Connection closed");
        }

        private void LostConnectionLabel(String text)
        {
            ConnectStatusLabel.Text = text;
            ConnectStatusLabel.BackColor = Color.Red;
            ConnectStatusLabel.ForeColor = Color.White;
        }

        private void ActiveConnectionLabel(String text)
        {
            ConnectStatusLabel.Text = text;
            ConnectStatusLabel.BackColor = Color.Green;
            ConnectStatusLabel.ForeColor = Color.White;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            simConnectService.Connect();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!simConnectService.IsConnected())
            {
                DisplayNotConnectedModal();

                return;
            }

            if (!IsNotEmpty(new TextBox[] {CheckpointNameTextBox}))
            {
                return;
            }

            string checkpointName = CheckpointNameTextBox.Text;

            SimData simData = simConnectService.GetSimData();

            databaseService.SaveData(checkpointName, simData);

            CheckpointNameTextBox.Text = "";

            LoadCheckPoints();

            CheckpointsListBox.SelectedIndex = 0;
        }

        private void LoadCheckPoints()
        {
            List<string> checkpoints = databaseService.FindCheckpoints();
            CheckpointsListBox.Items.Clear();
            CheckpointsListBox.Items.AddRange(checkpoints.ToArray());
            
            if (checkpoints.Count > 0)
            {
                CheckpointsListBox.SelectedIndex = 0;
            }
            
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (!simConnectService.IsConnected())
            {
                DisplayNotConnectedModal();

                return;
            }

            object checkPointId = CheckpointsListBox.SelectedItem;

            if (checkPointId == null)
            {
                MessageBox.Show("You need to save checkpoint first", "No checkpoint to load", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                return;
            }

            SimData simData = databaseService.FindCheckpointById(checkPointId.ToString());

            if (LoadTimeCheckbox.Checked == true)
            {
                if (!IsNotEmpty(new TextBox[] { HoursSaveTextBox, MinutesSaveTextBox, SecondsSaveTextBox }))
                {
                    return;
                }

                simConnectService.LoadTimeToSim(GetParsedTimeData(HoursSaveTextBox, MinutesSaveTextBox, SecondsSaveTextBox));
            }

            if (LoadFuelCheckbox.Checked == true)
            {
                simConnectService.LoadFuelToSim(simData.fuelData);
            }

            simConnectService.LoadCheckpointToSim(simData, ColdAndDarkCheckBox.Checked);

        }

        private void ChangeTimeButton_Click(object sender, EventArgs e)
        {
            if (!simConnectService.IsConnected())
            {
                DisplayNotConnectedModal();

                return;
            }

            if (!IsNotEmpty(new TextBox[] { HoursTextBox, MinutesTextBox, SecondsTextBox }))
            {
                return;
            }

            simConnectService.LoadTimeToSim(GetParsedTimeData(HoursTextBox, MinutesTextBox, SecondsTextBox));
        }

        private TimeData GetParsedTimeData(TextBox hours, TextBox minutes, TextBox seconds)
        {
            TimeData timeData = new TimeData();
            int hoursL = int.Parse(hours.Text);
            int minutesL = int.Parse(minutes.Text);
            int secondsL = int.Parse(seconds.Text);

            timeData.hours = hoursL > 23 ? 23 : hoursL;
            timeData.minutes = minutesL > 59 ? 59 : minutesL;
            timeData.seconds = secondsL > 59 ? 59 : secondsL;

            hours.Text = timeData.hours.ToString();
            minutes.Text = timeData.minutes.ToString();
            seconds.Text = timeData.seconds.ToString();

            return timeData;
        }

        
        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void OnlyDoubles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void SimRateDecrButton_Click(object sender, EventArgs e)
        {
            if (!simConnectService.IsConnected())
            {
                DisplayNotConnectedModal();

                return;
            }

            simConnectService.DecrSimRate();
        }

        private void SimRateIncrButton_Click(object sender, EventArgs e)
        {
            if (!simConnectService.IsConnected())
            {
                DisplayNotConnectedModal();

                return;
            }

            simConnectService.IncrSimRate();
        }

        private void LoadTimeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            HoursSaveTextBox.BackColor = Color.White;
            MinutesSaveTextBox.BackColor = Color.White;
            SecondsSaveTextBox.BackColor = Color.White;

            if (LoadTimeCheckbox.Checked == true)
            {
                HoursSaveTextBox.ReadOnly = false;
                MinutesSaveTextBox.ReadOnly = false;
                SecondsSaveTextBox.ReadOnly = false;
            }
            else
            {
                HoursSaveTextBox.ReadOnly = true;
                MinutesSaveTextBox.ReadOnly = true;
                SecondsSaveTextBox.ReadOnly = true;

                HoursSaveTextBox.Text = "";
                MinutesSaveTextBox.Text = "";
                SecondsSaveTextBox.Text = "";

                HoursSaveTextBox.BackColor = Color.LightGray;
                MinutesSaveTextBox.BackColor = Color.LightGray;
                SecondsSaveTextBox.BackColor = Color.LightGray;
            }

        }

        private void RefuelButton_Click(object sender, EventArgs e)
        {
            if (!simConnectService.IsConnected())
            {
                DisplayNotConnectedModal();

                return;
            }

            if (!IsNotEmpty(new TextBox[] { LeftFuelTankSaveTextBox, RightFuelTankSaveTextBox }))
            {
                return;
            }

            FuelData fuelData = new FuelData();
            fuelData.leftTankQuantity = double.Parse(LeftFuelTankSaveTextBox.Text);
            fuelData.rightTankQuantity = double.Parse(RightFuelTankSaveTextBox.Text);

            simConnectService.LoadFuelToSim(fuelData);
        }

        private void DeleteCheckpointButton_Click(object sender, EventArgs e)
        {
            string checkPointId = CheckpointsListBox.SelectedItem.ToString();
            databaseService.DeleteCheckpoint(checkPointId);
            LoadCheckPoints();
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            simConnectService.Disconnect();
        }

        private bool IsNotEmpty(TextBox [] textBoxes)
        {
            bool valid = true;
            for (int i = 0; i < textBoxes.Length; i++)
            {
                
                if (textBoxes[i].Text.Length == 0)
                {
                    valid = false;
                    textBoxes[i].BackColor = Color.Red;
                }
                else
                {
                    textBoxes[i].BackColor = Color.White;
                }
            }

            return valid;
        }

        private void ResetBoxes_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.White;
        }

    }
}
