using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedHMIcs3flagSerial
{
    public partial class MainForm : Form
    {
        private static RFEnlaces.ModbusProtocol.SerialRTU _modbusMaster = null;
        private static ushort[] response;
        private static bool consultaHabilitada = false;
        private static bool primeraEntrada = true;
        private static bool flagErrorConexion = true;
        private static char[] valorInicial_1 = { '0', '0', '0', '0', '0', '0', '0', '0' };
        private static char[] valorInicial_2 = { '0', '0', '0', '0', '0', '0', '0', '0' };
        private static char[] valorInicial_3 = { '0', '0', '0', '0', '0', '0', '0', '0' };
        private static byte direccion_1 = 1;
        private static byte direccion_2 = 2;
        private static byte direccion_3 = 3;


        private static int ReadAnalogicas = 4;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var serial = System.IO.Ports.SerialPort.GetPortNames();
            //if (serial.Length==0)
            //{
            //    MessageBox.Show("Sin puerto abiertos.");
            //}

            cboSeleccionPuerto.DataSource = serial;
            //txtCSVFile.Text = Properties.Settings.Default.CSVFile;
            //chkOneByDay.Checked = Properties.Settings.Default.OneByDay;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_modbusMaster == null)
                    _modbusMaster = new RFEnlaces.ModbusProtocol.SerialRTU(cboSeleccionPuerto.SelectedItem.ToString());

                AdvancedHMICS3Flag.Properties.Settings.Default.COM = cboSeleccionPuerto.SelectedItem.ToString();

                //tsslEstadoConexion.Text = "Conectando con el equipo...";
                //tsslEstadoConexion.ForeColor = System.Drawing.Color.Orange;

                consultaHabilitada = true;

                // Consultar();

                btnConectar.Enabled = false;
                cboSeleccionPuerto.Enabled = false;

                timer1.Enabled = true;
               timer2.Enabled = true;
                //timer3.Enabled = true;
            }
            catch (Exception ex)
            {
                _modbusMaster = null;

                consultaHabilitada = false;

                timer1.Enabled = false;

                //tsslEstadoConexion.Text = "ERROR - No se puede conectar con el puerto";
                //tsslEstadoConexion.ForeColor = System.Drawing.Color.Red;

                //ResetEnable(false);

                //Serilog.Log.Logger.Error(ex, "Conectar");
            }
        }



        private void btnRele1_Click(object sender, EventArgs e)
        {
            if (valorInicial_1[7] == '0')
            {
                valorInicial_1[7] = '1';
                // _modbusMaster.WriteSingleRegister(1, 1, (ushort)Convert.ToInt32(new string(valorInicial), 2));

                //btnRele1.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
            }
            else
            {
                valorInicial_1[7] = '0';
                //  _modbusMaster.WriteSingleRegister(1, 1, (ushort)Convert.ToInt32(new string(valorInicial), 2));

                //btnRele1.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
            }

        }

        private void btnRele2_Click(object sender, EventArgs e)
        {
            if (valorInicial_1[6] == '0')
            {
                valorInicial_1[6] = '1';
                //string str = new string(valorInicial);
                // var i = (ushort)Convert.ToInt32(new string(valorInicial), 2);
                //     _modbusMaster.WriteSingleRegister(1, 1, (ushort)Convert.ToInt32(new string(valorInicial), 2));
                //btnRele2.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;


            }
            else
            {
                valorInicial_1[6] = '0';
                // _modbusMaster.WriteSingleRegister(1, 1, (ushort)Convert.ToInt32(new string(valorInicial), 2));
                //btnRele2.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;


            }
        }

        private void btnRele3_Click(object sender, EventArgs e)
        {
            if (valorInicial_1[5] == '0')
            {
                valorInicial_1[5] = '1';
                // _modbusMaster.WriteSingleRegister(1, 1, (ushort)Convert.ToInt32(new string(valorInicial), 2));

                //btnRele3.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;


            }
            else
            {
                valorInicial_1[5] = '0';
                //   _modbusMaster.WriteSingleRegister(1, 1, (ushort)Convert.ToInt32(new string(valorInicial), 2));

                //btnRele3.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;


            }

        }

        private void btnRele4_Click(object sender, EventArgs e)
        {
            if (valorInicial_1[4] == '0')
            {
                valorInicial_1[4] = '1';
                //   _modbusMaster.WriteSingleRegister(1, 1, (ushort)Convert.ToInt32(new string(valorInicial), 2));

                //btnRele4.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;


            }
            else
            {
                valorInicial_1[4] = '0';
                //    _modbusMaster.WriteSingleRegister(1, 1, (ushort)Convert.ToInt32(new string(valorInicial), 2));

                //btnRele4.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;


            }


        }

        private void btnOnAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < valorInicial_1.Length; i++)
            {
                valorInicial_1[i] = '1';
            }
            //  _modbusMaster.WriteSingleRegister(1, 1, (ushort)Convert.ToInt32(new string(valorInicial), 2));

            //btnRele1.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
            //btnRele2.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
            //btnRele3.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
            //btnRele4.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
        }

        private void btnOffAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < valorInicial_1.Length; i++)
            {
                valorInicial_1[i] = '0';
            }
            //  _modbusMaster.WriteSingleRegister(1, 1, (ushort)Convert.ToInt32(new string(valorInicial), 2));

            //btnRele1.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
            //btnRele2.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
            //btnRele3.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
            //btnRele4.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (consultaHabilitada)
            {
                // Task.Run(new Action(ReadAnalogicas4));
                //Task.Run(new Action(ReadAnalogicas5));
                //Task.Run(new Action(ReadDigital));
                Task.Run(new Action(Circuito_1));
                Task.Run(new Action(Circuito_2));
                Task.Run(new Action(Circuito_3));





            }

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (consultaHabilitada)
            {


                Task.Run(new Action(Circuito_1_Digitales));

                Task.Run(new Action(Circuito_2_Digitales));

                Task.Run(new Action(Circuito_3_Digitales));
                // Task.Run(new Action(ReadAnalogicas4));
                //Task.Run(new Action(ReadAnalogicas5));o
                //Task.Run(new Action(ReadDigital));
                // Task.Run(new Action(Circuito_2));
                //    Task.Run(new Action(Circuito_2));
                //Task.Run(new Action(Circuito_3));


            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (consultaHabilitada)
            {
                // Task.Run(new Action(ReadAnalogicas4));
                //Task.Run(new Action(ReadAnalogicas5));
                //Task.Run(new Action(ReadDigital));
              //  Task.Run(new Action(Circuito_3));
                // Task.Run(new Action(Circuito_2));
//                Task.Run(new Action(Circuito_3));


            }
        }

        private void Circuito_1()
        {
            try
            {
               // string path = @"C:\Users\Usuario\Documents\log\";
               // System.IO.File.WriteAllText(path + direccion_1.ToString() + "_" + new string(valorInicial_1) + "_" + Guid.NewGuid() + ".txt", new string(valorInicial_1));

                _modbusMaster.WriteSingleRegister(direccion_1, 1, (ushort)Convert.ToInt32(new string(valorInicial_1), 2));
              //  Circuito_1_Digitales();
               // string path = @"C:\Users\Usuario\Documents\log\";
             //   System.IO.File.WriteAllText(path+ direccion_1.ToString()+"_"+ new string(valorInicial_1) + "_"+Guid.NewGuid()+".txt", new string(valorInicial_1));

                //var responseReadDigital_1 = _modbusMaster.ReadHoldingRegister(direccion_1, 0, 1);


                //if (responseReadDigital_1[0] == 3)
                //{
                //    pilotLight1_1.Value = false;
                //    pilotLight2_1.Value = false;
                //}
                //if (responseReadDigital_1[0] == 0)
                //{
                //    pilotLight1_1.Value = true;
                //    pilotLight2_1.Value = true;
                //}
                //if (responseReadDigital_1[0] == 1)
                //{
                //    pilotLight1_1.Value = true;
                //    pilotLight2_1.Value = false;
                //}
                //if (responseReadDigital_1[0] == 2)
                //{
                //    pilotLight1_1.Value = false;
                //    pilotLight2_1.Value = true;
                //}

                //Circuito_2();

                consultaHabilitada = true;
            }
            catch (Exception ex)
            {
              //  Circuito_1();
               // Circuito_3();

                //  MessageBox.Show(ex.Message);
                consultaHabilitada = true;
            }
        }
        private void Circuito_1_Digitales()
        {
            try
            {
                //_modbusMaster.WriteSingleRegister(direccion_1, 1, (ushort)Convert.ToInt32(new string(valorInicial_1), 2));

                var responseReadDigital_1 = _modbusMaster.ReadHoldingRegister(direccion_1, 0, 1);


                if (responseReadDigital_1[0] == 3)
                {
                    pilotLight1_1.Value = false;
                    pilotLight2_1.Value = false;
                }
                if (responseReadDigital_1[0] == 0)
                {
                    pilotLight1_1.Value = true;
                    pilotLight2_1.Value = true;
                }
                if (responseReadDigital_1[0] == 1)
                {
                    pilotLight1_1.Value = true;
                    pilotLight2_1.Value = false;
                }
                if (responseReadDigital_1[0] == 2)
                {
                    pilotLight1_1.Value = false;
                    pilotLight2_1.Value = true;
                }

                Circuito_2_Digitales();
                Circuito_3_Digitales();
                //  Circuito_2();

                consultaHabilitada = true;
            }
            catch (Exception ex)
            {
             //   Circuito_1();
                // Circuito_3();

                //  MessageBox.Show(ex.Message);
                consultaHabilitada = true;
            }
        }
        private void Circuito_2()
        {
            try
            {

                _modbusMaster.WriteSingleRegister(direccion_2, 1, (ushort)Convert.ToInt32(new string(valorInicial_2), 2));

                //var responseReadDigital_2 = _modbusMaster.ReadHoldingRegister(direccion_2, 0, 1);

                //if (responseReadDigital_2[0] == 3)
                //{
                //    pilotLight1_2.Value = false;
                //    pilotLight2_2.Value = false;
                //}
                //if (responseReadDigital_2[0] == 0)
                //{
                //    pilotLight1_2.Value = true;
                //    pilotLight2_2.Value = true;
                //}
                //if (responseReadDigital_2[0] == 1)
                //{
                //    pilotLight1_2.Value = true;
                //    pilotLight2_2.Value = false;
                //}
                //if (responseReadDigital_2[0] == 2)
                //{
                //    pilotLight1_2.Value = false;
                //    pilotLight2_2.Value = true;
                //}


                consultaHabilitada = true;
               // Circuito_3();
            }
            catch (Exception ex)
            {
              //  Circuito_2();
              //  MessageBox.Show(ex.Message);
                consultaHabilitada = true;
            }
        }
        private void Circuito_2_Digitales()
        {
            try
            {

                // _modbusMaster.WriteSingleRegister(direccion_2, 1, (ushort)Convert.ToInt32(new string(valorInicial_2), 2));
                var responseReadDigital_2 = _modbusMaster.ReadHoldingRegister(direccion_2, 0, 1);

                //  var responseReadDigital_2 = _modbusMaster.ReadHoldingRegister(direccion_2, 0, 1);

                if (responseReadDigital_2[0] == 3)
                {
                    pilotLight1_2.Value = false;
                    pilotLight2_2.Value = false;
                }
                if (responseReadDigital_2[0] == 0)
                {
                    pilotLight1_2.Value = true;
                    pilotLight2_2.Value = true;
                }
                if (responseReadDigital_2[0] == 1)
                {
                    pilotLight1_2.Value = true;
                    pilotLight2_2.Value = false;
                }
                if (responseReadDigital_2[0] == 2)
                {
                    pilotLight1_2.Value = false;
                    pilotLight2_2.Value = true;
                }


                consultaHabilitada = true;
                // Circuito_3();
            }
            catch (Exception ex)
            {
              //  Circuito_2();
                //  MessageBox.Show(ex.Message);
                consultaHabilitada = true;
            }
        }
        private void Circuito_3()
        {
            try
            {
                _modbusMaster.WriteSingleRegister(direccion_3, 1, (ushort)Convert.ToInt32(new string(valorInicial_3), 2));

                //var responseReadDigital_3 = _modbusMaster.ReadHoldingRegister(direccion_3, 0, 1);


                //if (responseReadDigital_3[0] == 3)
                //{
                //    pilotLight1_3.Value = false;
                //    pilotLight2_3.Value = false;
                //}
                //if (responseReadDigital_3[0] == 0)
                //{
                //    pilotLight1_3.Value = true;
                //    pilotLight2_3.Value = true;
                //}
                //if (responseReadDigital_3[0] == 1)
                //{
                //    pilotLight1_3.Value = true;
                //    pilotLight2_3.Value = false;
                //}
                //if (responseReadDigital_3[0] == 2)
                //{
                //    pilotLight1_3.Value = false;
                //    pilotLight2_3.Value = true;
                //}

                // Circuito_1();

                consultaHabilitada = true;
            }
            catch (Exception ex)
            {
             //   Circuito_3();
               // MessageBox.Show(ex.Message);
                consultaHabilitada = true;
            }
        }
        private void Circuito_3_Digitales()
        {
            try
            {
                //                _modbusMaster.WriteSingleRegister(direccion_3, 1, (ushort)Convert.ToInt32(new string(valorInicial_3), 2));

                var responseReadDigital_3 = _modbusMaster.ReadHoldingRegister(direccion_3, 0, 1);


                if (responseReadDigital_3[0] == 3)
                {
                    pilotLight1_3.Value = false;
                    pilotLight2_3.Value = false;
                }
                if (responseReadDigital_3[0] == 0)
                {
                    pilotLight1_3.Value = true;
                    pilotLight2_3.Value = true;
                }
                if (responseReadDigital_3[0] == 1)
                {
                    pilotLight1_3.Value = true;
                    pilotLight2_3.Value = false;
                }
                if (responseReadDigital_3[0] == 2)
                {
                    pilotLight1_3.Value = false;
                    pilotLight2_3.Value = true;
                }

                // Circuito_1();

                consultaHabilitada = true;
            }
            catch (Exception ex)
            {
                //   Circuito_3();
                // MessageBox.Show(ex.Message);
                consultaHabilitada = true;
            }
        }

        private void pacecar_1_Click(object sender, EventArgs e)
        {
            if (valorInicial_1[7] == '0')
            {
                valorInicial_1[7] = '1';

                var tah = pacecar_1.Tag.ToString();

                if (pacecar_1.Tag.ToString().Contains("inactiva"))
                {
                    pacecar_1.Image = global::AdvancedHMICS3Flag.Properties.Resources.pacecar_activa;
                    pacecar_1.Tag = "pacecar_activa";
                }
            }
            else
            {
                valorInicial_1[7] = '0';

                pacecar_1.Image = global::AdvancedHMICS3Flag.Properties.Resources.pacecar_inactiva;
                pacecar_1.Tag = "pacecar_inactiva";




            }
        }

        private void roja_1_Click(object sender, EventArgs e)
        {
            if (valorInicial_1[6] == '0')
            {
                valorInicial_1[6] = '1';

                var tah = roja_1.Tag.ToString();

                if (roja_1.Tag.ToString().Contains("inactiva"))
                {
                    roja_1.Image = global::AdvancedHMICS3Flag.Properties.Resources.rojas_activa;
                    roja_1.Tag = "rojas_activa";
                }
            }
            else
            {
                valorInicial_1[6] = '0';

                roja_1.Image = global::AdvancedHMICS3Flag.Properties.Resources.rojas_inactiva;
                roja_1.Tag = "rojas_inactiva";




            }
        }

        private void verde_1_Click(object sender, EventArgs e)
        {
            if (valorInicial_1[5] == '0')
            {
                valorInicial_1[5] = '1';

                var tah = verde_1.Tag.ToString();

                if (verde_1.Tag.ToString().Contains("inactiva"))
                {
                    verde_1.Image = global::AdvancedHMICS3Flag.Properties.Resources.verde_activa;
                    verde_1.Tag = "verde_activa";
                }
            }
            else
            {
                valorInicial_1[5] = '0';

                verde_1.Image = global::AdvancedHMICS3Flag.Properties.Resources.verde_inactiva;
                verde_1.Tag = "verde_inactiva";




            }

        }

        private void amarrilla_1_Click(object sender, EventArgs e)
        {
            if (valorInicial_1[4] == '0')
            {
                valorInicial_1[4] = '1';

                var tah = amarrilla_1.Tag.ToString();

                if (amarrilla_1.Tag.ToString().Contains("inactiva"))
                {
                    amarrilla_1.Image = global::AdvancedHMICS3Flag.Properties.Resources.amarillo_activa;
                    amarrilla_1.Tag = "amarillo_activa";
                }
            }
            else
            {
                valorInicial_1[4] = '0';

                amarrilla_1.Image = global::AdvancedHMICS3Flag.Properties.Resources.amarillo_inactiva;
                amarrilla_1.Tag = "amarillo_inactiva";




            }

        }

        private void pacecar_2_Click(object sender, EventArgs e)
        {
            if (valorInicial_2[7] == '0')
            {
                valorInicial_2[7] = '1';

                var tah = pacecar_2.Tag.ToString();

                if (pacecar_2.Tag.ToString().Contains("inactiva"))
                {
                    pacecar_2.Image = global::AdvancedHMICS3Flag.Properties.Resources.pacecar_activa;
                    pacecar_2.Tag = "pacecar_activa";
                }
            }
            else
            {
                valorInicial_2[7] = '0';

                pacecar_2.Image = global::AdvancedHMICS3Flag.Properties.Resources.pacecar_inactiva;
                pacecar_2.Tag = "pacecar_inactiva";




            }
        }

        private void roja_2_Click(object sender, EventArgs e)
        {
            if (valorInicial_2[6] == '0')
            {
                valorInicial_2[6] = '1';

                var tah = roja_2.Tag.ToString();

                if (roja_2.Tag.ToString().Contains("inactiva"))
                {
                    roja_2.Image = global::AdvancedHMICS3Flag.Properties.Resources.rojas_activa;
                    roja_2.Tag = "rojas_activa";
                }
            }
            else
            {
                valorInicial_2[6] = '0';

                roja_2.Image = global::AdvancedHMICS3Flag.Properties.Resources.rojas_inactiva;
                roja_2.Tag = "rojas_inactiva";




            }
        }

        private void verde_2_Click(object sender, EventArgs e)
        {
            if (valorInicial_2[5] == '0')
            {
                valorInicial_2[5] = '1';

                var tah = verde_2.Tag.ToString();

                if (verde_2.Tag.ToString().Contains("inactiva"))
                {
                    verde_2.Image = global::AdvancedHMICS3Flag.Properties.Resources.verde_activa;
                    verde_2.Tag = "verde_activa";
                }
            }
            else
            {
                valorInicial_2[5] = '0';
                verde_2.Image = global::AdvancedHMICS3Flag.Properties.Resources.verde_inactiva;
                verde_2.Tag = "verde_inactiva";
            }
        }

        private void amarillo_2_Click(object sender, EventArgs e)
        {
            if (valorInicial_2[4] == '0')
            {
                valorInicial_2[4] = '1';

                var tah = amarillo_2.Tag.ToString();

                if (amarillo_2.Tag.ToString().Contains("inactiva"))
                {
                    amarillo_2.Image = global::AdvancedHMICS3Flag.Properties.Resources.amarillo_activa;
                    amarillo_2.Tag = "amarillo_activa";
                }
            }
            else
            {
                valorInicial_2[4] = '0';
                amarillo_2.Image = global::AdvancedHMICS3Flag.Properties.Resources.amarillo_inactiva;
                amarillo_2.Tag = "amarillo_inactiva";
            }
        }

        private void pacecar_3_Click(object sender, EventArgs e)
        {
            if (valorInicial_3[7] == '0')
            {
                valorInicial_3[7] = '1';

                //var tah = pacecar_2.Tag.ToString();

                if (pacecar_3.Tag.ToString().Contains("inactiva"))
                {
                    pacecar_3.Image = global::AdvancedHMICS3Flag.Properties.Resources.pacecar_activa;
                    pacecar_3.Tag = "pacecar_activa";
                }
            }
            else
            {
                valorInicial_3[7] = '0';

                pacecar_3.Image = global::AdvancedHMICS3Flag.Properties.Resources.pacecar_inactiva;
                pacecar_3.Tag = "pacecar_inactiva";

            }
        }

        private void roja_3_Click(object sender, EventArgs e)
        {
            if (valorInicial_3[6] == '0')
            {
                valorInicial_3[6] = '1';

                var tah = roja_3.Tag.ToString();

                if (roja_3.Tag.ToString().Contains("inactiva"))
                {
                    roja_3.Image = global::AdvancedHMICS3Flag.Properties.Resources.rojas_activa;
                    roja_3.Tag = "rojas_activa";
                }
            }
            else
            {
                valorInicial_3[6] = '0';

                roja_3.Image = global::AdvancedHMICS3Flag.Properties.Resources.rojas_inactiva;
                roja_3.Tag = "rojas_inactiva";




            }
        }

        private void verde_3_Click(object sender, EventArgs e)
        {
            if (valorInicial_3[5] == '0')
            {
                valorInicial_3[5] = '1';

                var tah = verde_2.Tag.ToString();

                if (verde_3.Tag.ToString().Contains("inactiva"))
                {
                    verde_3.Image = global::AdvancedHMICS3Flag.Properties.Resources.verde_activa;
                    verde_3.Tag = "verde_activa";
                }
            }
            else
            {
                valorInicial_3[5] = '0';
                verde_3.Image = global::AdvancedHMICS3Flag.Properties.Resources.verde_inactiva;
                verde_3.Tag = "verde_inactiva";
            }
        }

        private void amarillo_3_Click(object sender, EventArgs e)
        {
            if (valorInicial_3[4] == '0')
            {
                valorInicial_3[4] = '1';

                var tah = amarillo_3.Tag.ToString();

                if (amarillo_3.Tag.ToString().Contains("inactiva"))
                {
                    amarillo_3.Image = global::AdvancedHMICS3Flag.Properties.Resources.amarillo_activa;
                    amarillo_3.Tag = "amarillo_activa";
                }
            }
            else
            {
                valorInicial_3[4] = '0';
                amarillo_3.Image = global::AdvancedHMICS3Flag.Properties.Resources.amarillo_inactiva;
                amarillo_3.Tag = "amarillo_inactiva";
            }
        }

        private void pacecarALL_Click(object sender, EventArgs e)
        {
            if (pacecarALL.Tag.ToString().Contains("inactiva"))
            {
                valorInicial_1[7] = '1';
                valorInicial_2[7] = '1';
                valorInicial_3[7] = '1';
                pacecar_1.Image = global::AdvancedHMICS3Flag.Properties.Resources.pacecar_activa;
                pacecar_1.Tag = "pacecar_activa";
                pacecar_2.Image = global::AdvancedHMICS3Flag.Properties.Resources.pacecar_activa;
                pacecar_2.Tag = "pacecar_activa";
                pacecar_3.Image = global::AdvancedHMICS3Flag.Properties.Resources.pacecar_activa;
                pacecar_3.Tag = "pacecar_activa";

                pacecarALL.Image = global::AdvancedHMICS3Flag.Properties.Resources.pacecar_activa;
                pacecarALL.Tag = "pacecar_activa";



            }
            else
            {
                valorInicial_1[7] = '0';
                valorInicial_2[7] = '0';
                valorInicial_3[7] = '0';
                pacecar_1.Image = global::AdvancedHMICS3Flag.Properties.Resources.pacecar_inactiva;
                pacecar_1.Tag = "pacecar_inactiva";
                pacecar_2.Image = global::AdvancedHMICS3Flag.Properties.Resources.pacecar_inactiva;
                pacecar_2.Tag = "pacecar_inactiva";
                pacecar_3.Image = global::AdvancedHMICS3Flag.Properties.Resources.pacecar_inactiva;
                pacecar_3.Tag = "pacecar_inactiva";
                pacecarALL.Image = global::AdvancedHMICS3Flag.Properties.Resources.pacecar_inactiva;
                pacecarALL.Tag = "pacecar_inactiva";
            }
        }

        private void rojasALL_Click(object sender, EventArgs e)
        {
            if (rojasALL.Tag.ToString().Contains("inactiva"))
            {
                valorInicial_1[6] = '1';
                valorInicial_2[6] = '1';
                valorInicial_3[6] = '1';
                roja_1.Image = global::AdvancedHMICS3Flag.Properties.Resources.rojas_activa;
                roja_1.Tag = "rojas_activa";
                roja_2.Image = global::AdvancedHMICS3Flag.Properties.Resources.rojas_activa;
                roja_2.Tag = "rojas_activa";
                roja_3.Image = global::AdvancedHMICS3Flag.Properties.Resources.rojas_activa;
                roja_3.Tag = "rojas_activa";

                rojasALL.Image = global::AdvancedHMICS3Flag.Properties.Resources.rojas_activa;
                rojasALL.Tag = "rojas_activa";



            }
            else
            {
                valorInicial_1[6] = '0';
                valorInicial_2[6] = '0';
                valorInicial_3[6] = '0';
                roja_1.Image = global::AdvancedHMICS3Flag.Properties.Resources.rojas_inactiva;
                roja_1.Tag = "rojas_inactiva";
                roja_2.Image = global::AdvancedHMICS3Flag.Properties.Resources.rojas_inactiva;
                roja_2.Tag = "rojas_inactiva";
                roja_3.Image = global::AdvancedHMICS3Flag.Properties.Resources.rojas_inactiva;
                roja_3.Tag = "rojas_inactiva";

                rojasALL.Image = global::AdvancedHMICS3Flag.Properties.Resources.rojas_inactiva;
                rojasALL.Tag = "rojas_inactiva";
            }
        }

        private void verdesAll_Click(object sender, EventArgs e)
        {
            if (verdesAll.Tag.ToString().Contains("inactiva"))
            {
                valorInicial_1[5] = '1';
                valorInicial_2[5] = '1';
                valorInicial_3[5] = '1';
                verde_1.Image = global::AdvancedHMICS3Flag.Properties.Resources.verde_activa;
                verde_1.Tag = "verde_activa";
                verde_2.Image = global::AdvancedHMICS3Flag.Properties.Resources.verde_activa;
                verde_2.Tag = "verde_activa";
                verde_3.Image = global::AdvancedHMICS3Flag.Properties.Resources.verde_activa;
                verde_3.Tag = "verde_activa";

                verdesAll.Image = global::AdvancedHMICS3Flag.Properties.Resources.verde_activa;
                verdesAll.Tag = "verde_activa";



            }
            else
            {
                valorInicial_1[5] = '0';
                valorInicial_2[5] = '0';
                valorInicial_3[5] = '0';
                verde_1.Image = global::AdvancedHMICS3Flag.Properties.Resources.verde_inactiva;
                verde_1.Tag = "verde_inactiva";
                verde_2.Image = global::AdvancedHMICS3Flag.Properties.Resources.verde_inactiva;
                verde_2.Tag = "verde_inactiva";
                verde_3.Image = global::AdvancedHMICS3Flag.Properties.Resources.verde_inactiva;
                verde_3.Tag = "verde_inactiva";

                verdesAll.Image = global::AdvancedHMICS3Flag.Properties.Resources.verde_inactiva;
                verdesAll.Tag = "verde_inactiva";
            }
        }

        private void amarillaAll_Click(object sender, EventArgs e)
        {
            if (amarillaAll.Tag.ToString().Contains("inactiva"))
            {
                valorInicial_1[4] = '1';
                valorInicial_2[4] = '1';
                valorInicial_3[4] = '1';
                amarrilla_1.Image = global::AdvancedHMICS3Flag.Properties.Resources.amarillo_activa;
                amarrilla_1.Tag = "amarillo_activa";
                amarillo_2.Image = global::AdvancedHMICS3Flag.Properties.Resources.amarillo_activa;
                amarillo_2.Tag = "amarillo_activa";
                amarillo_3.Image = global::AdvancedHMICS3Flag.Properties.Resources.amarillo_activa;
                amarillo_3.Tag = "amarillo_activa";

                amarillaAll.Image = global::AdvancedHMICS3Flag.Properties.Resources.amarillo_activa;
                amarillaAll.Tag = "amarillo_activa";
            }
            else
            {
                valorInicial_1[4] = '0';
                valorInicial_2[4] = '0';
                valorInicial_3[4] = '0';
                amarrilla_1.Image = global::AdvancedHMICS3Flag.Properties.Resources.amarillo_inactiva;
                amarrilla_1.Tag = "amarillo_inactiva";
                amarillo_2.Image = global::AdvancedHMICS3Flag.Properties.Resources.amarillo_inactiva;
                amarillo_2.Tag = "amarillo_inactiva";
                amarillo_3.Image = global::AdvancedHMICS3Flag.Properties.Resources.amarillo_inactiva;
                amarillo_3.Tag = "amarillo_inactiva";

                amarillaAll.Image = global::AdvancedHMICS3Flag.Properties.Resources.amarillo_inactiva;
                amarillaAll.Tag = "amarillo_inactiva";
            }
        }

      
    }
}
