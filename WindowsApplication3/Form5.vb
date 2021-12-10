Public Class Form5

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form9.Show()

    End Sub

    Private Sub txtmensaje_Click(sender As Object, e As EventArgs) Handles txtmensaje.Click
        If txtuser1.Text = My.Settings.user And txtpass4.Text = My.Settings.password Then

            labexito.Visible = True
            labexito.Text = "bienvenido " & My.Settings.user
            txterror.Visible = False
            labdetalle.Visible = False

        ElseIf txtuser1.Text = "" Then
            labdetalle.Visible = True
            labexito.Text = ""
            txterror.Visible = False

        ElseIf txtpass4.Text = "" Then
            labdetalle.Visible = True
            labexito.Text = ""
            txterror.Visible = False
        Else
            txterror.Visible = True
            labexito.Text = ""
            labdetalle.Visible = False


        End If

    End Sub

    Private Sub chkcheked_CheckedChanged(sender As Object, e As EventArgs) Handles chkcheked.CheckedChanged

        If chkcheked.Checked Then
            txtpass4.UseSystemPasswordChar = True

        Else
            txtpass4.UseSystemPasswordChar = False
        End If

    End Sub
End Class