﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.calcular = New System.Windows.Forms.Button()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbase = New System.Windows.Forms.TextBox()
        Me.txtarea = New System.Windows.Forms.TextBox()
        Me.txtaltura = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'calcular
        '
        Me.calcular.Location = New System.Drawing.Point(12, 150)
        Me.calcular.Name = "calcular"
        Me.calcular.Size = New System.Drawing.Size(75, 23)
        Me.calcular.TabIndex = 0
        Me.calcular.Text = "calcular"
        Me.calcular.UseVisualStyleBackColor = True
        '
        'limpiar
        '
        Me.limpiar.Location = New System.Drawing.Point(114, 150)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(75, 23)
        Me.limpiar.TabIndex = 1
        Me.limpiar.Text = "limpiar"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ingresa la base"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ingresa la altura"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "el area es:"
        '
        'txtbase
        '
        Me.txtbase.Location = New System.Drawing.Point(123, 9)
        Me.txtbase.Name = "txtbase"
        Me.txtbase.Size = New System.Drawing.Size(100, 20)
        Me.txtbase.TabIndex = 5
        '
        'txtarea
        '
        Me.txtarea.Location = New System.Drawing.Point(123, 64)
        Me.txtarea.Name = "txtarea"
        Me.txtarea.Size = New System.Drawing.Size(100, 20)
        Me.txtarea.TabIndex = 6
        '
        'txtaltura
        '
        Me.txtaltura.Location = New System.Drawing.Point(123, 35)
        Me.txtaltura.Name = "txtaltura"
        Me.txtaltura.Size = New System.Drawing.Size(100, 20)
        Me.txtaltura.TabIndex = 7
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtaltura)
        Me.Controls.Add(Me.txtarea)
        Me.Controls.Add(Me.txtbase)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.calcular)
        Me.Name = "Form2"
        Me.Text = "calcular el area de un triangulo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calcular As System.Windows.Forms.Button
    Friend WithEvents limpiar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtbase As System.Windows.Forms.TextBox
    Friend WithEvents txtarea As System.Windows.Forms.TextBox
    Friend WithEvents txtaltura As System.Windows.Forms.TextBox
End Class
