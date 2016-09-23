Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel
Imports System.Management







Public Class Form1

    Dim availablePorts As Array




    'Dim portButton As New System.Windows.Forms.Button()  'adds a new instance of the class "button" (like a prefix)


    Delegate Sub setTextCallBack(ByVal [text] As String)  'a delegate points to a function (unknown before runtime)

    Private Sub serial_disconnect(sender As Object, e As SerialPinChangedEventArgs) Handles SerialPort1.PinChanged
        MsgBox(e)
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        availablePorts = IO.Ports.SerialPort.GetPortNames






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
                If rx(i).Length > 0 Then

                    If rx(i)(0) <> ">" Then
                        terminal.SelectionColor = Color.Lime
                    Else
                        terminal.SelectionColor = Color.Aqua
                    End If
                End If
                terminal.AppendText(rx(i))
                '  terminal.SelectionLength = rx(i).Length



            Next
            'double checks that the newest ">" input line is Blue
            terminal.SelectionStart = terminal.Text.LastIndexOf(vbLf)
            terminal.SelectionLength = terminal.TextLength - terminal.Text.LastIndexOf(vbLf)
            terminal.SelectionColor = Color.Aqua
            terminal.SelectionStart = terminal.TextLength

        End If

    End Sub



    Private Sub terminal_KeyDown(sender As Object, e As KeyEventArgs) Handles terminal.KeyDown
        If e.KeyData = Keys.Enter Then

            If terminal.Text.Last = ">" Then                    'if no command written, ignore the enter key
                terminal.Text.Remove(terminal.TextLength - 2)
                terminal.SelectionStart = terminal.TextLength
                Exit Sub
            End If

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

    Private Sub SentrollerSearch_Tick(sender As Object, e As EventArgs) Handles SentrollerSearch.Tick

        If Not SerialPort1.IsOpen Then
            terminal.BackColor = Color.Silver
            terminal.SelectionStart = terminal.TextLength
            terminal.SelectionColor = Color.Red
            terminal.ReadOnly = True
            Try
                Dim searcher As New ManagementObjectSearcher(
               "root\cimv2",
               "SELECT * FROM Win32_SerialPort")

                For Each queryObj As ManagementObject In searcher.Get()
                    Dim COM_name As String = queryObj("Name")
                    If COM_name.IndexOf("USB Serial Device") = 0 Then
                        COM_name = COM_name.Remove(0, COM_name.IndexOf("(") + 1)
                        COM_name = COM_name.Remove(COM_name.IndexOf(")"))
                        SerialPort1.PortName = COM_name
                        Try
                            SerialPort1.Open()
                        Catch
                        End Try
                        Label1.Visible = False
                        terminal.BackColor = Color.FromArgb(40, 40, 45)
                        terminal.ReadOnly = False
                        terminal.SelectionStart = terminal.TextLength
                        If terminal.TextLength = 0 Then

                            terminal.SelectionColor = Color.Aqua
                            terminal.AppendText(">")

                        End If
                        terminal.SelectionColor = Color.Aqua
                    End If
                Next

            Catch err As ManagementException
                MessageBox.Show("Error with Windows Port Manager... Select the COM port through the terminal")
            End Try
        End If

    End Sub


    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub


End Class