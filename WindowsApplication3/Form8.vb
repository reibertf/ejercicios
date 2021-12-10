Public Class Form8
    Dim operacion As String
    Dim resultado As Nullable(Of Double) = Nothing
    Dim valor As Nullable(Of Double) = Nothing
    Dim accion As Boolean

    Private Sub Button1w7_Click(sender As Object, e As EventArgs) Handles Button1w7.Click
        concatenar()
        txtresultado.Text &= "0"
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        concatenar()
        txtresultado.Text &= "8"
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        concatenar()
        txtresultado.Text &= "9"
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        concatenar()
        txtresultado.Text &= "4"
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        concatenar()
        txtresultado.Text &= "5"
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        concatenar()
        txtresultado.Text &= "6"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        concatenar()
        txtresultado.Text &= "2"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        concatenar()
        txtresultado.Text &= "1"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        concatenar()
        txtresultado.Text &= "3"
    End Sub
    Private Sub BMultiplicacion_Click(sender As Object, e As EventArgs) Handles BMultiplicacion.Click
        evaluaOperacion()
        operacion = "*"
    End Sub
    Private Sub BDivision_Click(sender As Object, e As EventArgs) Handles BDivision.Click
        evaluaOperacion()
        operacion = "/"
    End Sub
    Private Sub BBorrar_Click(sender As Object, e As EventArgs) Handles BBorrar.Click
        txtresultado.Text = "0"
        resultado = Nothing
        valor = Nothing
    End Sub
    Private Sub BIgual_Click(sender As Object, e As EventArgs) Handles BIgual.Click
        evaluaOperacion()
        operacion = ""
    End Sub
    Private Sub BSuma_Click(sender As Object, e As EventArgs) Handles BSuma.Click
        evaluaOperacion()
        operacion = "+"
    End Sub
    Private Sub BResta_Click(sender As Object, e As EventArgs) Handles BResta.Click
        evaluaOperacion()
        operacion = "-"
    End Sub
    Private Sub BPunto_Click(sender As Object, e As EventArgs) Handles BPunto.Click
        concatenar()
        If InStr(txtresultado.Text, ".", CompareMethod.Text) = 0 Then
            txtresultado.Text &= "."
        End If

    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        concatenar()
        txtresultado.Text &= "7"
    End Sub
    Public Sub evaluaOperacion()
        accion = True
        valor = Val(txtresultado.Text)
        If resultado IsNot Nothing Then
            Select Case operacion
                Case "+"
                    resultado += valor
                Case "-"
                    resultado -= valor
                Case "*"
                    resultado *= valor
                Case "/"
                    resultado /= valor
            End Select
            txtresultado.Text = resultado
        Else
            resultado = valor
        End If
    End Sub
    Public Sub concatenar()
        If accion = True Then
            txtresultado.Text = ""
            accion = False
        ElseIf txtresultado.Text = "0" Then
            txtresultado.Text = ""
        End If
    End Sub
End Class