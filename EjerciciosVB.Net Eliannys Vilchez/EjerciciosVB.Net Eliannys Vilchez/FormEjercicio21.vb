Public Class Formejercicio21

    Private Sub Boton_Click(sender As Object, e As EventArgs) Handles Boton.Click
        Farenheit.Text = Val(Centigrados.Text * 9 / 5) + 32

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class