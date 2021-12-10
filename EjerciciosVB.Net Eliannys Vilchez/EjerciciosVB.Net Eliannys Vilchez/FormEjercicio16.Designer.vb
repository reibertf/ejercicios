<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEjercicio16
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
        Me.cbxpais = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxestado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbxpais
        '
        Me.cbxpais.FormattingEnabled = True
        Me.cbxpais.Items.AddRange(New Object() {"Chile", "Venezuela"})
        Me.cbxpais.Location = New System.Drawing.Point(12, 77)
        Me.cbxpais.Name = "cbxpais"
        Me.cbxpais.Size = New System.Drawing.Size(128, 21)
        Me.cbxpais.Sorted = True
        Me.cbxpais.TabIndex = 0
        Me.cbxpais.Text = "Seleccione"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "País"
        '
        'cbxestado
        '
        Me.cbxestado.FormattingEnabled = True
        Me.cbxestado.Location = New System.Drawing.Point(163, 77)
        Me.cbxestado.Name = "cbxestado"
        Me.cbxestado.Size = New System.Drawing.Size(274, 21)
        Me.cbxestado.Sorted = True
        Me.cbxestado.TabIndex = 2
        Me.cbxestado.Text = "Seleccione"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(163, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Estado y Ciudad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(312, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 5
        '
        'FormEjercicio16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 261)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbxestado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxpais)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormEjercicio16"
        Me.Text = "FormEjercicio17"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxpais As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxestado As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
