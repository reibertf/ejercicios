<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.txtpass4 = New System.Windows.Forms.TextBox()
        Me.txtuser1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmensaje = New System.Windows.Forms.Button()
        Me.txterror = New System.Windows.Forms.Label()
        Me.chkcheked = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.labexito = New System.Windows.Forms.Label()
        Me.labdetalle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtpass4
        '
        Me.txtpass4.Location = New System.Drawing.Point(83, 35)
        Me.txtpass4.Name = "txtpass4"
        Me.txtpass4.Size = New System.Drawing.Size(166, 20)
        Me.txtpass4.TabIndex = 13
        '
        'txtuser1
        '
        Me.txtuser1.Location = New System.Drawing.Point(83, 6)
        Me.txtuser1.Name = "txtuser1"
        Me.txtuser1.Size = New System.Drawing.Size(166, 20)
        Me.txtuser1.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "user"
        '
        'txtmensaje
        '
        Me.txtmensaje.Location = New System.Drawing.Point(106, 61)
        Me.txtmensaje.Name = "txtmensaje"
        Me.txtmensaje.Size = New System.Drawing.Size(75, 23)
        Me.txtmensaje.TabIndex = 7
        Me.txtmensaje.Text = "login"
        Me.txtmensaje.UseVisualStyleBackColor = True
        '
        'txterror
        '
        Me.txterror.AutoSize = True
        Me.txterror.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txterror.ForeColor = System.Drawing.Color.Red
        Me.txterror.Location = New System.Drawing.Point(5, 97)
        Me.txterror.Name = "txterror"
        Me.txterror.Size = New System.Drawing.Size(244, 20)
        Me.txterror.TabIndex = 14
        Me.txterror.Text = "usuario o contraseña incorrectos "
        Me.txterror.Visible = False
        '
        'chkcheked
        '
        Me.chkcheked.AutoSize = True
        Me.chkcheked.Location = New System.Drawing.Point(257, 41)
        Me.chkcheked.Name = "chkcheked"
        Me.chkcheked.Size = New System.Drawing.Size(15, 14)
        Me.chkcheked.TabIndex = 17
        Me.chkcheked.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(187, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "register"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'labexito
        '
        Me.labexito.AutoSize = True
        Me.labexito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labexito.ForeColor = System.Drawing.Color.Lime
        Me.labexito.Location = New System.Drawing.Point(5, 97)
        Me.labexito.Name = "labexito"
        Me.labexito.Size = New System.Drawing.Size(85, 20)
        Me.labexito.TabIndex = 19
        Me.labexito.Text = "bienvenido"
        Me.labexito.Visible = False
        '
        'labdetalle
        '
        Me.labdetalle.AutoSize = True
        Me.labdetalle.Location = New System.Drawing.Point(12, 102)
        Me.labdetalle.Name = "labdetalle"
        Me.labdetalle.Size = New System.Drawing.Size(204, 13)
        Me.labdetalle.TabIndex = 20
        Me.labdetalle.Text = "alguno de los campos se encuentra vacio"
        Me.labdetalle.Visible = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 150)
        Me.Controls.Add(Me.labdetalle)
        Me.Controls.Add(Me.labexito)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkcheked)
        Me.Controls.Add(Me.txterror)
        Me.Controls.Add(Me.txtpass4)
        Me.Controls.Add(Me.txtuser1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtmensaje)
        Me.Name = "Form5"
        Me.Text = "Realizar un login de usuario que permita el ingreso de Usuario y Contraseña."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpass4 As System.Windows.Forms.TextBox
    Friend WithEvents txtuser1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmensaje As System.Windows.Forms.Button
    Friend WithEvents txterror As System.Windows.Forms.Label
    Friend WithEvents chkcheked As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents labexito As System.Windows.Forms.Label
    Friend WithEvents labdetalle As System.Windows.Forms.Label
End Class
