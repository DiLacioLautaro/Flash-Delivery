Public Class frmAjustes
    Dim clickModif As Boolean = False
    Dim clickModif2 As Boolean = False
    'Formulario Programado Por Valentin Bertolini y diseñado por Valentina De Piero

    Private Sub btnModificar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar2.Click
        If clickModif2 = False Then

            Dim rta As Integer = MsgBox("desea hacer cambios de los datos de usuario?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "cambios")

            If rta = 1 Then 'respuesta si
                txtNick.Enabled = True
                txtPass.Enabled = True
                txtPass2.Enabled = True
         

                btnModificar2.Text = "Listo"

                clickModif2 = True
            End If

        Else
            txtNick.Enabled = False
            txtPass.Enabled = False
            txtPass2.Enabled = False

            If StrComp(txtNick.Text, "", 0) And StrComp(txtPass.Text, "", 0) And StrComp(txtPass2.Text, "", 0) And (txtPass.Text = txtPass2.Text) Then

                sql = "update usuario set nickname = '" & txtNick.Text & "' , password = '" & txtPass.Text & "' where codP = " & modulo.codP
                Call x()

                btnModificar2.Text = "Modificar"
                clickModif2 = False
            Else
                MsgBox("debe completar todos los campos y las contraseñas deben coincidir", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
                txtNick.Enabled = True
                txtPass.Enabled = True
                txtPass2.Enabled = True

            End If

        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        frmMenu.Show()

    End Sub


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If clickModif = False Then

            Dim rta As Integer = MsgBox("desea hacer cambios de datos personales?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "cambios")

            If rta = 1 Then 'respuesta si
                txtNom.Enabled = True
                txtApe.Enabled = True
                txtDirec.Enabled = True
                txtEmail.Enabled = True
                txtTel.Enabled = True

                btnModificar.Text = "Listo"

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
                " where per.codP = " & modulo.codP
                Call x()

                btnModificar.Text = "Modificar"
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

    Private Sub frmAjustes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class