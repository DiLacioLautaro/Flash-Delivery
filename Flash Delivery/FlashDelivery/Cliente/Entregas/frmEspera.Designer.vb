<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEspera
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstCant = New System.Windows.Forms.ListBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lstDesc = New System.Windows.Forms.ListBox()
        Me.lstMonto = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFormaPago = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Coolvetica Rg", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(25, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(374, 42)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "En espera por tu pedido!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(98, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 44)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "El negocio esta confirmando" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "               el pedido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Coolvetica Rg", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 25)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Tu pedido:"
        '
        'lstCant
        '
        Me.lstCant.BackColor = System.Drawing.Color.White
        Me.lstCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCant.ForeColor = System.Drawing.Color.Black
        Me.lstCant.FormattingEnabled = True
        Me.lstCant.ItemHeight = 18
        Me.lstCant.Location = New System.Drawing.Point(19, 227)
        Me.lstCant.Name = "lstCant"
        Me.lstCant.Size = New System.Drawing.Size(64, 292)
        Me.lstCant.TabIndex = 48
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Transparent
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(90, 598)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(244, 39)
        Me.btnVolver.TabIndex = 49
        Me.btnVolver.Text = "Volver al menu principal"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(223, 549)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 22)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Monto Total:"
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.BackColor = System.Drawing.Color.Transparent
        Me.lblMonto.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.ForeColor = System.Drawing.Color.Black
        Me.lblMonto.Location = New System.Drawing.Point(340, 549)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(76, 22)
        Me.lblMonto.TabIndex = 51
        Me.lblMonto.Text = "XXXXXX"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(14, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 22)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Cantidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(141, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 22)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Descripcion"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(331, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 22)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Monto"
        '
        'lstDesc
        '
        Me.lstDesc.BackColor = System.Drawing.Color.White
        Me.lstDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDesc.ForeColor = System.Drawing.Color.Black
        Me.lstDesc.FormattingEnabled = True
        Me.lstDesc.ItemHeight = 18
        Me.lstDesc.Location = New System.Drawing.Point(89, 227)
        Me.lstDesc.Name = "lstDesc"
        Me.lstDesc.Size = New System.Drawing.Size(233, 292)
        Me.lstDesc.TabIndex = 55
        '
        'lstMonto
        '
        Me.lstMonto.BackColor = System.Drawing.Color.White
        Me.lstMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMonto.ForeColor = System.Drawing.Color.Black
        Me.lstMonto.FormattingEnabled = True
        Me.lstMonto.ItemHeight = 18
        Me.lstMonto.Location = New System.Drawing.Point(328, 227)
        Me.lstMonto.Name = "lstMonto"
        Me.lstMonto.Size = New System.Drawing.Size(82, 292)
        Me.lstMonto.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(8, 549)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 22)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Forma de pago:"
        '
        'lblFormaPago
        '
        Me.lblFormaPago.AutoSize = True
        Me.lblFormaPago.BackColor = System.Drawing.Color.Transparent
        Me.lblFormaPago.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormaPago.ForeColor = System.Drawing.Color.Black
        Me.lblFormaPago.Location = New System.Drawing.Point(141, 549)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(28, 22)
        Me.lblFormaPago.TabIndex = 58
        Me.lblFormaPago.Text = "xx"
        '
        'frmEspera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = Global.FlashDelivery.My.Resources.Resources.Espera
        Me.ClientSize = New System.Drawing.Size(425, 651)
        Me.Controls.Add(Me.lblFormaPago)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lstMonto)
        Me.Controls.Add(Me.lstDesc)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lstCant)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmEspera"
        Me.Text = "Espera tu pedido!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstCant As System.Windows.Forms.ListBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lstDesc As System.Windows.Forms.ListBox
    Friend WithEvents lstMonto As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblFormaPago As System.Windows.Forms.Label
End Class
