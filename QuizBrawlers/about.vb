Public Class about
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub aboutButtonPrev_Click(sender As Object, e As EventArgs) Handles aboutButtonPrev.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class