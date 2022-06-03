Imports System.Data.Odbc

Public Class frmRegisterCliente

    Dim sql As String
    Dim sql2 As String
    Dim codP As Integer
    Dim codU As Integer
    Dim codC As Integer
    Dim Fecha As Date

    'Formulario Programado Por Gabriel Benitez y diseñado por Valentina De Piero
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmRegisterCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sql = "select max(codP) as 'max' from persona"
        cargar(sql)
        While rs.Read = True
            Me.codP = rs(0) + 1
        End While

        sql = "select max(codUS) as 'max' from usuario"
        cargar(sql)
        While rs.Read = True
            Me.codU = rs(0) + 1
        End While

        sql = "select max(codC) as 'max' from cliente"
        cargar(sql)
        While rs.Read = True
            Me.codC = rs(0) + 1
        End While


        sql = "select nombre from zona order by nombre"
        modulo.cargar(sql)
        While rs.Read = True
            cbxZona.Items.Add(rs(0))
        End While

    End Sub



    Private Sub cbxTipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtDoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub cbxZona_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtTel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Register.Show()
    End Sub

    Private Sub lblFNac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblCorreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblTelefono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblDireccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblApellido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lbNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblDatosPersonales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub btnVolver_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        Register.Show()
    End Sub

    Private Sub btnRegistrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        If txtNombre.Text <> "" And txtApellido.Text <> "" And txtDireccion.Text <> "" And txtDoc.Text <> "" And txtEmail.Text <> "" And txtPass.Text <> "" And txtPass2.Text <> "" And txtTel.Text <> "" And txtUser.Text <> "" And cbxTipo.Text <> "" And cbxZona.Text <> "" Then

            sql = "select count(*) from persona where nroDoc = " & txtDoc.Text
            cargar(sql)

            rs.Read()

            If rs(0) = 0 Then

                If txtPass.Text = txtPass2.Text Then

                    Fecha = dtpFnac.Value

                    sql = "select codZ from zona where nombre='" & cbxZona.Text & "'"
                    cargar(sql)

                    While rs.Read = True
                        sql2 = "insert into persona values(" & Me.codP & ",'" & cbxTipo.Text & "'," & txtDoc.Text & ",'" & txtNombre.Text & "','" & txtApellido.Text & "','" & txtTel.Text & "','" & txtDireccion.Text & "','" & txtEmail.Text & "',0, '" & Format(Fecha, "yyyy-MM-dd") & "'," & rs(0) & ")"
                        cargar1(sql2)
                    End While

                    sql = "insert into usuario values(" & Me.codU & ",'" & txtUser.Text & "','" & txtPass.Text & "',curdate()," & codP & ")"
                    cargar(sql)


                    sql = "insert into cliente values(" & Me.codC & "," & Me.codP & ", 0)"
                    cargar(sql)

                    Me.Close()
                    Login.Show()

                Else

                    MsgBox("Las contraseñas deben coincidir!", MsgBoxStyle.Critical)

                End If

            Else

                MsgBox("El numero de documento ingresado ya está registrado, verifique el dato!", MsgBoxStyle.Critical)

            End If

        Else

            MsgBox("Debe completar todos los campos!", MsgBoxStyle.Critical)

        End If

    End Sub
End Class