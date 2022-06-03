Imports System.Data.Odbc
Public Class frmRegistroPedidos
    'Formulario Programado Por Jaco Luna y diseñado por Valentina De Piero
    Private Sub frmRegistroPedidos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Dim ds As New DataSet
        Dim adp As OdbcDataAdapter

        sql =
        " select locAhd.nom local, locAhd.direc local_Direccion, " & _
        " per.nom cliente, per.direc cliente_direccion, " & _
        " forPag.descripcion from solicitudatencionpedido as solAtePed " & _
        " inner join pedido as ped on solAtePed.codPED = ped.codPED " & _
        " inner join formapago as forPag on ped.codFPago = forPag.codFPago " & _
        " inner join detallepedido as detPed on ped.codPED = detPed.codPED " & _
        " inner join elemento as ele on detPed.codE = ele.codE " & _
        " inner join localadherido as locAhd on ele.codLA = locAhd.codLA " & _
        " inner join cliente as cli on ped.codC = cli.codC " & _
        " inner join persona as per on cli.codP = per.codP " & _
        " inner join solicitudrepartidor as solRep on solAtePed.codSAP = solRep.codSAP " & _
        " where solRep.estado = 'entregada' " & _
        " and solRep.codR = '" & codRep & "'"

        ds.Tables.Add("pedidosHechos")
        adp = New OdbcDataAdapter(sql, cnn)
        adp.Fill(ds.Tables("pedidosHechos"))
        dtvRegistroPedidos.DataSource = ds.Tables("pedidosHechos")

    End Sub

    Private Sub frmRegistroPedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As New DataSet
        Dim adp As OdbcDataAdapter

        sql =
        " select locAhd.nom local, locAhd.direc local_Direccion, " & _
        " per.nom cliente, per.direc cliente_direccion, " & _
        " forPag.descripcion from solicitudatencionpedido as solAtePed " & _
        " inner join pedido as ped on solAtePed.codPED = ped.codPED " & _
        " inner join formapago as forPag on ped.codFPago = forPag.codFPago " & _
        " inner join detallepedido as detPed on ped.codPED = detPed.codPED " & _
        " inner join elemento as ele on detPed.codE = ele.codE " & _
        " inner join localadherido as locAhd on ele.codLA = locAhd.codLA " & _
        " inner join cliente as cli on ped.codC = cli.codC " & _
        " inner join persona as per on cli.codP = per.codP " & _
        " inner join solicitudrepartidor as solRep on solAtePed.codSAP = solRep.codSAP " & _
        " where solRep.estado = 'entregada' " & _
        " and solRep.codR = '" & codRep & "'"

        ds.Tables.Add("pedidosHechos")
        adp = New OdbcDataAdapter(sql, cnn)
        adp.Fill(ds.Tables("pedidosHechos"))
        dtvRegistroPedidos.DataSource = ds.Tables("pedidosHechos")

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmBusquedaPedidos.Show()
    End Sub
End Class