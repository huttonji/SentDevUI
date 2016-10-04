Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel
Imports System.Management



Public Class Form1

    'declare constants (this will be a generated excel file later on....)
    Public Const shellLockoutPassword = "pa55word"
    Public Const shellLockoutDissable = "shellLockoutDissable"
    Public Const UIcontrolPassword = "UI requesting control..."



    Dim lastTerminalKey As Keys = Keys.Enter     'for making sure blank commands are ignored (initialized as enter)(see terminal_keydown())

    Dim availablePorts As Array





    Delegate Sub setTextCallBack(ByVal [text] As String)  'a delegate points to a function (unknown before runtime)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        availablePorts = SerialPort.GetPortNames

        'Initialize all comboBoxes to 1st in list
        For Each cb In Controls : If TypeName(cb) = "ComboBox" Then cb.text = cb.items(0)
        Next


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
            If lastTerminalKey = Keys.Enter Then e.SuppressKeyPress = True : terminal.Text &= ">" : Exit Sub    '<-------------  change to "lastindexof(">")" , e.cance   
            transmit_terminal()
        End If
        lastTerminalKey = e.KeyData
    End Sub

    Private Sub transmit_terminal()
        Dim tx_buffer As String = ""
        Dim i As Integer = terminal.TextLength - 1
        While terminal.Text(i) <> ">" And terminal.Text(i) <> vbLf  '       <-------------  this can be reduced to "lastindexof()"....     

            tx_buffer = terminal.Text(i) & tx_buffer
            If i > 0 Then i -= 1 Else Exit While
        End While



        SerialPort1.WriteLine(tx_buffer)
    End Sub


    'exit button event
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SerialPort1.Dispose()
        SerialPort1.Close()


        Dim msgboxresponse As MsgBoxResult
        msgboxresponse = MsgBox("Are you sure you want to exit?",
        MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text)
        If msgboxresponse <> MsgBoxResult.Yes Then
            e.Cancel = True
            Exit Sub
        End If

        MsgBox("Fine then....bitch...")






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
                            SerialPort1.Open()      'open comms with suspected Sentroller (USB serial device)
                            SerialPort1.WriteLine(shellLockoutPassword)
                        Catch
                        End Try

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

    Private Sub afeModeChange(sender As Object, e As EventArgs) _
        Handles afe0_mh.SelectedIndexChanged, afe1_mh.SelectedIndexChanged, afe2_mh.SelectedIndexChanged, afe3_mh.SelectedIndexChanged,
            afe0_rtd.SelectedIndexChanged, afe1_rtd.SelectedIndexChanged, afe2_rtd.SelectedIndexChanged, afe3_rtd.SelectedIndexChanged,
            afe0_burd.SelectedIndexChanged, afe1_burd.SelectedIndexChanged, afe2_burd.SelectedIndexChanged, afe3_burd.SelectedIndexChanged,
            afe0_hvbyp.SelectedIndexChanged, afe1_hvbyp.SelectedIndexChanged, afe2_hvbyp.SelectedIndexChanged, afe3_hvbyp.SelectedIndexChanged,
            afe2_gain.SelectedIndexChanged, afe1_gain.SelectedIndexChanged, afe0_gain.SelectedIndexChanged, afe3_gain.SelectedIndexChanged,
            afe2_mode.SelectedIndexChanged, afe1_mode.SelectedIndexChanged, afe0_mode.SelectedIndexChanged, afe3_mode.SelectedIndexChanged

        If SerialPort1.IsOpen Then
            Dim tx_buff As String
            Dim name As String
            name = sender.name
            Dim channel As String
            channel = name.Substring(0, 4)

            Dim config As String = "0x"
            Dim gain As Int16
            Dim mode As Int16
            Dim dec As Int16 = 0
            For Each cb In Controls : If TypeName(cb) = "ComboBox" Then 'loop through all combo boxes
                    If cb.Name.Contains(channel) Then   'only does math on comboboxes for the correct channel

                        If cb.Name.Contains("gain") Then : gain = cb.selectedIndex   '(0-7) --> (1,2,4,8,16,32,64,128)
                        ElseIf cb.Name.Contains("mode") Then : mode = cb.selectedIndex + 1 '(1-4) --> (analog,PC,analog(no harvest),thermoCouple)

                        ElseIf cb.Name.Contains("mh") Then : dec += 8 * cb.selectedIndex    'converts 4 bits to 1 hex --> (tinyurl.com/afe-cheatsheet)
                        ElseIf cb.Name.Contains("rtd") Then : dec += 4 * cb.selectedIndex
                        ElseIf cb.Name.Contains("burd") Then : dec += 2 * cb.selectedIndex
                        ElseIf cb.Name.Contains("hvbyp") Then : dec += 1 * cb.selectedIndex
                        End If
                    End If
                End If
            Next

            config &= gain
            config &= mode
            If dec >= 10 Then : config &= "abcdef"(dec - 10)
            Else config &= dec
            End If

            tx_buff = "appdev afe " & channel(3) & " set " & config
            terminal.Text &= tx_buff
            transmit_terminal()

        End If

    End Sub


End Class