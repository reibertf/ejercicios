﻿Public Class Form7

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim año As Date = CDate(Me.txtaño.Value)
        Dim edad As Date = CDate(Me.txtactual.Value)
        

        Me.txtedad.Text = "tienes " & CStr(edad.Year - año.Year) & " años"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtaño.Text = ""


    End Sub
End Class