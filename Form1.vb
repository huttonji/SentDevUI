Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel



Public Class Form1

    Dim availablePorts As Array


    'Dim portButton As New System.Windows.Forms.Button()  'adds a new instance of the class "button" (like a prefix)


    Delegate Sub setTextCallBack(ByVal [text] As String)  'a delegate points to a function (unknown before runtime)






    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        SerialPort1.Open()



    End Sub





    'Incoming Serial handling///////////////////////////////////////////////////
    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText(SerialPort1.ReadExisting)
    End Sub

    Private Sub ReceivedText(ByVal [text] As String)
        If Me.tb_input.InvokeRequired Then
            Dim x As New setTextCallBack(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            Me.tb_input.Text &= [text]
        End If
    End Sub

    Private Sub button_send_Click(sender As Object, e As EventArgs) Handles button_send.Click
        SerialPort1.WriteLine(tb_output.Text)
    End Sub

    Private Sub tb_output_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_output.KeyDown
        If e.KeyData = Keys.Enter Then
            SerialPort1.WriteLine(tb_output.Text)
            tb_output.Text = ""
        End If
    End Sub
End Class