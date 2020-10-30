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

namespace WaterTank
{
    public partial class WaterTank : Form
    {
        private static SerialRTU _modbusMaster = null;
        private static bool consultaHabilitada = false;
        delegate void delegado(int valor);

        public WaterTank()
        {
            InitializeComponent();
        }



        private void WaterTank_Load(object sender, EventArgs e)
        {
            var serial = System.IO.Ports.SerialPort.GetPortNames();
            //if (serial.Length==0)
            //{
            //    MessageBox.Show("Sin puerto abiertos.");
            //}

            cboSeleccionPuerto.DataSource = serial;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_modbusMaster == null)
                    _modbusMaster = new RFEnlaces.ModbusProtocol.SerialRTU(cboSeleccionPuerto.SelectedItem.ToString());

                //Properties.Settings.Default.COM = cboSeleccionPuerto.SelectedItem.ToString();

                //tsslEstadoConexion.Text = "Conectando con el equipo...";
                //tsslEstadoConexion.ForeColor = System.Drawing.Color.Orange;

                consultaHabilitada = true;

                // Consultar();

                btnConectar.Enabled = false;
                cboSeleccionPuerto.Enabled = false;

                timer1.Enabled = true;
                //    timer2.Enabled = true;
                //timer3.Enabled = true;
            }
            catch (Exception ex)
            {
                _modbusMaster = null;

                consultaHabilitada = false;

                // timer1.Enabled = false;

                //tsslEstadoConexion.Text = "ERROR - No se puede conectar con el puerto";
                //tsslEstadoConexion.ForeColor = System.Drawing.Color.Red;

                //ResetEnable(false);

                //Serilog.Log.Logger.Error(ex, "Conectar");
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (consultaHabilitada)
            {
                // Task.Run(new Action(ReadAnalogicas4));
                //Task.Run(new Action(ReadAnalogicas5));
                Task.Run(new Action(Tank));
                Task.Run(new Action(bomb));






            }

        }
        private void bomb()
        {
            try
            {

                var responseReadDigital = _modbusMaster.ReadHoldingRegister(3, 0, 1);

                delegado MD = new delegado(actulizarBomb);
                this.Invoke(MD, new object[] { Convert.ToInt32(responseReadDigital.FirstOrDefault()) });

                consultaHabilitada = true;
            }
            catch (Exception ex)
            {

                consultaHabilitada = true;
            }
        }

        private void Tank()
        {


            try
            {

                var responseReadDigital = _modbusMaster.ReadHoldingRegister(3, 2, 1);

                delegado MD = new delegado(actulizarTank);
                this.Invoke(MD, new object[] {Convert.ToInt32( responseReadDigital.FirstOrDefault()) });

                consultaHabilitada = true;
            }
            catch (Exception ex)
            {

                consultaHabilitada = true;
            }
        }

        private void actulizarTank(int valor)
        {
            int percentComplete = (int)Math.Round((double)(100 * valor) / 1023);
            tank1.Value = valor;
            label3.Text = percentComplete.ToString()+"%";
        }
        private void actulizarBomb(int valor)
        {
            var bol = valor == 2 ? true : false;
            waterPump.Value = bol;
            if (bol)
            {

                label1.BackColor = Color.Blue;
                label2.BackColor = Color.Blue;

            }

            else
            {
                label1.BackColor = Color.Transparent;
                label2.BackColor = Color.Transparent;
          
            }
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void analogValueDisplay1_Click(object sender, EventArgs e)
        {

        }
    }
}
