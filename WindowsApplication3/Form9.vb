Public Class Form9

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim testString As String = txtuser.Text
        Dim testLen As Integer = Len(testString)

        If txtpass1.Text = txtpass2.Text Then
            My.Settings.user = txtuser.Text
            My.Settings.Save()
            My.Settings.Reload()

            My.Settings.password = txtpass1.Text
            My.Settings.Save()
            My.Settings.Reload()
            labcon1.Text = "usuario registrado"

        ElseIf txtuser.Text = "" Then
            lbdetalle.Visible = True
            labcon1.Visible = False

        ElseIf txtpass1.Text = "" Then
            lbdetalle.Visible = True
            labcon1.Visible = False

        ElseIf txtpass2.Text = "" Then
            lbdetalle.Visible = True
            labcon1.Visible = False
        Else
            labcon1.Visible = True
       
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkcheked.CheckedChanged
        If chkcheked.Checked Then
            txtpass1.UseSystemPasswordChar = True
            txtpass2.UseSystemPasswordChar = True
        Else
            txtpass1.UseSystemPasswordChar = False
            txtpass2.UseSystemPasswordChar = False
        End If
    End Sub
End Class