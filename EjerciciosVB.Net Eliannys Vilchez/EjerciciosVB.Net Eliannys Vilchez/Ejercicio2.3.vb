﻿Public Class ejercicio23

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click

        
    End Sub
    Private Function numero() As Short
        Throw New NotImplementedException


    End Function

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        
    End Sub

    Private Sub Ejercicio2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Ejercicio25_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Ejercicio25_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Resultado As Integer
        Resultado = (Txtnum.Text())

        If (Txtnum.Text() <= 9) Then
            Labresult.Text = "El Número tiene 1 cifra"
        End If

        If (Txtnum.Text() < 0) Then
            Labresult.Text = "Por Favor Introduzca un número positivo"
        End If

        If (Txtnum.Text() >= 10) Then
            Labresult.Text = "El Número tiene 2 cifra"
        End If

        If (Txtnum.Text() >= 100) Then
            Labresult.Text = "El Número tiene 3 cifra"
        End If

        If (Txtnum.Text() >= 1000) Then
            Labresult.Text = "El Número tiene 4 cifra"
        End If

        If (Txtnum.Text() >= 10000) Then
            Labresult.Text = "El Número tiene 5 cifra"
        End If

        If (Txtnum.Text() >= 100000) Then
            Labresult.Text = "El Número tiene 6 cifra"
        End If

        If (Txtnum.Text() >= 1000000) Then
            Labresult.Text = "El Número tiene 7 cifra"
        End If

        If (Txtnum.Text() >= 10000000) Then
            Labresult.Text = "El Número tiene 8 cifra"
        End If

        If (Txtnum.Text() >= 100000000) Then
            Labresult.Text = "El Número tiene 9 cifra"
        End If

        If (Txtnum.Text() >= 1000000000) Then
            Labresult.Text = "El Número tiene 10 cifra"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Labresult.Text = String.Empty
        Txtnum.Text = String.Empty
    End Sub
End Class