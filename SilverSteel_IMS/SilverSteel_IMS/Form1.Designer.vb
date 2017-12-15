<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_login
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
        Me.lbl_top = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_top
        '
        Me.lbl_top.AutoSize = True
        Me.lbl_top.Location = New System.Drawing.Point(13, 13)
        Me.lbl_top.Name = "lbl_top"
        Me.lbl_top.Size = New System.Drawing.Size(28, 13)
        Me.lbl_top.TabIndex = 0
        Me.lbl_top.Text = "Test"
        '
        'form_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 261)
        Me.Controls.Add(Me.lbl_top)
        Me.Name = "form_login"
        Me.Text = "SilverSteek Inventory Management System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_top As Label
End Class
