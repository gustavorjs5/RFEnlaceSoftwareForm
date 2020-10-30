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

namespace SerialPortWrite
{
    public partial class ConfigMF : Form
    {
        static SerialPort _port;
      
        delegate void SetTextDeleg(string text);
        public ConfigMF()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort.DataSource = SerialPort.GetPortNames();
            cmbBoxVelocidad.DataSource = new List<string>()
            {"1200","2400","9600","19200","38400","57600" };
            btnDesconectar.Enabled = false;

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            _port = new SerialPort(serialPort.SelectedItem.ToString());

            // configure serial port
            _port.BaudRate = 9600;
            _port.DataBits = 8;
            _port.Parity = Parity.None;
            _port.StopBits = StopBits.One;
            _port.ReadTimeout = 500;
            _port.WriteTimeout = 500;
            _port.DataReceived += new
       SerialDataReceivedEventHandler(port_DataReceived);
            _port.Open();

            btnConectar.Enabled = false;
            btnConectar.BackColor = Color.LimeGreen;
            btnDesconectar.Enabled = true;

            

        }
        private void port_DataReceived(object sender,
     SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(500);
            string data = _port.ReadLine();
            // Invokes the delegate on the UI thread, and sends the data that was received to the invoked method.  
            // ---- The "si_DataReceived" method will be executed on the UI thread which allows populating of the textbox.  
            this.BeginInvoke(new SetTextDeleg(drawer), new object[] { data });
        }
        private void txtDireccion_KeyPress(object sender,
        KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void btnCambiarDireccion_Click(object sender, EventArgs e)
        {
           
                if (_port!=null)
                {

                
                byte[] data = {65,Convert.ToByte(txtDireccion.Text)};
                _port.Write(data,0,data.Length);


                }
            
            else
            {
                MessageBox.Show("Problemas con el puerto");

            }



        }
  
        private void drawer(string txt)
        {

            if (txt.Substring(0,2)=="OK")
            {
                MessageBox.Show(" Dirección Cambiada!!");
            }

            if (txt.Contains("Baud Rate"))
            {
                MessageBox.Show(txt);
            }
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_port != null)
               _port.Close();
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            _port.Close();
            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
            btnConectar.BackColor = Color.Transparent;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnVelocidad_Click(object sender, EventArgs e)
        {

            if (_port != null)
            {


                byte[] data = { 66, Convert.ToByte(cmbBoxVelocidad.SelectedIndex+1) };
                _port.Write(data, 0, data.Length);


            }

            else
            {
                MessageBox.Show("Problemas con el puerto");

            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
