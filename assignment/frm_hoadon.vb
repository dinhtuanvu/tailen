Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frm_hoadon
    Public con As New SqlConnection("workstation id=vudtpk00391.mssql.somee.com;packet size=4096;user id=vudtpk00391_SQLLogin_1;pwd=9nf6cloxxa;data source=vudtpk00391.mssql.somee.com;persist security info=False;initial catalog=vudtpk00391")
    Public Sub moketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
    Public Sub dongketnoi()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub
    
    Private Sub Dockhachhang()
        moketnoi()
        Dim com As New SqlCommand("select * from Bang_khach_hang", con)
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable()
        da.Fill(dt)
        dongketnoi()
        combox_makhachhang.Items.Clear()
        For Each row As DataRow In dt.Rows
            combox_makhachhang.Items.Add(row("Ma_khach_hang").ToString())
        Next
    End Sub
    Private Sub Docnhanvien()
        moketnoi()
        Dim com As New SqlCommand("select * from Bang_nhan_vien", con)
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable()
        da.Fill(dt)
        dongketnoi()
        combox_manhanvien.Items.Clear()
        For Each row As DataRow In dt.Rows
            combox_manhanvien.Items.Add(row("Ma_nhan_vien").ToString())
        Next
    End Sub
    Public datatable As New DataTable()
    Public Sub laydulieu(cmd As String)
        Try
            moketnoi()
            datatable.Rows.Clear()
            Dim com As New SqlCommand(cmd, con)
            Dim da As New SqlDataAdapter(com)
            da.Fill(datatable)
            DGV_banhang.DataSource = datatable
        Catch ex As Exception
            If (MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error) = Windows.Forms.DialogResult.OK) Then
                Me.Close()
                Global.System.Windows.Forms.Application.Exit()
            End If
            dongketnoi()
        End Try
    End Sub

    Public status As String = ""
    Public Sub thucthi(cmd As String)
        moketnoi()
        Try
            Dim com As New SqlCommand(cmd, con)
            com.ExecuteNonQuery()
            status = "ok"
        Catch ex As Exception
            status = "no"
        End Try
        dongketnoi()
    End Sub


    Private Sub DGV_banhang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_banhang.CellClick
        Dim vitri As Integer = DGV_banhang.CurrentCell.RowIndex
        combox_makhachhang.Text = DGV_banhang.Rows(vitri).Cells(1).Value.ToString()
        combox_manhanvien.Text = DGV_banhang.Rows(vitri).Cells(2).Value.ToString()
        txt_ngayxuathoadon.Text = DGV_banhang.Rows(vitri).Cells(3).Value.ToString()
    End Sub
    Private Sub frm_quanlibanhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dockhachhang()
        Docnhanvien()
        laydulieu("select * from Bang_hoa_don")
    End Sub
    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click

        thucthi("insert into Bang_hoa_don(Ma_khach_hang,Ma_nhan_vien,Ngay_xuat_hoa_don) values('" & combox_makhachhang.Text & "','" & combox_manhanvien.Text & "','" & txt_ngayxuathoadon.Text & "')")
        laydulieu("select * from Bang_hoa_don")
        combox_makhachhang.Text = ""
        combox_manhanvien.Text = ""
        txt_ngayxuathoadon.Text = ""

    End Sub


    Private Sub btn_thoat_Click(sender As Object, e As EventArgs) Handles btn_thoat.Click
        frm_quanli.Show()
        Me.Close()
    End Sub

    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click
        Dim vitri As Integer = DGV_banhang.CurrentCell.RowIndex
        Dim id As Integer = Integer.Parse(DGV_banhang.Rows(vitri).Cells(0).Value.ToString())
        If MessageBox.Show("Bạn có chắc chắn muốn sửa không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            thucthi("update Bang_hoa_don set Ma_khach_hang= '" & combox_makhachhang.Text & "',Ma_nhan_vien= '" & combox_manhanvien.Text & "',Ngay_xuat_hoa_don = '" & txt_ngayxuathoadon.Text & "' where Ma_hoa_don ='" & id & "'")
            combox_makhachhang.Text = ""
            combox_manhanvien.Text = ""
            txt_ngayxuathoadon.Text = ""
        End If
        laydulieu("select * from Bang_hoa_don")
    End Sub

    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        Dim vitri As Integer = DGV_banhang.CurrentCell.RowIndex
        Dim id As Integer = Integer.Parse(DGV_banhang.Rows(vitri).Cells(0).Value.ToString())
        If MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            thucthi("delete from Bang_hoa_don where Ma_hoa_don ='" & id & "'")
            combox_makhachhang.Text = ""
            combox_manhanvien.Text = ""
            txt_ngayxuathoadon.Text = ""
        End If
        laydulieu("select * from Bang_hoa_don")
    End Sub
End Class