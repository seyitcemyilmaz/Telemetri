using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telemetri
{
    static class Log
    {       
        public enum Status
        {
            eNullPacket,
            eWrongPacketLength,
            eCorruptedPacket,
            eApprovedPacket,
        }
        
        static public void Write(Status status, string str = "")
        {
            if (status == Status.eNullPacket)
            {

            }
            else if (status == Status.eWrongPacketLength)
            {

            }
            else if (status == Status.eCorruptedPacket)
            {

            }
            else if (status == Status.eApprovedPacket)
            {

            }
            else
            {
                throw new System.Exception("WRONG STATUS");
            }
        }
    }
}
