Public Class Form1
    Private Sub F22_Click(sender As Object, e As EventArgs) Handles F22.Click
        display.Image = PictureBox1.Image
        Label7.Text = "F-22"
        Label8.Text = "120M"
        Label9.Text = "16.68ft"
        Label10.Text = "1500mph"
        Label11.Text = "43,430 lbs"

    End Sub

    Private Sub F35_Click(sender As Object, e As EventArgs) Handles F35.Click
        display.Image = PictureBox2.Image
        Label7.Text = "F.35"
        Label8.Text = "$77.9 m"
        Label9.Text = "14ft"
        Label10.Text = "1,200 mph"
        Label11.Text = "34,830 lbs"
    End Sub

    Private Sub F14_Click(sender As Object, e As EventArgs) Handles F14.Click
        display.Image = PictureBox3.Image
        Label7.Text = "F-14"
        Label8.Text = "38 m"
        Label9.Text = "16 feet"
        Label10.Text = "1,544 mph"
        Label11.Text = "40,100 lbs"
    End Sub

    Private Sub T38_Click(sender As Object, e As EventArgs) Handles T38.Click
        display.Image = PictureBox4.Image
        Label7.Text = "T38"
        Label8.Text = "800,000."
        Label9.Text = "16ft"
        Label10.Text = "858 mph"
        Label11.Text = "7,165 lbs"
    End Sub

    Private Sub F5_Click(sender As Object, e As EventArgs) Handles F5.Click
        display.Image = PictureBox5.Image
        Label7.Text = "F5"
        Label8.Text = "2.1 million"
        Label9.Text = "13 feet"
        Label10.Text = "Mach 1.4,"
        Label11.Text = "7,733"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
