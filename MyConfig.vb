Public Class MyConfig
  Friend Const PIName As String = "Fake Zone Authority"

  Friend DnsServers() As String
  Friend SoaEmail As String
  Friend TTL As Integer

  Friend SoaSerial As UInteger
  Friend SoaRefresh As Integer
  Friend SoaRetry As Integer
  Friend SoaExpire As Integer
  Friend SoaMinimum As Integer

  Friend NoData As Boolean

  Friend Function MakeSoaData() As String
    Dim i = SoaEmail.IndexOf("@"c)
    Return DnsServers(0) & ". " & _
           SoaEmail.Substring(0, i).Replace("."c, "\.") & "." & SoaEmail.Substring(i + 1) & ". " & _
           SoaSerial & " " & _
           SoaRefresh & " " & _
           SoaRetry & " " & _
           SoaExpire & " " & _
           SoaMinimum
  End Function

  Friend Function Save() As String
    Dim rv As String = "1|" & _
                 PipeEncode(SoaEmail) & "|" & _
                 TTL & "|" & _
                 SoaSerial & "|" & _
                 SoaRefresh & "|" & _
                 SoaRetry & "|" & _
                 SoaExpire & "|" & _
                 SoaMinimum & "|" & _
                 If(NoData, "1", "0")
    For Each s In DnsServers
      rv &= "|" & PipeEncode(s)
    Next
    Return rv
  End Function

  Shared Function Load(ByVal s As String) As MyConfig
    Dim rv As New MyConfig
    If String.IsNullOrEmpty(s) Then
      ReDim rv.DnsServers(-1)
      rv.SoaEmail = ""
      rv.TTL = 3600
      rv.NoData = True
      rv.SoaSerial = UInteger.Parse(Now.ToString("yyyyMMdd") & "01")
      rv.SoaRefresh = 10800
      rv.SoaRetry = 3600
      rv.SoaExpire = 1209600
      rv.SoaMinimum = 3600
    Else
      Dim pd = PipeDecode(s)
      If pd(0) <> "1" Then Throw New Exception("Unknown config data version")
      rv.SoaEmail = pd(1)
      rv.TTL = Integer.Parse(pd(2))
      rv.SoaSerial = UInteger.Parse(pd(3))
      rv.SoaRefresh = Integer.Parse(pd(4))
      rv.SoaRetry = Integer.Parse(pd(5))
      rv.SoaExpire = Integer.Parse(pd(6))
      rv.SoaMinimum = Integer.Parse(pd(7))
      rv.NoData = (pd(8) = "1")
      ReDim rv.DnsServers(pd.Length - 10)
      Array.Copy(pd, 9, rv.DnsServers, 0, pd.Length - 9)
    End If
    Return rv
  End Function

End Class
