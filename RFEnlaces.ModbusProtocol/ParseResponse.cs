using RFEnlaces.ModbusProtocol.Attributes;
using Serilog;
using System;
using System.Reflection;

namespace RFEnlaces.ModbusProtocol
{
    public class ParseResponse
    {
        public static T ParseCoil<T>(bool[] response) where T : new()
        {
            T ret = new T();

            foreach (PropertyInfo p in ret.GetType().GetProperties())
            {
                if (p.GetCustomAttribute<ModbusRegister>() != null)
                {
                    if (p.GetCustomAttribute<ModbusRegister>().Type == ModbusType.CoilStatus ||
                        p.GetCustomAttribute<ModbusRegister>().Type == ModbusType.InputStatus)
                    {
                        try
                        {
                            p.SetValue(ret, response[p.GetCustomAttribute<ModbusRegister>().Address]);
                        }
                        catch (Exception ex)
                        {
                            Log.Error(ex, "ERROR: no se pudo parsear el coil para la propiedad {0} del tipo {1} en la clase {2}", p.Name, p.PropertyType, ret.GetType());
                        }
                    }
                }
            }

            return ret;
        }

        public static T ParseRegister<T>(ushort[] response) where T : new()
        {
            T ret = new T();

            foreach (PropertyInfo p in ret.GetType().GetProperties())
            {
                if (p.GetCustomAttribute<ModbusRegister>() != null)
                {
                    if (p.GetCustomAttribute<ModbusRegister>().Type == ModbusType.HoldingRegister ||
                        p.GetCustomAttribute<ModbusRegister>().Type == ModbusType.InputRegister)
                    {
                        try
                        {
                            p.SetValue(ret, response[p.GetCustomAttribute<ModbusRegister>().Address]);
                        }
                        catch (Exception ex) { }
                    }
                }
            }

            return ret;
        }
    }
}
