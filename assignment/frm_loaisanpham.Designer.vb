<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_loaisanpham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_loaisanpham))
        Me.btn_them = New System.Windows.Forms.Button()
        Me.DGV_quanliloaisanpham = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_tenloaisanpham = New System.Windows.Forms.TextBox()
        Me.txt_mota = New System.Windows.Forms.TextBox()
        Me.btn_sua = New System.Windows.Forms.Button()
        Me.btn_xoa = New System.Windows.Forms.Button()
        CType(Me.DGV_quanliloaisanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_them
        '
        Me.btn_them.ForeColor = System.Drawing.Color.Blue
        Me.btn_them.Location = New System.Drawing.Point(12, 276)
        Me.btn_them.Name = "btn_them"
        Me.btn_them.Size = New System.Drawing.Size(75, 23)
        Me.btn_them.TabIndex = 1
        Me.btn_them.Text = "Thêm"
        Me.btn_them.UseVisualStyleBackColor = True
        '
        'DGV_quanliloaisanpham
        '
        Me.DGV_quanliloaisanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_quanliloaisanpham.Location = New System.Drawing.Point(304, 25)
        Me.DGV_quanliloaisanpham.Name = "DGV_quanliloaisanpham"
        Me.DGV_quanliloaisanpham.Size = New System.Drawing.Size(336, 274)
        Me.DGV_quanliloaisanpham.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tên loại sản phẩm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(12, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mô tả"
        '
        'txt_tenloaisanpham
        '
        Me.txt_tenloaisanpham.Location = New System.Drawing.Point(124, 49)
        Me.txt_tenloaisanpham.Name = "txt_tenloaisanpham"
        Me.txt_tenloaisanpham.Size = New System.Drawing.Size(161, 20)
        Me.txt_tenloaisanpham.TabIndex = 6
        '
        'txt_mota
        '
        Me.txt_mota.Location = New System.Drawing.Point(67, 118)
        Me.txt_mota.Multiline = True
        Me.txt_mota.Name = "txt_mota"
        Me.txt_mota.Size = New System.Drawing.Size(218, 115)
        Me.txt_mota.TabIndex = 7
        '
        'btn_sua
        '
        Me.btn_sua.ForeColor = System.Drawing.Color.Blue
        Me.btn_sua.Location = New System.Drawing.Point(113, 276)
        Me.btn_sua.Name = "btn_sua"
        Me.btn_sua.Size = New System.Drawing.Size(75, 23)
        Me.btn_sua.TabIndex = 8
        Me.btn_sua.Text = "Sửa"
        Me.btn_sua.UseVisualStyleBackColor = True
        '
        'btn_xoa
        '
        Me.btn_xoa.ForeColor = System.Drawing.Color.Blue
        Me.btn_xoa.Location = New System.Drawing.Point(210, 276)
        Me.btn_xoa.Name = "btn_xoa"
        Me.btn_xoa.Size = New System.Drawing.Size(75, 23)
        Me.btn_xoa.TabIndex = 9
        Me.btn_xoa.Text = "Xóa"
        Me.btn_xoa.UseVisualStyleBackColor = True
        '
        'frm_loaisanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(646, 332)
        Me.Controls.Add(Me.btn_xoa)
        Me.Controls.Add(Me.btn_sua)
        Me.Controls.Add(Me.txt_mota)
        Me.Controls.Add(Me.txt_tenloaisanpham)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV_quanliloaisanpham)
        Me.Controls.Add(Me.btn_them)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_loaisanpham"
        Me.Text = "Quản lí loại sản phẩm"
        CType(Me.DGV_quanliloaisanpham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_them As System.Windows.Forms.Button
    Friend WithEvents DGV_quanliloaisanpham As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_tenloaisanpham As System.Windows.Forms.TextBox
    Friend WithEvents txt_mota As System.Windows.Forms.TextBox
    Friend WithEvents btn_sua As System.Windows.Forms.Button
    Friend WithEvents btn_xoa As System.Windows.Forms.Button
End Class
