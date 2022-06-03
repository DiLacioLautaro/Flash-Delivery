Public Class frmDatosDomicilio
    Public codSR As Integer

    'Formulario Programado Por Jaco Luna y diseñado por Valentina De Piero

    Private Sub btnPedidoRealizado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPedidoRealizado.Click

        sql = " update solicitudrepartidor as solRep " & _
             " set solRep.estado = 'entregada' " & _
             " where solRep.codSR = '" & codSR & "'"
        Call x()

        frmEntregaCompletada.Show()
        Me.Close()
    End Sub

    Private Sub lblNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNombre.Click

    End Sub

    Private Sub frmDatosDomicilio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class