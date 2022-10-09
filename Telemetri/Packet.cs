using System.Collections.Generic;
using System.Linq;

namespace Telemetri
{
    static class Packet
    {
        public const int batteryCount = 20;

        static public Dictionary<Indexes, Data> datas;
        static public string[] batteryVoltages = new string[batteryCount];
        static public DataTypes batteryVoltageFormat;
        static public string checksum;
        static public DataTypes checksumFormat;
        static public int packetLength;
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
            checksumIndex = batteryVoltagesEndIndex + 1
        };


        static public int GetTotalVariableCount()
        {
            return batteryCount + datas.Count + 1;
        }

        static public void CalculatePacketLength()
        {
            Data[] variables = datas.Values.ToArray();

            packetLength = 0;

            for (int i = 0; i < variables.Length; i++)
            {
                packetLength += Data.GetDataLength(variables[i].type);
            }

            packetLength += batteryCount * Data.GetDataLength(batteryVoltageFormat);
            packetLength += Data.GetDataLength(checksumFormat);
            packetLength += GetTotalVariableCount() - 1;
        }
    }
}
