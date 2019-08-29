using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialDeviceSimulator
{
    public static class CRC32
    {
        const UInt32 CRCPolynomial = 0x82f63b78;

        public static UInt32 CalculateCRC32(UInt32 crc, byte data)
        {
            crc = ~crc;
            crc ^= data;

            for (int i = 0; i < 8; i++)
                crc = (crc & 1 ) > 0 ? (crc >> 1) ^ CRCPolynomial : crc >> 1;

            return ~crc;
        }
    }
}
