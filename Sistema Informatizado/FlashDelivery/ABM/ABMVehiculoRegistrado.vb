Imports System.Data.Odbc

Public Class ABMVehiculoRegistrado

    Dim x
    Dim band As Boolean
    Dim codV As Integer
    Dim sql As String
    Dim ds As New DataSet
    Dim da As OdbcDataAdapter
    Public ds1 As New DataSet
    Public da1 As OdbcDataAdapter
    Public ds2 As New DataSet
    Public da2 As OdbcDataAdapter
    Dim codigovehiculo As Integer = 0
    Dim tipov, nombrev, repartidor As String
    Dim ds2v As New DataSet

    'Formulario Programado Por Valentin Bertolini y diseñado por Valentina De Piero

    Private Sub ABMVehiculoRegistrado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select codVR, codR, tipo, color, marca, modelo from vehiculoregistrado where borrado = 0"
        cargar(sql)
        ds.Tables.Clear()
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvVehiculos.DataSource = ds.Tables("XX")

    End Sub


    Private Sub txtBuscarVehiculos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarVehiculos.TextChanged
        If txtBuscarVehiculos.Text <> "" And cbxBuscarPor.Text <> "" Then
            ds.Tables.Clear()

            sql = "select codVR, codR, tipo, color, marca, modelo from vehiculoregistrado where  " & cbxBuscarPor.Text & " like '%" & txtBuscarVehiculos.Text & "%' AND borrado=0 "
            cargar(sql)
            ds.Tables.Clear()
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvVehiculos.DataSource = ds.Tables("XX")

        ElseIf cbxBuscarPor.Text = "" Or txtBuscarVehiculos.Text = "" Then
            ds.Tables.Clear()
            sql = "select  codVR, codR, tipo, color, marca, modelo from vehiculoregistrado where borrado=0"
            cargar(sql)
            ds.Tables.Clear()
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvVehiculos.DataSource = ds.Tables("XX")

        End If
    End Sub

    Private Sub dgvVehiculos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvVehiculos.CellContentClick
        codigovehiculo = dgvVehiculos.Rows(e.RowIndex).Cells("codVR").Value.ToString()
        tipov = dgvVehiculos.Rows(e.RowIndex).Cells("tipo").Value.ToString()
        nombrev = dgvVehiculos.Rows(e.RowIndex).Cells("modelo").Value.ToString()
        lblCodVeh.Text = codigovehiculo.ToString
    End Sub

    Private Sub btnRegMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegMod.Click

        Dim x As Integer = MsgBox("Desea eliminar el vehiculo " & tipov & " modelo " & nombrev & " ?", MsgBoxStyle.YesNo)
        If x = 6 Then
            If codigovehiculo <> 0 And lblCodVeh.Text <> "" Then
                sql = "update vehiculoregistrado set borrado = 1 where codVR = " & codigovehiculo
                cargar(sql)
                MsgBox(" Vehiculo cuyo codigo es " & codigovehiculo & " fue borrado correctamente!")
                txtBuscarVehiculos.Text = "1"
                txtBuscarVehiculos.Text = ""
                lblCodVeh.Text = ""
                codigovehiculo = 0
            End If
        End If
    End Sub
End Class