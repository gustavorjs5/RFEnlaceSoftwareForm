namespace WaterTank
{
    partial class WaterTank
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaterTank));
            this.waterPump = new AdvancedHMIControls.WaterPump();
            this.ethernetIPforCLXCom1 = new AdvancedHMIDrivers.EthernetIPforCLXCom(this.components);
            this.tank1 = new AdvancedHMIControls.Tank();
            this.pipe1 = new AdvancedHMIControls.Pipe();
            this.pipe2 = new AdvancedHMIControls.Pipe();
            this.pipe3 = new AdvancedHMIControls.Pipe();
            this.pipe4 = new AdvancedHMIControls.Pipe();
            this.pipe5 = new AdvancedHMIControls.Pipe();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSeleccionPuerto = new System.Windows.Forms.ComboBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.analogValueDisplay1 = new AdvancedHMIControls.AnalogValueDisplay();
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // waterPump
            // 
            this.waterPump.ComComponent = this.ethernetIPforCLXCom1;
            this.waterPump.Location = new System.Drawing.Point(577, 314);
            this.waterPump.Name = "waterPump";
            this.waterPump.PLCAddressText = "";
            this.waterPump.PLCAddressValue = "";
            this.waterPump.PLCAddressVisible = "";
            this.waterPump.Size = new System.Drawing.Size(139, 105);
            this.waterPump.SuppressErrorDisplay = true;
            this.waterPump.TabIndex = 0;
            this.waterPump.Value = false;
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
            // tank1
            // 
            this.tank1.ComComponent = this.ethernetIPforCLXCom1;
            this.tank1.HighlightColor = System.Drawing.Color.Red;
            this.tank1.HighlightKeyCharacter = "!";
            this.tank1.KeypadText = null;
            this.tank1.Location = new System.Drawing.Point(139, 126);
            this.tank1.MaxValue = 1030;
            this.tank1.MinValue = 0;
            this.tank1.Name = "tank1";
            this.tank1.NumericFormat = "9";
            this.tank1.PLCAddressKeypad = "";
            this.tank1.PLCAddressText = "";
            this.tank1.PLCAddressValue = "";
            this.tank1.PLCAddressVisible = "";
            this.tank1.ScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tank1.Size = new System.Drawing.Size(94, 162);
            this.tank1.TabIndex = 1;
            this.tank1.TankContentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.tank1.TextPrefix = "";
            this.tank1.TextSuffix = null;
            this.tank1.UseWaitCursor = true;
            this.tank1.Value = 0F;
            this.tank1.ValueScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pipe1
            // 
            this.pipe1.BackColor = System.Drawing.Color.MediumBlue;
            this.pipe1.ComComponent = this.ethernetIPforCLXCom1;
            this.pipe1.Fitting = MfgControl.AdvancedHMI.Controls.Pipe.FittingType.Straight;
            this.pipe1.HighlightColor = System.Drawing.Color.Lime;
            this.pipe1.HighlightKeyCharacter = "!";
            this.pipe1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pipe1.KeypadText = null;
            this.pipe1.Location = new System.Drawing.Point(735, 126);
            this.pipe1.Name = "pipe1";
            this.pipe1.NumericFormat = null;
            this.pipe1.PLCAddressKeypad = "";
            this.pipe1.PLCAddressRotate = "";
            this.pipe1.PLCAddressText = "";
            this.pipe1.PLCAddressVisible = "";
            this.pipe1.Rotation = System.Drawing.RotateFlipType.Rotate90FlipXY;
            this.pipe1.ScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pipe1.Size = new System.Drawing.Size(20, 170);
            this.pipe1.TabIndex = 1;
            this.pipe1.TextPrefix = "grfgr";
            this.pipe1.TextSuffix = null;
            this.pipe1.UseWaitCursor = true;
            // 
            // pipe2
            // 
            this.pipe2.ComComponent = this.ethernetIPforCLXCom1;
            this.pipe2.Fitting = MfgControl.AdvancedHMI.Controls.Pipe.FittingType.Elbow;
            this.pipe2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pipe2.HighlightColor = System.Drawing.Color.Red;
            this.pipe2.HighlightKeyCharacter = "!";
            this.pipe2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.pipe2.KeypadText = null;
            this.pipe2.Location = new System.Drawing.Point(715, 296);
            this.pipe2.Name = "pipe2";
            this.pipe2.NumericFormat = "";
            this.pipe2.PLCAddressKeypad = "";
            this.pipe2.PLCAddressRotate = "";
            this.pipe2.PLCAddressText = "";
            this.pipe2.PLCAddressVisible = "";
            this.pipe2.Rotation = System.Drawing.RotateFlipType.Rotate90FlipXY;
            this.pipe2.ScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pipe2.Size = new System.Drawing.Size(42, 77);
            this.pipe2.TabIndex = 3;
            this.pipe2.TextPrefix = "";
            this.pipe2.TextSuffix = null;
            this.pipe2.UseWaitCursor = true;
            // 
            // pipe3
            // 
            this.pipe3.ComComponent = this.ethernetIPforCLXCom1;
            this.pipe3.Fitting = MfgControl.AdvancedHMI.Controls.Pipe.FittingType.Straight;
            this.pipe3.HighlightColor = System.Drawing.Color.Red;
            this.pipe3.HighlightKeyCharacter = "!";
            this.pipe3.KeypadText = null;
            this.pipe3.Location = new System.Drawing.Point(210, 86);
            this.pipe3.Name = "pipe3";
            this.pipe3.NumericFormat = null;
            this.pipe3.PLCAddressKeypad = "";
            this.pipe3.PLCAddressRotate = "";
            this.pipe3.PLCAddressText = "";
            this.pipe3.PLCAddressVisible = "";
            this.pipe3.Rotation = System.Drawing.RotateFlipType.RotateNoneFlipNone;
            this.pipe3.ScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pipe3.Size = new System.Drawing.Size(493, 19);
            this.pipe3.TabIndex = 4;
            this.pipe3.TextPrefix = null;
            this.pipe3.TextSuffix = null;
            // 
            // pipe4
            // 
            this.pipe4.ComComponent = this.ethernetIPforCLXCom1;
            this.pipe4.Fitting = MfgControl.AdvancedHMI.Controls.Pipe.FittingType.Elbow;
            this.pipe4.HighlightColor = System.Drawing.Color.Red;
            this.pipe4.HighlightKeyCharacter = "!";
            this.pipe4.KeypadText = null;
            this.pipe4.Location = new System.Drawing.Point(700, 82);
            this.pipe4.Name = "pipe4";
            this.pipe4.NumericFormat = null;
            this.pipe4.PLCAddressKeypad = "";
            this.pipe4.PLCAddressRotate = "";
            this.pipe4.PLCAddressText = "";
            this.pipe4.PLCAddressVisible = "";
            this.pipe4.Rotation = System.Drawing.RotateFlipType.Rotate270FlipY;
            this.pipe4.ScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pipe4.Size = new System.Drawing.Size(64, 46);
            this.pipe4.TabIndex = 5;
            this.pipe4.TextPrefix = null;
            this.pipe4.TextSuffix = null;
            // 
            // pipe5
            // 
            this.pipe5.ComComponent = this.ethernetIPforCLXCom1;
            this.pipe5.Fitting = MfgControl.AdvancedHMI.Controls.Pipe.FittingType.Elbow;
            this.pipe5.HighlightColor = System.Drawing.Color.Red;
            this.pipe5.HighlightKeyCharacter = "";
            this.pipe5.KeypadText = null;
            this.pipe5.Location = new System.Drawing.Point(168, 82);
            this.pipe5.Name = "pipe5";
            this.pipe5.NumericFormat = null;
            this.pipe5.PLCAddressKeypad = "";
            this.pipe5.PLCAddressRotate = "";
            this.pipe5.PLCAddressText = "";
            this.pipe5.PLCAddressVisible = "";
            this.pipe5.Rotation = System.Drawing.RotateFlipType.Rotate270FlipXY;
            this.pipe5.ScaleFactor = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pipe5.Size = new System.Drawing.Size(73, 46);
            this.pipe5.TabIndex = 6;
            this.pipe5.TextPrefix = null;
            this.pipe5.TextSuffix = null;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(239, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 27);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(730, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 170);
            this.label2.TabIndex = 8;
            // 
            // cboSeleccionPuerto
            // 
            this.cboSeleccionPuerto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboSeleccionPuerto.FormattingEnabled = true;
            this.cboSeleccionPuerto.Location = new System.Drawing.Point(12, 63);
            this.cboSeleccionPuerto.Name = "cboSeleccionPuerto";
            this.cboSeleccionPuerto.Size = new System.Drawing.Size(127, 21);
            this.cboSeleccionPuerto.TabIndex = 68;
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.Lime;
            this.btnConectar.Location = new System.Drawing.Point(12, 90);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(98, 26);
            this.btnConectar.TabIndex = 69;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 35);
            this.label3.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(720, 25);
            this.label4.TabIndex = 71;
            this.label4.Text = "Sistema SCADA- Visualización de Nivel de Tanque / Estado Bomba";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 294);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(227, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 73;
            this.label5.Text = "Tanque";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(600, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 74;
            this.label6.Text = "Bomba";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(100, 23);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // analogValueDisplay1
            // 
            this.analogValueDisplay1.ComComponent = this.ethernetIPforCLXCom1;
            this.analogValueDisplay1.ForeColor = System.Drawing.Color.White;
            this.analogValueDisplay1.ForeColorInLimits = System.Drawing.Color.Black;
            this.analogValueDisplay1.ForeColorOverLimit = System.Drawing.Color.Red;
            this.analogValueDisplay1.ForeColorUnderLimit = System.Drawing.Color.Yellow;
            this.analogValueDisplay1.KeypadFontColor = System.Drawing.Color.BlanchedAlmond;
            this.analogValueDisplay1.KeypadMaxValue = 0D;
            this.analogValueDisplay1.KeypadMinValue = 0D;
            this.analogValueDisplay1.KeypadPasscode = null;
            this.analogValueDisplay1.KeypadScaleFactor = 1D;
            this.analogValueDisplay1.KeypadText = null;
            this.analogValueDisplay1.KeypadWidth = 300;
            this.analogValueDisplay1.Location = new System.Drawing.Point(503, 282);
            this.analogValueDisplay1.Name = "analogValueDisplay1";
            this.analogValueDisplay1.NumericFormat = null;
            this.analogValueDisplay1.PLCAddressKeypad = "";
            this.analogValueDisplay1.PLCAddressValue = null;
            this.analogValueDisplay1.PLCAddressValueLimitLower = null;
            this.analogValueDisplay1.PLCAddressValueLimitUpper = null;
            this.analogValueDisplay1.PLCAddressVisible = null;
            this.analogValueDisplay1.ShowValue = true;
            this.analogValueDisplay1.Size = new System.Drawing.Size(100, 50);
            this.analogValueDisplay1.TabIndex = 75;
            this.analogValueDisplay1.Text = "0000";
            this.analogValueDisplay1.Value = "0000";
            this.analogValueDisplay1.ValueLimitLower = -999999D;
            this.analogValueDisplay1.ValueLimitUpper = 999999D;
            this.analogValueDisplay1.ValuePrefix = null;
            this.analogValueDisplay1.ValueSuffix = null;
            this.analogValueDisplay1.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always;
            this.analogValueDisplay1.Click += new System.EventHandler(this.analogValueDisplay1_Click);
            // 
            // WaterTank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.analogValueDisplay1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.cboSeleccionPuerto);
            this.Controls.Add(this.pipe5);
            this.Controls.Add(this.pipe4);
            this.Controls.Add(this.pipe3);
            this.Controls.Add(this.pipe2);
            this.Controls.Add(this.pipe1);
            this.Controls.Add(this.tank1);
            this.Controls.Add(this.waterPump);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "WaterTank";
            this.Text = "SISTEMA SCADA RF ENLACES";
            this.Load += new System.EventHandler(this.WaterTank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ethernetIPforCLXCom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdvancedHMIControls.WaterPump waterPump;
        private AdvancedHMIControls.Tank tank1;
        private AdvancedHMIControls.Pipe pipe1;
        private AdvancedHMIControls.Pipe pipe2;
        private AdvancedHMIControls.Pipe pipe3;
        private AdvancedHMIControls.Pipe pipe4;
        private AdvancedHMIControls.Pipe pipe5;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private AdvancedHMIDrivers.EthernetIPforCLXCom ethernetIPforCLXCom1;
        private System.Windows.Forms.ComboBox cboSeleccionPuerto;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList imageList1;
        private AdvancedHMIControls.AnalogValueDisplay analogValueDisplay1;
    }
}

