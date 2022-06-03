<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegisterCliente
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
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.gbxDatosUsuario = New System.Windows.Forms.GroupBox()
        Me.lblPassword2 = New System.Windows.Forms.Label()
        Me.txtPass2 = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gbxDatosPersonales = New System.Windows.Forms.GroupBox()
        Me.cbxZona = New System.Windows.Forms.ComboBox()
        Me.lblZona = New System.Windows.Forms.Label()
        Me.dtpFnac = New System.Windows.Forms.DateTimePicker()
        Me.lblFNac = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.lblTipoDoc = New System.Windows.Forms.Label()
        Me.cbxTipo = New System.Windows.Forms.ComboBox()
        Me.lblDocumento = New System.Windows.Forms.Label()
        Me.txtDoc = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblDatosPersonales = New System.Windows.Forms.Label()
        Me.gbxDatosUsuario.SuspendLayout()
        Me.gbxDatosPersonales.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Transparent
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Coolvetica Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(324, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(99, 35)
        Me.btnVolver.TabIndex = 65
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistrar.FlatAppearance.BorderSize = 0
        Me.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrar.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.Location = New System.Drawing.Point(71, 579)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(301, 35)
        Me.btnRegistrar.TabIndex = 64
        Me.btnRegistrar.Text = "Registrarme"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'gbxDatosUsuario
        '
        Me.gbxDatosUsuario.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatosUsuario.Controls.Add(Me.lblPassword2)
        Me.gbxDatosUsuario.Controls.Add(Me.txtPass2)
        Me.gbxDatosUsuario.Controls.Add(Me.lblPassword)
        Me.gbxDatosUsuario.Controls.Add(Me.txtPass)
        Me.gbxDatosUsuario.Controls.Add(Me.lblNombreUsuario)
        Me.gbxDatosUsuario.Controls.Add(Me.txtUser)
        Me.gbxDatosUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatosUsuario.Location = New System.Drawing.Point(12, 439)
        Me.gbxDatosUsuario.Name = "gbxDatosUsuario"
        Me.gbxDatosUsuario.Size = New System.Drawing.Size(408, 134)
        Me.gbxDatosUsuario.TabIndex = 63
        Me.gbxDatosUsuario.TabStop = False
        '
        'lblPassword2
        '
        Me.lblPassword2.AutoSize = True
        Me.lblPassword2.Font = New System.Drawing.Font("Coolvetica Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblPassword2.Location = New System.Drawing.Point(38, 96)
        Me.lblPassword2.Name = "lblPassword2"
        Me.lblPassword2.Size = New System.Drawing.Size(128, 18)
        Me.lblPassword2.TabIndex = 20
        Me.lblPassword2.Text = "Repita Contraseña"
        '
        'txtPass2
        '
        Me.txtPass2.BackColor = System.Drawing.Color.White
        Me.txtPass2.Location = New System.Drawing.Point(170, 95)
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.Size = New System.Drawing.Size(190, 21)
        Me.txtPass2.TabIndex = 19
        Me.txtPass2.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Coolvetica Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(82, 58)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(82, 18)
        Me.lblPassword.TabIndex = 18
        Me.lblPassword.Text = "Contraseña"
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.White
        Me.txtPass.Location = New System.Drawing.Point(170, 57)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(190, 21)
        Me.txtPass.TabIndex = 17
        Me.txtPass.UseSystemPasswordChar = True
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = True
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Coolvetica Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblNombreUsuario.Location = New System.Drawing.Point(38, 26)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(128, 18)
        Me.lblNombreUsuario.TabIndex = 16
        Me.lblNombreUsuario.Text = "Nombre De Usuario"
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.White
        Me.txtUser.Location = New System.Drawing.Point(170, 23)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(190, 21)
        Me.txtUser.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label10.Location = New System.Drawing.Point(12, 418)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(147, 22)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Datos de Usuario"
        '
        'gbxDatosPersonales
        '
        Me.gbxDatosPersonales.BackColor = System.Drawing.Color.Transparent
        Me.gbxDatosPersonales.Controls.Add(Me.cbxZona)
        Me.gbxDatosPersonales.Controls.Add(Me.lblZona)
        Me.gbxDatosPersonales.Controls.Add(Me.dtpFnac)
        Me.gbxDatosPersonales.Controls.Add(Me.lblFNac)
        Me.gbxDatosPersonales.Controls.Add(Me.lblCorreo)
        Me.gbxDatosPersonales.Controls.Add(Me.txtEmail)
        Me.gbxDatosPersonales.Controls.Add(Me.lblTelefono)
        Me.gbxDatosPersonales.Controls.Add(Me.txtTel)
        Me.gbxDatosPersonales.Controls.Add(Me.lblTipoDoc)
        Me.gbxDatosPersonales.Controls.Add(Me.cbxTipo)
        Me.gbxDatosPersonales.Controls.Add(Me.lblDocumento)
        Me.gbxDatosPersonales.Controls.Add(Me.txtDoc)
        Me.gbxDatosPersonales.Controls.Add(Me.lblDireccion)
        Me.gbxDatosPersonales.Controls.Add(Me.txtDireccion)
        Me.gbxDatosPersonales.Controls.Add(Me.lblApellido)
        Me.gbxDatosPersonales.Controls.Add(Me.lbNombre)
        Me.gbxDatosPersonales.Controls.Add(Me.txtApellido)
        Me.gbxDatosPersonales.Controls.Add(Me.txtNombre)
        Me.gbxDatosPersonales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatosPersonales.Location = New System.Drawing.Point(12, 74)
        Me.gbxDatosPersonales.Name = "gbxDatosPersonales"
        Me.gbxDatosPersonales.Size = New System.Drawing.Size(408, 330)
        Me.gbxDatosPersonales.TabIndex = 61
        Me.gbxDatosPersonales.TabStop = False
        '
        'cbxZona
        '
        Me.cbxZona.FormattingEnabled = True
        Me.cbxZona.Location = New System.Drawing.Point(170, 292)
        Me.cbxZona.Name = "cbxZona"
        Me.cbxZona.Size = New System.Drawing.Size(190, 24)
        Me.cbxZona.TabIndex = 29
        '
        'lblZona
        '
        Me.lblZona.AutoSize = True
        Me.lblZona.Font = New System.Drawing.Font("Coolvetica Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZona.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblZona.Location = New System.Drawing.Point(117, 293)
        Me.lblZona.Name = "lblZona"
        Me.lblZona.Size = New System.Drawing.Size(39, 18)
        Me.lblZona.TabIndex = 28
        Me.lblZona.Text = "Zona"
        '
        'dtpFnac
        '
        Me.dtpFnac.Location = New System.Drawing.Point(170, 257)
        Me.dtpFnac.Name = "dtpFnac"
        Me.dtpFnac.Size = New System.Drawing.Size(190, 22)
        Me.dtpFnac.TabIndex = 27
        Me.dtpFnac.Value = New Date(2020, 9, 27, 0, 0, 0, 0)
        '
        'lblFNac
        '
        Me.lblFNac.AutoSize = True
        Me.lblFNac.Font = New System.Drawing.Font("Coolvetica Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFNac.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblFNac.Location = New System.Drawing.Point(21, 260)
        Me.lblFNac.Name = "lblFNac"
        Me.lblFNac.Size = New System.Drawing.Size(140, 18)
        Me.lblFNac.TabIndex = 26
        Me.lblFNac.Text = "Fecha de Nacimiento"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Coolvetica Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblCorreo.Location = New System.Drawing.Point(38, 219)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(127, 18)
        Me.lblCorreo.TabIndex = 25
        Me.lblCorreo.Text = "Correo Electronico"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.Location = New System.Drawing.Point(170, 218)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(190, 22)
        Me.txtEmail.TabIndex = 24
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Coolvetica Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblTelefono.Location = New System.Drawing.Point(99, 182)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(60, 18)
        Me.lblTelefono.TabIndex = 23
        Me.lblTelefono.Text = "Telefono"
        '
        'txtTel
        '
        Me.txtTel.BackColor = System.Drawing.Color.White
        Me.txtTel.Location = New System.Drawing.Point(170, 179)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(190, 22)
        Me.txtTel.TabIndex = 22
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.AutoSize = True
        Me.lblTipoDoc.Font = New System.Drawing.Font("Coolvetica Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoDoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblTipoDoc.Location = New System.Drawing.Point(312, 123)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(35, 18)
        Me.lblTipoDoc.TabIndex = 21
        Me.lblTipoDoc.Text = "Tipo"
        '
        'cbxTipo
        '
        Me.cbxTipo.FormattingEnabled = True
        Me.cbxTipo.Items.AddRange(New Object() {"Pasaporte", "DNI"})
        Me.cbxTipo.Location = New System.Drawing.Point(312, 141)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(88, 24)
        Me.cbxTipo.TabIndex = 20
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.Font = New System.Drawing.Font("Coolvetica Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblDocumento.Location = New System.Drawing.Point(46, 142)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(115, 18)
        Me.lblDocumento.TabIndex = 19
        Me.lblDocumento.Text = "Num. Documento"
        '
        'txtDoc
        '
        Me.txtDoc.BackColor = System.Drawing.Color.White
        Me.txtDoc.Location = New System.Drawing.Point(170, 141)
        Me.txtDoc.Name = "txtDoc"
        Me.txtDoc.Size = New System.Drawing.Size(136, 22)
        Me.txtDoc.TabIndex = 18
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Coolvetica Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblDireccion.Location = New System.Drawing.Point(91, 99)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(66, 18)
        Me.lblDireccion.TabIndex = 17
        Me.lblDireccion.Text = "Direccion"
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.White
        Me.txtDireccion.Location = New System.Drawing.Point(170, 98)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(190, 22)
        Me.txtDireccion.TabIndex = 16
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Coolvetica Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lblApellido.Location = New System.Drawing.Point(99, 60)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(59, 18)
        Me.lblApellido.TabIndex = 15
        Me.lblApellido.Text = "Apellido"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Font = New System.Drawing.Font("Coolvetica Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lbNombre.Location = New System.Drawing.Point(99, 22)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(57, 18)
        Me.lbNombre.TabIndex = 14
        Me.lbNombre.Text = "Nombre"
        '
        'txtApellido
        '
        Me.txtApellido.BackColor = System.Drawing.Color.White
        Me.txtApellido.Location = New System.Drawing.Point(170, 59)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(190, 22)
        Me.txtApellido.TabIndex = 13
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(170, 21)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(190, 22)
        Me.txtNombre.TabIndex = 12
        '
        'lblDatosPersonales
        '
        Me.lblDatosPersonales.AutoSize = True
        Me.lblDatosPersonales.BackColor = System.Drawing.Color.Transparent
        Me.lblDatosPersonales.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatosPersonales.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblDatosPersonales.Location = New System.Drawing.Point(12, 53)
        Me.lblDatosPersonales.Name = "lblDatosPersonales"
        Me.lblDatosPersonales.Size = New System.Drawing.Size(151, 22)
        Me.lblDatosPersonales.TabIndex = 60
        Me.lblDatosPersonales.Text = "Datos Personales"
        '
        'frmRegisterCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FlashDelivery.My.Resources.Resources.RegistrarCliente1
        Me.ClientSize = New System.Drawing.Size(435, 626)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.gbxDatosUsuario)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.gbxDatosPersonales)
        Me.Controls.Add(Me.lblDatosPersonales)
        Me.Name = "frmRegisterCliente"
        Me.Text = "frmRegisterCliente"
        Me.gbxDatosUsuario.ResumeLayout(False)
        Me.gbxDatosUsuario.PerformLayout()
        Me.gbxDatosPersonales.ResumeLayout(False)
        Me.gbxDatosPersonales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents gbxDatosUsuario As System.Windows.Forms.GroupBox
    Friend WithEvents lblPassword2 As System.Windows.Forms.Label
    Friend WithEvents txtPass2 As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gbxDatosPersonales As System.Windows.Forms.GroupBox
    Friend WithEvents cbxZona As System.Windows.Forms.ComboBox
    Friend WithEvents lblZona As System.Windows.Forms.Label
    Friend WithEvents dtpFnac As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFNac As System.Windows.Forms.Label
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents lblTipoDoc As System.Windows.Forms.Label
    Friend WithEvents cbxTipo As System.Windows.Forms.ComboBox
    Friend WithEvents lblDocumento As System.Windows.Forms.Label
    Friend WithEvents txtDoc As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lbNombre As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblDatosPersonales As System.Windows.Forms.Label
End Class
