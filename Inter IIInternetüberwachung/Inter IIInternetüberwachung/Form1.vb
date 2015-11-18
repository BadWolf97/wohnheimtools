Imports System.Net.NetworkInformation
Imports LightButton

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        ToolStripComboBox1.Text = My.Settings.wohnheim
        For Each inter As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces
            cb_interfaces.Items.Add(inter.Description)
        Next
        cb_interfaces.Text = cb_interfaces.Items(1)
        'BackgroundWorker1.CancelAsync()
        BackgroundWorker1.RunWorkerAsync()
        ToolStripButton1.Enabled = True
    End Sub

    Private INTER As String = "134.93.79.254"
    Private MÜNCHFELD As String = "134.93.49.254"
    Private OBERSTADT As String = "134.93.51.254"
    Private WEISENAU As String = "134.93.55.254"
    Private HECHTSHEIM As String = "134.93.59.254"
    Private GONSENHEIM As String = "134.93.65.254"
    Private K3 As String = "134.93.71.254"
    Private WALLSTRAßE As String = "134.93.75.254"

    Private Wohnheim As String = "134.93.79.254"

    Private LOGIN As String = "134.93.48.86"
    Private ZDV As String = "134.93.254.5"
    Private HBF As String = "217.198.240.65"
    Private GOOGLE As String = "8.8.8.8"

    Sub refreshData()
        ToolStripButton1.Enabled = False
        Try

            lb_hbf.LightState = LightButton.LightButton.Light.Red
            lb_ownrouter.LightState = LightButton.LightButton.Light.Red
            lb_login.LightState = LightButton.LightButton.Light.Red
            lb_inter_ii.LightState = LightButton.LightButton.Light.Red
            lb_zdv.LightState = LightButton.LightButton.Light.Red
            lb_internet.LightState = LightButton.LightButton.Light.Red
            line_inter_login.BorderColor = Color.Red
            line_login_zdv.BorderColor = Color.Red
            line_own_inter.BorderColor = Color.Red
            line_zdv_hbf.BorderColor = Color.Red
            line_hbf_internet.BorderColor = Color.Red
            lbl_ping_inter.Text = "..."
            lbl_ping_internet.Text = "..."
            lbl_ping_login.Text = "..."
            lbl_ping_own.Text = "..."
            lbl_ping_zdv.Text = "..."

            Dim pinging As New Ping
            Dim gatewayip As String = "0.0.0.0"
            If Not cb_interfaces.SelectedItem Is Nothing Then
                For Each inter As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces
                    If cb_interfaces.Text = inter.Description Then
                        gatewayip = inter.GetIPProperties.GatewayAddresses(0).Address.ToString()
                    End If
                Next
            End If
            'überprüfen, ob router zwischengeschaltet
            If gatewayip = Wohnheim Then
                lbl_own.Text = "nicht vorhanden"
                lb_ownrouter.LightState = LightButton.LightButton.Light.Red
                line_own_inter.Visible = False
                lbl_ping_own.Visible = False
            Else
                'Router anpingen und Ergebnisse speichern
                lb_ownrouter.LightState = LightButton.LightButton.Light.Yellow
                Dim ping_own As PingReply = pinging.Send(gatewayip)
                If ping_own.Status = IPStatus.Success Then
                    lbl_ping_own.Text = ping_own.RoundtripTime & " ms"
                Else
                    lbl_ping_own.Text = "..."
                End If
                setButtonColor(ping_own, lb_ownrouter)
                line_own_inter.Visible = True
                lbl_ping_own.Visible = True
            End If

            'Wohnheim-Gateway anpingen und Ergebnisse speichern
            line_own_inter.BorderColor = Color.Yellow
            lb_inter_ii.LightState = LightButton.LightButton.Light.Yellow
            Dim ping_inter As PingReply = pinging.Send(Wohnheim)
            If ping_inter.Status = IPStatus.Success Then
                lbl_ping_inter.Text = ping_inter.RoundtripTime & " ms"
            Else
                lbl_ping_login.Text = "..."
            End If
            setButtonColor(ping_inter, lb_inter_ii)
            If (gatewayip = Wohnheim) = False Then
                setLineColor(lb_ownrouter, lb_inter_ii, line_own_inter)
            End If

            'Loginseite anpingen und Ergebnis speichern
            line_inter_login.BorderColor = Color.Yellow
            lb_login.LightState = LightButton.LightButton.Light.Yellow
            Dim ping_login As PingReply = pinging.Send(LOGIN)
            If ping_login.Status = IPStatus.Success Then
                lbl_ping_login.Text = ping_login.RoundtripTime & " ms"
            Else
                lbl_ping_login.Text = "..."
            End If
            setButtonColor(ping_login, lb_login)
            setLineColor(lb_inter_ii, lb_login, line_inter_login)

            'ZDV anpingen und Ergebnis speichern
            line_login_zdv.BorderColor = Color.Yellow
            lb_zdv.LightState = LightButton.LightButton.Light.Yellow
            Dim ping_zdv As PingReply = pinging.Send(ZDV)
            If ping_zdv.Status = IPStatus.Success Then
                lbl_ping_zdv.Text = ping_zdv.RoundtripTime & " ms"
            Else
                lbl_ping_zdv.Text = "..."
            End If
            setButtonColor(ping_zdv, lb_zdv)
            setLineColor(lb_login, lb_zdv, line_login_zdv)

            'HBF anpingen und Ergebnis speichern
            line_zdv_hbf.BorderColor = Color.Yellow
            lb_hbf.LightState = LightButton.LightButton.Light.Yellow
            Dim ping_hbf As PingReply = pinging.Send(HBF)
            If ping_hbf.Status = IPStatus.Success Then
                lbl_ping_hbf.Text = ping_hbf.RoundtripTime & " ms"
            Else
                lbl_ping_hbf.Text = "..."
            End If
            setButtonColor(ping_hbf, lb_hbf, 10)
            setLineColor(lb_zdv, lb_hbf, line_zdv_hbf)

            'Internet anpingen und Ergebnis speichern
            line_hbf_internet.BorderColor = Color.Yellow
            lb_internet.LightState = LightButton.LightButton.Light.Yellow
            Dim ping_google As PingReply = pinging.Send(GOOGLE)
            If ping_google.Status = IPStatus.Success Then
                lbl_ping_internet.Text = ping_google.RoundtripTime & " ms"
            Else
                lbl_ping_internet.Text = "..."
            End If
            setButtonColor(ping_google, lb_internet, 10)
            setLineColor(lb_hbf, lb_internet, line_hbf_internet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ToolStripButton1.Enabled = True
    End Sub

    Sub setButtonColor(ByVal ping As PingReply, ByVal lb As LightButton.LightButton, Optional ByVal threshold As Integer = 5)
        If (ping.Status = IPStatus.Success) = False Then
            lb.LightState = LightButton.LightButton.Light.Red
        ElseIf ping.RoundtripTime > threshold
            lb.LightState = LightButton.LightButton.Light.Yellow
        Else
            lb.LightState = LightButton.LightButton.Light.Green
        End If
    End Sub

    Sub setLineColor(ByVal lb1 As LightButton.LightButton, ByVal lb2 As LightButton.LightButton, ByVal line As PowerPacks.LineShape)
        If lb2.LightState = LightButton.LightButton.Light.Red Then
            line.BorderColor = Color.Red
        ElseIf lb2.LightState = LightButton.LightButton.Light.Yellow
            line.BorderColor = Color.Yellow
        ElseIf lb2.LightState = LightButton.LightButton.Light.Green
            line.BorderColor = Color.Lime
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        refreshData()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If ToolStripButton1.Enabled = True Then
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub cb_interfaces_TextChanged(sender As Object, e As EventArgs) Handles cb_interfaces.TextChanged
        If ToolStripButton1.Enabled = True Then
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub ToolStripComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.TextChanged
        If ToolStripComboBox1.Items.Contains(ToolStripComboBox1.Text) Then
            lb_inter_ii.Caption = ToolStripComboBox1.Text
            Select Case ToolStripComboBox1.Text
                Case "Münchfeld"
                    Wohnheim = MÜNCHFELD
                Case "Oberstadt"
                    Wohnheim = OBERSTADT
                Case "Weisenau"
                    Wohnheim = WEISENAU
                Case "Hechtsheim"
                    Wohnheim = HECHTSHEIM
                Case "Gonsenheim"
                    Wohnheim = GONSENHEIM
                Case "K3"
                    Wohnheim = K3
                Case "Wallstraße"
                    Wohnheim = WALLSTRAßE
                Case "Inter 2"
                    Wohnheim = INTER
            End Select
            If ToolStripButton1.Enabled = True Then
                BackgroundWorker1.RunWorkerAsync()
            End If
            My.Settings.wohnheim = ToolStripComboBox1.Text
            My.Settings.Save()
        End If
    End Sub
End Class
