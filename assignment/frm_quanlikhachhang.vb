Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frm_quanlikhachhang
    Dim con As New SqlConnection("workstation id=vudtpk00391.mssql.somee.com;packet size=4096;user id=vudtpk00391_SQLLogin_1;pwd=9nf6cloxxa;data source=vudtpk00391.mssql.somee.com;persist security info=False;initial catalog=vudtpk00391")

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
    Public datatable As New DataTable()
    Public Sub laydulieu(cmd As String)
        Try
            moketnoi()
            datatable.Rows.Clear()
            Dim com As New SqlCommand(cmd, con)
            Dim da As New SqlDataAdapter(com)
            da.Fill(datatable)
            DGV_quanlikhachhang.DataSource = datatable
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

    Private Sub DGV_quanlikhachhang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_quanlikhachhang.CellClick
        Dim vitri As Integer
        vitri = DGV_quanlikhachhang.CurrentCell.RowIndex
        txt_tenkhachhang.Text = DGV_quanlikhachhang.Rows(vitri).Cells(1).Value.ToString
        txt_gioitinh.Text = DGV_quanlikhachhang.Rows(vitri).Cells(2).Value.ToString
        txt_diachi.Text = DGV_quanlikhachhang.Rows(vitri).Cells(3).Value.ToString
        txt_sodienthoai.Text = DGV_quanlikhachhang.Rows(vitri).Cells(4).Value.ToString
    End Sub

    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        thucthi("insert into Bang_khach_hang(Ten_khach_hang,Gioi_tinh,Dia_chi,So_dien_thoai) values('" & txt_tenkhachhang.Text & "','" & txt_gioitinh.Text & "','" & txt_diachi.Text & "','" & txt_sodienthoai.Text & "')")
        laydulieu("select * from Bang_khach_hang")
        txt_tenkhachhang.Text = ""
        txt_gioitinh.Text = ""
        txt_diachi.Text = ""
        txt_sodienthoai.Text = ""
    End Sub

    Private Sub frm_quanlikhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        laydulieu("select * from Bang_khach_hang")
        txt_tenkhachhang.Text = ""
        txt_gioitinh.Text = ""
        txt_diachi.Text = ""
        txt_sodienthoai.Text = ""
    End Sub

    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click
        Dim vitri As Integer = DGV_quanlikhachhang.CurrentCell.RowIndex
        Dim id As Integer = Integer.Parse(DGV_quanlikhachhang.Rows(vitri).Cells(0).Value.ToString())
        If MessageBox.Show("Bạn có chắc chắn muốn sửa không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            thucthi("update Bang_khach_hang set Ten_khach_hang= '" & txt_tenkhachhang.Text & "',Gioi_tinh= '" & txt_gioitinh.Text & "',Dia_chi= '" & txt_diachi.Text & "',So_dien_thoai= '" & txt_sodienthoai.Text & "' where Ma_khach_hang ='" & id & "'")
            txt_tenkhachhang.Text = ""
            txt_gioitinh.Text = ""
            txt_diachi.Text = ""
            txt_sodienthoai.Text = ""
        End If
        laydulieu("select * from Bang_khach_hang")
    End Sub

    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        Dim vitri As Integer = DGV_quanlikhachhang.CurrentCell.RowIndex
        Dim id As Integer = Integer.Parse(DGV_quanlikhachhang.Rows(vitri).Cells(0).Value.ToString())
        If MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            thucthi("delete from Bang_khach_hang where Ma_khach_hang ='" & id & "'")
            txt_tenkhachhang.Text = ""
            txt_gioitinh.Text = ""
            txt_diachi.Text = ""
            txt_sodienthoai.Text = ""
        End If
        laydulieu("select * from Bang_khach_hang")
    End Sub

    Private Sub btn_thoat_Click(sender As Object, e As EventArgs) Handles btn_thoat.Click
        frm_quanli.Show()
        Me.Close()
    End Sub
End Class