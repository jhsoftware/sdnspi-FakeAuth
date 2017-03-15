<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSOA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.btnOK = New System.Windows.Forms.Button
    Me.btnCancel = New System.Windows.Forms.Button
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.ttlMinimum = New ctlTTL
    Me.ttlExpire = New ctlTTL
    Me.ttlRetry = New ctlTTL
    Me.ttlRefresh = New ctlTTL
    Me.Label7 = New System.Windows.Forms.Label
    Me.Label6 = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.numSerial = New System.Windows.Forms.NumericUpDown
    Me.GroupBox1.SuspendLayout()
    CType(Me.numSerial, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnOK
    '
    Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnOK.Location = New System.Drawing.Point(154, 246)
    Me.btnOK.Name = "btnOK"
    Me.btnOK.Size = New System.Drawing.Size(75, 23)
    Me.btnOK.TabIndex = 1
    Me.btnOK.Text = "OK"
    '
    'btnCancel
    '
    Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancel.Location = New System.Drawing.Point(235, 246)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(75, 23)
    Me.btnCancel.TabIndex = 2
    Me.btnCancel.Text = "Cancel"
    '
    'GroupBox1
    '
    Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBox1.Controls.Add(Me.numSerial)
    Me.GroupBox1.Controls.Add(Me.ttlMinimum)
    Me.GroupBox1.Controls.Add(Me.ttlExpire)
    Me.GroupBox1.Controls.Add(Me.ttlRetry)
    Me.GroupBox1.Controls.Add(Me.ttlRefresh)
    Me.GroupBox1.Controls.Add(Me.Label7)
    Me.GroupBox1.Controls.Add(Me.Label6)
    Me.GroupBox1.Controls.Add(Me.Label5)
    Me.GroupBox1.Controls.Add(Me.Label4)
    Me.GroupBox1.Controls.Add(Me.Label3)
    Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Padding = New System.Windows.Forms.Padding(15)
    Me.GroupBox1.Size = New System.Drawing.Size(298, 228)
    Me.GroupBox1.TabIndex = 0
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Additional SOA-record settings"
    '
    'ttlMinimum
    '
    Me.ttlMinimum.AutoSize = True
    Me.ttlMinimum.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.ttlMinimum.BackColor = System.Drawing.Color.Transparent
    Me.ttlMinimum.Location = New System.Drawing.Point(116, 175)
    Me.ttlMinimum.Margin = New System.Windows.Forms.Padding(3, 3, 3, 13)
    Me.ttlMinimum.Name = "ttlMinimum"
    Me.ttlMinimum.ReadOnly = False
    Me.ttlMinimum.Size = New System.Drawing.Size(156, 21)
    Me.ttlMinimum.TabIndex = 9
    Me.ttlMinimum.Value = 500
    '
    'ttlExpire
    '
    Me.ttlExpire.AutoSize = True
    Me.ttlExpire.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.ttlExpire.BackColor = System.Drawing.Color.Transparent
    Me.ttlExpire.Location = New System.Drawing.Point(116, 138)
    Me.ttlExpire.Margin = New System.Windows.Forms.Padding(3, 3, 3, 13)
    Me.ttlExpire.Name = "ttlExpire"
    Me.ttlExpire.ReadOnly = False
    Me.ttlExpire.Size = New System.Drawing.Size(156, 21)
    Me.ttlExpire.TabIndex = 7
    Me.ttlExpire.Value = 500
    '
    'ttlRetry
    '
    Me.ttlRetry.AutoSize = True
    Me.ttlRetry.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.ttlRetry.BackColor = System.Drawing.Color.Transparent
    Me.ttlRetry.Location = New System.Drawing.Point(116, 101)
    Me.ttlRetry.Margin = New System.Windows.Forms.Padding(3, 3, 3, 13)
    Me.ttlRetry.Name = "ttlRetry"
    Me.ttlRetry.ReadOnly = False
    Me.ttlRetry.Size = New System.Drawing.Size(156, 21)
    Me.ttlRetry.TabIndex = 5
    Me.ttlRetry.Value = 500
    '
    'ttlRefresh
    '
    Me.ttlRefresh.AutoSize = True
    Me.ttlRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.ttlRefresh.BackColor = System.Drawing.Color.Transparent
    Me.ttlRefresh.Location = New System.Drawing.Point(116, 64)
    Me.ttlRefresh.Margin = New System.Windows.Forms.Padding(3, 3, 3, 13)
    Me.ttlRefresh.Name = "ttlRefresh"
    Me.ttlRefresh.ReadOnly = False
    Me.ttlRefresh.Size = New System.Drawing.Size(156, 21)
    Me.ttlRefresh.TabIndex = 3
    Me.ttlRefresh.Value = 500
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(18, 180)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(84, 13)
    Me.Label7.TabIndex = 8
    Me.Label7.Text = """Minimum"" TTL:"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(18, 143)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(61, 13)
    Me.Label6.TabIndex = 6
    Me.Label6.Text = "Expire time:"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(18, 106)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(72, 13)
    Me.Label5.TabIndex = 4
    Me.Label5.Text = "Retry interval:"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(18, 69)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(84, 13)
    Me.Label4.TabIndex = 2
    Me.Label4.Text = "Refresh interval:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(18, 31)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(74, 13)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Serial number:"
    '
    'numSerial
    '
    Me.numSerial.Location = New System.Drawing.Point(116, 29)
    Me.numSerial.Maximum = New Decimal(New Integer() {-1, 0, 0, 0})
    Me.numSerial.Name = "numSerial"
    Me.numSerial.Size = New System.Drawing.Size(118, 20)
    Me.numSerial.TabIndex = 1
    '
    'frmSOA
    '
    Me.AcceptButton = Me.btnOK
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCancel
    Me.ClientSize = New System.Drawing.Size(322, 281)
    Me.Controls.Add(Me.btnOK)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.btnCancel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmSOA"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Additional SOA-record settings"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    CType(Me.numSerial, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnOK As System.Windows.Forms.Button
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents ttlMinimum As ctlTTL
  Friend WithEvents ttlExpire As ctlTTL
  Friend WithEvents ttlRetry As ctlTTL
  Friend WithEvents ttlRefresh As ctlTTL
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents numSerial As System.Windows.Forms.NumericUpDown

End Class
