<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidosEnCurso
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
        Me.dgvPedCurso = New System.Windows.Forms.DataGridView()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSinRepartidor = New System.Windows.Forms.Label()
        Me.lblSinConfirmacion = New System.Windows.Forms.Label()
        CType(Me.dgvPedCurso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPedCurso
        '
        Me.dgvPedCurso.BackgroundColor = System.Drawing.Color.White
        Me.dgvPedCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedCurso.GridColor = System.Drawing.Color.Moccasin
        Me.dgvPedCurso.Location = New System.Drawing.Point(33, 93)
        Me.dgvPedCurso.Name = "dgvPedCurso"
        Me.dgvPedCurso.Size = New System.Drawing.Size(402, 491)
        Me.dgvPedCurso.TabIndex = 13
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Transparent
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Coolvetica Rg", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(28, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(103, 34)
        Me.btnVolver.TabIndex = 42
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Coolvetica Rg", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Coral
        Me.Label3.Location = New System.Drawing.Point(12, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 29)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Tu Pedido en Curso"
        '
        'lblSinRepartidor
        '
        Me.lblSinRepartidor.AutoSize = True
        Me.lblSinRepartidor.BackColor = System.Drawing.Color.Transparent
        Me.lblSinRepartidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSinRepartidor.Font = New System.Drawing.Font("Coolvetica Rg", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinRepartidor.ForeColor = System.Drawing.Color.Red
        Me.lblSinRepartidor.Location = New System.Drawing.Point(161, 9)
        Me.lblSinRepartidor.Name = "lblSinRepartidor"
        Me.lblSinRepartidor.Size = New System.Drawing.Size(255, 29)
        Me.lblSinRepartidor.TabIndex = 44
        Me.lblSinRepartidor.Text = "Sin repartidor asignado!"
        '
        'lblSinConfirmacion
        '
        Me.lblSinConfirmacion.AutoSize = True
        Me.lblSinConfirmacion.BackColor = System.Drawing.Color.Transparent
        Me.lblSinConfirmacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSinConfirmacion.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinConfirmacion.ForeColor = System.Drawing.Color.Red
        Me.lblSinConfirmacion.Location = New System.Drawing.Point(225, 49)
        Me.lblSinConfirmacion.Name = "lblSinConfirmacion"
        Me.lblSinConfirmacion.Size = New System.Drawing.Size(224, 22)
        Me.lblSinConfirmacion.TabIndex = 45
        Me.lblSinConfirmacion.Text = "Sin Confirmacion del Local!"
        Me.lblSinConfirmacion.Visible = False
        '
        'frmPedidosEnCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = Global.FlashDelivery.My.Resources.Resources.Pedidos_en_curso
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(462, 600)
        Me.Controls.Add(Me.lblSinConfirmacion)
        Me.Controls.Add(Me.lblSinRepartidor)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.dgvPedCurso)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmPedidosEnCurso"
        Me.Text = "Pedidos en Curso"
        CType(Me.dgvPedCurso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvPedCurso As System.Windows.Forms.DataGridView
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSinRepartidor As System.Windows.Forms.Label
    Friend WithEvents lblSinConfirmacion As System.Windows.Forms.Label
End Class
