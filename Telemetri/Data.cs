using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telemetri
{
    public enum DataTypes
    {
        eINT,
        eFLOAT_1,
        eFLOAT_2,
        eFLOAT_3,
        eFLOAT_4,
        eString
    }

    public class Data
    {
        readonly public string name;
        readonly public string unit;
        readonly public string varName;
        readonly public DataTypes type;

        public Data(string name, string unit, string varName, DataTypes type)
        {
            this.name = name;
            this.unit = unit;
            this.varName = varName;
            this.type = type;
        }
    }    
}
