Public Class Form4
    Private Sub registerbtn_Click(sender As Object, e As EventArgs) Handles registerbtn.Click
        Me.Hide()
        Dim f2 As New Form2()
        f2.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles view2.Click
        Me.Hide()
        Dim f2 As New Form3()
        f2.ShowDialog()
    End Sub

    Private Sub exit1_Click(sender As Object, e As EventArgs) Handles exit1.Click
        Application.Exit()
    End Sub
End Class