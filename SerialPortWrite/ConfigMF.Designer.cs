namespace SerialPortWrite
{
    partial class ConfigMF
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigMF));
            this.serialPort = new System.Windows.Forms.ComboBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnCambiarDireccion = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVelocidad = new System.Windows.Forms.Button();
            this.cmbBoxVelocidad = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.FormattingEnabled = true;
            this.serialPort.Location = new System.Drawing.Point(15, 104);
            this.serialPort.Name = "serialPort";
            this.serialPort.Size = new System.Drawing.Size(73, 21);
            this.serialPort.TabIndex = 0;
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(94, 102);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(93, 24);
            this.btnConectar.TabIndex = 1;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(108, 163);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(79, 20);
            this.txtDireccion.TabIndex = 2;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // btnCambiarDireccion
            // 
            this.btnCambiarDireccion.Location = new System.Drawing.Point(193, 162);
            this.btnCambiarDireccion.Name = "btnCambiarDireccion";
            this.btnCambiarDireccion.Size = new System.Drawing.Size(76, 21);
            this.btnCambiarDireccion.TabIndex = 3;
            this.btnCambiarDireccion.Text = "OK";
            this.btnCambiarDireccion.UseVisualStyleBackColor = true;
            this.btnCambiarDireccion.Click += new System.EventHandler(this.btnCambiarDireccion_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.Location = new System.Drawing.Point(193, 102);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(91, 24);
            this.btnDesconectar.TabIndex = 5;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Ingrese Dirección";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 66);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección Puerto Serie";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 52);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parámetros Modbus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Buad Rate";
            // 
            // btnVelocidad
            // 
            this.btnVelocidad.Location = new System.Drawing.Point(180, 16);
            this.btnVelocidad.Name = "btnVelocidad";
            this.btnVelocidad.Size = new System.Drawing.Size(76, 21);
            this.btnVelocidad.TabIndex = 80;
            this.btnVelocidad.Text = "OK";
            this.btnVelocidad.UseVisualStyleBackColor = true;
            this.btnVelocidad.Click += new System.EventHandler(this.btnVelocidad_Click);
            // 
            // cmbBoxVelocidad
            // 
            this.cmbBoxVelocidad.FormattingEnabled = true;
            this.cmbBoxVelocidad.Location = new System.Drawing.Point(95, 16);
            this.cmbBoxVelocidad.Name = "cmbBoxVelocidad";
            this.cmbBoxVelocidad.Size = new System.Drawing.Size(78, 21);
            this.cmbBoxVelocidad.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbBoxVelocidad);
            this.groupBox3.Controls.Add(this.btnVelocidad);
            this.groupBox3.Location = new System.Drawing.Point(13, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 52);
            this.groupBox3.TabIndex = 79;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RS485";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // ConfigMF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 285);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnCambiarDireccion);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.serialPort);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "ConfigMF";
            this.Text = "ConfigMF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox serialPort;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnCambiarDireccion;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbBoxVelocidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVelocidad;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

