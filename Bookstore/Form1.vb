Public Class Form1
    Private Sub btn_infobook_Click(sender As Object, e As EventArgs) Handles btn_infobook.Click
        bookinform.Show()
    End Sub

    Private Sub btn_borrow_Click(sender As Object, e As EventArgs) Handles btn_borrow.Click
        borrowform.Show()
    End Sub

    Private Sub btn_member_Click(sender As Object, e As EventArgs) Handles btn_member.Click
        memberform.Show()
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        returnfrom.Show()
    End Sub

    Private Sub btnShowBill_Click(sender As Object, e As EventArgs) Handles btnShowBill.Click
        ShowBill.Show()
    End Sub
End Class
