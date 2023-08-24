using System.Windows.Forms;

namespace BushTripRelocator
{
    partial class MainUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.AircraftLabel = new System.Windows.Forms.Label();
            this.CheckpointsListBox = new System.Windows.Forms.ListBox();
            this.CheckpointsLabel = new System.Windows.Forms.Label();
            this.LoadButton = new System.Windows.Forms.Button();
            this.LoadFuelCheckbox = new System.Windows.Forms.CheckBox();
            this.CheckpointNameTextBox = new System.Windows.Forms.TextBox();
            this.CheckpointNameLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LeftFuelTankText = new System.Windows.Forms.TextBox();
            this.RightFuelTankText = new System.Windows.Forms.TextBox();
            this.LeftTankLabel = new System.Windows.Forms.Label();
            this.RightTankLabel = new System.Windows.Forms.Label();
            this.RefuelButton = new System.Windows.Forms.Button();
            this.SimConnectIndicatorLabel = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ConnectStatusLabel = new System.Windows.Forms.Label();
            this.AircraftNameLabel = new System.Windows.Forms.Label();
            this.separator1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckpointTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DeleteCheckpointButton = new System.Windows.Forms.Button();
            this.SecondsSaveLabel = new System.Windows.Forms.Label();
            this.MinutesSaveLabel = new System.Windows.Forms.Label();
            this.HoursSaveLabel = new System.Windows.Forms.Label();
            this.SecondsSaveTextBox = new System.Windows.Forms.TextBox();
            this.MinutesSaveTextBox = new System.Windows.Forms.TextBox();
            this.HoursSaveTextBox = new System.Windows.Forms.TextBox();
            this.LoadTimeCheckbox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MaxCapacityRightTank = new System.Windows.Forms.TextBox();
            this.MaxCapacityLeftTank = new System.Windows.Forms.TextBox();
            this.RightFuelTankSaveTextBox = new System.Windows.Forms.TextBox();
            this.LeftFuelTankSaveTextBox = new System.Windows.Forms.TextBox();
            this.ChangeTimeButton = new System.Windows.Forms.Button();
            this.SimRateIncrButton = new System.Windows.Forms.Button();
            this.SimRateDecrButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SecondsTextBox = new System.Windows.Forms.TextBox();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.MinutesTextBox = new System.Windows.Forms.TextBox();
            this.MinutesLabel = new System.Windows.Forms.Label();
            this.HoursTextBox = new System.Windows.Forms.TextBox();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.CheckpointTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AircraftLabel
            // 
            this.AircraftLabel.AutoSize = true;
            this.AircraftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AircraftLabel.Location = new System.Drawing.Point(54, 27);
            this.AircraftLabel.Name = "AircraftLabel";
            this.AircraftLabel.Size = new System.Drawing.Size(66, 17);
            this.AircraftLabel.TabIndex = 0;
            this.AircraftLabel.Text = "Aircraft:";
            // 
            // CheckpointsListBox
            // 
            this.CheckpointsListBox.FormattingEnabled = true;
            this.CheckpointsListBox.Location = new System.Drawing.Point(17, 58);
            this.CheckpointsListBox.Name = "CheckpointsListBox";
            this.CheckpointsListBox.Size = new System.Drawing.Size(278, 56);
            this.CheckpointsListBox.TabIndex = 1;
            // 
            // CheckpointsLabel
            // 
            this.CheckpointsLabel.AutoSize = true;
            this.CheckpointsLabel.Location = new System.Drawing.Point(14, 42);
            this.CheckpointsLabel.Name = "CheckpointsLabel";
            this.CheckpointsLabel.Size = new System.Drawing.Size(66, 13);
            this.CheckpointsLabel.TabIndex = 2;
            this.CheckpointsLabel.Text = "Checkpoints";
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoadButton.Location = new System.Drawing.Point(14, 210);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 3;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // LoadFuelCheckbox
            // 
            this.LoadFuelCheckbox.AutoSize = true;
            this.LoadFuelCheckbox.Checked = true;
            this.LoadFuelCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LoadFuelCheckbox.Location = new System.Drawing.Point(17, 141);
            this.LoadFuelCheckbox.Name = "LoadFuelCheckbox";
            this.LoadFuelCheckbox.Size = new System.Drawing.Size(70, 17);
            this.LoadFuelCheckbox.TabIndex = 4;
            this.LoadFuelCheckbox.Text = "Load fuel";
            this.LoadFuelCheckbox.UseVisualStyleBackColor = true;
            // 
            // CheckpointNameTextBox
            // 
            this.CheckpointNameTextBox.BackColor = System.Drawing.Color.White;
            this.CheckpointNameTextBox.Location = new System.Drawing.Point(14, 325);
            this.CheckpointNameTextBox.MaxLength = 100;
            this.CheckpointNameTextBox.Name = "CheckpointNameTextBox";
            this.CheckpointNameTextBox.Size = new System.Drawing.Size(278, 20);
            this.CheckpointNameTextBox.TabIndex = 5;
            this.CheckpointNameTextBox.TextChanged += new System.EventHandler(this.ResetBoxes_TextChanged);
            // 
            // CheckpointNameLabel
            // 
            this.CheckpointNameLabel.AutoSize = true;
            this.CheckpointNameLabel.Location = new System.Drawing.Point(14, 306);
            this.CheckpointNameLabel.Name = "CheckpointNameLabel";
            this.CheckpointNameLabel.Size = new System.Drawing.Size(90, 13);
            this.CheckpointNameLabel.TabIndex = 6;
            this.CheckpointNameLabel.Text = "Checkpoint name";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveButton.Location = new System.Drawing.Point(14, 369);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LeftFuelTankText
            // 
            this.LeftFuelTankText.Location = new System.Drawing.Point(20, 67);
            this.LeftFuelTankText.Name = "LeftFuelTankText";
            this.LeftFuelTankText.ReadOnly = true;
            this.LeftFuelTankText.Size = new System.Drawing.Size(43, 20);
            this.LeftFuelTankText.TabIndex = 8;
            // 
            // RightFuelTankText
            // 
            this.RightFuelTankText.Location = new System.Drawing.Point(255, 67);
            this.RightFuelTankText.Name = "RightFuelTankText";
            this.RightFuelTankText.ReadOnly = true;
            this.RightFuelTankText.Size = new System.Drawing.Size(43, 20);
            this.RightFuelTankText.TabIndex = 10;
            // 
            // LeftTankLabel
            // 
            this.LeftTankLabel.AutoSize = true;
            this.LeftTankLabel.Location = new System.Drawing.Point(17, 51);
            this.LeftTankLabel.Name = "LeftTankLabel";
            this.LeftTankLabel.Size = new System.Drawing.Size(25, 13);
            this.LeftTankLabel.TabIndex = 11;
            this.LeftTankLabel.Text = "Left";
            // 
            // RightTankLabel
            // 
            this.RightTankLabel.AutoSize = true;
            this.RightTankLabel.Location = new System.Drawing.Point(266, 51);
            this.RightTankLabel.Name = "RightTankLabel";
            this.RightTankLabel.Size = new System.Drawing.Size(32, 13);
            this.RightTankLabel.TabIndex = 13;
            this.RightTankLabel.Text = "Right";
            // 
            // RefuelButton
            // 
            this.RefuelButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RefuelButton.Location = new System.Drawing.Point(119, 90);
            this.RefuelButton.Name = "RefuelButton";
            this.RefuelButton.Size = new System.Drawing.Size(75, 23);
            this.RefuelButton.TabIndex = 14;
            this.RefuelButton.Text = "Refuel";
            this.RefuelButton.UseVisualStyleBackColor = false;
            this.RefuelButton.Click += new System.EventHandler(this.RefuelButton_Click);
            // 
            // SimConnectIndicatorLabel
            // 
            this.SimConnectIndicatorLabel.AutoSize = true;
            this.SimConnectIndicatorLabel.Location = new System.Drawing.Point(-1, 563);
            this.SimConnectIndicatorLabel.Name = "SimConnectIndicatorLabel";
            this.SimConnectIndicatorLabel.Size = new System.Drawing.Size(0, 13);
            this.SimConnectIndicatorLabel.TabIndex = 15;
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConnectButton.Location = new System.Drawing.Point(220, 553);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 16;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ConnectStatusLabel
            // 
            this.ConnectStatusLabel.AutoSize = true;
            this.ConnectStatusLabel.Location = new System.Drawing.Point(0, 563);
            this.ConnectStatusLabel.Name = "ConnectStatusLabel";
            this.ConnectStatusLabel.Size = new System.Drawing.Size(27, 13);
            this.ConnectStatusLabel.TabIndex = 17;
            this.ConnectStatusLabel.Text = "N/A";
            // 
            // AircraftNameLabel
            // 
            this.AircraftNameLabel.AutoSize = true;
            this.AircraftNameLabel.Location = new System.Drawing.Point(126, 31);
            this.AircraftNameLabel.Name = "AircraftNameLabel";
            this.AircraftNameLabel.Size = new System.Drawing.Size(27, 13);
            this.AircraftNameLabel.TabIndex = 18;
            this.AircraftNameLabel.Text = "N/A";
            // 
            // separator1
            // 
            this.separator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator1.Location = new System.Drawing.Point(11, 23);
            this.separator1.Name = "separator1";
            this.separator1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.separator1.Size = new System.Drawing.Size(276, 2);
            this.separator1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(17, 286);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(276, 2);
            this.label1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(276, 2);
            this.label2.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Load Checkpoint";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Save Checkpoint";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Manage Fuel";
            // 
            // CheckpointTab
            // 
            this.CheckpointTab.Controls.Add(this.tabPage1);
            this.CheckpointTab.Controls.Add(this.tabPage2);
            this.CheckpointTab.Location = new System.Drawing.Point(57, 63);
            this.CheckpointTab.Name = "CheckpointTab";
            this.CheckpointTab.SelectedIndex = 0;
            this.CheckpointTab.Size = new System.Drawing.Size(323, 459);
            this.CheckpointTab.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.DeleteCheckpointButton);
            this.tabPage1.Controls.Add(this.SecondsSaveLabel);
            this.tabPage1.Controls.Add(this.MinutesSaveLabel);
            this.tabPage1.Controls.Add(this.HoursSaveLabel);
            this.tabPage1.Controls.Add(this.SecondsSaveTextBox);
            this.tabPage1.Controls.Add(this.MinutesSaveTextBox);
            this.tabPage1.Controls.Add(this.HoursSaveTextBox);
            this.tabPage1.Controls.Add(this.LoadTimeCheckbox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.CheckpointsLabel);
            this.tabPage1.Controls.Add(this.separator1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.CheckpointsListBox);
            this.tabPage1.Controls.Add(this.LoadButton);
            this.tabPage1.Controls.Add(this.LoadFuelCheckbox);
            this.tabPage1.Controls.Add(this.SaveButton);
            this.tabPage1.Controls.Add(this.CheckpointNameTextBox);
            this.tabPage1.Controls.Add(this.CheckpointNameLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(315, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Checkpoint";
            // 
            // DeleteCheckpointButton
            // 
            this.DeleteCheckpointButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteCheckpointButton.Location = new System.Drawing.Point(99, 210);
            this.DeleteCheckpointButton.Name = "DeleteCheckpointButton";
            this.DeleteCheckpointButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteCheckpointButton.TabIndex = 31;
            this.DeleteCheckpointButton.Text = "Delete";
            this.DeleteCheckpointButton.UseVisualStyleBackColor = false;
            this.DeleteCheckpointButton.Click += new System.EventHandler(this.DeleteCheckpointButton_Click);
            // 
            // SecondsSaveLabel
            // 
            this.SecondsSaveLabel.AutoSize = true;
            this.SecondsSaveLabel.Location = new System.Drawing.Point(189, 148);
            this.SecondsSaveLabel.Name = "SecondsSaveLabel";
            this.SecondsSaveLabel.Size = new System.Drawing.Size(49, 13);
            this.SecondsSaveLabel.TabIndex = 30;
            this.SecondsSaveLabel.Text = "Seconds";
            // 
            // MinutesSaveLabel
            // 
            this.MinutesSaveLabel.AutoSize = true;
            this.MinutesSaveLabel.Location = new System.Drawing.Point(140, 148);
            this.MinutesSaveLabel.Name = "MinutesSaveLabel";
            this.MinutesSaveLabel.Size = new System.Drawing.Size(44, 13);
            this.MinutesSaveLabel.TabIndex = 29;
            this.MinutesSaveLabel.Text = "Minutes";
            // 
            // HoursSaveLabel
            // 
            this.HoursSaveLabel.AutoSize = true;
            this.HoursSaveLabel.Location = new System.Drawing.Point(93, 148);
            this.HoursSaveLabel.Name = "HoursSaveLabel";
            this.HoursSaveLabel.Size = new System.Drawing.Size(35, 13);
            this.HoursSaveLabel.TabIndex = 28;
            this.HoursSaveLabel.Text = "Hours";
            // 
            // SecondsSaveTextBox
            // 
            this.SecondsSaveTextBox.BackColor = System.Drawing.Color.LightGray;
            this.SecondsSaveTextBox.Location = new System.Drawing.Point(192, 164);
            this.SecondsSaveTextBox.MaxLength = 2;
            this.SecondsSaveTextBox.Name = "SecondsSaveTextBox";
            this.SecondsSaveTextBox.ReadOnly = true;
            this.SecondsSaveTextBox.Size = new System.Drawing.Size(31, 20);
            this.SecondsSaveTextBox.TabIndex = 27;
            this.SecondsSaveTextBox.TextChanged += new System.EventHandler(this.ResetBoxes_TextChanged);
            this.SecondsSaveTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers_KeyPress);
            // 
            // MinutesSaveTextBox
            // 
            this.MinutesSaveTextBox.BackColor = System.Drawing.Color.LightGray;
            this.MinutesSaveTextBox.Location = new System.Drawing.Point(143, 164);
            this.MinutesSaveTextBox.MaxLength = 2;
            this.MinutesSaveTextBox.Name = "MinutesSaveTextBox";
            this.MinutesSaveTextBox.ReadOnly = true;
            this.MinutesSaveTextBox.Size = new System.Drawing.Size(31, 20);
            this.MinutesSaveTextBox.TabIndex = 26;
            this.MinutesSaveTextBox.TextChanged += new System.EventHandler(this.ResetBoxes_TextChanged);
            this.MinutesSaveTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers_KeyPress);
            // 
            // HoursSaveTextBox
            // 
            this.HoursSaveTextBox.BackColor = System.Drawing.Color.LightGray;
            this.HoursSaveTextBox.Location = new System.Drawing.Point(95, 164);
            this.HoursSaveTextBox.MaxLength = 2;
            this.HoursSaveTextBox.Name = "HoursSaveTextBox";
            this.HoursSaveTextBox.ReadOnly = true;
            this.HoursSaveTextBox.Size = new System.Drawing.Size(31, 20);
            this.HoursSaveTextBox.TabIndex = 25;
            this.HoursSaveTextBox.TextChanged += new System.EventHandler(this.ResetBoxes_TextChanged);
            this.HoursSaveTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers_KeyPress);
            // 
            // LoadTimeCheckbox
            // 
            this.LoadTimeCheckbox.AutoSize = true;
            this.LoadTimeCheckbox.Location = new System.Drawing.Point(17, 164);
            this.LoadTimeCheckbox.Name = "LoadTimeCheckbox";
            this.LoadTimeCheckbox.Size = new System.Drawing.Size(72, 17);
            this.LoadTimeCheckbox.TabIndex = 23;
            this.LoadTimeCheckbox.Text = "Load time";
            this.LoadTimeCheckbox.UseVisualStyleBackColor = true;
            this.LoadTimeCheckbox.CheckedChanged += new System.EventHandler(this.LoadTimeCheckbox_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.MaxCapacityRightTank);
            this.tabPage2.Controls.Add(this.MaxCapacityLeftTank);
            this.tabPage2.Controls.Add(this.RightFuelTankSaveTextBox);
            this.tabPage2.Controls.Add(this.LeftFuelTankSaveTextBox);
            this.tabPage2.Controls.Add(this.ChangeTimeButton);
            this.tabPage2.Controls.Add(this.SimRateIncrButton);
            this.tabPage2.Controls.Add(this.SimRateDecrButton);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.SecondsTextBox);
            this.tabPage2.Controls.Add(this.SecondsLabel);
            this.tabPage2.Controls.Add(this.MinutesTextBox);
            this.tabPage2.Controls.Add(this.MinutesLabel);
            this.tabPage2.Controls.Add(this.HoursTextBox);
            this.tabPage2.Controls.Add(this.HoursLabel);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.LeftFuelTankText);
            this.tabPage2.Controls.Add(this.RightFuelTankText);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.LeftTankLabel);
            this.tabPage2.Controls.Add(this.RightTankLabel);
            this.tabPage2.Controls.Add(this.RefuelButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(315, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Misc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(207, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Max";
            // 
            // MaxCapacityRightTank
            // 
            this.MaxCapacityRightTank.Location = new System.Drawing.Point(206, 67);
            this.MaxCapacityRightTank.Name = "MaxCapacityRightTank";
            this.MaxCapacityRightTank.ReadOnly = true;
            this.MaxCapacityRightTank.Size = new System.Drawing.Size(43, 20);
            this.MaxCapacityRightTank.TabIndex = 43;
            // 
            // MaxCapacityLeftTank
            // 
            this.MaxCapacityLeftTank.Location = new System.Drawing.Point(66, 67);
            this.MaxCapacityLeftTank.Name = "MaxCapacityLeftTank";
            this.MaxCapacityLeftTank.ReadOnly = true;
            this.MaxCapacityLeftTank.Size = new System.Drawing.Size(43, 20);
            this.MaxCapacityLeftTank.TabIndex = 42;
            // 
            // RightFuelTankSaveTextBox
            // 
            this.RightFuelTankSaveTextBox.Location = new System.Drawing.Point(255, 93);
            this.RightFuelTankSaveTextBox.MaxLength = 6;
            this.RightFuelTankSaveTextBox.Name = "RightFuelTankSaveTextBox";
            this.RightFuelTankSaveTextBox.Size = new System.Drawing.Size(43, 20);
            this.RightFuelTankSaveTextBox.TabIndex = 41;
            this.RightFuelTankSaveTextBox.TextChanged += new System.EventHandler(this.ResetBoxes_TextChanged);
            this.RightFuelTankSaveTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDoubles_KeyPress);
            // 
            // LeftFuelTankSaveTextBox
            // 
            this.LeftFuelTankSaveTextBox.Location = new System.Drawing.Point(20, 93);
            this.LeftFuelTankSaveTextBox.MaxLength = 6;
            this.LeftFuelTankSaveTextBox.Name = "LeftFuelTankSaveTextBox";
            this.LeftFuelTankSaveTextBox.Size = new System.Drawing.Size(43, 20);
            this.LeftFuelTankSaveTextBox.TabIndex = 40;
            this.LeftFuelTankSaveTextBox.TextChanged += new System.EventHandler(this.ResetBoxes_TextChanged);
            this.LeftFuelTankSaveTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDoubles_KeyPress);
            // 
            // ChangeTimeButton
            // 
            this.ChangeTimeButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChangeTimeButton.Location = new System.Drawing.Point(15, 241);
            this.ChangeTimeButton.Name = "ChangeTimeButton";
            this.ChangeTimeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeTimeButton.TabIndex = 39;
            this.ChangeTimeButton.Text = "Change time";
            this.ChangeTimeButton.UseVisualStyleBackColor = false;
            this.ChangeTimeButton.Click += new System.EventHandler(this.ChangeTimeButton_Click);
            // 
            // SimRateIncrButton
            // 
            this.SimRateIncrButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SimRateIncrButton.Location = new System.Drawing.Point(64, 363);
            this.SimRateIncrButton.Name = "SimRateIncrButton";
            this.SimRateIncrButton.Size = new System.Drawing.Size(43, 23);
            this.SimRateIncrButton.TabIndex = 37;
            this.SimRateIncrButton.Text = "++";
            this.SimRateIncrButton.UseVisualStyleBackColor = false;
            this.SimRateIncrButton.Click += new System.EventHandler(this.SimRateIncrButton_Click);
            // 
            // SimRateDecrButton
            // 
            this.SimRateDecrButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SimRateDecrButton.Location = new System.Drawing.Point(15, 363);
            this.SimRateDecrButton.Name = "SimRateDecrButton";
            this.SimRateDecrButton.Size = new System.Drawing.Size(43, 23);
            this.SimRateDecrButton.TabIndex = 36;
            this.SimRateDecrButton.Text = "--";
            this.SimRateDecrButton.UseVisualStyleBackColor = false;
            this.SimRateDecrButton.Click += new System.EventHandler(this.SimRateDecrButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 314);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 16);
            this.label12.TabIndex = 34;
            this.label12.Text = "Manage Sim Rate";
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(14, 328);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(276, 2);
            this.label13.TabIndex = 33;
            // 
            // SecondsTextBox
            // 
            this.SecondsTextBox.Location = new System.Drawing.Point(119, 195);
            this.SecondsTextBox.MaxLength = 2;
            this.SecondsTextBox.Name = "SecondsTextBox";
            this.SecondsTextBox.Size = new System.Drawing.Size(43, 20);
            this.SecondsTextBox.TabIndex = 31;
            this.SecondsTextBox.TextChanged += new System.EventHandler(this.ResetBoxes_TextChanged);
            this.SecondsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers_KeyPress);
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.Location = new System.Drawing.Point(116, 179);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(49, 13);
            this.SecondsLabel.TabIndex = 32;
            this.SecondsLabel.Text = "Seconds";
            // 
            // MinutesTextBox
            // 
            this.MinutesTextBox.Location = new System.Drawing.Point(69, 195);
            this.MinutesTextBox.MaxLength = 2;
            this.MinutesTextBox.Name = "MinutesTextBox";
            this.MinutesTextBox.Size = new System.Drawing.Size(43, 20);
            this.MinutesTextBox.TabIndex = 29;
            this.MinutesTextBox.TextChanged += new System.EventHandler(this.ResetBoxes_TextChanged);
            this.MinutesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers_KeyPress);
            // 
            // MinutesLabel
            // 
            this.MinutesLabel.AutoSize = true;
            this.MinutesLabel.Location = new System.Drawing.Point(66, 179);
            this.MinutesLabel.Name = "MinutesLabel";
            this.MinutesLabel.Size = new System.Drawing.Size(44, 13);
            this.MinutesLabel.TabIndex = 30;
            this.MinutesLabel.Text = "Minutes";
            // 
            // HoursTextBox
            // 
            this.HoursTextBox.Location = new System.Drawing.Point(20, 195);
            this.HoursTextBox.MaxLength = 2;
            this.HoursTextBox.Name = "HoursTextBox";
            this.HoursTextBox.Size = new System.Drawing.Size(43, 20);
            this.HoursTextBox.TabIndex = 27;
            this.HoursTextBox.TextChanged += new System.EventHandler(this.ResetBoxes_TextChanged);
            this.HoursTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers_KeyPress);
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(17, 179);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(35, 13);
            this.HoursLabel.TabIndex = 28;
            this.HoursLabel.Text = "Hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Manage Time";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(17, 149);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(276, 2);
            this.label8.TabIndex = 25;
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DisconnectButton.Location = new System.Drawing.Point(301, 553);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(75, 23);
            this.DisconnectButton.TabIndex = 27;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = false;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(433, 580);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.CheckpointTab);
            this.Controls.Add(this.AircraftNameLabel);
            this.Controls.Add(this.ConnectStatusLabel);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.SimConnectIndicatorLabel);
            this.Controls.Add(this.AircraftLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.Text = "BushTripRelocator";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.CheckpointTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AircraftLabel;
        private System.Windows.Forms.ListBox CheckpointsListBox;
        private System.Windows.Forms.Label CheckpointsLabel;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.CheckBox LoadFuelCheckbox;
        private System.Windows.Forms.TextBox CheckpointNameTextBox;
        private System.Windows.Forms.Label CheckpointNameLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox LeftFuelTankText;
        private System.Windows.Forms.TextBox RightFuelTankText;
        private System.Windows.Forms.Label LeftTankLabel;
        private System.Windows.Forms.Label RightTankLabel;
        private System.Windows.Forms.Button RefuelButton;
        private System.Windows.Forms.Label SimConnectIndicatorLabel;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label ConnectStatusLabel;
        private System.Windows.Forms.Label AircraftNameLabel;
        private System.Windows.Forms.Label separator1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TabControl CheckpointTab;
        private TabPage tabPage1;
        private CheckBox LoadTimeCheckbox;
        private TabPage tabPage2;
        private Label label7;
        private Label label8;
        private TextBox SecondsTextBox;
        private Label SecondsLabel;
        private TextBox MinutesTextBox;
        private Label MinutesLabel;
        private TextBox HoursTextBox;
        private Label HoursLabel;
        private Label label12;
        private Label label13;
        private Button SimRateIncrButton;
        private Button SimRateDecrButton;
        private Button DisconnectButton;
        private Button ChangeTimeButton;
        private Label SecondsSaveLabel;
        private Label MinutesSaveLabel;
        private Label HoursSaveLabel;
        private TextBox SecondsSaveTextBox;
        private TextBox MinutesSaveTextBox;
        private TextBox HoursSaveTextBox;
        private TextBox RightFuelTankSaveTextBox;
        private TextBox LeftFuelTankSaveTextBox;
        private Button DeleteCheckpointButton;
        private Label label6;
        private TextBox MaxCapacityRightTank;
        private TextBox MaxCapacityLeftTank;
        private Label label9;
    }
}

