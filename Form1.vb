Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel







Public Class Form1

    Dim availablePorts As Array




    'Dim portButton As New System.Windows.Forms.Button()  'adds a new instance of the class "button" (like a prefix)


    Delegate Sub setTextCallBack(ByVal [text] As String)  'a delegate points to a function (unknown before runtime)






    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not terminal.TextLength Then terminal.AppendText(" >")  'add a ">" caret to the terminal if there isn't one




        SerialPort1.Open()



    End Sub





    'Incoming Serial handling///////////////////////////////////////////////////
    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText(SerialPort1.ReadExisting)
    End Sub

    Private Sub ReceivedText(ByVal [text] As String)
        If Me.terminal.InvokeRequired Then
            Dim x As New setTextCallBack(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})

        Else
            'add the latest shell message from the sentroller to the terminal
            Dim rx As String() = [text].Split(vbLf)
            rx(0) = ">" & rx(0)
            For i As Int16 = 1 To rx.Length - 1
                terminal.SelectionStart = terminal.TextLength
                If rx(i)(0) <> ">" Then
                    terminal.SelectionColor = Color.Lime
                Else
                    terminal.SelectionColor = Color.Aqua
                End If

                terminal.AppendText(rx(i))
                '  terminal.SelectionLength = rx(i).Length



            Next
            terminal.SelectionStart = terminal.TextLength

        End If

    End Sub



    Private Sub terminal_KeyDown(sender As Object, e As KeyEventArgs) Handles terminal.KeyDown
        If e.KeyData = Keys.Enter Then

            Dim tx_buffer As String

            Dim i As Integer = terminal.TextLength - 1
            While terminal.Text(i) <> ">" And terminal.Text(i) <> vbLf

                tx_buffer = terminal.Text(i) & tx_buffer
                If i > 0 Then i -= 1 Else Exit While
            End While

            SerialPort1.WriteLine(tx_buffer)

        End If
    End Sub



    'exit button event
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        SerialPort1.Close()


        'Dim msgboxresponse As MsgBoxResult
        'msgboxresponse = MsgBox("Are you sure you want to exit?",
        '                        MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text)
        'If msgboxresponse <> MsgBoxResult.Yes Then
        '    e.Cancel = True
        '    Return
        'End If

    End Sub
End Class