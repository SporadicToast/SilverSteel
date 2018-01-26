<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_debug
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_debug))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_debug_login = New System.Windows.Forms.Button()
        Me.btn_debug_menu = New System.Windows.Forms.Button()
        Me.btn_debug_var = New System.Windows.Forms.Button()
        Me.lbl_debugvar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Debug Window"
        '
        'btn_debug_login
        '
        Me.btn_debug_login.Location = New System.Drawing.Point(15, 26)
        Me.btn_debug_login.Name = "btn_debug_login"
        Me.btn_debug_login.Size = New System.Drawing.Size(109, 23)
        Me.btn_debug_login.TabIndex = 1
        Me.btn_debug_login.Text = "form_login.vb"
        Me.btn_debug_login.UseVisualStyleBackColor = True
        '
        'btn_debug_menu
        '
        Me.btn_debug_menu.Location = New System.Drawing.Point(15, 55)
        Me.btn_debug_menu.Name = "btn_debug_menu"
        Me.btn_debug_menu.Size = New System.Drawing.Size(109, 23)
        Me.btn_debug_menu.TabIndex = 1
        Me.btn_debug_menu.Text = "mainmenu.vb"
        Me.btn_debug_menu.UseVisualStyleBackColor = True
        '
        'btn_debug_var
        '
        Me.btn_debug_var.Location = New System.Drawing.Point(15, 84)
        Me.btn_debug_var.Name = "btn_debug_var"
        Me.btn_debug_var.Size = New System.Drawing.Size(109, 23)
        Me.btn_debug_var.TabIndex = 1
        Me.btn_debug_var.Text = "toggle debug var"
        Me.btn_debug_var.UseVisualStyleBackColor = True
        '
        'lbl_debugvar
        '
        Me.lbl_debugvar.AutoSize = True
        Me.lbl_debugvar.Location = New System.Drawing.Point(130, 89)
        Me.lbl_debugvar.Name = "lbl_debugvar"
        Me.lbl_debugvar.Size = New System.Drawing.Size(37, 13)
        Me.lbl_debugvar.TabIndex = 2
        Me.lbl_debugvar.Text = "TRUE"
        '
        'debug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lbl_debugvar)
        Me.Controls.Add(Me.btn_debug_var)
        Me.Controls.Add(Me.btn_debug_menu)
        Me.Controls.Add(Me.btn_debug_login)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "debug"
        Me.Text = "Debug Window"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_debug_login As Button
    Friend WithEvents btn_debug_menu As Button
    Friend WithEvents btn_debug_var As Button
    Friend WithEvents lbl_debugvar As Label
End Class
