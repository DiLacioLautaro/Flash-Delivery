Public Class frmDirigirseLocal
    Public codSR As Integer
    'Formulario Programado Por Jaco Luna y diseñado por Valentina De Piero
    Private Sub btnPedidoRecogido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPedidoRecogido.Click
        sql = " update solicitudrepartidor as solRep " & _
              " set solRep.estado = 'en camino' " & _
              " where solRep.codSR = '" & codSR & "'"
        Call x()

        frmDatosDomicilio.codSR = codSR
        frmDatosDomicilio.lblNombre.Text = Me.lblNombreCliente.Text
        frmDatosDomicilio.lblDireccion.Text = Me.lblDireccionPedido.Text
        frmDatosDomicilio.lblArea.Text = Me.lblAreaPedido.Text

        frmDatosDomicilio.Show()
        Me.Close()
    End Sub

    Private Sub frmDirigirseLocal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class