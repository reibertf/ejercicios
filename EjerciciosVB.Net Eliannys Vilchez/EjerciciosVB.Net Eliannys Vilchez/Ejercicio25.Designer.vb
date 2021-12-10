<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio25
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblresultado = New System.Windows.Forms.Label()
        Me.Txtproducto = New System.Windows.Forms.TextBox()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingrese el precio del producto"
        '
        'lblresultado
        '
        Me.lblresultado.AutoSize = True
        Me.lblresultado.Location = New System.Drawing.Point(12, 142)
        Me.lblresultado.Name = "lblresultado"
        Me.lblresultado.Size = New System.Drawing.Size(133, 13)
        Me.lblresultado.TabIndex = 2
        Me.lblresultado.Text = "El IVA del producto es de: "
        '
        'Txtproducto
        '
        Me.Txtproducto.Location = New System.Drawing.Point(85, 59)
        Me.Txtproducto.Name = "Txtproducto"
        Me.Txtproducto.Size = New System.Drawing.Size(100, 20)
        Me.Txtproducto.TabIndex = 3
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(43, 85)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 4
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Borrar
        '
        Me.Borrar.Location = New System.Drawing.Point(156, 85)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(75, 23)
        Me.Borrar.TabIndex = 5
        Me.Borrar.Text = "Borrar"
        Me.Borrar.UseVisualStyleBackColor = True
        '
        'Ejercicio25
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 191)
        Me.Controls.Add(Me.Borrar)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.Txtproducto)
        Me.Controls.Add(Me.lblresultado)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Ejercicio25"
        Me.Text = "Ejercicio25"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblresultado As System.Windows.Forms.Label
    Friend WithEvents Txtproducto As System.Windows.Forms.TextBox
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Borrar As System.Windows.Forms.Button
End Class
