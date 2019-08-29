using Microsoft.VisualStudio.TestTools.UnitTesting;
using SerialDeviceSimulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRC32 = SerialDeviceSimulator.CRC32;


namespace SerialDeviceSimulator.Tests
{
    [TestClass()]
    public class CRC32Tests
    {
        [TestMethod()]
        public void CalculateCRC32Test()
        {
            const string testData = "123456789";

            UInt32 checksum = 0;

            for (UInt32 i = 0; i < testData.Length; i++)
            {
                checksum = CRC32.CalculateCRC32(checksum, Convert.ToByte(testData[checked((int)i)]));
            }

            Assert.AreEqual(0xE3069283, checksum);
        }

        [TestMethod()]
        public void CalculateCRC32Test2()
        {
            const string testData = "Hello, World!";

            UInt32 checksum = 0;

            for (UInt32 i = 0; i < testData.Length; i++)
            {
                checksum = CRC32.CalculateCRC32(checksum, Convert.ToByte(testData[checked((int)i)]));
            }

            Assert.AreEqual(0x4D551068u, checksum);
        }
    }
}