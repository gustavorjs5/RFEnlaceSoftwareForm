using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedHMIcs3flagSerial
{
    public partial class MainForm : Form
    {
        private static RFEnlaces.ModbusProtocol.SerialRTU _modbusMaster = null;
        static SerialPort _port;
        private static int cntCircuitos = 3;

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

            _port = new SerialPort(cboSeleccionPuerto.SelectedItem.ToString());

            // configure serial port
            _port.BaudRate = 9600;
            _port.DataBits = 8;
            _port.Parity = Parity.None;
            _port.StopBits = StopBits.One;
            _port.ReadTimeout = 500;
            _port.WriteTimeout = 500;
            //_port.DataReceived += new
      // SerialDataReceivedEventHandler(port_DataReceived);
            _port.Open();

            btnConectar.Enabled = false;
            btnConectar.BackColor = Color.LimeGreen;
            btnDesconectar.Enabled = true;

        }

        private void banderas_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
           byte[] data = new byte[2];

            if (_port != null)
            {
                PictureBox[] listBanderaALL = new PictureBox[] { pacecarALL, rojasALL, verdesALL,amarillaAll,  azulAll };
                string[] listBanderaCircuito1tag = new string[] { "pacecar_inactiva1", "roja_inactiva1", "amarillo_inactiva1", "verde_inactiva1", "azul_inactiva1" };

                PictureBox[] listBanderaCircuito1 = new PictureBox[] { pacecar_1, roja_1, amarillo_1, verde_1, azul_1 };
                string[] listBanderaCircuito1tagALL = new string[] { "pacecar_inactivaALL", "rojas_inactivaALL", "verde_inactivaALL", "verde_inactiva1", "azul_inactiva1" };
                Bitmap[] listBanderaCircuito1Resources = new Bitmap[]
                { global::AdvancedHMICS3FlagSerial.Properties.Resources.pacecar_inactiva,
                        global::AdvancedHMICS3FlagSerial.Properties.Resources.rojas_inactiva,
                        global::AdvancedHMICS3FlagSerial.Properties.Resources.amarillo_inactiva,
                        global::AdvancedHMICS3FlagSerial.Properties.Resources.verde_inactiva,
                        global::AdvancedHMICS3FlagSerial.Properties.Resources.azul_inactiva };
                Bitmap[] listBanderaCircuito1ResourcesALL = new Bitmap[]
         { global::AdvancedHMICS3FlagSerial.Properties.Resources.pacecar_inactiva,
                        global::AdvancedHMICS3FlagSerial.Properties.Resources.rojas_inactiva,
                        global::AdvancedHMICS3FlagSerial.Properties.Resources.verde_inactiva,
                        global::AdvancedHMICS3FlagSerial.Properties.Resources.verde_inactiva,
                        global::AdvancedHMICS3FlagSerial.Properties.Resources.azul_inactiva };



                if (pictureBox.Name.Contains("ALL"))
                {
                    PictureBox[] listBanderaPacecar = new PictureBox[] { pacecar_1, pacecar_2, pacecar_3 };
                    PictureBox[] listBanderaRoja = new PictureBox[] { roja_1, roja_2, roja_3 };
                    PictureBox[] listBanderaVerde = new PictureBox[] { verde_1, verde_2, verde_3 };




                    switch (pictureBox.Tag)
                    {
                        case "pacecar_inactivaALL":
                            for (int i = 1; i <= listBanderaCircuito1.Length; i++)
                            {
                                listBanderaCircuito1[i - 1].Image = listBanderaCircuito1Resources[i - 1];
                                listBanderaCircuito1[i - 1].Tag = listBanderaCircuito1tag[i - 1];

                            }
                            for (int i = 1; i <= 3; i++)
                            {
                                listBanderaALL[i - 1].Image = listBanderaCircuito1ResourcesALL[i - 1];
                                listBanderaALL[i - 1].Tag = listBanderaCircuito1tagALL[i - 1];

                            }


                            data[0] = 254;
                            data[1] = (byte)1;
                            _port.Write(data, 0, data.Length);
                            for (int i = 1; i <= cntCircuitos; i++)
                            {
                                listBanderaPacecar[i - 1].Image = global::AdvancedHMICS3FlagSerial.Properties.Resources.pacecar_activa;
                                listBanderaPacecar[i - 1].Tag = "pacecar_activa1";

                            }
                            pacecarALL.Image = global::AdvancedHMICS3FlagSerial.Properties.Resources.pacecar_activa;
                            pacecarALL.Tag = "pacecar_activaALL";
                            break;

                        case "pacecar_activaALL":

                            data[0] = 254;
                            data[1] = (byte)6;
                            _port.Write(data, 0, data.Length);
                            for (int i = 1; i <= cntCircuitos; i++)
                            {
                                listBanderaPacecar[i - 1].Image = global::AdvancedHMICS3FlagSerial.Properties.Resources.pacecar_inactiva;
                                listBanderaPacecar[i - 1].Tag = "pacecar_inactiva1";

                            }
                            pacecarALL.Image = global::AdvancedHMICS3FlagSerial.Properties.Resources.pacecar_inactiva;
                            pacecarALL.Tag = "pacecar_inactivaALL";
                            break;

                        case "rojas_inactivaALL":
                            for (int i = 1; i <= listBanderaCircuito1.Length; i++)
                            {
                                listBanderaCircuito1[i - 1].Image = listBanderaCircuito1Resources[i - 1];
                                listBanderaCircuito1[i - 1].Tag = listBanderaCircuito1tag[i - 1];

                            }
                            for (int i = 1; i <= 3; i++)
                            {
                                listBanderaALL[i - 1].Image = listBanderaCircuito1ResourcesALL[i - 1];
                                listBanderaALL[i - 1].Tag = listBanderaCircuito1tagALL[i - 1];

                            }

                            data[0] = 254;
                            data[1] = (byte)1;
                            _port.Write(data, 0, data.Length);
                            for (int i = 1; i <= cntCircuitos; i++)
                            {
                                listBanderaRoja[i - 1].Image = global::AdvancedHMICS3FlagSerial.Properties.Resources.rojas_activa;
                                listBanderaRoja[i - 1].Tag = "roja_activa1";

                            }
                            rojasALL.Image = global::AdvancedHMICS3FlagSerial.Properties.Resources.rojas_activa;
                            rojasALL.Tag = "rojas_activaALL";
                            break;

                        case "rojas_activaALL":

                            data[0] = 254;
                            data[1] = (byte)6;
                            _port.Write(data, 0, data.Length);
                            for (int i = 1; i <= cntCircuitos; i++)
                            {
                                listBanderaRoja[i - 1].Image = global::AdvancedHMICS3FlagSerial.Properties.Resources.rojas_inactiva;
                                listBanderaRoja[i - 1].Tag = "roja_inactiva1";

                            }
                            rojasALL.Image = global::AdvancedHMICS3FlagSerial.Properties.Resources.rojas_inactiva;
                            rojasALL.Tag = "rojas_inactivaALL";
                            break;

                        case "verde_inactivaALL":
                            for (int i = 1; i <= listBanderaCircuito1.Length; i++)
                            {
                                listBanderaCircuito1[i - 1].Image = listBanderaCircuito1Resources[i - 1];
                                listBanderaCircuito1[i - 1].Tag = listBanderaCircuito1tag[i - 1];

                            }
                            for (int i = 1; i <= 3; i++)
                            {
                                listBanderaALL[i - 1].Image = listBanderaCircuito1ResourcesALL[i - 1];
                                listBanderaALL[i - 1].Tag = listBanderaCircuito1tagALL[i - 1];

                            }

                            data[0] = 254;
                            data[1] = (byte)1;
                            _port.Write(data, 0, data.Length);
                            for (int i = 1; i <= cntCircuitos; i++)
                            {
                                listBanderaVerde[i - 1].Image = global::AdvancedHMICS3FlagSerial.Properties.Resources.verde_activa;
                                listBanderaVerde[i - 1].Tag = "verde_activa1";

                            }
                            verdesALL.Image = global::AdvancedHMICS3FlagSerial.Properties.Resources.verde_activa;
                            verdesALL.Tag = "verde_activaALL";
                            break;

                        case "verde_activaALL":

                            data[0] = 254;
                            data[1] = (byte)6;
                            _port.Write(data, 0, data.Length);
                            for (int i = 1; i <= cntCircuitos; i++)
                            {
                                listBanderaVerde[i - 1].Image = global::AdvancedHMICS3FlagSerial.Properties.Resources.verde_inactiva;
                                listBanderaVerde[i - 1].Tag = "verde_inactiva1";

                            }
                            verdesALL.Image = global::AdvancedHMICS3FlagSerial.Properties.Resources.verde_inactiva;
                            verdesALL.Tag = "verde_inactivaALL";
                            break;




                        default:
                            break;
                    }
                }
                else
                {
              
                    switch (pictureBox.Tag)
                    {

                        case "pacecar_inactiva1":
                            for (int i = 1; i <= listBanderaCircuito1.Length; i++)
                            {
                                listBanderaCircuito1[i - 1].Image = listBanderaCircuito1Resources[i - 1];
                                listBanderaCircuito1[i - 1].Tag = listBanderaCircuito1tag[i - 1];

                            }
                            data[0] = 1;
                            data[1] = 1;
                            _port.Write(data, 0, data.Length);
                            pacecar_1.Image = global::AdvancedHMICS3FlagSerial.Properties.Resources.pacecar_activa;
                            pacecar_1.Tag = "pacecar_activa1";

                            break;
                        case "pacecar_activa1":
                            data[0] = 1;
                            data[1] = 6;
                            _port.Write(data, 0, data.Length);
                            pacecar_1.Image = global::AdvancedHMICS3FlagSerial.Properties.Resources.pacecar_inactiva;
                            pacecar_1.Tag = "pacecar_inactiva1";
                            break;

                        case "amarillo_inactiva1":
                            for (int i = 1; i <= listBanderaCircuito1.Length; i++)
                            {
                                listBanderaCircuito1[i - 1].Image = listBanderaCircuito1Resources[i - 1];
                                listBanderaCircuito1[i - 1].Tag = listBanderaCircuito1tag[i - 1];

                            }
                            data[0] = 1;
                            data[1] = 2;
                            _port.Write(data, 0, data.Length);
                            amarillo_1.Image = global::AdvancedHMICS3FlagSerial.Properties.Resources.amarillo_activa;
                            amarillo_1.Tag = "amarillo_activa1";

                            break;
                        case "amarillo_activa1":
                            data[0] = 1;
                            data[1] = 6;
                            _port.Write(data, 0, data.Length);
                            amarillo_1.Image = global::AdvancedHMICS3FlagSerial.Properties.Resources.amarillo_inactiva;
                            amarillo_1.Tag = "amarillo_inactiva1";
                            break;

                        case "verde_inactiva1":
                            for (int i = 1; i <= listBanderaCircuito1.Length; i++)
                            {
                                listBanderaCircuito1[i - 1].Image = listBanderaCircuito1Resources[i - 1];
                                listBanderaCircuito1[i - 1].Tag = listBanderaCircuito1tag[i - 1];

                            }
                            data[0] = 1;
                            data[1] = 5;
                            _port.Write(data, 0, data.Length);
                            verde_1.Image = global::AdvancedHMICS3FlagSerial.Properties.Resources.verde_activa;
                            verde_1.Tag = "verde_activa1";

                            break;
                        case "verde_activa1":
                            data[0] = 1;
                            data[1] = 6;
                            _port.Write(data, 0, data.Length);
                            verde_1.Image = global::AdvancedHMICS3FlagSerial.Properties.Resources.verde_inactiva;
                            verde_1.Tag = "verde_inactiva1";
                            break;

                        case "azul_inactiva1":
                            for (int i = 1; i <= listBanderaCircuito1.Length; i++)
                            {
                                listBanderaCircuito1[i - 1].Image = listBanderaCircuito1Resources[i - 1];
                                listBanderaCircuito1[i - 1].Tag = listBanderaCircuito1tag[i - 1];

                            }
                            data[0] = 1;
                            data[1] = 3;
                            _port.Write(data, 0, data.Length);
                            azul_1.Image = global::AdvancedHMICS3FlagSerial.Properties.Resources.azul_activa;
                            azul_1.Tag = "azul_activa1";

                            break;
                        case "azul_activa1":
                            data[0] = 1;
                            data[1] = 6;
                            _port.Write(data, 0, data.Length);
                            azul_1.Image = global::AdvancedHMICS3FlagSerial.Properties.Resources.azul_inactiva;
                            azul_1.Tag = "azul_inactiva1";
                            break;


                        case "roja_inactiva1":
                            for (int i = 1; i <= listBanderaCircuito1.Length; i++)
                            {
                                listBanderaCircuito1[i - 1].Image = listBanderaCircuito1Resources[i - 1];
                                listBanderaCircuito1[i - 1].Tag = listBanderaCircuito1tag[i - 1];

                            }
                            data[0] = 1;
                            data[1] = 4;
                            _port.Write(data, 0, data.Length);
                            roja_1.Image = global::AdvancedHMICS3FlagSerial.Properties.Resources.rojas_activa;
                            roja_1.Tag = "roja_activa1";

                            break;
                        case "roja_activa1":
                            data[0] = 1;
                            data[1] = 6;
                            _port.Write(data, 0, data.Length);
                            roja_1.Image = global::AdvancedHMICS3FlagSerial.Properties.Resources.rojas_inactiva;
                            roja_1.Tag = "roja_inactiva1";
                            break;

                        default:
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Problemas con el puerto");
            }
      
        }


        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            _port.Close();
            _port = null;
            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
            btnConectar.BackColor = Color.Transparent;

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_port != null)
                _port.Close();
        }

    }
}
