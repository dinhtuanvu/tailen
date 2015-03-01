<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_quanlinhanvien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_quanlinhanvien))
        Me.btn_them = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_tennhanvien = New System.Windows.Forms.TextBox()
        Me.DGV_quanlinhanvien = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_gioitinh = New System.Windows.Forms.TextBox()
        Me.txt_diachi = New System.Windows.Forms.TextBox()
        Me.txt_ngaysinh = New System.Windows.Forms.TextBox()
        Me.txt_sodienthoai = New System.Windows.Forms.TextBox()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.btn_thoat = New System.Windows.Forms.Button()
        CType(Me.DGV_quanlinhanvien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_them
        '
        Me.btn_them.ForeColor = System.Drawing.Color.Blue
        Me.btn_them.Location = New System.Drawing.Point(12, 312)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(75, 23)
        Me.btn_them.TabIndex = 0
        Me.btn_them.Text = "Thêm"
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(11, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tên nhân viên"
        '
        'txt_tennhanvien
        '
        Me.txt_tennhanvien.Location = New System.Drawing.Point(93, 30)
        Me.txt_tennhanvien.Name = "txt_tennhanvien"
        Me.txt_tennhanvien.Size = New System.Drawing.Size(184, 20)
        Me.txt_tennhanvien.TabIndex = 2
        '
        'DGV_quanlinhanvien
        '
        Me.DGV_quanlinhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_quanlinhanvien.Location = New System.Drawing.Point(283, 12)
        Me.DGV_quanlinhanvien.Name = "DGV_quanlinhanvien"
        Me.DGV_quanlinhanvien.Size = New System.Drawing.Size(640, 323)
        Me.DGV_quanlinhanvien.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(47, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Địa chỉ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(40, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Giới tính"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(33, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ngày sinh"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(17, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Số điện thoại"
        '
        'txt_gioitinh
        '
        Me.txt_gioitinh.Location = New System.Drawing.Point(93, 142)
        Me.txt_gioitinh.Name = "txt_gioitinh"
        Me.txt_gioitinh.Size = New System.Drawing.Size(184, 20)
        Me.txt_gioitinh.TabIndex = 8
        '
        'txt_diachi
        '
        Me.txt_diachi.Location = New System.Drawing.Point(93, 84)
        Me.txt_diachi.Name = "txt_diachi"
        Me.txt_diachi.Size = New System.Drawing.Size(184, 20)
        Me.txt_diachi.TabIndex = 9
        '
        'txt_ngaysinh
        '
        Me.txt_ngaysinh.Location = New System.Drawing.Point(93, 200)
        Me.txt_ngaysinh.Name = "txt_ngaysinh"
        Me.txt_ngaysinh.Size = New System.Drawing.Size(184, 20)
        Me.txt_ngaysinh.TabIndex = 10
        '
        'txt_sodienthoai
        '
        Me.txt_sodienthoai.Location = New System.Drawing.Point(93, 262)
        Me.txt_sodienthoai.Name = "txt_sodienthoai"
        Me.txt_sodienthoai.Size = New System.Drawing.Size(184, 20)
        Me.txt_sodienthoai.TabIndex = 11
        '
        'btn_xoa
        '
        Me.btn_xoa.ForeColor = System.Drawing.Color.Blue
        Me.btn_xoa.Location = New System.Drawing.Point(202, 312)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(75, 23)
        Me.btn_xoa.TabIndex = 12
        Me.btn_xoa.Text = "Xóa"
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'btn_sua
        '
        Me.btn_sua.ForeColor = System.Drawing.Color.Blue
        Me.btn_sua.Location = New System.Drawing.Point(107, 312)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(75, 23)
        Me.btn_sua.TabIndex = 13
        Me.btn_sua.Text = "Sửa"
        Me.btn_sua.UseVisualStyleBackColor = True
        '
        'btn_thoat
        '
        Me.btn_thoat.ForeColor = System.Drawing.Color.Blue
        Me.btn_thoat.Location = New System.Drawing.Point(63, 344)
        Me.btn_thoat.Name = "btn_thoat"
        Me.btn_thoat.Size = New System.Drawing.Size(172, 23)
        Me.btn_thoat.TabIndex = 29
        Me.btn_thoat.Text = "Thoát"
        Me.btn_thoat.UseVisualStyleBackColor = True
        '
        'frm_quanlinhanvien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(928, 379)
        Me.Controls.Add(Me.btn_thoat)
        Me.Controls.Add(Me.btn_sua)
        Me.Controls.Add(Me.btn_xoa)
        Me.Controls.Add(Me.txt_sodienthoai)
        Me.Controls.Add(Me.txt_ngaysinh)
        Me.Controls.Add(Me.txt_diachi)
        Me.Controls.Add(Me.txt_gioitinh)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV_quanlinhanvien)
        Me.Controls.Add(Me.txt_tennhanvien)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_them)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_quanlinhanvien"
        Me.Text = "Quản lí nhân viên"
        CType(Me.DGV_quanlinhanvien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_them As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_tennhanvien As System.Windows.Forms.TextBox
    Friend WithEvents DGV_quanlinhanvien As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_gioitinh As System.Windows.Forms.TextBox
    Friend WithEvents txt_diachi As System.Windows.Forms.TextBox
    Friend WithEvents txt_ngaysinh As System.Windows.Forms.TextBox
    Friend WithEvents txt_sodienthoai As System.Windows.Forms.TextBox
    Friend WithEvents btn_xoa As System.Windows.Forms.Button
    Friend WithEvents btn_sua As System.Windows.Forms.Button
    Friend WithEvents btn_thoat As System.Windows.Forms.Button

End Class
