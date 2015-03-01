<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_chitiethoadon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_chitiethoadon))
        Me.btn_them = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV_chitiethoadon = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_gia = New System.Windows.Forms.TextBox()
        Me.txt_soluong = New System.Windows.Forms.TextBox()
        Me.txt_thanhtien = New System.Windows.Forms.TextBox()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.btn_thoat = New System.Windows.Forms.Button()
        Me.combox_sanpham = New System.Windows.Forms.ComboBox()
        Me.combox_mashoadon = New System.Windows.Forms.ComboBox()
        CType(Me.DGV_chitiethoadon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_them
        '
        Me.btn_them.ForeColor = System.Drawing.Color.Blue
        Me.btn_them.Location = New System.Drawing.Point(12, 325)
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
        Me.Label1.Location = New System.Drawing.Point(9, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mã hóa đơn"
        '
        'DGV_chitiethoadon
        '
        Me.DGV_chitiethoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_chitiethoadon.Location = New System.Drawing.Point(277, 16)
        Me.DGV_chitiethoadon.Name = "DGV_chitiethoadon"
        Me.DGV_chitiethoadon.Size = New System.Drawing.Size(645, 374)
        Me.DGV_chitiethoadon.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(3, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mã sản phẩm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(51, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Giá"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(25, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Số lượng"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(16, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Thành tiền"
        '
        'txt_gia
        '
        Me.txt_gia.Location = New System.Drawing.Point(101, 144)
        Me.txt_gia.Name = "txt_gia"
        Me.txt_gia.Size = New System.Drawing.Size(144, 20)
        Me.txt_gia.TabIndex = 10
        '
        'txt_soluong
        '
        Me.txt_soluong.Location = New System.Drawing.Point(101, 202)
        Me.txt_soluong.Name = "txt_soluong"
        Me.txt_soluong.Size = New System.Drawing.Size(144, 20)
        Me.txt_soluong.TabIndex = 11
        '
        'txt_thanhtien
        '
        Me.txt_thanhtien.Location = New System.Drawing.Point(101, 260)
        Me.txt_thanhtien.Name = "txt_thanhtien"
        Me.txt_thanhtien.Size = New System.Drawing.Size(144, 20)
        Me.txt_thanhtien.TabIndex = 12
        '
        'btn_sua
        '
        Me.btn_sua.ForeColor = System.Drawing.Color.Blue
        Me.btn_sua.Location = New System.Drawing.Point(101, 325)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(75, 23)
        Me.btn_sua.TabIndex = 13
        Me.btn_sua.Text = "Sửa"
        Me.btn_sua.UseVisualStyleBackColor = True
        '
        'btn_xoa
        '
        Me.btn_xoa.ForeColor = System.Drawing.Color.Blue
        Me.btn_xoa.Location = New System.Drawing.Point(196, 325)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(75, 23)
        Me.btn_xoa.TabIndex = 14
        Me.btn_xoa.Text = "Xóa"
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'btn_thoat
        '
        Me.btn_thoat.ForeColor = System.Drawing.Color.Blue
        Me.btn_thoat.Location = New System.Drawing.Point(64, 367)
        Me.btn_thoat.Name = "btn_thoat"
        Me.btn_thoat.Size = New System.Drawing.Size(143, 23)
        Me.btn_thoat.TabIndex = 15
        Me.btn_thoat.Text = "Thoát"
        Me.btn_thoat.UseVisualStyleBackColor = True
        '
        'combox_sanpham
        '
        Me.combox_sanpham.FormattingEnabled = True
        Me.combox_sanpham.Location = New System.Drawing.Point(101, 86)
        Me.combox_sanpham.Name = "combox_sanpham"
        Me.combox_sanpham.Size = New System.Drawing.Size(144, 21)
        Me.combox_sanpham.TabIndex = 16
        '
        'combox_mashoadon
        '
        Me.combox_mashoadon.FormattingEnabled = True
        Me.combox_mashoadon.Location = New System.Drawing.Point(101, 23)
        Me.combox_mashoadon.Name = "combox_mashoadon"
        Me.combox_mashoadon.Size = New System.Drawing.Size(144, 21)
        Me.combox_mashoadon.TabIndex = 17
        '
        'frm_chitiethoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(924, 424)
        Me.Controls.Add(Me.combox_mashoadon)
        Me.Controls.Add(Me.combox_sanpham)
        Me.Controls.Add(Me.btn_thoat)
        Me.Controls.Add(Me.btn_xoa)
        Me.Controls.Add(Me.btn_sua)
        Me.Controls.Add(Me.txt_thanhtien)
        Me.Controls.Add(Me.txt_soluong)
        Me.Controls.Add(Me.txt_gia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV_chitiethoadon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_them)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_chitiethoadon"
        Me.Text = "Chi tiết hóa đơn"
        CType(Me.DGV_chitiethoadon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_them As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGV_chitiethoadon As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_gia As System.Windows.Forms.TextBox
    Friend WithEvents txt_soluong As System.Windows.Forms.TextBox
    Friend WithEvents txt_thanhtien As System.Windows.Forms.TextBox
    Friend WithEvents btn_sua As System.Windows.Forms.Button
    Friend WithEvents btn_xoa As System.Windows.Forms.Button
    Friend WithEvents btn_thoat As System.Windows.Forms.Button
    Friend WithEvents combox_sanpham As System.Windows.Forms.ComboBox
    Friend WithEvents combox_mashoadon As System.Windows.Forms.ComboBox
End Class
