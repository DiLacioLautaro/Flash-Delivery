<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.btnLocal = New System.Windows.Forms.Button()
        Me.btnRepartidor = New System.Windows.Forms.Button()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Transparent
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(12, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(78, 34)
        Me.btnVolver.TabIndex = 65
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnLocal
        '
        Me.btnLocal.BackColor = System.Drawing.Color.Transparent
        Me.btnLocal.FlatAppearance.BorderSize = 0
        Me.btnLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLocal.Font = New System.Drawing.Font("Coolvetica Rg", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocal.ForeColor = System.Drawing.Color.White
        Me.btnLocal.Location = New System.Drawing.Point(66, 343)
        Me.btnLocal.Name = "btnLocal"
        Me.btnLocal.Size = New System.Drawing.Size(301, 63)
        Me.btnLocal.TabIndex = 64
        Me.btnLocal.Text = "Local"
        Me.btnLocal.UseVisualStyleBackColor = False
        '
        'btnRepartidor
        '
        Me.btnRepartidor.BackColor = System.Drawing.Color.Transparent
        Me.btnRepartidor.FlatAppearance.BorderSize = 0
        Me.btnRepartidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRepartidor.Font = New System.Drawing.Font("Coolvetica Rg", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepartidor.ForeColor = System.Drawing.Color.White
        Me.btnRepartidor.Location = New System.Drawing.Point(66, 236)
        Me.btnRepartidor.Name = "btnRepartidor"
        Me.btnRepartidor.Size = New System.Drawing.Size(301, 63)
        Me.btnRepartidor.TabIndex = 63
        Me.btnRepartidor.Text = "Repartidor"
        Me.btnRepartidor.UseVisualStyleBackColor = False
        '
        'btnUsuario
        '
        Me.btnUsuario.BackColor = System.Drawing.Color.Transparent
        Me.btnUsuario.FlatAppearance.BorderSize = 0
        Me.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuario.Font = New System.Drawing.Font("Coolvetica Rg", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuario.ForeColor = System.Drawing.Color.White
        Me.btnUsuario.Location = New System.Drawing.Point(69, 128)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(301, 65)
        Me.btnUsuario.TabIndex = 62
        Me.btnUsuario.Text = "Registrarse Como Usuario"
        Me.btnUsuario.UseVisualStyleBackColor = False
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FlashDelivery.My.Resources.Resources.Register
        Me.ClientSize = New System.Drawing.Size(413, 223)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnLocal)
        Me.Controls.Add(Me.btnRepartidor)
        Me.Controls.Add(Me.btnUsuario)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnLocal As System.Windows.Forms.Button
    Friend WithEvents btnRepartidor As System.Windows.Forms.Button
    Friend WithEvents btnUsuario As System.Windows.Forms.Button
End Class
