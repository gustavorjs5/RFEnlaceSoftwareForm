using EasyModbus;
using RFEnlaces.ModbusProtocol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ATMEGA
{
    public partial class ATMEGA : Form
    {
        private static SerialRTU _modbusMaster = null;
        private static ModbusClient modbusClient = null;
        private static bool consultaHabilitada = false;
        delegate void delegado(ushort[] valor);
        delegate void delegadoAnalogia(bool[] valor);



        public ATMEGA()
        {
            InitializeComponent();
        }



        private void ATMEGA_Load(object sender, EventArgs e)
        {
            var serial = System.IO.Ports.SerialPort.GetPortNames();
            //if (serial.Length==0)
            //{
            //    MessageBox.Show("Sin puerto abiertos.");
            //}
            consultaHabilitada = true;
            comboBox1.DataSource = serial;
           



            ;        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (consultaHabilitada)
            {
                // Task.Run(new Action(ReadAnalogicas4));
                //Task.Run(new Action(ReadAnalogicas5));
                //Task.Run(new Action(Tank));
                //  Task.Run(new Action());
                Actualizar_InDigitales();
            }

        }
      
        private void Tank()
        {
            try
            {

                var responseReadAnalog = _modbusMaster.ReadInputRegister(3, 0, 12);
                delegado MD = new delegado(actualizar_INA1);
                this.Invoke(MD,  responseReadAnalog );

                consultaHabilitada = true;
            }
            catch (Exception ex)
            {
                consultaHabilitada = true;
            }
        }

        private void EntradasDigitales()
        {
            try
            {



              ////  var responseReadDigital = _modbusMaster.ReadInputRegister(3, 0, 8);
              //  delegadoAnalogia MD = new delegadoAnalogia(Actualizar_InDigitales);
              //  this.Invoke(MD, m);

                consultaHabilitada = true;
            }
            catch (Exception ex)
            {
                consultaHabilitada = true;
            }
        }


        private void actualizar_INA1 (ushort[] Valor)
        {
       
            analogValueDisplay1.Value = Valor[0].ToString();
            analogValueDisplay2.Value = Valor[1].ToString();
            analogValueDisplay3.Value = Valor[2].ToString();
            analogValueDisplay4.Value = Valor[3].ToString();
            analogValueDisplay5.Value = Valor[4].ToString();
            analogValueDisplay6.Value = Valor[5].ToString();
            analogValueDisplay7.Value = Valor[6].ToString();
            analogValueDisplay8.Value = Valor[7].ToString();
            analogValueDisplay9.Value = Valor[8].ToString();
            analogValueDisplay10.Value = Valor[9].ToString();
            analogValueDisplay11.Value = Valor[10].ToString();
            analogValueDisplay12.Value = Valor[11].ToString();

        }

        private void Actualizar_InDigitales()
        {

           

            var m = modbusClient.ReadDiscreteInputs(0, 8);
            consultaHabilitada = true;
            //motor1.Value = Valor[0].ToString();
            //motor2.Value = Valor[1].ToString();
            //motor3.Value = Valor[2].ToString();
            //motor4.Value = Valor[3].ToString();
            //waterPump1.Value = Valor[4].ToString();
            //waterPump2.Value = Valor[5].ToString();
            //waterPump3.Value = Valor[6].ToString();
            //waterPump4.Value = Valor[7].ToString();



        }
        private void actulizarBomb(int valor)
        {
          
        }

        private void ATMEGA_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if (_modbusMaster == null)
            // _modbusMaster = new RFEnlaces.ModbusProtocol.SerialRTU(comboBox1.SelectedItem.ToString());
            modbusClient = new ModbusClient("COM3");
            modbusClient.UnitIdentifier = 3;
            modbusClient.Parity = System.IO.Ports.Parity.None;
            modbusClient.StopBits = System.IO.Ports.StopBits.One;
            modbusClient.ConnectionTimeout = 500;
            modbusClient.Connect();

            timer1.Start();
        }

       
    }
}
