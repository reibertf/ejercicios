﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form18
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.cbxpalguardadas = New System.Windows.Forms.ComboBox()
        Me.TxtPalabra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Guardar
        '
        Me.Guardar.Location = New System.Drawing.Point(30, 147)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(75, 23)
        Me.Guardar.TabIndex = 7
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'cbxpalguardadas
        '
        Me.cbxpalguardadas.FormattingEnabled = True
        Me.cbxpalguardadas.Location = New System.Drawing.Point(125, 147)
        Me.cbxpalguardadas.Name = "cbxpalguardadas"
        Me.cbxpalguardadas.Size = New System.Drawing.Size(141, 21)
        Me.cbxpalguardadas.TabIndex = 6
        '
        'TxtPalabra
        '
        Me.TxtPalabra.Location = New System.Drawing.Point(125, 92)
        Me.TxtPalabra.Name = "TxtPalabra"
        Me.TxtPalabra.Size = New System.Drawing.Size(141, 20)
        Me.TxtPalabra.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Ingrese una palabra"
        '
        'Form18
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.cbxpalguardadas)
        Me.Controls.Add(Me.TxtPalabra)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form18"
        Me.Text = "Form18"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents cbxpalguardadas As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPalabra As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
