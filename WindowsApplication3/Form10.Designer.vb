<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Me.cbvehiculo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbcontrato = New System.Windows.Forms.Label()
        Me.lbcosto = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btncalculo = New System.Windows.Forms.Button()
        Me.dtsalida = New System.Windows.Forms.DateTimePicker()
        Me.dtentrada = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbdescuento = New System.Windows.Forms.Label()
        Me.lbdesc2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtmulta = New System.Windows.Forms.DateTimePicker()
        Me.lbmulta = New System.Windows.Forms.Label()
        Me.lbmult2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbvehiculo
        '
        Me.cbvehiculo.FormattingEnabled = True
        Me.cbvehiculo.Items.AddRange(New Object() {"auto", "camioneta"})
        Me.cbvehiculo.Location = New System.Drawing.Point(12, 30)
        Me.cbvehiculo.Name = "cbvehiculo"
        Me.cbvehiculo.Size = New System.Drawing.Size(135, 21)
        Me.cbvehiculo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "selecione un vehiculo"
        '
        'lbcontrato
        '
        Me.lbcontrato.AutoSize = True
        Me.lbcontrato.Location = New System.Drawing.Point(9, 160)
        Me.lbcontrato.Name = "lbcontrato"
        Me.lbcontrato.Size = New System.Drawing.Size(101, 13)
        Me.lbcontrato.TabIndex = 3
        Me.lbcontrato.Text = "el contrato sera por:"
        '
        'lbcosto
        '
        Me.lbcosto.AutoSize = True
        Me.lbcosto.Location = New System.Drawing.Point(12, 188)
        Me.lbcosto.Name = "lbcosto"
        Me.lbcosto.Size = New System.Drawing.Size(102, 13)
        Me.lbcosto.TabIndex = 4
        Me.lbcosto.Text = "el costo total es de: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "fecha de salida del vehiculo"
        '
        'btncalculo
        '
        Me.btncalculo.Location = New System.Drawing.Point(12, 291)
        Me.btncalculo.Name = "btncalculo"
        Me.btncalculo.Size = New System.Drawing.Size(75, 23)
        Me.btncalculo.TabIndex = 6
        Me.btncalculo.Text = "calcular"
        Me.btncalculo.UseVisualStyleBackColor = True
        '
        'dtsalida
        '
        Me.dtsalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtsalida.Location = New System.Drawing.Point(12, 81)
        Me.dtsalida.Name = "dtsalida"
        Me.dtsalida.Size = New System.Drawing.Size(119, 20)
        Me.dtsalida.TabIndex = 7
        '
        'dtentrada
        '
        Me.dtentrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtentrada.Location = New System.Drawing.Point(12, 137)
        Me.dtentrada.Name = "dtentrada"
        Me.dtentrada.Size = New System.Drawing.Size(119, 20)
        Me.dtentrada.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "fecha de entrada del vehiculo"
        '
        'lbdescuento
        '
        Me.lbdescuento.AutoSize = True
        Me.lbdescuento.Location = New System.Drawing.Point(12, 217)
        Me.lbdescuento.Name = "lbdescuento"
        Me.lbdescuento.Size = New System.Drawing.Size(106, 13)
        Me.lbdescuento.TabIndex = 10
        Me.lbdescuento.Text = "su descuento es de: "
        Me.lbdescuento.Visible = False
        '
        'lbdesc2
        '
        Me.lbdesc2.AutoSize = True
        Me.lbdesc2.Location = New System.Drawing.Point(16, 246)
        Me.lbdesc2.Name = "lbdesc2"
        Me.lbdesc2.Size = New System.Drawing.Size(117, 13)
        Me.lbdesc2.TabIndex = 11
        Me.lbdesc2.Text = "aplicando el descuento"
        Me.lbdesc2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(204, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "informar retraso de entrega"
        '
        'dtmulta
        '
        Me.dtmulta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmulta.Location = New System.Drawing.Point(207, 137)
        Me.dtmulta.Name = "dtmulta"
        Me.dtmulta.Size = New System.Drawing.Size(119, 20)
        Me.dtmulta.TabIndex = 13
        '
        'lbmulta
        '
        Me.lbmulta.AutoSize = True
        Me.lbmulta.Location = New System.Drawing.Point(204, 171)
        Me.lbmulta.Name = "lbmulta"
        Me.lbmulta.Size = New System.Drawing.Size(91, 13)
        Me.lbmulta.TabIndex = 14
        Me.lbmulta.Text = "multa por retraso: "
        Me.lbmulta.Visible = False
        '
        'lbmult2
        '
        Me.lbmult2.AutoSize = True
        Me.lbmult2.Location = New System.Drawing.Point(204, 188)
        Me.lbmult2.Name = "lbmult2"
        Me.lbmult2.Size = New System.Drawing.Size(91, 13)
        Me.lbmult2.TabIndex = 15
        Me.lbmult2.Text = "multa por retraso: "
        Me.lbmult2.Visible = False
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 326)
        Me.Controls.Add(Me.lbmult2)
        Me.Controls.Add(Me.lbmulta)
        Me.Controls.Add(Me.dtmulta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbdesc2)
        Me.Controls.Add(Me.lbdescuento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtentrada)
        Me.Controls.Add(Me.dtsalida)
        Me.Controls.Add(Me.btncalculo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbcosto)
        Me.Controls.Add(Me.lbcontrato)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbvehiculo)
        Me.Name = "Form10"
        Me.Text = "Form10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbvehiculo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbcontrato As System.Windows.Forms.Label
    Friend WithEvents lbcosto As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btncalculo As System.Windows.Forms.Button
    Friend WithEvents dtsalida As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtentrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbdescuento As System.Windows.Forms.Label
    Friend WithEvents lbdesc2 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtmulta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbmulta As System.Windows.Forms.Label
    Friend WithEvents lbmult2 As System.Windows.Forms.Label
End Class
