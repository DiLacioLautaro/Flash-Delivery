Public Class frmEspera
    'Formulario Programado Por Valentin Bertolini y diseñado por Valentina De Piero
    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        frmMenu.checkForPedido()
        Me.Hide()
        frmMenu.Show()

    End Sub

    Private Sub lstDesc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstDesc.SelectedIndexChanged

    End Sub

    Private Sub btninfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmEspera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class