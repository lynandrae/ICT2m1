Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Hide()
        While (Panel1.Height < 489)
            Panel1.Height += 1
        End While
        Label2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Hide()
        While (Panel1.Height > 19)
            Panel1.Height -= 1
        End While
        Label1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form2 As New Form2()
        form2.Show() ' Show Form2
        Me.Hide() ' Hide the current Form1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
