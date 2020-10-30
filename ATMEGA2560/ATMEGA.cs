using EasyModbus;
using RFEnlaces.EasyModbus;
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
using static MfgControl.AdvancedHMI.Controls.PushButton;

namespace ATMEGA
{
    public partial class ATMEGA : Form
    {
        private static EasyModbusRTU _modbusMaster = null;
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
                }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_modbusMaster == null|| _modbusMaster.Connected()==false )
                _modbusMaster = new EasyModbusRTU(comboBox1.SelectedItem.ToString());
            timer1.Start();

            button1.Enabled = false;
            btnDesconectar.Enabled = true;
            button1.BackColor = Color.Green;
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
                actualizar_INA1();
            }

        }
      
     

        private void actualizar_INA1 ()
        {
            var Valor = _modbusMaster.ReadInputRegister(3, 21, 12);
            if (Valor!= null)
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


        }

        private void Actualizar_InDigitales()
        {

           

            var Valor = _modbusMaster.ReadDiscreteInputs(3,0, 8);

            if (Valor!=null)
            {
                consultaHabilitada = true;
                motor1.Value = !Valor[0];
                motor2.Value = !Valor[1];
                motor3.Value = !Valor[2];
                motor4.Value = !Valor[3];
                waterPump1.Value = !Valor[4];
                waterPump2.Value = !Valor[5];
                waterPump3.Value = !Valor[6];
                waterPump4.Value = !Valor[7];
            }
            consultaHabilitada = true;
        



        }

        private void EscribirSalida(int registro,int valor)
        {



             _modbusMaster.WriteSingleRegister(3,registro, valor);
         
            
            //motor1.Value = Valor[0].ToString();
            //motor2.Value = Valor[1].ToString();
            //motor3.Value = Valor[2].ToString();
            //motor4.Value = Valor[3].ToString();
            //waterPump1.Value = Valor[4].ToString();
            //waterPump2.Value = Valor[5].ToString();
            //waterPump3.Value = Valor[6].ToString();
            //waterPump4.Value = Valor[7].ToString();



        }

        private void momentaryButton1_Click(object sender, EventArgs e)
        {
            var mb = momentaryButton1.ButtonColor;
            if(mb == ButtonColors.Red)
            {
              momentaryButton1.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
                EscribirSalida(0, 1);
            }
            else
            {
                momentaryButton1.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
                EscribirSalida(0, 0);
            }
          
        }

        private void momentaryButton8_Click(object sender, EventArgs e)
        {
            var mb = momentaryButton8.ButtonColor;
            if (mb == ButtonColors.Red)
            {
                momentaryButton8.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
                EscribirSalida(4, 1);
            }
            else
            {
                momentaryButton8.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
                EscribirSalida(4, 0);
            }
        }

        private void momentaryButton2_Click(object sender, EventArgs e)
        {
            var mb = momentaryButton2.ButtonColor;
            if (mb == ButtonColors.Red)
            {
                momentaryButton2.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
                EscribirSalida(1, 1);
            }
            else
            {
                momentaryButton2.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
                EscribirSalida(1, 0);
            }
        }

        private void momentaryButton3_Click(object sender, EventArgs e)
        {
            var mb = momentaryButton3.ButtonColor;
            if (mb == ButtonColors.Red)
            {
                momentaryButton3.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
                EscribirSalida(2, 1);
            }
            else
            {
                momentaryButton3.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
                EscribirSalida(2, 0);
            }
        }

        private void momentaryButton4_Click(object sender, EventArgs e)
        {
            var mb = momentaryButton4.ButtonColor;
            if (mb == ButtonColors.Red)
            {
                momentaryButton4.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
                EscribirSalida(3, 1);
            }
            else
            {
                momentaryButton4.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
                EscribirSalida(3, 0);
            }
        }

        private void momentaryButton7_Click(object sender, EventArgs e)
        {
            var mb = momentaryButton7.ButtonColor;
            if (mb == ButtonColors.Red)
            {
                momentaryButton7.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
                EscribirSalida(5, 1);
            }
            else
            {
                momentaryButton7.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
                EscribirSalida(5, 0);
            }
        }

        private void momentaryButton6_Click(object sender, EventArgs e)
        {
            var mb = momentaryButton6.ButtonColor;
            if (mb == ButtonColors.Red)
            {
                momentaryButton6.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
                EscribirSalida(6, 1);
            }
            else
            {
                momentaryButton6.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
                EscribirSalida(6, 0);
            }
        }

        private void momentaryButton5_Click(object sender, EventArgs e)
        {
            var mb = momentaryButton5.ButtonColor;
            if (mb == ButtonColors.Red)
            {
                momentaryButton5.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
                EscribirSalida(7, 1);
            }
            else
            {
                momentaryButton5.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
                EscribirSalida(7, 0);
            }
        }

        private void momentaryButton12_Click(object sender, EventArgs e)
        {
            var mb = momentaryButton12.ButtonColor;
            if (mb == ButtonColors.Red)
            {
                momentaryButton12.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
                EscribirSalida(8, 1);
            }
            else
            {
                momentaryButton12.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
                EscribirSalida(8, 0);
            }
        }

        private void momentaryButton11_Click(object sender, EventArgs e)
        {
            var mb = momentaryButton11.ButtonColor;
            if (mb == ButtonColors.Red)
            {
                momentaryButton11.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
                EscribirSalida(9, 1);
            }
            else
            {
                momentaryButton11.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
                EscribirSalida(9, 0);
            }
        }

        private void momentaryButton10_Click(object sender, EventArgs e)
        {
            var mb = momentaryButton10.ButtonColor;
            if (mb == ButtonColors.Red)
            {
                momentaryButton10.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
                EscribirSalida(10, 1);
            }
            else
            {
                momentaryButton10.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
                EscribirSalida(10, 0);
            }
        }

        private void momentaryButton9_Click(object sender, EventArgs e)
        {
            var mb = momentaryButton9.ButtonColor;
            if (mb == ButtonColors.Red)
            {
                momentaryButton9.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
                EscribirSalida(11, 1);
            }
            else
            {
                momentaryButton9.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
                EscribirSalida(11, 0);
            }
        }

        private void momentaryButton20_Click(object sender, EventArgs e)
        {
            var mb = momentaryButton20.ButtonColor;
            if (mb == ButtonColors.Red)
            {
                momentaryButton20.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
                EscribirSalida(12, 1);
            }
            else
            {
                momentaryButton20.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
                EscribirSalida(12, 0);
            }
        }

        private void momentaryButton19_Click(object sender, EventArgs e)
        {
            var mb = momentaryButton19.ButtonColor;
            if (mb == ButtonColors.Red)
            {
                momentaryButton19.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
                EscribirSalida(13, 1);
            }
            else
            {
                momentaryButton19.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
                EscribirSalida(13, 0);
            }
        }

        private void momentaryButton18_Click(object sender, EventArgs e)
        {
            var mb = momentaryButton18.ButtonColor;
            if (mb == ButtonColors.Red)
            {
                momentaryButton18.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
                EscribirSalida(14, 1);
            }
            else
            {
                momentaryButton18.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
                EscribirSalida(14, 0);
            }
        }

        private void momentaryButton17_Click(object sender, EventArgs e)
        {
            var mb = momentaryButton17.ButtonColor;
            if (mb == ButtonColors.Red)
            {
                momentaryButton17.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
                EscribirSalida(15, 1);
            }
            else
            {
                momentaryButton17.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
                EscribirSalida(15, 0);
            }
        }

        private void momentaryButton16_Click(object sender, EventArgs e)
        {
            var mb = momentaryButton16.ButtonColor;
            if (mb == ButtonColors.Red)
            {
                momentaryButton16.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
                EscribirSalida(16, 1);
            }
            else
            {
                momentaryButton16.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
                EscribirSalida(16, 0);
            }
        }

        private void momentaryButton15_Click(object sender, EventArgs e)
        {
            var mb = momentaryButton15.ButtonColor;
            if (mb == ButtonColors.Red)
            {
                momentaryButton15.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
                EscribirSalida(17, 1);
            }
            else
            {
                momentaryButton15.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
                EscribirSalida(17, 0);
            }
        }

        private void momentaryButton14_Click(object sender, EventArgs e)
        {
            var mb = momentaryButton14.ButtonColor;
            if (mb == ButtonColors.Red)
            {
                momentaryButton14.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
                EscribirSalida(18, 1);
            }
            else
            {
                momentaryButton14.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
                EscribirSalida(18, 0);
            }
        }

        private void momentaryButton13_Click(object sender, EventArgs e)
        {
            var mb = momentaryButton13.ButtonColor;
            if (mb == ButtonColors.Red)
            {
                momentaryButton13.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
                EscribirSalida(19, 1);
            }
            else
            {
                momentaryButton13.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
                EscribirSalida(19, 0);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            _modbusMaster.Close();
            button1.Enabled = true;
            btnDesconectar.Enabled = false;
            button1.BackColor = Color.Transparent;
        }

        private void ATMEGA_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_modbusMaster !=null)
               _modbusMaster.Close();
        }
    }
}
