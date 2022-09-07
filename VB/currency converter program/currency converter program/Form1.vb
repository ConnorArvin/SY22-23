Public Class Form1

    Private Sub Yenbutton_Click(sender As Object, e As EventArgs) Handles Yenbutton.Click
        Dim Dollars As Decimal
        Decimal.TryParse(inputTextBox.Text, Dollars)

        Dim Yen As Decimal
        Yen = Dollars * 137.24
        outputTextBox.Text = Yen.ToString("n2")
        PictureBox3.Image = Japaneseyen.Image
        PictureBox1.Image = PictureBox5.Image


    End Sub

    Private Sub Poundbutton_Click(sender As Object, e As EventArgs) Handles Poundbutton.Click
        Dim Dollars As Decimal
        Decimal.TryParse(inputTextbox.Text, Dollars)

        Dim Pound As Decimal
        Pound = Dollars * 0.85
        outputTextBox.Text = Pound.ToString("n2")
        PictureBox3.Image = Britishpound.Image
        PictureBox1.Image = PictureBox5.Image
    End Sub

    Private Sub CanadianDollarbutton_Click(sender As Object, e As EventArgs) Handles CanadianDollarbutton.Click
        Dim Dollars As Decimal
        Decimal.TryParse(inputTextbox.Text, Dollars)

        Dim Canadian As Decimal
        Canadian = Dollars * 1.3
        PictureBox3.Image = CanadianDollarbutton.Image
        PictureBox1.Image = PictureBox5.Image
        outputTextBox.Text = Canadian.ToString("n2")

    End Sub

    Private Sub Eurobutton_Click(sender As Object, e As EventArgs) Handles Eurobutton.Click
        Dim Dollars As Decimal
        Decimal.TryParse(inputTextbox.Text, Dollars)

        Dim Euro As Decimal
        Euro = Dollars * 1
        PictureBox3.Image = Germaneuro.Image
        PictureBox1.Image = PictureBox5.Image
        outputTextBox.Text = Euro.ToString("n2")

    End Sub

    Private Sub Rupeebutton_Click(sender As Object, e As EventArgs) Handles Rupeebutton.Click
        Dim Dollars As Decimal
        Decimal.TryParse(inputTextbox.Text, Dollars)

        Dim Rupee As Decimal
        Rupee = Dollars * 79.82
        PictureBox3.Image = Rupeebutton.Image
        PictureBox1.Image = PictureBox5.Image
        outputTextBox.Text = Rupee.ToString("n2")

    End Sub

    Private Sub Bitcoinbutton_Click(sender As Object, e As EventArgs) Handles Bitcoinbutton.Click
        Dim Dollars As Decimal
        Decimal.TryParse(inputTextbox.Text, Dollars)

        Dim Bitcoin As Decimal
        Bitcoin = Dollars * 0.000047
        PictureBox3.Image = Bitcoinbutton.Image
        PictureBox1.Image = PictureBox5.Image
        outputTextBox.Text = Bitcoin.ToString("n2")


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
