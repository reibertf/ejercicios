Public Class Form18

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        If TxtPalabra.TextLength = 0 Then
            MessageBox.Show("Ingrese una palabra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtPalabra.Focus()

        Else
            cbxpalguardadas.Items.Add(TxtPalabra.Text)
            TxtPalabra.Clear()
            TxtPalabra.Focus()

        End If
    End Sub
End Class