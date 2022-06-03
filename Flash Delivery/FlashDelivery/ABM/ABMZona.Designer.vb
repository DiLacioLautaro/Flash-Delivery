<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMZona
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
        Me.btnBzona = New System.Windows.Forms.Button()
        Me.cbxZonaB = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxZonaM = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtZonaM = New System.Windows.Forms.TextBox()
        Me.btnMzona = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAzona = New System.Windows.Forms.Button()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.txtZonaA = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.grb1 = New System.Windows.Forms.GroupBox()
        Me.grb2 = New System.Windows.Forms.GroupBox()
        Me.grb3 = New System.Windows.Forms.GroupBox()
        Me.grb1.SuspendLayout()
        Me.grb2.SuspendLayout()
        Me.grb3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBzona
        '
        Me.btnBzona.BackColor = System.Drawing.Color.Transparent
        Me.btnBzona.FlatAppearance.BorderSize = 0
        Me.btnBzona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBzona.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBzona.ForeColor = System.Drawing.Color.Black
        Me.btnBzona.Location = New System.Drawing.Point(50, 88)
        Me.btnBzona.Name = "btnBzona"
        Me.btnBzona.Size = New System.Drawing.Size(246, 35)
        Me.btnBzona.TabIndex = 85
        Me.btnBzona.Text = "Borrar Zona"
        Me.btnBzona.UseVisualStyleBackColor = False
        '
        'cbxZonaB
        '
        Me.cbxZonaB.FormattingEnabled = True
        Me.cbxZonaB.Location = New System.Drawing.Point(125, 35)
        Me.cbxZonaB.Name = "cbxZonaB"
        Me.cbxZonaB.Size = New System.Drawing.Size(196, 37)
        Me.cbxZonaB.TabIndex = 84
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Coolvetica Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(62, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 18)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Zona"
        '
        'cbxZonaM
        '
        Me.cbxZonaM.FormattingEnabled = True
        Me.cbxZonaM.Location = New System.Drawing.Point(140, 45)
        Me.cbxZonaM.Name = "cbxZonaM"
        Me.cbxZonaM.Size = New System.Drawing.Size(196, 37)
        Me.cbxZonaM.TabIndex = 82
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Coolvetica Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(35, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 18)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Nuevo Nombre"
        '
        'txtZonaM
        '
        Me.txtZonaM.BackColor = System.Drawing.Color.White
        Me.txtZonaM.Location = New System.Drawing.Point(140, 97)
        Me.txtZonaM.Name = "txtZonaM"
        Me.txtZonaM.Size = New System.Drawing.Size(196, 36)
        Me.txtZonaM.TabIndex = 80
        '
        'btnMzona
        '
        Me.btnMzona.BackColor = System.Drawing.Color.Transparent
        Me.btnMzona.FlatAppearance.BorderSize = 0
        Me.btnMzona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMzona.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMzona.ForeColor = System.Drawing.Color.Black
        Me.btnMzona.Location = New System.Drawing.Point(65, 139)
        Me.btnMzona.Name = "btnMzona"
        Me.btnMzona.Size = New System.Drawing.Size(246, 35)
        Me.btnMzona.TabIndex = 79
        Me.btnMzona.Text = "Modificar Zona"
        Me.btnMzona.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Coolvetica Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(95, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 18)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Zona"
        '
        'btnAzona
        '
        Me.btnAzona.BackColor = System.Drawing.Color.Transparent
        Me.btnAzona.FlatAppearance.BorderSize = 0
        Me.btnAzona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAzona.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAzona.ForeColor = System.Drawing.Color.Black
        Me.btnAzona.Location = New System.Drawing.Point(108, 98)
        Me.btnAzona.Name = "btnAzona"
        Me.btnAzona.Size = New System.Drawing.Size(198, 35)
        Me.btnAzona.TabIndex = 77
        Me.btnAzona.Text = "Registrar Zona"
        Me.btnAzona.UseVisualStyleBackColor = False
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Font = New System.Drawing.Font("Coolvetica Rg", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.lbNombre.Location = New System.Drawing.Point(28, 43)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(112, 18)
        Me.lbNombre.TabIndex = 76
        Me.lbNombre.Text = "Nombre de Zona"
        '
        'txtZonaA
        '
        Me.txtZonaA.BackColor = System.Drawing.Color.White
        Me.txtZonaA.Location = New System.Drawing.Point(154, 41)
        Me.txtZonaA.Name = "txtZonaA"
        Me.txtZonaA.Size = New System.Drawing.Size(190, 36)
        Me.txtZonaA.TabIndex = 75
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Transparent
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(334, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(78, 34)
        Me.btnVolver.TabIndex = 74
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'grb1
        '
        Me.grb1.BackColor = System.Drawing.Color.Transparent
        Me.grb1.Controls.Add(Me.txtZonaA)
        Me.grb1.Controls.Add(Me.lbNombre)
        Me.grb1.Controls.Add(Me.btnAzona)
        Me.grb1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.grb1.Font = New System.Drawing.Font("Coolvetica Rg", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grb1.Location = New System.Drawing.Point(18, 52)
        Me.grb1.Name = "grb1"
        Me.grb1.Size = New System.Drawing.Size(394, 148)
        Me.grb1.TabIndex = 86
        Me.grb1.TabStop = False
        Me.grb1.Text = "Registrar Zona"
        '
        'grb2
        '
        Me.grb2.BackColor = System.Drawing.Color.Transparent
        Me.grb2.Controls.Add(Me.btnMzona)
        Me.grb2.Controls.Add(Me.Label1)
        Me.grb2.Controls.Add(Me.txtZonaM)
        Me.grb2.Controls.Add(Me.Label2)
        Me.grb2.Controls.Add(Me.cbxZonaM)
        Me.grb2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.grb2.Font = New System.Drawing.Font("Coolvetica Rg", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grb2.Location = New System.Drawing.Point(28, 219)
        Me.grb2.Name = "grb2"
        Me.grb2.Size = New System.Drawing.Size(384, 196)
        Me.grb2.TabIndex = 87
        Me.grb2.TabStop = False
        Me.grb2.Text = "Modificar Zona"
        '
        'grb3
        '
        Me.grb3.BackColor = System.Drawing.Color.Transparent
        Me.grb3.Controls.Add(Me.btnBzona)
        Me.grb3.Controls.Add(Me.Label3)
        Me.grb3.Controls.Add(Me.cbxZonaB)
        Me.grb3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.grb3.Font = New System.Drawing.Font("Coolvetica Rg", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grb3.Location = New System.Drawing.Point(28, 433)
        Me.grb3.Name = "grb3"
        Me.grb3.Size = New System.Drawing.Size(384, 129)
        Me.grb3.TabIndex = 88
        Me.grb3.TabStop = False
        Me.grb3.Text = "Borrar Zona"
        '
        'ABMZona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FlashDelivery.My.Resources.Resources.RegistrarCliente
        Me.ClientSize = New System.Drawing.Size(435, 578)
        Me.Controls.Add(Me.grb3)
        Me.Controls.Add(Me.grb2)
        Me.Controls.Add(Me.grb1)
        Me.Controls.Add(Me.btnVolver)
        Me.Name = "ABMZona"
        Me.Text = "ABMZona"
        Me.grb1.ResumeLayout(False)
        Me.grb1.PerformLayout()
        Me.grb2.ResumeLayout(False)
        Me.grb2.PerformLayout()
        Me.grb3.ResumeLayout(False)
        Me.grb3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBzona As System.Windows.Forms.Button
    Friend WithEvents cbxZonaB As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxZonaM As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtZonaM As System.Windows.Forms.TextBox
    Friend WithEvents btnMzona As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAzona As System.Windows.Forms.Button
    Friend WithEvents lbNombre As System.Windows.Forms.Label
    Friend WithEvents txtZonaA As System.Windows.Forms.TextBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents grb1 As System.Windows.Forms.GroupBox
    Friend WithEvents grb2 As System.Windows.Forms.GroupBox
    Friend WithEvents grb3 As System.Windows.Forms.GroupBox
End Class
