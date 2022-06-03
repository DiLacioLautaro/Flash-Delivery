Public Class frmUsuarioRepartidor

    Dim clickModif As Boolean = False
    'Formulario Programado Por Jaco Luna y diseñado por Valentina De Piero
    Private Sub btnSeguirBuscando_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeguirBuscando.Click
        Me.Close()
        frmBusquedaPedidos.Show()
    End Sub

    Private Sub btnModificarRepartidor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarRepartidor.Click

        If clickModif = False Then

            Dim rta As Integer = MsgBox("desea hacer cambios?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "cambios")

            If rta = 1 Then 'respuesta si
                txtNom.Enabled = True
                txtApe.Enabled = True
                txtDirec.Enabled = True
                txtEmail.Enabled = True
                txtTel.Enabled = True

                btnModificarRepartidor.Text = "Listo"

                clickModif = True
            End If

        Else
            txtNom.Enabled = False
            txtApe.Enabled = False
            txtDirec.Enabled = False
            txtEmail.Enabled = False
            txtTel.Enabled = False

            If StrComp(txtNom.Text, "", 0) And StrComp(txtApe.Text, "", 0) And StrComp(txtTel.Text, "", 0) And StrComp(txtDirec.Text, "", 0) And StrComp(txtEmail.Text, "", 0) Then

                sql =
                " update persona as per " & _
                " set per.nom = '" & txtNom.Text & "', per.ape = '" & txtApe.Text & "', per.tel = '" & txtTel.Text & "', per.direc = '" & txtDirec.Text & "', per.email = '" & txtEmail.Text & "' " & _
                " where per.codP = (select codP from repartidor where codR = '" & codRep & "') "
                Call x()

                btnModificarRepartidor.Text = "Modificar"
                clickModif = False
            Else
                MsgBox("debe completar todos los campos", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
                txtNom.Enabled = True
                txtApe.Enabled = True
                txtDirec.Enabled = True
                txtEmail.Enabled = True
                txtTel.Enabled = True
            End If
        End If
    End Sub

    Private Sub frmUsuarioRepartidor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtApe_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtApe.TextChanged

    End Sub

    Private Sub txtNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNom.TextChanged

    End Sub

    Private Sub txtTel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTel.TextChanged

    End Sub

    Private Sub txtDirec_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDirec.TextChanged

    End Sub

    Private Sub txtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.TextChanged

    End Sub
End Class