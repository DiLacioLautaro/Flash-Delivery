<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMVehiculoRegistrado
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
        Me.txtBuscarVehiculos = New System.Windows.Forms.TextBox()
        Me.dgvVehiculos = New System.Windows.Forms.DataGridView()
        Me.btnRegMod = New System.Windows.Forms.Button()
        Me.cbxBuscarPor = New System.Windows.Forms.ComboBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCodVeh = New System.Windows.Forms.Label()
        CType(Me.dgvVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Transparent
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Coolvetica Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(15, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(78, 34)
        Me.btnVolver.TabIndex = 88
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'txtBuscarVehiculos
        '
        Me.txtBuscarVehiculos.BackColor = System.Drawing.Color.White
        Me.txtBuscarVehiculos.Location = New System.Drawing.Point(263, 36)
        Me.txtBuscarVehiculos.Name = "txtBuscarVehiculos"
        Me.txtBuscarVehiculos.Size = New System.Drawing.Size(195, 20)
        Me.txtBuscarVehiculos.TabIndex = 89
        '
        'dgvVehiculos
        '
        Me.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVehiculos.Location = New System.Drawing.Point(12, 61)
        Me.dgvVehiculos.Name = "dgvVehiculos"
        Me.dgvVehiculos.Size = New System.Drawing.Size(446, 159)
        Me.dgvVehiculos.TabIndex = 85
        '
        'btnRegMod
        '
        Me.btnRegMod.BackColor = System.Drawing.Color.Transparent
        Me.btnRegMod.FlatAppearance.BorderSize = 0
        Me.btnRegMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegMod.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegMod.ForeColor = System.Drawing.Color.Black
        Me.btnRegMod.Location = New System.Drawing.Point(152, 264)
        Me.btnRegMod.Name = "btnRegMod"
        Me.btnRegMod.Size = New System.Drawing.Size(170, 34)
        Me.btnRegMod.TabIndex = 84
        Me.btnRegMod.Text = "Borrar"
        Me.btnRegMod.UseVisualStyleBackColor = False
        '
        'cbxBuscarPor
        '
        Me.cbxBuscarPor.FormattingEnabled = True
        Me.cbxBuscarPor.Items.AddRange(New Object() {"codVR", "codR", "tipo", "marca", "modelo"})
        Me.cbxBuscarPor.Location = New System.Drawing.Point(162, 36)
        Me.cbxBuscarPor.Name = "cbxBuscarPor"
        Me.cbxBuscarPor.Size = New System.Drawing.Size(95, 21)
        Me.cbxBuscarPor.TabIndex = 90
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Font = New System.Drawing.Font("Coolvetica Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.ForeColor = System.Drawing.Color.Black
        Me.lbNombre.Location = New System.Drawing.Point(159, 15)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(83, 18)
        Me.lbNombre.TabIndex = 91
        Me.lbNombre.Text = "Buscar Por..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Coolvetica Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 18)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Codigo Vehiculo Seleccionado:"
        '
        'lblCodVeh
        '
        Me.lblCodVeh.AutoSize = True
        Me.lblCodVeh.Font = New System.Drawing.Font("Coolvetica Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodVeh.ForeColor = System.Drawing.Color.Red
        Me.lblCodVeh.Location = New System.Drawing.Point(216, 234)
        Me.lblCodVeh.Name = "lblCodVeh"
        Me.lblCodVeh.Size = New System.Drawing.Size(0, 18)
        Me.lblCodVeh.TabIndex = 93
        '
        'ABMVehiculoRegistrado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FlashDelivery.My.Resources.Resources.ABM_Vehiculo
        Me.ClientSize = New System.Drawing.Size(470, 322)
        Me.Controls.Add(Me.lblCodVeh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.cbxBuscarPor)
        Me.Controls.Add(Me.btnRegMod)
        Me.Controls.Add(Me.dgvVehiculos)
        Me.Controls.Add(Me.txtBuscarVehiculos)
        Me.Controls.Add(Me.btnVolver)
        Me.Name = "ABMVehiculoRegistrado"
        Me.Text = "ABMVehiculoRegistrado"
        CType(Me.dgvVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnRegMod As System.Windows.Forms.Button
    Friend WithEvents dgvVehiculos As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscarVehiculos As System.Windows.Forms.TextBox
    Friend WithEvents cbxBuscarPor As System.Windows.Forms.ComboBox
    Friend WithEvents lbNombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCodVeh As System.Windows.Forms.Label
End Class
