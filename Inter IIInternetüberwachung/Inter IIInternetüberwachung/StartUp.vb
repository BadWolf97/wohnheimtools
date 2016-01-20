Public Class StartUp
    Private Sub StartUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.FileSystem.WriteAllBytes(Application.StartupPath & "\LightButton.dll", My.Resources.LightButton, False)
        My.Computer.FileSystem.WriteAllBytes(Application.StartupPath & "\Microsoft.VisualBasic.PowerPacks.dll", My.Resources.Microsoft_VisualBasic_PowerPacks, False)
        Form1.Show()
        Me.Close()
    End Sub
End Class