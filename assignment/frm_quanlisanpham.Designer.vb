<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_quanlisanpham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_quanlisanpham))
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.txt_tensanpham = New System.Windows.Forms.TextBox()
        Me.txt_chitietsanpham = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGV_quanlisanpham = New System.Windows.Forms.DataGridView()
        Me.btn_them = New System.Windows.Forms.Button()
        Me.btn_themloaisanpham = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.combox_maloaisanpham = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_tenloaisanpham = New System.Windows.Forms.TextBox()
        Me.btn_thoat = New System.Windows.Forms.Button()
        CType(Me.DGV_quanlisanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_sua
        '
        Me.btn_sua.ForeColor = System.Drawing.Color.Blue
        Me.btn_sua.Location = New System.Drawing.Point(104, 333)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(75, 23)
        Me.btn_sua.TabIndex = 27
        Me.btn_sua.Text = "Sửa"
        Me.btn_sua.UseVisualStyleBackColor = True
        '
        'btn_xoa
        '
        Me.btn_xoa.ForeColor = System.Drawing.Color.Blue
        Me.btn_xoa.Location = New System.Drawing.Point(199, 333)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(75, 23)
        Me.btn_xoa.TabIndex = 26
        Me.btn_xoa.Text = "Xóa"
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'txt_tensanpham
        '
        Me.txt_tensanpham.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_tensanpham.Location = New System.Drawing.Point(104, 104)
        Me.txt_tensanpham.Name = "txt_tensanpham"
        Me.txt_tensanpham.Size = New System.Drawing.Size(170, 20)
        Me.txt_tensanpham.TabIndex = 23
        '
        'txt_chitietsanpham
        '
        Me.txt_chitietsanpham.Location = New System.Drawing.Point(15, 184)
        Me.txt_chitietsanpham.Multiline = True
        Me.txt_chitietsanpham.Name = "txt_chitietsanpham"
        Me.txt_chitietsanpham.Size = New System.Drawing.Size(259, 115)
        Me.txt_chitietsanpham.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(12, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Chi tiết sản phẩm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(6, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Tên sản phẩm"
        '
        'DGV_quanlisanpham
        '
        Me.DGV_quanlisanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_quanlisanpham.Location = New System.Drawing.Point(421, 9)
        Me.DGV_quanlisanpham.Name = "DGV_quanlisanpham"
        Me.DGV_quanlisanpham.Size = New System.Drawing.Size(448, 347)
        Me.DGV_quanlisanpham.TabIndex = 17
        '
        'btn_them
        '
        Me.btn_them.ForeColor = System.Drawing.Color.Blue
        Me.btn_them.Location = New System.Drawing.Point(9, 333)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(75, 23)
        Me.btn_them.TabIndex = 14
        Me.btn_them.Text = "Thêm"
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'btn_themloaisanpham
        '
        Me.btn_themloaisanpham.ForeColor = System.Drawing.Color.Blue
        Me.btn_themloaisanpham.Location = New System.Drawing.Point(291, 16)
        Me.btn_themloaisanpham.Name = "btn_themloaisanpham"
        Me.btn_themloaisanpham.Size = New System.Drawing.Size(114, 23)
        Me.btn_themloaisanpham.TabIndex = 29
        Me.btn_themloaisanpham.Text = "Thêm loại sản phẩm"
        Me.btn_themloaisanpham.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Mã loại sản phẩm"
        '
        'combox_maloaisanpham
        '
        Me.combox_maloaisanpham.ForeColor = System.Drawing.SystemColors.WindowText
        Me.combox_maloaisanpham.FormattingEnabled = True
        Me.combox_maloaisanpham.Location = New System.Drawing.Point(104, 16)
        Me.combox_maloaisanpham.Name = "combox_maloaisanpham"
        Me.combox_maloaisanpham.Size = New System.Drawing.Size(170, 21)
        Me.combox_maloaisanpham.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(4, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Tên loại sản phẩm"
        '
        'txt_tenloaisanpham
        '
        Me.txt_tenloaisanpham.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_tenloaisanpham.Location = New System.Drawing.Point(104, 62)
        Me.txt_tenloaisanpham.Name = "txt_tenloaisanpham"
        Me.txt_tenloaisanpham.Size = New System.Drawing.Size(170, 20)
        Me.txt_tenloaisanpham.TabIndex = 32
        '
        'btn_thoat
        '
        Me.btn_thoat.ForeColor = System.Drawing.Color.Blue
        Me.btn_thoat.Location = New System.Drawing.Point(53, 370)
        Me.btn_thoat.Name = "btn_thoat"
        Me.btn_thoat.Size = New System.Drawing.Size(172, 23)
        Me.btn_thoat.TabIndex = 33
        Me.btn_thoat.Text = "Thoát"
        Me.btn_thoat.UseVisualStyleBackColor = True
        '
        'frm_quanlisanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(876, 405)
        Me.Controls.Add(Me.btn_thoat)
        Me.Controls.Add(Me.txt_tenloaisanpham)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_themloaisanpham)
        Me.Controls.Add(Me.combox_maloaisanpham)
        Me.Controls.Add(Me.btn_sua)
        Me.Controls.Add(Me.btn_xoa)
        Me.Controls.Add(Me.txt_tensanpham)
        Me.Controls.Add(Me.txt_chitietsanpham)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV_quanlisanpham)
        Me.Controls.Add(Me.btn_them)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_quanlisanpham"
        Me.Text = "Quản lí sản phẩm"
        CType(Me.DGV_quanlisanpham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_sua As System.Windows.Forms.Button
    Friend WithEvents btn_xoa As System.Windows.Forms.Button
    Friend WithEvents txt_tensanpham As System.Windows.Forms.TextBox
    Friend WithEvents txt_chitietsanpham As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DGV_quanlisanpham As System.Windows.Forms.DataGridView
    Friend WithEvents btn_them As System.Windows.Forms.Button
    Friend WithEvents btn_themloaisanpham As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents combox_maloaisanpham As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_tenloaisanpham As System.Windows.Forms.TextBox
    Friend WithEvents btn_thoat As System.Windows.Forms.Button
End Class
