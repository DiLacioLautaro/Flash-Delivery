<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaPedidos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvPedidosZona = New System.Windows.Forms.DataGridView()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.cboZona = New System.Windows.Forms.ComboBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        CType(Me.dgvPedidosZona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPedidosZona
        '
        Me.dgvPedidosZona.AllowUserToAddRows = False
        Me.dgvPedidosZona.AllowUserToDeleteRows = False
        Me.dgvPedidosZona.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPedidosZona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidosZona.Location = New System.Drawing.Point(33, 132)
        Me.dgvPedidosZona.Name = "dgvPedidosZona"
        Me.dgvPedidosZona.ReadOnly = True
        Me.dgvPedidosZona.Size = New System.Drawing.Size(363, 507)
        Me.dgvPedidosZona.TabIndex = 5
        '
        'btnUsuario
        '
        Me.btnUsuario.BackColor = System.Drawing.Color.Transparent
        Me.btnUsuario.FlatAppearance.BorderSize = 0
        Me.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuario.Font = New System.Drawing.Font("Coolvetica Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuario.ForeColor = System.Drawing.Color.Black
        Me.btnUsuario.Location = New System.Drawing.Point(12, 30)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(77, 33)
        Me.btnUsuario.TabIndex = 6
        Me.btnUsuario.Text = "Usuario"
        Me.btnUsuario.UseVisualStyleBackColor = False
        '
        'btnRegistro
        '
        Me.btnRegistro.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistro.FlatAppearance.BorderSize = 0
        Me.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistro.Font = New System.Drawing.Font("Coolvetica Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistro.Location = New System.Drawing.Point(342, 30)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(72, 33)
        Me.btnRegistro.TabIndex = 7
        Me.btnRegistro.Text = "Registro"
        Me.btnRegistro.UseVisualStyleBackColor = False
        '
        'cboZona
        '
        Me.cboZona.FormattingEnabled = True
        Me.cboZona.Location = New System.Drawing.Point(33, 84)
        Me.cboZona.Name = "cboZona"
        Me.cboZona.Size = New System.Drawing.Size(363, 21)
        Me.cboZona.TabIndex = 8
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.Location = New System.Drawing.Point(120, 645)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(167, 31)
        Me.btnLogout.TabIndex = 9
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'frmBusquedaPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FlashDelivery.My.Resources.Resources.pedidosenzona
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(426, 684)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.cboZona)
        Me.Controls.Add(Me.btnRegistro)
        Me.Controls.Add(Me.btnUsuario)
        Me.Controls.Add(Me.dgvPedidosZona)
        Me.DoubleBuffered = True
        Me.Name = "frmBusquedaPedidos"
        Me.Text = "frmBusquedaPedidos"
        CType(Me.dgvPedidosZona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvPedidosZona As System.Windows.Forms.DataGridView
    Friend WithEvents btnUsuario As System.Windows.Forms.Button
    Friend WithEvents btnRegistro As System.Windows.Forms.Button
    Friend WithEvents cboZona As System.Windows.Forms.ComboBox
    Friend WithEvents btnLogout As System.Windows.Forms.Button
End Class
