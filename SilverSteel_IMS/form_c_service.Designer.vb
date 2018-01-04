<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_c_service
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_c_service))
        Me.cb_cw = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gb_carwash = New System.Windows.Forms.GroupBox()
        Me.btn_set = New System.Windows.Forms.Button()
        Me.btn_now = New System.Windows.Forms.Button()
        Me.tb_c_cd = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_c_ap = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_c_ct = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_c_st = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_c_ts = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_override = New System.Windows.Forms.Button()
        Me.gb_carwash.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb_cw
        '
        Me.cb_cw.FormattingEnabled = True
        Me.cb_cw.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cb_cw.Location = New System.Drawing.Point(89, 12)
        Me.cb_cw.Name = "cb_cw"
        Me.cb_cw.Size = New System.Drawing.Size(121, 21)
        Me.cb_cw.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Carwash Slot:"
        '
        'gb_carwash
        '
        Me.gb_carwash.Controls.Add(Me.btn_set)
        Me.gb_carwash.Controls.Add(Me.btn_now)
        Me.gb_carwash.Controls.Add(Me.tb_c_cd)
        Me.gb_carwash.Controls.Add(Me.Label6)
        Me.gb_carwash.Controls.Add(Me.tb_c_ap)
        Me.gb_carwash.Controls.Add(Me.Label5)
        Me.gb_carwash.Controls.Add(Me.tb_c_ct)
        Me.gb_carwash.Controls.Add(Me.Label4)
        Me.gb_carwash.Controls.Add(Me.tb_c_st)
        Me.gb_carwash.Controls.Add(Me.Label3)
        Me.gb_carwash.Controls.Add(Me.tb_c_ts)
        Me.gb_carwash.Controls.Add(Me.Label2)
        Me.gb_carwash.Location = New System.Drawing.Point(15, 39)
        Me.gb_carwash.Name = "gb_carwash"
        Me.gb_carwash.Size = New System.Drawing.Size(257, 180)
        Me.gb_carwash.TabIndex = 2
        Me.gb_carwash.TabStop = False
        Me.gb_carwash.Text = "Information"
        '
        'btn_set
        '
        Me.btn_set.Location = New System.Drawing.Point(109, 147)
        Me.btn_set.Name = "btn_set"
        Me.btn_set.Size = New System.Drawing.Size(142, 23)
        Me.btn_set.TabIndex = 3
        Me.btn_set.Text = "Set"
        Me.btn_set.UseVisualStyleBackColor = True
        '
        'btn_now
        '
        Me.btn_now.Location = New System.Drawing.Point(204, 14)
        Me.btn_now.Name = "btn_now"
        Me.btn_now.Size = New System.Drawing.Size(47, 23)
        Me.btn_now.TabIndex = 2
        Me.btn_now.Text = "NOW"
        Me.btn_now.UseVisualStyleBackColor = True
        '
        'tb_c_cd
        '
        Me.tb_c_cd.Location = New System.Drawing.Point(83, 121)
        Me.tb_c_cd.Name = "tb_c_cd"
        Me.tb_c_cd.Size = New System.Drawing.Size(115, 20)
        Me.tb_c_cd.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Car Desc:"
        '
        'tb_c_ap
        '
        Me.tb_c_ap.Location = New System.Drawing.Point(83, 95)
        Me.tb_c_ap.Name = "tb_c_ap"
        Me.tb_c_ap.Size = New System.Drawing.Size(115, 20)
        Me.tb_c_ap.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Amt. Paid:"
        '
        'tb_c_ct
        '
        Me.tb_c_ct.Location = New System.Drawing.Point(83, 69)
        Me.tb_c_ct.Name = "tb_c_ct"
        Me.tb_c_ct.Size = New System.Drawing.Size(115, 20)
        Me.tb_c_ct.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Car Type:"
        '
        'tb_c_st
        '
        Me.tb_c_st.Location = New System.Drawing.Point(83, 43)
        Me.tb_c_st.Name = "tb_c_st"
        Me.tb_c_st.Size = New System.Drawing.Size(115, 20)
        Me.tb_c_st.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Service Type:"
        '
        'tb_c_ts
        '
        Me.tb_c_ts.Location = New System.Drawing.Point(83, 17)
        Me.tb_c_ts.Name = "tb_c_ts"
        Me.tb_c_ts.Size = New System.Drawing.Size(115, 20)
        Me.tb_c_ts.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Time Started:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "----"
        '
        'btn_override
        '
        Me.btn_override.Location = New System.Drawing.Point(124, 240)
        Me.btn_override.Name = "btn_override"
        Me.btn_override.Size = New System.Drawing.Size(142, 23)
        Me.btn_override.TabIndex = 4
        Me.btn_override.Text = "Override"
        Me.btn_override.UseVisualStyleBackColor = True
        '
        'form_c_service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 267)
        Me.Controls.Add(Me.btn_override)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.gb_carwash)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_cw)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_c_service"
        Me.Text = "New Carwash"
        Me.gb_carwash.ResumeLayout(False)
        Me.gb_carwash.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb_cw As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gb_carwash As GroupBox
    Friend WithEvents btn_now As Button
    Friend WithEvents tb_c_st As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_c_ts As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_set As Button
    Friend WithEvents tb_c_cd As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_c_ap As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_c_ct As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_override As Button
End Class
