Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frm_quanlisanpham
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
    Private Sub Docsanpham()
        moketnoi()
        Dim com As New SqlCommand("select * from Bang_loai_san_pham", con)
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable()
        da.Fill(dt)
        dongketnoi()
        combox_maloaisanpham.Items.Clear()
        For Each row As DataRow In dt.Rows
            'muon lay truong nao day ?
            combox_maloaisanpham.Items.Add(row("Ma_loai_san_pham").ToString())

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
            DGV_quanlisanpham.DataSource = datatable
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
    Private Sub frm_quanlisanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Docsanpham()
        laydulieu("select * from Bang_san_pham ")
    End Sub

    Private Sub DGV_quanlisanpham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_quanlisanpham.CellClick
        Dim vitri As Integer = DGV_quanlisanpham.CurrentCell.RowIndex
        combox_maloaisanpham.Text = DGV_quanlisanpham.Rows(vitri).Cells(1).Value.ToString()
        txt_tensanpham.Text = DGV_quanlisanpham.Rows(vitri).Cells(2).Value.ToString()
        txt_chitietsanpham.Text = DGV_quanlisanpham.Rows(vitri).Cells(3).Value.ToString()

    End Sub

    Private Sub btn_themloaisanpham_Click(sender As Object, e As EventArgs) Handles btn_themloaisanpham.Click
        frm_loaisanpham.Show()
    End Sub


    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        thucthi("insert into Bang_san_pham(Ten_san_pham,Chi_tiet,Ma_loai_san_pham) values('" & txt_tensanpham.Text & "','" & txt_chitietsanpham.Text & "','" & combox_maloaisanpham.Text & "')")
        txt_tenloaisanpham.Text = ""
        txt_tensanpham.Text = ""
        combox_maloaisanpham.Text = ""
        txt_chitietsanpham.Text = ""

        laydulieu("select * from Bang_san_pham")
    End Sub

    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click
        Dim vitri As Integer = DGV_quanlisanpham.CurrentCell.RowIndex
        Dim id As Integer = Integer.Parse(DGV_quanlisanpham.Rows(vitri).Cells(0).Value.ToString())
        If MessageBox.Show("Bạn có chắc chắn muốn sửa không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            thucthi("update Bang_san_pham set Ten_san_pham = '" & txt_tensanpham.Text & "',Chi_tiet = '" & txt_chitietsanpham.Text & "',Ma_loai_san_pham = '" & combox_maloaisanpham.Text & "' where Ma_san_pham ='" & id & "'")
            txt_tenloaisanpham.Text = ""
            txt_tensanpham.Text = ""
            combox_maloaisanpham.Text = ""
            txt_chitietsanpham.Text = ""
        End If
        laydulieu("select * from Bang_san_pham")
    End Sub

    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        Dim vitri As Integer = DGV_quanlisanpham.CurrentCell.RowIndex
        Dim id As Integer = Integer.Parse(DGV_quanlisanpham.Rows(vitri).Cells(0).Value.ToString())
        If MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            thucthi("delete from Bang_san_pham where Ma_san_pham ='" & id & "'")
            txt_tenloaisanpham.Text = ""
            txt_tensanpham.Text = ""
            combox_maloaisanpham.Text = ""
            txt_chitietsanpham.Text = ""

        End If
        laydulieu("select * from Bang_san_pham")
    End Sub

    Private Sub btn_thoat_Click(sender As Object, e As EventArgs) Handles btn_thoat.Click
        frm_quanli.Show()
        Me.Close()
    End Sub
End Class