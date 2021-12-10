<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtpass1 = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpass2 = New System.Windows.Forms.TextBox()
        Me.labcon1 = New System.Windows.Forms.Label()
        Me.chkcheked = New System.Windows.Forms.CheckBox()
        Me.lbdetalle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(155, 151)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "register"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtpass1
        '
        Me.txtpass1.Location = New System.Drawing.Point(104, 57)
        Me.txtpass1.Name = "txtpass1"
        Me.txtpass1.Size = New System.Drawing.Size(148, 20)
        Me.txtpass1.TabIndex = 23
        Me.txtpass1.UseSystemPasswordChar = True
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(104, 29)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(148, 20)
        Me.txtuser.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "user"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "confirm password "
        '
        'txtpass2
        '
        Me.txtpass2.Location = New System.Drawing.Point(104, 88)
        Me.txtpass2.Name = "txtpass2"
        Me.txtpass2.Size = New System.Drawing.Size(148, 20)
        Me.txtpass2.TabIndex = 27
        Me.txtpass2.UseSystemPasswordChar = True
        '
        'labcon1
        '
        Me.labcon1.AutoSize = True
        Me.labcon1.Location = New System.Drawing.Point(96, 125)
        Me.labcon1.Name = "labcon1"
        Me.labcon1.Size = New System.Drawing.Size(145, 13)
        Me.labcon1.TabIndex = 28
        Me.labcon1.Text = "las contraseñas no coinciden"
        Me.labcon1.Visible = False
        '
        'chkcheked
        '
        Me.chkcheked.AutoSize = True
        Me.chkcheked.Location = New System.Drawing.Point(258, 94)
        Me.chkcheked.Name = "chkcheked"
        Me.chkcheked.Size = New System.Drawing.Size(15, 14)
        Me.chkcheked.TabIndex = 29
        Me.chkcheked.UseVisualStyleBackColor = True
        '
        'lbdetalle
        '
        Me.lbdetalle.AutoSize = True
        Me.lbdetalle.Location = New System.Drawing.Point(96, 125)
        Me.lbdetalle.Name = "lbdetalle"
        Me.lbdetalle.Size = New System.Drawing.Size(170, 13)
        Me.lbdetalle.TabIndex = 30
        Me.lbdetalle.Text = "algunos de los campos esta vacio "
        Me.lbdetalle.Visible = False
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lbdetalle)
        Me.Controls.Add(Me.chkcheked)
        Me.Controls.Add(Me.labcon1)
        Me.Controls.Add(Me.txtpass2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtpass1)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form9"
        Me.Text = "Form9"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtpass1 As System.Windows.Forms.TextBox
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtpass2 As System.Windows.Forms.TextBox
    Friend WithEvents labcon1 As System.Windows.Forms.Label
    Friend WithEvents chkcheked As System.Windows.Forms.CheckBox
    Friend WithEvents lbdetalle As System.Windows.Forms.Label
End Class
