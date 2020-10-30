using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedHMIcs
{
    public partial class MainForm : Form
    {
        private static RFEnlaces.ModbusProtocol.SerialRTU _modbusMaster = null;
        private static ushort[] response;
        private static bool consultaHabilitada = false;
        private static bool primeraEntrada = true;
        private static bool flagErrorConexion = true;
        private static char[] valorInicial = { '0', '0', '0', '0', '0', '0', '0', '0' };
        private static int ReadAnalogicas = 4;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cboSeleccionPuerto.SelectedItem = Properties.Settings.Default.COM;
            //txtCSVFile.Text = Properties.Settings.Default.CSVFile;
            //chkOneByDay.Checked = Properties.Settings.Default.OneByDay;
            txtDevice.Text = Properties.Settings.Default.Device.ToString();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_modbusMaster == null)
                    _modbusMaster = new RFEnlaces.ModbusProtocol.SerialRTU(cboSeleccionPuerto.SelectedItem.ToString());

                Properties.Settings.Default.COM = cboSeleccionPuerto.SelectedItem.ToString();

                //tsslEstadoConexion.Text = "Conectando con el equipo...";
                //tsslEstadoConexion.ForeColor = System.Drawing.Color.Orange;

                consultaHabilitada = true;

                // Consultar();

                btnConectar.Enabled = false;
                cboSeleccionPuerto.Enabled = false;
                txtDevice.Enabled = false;

                timer1.Enabled = true;
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
            if (valorInicial[7] == '0')
            {
                valorInicial[7] = '1';
               // _modbusMaster.WriteSingleRegister(1, 1, (ushort)Convert.ToInt32(new string(valorInicial), 2));

                btnRele1.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
            }
            else
            {
                valorInicial[7] = '0';
              //  _modbusMaster.WriteSingleRegister(1, 1, (ushort)Convert.ToInt32(new string(valorInicial), 2));

                btnRele1.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
            }

        }

        private void btnRele2_Click(object sender, EventArgs e)
        {
            if (valorInicial[6] == '0')
            {
                valorInicial[6] = '1';
                //string str = new string(valorInicial);
               // var i = (ushort)Convert.ToInt32(new string(valorInicial), 2);
           //     _modbusMaster.WriteSingleRegister(1, 1, (ushort)Convert.ToInt32(new string(valorInicial), 2));
                btnRele2.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;


            }
            else
            {
                valorInicial[6] = '0';
               // _modbusMaster.WriteSingleRegister(1, 1, (ushort)Convert.ToInt32(new string(valorInicial), 2));
                btnRele2.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;


            }
        }

        private void btnRele3_Click(object sender, EventArgs e)
        {
            if (valorInicial[5] == '0')
            {
                valorInicial[5] = '1';
               // _modbusMaster.WriteSingleRegister(1, 1, (ushort)Convert.ToInt32(new string(valorInicial), 2));

                btnRele3.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;


            }
            else
            {
                valorInicial[5] = '0';
             //   _modbusMaster.WriteSingleRegister(1, 1, (ushort)Convert.ToInt32(new string(valorInicial), 2));

                btnRele3.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;


            }

        }

        private void btnRele4_Click(object sender, EventArgs e)
        {
            if (valorInicial[4] == '0')
            {
                valorInicial[4] = '1';
             //   _modbusMaster.WriteSingleRegister(1, 1, (ushort)Convert.ToInt32(new string(valorInicial), 2));

                btnRele4.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;


            }
            else
            {
                valorInicial[4] = '0';
            //    _modbusMaster.WriteSingleRegister(1, 1, (ushort)Convert.ToInt32(new string(valorInicial), 2));

                btnRele4.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;


            }


        }

        private void btnOnAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < valorInicial.Length; i++)
            {
                valorInicial[i] = '1';
            }
          //  _modbusMaster.WriteSingleRegister(1, 1, (ushort)Convert.ToInt32(new string(valorInicial), 2));

            btnRele1.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
            btnRele2.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
            btnRele3.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
            btnRele4.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green;
        }

        private void btnOffAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < valorInicial.Length; i++)
            {
                valorInicial[i] = '0';
            }
          //  _modbusMaster.WriteSingleRegister(1, 1, (ushort)Convert.ToInt32(new string(valorInicial), 2));

            btnRele1.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
            btnRele2.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
            btnRele3.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
            btnRele4.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (consultaHabilitada)
            {
               // Task.Run(new Action(ReadAnalogicas4));
                //Task.Run(new Action(ReadAnalogicas5));
                //Task.Run(new Action(ReadDigital));
                Task.Run(new Action(Rele));
            }
            
        }

        private void Rele()
        {
            try
            {

      
            _modbusMaster.WriteSingleRegister(1, 1, (ushort)Convert.ToInt32(new string(valorInicial), 2));

                //var responseReadAnalogicas4 = _modbusMaster.ReadHoldingRegister(1, 4, 1);
                //digitalPanelMeter1.Value = Convert.ToDouble(responseReadAnalogicas4[0].ToString());
                //string str = new string(valorInicial);
                //var i = (ushort)Convert.ToInt32(new string(valorInicial), 2);


                //_modbusMaster.WriteSingleRegister(1, 1, i); 
                //var responseReadAnalogicas4 = _modbusMaster.ReadHoldingRegister(1, 4, 1);
                //digitalPanelMeter1.Value = Convert.ToDouble(responseReadAnalogicas4[0].ToString());

                //var responseReadAnalogicas5 = _modbusMaster.ReadHoldingRegister(1, 5, 1);
                //digitalPanelMeter2.Value = Convert.ToDouble(responseReadAnalogicas5[0].ToString());

                //_modbusMaster.WriteSingleRegister(1, 1, i); 
                var responseReadDigital = _modbusMaster.ReadHoldingRegister(1, 0, 1);
                if (responseReadDigital[0] == 3)
                {
                    pilotLight1.Value = false;
                    pilotLight2.Value = false;
                }
                if (responseReadDigital[0] == 0)
                {
                    pilotLight1.Value = true;
                    pilotLight2.Value = true;
                }
                if (responseReadDigital[0] == 1)
                {
                    pilotLight1.Value = true;
                    pilotLight2.Value = false;
                }
                if (responseReadDigital[0] == 2)
                {
                    pilotLight1.Value = false;
                    pilotLight2.Value = true;
                }
                var responseReadAnalogicas4 = _modbusMaster.ReadHoldingRegister(1, (ushort)ReadAnalogicas, 1);
                if (ReadAnalogicas == 4)
                {

                    digitalPanelMeter1.Value = Convert.ToDouble(responseReadAnalogicas4[0].ToString());

                    ReadAnalogicas = 5;
                }
                else
                {

                    digitalPanelMeter2.Value = Convert.ToDouble(responseReadAnalogicas4[0].ToString());

                    ReadAnalogicas = 4;

                }
                consultaHabilitada = true;
            }
            catch (Exception)
            {

                consultaHabilitada = true;
            }
        }
        private void ReadAnalogicas4()
        {
            try
            {
            var responseReadAnalogicas4 = _modbusMaster.ReadHoldingRegister(1, (ushort)ReadAnalogicas, 1);
            if (ReadAnalogicas == 4)
            {

                digitalPanelMeter1.Value = Convert.ToDouble(responseReadAnalogicas4[0].ToString());

                ReadAnalogicas = 5;
            }
            else { 
           
                digitalPanelMeter2.Value = Convert.ToDouble(responseReadAnalogicas4[0].ToString());

                ReadAnalogicas = 4;

            }
                consultaHabilitada = true;
            }
            catch (Exception)
            {

                consultaHabilitada = true;
            }
           
            //string str = new string(valorInicial);
            //var i = (ushort)Convert.ToInt32(new string(valorInicial), 2);


        }
        private void ReadAnalogicas5()
        {
            var responseReadAnalogicas5 = _modbusMaster.ReadHoldingRegister(1, 5, 1);
            digitalPanelMeter2.Value = Convert.ToDouble(responseReadAnalogicas5[0].ToString());
            //string str = new string(valorInicial);
            //var i = (ushort)Convert.ToInt32(new string(valorInicial), 2);


            //_modbusMaster.WriteSingleRegister(1, 1, i); 
        }
        private void ReadDigital()
        {
            try
            {
          var responseReadDigital = _modbusMaster.ReadInputRegister(1, 0, 1);
            if (responseReadDigital[0]==3)
            {
                pilotLight1.Value = false;
                pilotLight2.Value = false;
            }
            if (responseReadDigital[0] == 0)
            {
                pilotLight1.Value = true;
                pilotLight2.Value = true;
            }
            if (responseReadDigital[0] == 1)
            {
                pilotLight1.Value = true;
                pilotLight2.Value = false;
            }
            if (responseReadDigital[0] == 2)
            {
                pilotLight1.Value = false;
                pilotLight2.Value = true;
            }
                consultaHabilitada = true;

            }
            catch (Exception)
            {

                consultaHabilitada = true;
            }
        
          //  digitalPanelMeter1.Value = Convert.ToDouble(responseReadDigital[0].ToString());
            //string str = new string(valorInicial);
            //var i = (ushort)Convert.ToInt32(new string(valorInicial), 2);


            //_modbusMaster.WriteSingleRegister(1, 1, i); 
        }
    }
}
