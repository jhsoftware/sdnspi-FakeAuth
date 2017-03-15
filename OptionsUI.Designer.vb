<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsUI
    Inherits JHSoftware.SimpleDNS.Plugin.OptionsUI

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label8 = New System.Windows.Forms.Label
    Me.txtEmail = New System.Windows.Forms.TextBox
    Me.btnAddlSOA = New System.Windows.Forms.Button
    Me.Label3 = New System.Windows.Forms.Label
    Me.txtServers = New System.Windows.Forms.TextBox
    Me.chkNoData = New System.Windows.Forms.CheckBox
    Me.ttl1 = New ctlTTL
    Me.SuspendLayout()
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(-3, 86)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(313, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "E-mail address of the person responsible for zone (SOA RNAME):"
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(-3, 174)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(165, 13)
    Me.Label8.TabIndex = 5
    Me.Label8.Text = "DNS Record TTL (Time To Live):"
    '
    'txtEmail
    '
    Me.txtEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
    Me.txtEmail.Location = New System.Drawing.Point(0, 102)
    Me.txtEmail.Margin = New System.Windows.Forms.Padding(3, 3, 3, 13)
    Me.txtEmail.Name = "txtEmail"
    Me.txtEmail.Size = New System.Drawing.Size(359, 20)
    Me.txtEmail.TabIndex = 3
    '
    'btnAddlSOA
    '
    Me.btnAddlSOA.Location = New System.Drawing.Point(0, 138)
    Me.btnAddlSOA.Margin = New System.Windows.Forms.Padding(3, 3, 3, 13)
    Me.btnAddlSOA.Name = "btnAddlSOA"
    Me.btnAddlSOA.Size = New System.Drawing.Size(186, 23)
    Me.btnAddlSOA.TabIndex = 4
    Me.btnAddlSOA.Text = "Additional SOA-record settings..."
    Me.btnAddlSOA.UseVisualStyleBackColor = True
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(-3, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(257, 13)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "DNS server names (FQDN), one per line, primary first:"
    '
    'txtServers
    '
    Me.txtServers.AcceptsReturn = True
    Me.txtServers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtServers.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
    Me.txtServers.Location = New System.Drawing.Point(0, 16)
    Me.txtServers.Margin = New System.Windows.Forms.Padding(3, 3, 3, 13)
    Me.txtServers.Multiline = True
    Me.txtServers.Name = "txtServers"
    Me.txtServers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.txtServers.Size = New System.Drawing.Size(359, 57)
    Me.txtServers.TabIndex = 1
    Me.txtServers.WordWrap = False
    '
    'chkNoData
    '
    Me.chkNoData.AutoSize = True
    Me.chkNoData.CheckAlign = System.Drawing.ContentAlignment.TopLeft
    Me.chkNoData.Checked = True
    Me.chkNoData.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkNoData.Location = New System.Drawing.Point(0, 227)
    Me.chkNoData.Name = "chkNoData"
    Me.chkNoData.Size = New System.Drawing.Size(349, 30)
    Me.chkNoData.TabIndex = 7
    Me.chkNoData.Text = "Send ""NO DATA"" response for record types other than SOA and NS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(except when requ" & _
        "est is for one of the DNS server names above)"
    Me.chkNoData.UseVisualStyleBackColor = True
    '
    'ttl1
    '
    Me.ttl1.AutoSize = True
    Me.ttl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.ttl1.BackColor = System.Drawing.Color.Transparent
    Me.ttl1.Location = New System.Drawing.Point(0, 190)
    Me.ttl1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 13)
    Me.ttl1.Name = "ttl1"
    Me.ttl1.ReadOnly = False
    Me.ttl1.Size = New System.Drawing.Size(156, 21)
    Me.ttl1.TabIndex = 6
    Me.ttl1.Value = 500
    '
    'OptionsUI
    '
    Me.Controls.Add(Me.chkNoData)
    Me.Controls.Add(Me.txtServers)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.btnAddlSOA)
    Me.Controls.Add(Me.txtEmail)
    Me.Controls.Add(Me.ttl1)
    Me.Controls.Add(Me.Label8)
    Me.Controls.Add(Me.Label2)
    Me.Name = "OptionsUI"
    Me.Size = New System.Drawing.Size(359, 260)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents ttl1 As ctlTTL
  Friend WithEvents txtEmail As System.Windows.Forms.TextBox
  Friend WithEvents btnAddlSOA As System.Windows.Forms.Button
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtServers As System.Windows.Forms.TextBox
  Friend WithEvents chkNoData As System.Windows.Forms.CheckBox

End Class
