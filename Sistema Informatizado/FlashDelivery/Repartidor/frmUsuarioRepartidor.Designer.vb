<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarioRepartidor
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
        Me.txtApe = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDirec = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.btnModificarRepartidor = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSeguirBuscando = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtApe
        '
        Me.txtApe.BackColor = System.Drawing.Color.White
        Me.txtApe.Enabled = False
        Me.txtApe.ForeColor = System.Drawing.Color.Black
        Me.txtApe.Location = New System.Drawing.Point(223, 100)
        Me.txtApe.Name = "txtApe"
        Me.txtApe.Size = New System.Drawing.Size(100, 20)
        Me.txtApe.TabIndex = 33
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.Enabled = False
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(117, 280)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(206, 20)
        Me.txtEmail.TabIndex = 32
        '
        'txtDirec
        '
        Me.txtDirec.BackColor = System.Drawing.Color.White
        Me.txtDirec.Enabled = False
        Me.txtDirec.ForeColor = System.Drawing.Color.Black
        Me.txtDirec.Location = New System.Drawing.Point(118, 220)
        Me.txtDirec.Name = "txtDirec"
        Me.txtDirec.Size = New System.Drawing.Size(159, 20)
        Me.txtDirec.TabIndex = 31
        '
        'txtTel
        '
        Me.txtTel.BackColor = System.Drawing.Color.White
        Me.txtTel.Enabled = False
        Me.txtTel.ForeColor = System.Drawing.Color.Black
        Me.txtTel.Location = New System.Drawing.Point(117, 160)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(160, 20)
        Me.txtTel.TabIndex = 30
        '
        'txtNom
        '
        Me.txtNom.BackColor = System.Drawing.Color.White
        Me.txtNom.Enabled = False
        Me.txtNom.ForeColor = System.Drawing.Color.Black
        Me.txtNom.Location = New System.Drawing.Point(118, 100)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 29
        '
        'btnModificarRepartidor
        '
        Me.btnModificarRepartidor.BackColor = System.Drawing.Color.Transparent
        Me.btnModificarRepartidor.FlatAppearance.BorderSize = 0
        Me.btnModificarRepartidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarRepartidor.Font = New System.Drawing.Font("Coolvetica Rg", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarRepartidor.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnModificarRepartidor.Location = New System.Drawing.Point(125, 367)
        Me.btnModificarRepartidor.Name = "btnModificarRepartidor"
        Me.btnModificarRepartidor.Size = New System.Drawing.Size(125, 50)
        Me.btnModificarRepartidor.TabIndex = 28
        Me.btnModificarRepartidor.Text = "Modificar"
        Me.btnModificarRepartidor.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Coolvetica Rg", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(31, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 22)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Direccion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Coolvetica Rg", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(31, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 22)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Coolvetica Rg", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 22)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Telefono"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Coolvetica Rg", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(31, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 22)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Nombre"
        '
        'btnSeguirBuscando
        '
        Me.btnSeguirBuscando.BackColor = System.Drawing.Color.Transparent
        Me.btnSeguirBuscando.FlatAppearance.BorderSize = 0
        Me.btnSeguirBuscando.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeguirBuscando.Font = New System.Drawing.Font("Coolvetica Rg", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeguirBuscando.ForeColor = System.Drawing.Color.White
        Me.btnSeguirBuscando.Location = New System.Drawing.Point(13, 13)
        Me.btnSeguirBuscando.Name = "btnSeguirBuscando"
        Me.btnSeguirBuscando.Size = New System.Drawing.Size(34, 36)
        Me.btnSeguirBuscando.TabIndex = 23
        Me.btnSeguirBuscando.Text = "<-"
        Me.btnSeguirBuscando.UseVisualStyleBackColor = False
        '
        'frmUsuarioRepartidor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FlashDelivery.My.Resources.Resources.UsuarioRepartidor
        Me.ClientSize = New System.Drawing.Size(363, 440)
        Me.Controls.Add(Me.txtApe)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtDirec)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.btnModificarRepartidor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSeguirBuscando)
        Me.Name = "frmUsuarioRepartidor"
        Me.Text = "frmUsuarioRepartidor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtApe As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtDirec As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents btnModificarRepartidor As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSeguirBuscando As System.Windows.Forms.Button
End Class
