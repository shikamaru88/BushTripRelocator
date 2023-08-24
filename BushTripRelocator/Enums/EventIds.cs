using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BushTripRelocator.Enums
{
    public enum EVENT_IDS
    {
        CLOCK_HOURS_SET,
        CLOCK_MINUTES_SET,
        CLOCK_SECONDS_SET,
        SIM_RATE_INCR,
        SIM_RATE_DECR,

        //ColdAndDarkEvents
        NAV_LIGHTS_OFF,
        LANDING_LIGHTS_OFF,
        BEACON_LIGHTS_OFF,
        STROBES_OFF,
        TAXI_LIGHTS_OFF,
        PITOT_HEAT_OFF,
        AVIONICS_MASTER_1_OFF,
        ALTERNATOR_OFF,
        MASTER_BATTERY_OFF,
        MIXTURE_LEAN,
        MAGNETO_OFF,
        FLAPS_UP,
        FUEL_SELECTOR_1_OFF,
        FUEL_SELECTOR_2_OFF,
        PROP_PITCH_HI
    }
}
