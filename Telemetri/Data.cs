namespace Telemetri
{
    public enum DataTypes
    {
        eINT,           // 3
        eFLOAT_1,       // 3 + 1 + 1
        eFLOAT_2,       // 3 + 1 + 2
        eFLOAT_3,       // 3 + 1 + 3
        eCHECKSUM,      // 8
        eTIME           // 8 -> 08:11:51
    }

    public class Data
    {
        readonly public string name;
        readonly public string unit;
        readonly public string varName;
        readonly public DataTypes type;
        public string value;

        public Data(string name, string unit, string varName, DataTypes type)
        {
            this.name = name;
            this.unit = unit;
            this.varName = varName;
            this.type = type;
        }

        static public int GetDataLength(DataTypes dataType)
        {
            switch (dataType)
            {
                case DataTypes.eINT:
                    return 3;
                case DataTypes.eFLOAT_1:
                    return 5;
                case DataTypes.eFLOAT_2:
                    return 6;
                case DataTypes.eFLOAT_3:
                    return 7;
                case DataTypes.eCHECKSUM:
                    return 8;
                case DataTypes.eTIME:
                    return 8;
                default:
                    throw new System.Exception("WRONG DATA FORMAT");
            }
        }
    }

}
