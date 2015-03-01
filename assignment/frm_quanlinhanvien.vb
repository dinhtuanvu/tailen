Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frm_quanlinhanvien
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
    Public datatable As New DataTable()
    Public Sub laydulieu(cmd As String)
        Try
            moketnoi()
            datatable.Rows.Clear()
            Dim com As New SqlCommand(cmd, con)
            Dim da As New SqlDataAdapter(com)
            da.Fill(datatable)
            DGV_quanlinhanvien.DataSource = datatable
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
    Private Sub frm_quanlinhanvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        laydulieu("select * from Bang_nhan_vien")
    End Sub

    Private Sub DGV_quanlinhanvien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_quanlinhanvien.CellClick
        Dim vitri As Integer
        vitri = DGV_quanlinhanvien.CurrentCell.RowIndex
        txt_tennhanvien.Text = DGV_quanlinhanvien.Rows(vitri).Cells(1).Value.ToString
        txt_diachi.Text = DGV_quanlinhanvien.Rows(vitri).Cells(2).Value.ToString
        txt_gioitinh.Text = DGV_quanlinhanvien.Rows(vitri).Cells(3).Value.ToString
        txt_ngaysinh.Text = DGV_quanlinhanvien.Rows(vitri).Cells(4).Value.ToString
        txt_sodienthoai.Text = DGV_quanlinhanvien.Rows(vitri).Cells(5).Value.ToString
    End Sub

    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        thucthi("insert into Bang_nhan_vien(Ten_nhan_vien,Dia_chi,Gioi_tinh,Ngay_sinh,So_dien_thoai) values('" & txt_tennhanvien.Text & "','" & txt_diachi.Text & "','" & txt_gioitinh.Text & "','" & txt_ngaysinh.Text & "','" & txt_sodienthoai.Text & "')")
        laydulieu("select * from Bang_nhan_vien")
        txt_tennhanvien.Text = ""
        txt_diachi.Text = ""
        txt_gioitinh.Text = ""
        txt_ngaysinh.Text = ""
        txt_sodienthoai.Text = ""
    End Sub

    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click
        Dim vitri As Integer = DGV_quanlinhanvien.CurrentCell.RowIndex
        Dim id As Integer = Integer.Parse(DGV_quanlinhanvien.Rows(vitri).Cells(0).Value.ToString())
        If MessageBox.Show("Bạn có chắc chắn muốn sửa không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            thucthi("update Bang_nhan_vien set Ten_nhan_vien= '" & txt_tennhanvien.Text & "',Dia_chi= '" & txt_diachi.Text & "',Gioi_tinh= '" & txt_gioitinh.Text & "',Ngay_sinh= '" & txt_ngaysinh.Text & "',So_dien_thoai= '" & txt_sodienthoai.Text & "' where Ma_nhan_vien ='" & id & "'")
        End If
        laydulieu("select * from Bang_nhan_vien")
    End Sub

    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        Dim vitri As Integer = DGV_quanlinhanvien.CurrentCell.RowIndex
        Dim id As Integer = Integer.Parse(DGV_quanlinhanvien.Rows(vitri).Cells(0).Value.ToString())
        If MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            thucthi("delete from Bang_nhan_vien where Ma_nhan_vien ='" & id & "'")
        End If
        laydulieu("select * from Bang_nhan_vien")
    End Sub

    Private Sub btn_thoat_Click(sender As Object, e As EventArgs) Handles btn_thoat.Click
        frm_quanli.Show()
        Me.Close()
    End Sub
End Class
