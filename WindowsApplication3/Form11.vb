Public Class Form11

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim far As Double
        Dim celsius As Double

        far = txtfaren.Text

        celsius = 5 / 9 * (far - 32)
        celsius = Math.Round(celsius, 1)
        Label3.Text = "el resultado es: " & celsius & "C°"
    End Sub
End Class