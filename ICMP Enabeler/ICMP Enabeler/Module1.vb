Module Module1
    Sub Main()
        Dim proces = Process.Start("C:\Windows\System32\netsh.exe", "advfirewall firewall add rule name=""ICMP Allow incoming V4 echo request"" protocol=icmpv4:8,any dir=in action=allow")
        proces.WaitForExit()
        proces = Process.Start("C:\Windows\System32\netsh.exe", "advfirewall set domainprofile firewallpolicy allowinbound,allowoutbound")
        proces.WaitForExit()
        MsgBox("Einstellungen erfolgreich gesetzt." & vbNewLine & vbNewLine & "© Nicolas Reuter, www.fphst.de")
        End
    End Sub
End Module
