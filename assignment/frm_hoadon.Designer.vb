<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_hoadon
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_hoadon))
        Me.btn_them = New System.Windows.Forms.Button()
        Me.DGV_banhang = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BangsanphamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ASSIGNMENTDataSet = New assignment.ASSIGNMENTDataSet()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.btn_xoa = New System.Windows.Forms.Button()
        Me.Bang_san_phamTableAdapter = New assignment.ASSIGNMENTDataSetTableAdapters.Bang_san_phamTableAdapter()
        Me.ASSIGNMENTDataSet1 = New assignment.ASSIGNMENTDataSet1()
        Me.BangsanphamBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Bang_san_phamTableAdapter1 = New assignment.ASSIGNMENTDataSet1TableAdapters.Bang_san_phamTableAdapter()
        Me.BangsanphamBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_thoat = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_ngayxuathoadon = New System.Windows.Forms.TextBox()
        Me.combox_manhanvien = New System.Windows.Forms.ComboBox()
        Me.combox_makhachhang = New System.Windows.Forms.ComboBox()
        CType(Me.DGV_banhang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BangsanphamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASSIGNMENTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASSIGNMENTDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BangsanphamBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BangsanphamBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_them
        '
        Me.btn_them.ForeColor = System.Drawing.Color.Blue
        Me.btn_them.Location = New System.Drawing.Point(9, 232)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(75, 23)
        Me.btn_them.TabIndex = 2
        Me.btn_them.Text = "Thêm"
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'DGV_banhang
        '
        Me.DGV_banhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_banhang.Location = New System.Drawing.Point(283, 12)
        Me.DGV_banhang.Name = "DGV_banhang"
        Me.DGV_banhang.Size = New System.Drawing.Size(478, 284)
        Me.DGV_banhang.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(15, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Mã nhân viên"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(5, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Mã khách hàng"
        '
        'BangsanphamBindingSource
        '
        Me.BangsanphamBindingSource.DataMember = "Bang_san_pham"
        Me.BangsanphamBindingSource.DataSource = Me.ASSIGNMENTDataSet
        '
        'ASSIGNMENTDataSet
        '
        Me.ASSIGNMENTDataSet.DataSetName = "ASSIGNMENTDataSet"
        Me.ASSIGNMENTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_sua
        '
        Me.btn_sua.ForeColor = System.Drawing.Color.Blue
        Me.btn_sua.Location = New System.Drawing.Point(102, 232)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(75, 23)
        Me.btn_sua.TabIndex = 13
        Me.btn_sua.Text = "Sửa"
        Me.btn_sua.UseVisualStyleBackColor = True
        '
        'btn_xoa
        '
        Me.btn_xoa.ForeColor = System.Drawing.Color.Blue
        Me.btn_xoa.Location = New System.Drawing.Point(197, 232)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(75, 23)
        Me.btn_xoa.TabIndex = 14
        Me.btn_xoa.Text = "Xóa"
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'Bang_san_phamTableAdapter
        '
        Me.Bang_san_phamTableAdapter.ClearBeforeFill = True
        '
        'ASSIGNMENTDataSet1
        '
        Me.ASSIGNMENTDataSet1.DataSetName = "ASSIGNMENTDataSet1"
        Me.ASSIGNMENTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BangsanphamBindingSource1
        '
        Me.BangsanphamBindingSource1.DataMember = "Bang_san_pham"
        Me.BangsanphamBindingSource1.DataSource = Me.ASSIGNMENTDataSet1
        '
        'Bang_san_phamTableAdapter1
        '
        Me.Bang_san_phamTableAdapter1.ClearBeforeFill = True
        '
        'BangsanphamBindingSource2
        '
        Me.BangsanphamBindingSource2.DataMember = "Bang_san_pham"
        Me.BangsanphamBindingSource2.DataSource = Me.ASSIGNMENTDataSet
        '
        'btn_thoat
        '
        Me.btn_thoat.ForeColor = System.Drawing.Color.Blue
        Me.btn_thoat.Location = New System.Drawing.Point(53, 273)
        Me.btn_thoat.Name = "btn_thoat"
        Me.btn_thoat.Size = New System.Drawing.Size(172, 23)
        Me.btn_thoat.TabIndex = 29
        Me.btn_thoat.Text = "Thoát"
        Me.btn_thoat.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(5, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Ngày xuất hóa đơn"
        '
        'txt_ngayxuathoadon
        '
        Me.txt_ngayxuathoadon.Location = New System.Drawing.Point(114, 181)
        Me.txt_ngayxuathoadon.Name = "txt_ngayxuathoadon"
        Me.txt_ngayxuathoadon.Size = New System.Drawing.Size(157, 20)
        Me.txt_ngayxuathoadon.TabIndex = 31
        '
        'combox_manhanvien
        '
        Me.combox_manhanvien.FormattingEnabled = True
        Me.combox_manhanvien.Location = New System.Drawing.Point(115, 113)
        Me.combox_manhanvien.Name = "combox_manhanvien"
        Me.combox_manhanvien.Size = New System.Drawing.Size(157, 21)
        Me.combox_manhanvien.TabIndex = 32
        '
        'combox_makhachhang
        '
        Me.combox_makhachhang.FormattingEnabled = True
        Me.combox_makhachhang.Location = New System.Drawing.Point(114, 43)
        Me.combox_makhachhang.Name = "combox_makhachhang"
        Me.combox_makhachhang.Size = New System.Drawing.Size(157, 21)
        Me.combox_makhachhang.TabIndex = 33
        '
        'frm_hoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(764, 320)
        Me.Controls.Add(Me.combox_makhachhang)
        Me.Controls.Add(Me.combox_manhanvien)
        Me.Controls.Add(Me.txt_ngayxuathoadon)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_thoat)
        Me.Controls.Add(Me.btn_xoa)
        Me.Controls.Add(Me.btn_sua)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DGV_banhang)
        Me.Controls.Add(Me.btn_them)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_hoadon"
        Me.Text = "Quản lí hóa đơn"
        CType(Me.DGV_banhang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BangsanphamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASSIGNMENTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASSIGNMENTDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BangsanphamBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BangsanphamBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_them As System.Windows.Forms.Button
    Friend WithEvents DGV_banhang As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_sua As System.Windows.Forms.Button
    Friend WithEvents btn_xoa As System.Windows.Forms.Button
    Friend WithEvents ASSIGNMENTDataSet As assignment.ASSIGNMENTDataSet
    Friend WithEvents BangsanphamBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Bang_san_phamTableAdapter As assignment.ASSIGNMENTDataSetTableAdapters.Bang_san_phamTableAdapter
    Friend WithEvents ASSIGNMENTDataSet1 As assignment.ASSIGNMENTDataSet1
    Friend WithEvents BangsanphamBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Bang_san_phamTableAdapter1 As assignment.ASSIGNMENTDataSet1TableAdapters.Bang_san_phamTableAdapter
    Friend WithEvents BangsanphamBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents btn_thoat As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_ngayxuathoadon As System.Windows.Forms.TextBox
    Friend WithEvents combox_manhanvien As System.Windows.Forms.ComboBox
    Friend WithEvents combox_makhachhang As System.Windows.Forms.ComboBox
End Class
