Public Class Form2

    Private Sub calcular_Click(sender As Object, e As EventArgs) Handles calcular.Click
        Dim b As Integer
        Dim h As Integer
        Dim a As Double
        b = Val(Me.txtbase.Text)
        h = Val(Me.txtaltura.Text)
        a = (b * h) / 2
        Me.txtarea.Text = a

    End Sub

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        Me.txtaltura.Text = ""
        Me.txtarea.Text = ""
        Me.txtbase.Text = ""
    End Sub
End Class