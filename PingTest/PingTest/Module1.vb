Imports System.Net.NetworkInformation

Module Module1

    Sub Main()
        Dim ip As String = Environment.GetCommandLineArgs(1)
        If ip Is Nothing Then
            Console.WriteLine("Bitte IP eingeben.")
        End If
        Dim Pinging As New Ping
        Dim repl As PingReply
        Do
            repl = Pinging.Send(ip, 3000)
            If repl.Status = IPStatus.Success Then
                My.Computer.FileSystem.WriteAllText(IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, ip & ".txt"), vbNewLine & Now.Day & "." & Now.Month & "." & Now.Year & ";" & Now.Hour & ":" & Now.Minute & ":" & Now.Second & ";" & repl.Status.ToString & ";" & repl.RoundtripTime, True)
            Else
                My.Computer.FileSystem.WriteAllText(IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, ip & ".txt"), vbNewLine & Now.Day & "." & Now.Month & "." & Now.Year & ";" & Now.Hour & ":" & Now.Minute & ":" & Now.Second & ";" & repl.Status.ToString & ";" & repl.RoundtripTime, True)
            End If
            Console.WriteLine(Now.Day & "." & Now.Month & "." & Now.Year & vbTab & Now.Hour & ":" & Now.Minute & ":" & Now.Second & vbTab & repl.Status.ToString & vbTab & repl.RoundtripTime)
            System.Threading.Thread.Sleep(10000)
        Loop
    End Sub

End Module
