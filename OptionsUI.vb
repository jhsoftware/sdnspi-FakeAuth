Public Class OptionsUI

  Friend Cfg As New MyConfig

  Private Sub btnAddlSOA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddlSOA.Click
    Dim frm = New frmSOA
    frm.numSerial.Value = Cfg.SoaSerial
    frm.ttlRefresh.Value = Cfg.SoaRefresh
    frm.ttlRetry.Value = Cfg.SoaRetry
    frm.ttlExpire.Value = Cfg.SoaExpire
    frm.ttlMinimum.Value = Cfg.SoaMinimum
    If frm.ShowDialog() <> DialogResult.OK Then Exit Sub
    Cfg.SoaSerial = frm.numSerial.Value
    Cfg.SoaRefresh = frm.ttlRefresh.Value
    Cfg.SoaRetry = frm.ttlRetry.Value
    Cfg.SoaExpire = frm.ttlExpire.Value
    Cfg.SoaMinimum = frm.ttlMinimum.Value
  End Sub

  Public Overrides Function SaveData() As String
    Cfg.DnsServers = ServerList
    Cfg.SoaEmail = txtEmail.Text.Trim.Replace(" ", "").ToLower
    Cfg.TTL = ttl1.Value
    Cfg.NoData = chkNoData.Checked
    Return Cfg.Save
  End Function

  Public Overrides Sub LoadData(ByVal config As String)
    Cfg = MyConfig.Load(config)
    ServerList = Cfg.DnsServers
    txtEmail.Text = Cfg.SoaEmail
    ttl1.Value = Cfg.TTL
    chkNoData.Checked = Cfg.NoData
  End Sub

  Private Sub txtServers_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtServers.LostFocus
    Dim sl = ServerList
    ServerList = sl
  End Sub

  Property ServerList() As String()
    Get
      Dim x = txtServers.Text.Trim
      Dim i As Integer
      Dim y As String
      Dim rv As New List(Of String)
      While x.Length > 0
        i = x.IndexOf(vbCrLf)
        If i > 0 Then
          y = x.Substring(0, i).Trim
          x = x.Substring(i + 2).Trim
        Else
          y = x
          x = ""
        End If
        y = CleanDom(y)
        If y.Length > 0 Then rv.Add(y)
      End While
      Return rv.ToArray
    End Get
    Set(ByVal value As String())
      If value.Length = 0 Then txtServers.Text = "" : Exit Property
      Dim x = ""
      For Each s In value
        If x.Length > 0 Then x &= vbCrLf
        x &= s
      Next
      txtServers.Text = x
    End Set
  End Property

  Private Sub txtEmail_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail.LostFocus
    txtEmail.Text = CleanEmail(txtEmail.Text)
  End Sub

  Public Overrides Function ValidateData() As Boolean
    Dim i As Integer
    Dim sl = ServerList
    If sl.Length = 0 Then MessageBox.Show("At least one DNS server name is required", MyConfig.PIName, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False
    Dim dn As JHSoftware.SimpleDNS.Plugin.DomainName
    For i = 0 To sl.Length - 1
      If Not JHSoftware.SimpleDNS.Plugin.DomainName.TryParse(sl(i), dn) Then _
        MessageBox.Show("Invalid DNS server name '" & sl(i) & "'", MyConfig.PIName, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False
      For j = i + 1 To sl.Length - 1
        If sl(i) = sl(j) Then MessageBox.Show("DNS server name '" & sl(i) & "' is listed several times", MyConfig.PIName, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False
      Next
    Next

    Dim x = CleanEmail(txtEmail.Text)
    i = x.IndexOf("@"c)
    If i < 1 OrElse i = x.Length - 1 OrElse _
       x.IndexOf("@"c, i + 1) > 0 OrElse _
       Not JHSoftware.SimpleDNS.Plugin.DomainName.TryParse(x.Substring(i + 1), dn) _
       Then MessageBox.Show("Invalid e-mail address", MyConfig.PIName, MessageBoxButtons.OK, MessageBoxIcon.Error) : Return False

    Return True
  End Function

  Private Function CleanDom(ByVal s As String) As String
    Dim rv = s.Trim.ToLower.Replace(" "c, "")
    While rv.Length > 0 AndAlso rv(0) = "."c
      rv = rv.Substring(1)
    End While
    While rv.Length > 0 AndAlso rv(rv.Length - 1) = "."c
      rv = rv.Substring(0, rv.Length - 1)
    End While
    While rv.IndexOf("..") >= 0
      rv = rv.Replace("..", ".")
    End While
    Return rv
  End Function

  Private Function CleanEmail(ByVal s As String) As String
    Dim rv = s.Trim.ToLower.Replace(" "c, "")
    Dim i = rv.IndexOf("@"c)
    If i < 1 OrElse i = rv.Length - 1 Then Return rv
    Return rv.Substring(0, i + 1) & CleanDom(rv.Substring(i + 1))
  End Function

End Class
