using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialDeviceSimulator
{
    public static class BValues
    {
        public static string alarm;
        public static string P1;
        public static string QS2;
        public static string QS2TempCompensated;
        public static string QS3;
        public static string QS3TempCompensated;
        public static string QS4;
        public static string QS4TempCompensated;
        public static string TOC;
        public static string TS2;
        public static string TS3;
        public static string TS4;
        public static string UVString;
        public static string V3String;
        public static string V4String;
        public static string V5String;
        public static string Varient;
        public static string Version;


        public static bool UV;
        public static bool V3;
        public static bool V4;
        public static bool V5;

        public static string V3ReturnState(bool enabled)
        {
            if (enabled == true)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }
        public static string V4ReturnState(bool enabled)
        {
            if (enabled == true)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }
        public static string V5ReturnState(bool enabled)
        {
            if (enabled == true)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }
        public static string UVReturnState(bool enabled)
        {
            if (enabled == true)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }

    }
}
