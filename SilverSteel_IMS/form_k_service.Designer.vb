<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_k_service
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
        Me.btn_override = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tp_ts = New System.Windows.Forms.DateTimePicker()
        Me.btn_set = New System.Windows.Forms.Button()
        Me.btn_now = New System.Windows.Forms.Button()
        Me.tb_plateno = New System.Windows.Forms.TextBox()
        Me.tb_c_cd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gb_carwash = New System.Windows.Forms.GroupBox()
        Me.cb_cw = New System.Windows.Forms.ComboBox()
        Me.gb_carwash.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_override
        '
        Me.btn_override.Location = New System.Drawing.Point(130, 193)
        Me.btn_override.Name = "btn_override"
        Me.btn_override.Size = New System.Drawing.Size(142, 23)
        Me.btn_override.TabIndex = 19
        Me.btn_override.Text = "Override"
        Me.btn_override.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(194, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Override Requires Supervisor Password"
        '
        'tp_ts
        '
        Me.tp_ts.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.tp_ts.Location = New System.Drawing.Point(82, 15)
        Me.tp_ts.Name = "tp_ts"
        Me.tp_ts.ShowUpDown = True
        Me.tp_ts.Size = New System.Drawing.Size(115, 20)
        Me.tp_ts.TabIndex = 1
        '
        'btn_set
        '
        Me.btn_set.Location = New System.Drawing.Point(107, 105)
        Me.btn_set.Name = "btn_set"
        Me.btn_set.Size = New System.Drawing.Size(142, 23)
        Me.btn_set.TabIndex = 11
        Me.btn_set.Text = "Set"
        Me.btn_set.UseVisualStyleBackColor = True
        '
        'btn_now
        '
        Me.btn_now.Location = New System.Drawing.Point(202, 14)
        Me.btn_now.Name = "btn_now"
        Me.btn_now.Size = New System.Drawing.Size(47, 23)
        Me.btn_now.TabIndex = 2
        Me.btn_now.Text = "NOW"
        Me.btn_now.UseVisualStyleBackColor = True
        '
        'tb_plateno
        '
        Me.tb_plateno.Location = New System.Drawing.Point(82, 38)
        Me.tb_plateno.Name = "tb_plateno"
        Me.tb_plateno.Size = New System.Drawing.Size(115, 20)
        Me.tb_plateno.TabIndex = 3
        '
        'tb_c_cd
        '
        Me.tb_c_cd.Location = New System.Drawing.Point(82, 61)
        Me.tb_c_cd.Name = "tb_c_cd"
        Me.tb_c_cd.Size = New System.Drawing.Size(115, 20)
        Me.tb_c_cd.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Hours:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Amount Paid:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "KTV Slot:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Time Started:"
        '
        'gb_carwash
        '
        Me.gb_carwash.Controls.Add(Me.tp_ts)
        Me.gb_carwash.Controls.Add(Me.btn_set)
        Me.gb_carwash.Controls.Add(Me.btn_now)
        Me.gb_carwash.Controls.Add(Me.tb_plateno)
        Me.gb_carwash.Controls.Add(Me.tb_c_cd)
        Me.gb_carwash.Controls.Add(Me.Label8)
        Me.gb_carwash.Controls.Add(Me.Label6)
        Me.gb_carwash.Controls.Add(Me.Label2)
        Me.gb_carwash.Location = New System.Drawing.Point(15, 37)
        Me.gb_carwash.Name = "gb_carwash"
        Me.gb_carwash.Size = New System.Drawing.Size(257, 137)
        Me.gb_carwash.TabIndex = 17
        Me.gb_carwash.TabStop = False
        Me.gb_carwash.Text = "Information"
        '
        'cb_cw
        '
        Me.cb_cw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_cw.FormattingEnabled = True
        Me.cb_cw.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cb_cw.Location = New System.Drawing.Point(89, 10)
        Me.cb_cw.Name = "cb_cw"
        Me.cb_cw.Size = New System.Drawing.Size(121, 21)
        Me.cb_cw.TabIndex = 15
        '
        'form_k_service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 223)
        Me.Controls.Add(Me.btn_override)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gb_carwash)
        Me.Controls.Add(Me.cb_cw)
        Me.Name = "form_k_service"
        Me.Text = "form_k_service"
        Me.gb_carwash.ResumeLayout(False)
        Me.gb_carwash.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_override As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents tp_ts As DateTimePicker
    Friend WithEvents btn_set As Button
    Friend WithEvents btn_now As Button
    Friend WithEvents tb_plateno As TextBox
    Friend WithEvents tb_c_cd As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gb_carwash As GroupBox
    Friend WithEvents cb_cw As ComboBox
End Class
