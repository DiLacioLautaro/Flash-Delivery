Public Class frmEntregaCompletada
    'Formulario Programado Por Jaco Luna y diseñado por Valentina De Piero
    Private Sub frmEntregaCompletada_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnListaPedidos_Click(sender As System.Object, e As System.EventArgs) Handles btnListaPedidos.Click
        frmBusquedaPedidos.Show()
        Me.Close()

    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class