Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frm_loaisanpham
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
            DGV_quanliloaisanpham.DataSource = datatable
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
    Private Sub frm_loaisanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        laydulieu("select * from Bang_loai_san_pham")
    End Sub

    Private Sub DGV_quanliloaisanpham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_quanliloaisanpham.CellClick
        Dim vitri As Integer = DGV_quanliloaisanpham.CurrentCell.RowIndex
        txt_tenloaisanpham.Text = DGV_quanliloaisanpham.Rows(vitri).Cells(1).Value.ToString()
        txt_mota.Text = DGV_quanliloaisanpham.Rows(vitri).Cells(2).Value.ToString()
    End Sub

    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        thucthi("insert into Bang_loai_san_pham(Ten_loai_san_pham,Mo_ta) values('" & txt_tenloaisanpham.Text & "','" & txt_mota.Text & "')")
        txt_tenloaisanpham.Text = ""
        txt_mota.Text = ""
        laydulieu("select * from Bang_loai_san_pham")
    End Sub

    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click
        Dim vitri As Integer = DGV_quanliloaisanpham.CurrentCell.RowIndex
        Dim id As Integer = Integer.Parse(DGV_quanliloaisanpham.Rows(vitri).Cells(0).Value.ToString())
        If MessageBox.Show("Bạn có chắc chắn muốn sửa không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            thucthi("update Bang_loai_san_pham set Ten_loai_san_pham = '" & txt_tenloaisanpham.Text & "',Mo_ta = '" & txt_mota.Text & "' where Ma_loai_san_pham ='" & id & "'")
            txt_tenloaisanpham.Text = ""
            txt_mota.Text = ""
        End If
        laydulieu("select * from Bang_loai_san_pham")
    End Sub

    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        Dim vitri As Integer = DGV_quanliloaisanpham.CurrentCell.RowIndex
        Dim id As Integer = Integer.Parse(DGV_quanliloaisanpham.Rows(vitri).Cells(0).Value.ToString())
        If MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            thucthi("delete from Bang_loai_san_pham where Ma_loai_san_pham ='" & id & "'")
            txt_tenloaisanpham.Text = ""
            txt_mota.Text = ""
        End If
        laydulieu("select * from Bang_loai_san_pham")
    End Sub
End Class