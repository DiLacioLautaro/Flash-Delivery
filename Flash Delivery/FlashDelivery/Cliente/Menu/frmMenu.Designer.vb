<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnVerPed = New System.Windows.Forms.Button()
        Me.grbPed = New System.Windows.Forms.GroupBox()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblLocal = New System.Windows.Forms.Label()
        Me.btnRealizarPed = New System.Windows.Forms.Button()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblZona = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grbPed.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUser
        '
        Me.btnUser.BackColor = System.Drawing.Color.Transparent
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.Black
        Me.btnUser.Location = New System.Drawing.Point(25, 450)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(144, 54)
        Me.btnUser.TabIndex = 14
        Me.btnUser.Text = "Ajustes de usuario"
        Me.btnUser.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.Location = New System.Drawing.Point(310, 456)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(148, 42)
        Me.btnLogout.TabIndex = 15
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnVerPed
        '
        Me.btnVerPed.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVerPed.FlatAppearance.BorderSize = 0
        Me.btnVerPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerPed.Font = New System.Drawing.Font("Coolvetica Rg", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerPed.ForeColor = System.Drawing.Color.White
        Me.btnVerPed.Location = New System.Drawing.Point(45, 171)
        Me.btnVerPed.Name = "btnVerPed"
        Me.btnVerPed.Size = New System.Drawing.Size(357, 47)
        Me.btnVerPed.TabIndex = 50
        Me.btnVerPed.Text = "Mas informacion"
        Me.btnVerPed.UseVisualStyleBackColor = False
        '
        'grbPed
        '
        Me.grbPed.BackColor = System.Drawing.Color.Transparent
        Me.grbPed.Controls.Add(Me.lblHora)
        Me.grbPed.Controls.Add(Me.lblLocal)
        Me.grbPed.Controls.Add(Me.btnVerPed)
        Me.grbPed.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.grbPed.Enabled = False
        Me.grbPed.Font = New System.Drawing.Font("Coolvetica Rg", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbPed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grbPed.Location = New System.Drawing.Point(28, 177)
        Me.grbPed.Name = "grbPed"
        Me.grbPed.Size = New System.Drawing.Size(426, 229)
        Me.grbPed.TabIndex = 51
        Me.grbPed.TabStop = False
        Me.grbPed.Text = "Pedido En Curso!"
        Me.grbPed.Visible = False
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Coolvetica Rg", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.lblHora.Location = New System.Drawing.Point(15, 112)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(63, 29)
        Me.lblHora.TabIndex = 54
        Me.lblHora.Text = "Hora:"
        '
        'lblLocal
        '
        Me.lblLocal.AutoSize = True
        Me.lblLocal.Font = New System.Drawing.Font("Coolvetica Rg", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.lblLocal.Location = New System.Drawing.Point(15, 32)
        Me.lblLocal.Name = "lblLocal"
        Me.lblLocal.Size = New System.Drawing.Size(69, 29)
        Me.lblLocal.TabIndex = 55
        Me.lblLocal.Text = "Local:"
        '
        'btnRealizarPed
        '
        Me.btnRealizarPed.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRealizarPed.FlatAppearance.BorderSize = 0
        Me.btnRealizarPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRealizarPed.Font = New System.Drawing.Font("Coolvetica Rg", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRealizarPed.ForeColor = System.Drawing.Color.White
        Me.btnRealizarPed.Location = New System.Drawing.Point(21, 54)
        Me.btnRealizarPed.Name = "btnRealizarPed"
        Me.btnRealizarPed.Size = New System.Drawing.Size(433, 78)
        Me.btnRealizarPed.TabIndex = 56
        Me.btnRealizarPed.Text = "Realizar Pedido"
        Me.btnRealizarPed.UseVisualStyleBackColor = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Coolvetica Rg", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblUser.Location = New System.Drawing.Point(127, 9)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(28, 32)
        Me.lblUser.TabIndex = 58
        Me.lblUser.Text = "x"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Coolvetica Rg", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(19, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 32)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Usuario:"
        '
        'lblZona
        '
        Me.lblZona.AutoSize = True
        Me.lblZona.BackColor = System.Drawing.Color.Transparent
        Me.lblZona.Font = New System.Drawing.Font("Coolvetica Rg", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZona.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblZona.Location = New System.Drawing.Point(357, 9)
        Me.lblZona.Name = "lblZona"
        Me.lblZona.Size = New System.Drawing.Size(28, 32)
        Me.lblZona.TabIndex = 60
        Me.lblZona.Text = "x"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Coolvetica Rg", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(278, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 32)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Zona:"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = Global.FlashDelivery.My.Resources.Resources.Menu_principal1
        Me.ClientSize = New System.Drawing.Size(478, 533)
        Me.Controls.Add(Me.lblZona)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRealizarPed)
        Me.Controls.Add(Me.grbPed)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnUser)
        Me.Name = "frmMenu"
        Me.Text = "Menu Principal"
        Me.grbPed.ResumeLayout(False)
        Me.grbPed.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUser As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnVerPed As System.Windows.Forms.Button
    Friend WithEvents grbPed As System.Windows.Forms.GroupBox
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents lblLocal As System.Windows.Forms.Label
    Friend WithEvents btnRealizarPed As System.Windows.Forms.Button
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblZona As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
