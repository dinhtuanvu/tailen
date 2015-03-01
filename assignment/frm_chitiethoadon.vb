Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frm_chitiethoadon
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
        Dim com As New SqlCommand("select * from Bang_san_pham", con)
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable()
        da.Fill(dt)
        dongketnoi()
        combox_sanpham.Items.Clear()
        For Each row As DataRow In dt.Rows
            combox_sanpham.Items.Add(row("Ma_san_pham").ToString())
        Next
    End Sub
    Private Sub Dochoadon()
        moketnoi()
        Dim com As New SqlCommand("select * from Bang_hoa_don", con)
        Dim da As New SqlDataAdapter(com)
        Dim dt As New DataTable()
        da.Fill(dt)
        dongketnoi()
        combox_mashoadon.Items.Clear()
        For Each row As DataRow In dt.Rows
            combox_mashoadon.Items.Add(row("Ma_hoa_don").ToString())
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
            DGV_chitiethoadon.DataSource = datatable
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
    Private Sub frm_chitiethoadon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dochoadon()
        Docsanpham()
        laydulieu("select * from Bang_chi_tiet_hoa_don")
    End Sub

    Private Sub btn_them_Click(sender As Object, e As EventArgs) Handles btn_them.Click
        thucthi("insert into Bang_chi_tiet_hoa_don(Ma_hoa_don,Ma_san_pham,Gia,So_luong,Thanh_tien) values('" & combox_mashoadon.Text & "','" & combox_sanpham.Text & "','" & txt_gia.Text & "','" & txt_soluong.Text & "','" & txt_thanhtien.Text & "')")
        laydulieu("select * from Bang_chi_tiet_hoa_don")
        combox_mashoadon.Text = ""
        combox_sanpham.Text = ""
        txt_gia.Text = ""
        txt_thanhtien.Text = ""

    End Sub

    
    Private Sub DGV_chitiethoadon_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_chitiethoadon.CellClick
        Dim vitri As Integer = DGV_chitiethoadon.CurrentCell.RowIndex
        combox_mashoadon.Text = DGV_chitiethoadon.Rows(vitri).Cells(1).Value.ToString()
        combox_sanpham.Text = DGV_chitiethoadon.Rows(vitri).Cells(2).Value.ToString()
        txt_gia.Text = DGV_chitiethoadon.Rows(vitri).Cells(3).Value.ToString()
        txt_soluong.Text = DGV_chitiethoadon.Rows(vitri).Cells(4).Value.ToString()
        txt_thanhtien.Text = DGV_chitiethoadon.Rows(vitri).Cells(5).Value.ToString()
    End Sub

    Private Sub txt_soluong_TextChanged(sender As Object, e As EventArgs) Handles txt_soluong.TextChanged
        Dim thanhtien As Integer
        If txt_soluong.Text = "" Then
            MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            thanhtien = Integer.Parse(txt_gia.Text) * txt_soluong.Text
            txt_thanhtien.Text = thanhtien
        End If
    End Sub

    Private Sub btn_sua_Click(sender As Object, e As EventArgs) Handles btn_sua.Click
        Dim vitri As Integer = DGV_chitiethoadon.CurrentCell.RowIndex
        Dim id As Integer = Integer.Parse(DGV_chitiethoadon.Rows(vitri).Cells(0).Value.ToString())
        If MessageBox.Show("Bạn có chắc chắn muốn sửa không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            thucthi("update Bang_chi_tiet_hoa_don set Ma_hoa_don= '" & combox_mashoadon.Text & "',Ma_san_pham= '" & combox_sanpham.Text & "',Gia = '" & txt_gia.Text & "',So_luong= '" & txt_soluong.Text & "',Thanh_tien= '" & txt_thanhtien.Text & "' where Ma_chi_tiet_hoa_don ='" & id & "'")
        End If
        laydulieu("select * from Bang_chi_tiet_hoa_don")
        combox_mashoadon.Text = ""
        combox_sanpham.Text = ""
        txt_gia.Text = ""
        txt_thanhtien.Text = ""
    End Sub

    Private Sub btn_xoa_Click(sender As Object, e As EventArgs) Handles btn_xoa.Click
        Dim vitri As Integer = DGV_chitiethoadon.CurrentCell.RowIndex
        Dim id As Integer = Integer.Parse(DGV_chitiethoadon.Rows(vitri).Cells(0).Value.ToString())
        If MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            thucthi("delete from Bang_chi_tiet_hoa_don where Ma_chi_tiet_hoa_don ='" & id & "'")
            combox_mashoadon.Text = ""
            combox_sanpham.Text = ""
            txt_gia.Text = ""
            txt_thanhtien.Text = ""
        End If
        laydulieu("select * from Bang_chi_tiet_hoa_don")
    End Sub

    Private Sub btn_thoat_Click(sender As Object, e As EventArgs) Handles btn_thoat.Click
        frm_quanli.Show()
        Me.Close()
    End Sub
End Class