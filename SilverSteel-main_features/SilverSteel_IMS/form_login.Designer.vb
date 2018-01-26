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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_user = New System.Windows.Forms.TextBox()
        Me.tb_pass = New System.Windows.Forms.TextBox()
        Me.cb_debug_window = New System.Windows.Forms.CheckBox()
        Me.cb_debug_bypass = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SilverSteel_IMS.My.Resources.Resources.login_icon
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(118, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Authentication"
        '
        'tb_user
        '
        Me.tb_user.Location = New System.Drawing.Point(181, 38)
        Me.tb_user.Name = "tb_user"
        Me.tb_user.Size = New System.Drawing.Size(179, 20)
        Me.tb_user.TabIndex = 1
        '
        'tb_pass
        '
        Me.tb_pass.Location = New System.Drawing.Point(181, 63)
        Me.tb_pass.Name = "tb_pass"
        Me.tb_pass.Size = New System.Drawing.Size(179, 20)
        Me.tb_pass.TabIndex = 2
        '
        'cb_debug_window
        '
        Me.cb_debug_window.AutoSize = True
        Me.cb_debug_window.Location = New System.Drawing.Point(258, 89)
        Me.cb_debug_window.Name = "cb_debug_window"
        Me.cb_debug_window.Size = New System.Drawing.Size(136, 17)
        Me.cb_debug_window.TabIndex = 4
        Me.cb_debug_window.Text = "Enable Debug Window"
        Me.cb_debug_window.UseVisualStyleBackColor = True
        '
        'cb_debug_bypass
        '
        Me.cb_debug_bypass.AutoSize = True
        Me.cb_debug_bypass.Location = New System.Drawing.Point(122, 89)
        Me.cb_debug_bypass.Name = "cb_debug_bypass"
        Me.cb_debug_bypass.Size = New System.Drawing.Size(130, 17)
        Me.cb_debug_bypass.TabIndex = 3
        Me.cb_debug_bypass.Text = "Bypass Login (Debug)"
        Me.cb_debug_bypass.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(389, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(389, 62)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 6
        Me.btn_exit.Text = "Cancel"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'form_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 113)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cb_debug_bypass)
        Me.Controls.Add(Me.cb_debug_window)
        Me.Controls.Add(Me.tb_pass)
        Me.Controls.Add(Me.tb_user)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_login"
        Me.Text = "SilverSteel IMS | Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_user As TextBox
    Friend WithEvents tb_pass As TextBox
    Friend WithEvents cb_debug_window As CheckBox
    Friend WithEvents cb_debug_bypass As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_exit As Button
End Class
