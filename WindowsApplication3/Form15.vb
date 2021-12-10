Public Class Form15

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim Resultado As Integer
        Resultado = (Txtnum.Text())

        If (Txtnum.Text() <= 9) Then
            Lbresultado.Text = "El Número tiene 1 cifra"
        End If

        If (Txtnum.Text() < 0) Then
            Lbresultado.Text = "Por Favor Introduzca un número positivo"
        End If

        If (Txtnum.Text() >= 10) Then
            Lbresultado.Text = "El Número tiene 2 cifra"
        End If

        If (Txtnum.Text() >= 100) Then
            Lbresultado.Text = "El Número tiene 3 cifra"
        End If

        If (Txtnum.Text() >= 1000) Then
            Lbresultado.Text = "El Número tiene 4 cifra"
        End If

        If (Txtnum.Text() >= 10000) Then
            Lbresultado.Text = "El Número tiene 5 cifra"
        End If

        If (Txtnum.Text() >= 100000) Then
            Lbresultado.Text = "El Número tiene 6 cifra"
        End If

        If (Txtnum.Text() >= 1000000) Then
            Lbresultado.Text = "El Número tiene 7 cifra"
        End If

        If (Txtnum.Text() >= 10000000) Then
            Lbresultado.Text = "El Número tiene 8 cifra"
        End If

        If (Txtnum.Text() >= 100000000) Then
            Lbresultado.Text = "El Número tiene 9 cifra"
        End If

        If (Txtnum.Text() >= 1000000000) Then
            Lbresultado.Text = "El Número tiene 10 cifra"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        Lbresultado.Text = ""
        Txtnum.Text = ""
    End Sub

End Class