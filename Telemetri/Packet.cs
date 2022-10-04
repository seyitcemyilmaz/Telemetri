using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telemetri
{
    static class Packet
    {
        public const int batteryCount = 20;
        static public int variableCount;
        static public List<Data> datas;
        public enum Indexes
        {
            timeIndex = 0,
            speedIndex,
            maxTemperatureIndex,
            totalVoltageIndex,
            remainingEnergyIndex,
            stateOfChargeIndex,
            currentIndex,
            batteryVoltagesStartIndex,
            batteryVoltagesEndIndex = batteryVoltagesStartIndex + batteryCount - 1,
            checksumIndex
        };

        static public string time;
        static public string speed;
        static public string maxTemperature;
        static public string totalVoltage;
        static public string remainingEnergy;
        static public string stateOfCharge;
        static public string current;
        static public string[] batteryVoltages = new string[batteryCount];
        static public string checksum;
    }
}
