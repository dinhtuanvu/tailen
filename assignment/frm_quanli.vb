Public Class frm_quanli

    Private Sub btn_quanlikhachhang_Click(sender As Object, e As EventArgs) Handles btn_quanlikhachhang.Click
        frm_quanlikhachhang.ShowDialog()

    End Sub

    Private Sub btn_quanlinhanvien_Click(sender As Object, e As EventArgs) Handles btn_quanlinhanvien.Click
        frm_quanlinhanvien.ShowDialog()

    End Sub

    Private Sub btn_quanlibanhang_Click(sender As Object, e As EventArgs) Handles btn_quanlibanhang.Click
        frm_hoadon.ShowDialog()

    End Sub

    Private Sub btn_quanlihanghoa_Click(sender As Object, e As EventArgs) Handles btn_quanlihanghoa.Click
        frm_quanlisanpham.ShowDialog()

    End Sub

    Private Sub btn_quanlichitiethoadon_Click(sender As Object, e As EventArgs) Handles btn_quanlichitiethoadon.Click
        frm_chitiethoadon.ShowDialog()
    End Sub

    
End Class