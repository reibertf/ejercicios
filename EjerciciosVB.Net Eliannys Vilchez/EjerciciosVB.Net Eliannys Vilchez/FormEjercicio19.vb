﻿Public Class FormEjercicio19
    Public TextTexto As AccessibleObject



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_Palabra.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim NVocales As Integer
        NVocales = 0
       string palabra = String.Empty;
int vocales = 0;

palabra = txt_Palabra.Text.ToLower();

for (int i = 0; i < palabra.Length; i++)
{
    switch (palabra[i])
    {
        case 'a':
            vocales += 1;
            break;
        case 'e':
            vocales += 1;
            break;
        case 'i':
            vocales += 1;
            break;
        case 'o':
            vocales += 1;
            break;
        case 'u':
            vocales += 1;
            break;
    }
}
textBox2.Text = vocales.ToString();

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CantPalabras As Integer
        Dim Palabra As String

        Palabra = txt_Palabra.Text

        If Len(Trim(Palabra)) = 0 Then
            MsgBox("No has ingresado ninguna palabra")

            txt_Palabra.Focus()
        End If

        CantPalabras = 0
        For c = 1 To Len(Trim(Palabra))
            If Mid(Trim(Palabra), c, 1) = " " Then
                Len(Trim(Palabra))
                CantPalabras = CantPalabras
            End If
        Next

        txt_CantPalabras.Text = Len(Trim(Palabra))




    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles txt_CantPalabras.Click

    End Sub
End Class