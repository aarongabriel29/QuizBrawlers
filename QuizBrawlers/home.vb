Public Class home
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles boxHome.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles buttonPlay.Click
        Me.Hide()
        samplequestion1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles buttonAbout.Click
        Me.Hide()
        about.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub buttonHow2Play_Click(sender As Object, e As EventArgs) Handles buttonHow2Play.Click
        Me.Hide()
        how2play.Show()

    End Sub

    Private Sub buttonCredits_Click(sender As Object, e As EventArgs) Handles buttonCredits.Click
        Me.Hide()
        credits.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles buttonExit.Click
        Me.Close()
    End Sub
End Class
