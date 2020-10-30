using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RFEnlaces.ModbusProtocol.Attributes
{
    public enum ModbusType
    {
        HoldingRegister,
        InputRegister,
        InputStatus,
        CoilStatus
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class ModbusRegister : Attribute
    {
        public ushort Address { get; set; }
        public ModbusType Type { get; set; }

        public static ushort GetAddress<T>(string propertyName)
        {
            ushort ret = 0;

            foreach (PropertyInfo p in typeof(T).GetProperties())
            {
                if ((p.Name == propertyName) && (p.GetCustomAttribute<ModbusRegister>() != null))
                {
                    ret = p.GetCustomAttribute<ModbusRegister>().Address;
                    break;
                }
            }

            return ret;
        }
    }
}
