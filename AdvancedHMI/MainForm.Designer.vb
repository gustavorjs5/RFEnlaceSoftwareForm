<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '   <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QuickStartLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ForceItemsIntoToolBox1 = New MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox()
        Me.LicenseNote = New System.Windows.Forms.Label()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.MessageDisplayByValue1 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MessageDisplayByValue2 = New AdvancedHMIControls.MessageDisplayByValue()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 662)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "For Development Source Code Visit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "http://www.advancedhmi.com"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'QuickStartLabel
        '
        Me.QuickStartLabel.AutoSize = True
        Me.QuickStartLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.QuickStartLabel.ForeColor = System.Drawing.Color.White
        Me.QuickStartLabel.Location = New System.Drawing.Point(9, 16)
        Me.QuickStartLabel.Name = "QuickStartLabel"
        Me.QuickStartLabel.Size = New System.Drawing.Size(273, 104)
        Me.QuickStartLabel.TabIndex = 38
        Me.QuickStartLabel.Text = resources.GetString("QuickStartLabel.Text")
        Me.QuickStartLabel.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(450, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(322, 47)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'LicenseNote
        '
        Me.LicenseNote.AutoSize = True
        Me.LicenseNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LicenseNote.ForeColor = System.Drawing.Color.White
        Me.LicenseNote.Location = New System.Drawing.Point(19, 264)
        Me.LicenseNote.Name = "LicenseNote"
        Me.LicenseNote.Size = New System.Drawing.Size(746, 32)
        Me.LicenseNote.TabIndex = 53
        Me.LicenseNote.Text = "By Using This Software You Agree to the UsageAndLicense.txt" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "AdvancedHMI is licen" &
    "sed under a GPL model which means you must pass on the full source to the end us" &
    "er."
        Me.LicenseNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LicenseNote.Visible = False
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "192.168.0.10"
        Me.EthernetIPforCLXCom1.PollRateOverride = 500
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 0
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'MessageDisplayByValue1
        '
        Me.MessageDisplayByValue1.BackColor = System.Drawing.Color.Transparent
        Me.MessageDisplayByValue1.ComComponent = Me.EthernetIPforCLXCom1
        Me.MessageDisplayByValue1.ForeColor = System.Drawing.Color.Transparent
        Me.MessageDisplayByValue1.HighlightColor = System.Drawing.Color.Red
        Me.MessageDisplayByValue1.HighlightColor2 = System.Drawing.Color.Red
        Me.MessageDisplayByValue1.HighlightKeyCharacter = "!"
        Me.MessageDisplayByValue1.HighlightKeyCharacter2 = "."
        Me.MessageDisplayByValue1.IniFileName = "Messages.txt"
        Me.MessageDisplayByValue1.Location = New System.Drawing.Point(171, 155)
        Me.MessageDisplayByValue1.Name = "MessageDisplayByValue1"
        Me.MessageDisplayByValue1.PLCAddressValue = ""
        Me.MessageDisplayByValue1.PLCAddressVisible = ""
        Me.MessageDisplayByValue1.ShowMessageNumber = False
        Me.MessageDisplayByValue1.Size = New System.Drawing.Size(459, 46)
        Me.MessageDisplayByValue1.SpeakMessage = False
        Me.MessageDisplayByValue1.TabIndex = 54
        Me.MessageDisplayByValue1.Text = "Undefined Message for 0"
        Me.MessageDisplayByValue1.TextPrefix = Nothing
        Me.MessageDisplayByValue1.Value = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(339, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 36)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Increment"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MessageDisplayByValue2
        '
        Me.MessageDisplayByValue2.BackColor = System.Drawing.Color.Transparent
        Me.MessageDisplayByValue2.ComComponent = Me.EthernetIPforCLXCom1
        Me.MessageDisplayByValue2.ForeColor = System.Drawing.Color.Transparent
        Me.MessageDisplayByValue2.HighlightColor = System.Drawing.Color.Red
        Me.MessageDisplayByValue2.HighlightColor2 = System.Drawing.Color.Red
        Me.MessageDisplayByValue2.HighlightKeyCharacter = "!"
        Me.MessageDisplayByValue2.HighlightKeyCharacter2 = "."
        Me.MessageDisplayByValue2.IniFileName = ""
        Me.MessageDisplayByValue2.Location = New System.Drawing.Point(171, 213)
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages3"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages4"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages5"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages6"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Name = "MessageDisplayByValue2"
        Me.MessageDisplayByValue2.PLCAddressValue = ""
        Me.MessageDisplayByValue2.PLCAddressVisible = ""
        Me.MessageDisplayByValue2.ShowMessageNumber = False
        Me.MessageDisplayByValue2.Size = New System.Drawing.Size(459, 46)
        Me.MessageDisplayByValue2.SpeakMessage = False
        Me.MessageDisplayByValue2.TabIndex = 56
        Me.MessageDisplayByValue2.Text = "Undefined Message for 0"
        Me.MessageDisplayByValue2.TextPrefix = Nothing
        Me.MessageDisplayByValue2.Value = 0
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.MessageDisplayByValue2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MessageDisplayByValue1)
        Me.Controls.Add(Me.LicenseNote)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.QuickStartLabel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AdvancedHMI v3.99w"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents QuickStartLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ForceItemsIntoToolBox1 As MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox
    Friend WithEvents LicenseNote As Label
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents MessageDisplayByValue1 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents Button1 As Button
    Friend WithEvents MessageDisplayByValue2 As AdvancedHMIControls.MessageDisplayByValue
End Class
