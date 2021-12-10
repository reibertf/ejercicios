<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.cachapa = New System.Windows.Forms.Label()
        Me.arepa = New System.Windows.Forms.Label()
        Me.empanadas = New System.Windows.Forms.Label()
        Me.Picachapa = New System.Windows.Forms.PictureBox()
        Me.Picarepa = New System.Windows.Forms.PictureBox()
        Me.Picempanadas = New System.Windows.Forms.PictureBox()
        CType(Me.Picachapa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picarepa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picempanadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cachapa
        '
        Me.cachapa.AutoSize = True
        Me.cachapa.Location = New System.Drawing.Point(110, 24)
        Me.cachapa.Name = "cachapa"
        Me.cachapa.Size = New System.Drawing.Size(49, 13)
        Me.cachapa.TabIndex = 0
        Me.cachapa.Text = "cachapa"
        '
        'arepa
        '
        Me.arepa.AutoSize = True
        Me.arepa.Location = New System.Drawing.Point(125, 96)
        Me.arepa.Name = "arepa"
        Me.arepa.Size = New System.Drawing.Size(34, 13)
        Me.arepa.TabIndex = 1
        Me.arepa.Text = "arepa"
        '
        'empanadas
        '
        Me.empanadas.AutoSize = True
        Me.empanadas.Location = New System.Drawing.Point(110, 175)
        Me.empanadas.Name = "empanadas"
        Me.empanadas.Size = New System.Drawing.Size(62, 13)
        Me.empanadas.TabIndex = 2
        Me.empanadas.Text = "empanadas"
        '
        'Picachapa
        '
        Me.Picachapa.Image = CType(resources.GetObject("Picachapa.Image"), System.Drawing.Image)
        Me.Picachapa.Location = New System.Drawing.Point(91, 40)
        Me.Picachapa.Name = "Picachapa"
        Me.Picachapa.Size = New System.Drawing.Size(100, 50)
        Me.Picachapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picachapa.TabIndex = 3
        Me.Picachapa.TabStop = False
        '
        'Picarepa
        '
        Me.Picarepa.Image = CType(resources.GetObject("Picarepa.Image"), System.Drawing.Image)
        Me.Picarepa.Location = New System.Drawing.Point(91, 112)
        Me.Picarepa.Name = "Picarepa"
        Me.Picarepa.Size = New System.Drawing.Size(100, 50)
        Me.Picarepa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picarepa.TabIndex = 4
        Me.Picarepa.TabStop = False
        '
        'Picempanadas
        '
        Me.Picempanadas.Image = CType(resources.GetObject("Picempanadas.Image"), System.Drawing.Image)
        Me.Picempanadas.Location = New System.Drawing.Point(91, 191)
        Me.Picempanadas.Name = "Picempanadas"
        Me.Picempanadas.Size = New System.Drawing.Size(100, 50)
        Me.Picempanadas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picempanadas.TabIndex = 5
        Me.Picempanadas.TabStop = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Picempanadas)
        Me.Controls.Add(Me.Picarepa)
        Me.Controls.Add(Me.Picachapa)
        Me.Controls.Add(Me.empanadas)
        Me.Controls.Add(Me.arepa)
        Me.Controls.Add(Me.cachapa)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.Picachapa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picarepa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picempanadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cachapa As System.Windows.Forms.Label
    Friend WithEvents arepa As System.Windows.Forms.Label
    Friend WithEvents empanadas As System.Windows.Forms.Label
    Friend WithEvents Picachapa As System.Windows.Forms.PictureBox
    Friend WithEvents Picarepa As System.Windows.Forms.PictureBox
    Friend WithEvents Picempanadas As System.Windows.Forms.PictureBox
End Class
