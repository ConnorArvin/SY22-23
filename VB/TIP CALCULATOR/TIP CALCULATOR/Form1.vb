Public Class TipCalculator
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles calcButton.Click


        Dim total As Decimal
        Decimal.TryParse(totalTextBox.Text, total)




        If RadioButton1.Checked Then
            Tiptextbox.Text = total * 0.05
        End If
        If RadioButton2.Checked Then
            Tiptextbox.Text = total * 0.1
        End If
        If RadioButton3.Checked Then
            Tiptextbox.Text = total * 0.2
        End If
    End Sub
End Class
