<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formejercicio21
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
        Me.Farenheit = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Centigrados = New System.Windows.Forms.TextBox()
        Me.Boton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Farenheit
        '
        Me.Farenheit.AutoSize = True
        Me.Farenheit.Location = New System.Drawing.Point(137, 58)
        Me.Farenheit.Name = "Farenheit"
        Me.Farenheit.Size = New System.Drawing.Size(0, 13)
        Me.Farenheit.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Ingrese los Cº"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "El equivalente en Fº es:"
        '
        'Centigrados
        '
        Me.Centigrados.Location = New System.Drawing.Point(86, 23)
        Me.Centigrados.Name = "Centigrados"
        Me.Centigrados.Size = New System.Drawing.Size(100, 20)
        Me.Centigrados.TabIndex = 6
        '
        'Boton
        '
        Me.Boton.Location = New System.Drawing.Point(192, 21)
        Me.Boton.Name = "Boton"
        Me.Boton.Size = New System.Drawing.Size(75, 23)
        Me.Boton.TabIndex = 5
        Me.Boton.Text = "Convertir"
        Me.Boton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 88)
        Me.Controls.Add(Me.Farenheit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Centigrados)
        Me.Controls.Add(Me.Boton)
        Me.Name = "Form1"
        Me.Text = "Formejercicio22"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Farenheit As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Centigrados As System.Windows.Forms.TextBox
    Friend WithEvents Boton As System.Windows.Forms.Button
End Class
