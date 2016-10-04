<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.terminal = New System.Windows.Forms.RichTextBox()
        Me.SentrollerSearch = New System.Windows.Forms.Timer(Me.components)
        Me.afe0_mh = New System.Windows.Forms.ComboBox()
        Me.afe0_rtd = New System.Windows.Forms.ComboBox()
        Me.afe0_burd = New System.Windows.Forms.ComboBox()
        Me.afe0_hvbyp = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.afe1_hvbyp = New System.Windows.Forms.ComboBox()
        Me.afe1_burd = New System.Windows.Forms.ComboBox()
        Me.afe1_rtd = New System.Windows.Forms.ComboBox()
        Me.afe1_mh = New System.Windows.Forms.ComboBox()
        Me.afe2_hvbyp = New System.Windows.Forms.ComboBox()
        Me.afe2_burd = New System.Windows.Forms.ComboBox()
        Me.afe2_rtd = New System.Windows.Forms.ComboBox()
        Me.afe2_mh = New System.Windows.Forms.ComboBox()
        Me.afe3_hvbyp = New System.Windows.Forms.ComboBox()
        Me.afe3_burd = New System.Windows.Forms.ComboBox()
        Me.afe3_rtd = New System.Windows.Forms.ComboBox()
        Me.afe3_mh = New System.Windows.Forms.ComboBox()
        Me.afe0_mode = New System.Windows.Forms.ComboBox()
        Me.afe1_mode = New System.Windows.Forms.ComboBox()
        Me.afe2_mode = New System.Windows.Forms.ComboBox()
        Me.afe3_mode = New System.Windows.Forms.ComboBox()
        Me.afe0_gain = New System.Windows.Forms.ComboBox()
        Me.afe1_gain = New System.Windows.Forms.ComboBox()
        Me.afe2_gain = New System.Windows.Forms.ComboBox()
        Me.afe3_gain = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM69"
        '
        'terminal
        '
        Me.terminal.BackColor = System.Drawing.Color.Silver
        Me.terminal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.terminal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.terminal.ForeColor = System.Drawing.Color.Lime
        Me.terminal.Location = New System.Drawing.Point(19, 56)
        Me.terminal.Margin = New System.Windows.Forms.Padding(10, 10, 10, 100)
        Me.terminal.Name = "terminal"
        Me.terminal.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.terminal.ShowSelectionMargin = True
        Me.terminal.Size = New System.Drawing.Size(653, 532)
        Me.terminal.TabIndex = 3
        Me.terminal.Text = ""
        '
        'SentrollerSearch
        '
        Me.SentrollerSearch.Enabled = True
        '
        'afe0_mh
        '
        Me.afe0_mh.FormattingEnabled = True
        Me.afe0_mh.Items.AddRange(New Object() {"Harvest", "Meter"})
        Me.afe0_mh.Location = New System.Drawing.Point(1008, 156)
        Me.afe0_mh.Name = "afe0_mh"
        Me.afe0_mh.Size = New System.Drawing.Size(78, 21)
        Me.afe0_mh.TabIndex = 6
        '
        'afe0_rtd
        '
        Me.afe0_rtd.FormattingEnabled = True
        Me.afe0_rtd.Items.AddRange(New Object() {"RTD off", "RTD on"})
        Me.afe0_rtd.Location = New System.Drawing.Point(1092, 156)
        Me.afe0_rtd.Name = "afe0_rtd"
        Me.afe0_rtd.Size = New System.Drawing.Size(94, 21)
        Me.afe0_rtd.TabIndex = 6
        '
        'afe0_burd
        '
        Me.afe0_burd.FormattingEnabled = True
        Me.afe0_burd.Items.AddRange(New Object() {"No Burden", "Burdened"})
        Me.afe0_burd.Location = New System.Drawing.Point(1192, 156)
        Me.afe0_burd.Name = "afe0_burd"
        Me.afe0_burd.Size = New System.Drawing.Size(94, 21)
        Me.afe0_burd.TabIndex = 6
        '
        'afe0_hvbyp
        '
        Me.afe0_hvbyp.FormattingEnabled = True
        Me.afe0_hvbyp.Items.AddRange(New Object() {"High Voltage (Protection)", "Bypass (low voltage)"})
        Me.afe0_hvbyp.Location = New System.Drawing.Point(1292, 156)
        Me.afe0_hvbyp.Name = "afe0_hvbyp"
        Me.afe0_hvbyp.Size = New System.Drawing.Size(113, 21)
        Me.afe0_hvbyp.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(706, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "AFE 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(706, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "AFE 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(706, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "AFE 3"
        '
        'afe1_hvbyp
        '
        Me.afe1_hvbyp.FormattingEnabled = True
        Me.afe1_hvbyp.Items.AddRange(New Object() {"High Voltage (Protection)", "Bypass (low voltage)"})
        Me.afe1_hvbyp.Location = New System.Drawing.Point(1292, 197)
        Me.afe1_hvbyp.Name = "afe1_hvbyp"
        Me.afe1_hvbyp.Size = New System.Drawing.Size(113, 21)
        Me.afe1_hvbyp.TabIndex = 21
        '
        'afe1_burd
        '
        Me.afe1_burd.FormattingEnabled = True
        Me.afe1_burd.Items.AddRange(New Object() {"No Burden", "Burdened"})
        Me.afe1_burd.Location = New System.Drawing.Point(1192, 197)
        Me.afe1_burd.Name = "afe1_burd"
        Me.afe1_burd.Size = New System.Drawing.Size(94, 21)
        Me.afe1_burd.TabIndex = 22
        '
        'afe1_rtd
        '
        Me.afe1_rtd.FormattingEnabled = True
        Me.afe1_rtd.Items.AddRange(New Object() {"RTD off", "RTD on"})
        Me.afe1_rtd.Location = New System.Drawing.Point(1092, 197)
        Me.afe1_rtd.Name = "afe1_rtd"
        Me.afe1_rtd.Size = New System.Drawing.Size(94, 21)
        Me.afe1_rtd.TabIndex = 23
        '
        'afe1_mh
        '
        Me.afe1_mh.FormattingEnabled = True
        Me.afe1_mh.Items.AddRange(New Object() {"Harvest", "Meter"})
        Me.afe1_mh.Location = New System.Drawing.Point(1008, 197)
        Me.afe1_mh.Name = "afe1_mh"
        Me.afe1_mh.Size = New System.Drawing.Size(78, 21)
        Me.afe1_mh.TabIndex = 24
        '
        'afe2_hvbyp
        '
        Me.afe2_hvbyp.FormattingEnabled = True
        Me.afe2_hvbyp.Items.AddRange(New Object() {"High Voltage (Protection)", "Bypass (low voltage)"})
        Me.afe2_hvbyp.Location = New System.Drawing.Point(1292, 242)
        Me.afe2_hvbyp.Name = "afe2_hvbyp"
        Me.afe2_hvbyp.Size = New System.Drawing.Size(113, 21)
        Me.afe2_hvbyp.TabIndex = 25
        '
        'afe2_burd
        '
        Me.afe2_burd.FormattingEnabled = True
        Me.afe2_burd.Items.AddRange(New Object() {"No Burden", "Burdened"})
        Me.afe2_burd.Location = New System.Drawing.Point(1192, 242)
        Me.afe2_burd.Name = "afe2_burd"
        Me.afe2_burd.Size = New System.Drawing.Size(94, 21)
        Me.afe2_burd.TabIndex = 26
        '
        'afe2_rtd
        '
        Me.afe2_rtd.FormattingEnabled = True
        Me.afe2_rtd.Items.AddRange(New Object() {"RTD off", "RTD on"})
        Me.afe2_rtd.Location = New System.Drawing.Point(1092, 242)
        Me.afe2_rtd.Name = "afe2_rtd"
        Me.afe2_rtd.Size = New System.Drawing.Size(94, 21)
        Me.afe2_rtd.TabIndex = 27
        '
        'afe2_mh
        '
        Me.afe2_mh.FormattingEnabled = True
        Me.afe2_mh.Items.AddRange(New Object() {"Harvest", "Meter"})
        Me.afe2_mh.Location = New System.Drawing.Point(1008, 242)
        Me.afe2_mh.Name = "afe2_mh"
        Me.afe2_mh.Size = New System.Drawing.Size(78, 21)
        Me.afe2_mh.TabIndex = 28
        '
        'afe3_hvbyp
        '
        Me.afe3_hvbyp.FormattingEnabled = True
        Me.afe3_hvbyp.Items.AddRange(New Object() {"High Voltage (Protection)", "Bypass (low voltage)"})
        Me.afe3_hvbyp.Location = New System.Drawing.Point(1292, 287)
        Me.afe3_hvbyp.Name = "afe3_hvbyp"
        Me.afe3_hvbyp.Size = New System.Drawing.Size(113, 21)
        Me.afe3_hvbyp.TabIndex = 29
        '
        'afe3_burd
        '
        Me.afe3_burd.FormattingEnabled = True
        Me.afe3_burd.Items.AddRange(New Object() {"No Burden", "Burdened"})
        Me.afe3_burd.Location = New System.Drawing.Point(1192, 287)
        Me.afe3_burd.Name = "afe3_burd"
        Me.afe3_burd.Size = New System.Drawing.Size(94, 21)
        Me.afe3_burd.TabIndex = 30
        '
        'afe3_rtd
        '
        Me.afe3_rtd.FormattingEnabled = True
        Me.afe3_rtd.Items.AddRange(New Object() {"RTD off", "RTD on"})
        Me.afe3_rtd.Location = New System.Drawing.Point(1092, 287)
        Me.afe3_rtd.Name = "afe3_rtd"
        Me.afe3_rtd.Size = New System.Drawing.Size(94, 21)
        Me.afe3_rtd.TabIndex = 31
        '
        'afe3_mh
        '
        Me.afe3_mh.FormattingEnabled = True
        Me.afe3_mh.Items.AddRange(New Object() {"Harvest", "Meter"})
        Me.afe3_mh.Location = New System.Drawing.Point(1008, 287)
        Me.afe3_mh.Name = "afe3_mh"
        Me.afe3_mh.Size = New System.Drawing.Size(78, 21)
        Me.afe3_mh.TabIndex = 32
        '
        'afe0_mode
        '
        Me.afe0_mode.FormattingEnabled = True
        Me.afe0_mode.Items.AddRange(New Object() {"analog", "PulseCount", "analog (no auto-harvest)", "thermocouple"})
        Me.afe0_mode.Location = New System.Drawing.Point(892, 156)
        Me.afe0_mode.Name = "afe0_mode"
        Me.afe0_mode.Size = New System.Drawing.Size(79, 21)
        Me.afe0_mode.TabIndex = 6
        '
        'afe1_mode
        '
        Me.afe1_mode.FormattingEnabled = True
        Me.afe1_mode.Items.AddRange(New Object() {"analog", "PulseCount", "analog (no auto-harvest)", "thermocouple"})
        Me.afe1_mode.Location = New System.Drawing.Point(892, 195)
        Me.afe1_mode.Name = "afe1_mode"
        Me.afe1_mode.Size = New System.Drawing.Size(79, 21)
        Me.afe1_mode.TabIndex = 6
        '
        'afe2_mode
        '
        Me.afe2_mode.FormattingEnabled = True
        Me.afe2_mode.Items.AddRange(New Object() {"analog", "PulseCount", "analog (no auto-harvest)", "thermocouple"})
        Me.afe2_mode.Location = New System.Drawing.Point(892, 242)
        Me.afe2_mode.Name = "afe2_mode"
        Me.afe2_mode.Size = New System.Drawing.Size(79, 21)
        Me.afe2_mode.TabIndex = 6
        '
        'afe3_mode
        '
        Me.afe3_mode.FormattingEnabled = True
        Me.afe3_mode.Items.AddRange(New Object() {"analog", "PulseCount", "analog (no auto-harvest)", "thermocouple"})
        Me.afe3_mode.Location = New System.Drawing.Point(892, 287)
        Me.afe3_mode.Name = "afe3_mode"
        Me.afe3_mode.Size = New System.Drawing.Size(79, 21)
        Me.afe3_mode.TabIndex = 6
        '
        'afe0_gain
        '
        Me.afe0_gain.FormattingEnabled = True
        Me.afe0_gain.Items.AddRange(New Object() {"1", "2", "4", "8", "16", "32", "64", "128"})
        Me.afe0_gain.Location = New System.Drawing.Point(775, 156)
        Me.afe0_gain.Name = "afe0_gain"
        Me.afe0_gain.Size = New System.Drawing.Size(89, 21)
        Me.afe0_gain.TabIndex = 6
        '
        'afe1_gain
        '
        Me.afe1_gain.FormattingEnabled = True
        Me.afe1_gain.Items.AddRange(New Object() {"1", "2", "4", "8", "16", "32", "64", "128"})
        Me.afe1_gain.Location = New System.Drawing.Point(775, 195)
        Me.afe1_gain.Name = "afe1_gain"
        Me.afe1_gain.Size = New System.Drawing.Size(89, 21)
        Me.afe1_gain.TabIndex = 6
        '
        'afe2_gain
        '
        Me.afe2_gain.FormattingEnabled = True
        Me.afe2_gain.Items.AddRange(New Object() {"1", "2", "4", "8", "16", "32", "64", "128"})
        Me.afe2_gain.Location = New System.Drawing.Point(775, 242)
        Me.afe2_gain.Name = "afe2_gain"
        Me.afe2_gain.Size = New System.Drawing.Size(89, 21)
        Me.afe2_gain.TabIndex = 6
        '
        'afe3_gain
        '
        Me.afe3_gain.FormattingEnabled = True
        Me.afe3_gain.Items.AddRange(New Object() {"1", "2", "4", "8", "16", "32", "64", "128"})
        Me.afe3_gain.Location = New System.Drawing.Point(775, 287)
        Me.afe3_gain.Name = "afe3_gain"
        Me.afe3_gain.Size = New System.Drawing.Size(89, 21)
        Me.afe3_gain.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(706, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "AFE 0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1417, 911)
        Me.Controls.Add(Me.afe3_hvbyp)
        Me.Controls.Add(Me.afe3_burd)
        Me.Controls.Add(Me.afe3_rtd)
        Me.Controls.Add(Me.afe3_mh)
        Me.Controls.Add(Me.afe2_hvbyp)
        Me.Controls.Add(Me.afe2_burd)
        Me.Controls.Add(Me.afe2_rtd)
        Me.Controls.Add(Me.afe2_mh)
        Me.Controls.Add(Me.afe1_hvbyp)
        Me.Controls.Add(Me.afe1_burd)
        Me.Controls.Add(Me.afe1_rtd)
        Me.Controls.Add(Me.afe1_mh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.afe0_hvbyp)
        Me.Controls.Add(Me.afe0_burd)
        Me.Controls.Add(Me.afe0_rtd)
        Me.Controls.Add(Me.afe3_mode)
        Me.Controls.Add(Me.afe2_mode)
        Me.Controls.Add(Me.afe1_mode)
        Me.Controls.Add(Me.afe3_gain)
        Me.Controls.Add(Me.afe2_gain)
        Me.Controls.Add(Me.afe1_gain)
        Me.Controls.Add(Me.afe0_gain)
        Me.Controls.Add(Me.afe0_mode)
        Me.Controls.Add(Me.afe0_mh)
        Me.Controls.Add(Me.terminal)
        Me.Location = New System.Drawing.Point(2000, 30)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents terminal As RichTextBox
    Friend WithEvents SentrollerSearch As Timer
    Friend WithEvents afe0_mh As ComboBox
    Friend WithEvents afe0_rtd As ComboBox
    Friend WithEvents afe0_burd As ComboBox
    Friend WithEvents afe0_hvbyp As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents afe1_hvbyp As ComboBox
    Friend WithEvents afe1_burd As ComboBox
    Friend WithEvents afe1_rtd As ComboBox
    Friend WithEvents afe1_mh As ComboBox
    Friend WithEvents afe2_hvbyp As ComboBox
    Friend WithEvents afe2_burd As ComboBox
    Friend WithEvents afe2_rtd As ComboBox
    Friend WithEvents afe2_mh As ComboBox
    Friend WithEvents afe3_hvbyp As ComboBox
    Friend WithEvents afe3_burd As ComboBox
    Friend WithEvents afe3_rtd As ComboBox
    Friend WithEvents afe3_mh As ComboBox
    Friend WithEvents afe0_mode As ComboBox
    Friend WithEvents afe1_mode As ComboBox
    Friend WithEvents afe2_mode As ComboBox
    Friend WithEvents afe3_mode As ComboBox
    Friend WithEvents afe0_gain As ComboBox
    Friend WithEvents afe1_gain As ComboBox
    Friend WithEvents afe2_gain As ComboBox
    Friend WithEvents afe3_gain As ComboBox
    Friend WithEvents Label5 As Label
End Class
