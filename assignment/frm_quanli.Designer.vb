<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_quanli
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_quanli))
        Me.btn_quanlikhachhang = New System.Windows.Forms.Button()
        Me.btn_quanlibanhang = New System.Windows.Forms.Button()
        Me.btn_quanlinhanvien = New System.Windows.Forms.Button()
        Me.btn_quanlihanghoa = New System.Windows.Forms.Button()
        Me.btn_quanlichitiethoadon = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_quanlikhachhang
        '
        Me.btn_quanlikhachhang.ForeColor = System.Drawing.Color.Blue
        Me.btn_quanlikhachhang.Location = New System.Drawing.Point(371, 44)
        Me.btn_quanlikhachhang.Name = "btn_quanlikhachhang"
        Me.btn_quanlikhachhang.Size = New System.Drawing.Size(174, 23)
        Me.btn_quanlikhachhang.TabIndex = 0
        Me.btn_quanlikhachhang.Text = "Quản lí khách hàng"
        Me.btn_quanlikhachhang.UseVisualStyleBackColor = True
        '
        'btn_quanlibanhang
        '
        Me.btn_quanlibanhang.ForeColor = System.Drawing.Color.Blue
        Me.btn_quanlibanhang.Location = New System.Drawing.Point(371, 216)
        Me.btn_quanlibanhang.Name = "btn_quanlibanhang"
        Me.btn_quanlibanhang.Size = New System.Drawing.Size(174, 23)
        Me.btn_quanlibanhang.TabIndex = 1
        Me.btn_quanlibanhang.Text = "Quản lí hóa đơn"
        Me.btn_quanlibanhang.UseVisualStyleBackColor = True
        '
        'btn_quanlinhanvien
        '
        Me.btn_quanlinhanvien.ForeColor = System.Drawing.Color.Blue
        Me.btn_quanlinhanvien.Location = New System.Drawing.Point(371, 101)
        Me.btn_quanlinhanvien.Name = "btn_quanlinhanvien"
        Me.btn_quanlinhanvien.Size = New System.Drawing.Size(174, 23)
        Me.btn_quanlinhanvien.TabIndex = 2
        Me.btn_quanlinhanvien.Text = "Quản lí nhân viên"
        Me.btn_quanlinhanvien.UseVisualStyleBackColor = True
        '
        'btn_quanlihanghoa
        '
        Me.btn_quanlihanghoa.ForeColor = System.Drawing.Color.Blue
        Me.btn_quanlihanghoa.Location = New System.Drawing.Point(371, 157)
        Me.btn_quanlihanghoa.Name = "btn_quanlihanghoa"
        Me.btn_quanlihanghoa.Size = New System.Drawing.Size(174, 23)
        Me.btn_quanlihanghoa.TabIndex = 3
        Me.btn_quanlihanghoa.Text = "Quản lí sản phẩm"
        Me.btn_quanlihanghoa.UseVisualStyleBackColor = True
        '
        'btn_quanlichitiethoadon
        '
        Me.btn_quanlichitiethoadon.ForeColor = System.Drawing.Color.Blue
        Me.btn_quanlichitiethoadon.Location = New System.Drawing.Point(371, 270)
        Me.btn_quanlichitiethoadon.Name = "btn_quanlichitiethoadon"
        Me.btn_quanlichitiethoadon.Size = New System.Drawing.Size(174, 23)
        Me.btn_quanlichitiethoadon.TabIndex = 4
        Me.btn_quanlichitiethoadon.Text = "Quản lí chi tiết hóa đơn"
        Me.btn_quanlichitiethoadon.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.assignment.My.Resources.Resources.image_thumb1378952876
        Me.PictureBox1.Location = New System.Drawing.Point(26, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(302, 277)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'frm_quanli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(605, 333)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_quanlichitiethoadon)
        Me.Controls.Add(Me.btn_quanlihanghoa)
        Me.Controls.Add(Me.btn_quanlinhanvien)
        Me.Controls.Add(Me.btn_quanlibanhang)
        Me.Controls.Add(Me.btn_quanlikhachhang)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_quanli"
        Me.Text = "Quản lí"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_quanlikhachhang As System.Windows.Forms.Button
    Friend WithEvents btn_quanlibanhang As System.Windows.Forms.Button
    Friend WithEvents btn_quanlinhanvien As System.Windows.Forms.Button
    Friend WithEvents btn_quanlihanghoa As System.Windows.Forms.Button
    Friend WithEvents btn_quanlichitiethoadon As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
