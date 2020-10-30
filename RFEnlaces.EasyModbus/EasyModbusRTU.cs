using EasyModbus;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFEnlaces.EasyModbus
{
    public class EasyModbusRTU
    {
        static ModbusClient _master;

       

        public EasyModbusRTU(string comPort)
        {

            _master = new ModbusClient(comPort);

            // configure serial port
            _master.Baudrate = 9600;
            _master.Parity = Parity.None;
            _master.StopBits = StopBits.One;
            _master.ConnectionTimeout = 500;
            _master.Connect();

        }

        public void Close()
        {
            _master.Disconnect();
        }

        public bool Connected()
        {
           return _master.Connected;
        }
        public bool[] ReadDiscreteInputs(byte slaveAddress, int startAddress, int numberOfPoints)
        {
            Log.Debug("GET ReadDiscreteInputs: SlaveAddress {0}, StartAddress {1}, NumberOfPoints {2}", slaveAddress, startAddress, numberOfPoints);

            try
            {
                _master.UnitIdentifier = slaveAddress;
                var response = _master.ReadDiscreteInputs(startAddress, numberOfPoints);

                Log.Debug("RESPONSE ReadHoldingRegisters: {0}", String.Join(",", response));
                return response;
            }
            catch (Exception ex)
            {
                //  return new ushort[] { Convert.ToUInt16(new Random().Next(2, 4)) };
                Log.Error(ex, "ERROR: ReadHoldingRegisters: SlaveAddress {0}, StartAddress {1}, NumberOfPoints {2} - MSG: {3}", slaveAddress, startAddress, numberOfPoints, ex.Message);
                //throw ex;
                return null;

            }
        }

        public int[] ReadInputRegister(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            Log.Debug("GET ReadInputRegister: SlaveAddress {0}, StartAddress {1}, NumberOfPoints {2}", slaveAddress, startAddress, numberOfPoints);

            try
            {
                _master.UnitIdentifier = slaveAddress;
                var response = _master.ReadInputRegisters(startAddress, numberOfPoints);
                Log.Debug("RESPONSE ReadInputRegister: {0}", String.Join(",", response));
                return response;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "ERROR: ReadInputRegister: SlaveAddress {0}, StartAddress {1}, NumberOfPoints {2} - MSG: {3}", slaveAddress, startAddress, numberOfPoints, ex.Message);
                //throw ex;
                return null;

            }
        }

        public void WriteSingleRegister(byte slaveAddress, int startAddress, int numberOfPoints)
        {
            Log.Debug("GET ReadCoils: SlaveAddress {0}, StartAddress {1}, NumberOfPoints {2}", slaveAddress, startAddress, numberOfPoints);
            try
            {
                _master.WriteSingleRegister(startAddress, numberOfPoints);
                Log.Debug("RESPONSE WriteSingleRegister: NO ERROR");

            }
            catch (Exception ex)
            {
                Log.Error(ex, "ERROR: WriteSingleRegister: SlaveAddress {0}, StartAddress {1}, NumberOfPoints {2} - MSG: {3}", slaveAddress, startAddress, numberOfPoints, ex.Message);
               // throw ex;

            }
        }

    }
}
