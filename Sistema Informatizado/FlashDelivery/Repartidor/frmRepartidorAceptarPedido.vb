Public Class frmRepartidorAceptarPedido

    Dim codSAP As Integer
    'Formulario Programado Por Jaco Luna y diseñado por Valentina De Piero
    Private Sub btnSeguirBuscando_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeguirBuscando.Click
        frmBusquedaPedidos.Show()
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        'codigo x que se iguala al iniciar sesion
        codRep = 1000

        sql = " select codSAP from SolicitudAtencionPedido where codPed = '" & frmBusquedaPedidos.codPed & "'"

        Call x()
        While rs.Read = True

            codSAP = rs(0)

            sql = " update SolicitudAtencionPedido as solAte " & _
                  " set estado = 'aceptada' " & _
                  " where solAte.codSAP = " & codSAP & ""
            Call x()

            sql = " select max(codSR)+1 from SolicitudRepartidor "

            Call x()
            While rs.Read = True
                frmDirigirseLocal.codSR = rs(0)
                sql = " insert into SolicitudRepartidor values " & _
                      " ( '" & rs(0) & "' , '" & codSAP & "' , '" & codRep & "','sin retirar') "
                Call x()
            End While
        End While

        sql =
        " select locAhd.nom local, locAhd.direc, zon.nombre from pedido as ped " & _
        " inner join localadherido as locAhd on ped.codLA = locAhd.codLA " & _
        " inner join zona as zon on locAhd.codZ = zon.codZ " & _
        " where codPED = '" & frmBusquedaPedidos.codPed & "'"
        Call x()
        While rs.Read = True
            frmDirigirseLocal.lblNombreLocal.Text = rs(0)
            frmDirigirseLocal.lblDireccionLocal.Text = rs(1)
            frmDirigirseLocal.lblAreaLocal.Text = rs(2)
        End While

        sql =
        " select per.nom, per.direc, zon.nombre from pedido as ped " & _
        " inner join cliente as cli on ped.codC = cli.codC " & _
        " inner join persona as per on cli.codP = per.codP " & _
        " inner join zona as zon on per.codZ = per.codZ " & _
        " where codPED = '" & frmBusquedaPedidos.codPed & "'"
        Call x()
        While rs.Read = True
            frmDirigirseLocal.lblNombreCliente.Text = rs(0)
            frmDirigirseLocal.lblDireccionPedido.Text = rs(1)
            frmDirigirseLocal.lblAreaPedido.Text = rs(2)
        End While

        Me.Close()
        frmDirigirseLocal.Show()

    End Sub

    Private Sub frmRepartidorAceptarPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
