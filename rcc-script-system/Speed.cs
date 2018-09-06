using System;

namespace rcc_script_system
{
    public class Speed
    {
        public enum speedType
        {
           SIX_SECONDS = 6,
           SEVEN_SECONDS = 7,
           EIGHT_SECONDS = 8
        }

        public int getCount()
        {
            return Enum.GetNames(typeof(speedType)).Length;
        }

    }
}
