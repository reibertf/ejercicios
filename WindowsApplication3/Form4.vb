Public Class Form4

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Format(DateAndTime.TimeOfDay, "hh") & ":"
        Label2.Text = Format(DateAndTime.TimeOfDay, "mm")
        Label3.Text = Format(DateAndTime.TimeOfDay, "ss")

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Val(Label1.Text) > 12 Then
            Label4.Text = "am"
        Else
            Label4.Text = "pm"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form6.Show(Me)

    End Sub
End Class