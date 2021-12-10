Public Class Form13

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        If txtcedula.Text <= 0 Then
            MsgBox("El valor ingresado no corresponde a una cedula")
        ElseIf txtcedula.Text >= 0 Then
            MsgBox("El valor ingresado es valido como cedula")
        End If
    End Sub
End Class