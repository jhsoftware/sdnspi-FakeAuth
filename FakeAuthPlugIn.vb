Imports JHSoftware.SimpleDNS.Plugin

Public Class FakeAuthPlugIn
  Implements ILookupAnswer
  Implements IOptionsUI

  Private cfg As MyConfig
  Private cfgSoaData As String

  Public Property Host As IHost Implements IPlugInBase.Host

#Region "not implemented"

  Public Function InstanceConflict(ByVal config1 As String, ByVal config2 As String, ByRef errorMsg As String) As Boolean Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.InstanceConflict
    Return False
  End Function

  Public Function StartService() As Threading.Tasks.Task Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.StartService
    Return Threading.Tasks.Task.CompletedTask
  End Function

  Public Sub StopService() Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.StopService
  End Sub

#End Region

  Public Function GetPlugInTypeInfo() As TypeInfo Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.GetTypeInfo
    Dim rv As TypeInfo
    rv.Name = MyConfig.PIName
    rv.Description = "Returns SOA- and NS-records"
    rv.InfoURL = "https://simpledns.plus/plugin-fakeauth"
    Return rv
  End Function


  Public Async Function Lookup(ByVal request As IRequestContext) As Threading.Tasks.Task(Of DNSAnswer) Implements JHSoftware.SimpleDNS.Plugin.ILookupAnswer.LookupAnswer
    Dim rv As New DNSAnswer
    rv.AA = TriState.True
    Select Case request.QType
      Case JHSoftware.SimpleDNS.DNSRecType.SOA
        rv.Answer.Add(New DNSRecord With {.Name = request.QName,
                                           .RRType = JHSoftware.SimpleDNS.DNSRecType.SOA,
                                           .TTL = cfg.TTL,
                                           .Data = cfgSoaData})
      Case JHSoftware.SimpleDNS.DNSRecType.NS
        For Each s In cfg.DnsServers
          rv.Answer.Add(New DNSRecord With {.Name = request.QName,
                                             .RRType = JHSoftware.SimpleDNS.DNSRecType.NS,
                                             .TTL = cfg.TTL,
                                             .Data = s & "."})
        Next
      Case JHSoftware.SimpleDNS.DNSRecType.ANY
      Case Else
        If cfg.NoData Then
          Dim x = request.QName.ToString
          For i = 0 To cfg.DnsServers.Length - 1
            If cfg.DnsServers(i) = x Then Return Nothing
          Next
          rv.Authority.Add(New DNSRecord With {.Name = request.QName,
                                             .RRType = JHSoftware.SimpleDNS.DNSRecType.SOA,
                                             .TTL = cfg.TTL,
                                             .Data = cfgSoaData})
        Else
          Return Nothing
        End If
    End Select
    Return rv
  End Function

  Public Function GetOptionsUI(ByVal instanceID As System.Guid, ByVal dataPath As String) As JHSoftware.SimpleDNS.Plugin.OptionsUI Implements JHSoftware.SimpleDNS.Plugin.IOptionsUI.GetOptionsUI
    Return New OptionsUI
  End Function

  Public Sub LoadConfig(ByVal config As String, ByVal instanceID As System.Guid, ByVal dataPath As String) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.LoadConfig
    cfg = MyConfig.Load(config)
    cfgSoaData = cfg.MakeSoaData
  End Sub

End Class
