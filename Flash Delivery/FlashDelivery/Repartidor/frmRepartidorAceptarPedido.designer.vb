<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepartidorAceptarPedido
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnSeguirBuscando = New System.Windows.Forms.Button()
        Me.lblNombreLocal = New System.Windows.Forms.Label()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.lblDireccionLocal = New System.Windows.Forms.Label()
        Me.lblDireccionCliente = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstPedido = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.Location = New System.Drawing.Point(106, 514)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(154, 40)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Tomar Pedido"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnSeguirBuscando
        '
        Me.btnSeguirBuscando.BackColor = System.Drawing.Color.Transparent
        Me.btnSeguirBuscando.FlatAppearance.BorderSize = 0
        Me.btnSeguirBuscando.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeguirBuscando.Font = New System.Drawing.Font("Coolvetica Rg", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeguirBuscando.Location = New System.Drawing.Point(13, 11)
        Me.btnSeguirBuscando.Name = "btnSeguirBuscando"
        Me.btnSeguirBuscando.Size = New System.Drawing.Size(34, 36)
        Me.btnSeguirBuscando.TabIndex = 2
        Me.btnSeguirBuscando.Text = "<-"
        Me.btnSeguirBuscando.UseVisualStyleBackColor = False
        '
        'lblNombreLocal
        '
        Me.lblNombreLocal.AutoSize = True
        Me.lblNombreLocal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNombreLocal.Font = New System.Drawing.Font("Coolvetica Rg", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreLocal.ForeColor = System.Drawing.Color.White
        Me.lblNombreLocal.Location = New System.Drawing.Point(48, 166)
        Me.lblNombreLocal.Name = "lblNombreLocal"
        Me.lblNombreLocal.Size = New System.Drawing.Size(94, 18)
        Me.lblNombreLocal.TabIndex = 6
        Me.lblNombreLocal.Text = "Nombre Local"
        Me.lblNombreLocal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNombreCliente.Font = New System.Drawing.Font("Coolvetica Rg", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCliente.ForeColor = System.Drawing.Color.White
        Me.lblNombreCliente.Location = New System.Drawing.Point(45, 251)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(107, 18)
        Me.lblNombreCliente.TabIndex = 7
        Me.lblNombreCliente.Text = "Nombre Cliente"
        Me.lblNombreCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDireccionLocal
        '
        Me.lblDireccionLocal.AutoSize = True
        Me.lblDireccionLocal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDireccionLocal.Font = New System.Drawing.Font("Coolvetica Rg", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionLocal.ForeColor = System.Drawing.Color.White
        Me.lblDireccionLocal.Location = New System.Drawing.Point(213, 164)
        Me.lblDireccionLocal.Name = "lblDireccionLocal"
        Me.lblDireccionLocal.Size = New System.Drawing.Size(103, 18)
        Me.lblDireccionLocal.TabIndex = 8
        Me.lblDireccionLocal.Text = "Direccion Local"
        Me.lblDireccionLocal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDireccionCliente
        '
        Me.lblDireccionCliente.AutoSize = True
        Me.lblDireccionCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDireccionCliente.Font = New System.Drawing.Font("Coolvetica Rg", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionCliente.ForeColor = System.Drawing.Color.White
        Me.lblDireccionCliente.Location = New System.Drawing.Point(213, 251)
        Me.lblDireccionCliente.Name = "lblDireccionCliente"
        Me.lblDireccionCliente.Size = New System.Drawing.Size(116, 18)
        Me.lblDireccionCliente.TabIndex = 9
        Me.lblDireccionCliente.Text = "Direccion Cliente"
        Me.lblDireccionCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Coolvetica Rg", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(47, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Nombre Local"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Coolvetica Rg", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(44, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Nombre Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Coolvetica Rg", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(212, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 18)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Direccion Local"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Coolvetica Rg", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(212, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 18)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Direccion Cliente"
        '
        'lstPedido
        '
        Me.lstPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.lstPedido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstPedido.Font = New System.Drawing.Font("Coolvetica Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPedido.ForeColor = System.Drawing.Color.White
        Me.lstPedido.FormattingEnabled = True
        Me.lstPedido.ItemHeight = 19
        Me.lstPedido.Location = New System.Drawing.Point(71, 341)
        Me.lstPedido.Name = "lstPedido"
        Me.lstPedido.ScrollAlwaysVisible = True
        Me.lstPedido.Size = New System.Drawing.Size(239, 114)
        Me.lstPedido.TabIndex = 17
        '
        'frmRepartidorAceptarPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.FlashDelivery.My.Resources.Resources.deseatomar
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(367, 585)
        Me.Controls.Add(Me.lstPedido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDireccionCliente)
        Me.Controls.Add(Me.lblDireccionLocal)
        Me.Controls.Add(Me.lblNombreCliente)
        Me.Controls.Add(Me.lblNombreLocal)
        Me.Controls.Add(Me.btnSeguirBuscando)
        Me.Controls.Add(Me.btnAceptar)
        Me.DoubleBuffered = True
        Me.Name = "frmRepartidorAceptarPedido"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnSeguirBuscando As System.Windows.Forms.Button
    Friend WithEvents lblNombreLocal As System.Windows.Forms.Label
    Friend WithEvents lblNombreCliente As System.Windows.Forms.Label
    Friend WithEvents lblDireccionLocal As System.Windows.Forms.Label
    Friend WithEvents lblDireccionCliente As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstPedido As System.Windows.Forms.ListBox

End Class
