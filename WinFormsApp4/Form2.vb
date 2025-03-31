Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Hide()
        While (Panel1.Width < 816)
            Panel1.Width += 1
        End While
        Button4.Show()
        Panel3.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.Hide()
        While (Panel1.Width > 190)
            Panel1.Width -= 1
        End While
        Button1.Show()
    End Sub

    Private Sub btnoneway_Click(sender As Object, e As EventArgs) Handles btnoneway.Click
        pnloneway.Visible = True

        Panel3.Visible = False
    End Sub

    Private Sub btnround_Click(sender As Object, e As EventArgs) Handles btnround.Click

        pnloneway.Visible = False
        Panel3.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("You have confirmed your reservation. Thankyou for trusting LOMILO Airline")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("You have confirmed your reservation. Thankyou for trusting LOMILO Airline")
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class