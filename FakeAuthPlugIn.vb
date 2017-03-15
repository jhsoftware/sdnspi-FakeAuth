Imports JHSoftware.SimpleDNS.Plugin

Public Class FakeAuthPlugIn
  Implements JHSoftware.SimpleDNS.Plugin.IGetAnswerPlugIn

  Public Event AsyncError(ByVal ex As System.Exception) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.AsyncError
  Public Event LogLine(ByVal text As String) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.LogLine
  Public Event SaveConfig(ByVal config As String) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.SaveConfig

  Private SOAType = DNSRRType.Parse("SOA")
  Private NSType = DNSRRType.Parse("NS")
  Private ANYType = DNSRRType.Parse("*")

  Private cfg As MyConfig
  Private cfgSoaData As String

#Region "not implemented"

  Public Function InstanceConflict(ByVal config1 As String, ByVal config2 As String, ByRef errorMsg As String) As Boolean Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.InstanceConflict
    Return False
  End Function

  Public Sub LoadState(ByVal state As String) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.LoadState
  End Sub

  Public Function SaveState() As String Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.SaveState
    Return ""
  End Function

  Public Sub StartService() Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.StartService
  End Sub

  Public Sub StopService() Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.StopService
  End Sub

#End Region

  Public Function GetPlugInTypeInfo() As JHSoftware.SimpleDNS.Plugin.IPlugInBase.PlugInTypeInfo Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.GetPlugInTypeInfo
    Dim rv As IPlugInBase.PlugInTypeInfo
    rv.Name = MyConfig.PIName
    rv.Description = "Returns SOA- and NS-records"
    rv.InfoURL = "http://www.simpledns.com/kb.aspx?kbid=1285"
    rv.ConfigFile = False
    rv.MultiThreaded = False
    Return rv
  End Function

  Public Function GetDNSAskAbout() As JHSoftware.SimpleDNS.Plugin.DNSAskAbout Implements JHSoftware.SimpleDNS.Plugin.IGetAnswerPlugIn.GetDNSAskAbout
    If cfg.NoData Then
      Return Nothing
    Else
      Return New DNSAskAbout With {.RRTypes = New DNSRRType() {SOAType, NSType}}
    End If
  End Function

  Public Function Lookup(ByVal request As JHSoftware.SimpleDNS.Plugin.IDNSRequest) As JHSoftware.SimpleDNS.Plugin.DNSAnswer Implements JHSoftware.SimpleDNS.Plugin.IGetAnswerPlugIn.Lookup
    Dim rv As New DNSAnswer
    rv.AA = TriState.True
    Select Case request.QType
      Case SOAType
        rv.Records.Add(New DNSRecord With {.Name = request.QName, _
                                           .RRType = SOAType, _
                                           .TTL = cfg.TTL, _
                                           .Data = cfgSoaData})
      Case NSType
        For Each s In cfg.DnsServers
          rv.Records.Add(New DNSRecord With {.Name = request.QName, _
                                             .RRType = NSType, _
                                             .TTL = cfg.TTL, _
                                             .Data = s & "."})
        Next
      Case ANYType
      Case Else
        If cfg.NoData Then
          Dim x = request.QName.ToString
          For i = 0 To cfg.DnsServers.Length - 1
            If cfg.DnsServers(i) = x Then Return Nothing
          Next
          rv.Records.Add(New DNSRecord With {.Name = request.QName, _
                                             .RRType = SOAType, _
                                             .TTL = cfg.TTL, _
                                             .Data = cfgSoaData, _
                                             .AnswerSection = DNSAnswerSection.Authority})
        Else
          Return Nothing
        End If
    End Select
    Return rv
  End Function

  Public Function GetOptionsUI(ByVal instanceID As System.Guid, ByVal dataPath As String) As JHSoftware.SimpleDNS.Plugin.OptionsUI Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.GetOptionsUI
    Return New OptionsUI
  End Function

  Public Sub LoadConfig(ByVal config As String, ByVal instanceID As System.Guid, ByVal dataPath As String, ByRef maxThreads As Integer) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.LoadConfig
    cfg = MyConfig.Load(config)
    cfgSoaData = cfg.MakeSoaData
  End Sub

End Class
