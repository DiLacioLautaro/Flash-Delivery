<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRealizarPed
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
        Me.dgvElementos = New System.Windows.Forms.DataGridView()
        Me.dgvPedido = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLocal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnConfirmarPed = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMONTO = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvElementos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvElementos
        '
        Me.dgvElementos.BackgroundColor = System.Drawing.Color.White
        Me.dgvElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvElementos.Location = New System.Drawing.Point(17, 101)
        Me.dgvElementos.Name = "dgvElementos"
        Me.dgvElementos.Size = New System.Drawing.Size(302, 448)
        Me.dgvElementos.TabIndex = 0
        '
        'dgvPedido
        '
        Me.dgvPedido.BackgroundColor = System.Drawing.Color.White
        Me.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedido.Location = New System.Drawing.Point(342, 101)
        Me.dgvPedido.Name = "dgvPedido"
        Me.dgvPedido.Size = New System.Drawing.Size(302, 448)
        Me.dgvPedido.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Coolvetica Rg", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(187, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 35)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Bienvenido a:"
        '
        'lblLocal
        '
        Me.lblLocal.AutoSize = True
        Me.lblLocal.BackColor = System.Drawing.Color.Transparent
        Me.lblLocal.Font = New System.Drawing.Font("Coolvetica Rg", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLocal.Location = New System.Drawing.Point(378, 16)
        Me.lblLocal.Name = "lblLocal"
        Me.lblLocal.Size = New System.Drawing.Size(33, 35)
        Me.lblLocal.TabIndex = 15
        Me.lblLocal.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Coolvetica Rg", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 29)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Que deseas llevar?"
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.White
        Me.txtBuscar.Location = New System.Drawing.Point(207, 73)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(112, 20)
        Me.txtBuscar.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Coolvetica Rg", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(337, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 29)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Tu Pedido:"
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Transparent
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(11, 6)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(163, 54)
        Me.btnVolver.TabIndex = 41
        Me.btnVolver.Text = "Cancelar y Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnConfirmarPed
        '
        Me.btnConfirmarPed.BackColor = System.Drawing.Color.Transparent
        Me.btnConfirmarPed.FlatAppearance.BorderSize = 0
        Me.btnConfirmarPed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmarPed.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmarPed.ForeColor = System.Drawing.Color.White
        Me.btnConfirmarPed.Location = New System.Drawing.Point(371, 644)
        Me.btnConfirmarPed.Name = "btnConfirmarPed"
        Me.btnConfirmarPed.Size = New System.Drawing.Size(242, 42)
        Me.btnConfirmarPed.TabIndex = 42
        Me.btnConfirmarPed.Text = "Confirmar pedido"
        Me.btnConfirmarPed.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Coolvetica Rg", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Coral
        Me.Label4.Location = New System.Drawing.Point(417, 566)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 29)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Monto total: $"
        '
        'lblMONTO
        '
        Me.lblMONTO.AllowDrop = True
        Me.lblMONTO.AutoSize = True
        Me.lblMONTO.Font = New System.Drawing.Font("Coolvetica Rg", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMONTO.ForeColor = System.Drawing.Color.Red
        Me.lblMONTO.Location = New System.Drawing.Point(480, 595)
        Me.lblMONTO.Name = "lblMONTO"
        Me.lblMONTO.Size = New System.Drawing.Size(0, 29)
        Me.lblMONTO.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Coolvetica Rg", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Coral
        Me.Label5.Location = New System.Drawing.Point(66, 586)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 29)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Forma De Pago:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Coolvetica Rg", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(98, 627)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 29)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Efectivo"
        '
        'frmRealizarPed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = Global.FlashDelivery.My.Resources.Resources.Realizar_Pedido
        Me.ClientSize = New System.Drawing.Size(660, 704)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblMONTO)
        Me.Controls.Add(Me.btnConfirmarPed)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblLocal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvPedido)
        Me.Controls.Add(Me.dgvElementos)
        Me.Name = "frmRealizarPed"
        Me.Text = "Realizar Pedido"
        CType(Me.dgvElementos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvElementos As System.Windows.Forms.DataGridView
    Friend WithEvents dgvPedido As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLocal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnConfirmarPed As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMONTO As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
