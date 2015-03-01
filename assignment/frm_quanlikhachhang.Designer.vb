<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_quanlikhachhang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_quanlikhachhang))
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.txt_sodienthoai = New System.Windows.Forms.TextBox()
        Me.txt_diachi = New System.Windows.Forms.TextBox()
        Me.txt_gioitinh = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGV_quanlikhachhang = New System.Windows.Forms.DataGridView()
        Me.txt_tenkhachhang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_them = New System.Windows.Forms.Button()
        Me.btn_thoat = New System.Windows.Forms.Button()
        CType(Me.DGV_quanlikhachhang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_sua
        '
        Me.btn_sua.ForeColor = System.Drawing.Color.Blue
        Me.btn_sua.Location = New System.Drawing.Point(101, 265)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(75, 23)
        Me.btn_sua.TabIndex = 27
        Me.btn_sua.Text = "Sửa"
        Me.btn_sua.UseVisualStyleBackColor = True
        '
        'btn_xoa
        '
        Me.btn_xoa.ForeColor = System.Drawing.Color.Blue
        Me.btn_xoa.Location = New System.Drawing.Point(196, 265)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(75, 23)
        Me.btn_xoa.TabIndex = 26
        Me.btn_xoa.Text = "Xóa"
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'txt_sodienthoai
        '
        Me.txt_sodienthoai.Location = New System.Drawing.Point(102, 209)
        Me.txt_sodienthoai.Name = "txt_sodienthoai"
        Me.txt_sodienthoai.Size = New System.Drawing.Size(184, 20)
        Me.txt_sodienthoai.TabIndex = 25
        '
        'txt_diachi
        '
        Me.txt_diachi.Location = New System.Drawing.Point(102, 147)
        Me.txt_diachi.Name = "txt_diachi"
        Me.txt_diachi.Size = New System.Drawing.Size(184, 20)
        Me.txt_diachi.TabIndex = 23
        '
        'txt_gioitinh
        '
        Me.txt_gioitinh.Location = New System.Drawing.Point(101, 81)
        Me.txt_gioitinh.Name = "txt_gioitinh"
        Me.txt_gioitinh.Size = New System.Drawing.Size(184, 20)
        Me.txt_gioitinh.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(17, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Số điện thoại"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(40, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Giới tính"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(47, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Địa chỉ"
        '
        'DGV_quanlikhachhang
        '
        Me.DGV_quanlikhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_quanlikhachhang.Location = New System.Drawing.Point(292, 22)
        Me.DGV_quanlikhachhang.Name = "DGV_quanlikhachhang"
        Me.DGV_quanlikhachhang.Size = New System.Drawing.Size(562, 266)
        Me.DGV_quanlikhachhang.TabIndex = 17
        '
        'txt_tenkhachhang
        '
        Me.txt_tenkhachhang.Location = New System.Drawing.Point(101, 22)
        Me.txt_tenkhachhang.Name = "txt_tenkhachhang"
        Me.txt_tenkhachhang.Size = New System.Drawing.Size(184, 20)
        Me.txt_tenkhachhang.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(1, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Tên khách hàng"
        '
        'btn_them
        '
        Me.btn_them.ForeColor = System.Drawing.Color.Blue
        Me.btn_them.Location = New System.Drawing.Point(12, 265)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(75, 23)
        Me.btn_them.TabIndex = 14
        Me.btn_them.Text = "Thêm"
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'btn_thoat
        '
        Me.btn_thoat.ForeColor = System.Drawing.Color.Blue
        Me.btn_thoat.Location = New System.Drawing.Point(50, 311)
        Me.btn_thoat.Name = "btn_thoat"
        Me.btn_thoat.Size = New System.Drawing.Size(172, 23)
        Me.btn_thoat.TabIndex = 28
        Me.btn_thoat.Text = "Thoát"
        Me.btn_thoat.UseVisualStyleBackColor = True
        '
        'frm_quanlikhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(859, 346)
        Me.Controls.Add(Me.btn_thoat)
        Me.Controls.Add(Me.btn_sua)
        Me.Controls.Add(Me.btn_xoa)
        Me.Controls.Add(Me.txt_sodienthoai)
        Me.Controls.Add(Me.txt_diachi)
        Me.Controls.Add(Me.txt_gioitinh)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV_quanlikhachhang)
        Me.Controls.Add(Me.txt_tenkhachhang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_them)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_quanlikhachhang"
        Me.Text = "Quản lí khách hàng"
        CType(Me.DGV_quanlikhachhang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_sua As System.Windows.Forms.Button
    Friend WithEvents btn_xoa As System.Windows.Forms.Button
    Friend WithEvents txt_sodienthoai As System.Windows.Forms.TextBox
    Friend WithEvents txt_diachi As System.Windows.Forms.TextBox
    Friend WithEvents txt_gioitinh As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DGV_quanlikhachhang As System.Windows.Forms.DataGridView
    Friend WithEvents txt_tenkhachhang As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_them As System.Windows.Forms.Button
    Friend WithEvents btn_thoat As System.Windows.Forms.Button
End Class
