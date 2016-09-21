<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.tb_output = New System.Windows.Forms.TextBox()
        Me.tb_input = New System.Windows.Forms.TextBox()
        Me.button_send = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM69"
        '
        'tb_output
        '
        Me.tb_output.Location = New System.Drawing.Point(23, 27)
        Me.tb_output.Name = "tb_output"
        Me.tb_output.Size = New System.Drawing.Size(450, 20)
        Me.tb_output.TabIndex = 0
        '
        'tb_input
        '
        Me.tb_input.Location = New System.Drawing.Point(23, 53)
        Me.tb_input.Multiline = True
        Me.tb_input.Name = "tb_input"
        Me.tb_input.Size = New System.Drawing.Size(450, 478)
        Me.tb_input.TabIndex = 1
        '
        'button_send
        '
        Me.button_send.Location = New System.Drawing.Point(506, 133)
        Me.button_send.Name = "button_send"
        Me.button_send.Size = New System.Drawing.Size(75, 23)
        Me.button_send.TabIndex = 2
        Me.button_send.Text = "send"
        Me.button_send.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1417, 911)
        Me.Controls.Add(Me.button_send)
        Me.Controls.Add(Me.tb_input)
        Me.Controls.Add(Me.tb_output)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents tb_output As TextBox
    Friend WithEvents tb_input As TextBox
    Friend WithEvents button_send As Button
End Class
