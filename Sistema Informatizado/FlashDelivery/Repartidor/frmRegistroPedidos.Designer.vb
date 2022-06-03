<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroPedidos
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
        Me.lblPedidos = New System.Windows.Forms.Label()
        Me.dtvRegistroPedidos = New System.Windows.Forms.DataGridView()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.dtvRegistroPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPedidos
        '
        Me.lblPedidos.AutoSize = True
        Me.lblPedidos.BackColor = System.Drawing.Color.Transparent
        Me.lblPedidos.Font = New System.Drawing.Font("Coolvetica Rg", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPedidos.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblPedidos.Location = New System.Drawing.Point(81, 20)
        Me.lblPedidos.Name = "lblPedidos"
        Me.lblPedidos.Size = New System.Drawing.Size(268, 32)
        Me.lblPedidos.TabIndex = 8
        Me.lblPedidos.Text = "Pedidos que realizaste"
        Me.lblPedidos.Visible = False
        '
        'dtvRegistroPedidos
        '
        Me.dtvRegistroPedidos.AllowUserToAddRows = False
        Me.dtvRegistroPedidos.AllowUserToDeleteRows = False
        Me.dtvRegistroPedidos.AllowUserToOrderColumns = True
        Me.dtvRegistroPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtvRegistroPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvRegistroPedidos.Location = New System.Drawing.Point(23, 89)
        Me.dtvRegistroPedidos.Name = "dtvRegistroPedidos"
        Me.dtvRegistroPedidos.ReadOnly = True
        Me.dtvRegistroPedidos.Size = New System.Drawing.Size(375, 575)
        Me.dtvRegistroPedidos.TabIndex = 7
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Transparent
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Coolvetica Rg", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(12, 18)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(46, 34)
        Me.btnVolver.TabIndex = 6
        Me.btnVolver.Text = "<-"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'frmRegistroPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FlashDelivery.My.Resources.Resources.RegistroPedidos
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(422, 688)
        Me.Controls.Add(Me.lblPedidos)
        Me.Controls.Add(Me.dtvRegistroPedidos)
        Me.Controls.Add(Me.btnVolver)
        Me.Name = "frmRegistroPedidos"
        Me.Text = "frmRegistroPedidos"
        CType(Me.dtvRegistroPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPedidos As System.Windows.Forms.Label
    Friend WithEvents dtvRegistroPedidos As System.Windows.Forms.DataGridView
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
