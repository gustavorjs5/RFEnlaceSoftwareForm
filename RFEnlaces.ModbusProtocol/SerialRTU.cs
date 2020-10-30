using Modbus.Device;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;

namespace RFEnlaces.ModbusProtocol
{
    public class SerialRTU
    {
        static IModbusSerialMaster _master;
    
        static SerialPort _port;

        public SerialRTU(string comPort)
        {
            _port = new SerialPort(comPort);

            // configure serial port
            _port.BaudRate = 9600;
            _port.DataBits = 8;
            _port.Parity = Parity.None;
            _port.StopBits = StopBits.One;
            _port.Open();
            
            // create modbus master
            _master = ModbusSerialMaster.CreateRtu(_port);
            _master.Transport.ReadTimeout = 2000;
            _master.Transport.Retries = 0;

            _master.Transport.CheckFrame = true;
        }

        public void Close()
        {
            _port.Close();
            _master.Dispose();
        }

        public ushort[] ReadHoldingRegister(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            Log.Debug("GET ReadHoldingRegisters: SlaveAddress {0}, StartAddress {1}, NumberOfPoints {2}", slaveAddress, startAddress, numberOfPoints);

            try
            {
                var response = _master.ReadHoldingRegisters(slaveAddress, startAddress, numberOfPoints);
                Log.Debug("RESPONSE ReadHoldingRegisters: {0}", String.Join(",", response));
                return response;
            }
            catch (Exception ex)
            {
              //  return new ushort[] { Convert.ToUInt16(new Random().Next(2, 4)) };
                Log.Error(ex, "ERROR: ReadHoldingRegisters: SlaveAddress {0}, StartAddress {1}, NumberOfPoints {2} - MSG: {3}", slaveAddress, startAddress, numberOfPoints, ex.Message);
                throw ex;
            }
        }

        public ushort[] ReadInputRegister(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            Log.Debug("GET ReadInputRegister: SlaveAddress {0}, StartAddress {1}, NumberOfPoints {2}", slaveAddress, startAddress, numberOfPoints);

            try
            {
                var response = _master.ReadInputRegisters(slaveAddress, startAddress, numberOfPoints);
                Log.Debug("RESPONSE ReadInputRegister: {0}", String.Join(",", response));
                return response;
            }
            catch(Exception ex)
            {
                Log.Error(ex, "ERROR: ReadInputRegister: SlaveAddress {0}, StartAddress {1}, NumberOfPoints {2} - MSG: {3}", slaveAddress, startAddress, numberOfPoints, ex.Message);
                throw ex;
            }
        }

        public bool[] ReadCoils(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            Log.Debug("GET ReadCoils: SlaveAddress {0}, StartAddress {1}, NumberOfPoints {2}", slaveAddress, startAddress, numberOfPoints);
            try
            {
                var response = _master.ReadCoils(slaveAddress, startAddress, numberOfPoints);
                Log.Debug("RESPONSE ReadCoils: {0}", String.Join(",", response));
                return response;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "ERROR: ReadCoils: SlaveAddress {0}, StartAddress {1}, NumberOfPoints {2} - MSG: {3}", slaveAddress, startAddress, numberOfPoints, ex.Message);
                throw ex;
            }
        }

        public void WriteSingleInput(byte slaveAddress, ushort address, bool value)
        {
            Log.Debug("WriteSingleInput: SlaveAddress {0}, Address {1}, Value {2}", slaveAddress, address, value);
            try
            {
                _master.WriteSingleCoilAsync(slaveAddress, address, value);
                Log.Debug("RESPONSE WriteSingleCoil: NO ERROR");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "ERROR: WriteSingleCoil: SlaveAddress {0}, Address {1}, Value {2} - MSG: {3}", slaveAddress, address, value, ex.Message);
                throw ex;
            }
        }

        public void WriteSingleRegister(byte slaveAddress, ushort address, ushort value)
        {
            Log.Debug("WriteSingleRegister: SlaveAddress {0}, Address {1}, Value {2}", slaveAddress, address, value);
            try
            {
                _master.WriteSingleRegisterAsync(slaveAddress, address, value);
                Log.Debug("RESPONSE WriteSingleRegister: NO ERROR");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "ERROR: WriteSingleRegister: SlaveAddress {0}, Address {1}, Value {2} - MSG: {3}", slaveAddress, address, value, ex.Message);
                throw ex;
            }
        }

        public void WriteMultipleRegisters(byte slaveAddress, ushort address, ushort[] values)
        {
            Log.Debug("WriteMultipleRegisters: SlaveAddress {0}, Address {1}, Values {2}", slaveAddress, address, String.Join(",", values));
            try
            {
                _master.WriteMultipleRegistersAsync(slaveAddress, address, values);
                Log.Debug("RESPONSE WriteMultipleRegisters: NO ERROR");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "ERROR: WriteMultipleRegisters: SlaveAddress {0}, Address {1}, Values {2} - MSG: {3}", slaveAddress, address, String.Join(",", values), ex.Message);
                throw ex;
            }
        }
    }
}
