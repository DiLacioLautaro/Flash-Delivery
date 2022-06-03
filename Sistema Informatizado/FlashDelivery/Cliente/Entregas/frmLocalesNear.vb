Imports System.Data.Odbc
Public Class frmLocalesNear
    Dim sql As String
    Public sqlid As String
    Public rsid As OdbcDataReader
    Public UsuarioActual As String
    Public permiso As String
    Dim ds As New DataSet
    Dim da As OdbcDataAdapter
    Public ds1 As New DataSet
    Public da1 As OdbcDataAdapter
    Public ds2 As New DataSet
    Public da2 As OdbcDataAdapter
    Dim ds2v As New DataSet
    Dim da2v As OdbcDataAdapter
    Dim dsbu As New DataSet
    Dim dabu As OdbcDataAdapter
    Dim x As Integer
    'Formulario Programado Por Valentin Bertolini y diseñado por Valentina De Piero

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLocales.CellContentClick

        Dim local As String = dgvLocales.Rows(e.RowIndex).Cells("Local").Value.ToString()
        Dim direc As String = dgvLocales.Rows(e.RowIndex).Cells("Direccion").Value.ToString()
        x = MsgBox("Desea realizar un pedido a " & local & "?", MsgBoxStyle.YesNo, "Realizar Pedido?")
        If (x = 6) Then
            frmRealizarPed.lblLocal.Text = local
            sql = "select codLA from LocalAdherido where nom = '" & local & "' and direc = '" & direc & "'"
            cargar(sql)
            While modulo.rs.Read = True
                sql = "select descripcion as Elemento, PU as Precio from Elemento where codLA=" & modulo.rs(0)
                frmRealizarPed.codLocal = modulo.rs(0)
                cargar1(sql)
                ds.Tables.Clear()
                ds.Tables.Add("XX5")
                da = New OdbcDataAdapter(sql, cnn)
                da.Fill(ds.Tables("XX5"))
                frmRealizarPed.dgvElementos.DataSource = ds.Tables("XX5")
            End While
            sql = "truncate tempdetallepedido"
            cargar(sql)

            Me.Hide()
            frmRealizarPed.Show()

        End If
    End Sub

    Private Sub frmLocalesNear_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarRestaurantes()

    End Sub

    Public Sub cargarRestaurantes()
        sql = "select nom as 'Local',direc as 'Direccion' from LocalAdherido where codZ = " & modulo.codZona
        cargar(sql)
        ds.Tables.Clear()
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvLocales.DataSource = ds.Tables("XX")

        sql = "select Elemento.codE as 'Codigo', Elemento.descripcion as 'Elemento' from Elemento,LocalAdherido,Zona where Elemento.codLA = LocalAdherido.codLA and LocalAdherido.codZ = Zona.codZ and Zona.codZ  =" & codZona
        cargar(sql)
        ds.Tables.Clear()
        ds.Tables.Add("XX1")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX1"))
        Me.dgvElementos.DataSource = ds.Tables("XX1")
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        frmMenu.Show()
        txtBuscarElementos.Text = ""
        txtBuscar.Text = ""
    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text <> "" Then
            dsbu.Tables.Clear()
            sql = "select nom as 'Local',direc as 'Direccion' from LocalAdherido where nom like '%" & txtBuscar.Text & "%' and codZ = " & modulo.codZona
            cargar(sql)
            dsbu.Tables.Add("XX")
            dabu = New OdbcDataAdapter(sql, cnn)
            dabu.Fill(dsbu.Tables("XX"))
            Me.dgvLocales.DataSource = dsbu.Tables("XX")

        Else
            ds.Tables.Clear()
            sql = "select nom as 'Local',direc as 'Direccion' from LocalAdherido where codZ = " & modulo.codZona
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvLocales.DataSource = ds.Tables("XX")
        End If
    End Sub

    Private Sub txtBuscarElementos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarElementos.TextChanged
        If txtBuscarElementos.Text <> "" Then
            dsbu.Tables.Clear()

            sql = "select Elemento.codE, Elemento.descripcion as 'Elemento' from Elemento,LocalAdherido,Zona where Elemento.descripcion  like '%" & txtBuscarElementos.Text & "%' and Elemento.codLA = LocalAdherido.codLA and LocalAdherido.codZ = Zona.codZ =" & modulo.codZona
            cargar(sql)
            dsbu.Tables.Add("XX")
            dabu = New OdbcDataAdapter(sql, cnn)
            dabu.Fill(dsbu.Tables("XX"))
            Me.dgvElementos.DataSource = dsbu.Tables("XX")

        Else
            ds.Tables.Clear()

            sql = "select Elemento.codE, Elemento.descripcion as 'Elemento' from Elemento,LocalAdherido,Zona where Elemento.codLA = LocalAdherido.codLA and LocalAdherido.codZ = Zona.codZ =" & modulo.codZona
            cargar(sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvElementos.DataSource = ds.Tables("XX")
        End If
    End Sub

    Private Sub dgvElementos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvElementos.CellContentClick
        Dim codE As Integer = dgvElementos.Rows(e.RowIndex).Cells("Codigo").Value.ToString()
        Dim elemento As String = dgvElementos.Rows(e.RowIndex).Cells("Elemento").Value.ToString()
        sql = "select nom as Local,direc as Direccion from LocalAdherido,Elemento where LocalAdherido.codZ = " & modulo.codZona & " and LocalAdherido.codLA = Elemento.codLA and Elemento.codE = " & codE
        ds2.Tables.Clear()
        ds2.Tables.Add("XXh")
        da2 = New OdbcDataAdapter(sql, cnn)
        da2.Fill(ds2.Tables("XXh"))
        Me.dgvLocales.DataSource = ds2.Tables("XXh")
        lblElige.Text = "Locales que contengan " + elemento
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lblElige.Text = "Elige el que mas te guste!"
        ds.Tables.Clear()
        sql = "select nom as 'Local',direc as 'Direccion' from LocalAdherido where codZ = " & modulo.codZona
        cargar(sql)
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvLocales.DataSource = ds.Tables("XX")
    End Sub

    Private Sub frmLocalesNear_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        sql = "select nom as 'Local',direc as 'Direccion' from LocalAdherido where codZ = " & modulo.codZona
        cargar(sql)
        ds.Tables.Clear()
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvLocales.DataSource = ds.Tables("XX")


        sql = "select Elemento.codE as 'Codigo', Elemento.descripcion as 'Elemento' from Elemento,LocalAdherido,Zona where Elemento.codLA = LocalAdherido.codLA and LocalAdherido.codZ = Zona.codZ and Zona.codZ  =" & codZona
        cargar(sql)
        ds.Tables.Clear()
        ds.Tables.Add("XX1")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX1"))
        Me.dgvElementos.DataSource = ds.Tables("XX1")
    End Sub
End Class