namespace AdvancedHMIcs3flagSerial
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.cboSeleccionPuerto = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.amarrilla_1 = new System.Windows.Forms.PictureBox();
            this.verde_1 = new System.Windows.Forms.PictureBox();
            this.roja_1 = new System.Windows.Forms.PictureBox();
            this.pacecar_1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.amarillo_2 = new System.Windows.Forms.PictureBox();
            this.verde_2 = new System.Windows.Forms.PictureBox();
            this.roja_2 = new System.Windows.Forms.PictureBox();
            this.pacecar_2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.amarillo_3 = new System.Windows.Forms.PictureBox();
            this.verde_3 = new System.Windows.Forms.PictureBox();
            this.roja_3 = new System.Windows.Forms.PictureBox();
            this.pacecar_3 = new System.Windows.Forms.PictureBox();
            this.verdesAll = new System.Windows.Forms.PictureBox();
            this.amarillaAll = new System.Windows.Forms.PictureBox();
            this.rojasALL = new System.Windows.Forms.PictureBox();
            this.pacecarALL = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.ethernetIPforCLXCom1 = new AdvancedHMIDrivers.EthernetIPforCLXCom(this.components);
            this.pilotLight1_3 = new AdvancedHMIControls.PilotLight();
            this.pilotLight2_3 = new AdvancedHMIControls.PilotLight();
            this.pilotLight1_2 = new AdvancedHMIControls.PilotLight();
            this.pilotLight2_2 = new AdvancedHMIControls.PilotLight();
            this.pilotLight1_1 = new AdvancedHMIControls.PilotLight();
            this.pilotLight2_1 = new AdvancedHMIControls.PilotLight();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amarrilla_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verde_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roja_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacecar_1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amarillo_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verde_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roja_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacecar_2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amarillo_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verde_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roja_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacecar_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdesAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amarillaAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojasALL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacecarALL)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Dirección:";
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.Lime;
            this.btnConectar.Location = new System.Drawing.Point(15, 65);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(98, 26);
            this.btnConectar.TabIndex = 68;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // cboSeleccionPuerto
            // 
            this.cboSeleccionPuerto.ForeColor = System.Drawing.Color.Lime;
            this.cboSeleccionPuerto.FormattingEnabled = true;
            this.cboSeleccionPuerto.Location = new System.Drawing.Point(15, 12);
            this.cboSeleccionPuerto.Name = "cboSeleccionPuerto";
            this.cboSeleccionPuerto.Size = new System.Drawing.Size(127, 21);
            this.cboSeleccionPuerto.TabIndex = 67;
            // 
            // timer1
            // 
            this.timer1.Interval = 1235;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.amarrilla_1);
            this.groupBox1.Controls.Add(this.verde_1);
            this.groupBox1.Controls.Add(this.roja_1);
            this.groupBox1.Controls.Add(this.pacecar_1);
            this.groupBox1.Controls.Add(this.pilotLight1_1);
            this.groupBox1.Controls.Add(this.pilotLight2_1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(2, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 312);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Circuito 1";
            // 
            // amarrilla_1
            // 
            this.amarrilla_1.Image = global::AdvancedHMICS3Flag.Properties.Resources.amarillo_inactiva;
            this.amarrilla_1.Location = new System.Drawing.Point(334, 195);
            this.amarrilla_1.Name = "amarrilla_1";
            this.amarrilla_1.Size = new System.Drawing.Size(97, 97);
            this.amarrilla_1.TabIndex = 82;
            this.amarrilla_1.TabStop = false;
            this.amarrilla_1.Tag = "amarillo_inactiva";
            this.amarrilla_1.Click += new System.EventHandler(this.amarrilla_1_Click);
            // 
            // verde_1
            // 
            this.verde_1.Image = global::AdvancedHMICS3Flag.Properties.Resources.verde_inactiva;
            this.verde_1.Location = new System.Drawing.Point(223, 195);
            this.verde_1.Name = "verde_1";
            this.verde_1.Size = new System.Drawing.Size(96, 97);
            this.verde_1.TabIndex = 81;
            this.verde_1.TabStop = false;
            this.verde_1.Tag = "verde_inactiva";
            this.verde_1.Click += new System.EventHandler(this.verde_1_Click);
            // 
            // roja_1
            // 
            this.roja_1.Image = global::AdvancedHMICS3Flag.Properties.Resources.rojas_inactiva;
            this.roja_1.Location = new System.Drawing.Point(112, 195);
            this.roja_1.Name = "roja_1";
            this.roja_1.Size = new System.Drawing.Size(97, 97);
            this.roja_1.TabIndex = 80;
            this.roja_1.TabStop = false;
            this.roja_1.Tag = "rojas_inactiva";
            this.roja_1.Click += new System.EventHandler(this.roja_1_Click);
            // 
            // pacecar_1
            // 
            this.pacecar_1.Image = global::AdvancedHMICS3Flag.Properties.Resources.pacecar_inactiva2;
            this.pacecar_1.Location = new System.Drawing.Point(3, 195);
            this.pacecar_1.Name = "pacecar_1";
            this.pacecar_1.Size = new System.Drawing.Size(97, 97);
            this.pacecar_1.TabIndex = 79;
            this.pacecar_1.TabStop = false;
            this.pacecar_1.Tag = "pacecar_inactiva2";
            this.pacecar_1.Click += new System.EventHandler(this.pacecar_1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.amarillo_2);
            this.groupBox2.Controls.Add(this.verde_2);
            this.groupBox2.Controls.Add(this.roja_2);
            this.groupBox2.Controls.Add(this.pacecar_2);
            this.groupBox2.Controls.Add(this.pilotLight1_2);
            this.groupBox2.Controls.Add(this.pilotLight2_2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Location = new System.Drawing.Point(448, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 312);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Circuito 2";
            // 
            // amarillo_2
            // 
            this.amarillo_2.Image = global::AdvancedHMICS3Flag.Properties.Resources.amarillo_inactiva;
            this.amarillo_2.Location = new System.Drawing.Point(341, 195);
            this.amarillo_2.Name = "amarillo_2";
            this.amarillo_2.Size = new System.Drawing.Size(97, 97);
            this.amarillo_2.TabIndex = 82;
            this.amarillo_2.TabStop = false;
            this.amarillo_2.Tag = "amarillo_inactiva";
            this.amarillo_2.Click += new System.EventHandler(this.amarillo_2_Click);
            // 
            // verde_2
            // 
            this.verde_2.Image = global::AdvancedHMICS3Flag.Properties.Resources.verde_inactiva;
            this.verde_2.Location = new System.Drawing.Point(230, 195);
            this.verde_2.Name = "verde_2";
            this.verde_2.Size = new System.Drawing.Size(96, 97);
            this.verde_2.TabIndex = 81;
            this.verde_2.TabStop = false;
            this.verde_2.Tag = "verde_inactiva";
            this.verde_2.Click += new System.EventHandler(this.verde_2_Click);
            // 
            // roja_2
            // 
            this.roja_2.Image = global::AdvancedHMICS3Flag.Properties.Resources.rojas_inactiva;
            this.roja_2.Location = new System.Drawing.Point(119, 195);
            this.roja_2.Name = "roja_2";
            this.roja_2.Size = new System.Drawing.Size(97, 97);
            this.roja_2.TabIndex = 80;
            this.roja_2.TabStop = false;
            this.roja_2.Tag = "rojas_inactiva";
            this.roja_2.Click += new System.EventHandler(this.roja_2_Click);
            // 
            // pacecar_2
            // 
            this.pacecar_2.Image = global::AdvancedHMICS3Flag.Properties.Resources.pacecar_inactiva2;
            this.pacecar_2.Location = new System.Drawing.Point(10, 195);
            this.pacecar_2.Name = "pacecar_2";
            this.pacecar_2.Size = new System.Drawing.Size(97, 97);
            this.pacecar_2.TabIndex = 79;
            this.pacecar_2.TabStop = false;
            this.pacecar_2.Tag = "pacecar_inactiva2";
            this.pacecar_2.Click += new System.EventHandler(this.pacecar_2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.amarillo_3);
            this.groupBox3.Controls.Add(this.verde_3);
            this.groupBox3.Controls.Add(this.roja_3);
            this.groupBox3.Controls.Add(this.pacecar_3);
            this.groupBox3.Controls.Add(this.pilotLight1_3);
            this.groupBox3.Controls.Add(this.pilotLight2_3);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox3.Location = new System.Drawing.Point(900, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(445, 312);
            this.groupBox3.TabIndex = 81;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Circuito 3";
            // 
            // amarillo_3
            // 
            this.amarillo_3.Image = global::AdvancedHMICS3Flag.Properties.Resources.amarillo_inactiva;
            this.amarillo_3.Location = new System.Drawing.Point(341, 195);
            this.amarillo_3.Name = "amarillo_3";
            this.amarillo_3.Size = new System.Drawing.Size(97, 97);
            this.amarillo_3.TabIndex = 82;
            this.amarillo_3.TabStop = false;
            this.amarillo_3.Tag = "amarillo_inactiva";
            this.amarillo_3.Click += new System.EventHandler(this.amarillo_3_Click);
            // 
            // verde_3
            // 
            this.verde_3.Image = global::AdvancedHMICS3Flag.Properties.Resources.verde_inactiva;
            this.verde_3.Location = new System.Drawing.Point(230, 195);
            this.verde_3.Name = "verde_3";
            this.verde_3.Size = new System.Drawing.Size(96, 97);
            this.verde_3.TabIndex = 81;
            this.verde_3.TabStop = false;
            this.verde_3.Tag = "verde_inactiva";
            this.verde_3.Click += new System.EventHandler(this.verde_3_Click);
            // 
            // roja_3
            // 
            this.roja_3.Image = global::AdvancedHMICS3Flag.Properties.Resources.rojas_inactiva;
            this.roja_3.Location = new System.Drawing.Point(119, 195);
            this.roja_3.Name = "roja_3";
            this.roja_3.Size = new System.Drawing.Size(97, 97);
            this.roja_3.TabIndex = 80;
            this.roja_3.TabStop = false;
            this.roja_3.Tag = "rojas_inactiva";
            this.roja_3.Click += new System.EventHandler(this.roja_3_Click);
            // 
            // pacecar_3
            // 
            this.pacecar_3.Image = global::AdvancedHMICS3Flag.Properties.Resources.pacecar_inactiva1;
            this.pacecar_3.Location = new System.Drawing.Point(10, 195);
            this.pacecar_3.Name = "pacecar_3";
            this.pacecar_3.Size = new System.Drawing.Size(97, 97);
            this.pacecar_3.TabIndex = 79;
            this.pacecar_3.TabStop = false;
            this.pacecar_3.Tag = "pacecar_inactiva1";
            this.pacecar_3.Click += new System.EventHandler(this.pacecar_3_Click);
            // 
            // verdesAll
            // 
            this.verdesAll.Image = global::AdvancedHMICS3Flag.Properties.Resources.verde_inactiva;
            this.verdesAll.Location = new System.Drawing.Point(314, 16);
            this.verdesAll.Name = "verdesAll";
            this.verdesAll.Size = new System.Drawing.Size(96, 97);
            this.verdesAll.TabIndex = 82;
            this.verdesAll.TabStop = false;
            this.verdesAll.Tag = "verde_inactiva";
            this.verdesAll.Click += new System.EventHandler(this.verdesAll_Click);
            // 
            // amarillaAll
            // 
            this.amarillaAll.Image = global::AdvancedHMICS3Flag.Properties.Resources.amarillo_inactiva;
            this.amarillaAll.Location = new System.Drawing.Point(429, 16);
            this.amarillaAll.Name = "amarillaAll";
            this.amarillaAll.Size = new System.Drawing.Size(97, 97);
            this.amarillaAll.TabIndex = 83;
            this.amarillaAll.TabStop = false;
            this.amarillaAll.Tag = "amarillo_inactiva";
            this.amarillaAll.Click += new System.EventHandler(this.amarillaAll_Click);
            // 
            // rojasALL
            // 
            this.rojasALL.Image = global::AdvancedHMICS3Flag.Properties.Resources.rojas_inactiva;
            this.rojasALL.Location = new System.Drawing.Point(197, 16);
            this.rojasALL.Name = "rojasALL";
            this.rojasALL.Size = new System.Drawing.Size(97, 97);
            this.rojasALL.TabIndex = 83;
            this.rojasALL.TabStop = false;
            this.rojasALL.Tag = "rojas_inactiva";
            this.rojasALL.Click += new System.EventHandler(this.rojasALL_Click);
            // 
            // pacecarALL
            // 
            this.pacecarALL.Image = global::AdvancedHMICS3Flag.Properties.Resources.pacecar_inactiva1;
            this.pacecarALL.Location = new System.Drawing.Point(84, 16);
            this.pacecarALL.Name = "pacecarALL";
            this.pacecarALL.Size = new System.Drawing.Size(97, 97);
            this.pacecarALL.TabIndex = 84;
            this.pacecarALL.TabStop = false;
            this.pacecarALL.Tag = "pacecar_inactiva1";
            this.pacecarALL.Click += new System.EventHandler(this.pacecarALL_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.OrangeRed;
            this.groupBox4.Controls.Add(this.verdesAll);
            this.groupBox4.Controls.Add(this.pacecarALL);
            this.groupBox4.Controls.Add(this.amarillaAll);
            this.groupBox4.Controls.Add(this.rojasALL);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(314, 580);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(572, 125);
            this.groupBox4.TabIndex = 85;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Todas";
            // 
            // timer2
            // 
            this.timer2.Interval = 1654;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 3000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // ethernetIPforCLXCom1
            // 
            this.ethernetIPforCLXCom1.CIPConnectionSize = 508;
            this.ethernetIPforCLXCom1.DisableMultiServiceRequest = false;
            this.ethernetIPforCLXCom1.DisableSubscriptions = false;
            this.ethernetIPforCLXCom1.IniFileName = "";
            this.ethernetIPforCLXCom1.IniFileSection = null;
            this.ethernetIPforCLXCom1.IPAddress = "192.168.0.10";
            this.ethernetIPforCLXCom1.PollRateOverride = 500;
            this.ethernetIPforCLXCom1.Port = 44818;
            this.ethernetIPforCLXCom1.ProcessorSlot = 0;
            this.ethernetIPforCLXCom1.RoutePath = null;
            this.ethernetIPforCLXCom1.Timeout = 4000;
            // 
            // pilotLight1_3
            // 
            this.pilotLight1_3.Blink = false;
            this.pilotLight1_3.ComComponent = this.ethernetIPforCLXCom1;
            this.pilotLight1_3.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.pilotLight1_3.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.pilotLight1_3.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White;
            this.pilotLight1_3.Location = new System.Drawing.Point(133, 39);
            this.pilotLight1_3.Name = "pilotLight1_3";
            this.pilotLight1_3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.pilotLight1_3.PLCAddressClick = "";
            this.pilotLight1_3.PLCAddressText = "";
            this.pilotLight1_3.PLCAddressValue = "";
            this.pilotLight1_3.PLCAddressVisible = "";
            this.pilotLight1_3.Size = new System.Drawing.Size(75, 110);
            this.pilotLight1_3.TabIndex = 77;
            this.pilotLight1_3.Text = "IN1";
            this.pilotLight1_3.Value = false;
            this.pilotLight1_3.ValueToWrite = 0;
            // 
            // pilotLight2_3
            // 
            this.pilotLight2_3.Blink = false;
            this.pilotLight2_3.ComComponent = this.ethernetIPforCLXCom1;
            this.pilotLight2_3.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.pilotLight2_3.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.pilotLight2_3.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White;
            this.pilotLight2_3.Location = new System.Drawing.Point(224, 39);
            this.pilotLight2_3.Name = "pilotLight2_3";
            this.pilotLight2_3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.pilotLight2_3.PLCAddressClick = "";
            this.pilotLight2_3.PLCAddressText = "";
            this.pilotLight2_3.PLCAddressValue = "";
            this.pilotLight2_3.PLCAddressVisible = "";
            this.pilotLight2_3.Size = new System.Drawing.Size(75, 110);
            this.pilotLight2_3.TabIndex = 78;
            this.pilotLight2_3.Text = "IN2";
            this.pilotLight2_3.Value = false;
            this.pilotLight2_3.ValueToWrite = 0;
            // 
            // pilotLight1_2
            // 
            this.pilotLight1_2.Blink = false;
            this.pilotLight1_2.ComComponent = this.ethernetIPforCLXCom1;
            this.pilotLight1_2.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.pilotLight1_2.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.pilotLight1_2.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White;
            this.pilotLight1_2.Location = new System.Drawing.Point(133, 39);
            this.pilotLight1_2.Name = "pilotLight1_2";
            this.pilotLight1_2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.pilotLight1_2.PLCAddressClick = "";
            this.pilotLight1_2.PLCAddressText = "";
            this.pilotLight1_2.PLCAddressValue = "";
            this.pilotLight1_2.PLCAddressVisible = "";
            this.pilotLight1_2.Size = new System.Drawing.Size(75, 110);
            this.pilotLight1_2.TabIndex = 77;
            this.pilotLight1_2.Text = "IN1";
            this.pilotLight1_2.Value = false;
            this.pilotLight1_2.ValueToWrite = 0;
            // 
            // pilotLight2_2
            // 
            this.pilotLight2_2.Blink = false;
            this.pilotLight2_2.ComComponent = this.ethernetIPforCLXCom1;
            this.pilotLight2_2.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.pilotLight2_2.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.pilotLight2_2.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White;
            this.pilotLight2_2.Location = new System.Drawing.Point(224, 39);
            this.pilotLight2_2.Name = "pilotLight2_2";
            this.pilotLight2_2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.pilotLight2_2.PLCAddressClick = "";
            this.pilotLight2_2.PLCAddressText = "";
            this.pilotLight2_2.PLCAddressValue = "";
            this.pilotLight2_2.PLCAddressVisible = "";
            this.pilotLight2_2.Size = new System.Drawing.Size(75, 110);
            this.pilotLight2_2.TabIndex = 78;
            this.pilotLight2_2.Text = "IN2";
            this.pilotLight2_2.Value = false;
            this.pilotLight2_2.ValueToWrite = 0;
            // 
            // pilotLight1_1
            // 
            this.pilotLight1_1.Blink = false;
            this.pilotLight1_1.ComComponent = this.ethernetIPforCLXCom1;
            this.pilotLight1_1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.pilotLight1_1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.pilotLight1_1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White;
            this.pilotLight1_1.Location = new System.Drawing.Point(133, 39);
            this.pilotLight1_1.Name = "pilotLight1_1";
            this.pilotLight1_1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.pilotLight1_1.PLCAddressClick = "";
            this.pilotLight1_1.PLCAddressText = "";
            this.pilotLight1_1.PLCAddressValue = "";
            this.pilotLight1_1.PLCAddressVisible = "";
            this.pilotLight1_1.Size = new System.Drawing.Size(75, 110);
            this.pilotLight1_1.TabIndex = 77;
            this.pilotLight1_1.Text = "IN1";
            this.pilotLight1_1.Value = false;
            this.pilotLight1_1.ValueToWrite = 0;
            // 
            // pilotLight2_1
            // 
            this.pilotLight2_1.Blink = false;
            this.pilotLight2_1.ComComponent = this.ethernetIPforCLXCom1;
            this.pilotLight2_1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.pilotLight2_1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.pilotLight2_1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White;
            this.pilotLight2_1.Location = new System.Drawing.Point(224, 39);
            this.pilotLight2_1.Name = "pilotLight2_1";
            this.pilotLight2_1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.pilotLight2_1.PLCAddressClick = "";
            this.pilotLight2_1.PLCAddressText = "";
            this.pilotLight2_1.PLCAddressValue = "";
            this.pilotLight2_1.PLCAddressVisible = "";
            this.pilotLight2_1.Size = new System.Drawing.Size(75, 110);
            this.pilotLight2_1.TabIndex = 78;
            this.pilotLight2_1.Text = "IN2";
            this.pilotLight2_1.Value = false;
            this.pilotLight2_1.ValueToWrite = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::AdvancedHMICS3Flag.Properties.Resources.racing_background;
            this.ClientSize = new System.Drawing.Size(1370, 694);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.cboSeleccionPuerto);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Text = "RFEnlaces3Flag";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.amarrilla_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verde_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roja_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacecar_1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.amarillo_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verde_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roja_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacecar_2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.amarillo_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verde_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roja_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacecar_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verdesAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amarillaAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojasALL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacecarALL)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ComboBox cboSeleccionPuerto;
        private System.Windows.Forms.Timer timer1;
        private AdvancedHMIDrivers.EthernetIPforCLXCom ethernetIPforCLXCom1;
        private AdvancedHMIControls.PilotLight pilotLight1_1;
        private AdvancedHMIControls.PilotLight pilotLight2_1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pacecar_1;
        private System.Windows.Forms.PictureBox roja_1;
        private System.Windows.Forms.PictureBox verde_1;
        private System.Windows.Forms.PictureBox amarrilla_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox amarillo_2;
        private System.Windows.Forms.PictureBox verde_2;
        private System.Windows.Forms.PictureBox roja_2;
        private System.Windows.Forms.PictureBox pacecar_2;
        private AdvancedHMIControls.PilotLight pilotLight1_2;
        private AdvancedHMIControls.PilotLight pilotLight2_2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox amarillo_3;
        private System.Windows.Forms.PictureBox verde_3;
        private System.Windows.Forms.PictureBox roja_3;
        private System.Windows.Forms.PictureBox pacecar_3;
        private AdvancedHMIControls.PilotLight pilotLight1_3;
        private AdvancedHMIControls.PilotLight pilotLight2_3;
        private System.Windows.Forms.PictureBox verdesAll;
        private System.Windows.Forms.PictureBox amarillaAll;
        private System.Windows.Forms.PictureBox rojasALL;
        private System.Windows.Forms.PictureBox pacecarALL;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

