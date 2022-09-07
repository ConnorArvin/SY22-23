Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ammount As Decimal
        Decimal.TryParse(Buy.Text, ammount)

        FeeTextbox.Text = ammount * 0.03
        FeeTextbox.Text = fee.tostring("C2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Buy.Click
        Dim ammount As Decimal
        Decimal.TryParse()
    End Sub
End Class
