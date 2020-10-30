namespace AdvancedHMIcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRele1 = new AdvancedHMIControls.MomentaryButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDevice = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.cboSeleccionPuerto = new System.Windows.Forms.ComboBox();
            this.btnRele2 = new AdvancedHMIControls.MomentaryButton();
            this.btnRele3 = new AdvancedHMIControls.MomentaryButton();
            this.btnRele4 = new AdvancedHMIControls.MomentaryButton();
            this.btnOnAll = new AdvancedHMIControls.BasicButton();
            this.btnOffAll = new AdvancedHMIControls.BasicButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ethernetIPforCLXCom1 = new AdvancedHMIDrivers.EthernetIPforCLXCom(this.components);
            this.digitalPanelMeter1 = new AdvancedHMIControls.DigitalPanelMeter();
            this.pilotLight1 = new AdvancedHMIControls.PilotLight();
            this.pilotLight2 = new AdvancedHMIControls.PilotLight();
            this.digitalPanelMeter2 = new AdvancedHMIControls.DigitalPanelMeter();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox1.BackgroundImage")));
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox1.Location = new System.Drawing.Point(409, -3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(374, 153);
            this.PictureBox1.TabIndex = 45;
            this.PictureBox1.TabStop = false;
            // 
            // btnRele1
            // 
            this.btnRele1.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
            this.btnRele1.ComComponent = this.ethernetIPforCLXCom1;
            this.btnRele1.LegendPlate = MfgControl.AdvancedHMI.Controls.PushButton.LegendPlates.Large;
            this.btnRele1.Location = new System.Drawing.Point(51, 384);
            this.btnRele1.MaximumHoldTime = 3000;
            this.btnRele1.MinimumHoldTime = 500;
            this.btnRele1.Name = "btnRele1";
            this.btnRele1.OutputType = MfgControl.AdvancedHMI.Controls.PushButton.OutputTypes.MomentarySet;
            this.btnRele1.PLCAddressClick = "";
            this.btnRele1.PLCAddressVisible = "";
            this.btnRele1.Size = new System.Drawing.Size(75, 110);
            this.btnRele1.TabIndex = 59;
            this.btnRele1.Text = "OUT1";
            this.btnRele1.Click += new System.EventHandler(this.btnRele1_Click);
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
            // txtDevice
            // 
            this.txtDevice.Location = new System.Drawing.Point(73, 39);
            this.txtDevice.Name = "txtDevice";
            this.txtDevice.Size = new System.Drawing.Size(63, 20);
            this.txtDevice.TabIndex = 69;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(15, 65);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 68;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // cboSeleccionPuerto
            // 
            this.cboSeleccionPuerto.FormattingEnabled = true;
            this.cboSeleccionPuerto.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20"});
            this.cboSeleccionPuerto.Location = new System.Drawing.Point(15, 12);
            this.cboSeleccionPuerto.Name = "cboSeleccionPuerto";
            this.cboSeleccionPuerto.Size = new System.Drawing.Size(121, 21);
            this.cboSeleccionPuerto.TabIndex = 67;
            // 
            // btnRele2
            // 
            this.btnRele2.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
            this.btnRele2.ComComponent = this.ethernetIPforCLXCom1;
            this.btnRele2.LegendPlate = MfgControl.AdvancedHMI.Controls.PushButton.LegendPlates.Large;
            this.btnRele2.Location = new System.Drawing.Point(141, 384);
            this.btnRele2.MaximumHoldTime = 3000;
            this.btnRele2.MinimumHoldTime = 500;
            this.btnRele2.Name = "btnRele2";
            this.btnRele2.OutputType = MfgControl.AdvancedHMI.Controls.PushButton.OutputTypes.MomentarySet;
            this.btnRele2.PLCAddressClick = "";
            this.btnRele2.PLCAddressVisible = "";
            this.btnRele2.Size = new System.Drawing.Size(75, 110);
            this.btnRele2.TabIndex = 71;
            this.btnRele2.Text = "OUT2";
            this.btnRele2.Click += new System.EventHandler(this.btnRele2_Click);
            // 
            // btnRele3
            // 
            this.btnRele3.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
            this.btnRele3.ComComponent = this.ethernetIPforCLXCom1;
            this.btnRele3.LegendPlate = MfgControl.AdvancedHMI.Controls.PushButton.LegendPlates.Large;
            this.btnRele3.Location = new System.Drawing.Point(232, 384);
            this.btnRele3.MaximumHoldTime = 3000;
            this.btnRele3.MinimumHoldTime = 500;
            this.btnRele3.Name = "btnRele3";
            this.btnRele3.OutputType = MfgControl.AdvancedHMI.Controls.PushButton.OutputTypes.MomentarySet;
            this.btnRele3.PLCAddressClick = "";
            this.btnRele3.PLCAddressVisible = "";
            this.btnRele3.Size = new System.Drawing.Size(75, 110);
            this.btnRele3.TabIndex = 72;
            this.btnRele3.Text = "OUT3";
            this.btnRele3.Click += new System.EventHandler(this.btnRele3_Click);
            // 
            // btnRele4
            // 
            this.btnRele4.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red;
            this.btnRele4.ComComponent = this.ethernetIPforCLXCom1;
            this.btnRele4.LegendPlate = MfgControl.AdvancedHMI.Controls.PushButton.LegendPlates.Large;
            this.btnRele4.Location = new System.Drawing.Point(328, 384);
            this.btnRele4.MaximumHoldTime = 3000;
            this.btnRele4.MinimumHoldTime = 500;
            this.btnRele4.Name = "btnRele4";
            this.btnRele4.OutputType = MfgControl.AdvancedHMI.Controls.PushButton.OutputTypes.MomentarySet;
            this.btnRele4.PLCAddressClick = "";
            this.btnRele4.PLCAddressVisible = "";
            this.btnRele4.Size = new System.Drawing.Size(75, 110);
            this.btnRele4.TabIndex = 73;
            this.btnRele4.Text = "OUT4";
            this.btnRele4.Click += new System.EventHandler(this.btnRele4_Click);
            // 
            // btnOnAll
            // 
            this.btnOnAll.BackColor = System.Drawing.Color.Black;
            this.btnOnAll.ComComponent = this.ethernetIPforCLXCom1;
            this.btnOnAll.ForeColor = System.Drawing.Color.Black;
            this.btnOnAll.ForeColorAltername = System.Drawing.Color.Black;
            this.btnOnAll.Highlight = false;
            this.btnOnAll.HighlightColor = System.Drawing.Color.Green;
            this.btnOnAll.Location = new System.Drawing.Point(438, 384);
            this.btnOnAll.MaximumHoldTime = 3000;
            this.btnOnAll.MinimumHoldTime = 500;
            this.btnOnAll.Name = "btnOnAll";
            this.btnOnAll.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.btnOnAll.PLCAddressClick = "";
            this.btnOnAll.SelectTextAlternate = false;
            this.btnOnAll.Size = new System.Drawing.Size(123, 33);
            this.btnOnAll.TabIndex = 74;
            this.btnOnAll.Text = "Encender Todas";
            this.btnOnAll.TextAlternate = null;
            this.btnOnAll.UseVisualStyleBackColor = true;
            this.btnOnAll.ValueToWrite = 0;
            this.btnOnAll.Click += new System.EventHandler(this.btnOnAll_Click);
            // 
            // btnOffAll
            // 
            this.btnOffAll.BackColor = System.Drawing.Color.Black;
            this.btnOffAll.ComComponent = this.ethernetIPforCLXCom1;
            this.btnOffAll.ForeColor = System.Drawing.Color.Black;
            this.btnOffAll.ForeColorAltername = System.Drawing.Color.Black;
            this.btnOffAll.Highlight = false;
            this.btnOffAll.HighlightColor = System.Drawing.Color.Green;
            this.btnOffAll.Location = new System.Drawing.Point(438, 445);
            this.btnOffAll.MaximumHoldTime = 3000;
            this.btnOffAll.MinimumHoldTime = 500;
            this.btnOffAll.Name = "btnOffAll";
            this.btnOffAll.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.btnOffAll.PLCAddressClick = "";
            this.btnOffAll.SelectTextAlternate = false;
            this.btnOffAll.Size = new System.Drawing.Size(123, 33);
            this.btnOffAll.TabIndex = 75;
            this.btnOffAll.Text = "Apagar Todas";
            this.btnOffAll.TextAlternate = null;
            this.btnOffAll.UseVisualStyleBackColor = true;
            this.btnOffAll.ValueToWrite = 0;
            this.btnOffAll.Click += new System.EventHandler(this.btnOffAll_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // digitalPanelMeter1
            // 
            this.digitalPanelMeter1.BackColor = System.Drawing.Color.Transparent;
            this.digitalPanelMeter1.ComComponent = this.ethernetIPforCLXCom1;
            this.digitalPanelMeter1.DecimalPosition = 0;
            this.digitalPanelMeter1.ForeColor = System.Drawing.Color.LightGray;
            this.digitalPanelMeter1.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.digitalPanelMeter1.KeypadMaxValue = 0D;
            this.digitalPanelMeter1.KeypadMinValue = 0D;
            this.digitalPanelMeter1.KeypadScaleFactor = 1D;
            this.digitalPanelMeter1.KeypadText = null;
            this.digitalPanelMeter1.KeypadWidth = 300;
            this.digitalPanelMeter1.Location = new System.Drawing.Point(41, 122);
            this.digitalPanelMeter1.Name = "digitalPanelMeter1";
            this.digitalPanelMeter1.NumberOfDigits = 5;
            this.digitalPanelMeter1.PLCAddressKeypad = "";
            this.digitalPanelMeter1.Resolution = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitalPanelMeter1.Size = new System.Drawing.Size(221, 96);
            this.digitalPanelMeter1.TabIndex = 76;
            this.digitalPanelMeter1.Text = "IN1 ANALOGICA";
            this.digitalPanelMeter1.Value = 10D;
            this.digitalPanelMeter1.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitalPanelMeter1.ValueScaleOffset = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // pilotLight1
            // 
            this.pilotLight1.Blink = false;
            this.pilotLight1.ComComponent = this.ethernetIPforCLXCom1;
            this.pilotLight1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.pilotLight1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.pilotLight1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White;
            this.pilotLight1.Location = new System.Drawing.Point(385, 168);
            this.pilotLight1.Name = "pilotLight1";
            this.pilotLight1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.pilotLight1.PLCAddressClick = "";
            this.pilotLight1.PLCAddressText = "";
            this.pilotLight1.PLCAddressValue = "";
            this.pilotLight1.PLCAddressVisible = "";
            this.pilotLight1.Size = new System.Drawing.Size(75, 110);
            this.pilotLight1.TabIndex = 77;
            this.pilotLight1.Text = "IN1";
            this.pilotLight1.Value = false;
            this.pilotLight1.ValueToWrite = 0;
            // 
            // pilotLight2
            // 
            this.pilotLight2.Blink = false;
            this.pilotLight2.ComComponent = this.ethernetIPforCLXCom1;
            this.pilotLight2.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large;
            this.pilotLight2.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green;
            this.pilotLight2.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White;
            this.pilotLight2.Location = new System.Drawing.Point(486, 168);
            this.pilotLight2.Name = "pilotLight2";
            this.pilotLight2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet;
            this.pilotLight2.PLCAddressClick = "";
            this.pilotLight2.PLCAddressText = "";
            this.pilotLight2.PLCAddressValue = "";
            this.pilotLight2.PLCAddressVisible = "";
            this.pilotLight2.Size = new System.Drawing.Size(75, 110);
            this.pilotLight2.TabIndex = 78;
            this.pilotLight2.Text = "IN2";
            this.pilotLight2.Value = false;
            this.pilotLight2.ValueToWrite = 0;
            // 
            // digitalPanelMeter2
            // 
            this.digitalPanelMeter2.BackColor = System.Drawing.Color.Transparent;
            this.digitalPanelMeter2.ComComponent = this.ethernetIPforCLXCom1;
            this.digitalPanelMeter2.DecimalPosition = 0;
            this.digitalPanelMeter2.ForeColor = System.Drawing.Color.LightGray;
            this.digitalPanelMeter2.KeypadFontColor = System.Drawing.Color.WhiteSmoke;
            this.digitalPanelMeter2.KeypadMaxValue = 0D;
            this.digitalPanelMeter2.KeypadMinValue = 0D;
            this.digitalPanelMeter2.KeypadScaleFactor = 1D;
            this.digitalPanelMeter2.KeypadText = null;
            this.digitalPanelMeter2.KeypadWidth = 300;
            this.digitalPanelMeter2.Location = new System.Drawing.Point(41, 233);
            this.digitalPanelMeter2.Name = "digitalPanelMeter2";
            this.digitalPanelMeter2.NumberOfDigits = 5;
            this.digitalPanelMeter2.PLCAddressKeypad = "";
            this.digitalPanelMeter2.Resolution = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitalPanelMeter2.Size = new System.Drawing.Size(221, 96);
            this.digitalPanelMeter2.TabIndex = 79;
            this.digitalPanelMeter2.Text = "IN2 ANALOGICA";
            this.digitalPanelMeter2.Value = 10D;
            this.digitalPanelMeter2.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitalPanelMeter2.ValueScaleOffset = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.digitalPanelMeter2);
            this.Controls.Add(this.pilotLight2);
            this.Controls.Add(this.pilotLight1);
            this.Controls.Add(this.digitalPanelMeter1);
            this.Controls.Add(this.btnOffAll);
            this.Controls.Add(this.btnOnAll);
            this.Controls.Add(this.btnRele4);
            this.Controls.Add(this.btnRele3);
            this.Controls.Add(this.btnRele2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDevice);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.cboSeleccionPuerto);
            this.Controls.Add(this.btnRele1);
            this.Controls.Add(this.PictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Text = "AdvancedHMI V3.99w";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        private AdvancedHMIControls.MomentaryButton btnRele1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDevice;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ComboBox cboSeleccionPuerto;
        private AdvancedHMIControls.MomentaryButton btnRele2;
        private AdvancedHMIControls.MomentaryButton btnRele3;
        private AdvancedHMIControls.MomentaryButton btnRele4;
        private AdvancedHMIControls.BasicButton btnOnAll;
        private AdvancedHMIControls.BasicButton btnOffAll;
        private System.Windows.Forms.Timer timer1;
        private AdvancedHMIDrivers.EthernetIPforCLXCom ethernetIPforCLXCom1;
        private AdvancedHMIControls.DigitalPanelMeter digitalPanelMeter1;
        private AdvancedHMIControls.PilotLight pilotLight1;
        private AdvancedHMIControls.PilotLight pilotLight2;
        private AdvancedHMIControls.DigitalPanelMeter digitalPanelMeter2;
    }
}

