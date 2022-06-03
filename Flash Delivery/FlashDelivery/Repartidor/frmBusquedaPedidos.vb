Imports System.Data.Odbc
Public Class frmBusquedaPedidos

    Public codPed As Integer

    'Formulario Programado Por Jaco Luna y diseñado por Valentina De Piero

    Private Sub frmBusquedaPedidos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Dim ds As New DataSet
        Dim adp As OdbcDataAdapter

        sql =
        " select ped.codPED " & _
        " from pedido as ped " & _
        " inner join solicitudatencionpedido as solAtePed on ped.codPED = solAtePed.codPED " & _
        " inner join localadherido as locAhd on ped.codLA = locAhd.codLA " & _
        " inner join detallepedido as detPed on ped.codPED = detPed.codPED " & _
        " inner join formaPago as forPag on ped.codFPago = forPag.codFPago " & _
        " where solAtePed.estado = 'pendiente' " & _
        " group by detPed.codDP " & _
        " and locAhd.codZ = (select codZ from zona " & _
                           " where nombre = '" & cboZona.SelectedItem & "') "

        ds.Tables.Add("pedidos")
        adp = New OdbcDataAdapter(sql, cnn)
        adp.Fill(ds.Tables("pedidos"))
        dgvPedidosZona.DataSource = ds.Tables("pedidos")
        dgvPedidosZona.Columns(0).Visible = False

        cboZona.Items.Clear()

        sql = " select zon.nombre from zona as zon " & _
              " inner join zonarepartidor as zonRep on zon.codZ = zonRep.codZ " & _
              " inner join repartidor as rep on zonRep.codR = rep.codR " & _
              " where rep.codR = '" & codRep & "'"
        Call x()
        While rs.Read = True
            cboZona.Items.Add(rs(0))
        End While
    End Sub

    Private Sub frmBusquedaPedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = " select zon.nombre from zona as zon " & _
              " inner join zonarepartidor as zonRep on zon.codZ = zonRep.codZ " & _
              " inner join repartidor as rep on zonRep.codR = rep.codR " & _
              " where rep.codR = '" & codRep & "'"
        Call x()
        While rs.Read = True
            cboZona.Items.Add(rs(0))
        End While
    End Sub

    Private Sub dgvPedidosZona_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPedidosZona.CellContentClick

        codPed = dgvPedidosZona.CurrentRow.Cells.Item(0).Value

        sql =
        " select locAhd.nom local, locAhd.direc, " & _
        " per.nom cliente, per.direc, " & _
        " ele.descripcion, detPed.cant from solicitudatencionpedido as solAtePed " & _
        " inner join pedido as ped on solAtePed.codPED =  ped.codPED " & _
        " inner join detallepedido as detPed on ped.codPED = detPed.codPED " & _
        " inner join elemento as ele on detPed.codE = ele.codE " & _
        " inner join localadherido as locAhd on ele.codLA = locAhd.codLA " & _
        " inner join cliente as cli on ped.codC = cli.codC " & _
        " inner join persona as per on cli.codP = per.codP " & _
        " where ped.codPED = '" & codPed & "'"

        Call x()

        While rs.Read = True
            frmRepartidorAceptarPedido.lblNombreLocal.Text = rs(0)
            frmRepartidorAceptarPedido.lblDireccionLocal.Text = rs(1)

            frmRepartidorAceptarPedido.lblNombreCliente.Text = rs(2)
            frmRepartidorAceptarPedido.lblDireccionCliente.Text = rs(3)

            frmRepartidorAceptarPedido.lstPedido.Items.Add(rs(5) & " " & rs(4))
        End While

        frmRepartidorAceptarPedido.Show()
        Me.Hide()

    End Sub

    Private Sub btnRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistro.Click
        Me.Close()
        frmRegistroPedidos.Show()
    End Sub

    Private Sub btnUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuario.Click
        sql =
        " select per.nom, per.ape, per.tel, per.direc, per.email, zon.nombre from repartidor as rep " & _
        " inner join persona as per on rep.codP = per.codP " & _
        " inner join zonarepartidor as zonRep on rep.codR = zonRep.codR " & _
        " inner join zona as zon on zonRep.codZ = zon.codZ " & _
        " where rep.codR = '" & codRep & "'"
        Call x()
        While rs.Read = True
            frmUsuarioRepartidor.txtNom.Text = rs(0)
            frmUsuarioRepartidor.txtApe.Text = rs(1)
            frmUsuarioRepartidor.txtTel.Text = rs(2)
            frmUsuarioRepartidor.txtDirec.Text = rs(3)
            frmUsuarioRepartidor.txtEmail.Text = rs(4)
        End While

        Me.Close()
        frmUsuarioRepartidor.Show()
    End Sub

    Private Sub cboZona_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboZona.SelectedIndexChanged
        Dim ds As New DataSet
        Dim adp As OdbcDataAdapter

        sql =
          " select ped.codPED, " &
          " locAhd.nom local, count(detPed.codPED) paquetes,  " &
          " sum(detPed.PU) precio, forPag.descripcion formaPago from pedido as ped " &
          " inner join solicitudatencionpedido as solAtePed on ped.codPED = solAtePed.codPED " &
          " inner join localadherido as locAhd on ped.codLA = locAhd.codLA " &
          " inner join detallepedido as detPed on ped.codPED = detPed.codPED " &
          " inner join formaPago as forPag on ped.codFPago = forPag.codFPago " &
          " where solAtePed.estado = 'pendiente' " &
          " and locAhd.codZ = (select codZ from zona " &
                             " where nombre = '" & cboZona.SelectedItem & "') " & _
          " group by ped.codPED "

        ds.Tables.Add("pedidos")
        adp = New OdbcDataAdapter(sql, cnn)
        adp.Fill(ds.Tables("pedidos"))
        dgvPedidosZona.DataSource = ds.Tables("pedidos")

        dgvPedidosZona.Columns(0).Visible = False
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Me.Hide()
        Login.Show()
        modulo.codRep = 0
    End Sub
End Class