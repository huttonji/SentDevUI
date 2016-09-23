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
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.terminal.Location = New System.Drawing.Point(36, 12)
        Me.terminal.Margin = New System.Windows.Forms.Padding(10, 10, 10, 100)
        Me.terminal.Name = "terminal"
        Me.terminal.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.terminal.ShowSelectionMargin = True
        Me.terminal.Size = New System.Drawing.Size(653, 828)
        Me.terminal.TabIndex = 3
        Me.terminal.Text = ""
        '
        'SentrollerSearch
        '
        Me.SentrollerSearch.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(886, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Connect a Sentroller to begin..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1417, 911)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As Label
End Class
