<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocalesNear
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
        Me.lblElige = New System.Windows.Forms.Label()
        Me.dgvLocales = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblZona = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvElementos = New System.Windows.Forms.DataGridView()
        Me.txtBuscarElementos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.dgvLocales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvElementos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblElige
        '
        Me.lblElige.AutoSize = True
        Me.lblElige.BackColor = System.Drawing.Color.Transparent
        Me.lblElige.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElige.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.lblElige.Location = New System.Drawing.Point(47, 436)
        Me.lblElige.Name = "lblElige"
        Me.lblElige.Size = New System.Drawing.Size(219, 22)
        Me.lblElige.TabIndex = 14
        Me.lblElige.Text = "Elige el que mas te guste!"
        '
        'dgvLocales
        '
        Me.dgvLocales.AllowUserToResizeColumns = False
        Me.dgvLocales.BackgroundColor = System.Drawing.Color.White
        Me.dgvLocales.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvLocales.Location = New System.Drawing.Point(51, 502)
        Me.dgvLocales.Name = "dgvLocales"
        Me.dgvLocales.RowHeadersWidth = 40
        Me.dgvLocales.Size = New System.Drawing.Size(371, 176)
        Me.dgvLocales.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Coolvetica Rg", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(46, 470)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 25)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Zona:"
        '
        'lblZona
        '
        Me.lblZona.AutoSize = True
        Me.lblZona.BackColor = System.Drawing.Color.Transparent
        Me.lblZona.Font = New System.Drawing.Font("Coolvetica Rg", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZona.ForeColor = System.Drawing.Color.Coral
        Me.lblZona.Location = New System.Drawing.Point(111, 471)
        Me.lblZona.Name = "lblZona"
        Me.lblZona.Size = New System.Drawing.Size(25, 25)
        Me.lblZona.TabIndex = 17
        Me.lblZona.Text = "X"
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Transparent
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Coolvetica Compressed Rg", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(12, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(52, 48)
        Me.btnVolver.TabIndex = 37
        Me.btnVolver.Text = "<-"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.White
        Me.txtBuscar.Location = New System.Drawing.Point(255, 476)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(167, 20)
        Me.txtBuscar.TabIndex = 38
        '
        'dgvElementos
        '
        Me.dgvElementos.AllowUserToAddRows = False
        Me.dgvElementos.AllowUserToDeleteRows = False
        Me.dgvElementos.BackgroundColor = System.Drawing.Color.White
        Me.dgvElementos.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgvElementos.Location = New System.Drawing.Point(51, 163)
        Me.dgvElementos.Name = "dgvElementos"
        Me.dgvElementos.RowHeadersWidth = 40
        Me.dgvElementos.Size = New System.Drawing.Size(371, 179)
        Me.dgvElementos.TabIndex = 40
        '
        'txtBuscarElementos
        '
        Me.txtBuscarElementos.BackColor = System.Drawing.Color.White
        Me.txtBuscarElementos.Location = New System.Drawing.Point(270, 137)
        Me.txtBuscarElementos.Name = "txtBuscarElementos"
        Me.txtBuscarElementos.Size = New System.Drawing.Size(152, 20)
        Me.txtBuscarElementos.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Coolvetica Rg", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(46, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 25)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Productos cerca tuyo!"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Coolvetica Rg", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Red
        Me.btnClear.Location = New System.Drawing.Point(428, 467)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(24, 32)
        Me.btnClear.TabIndex = 62
        Me.btnClear.Text = "X"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmLocalesNear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = Global.FlashDelivery.My.Resources.Resources.LocalesCerca
        Me.ClientSize = New System.Drawing.Size(476, 718)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBuscarElementos)
        Me.Controls.Add(Me.dgvElementos)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblZona)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvLocales)
        Me.Controls.Add(Me.lblElige)
        Me.Name = "frmLocalesNear"
        Me.Text = "Locales Cerca!"
        CType(Me.dgvLocales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvElementos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblElige As System.Windows.Forms.Label
    Friend WithEvents dgvLocales As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblZona As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents dgvElementos As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscarElementos As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
