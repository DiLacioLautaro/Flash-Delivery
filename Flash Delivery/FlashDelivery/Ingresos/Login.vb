Imports System.Data.Odbc
Public Class Login
    Dim sql As String
    Public sqlid As String
    Public rsid As OdbcDataReader
    Public UsuarioActual As String
    Public permiso As String

    'Formulario Programado Por Valentin Bertolini y diseñado por Valentina De Piero

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cnn = New OdbcConnection("DSN=flash_delivery")
            cnn.Open()
            MsgBox("Conexion Satisfactoria")
        Catch ex As Exception
            MsgBox("Fallo la conexion")
        End Try
    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        modulo.codZona = 0
        modulo.codP = 0
        modulo.codCliente = 0
        If txtUsuario.Text = "" Or txtContraseña.Text = "" Then
            MsgBox("No deje campos vacios", MsgBoxStyle.Exclamation, "error")
        Else
            sql = "select count(*),codP,nickname from usuario where nickname='" & txtUsuario.Text & "' and password='" & txtContraseña.Text & "'"

            modulo.cargar(sql)
            While modulo.rs.Read = True
                If modulo.rs(0) = 0 Then
                    MsgBox("Los datos son incorrectos.", MsgBoxStyle.Exclamation, "error")
                Else
                    modulo.codP = modulo.rs(1)
                    frmMenu.lblUser.Text = modulo.rs(2)

                    sql = "select persona.codZ,zona.nombre from persona,zona where zona.codZ = persona.codZ and persona.codP = " & rs(1)
                    cargar1(sql)
                    While rs1.Read = True
                        modulo.codZona = rs1(0)
                        frmMenu.lblZona.Text = rs1(1)
                    End While

                    sql = "select count(*), codR from repartidor where codP = " & rs(1)
                    modulo.cargar1(sql)
                    While modulo.rs1.Read = True
                        If (rs1(0) = 1) Then
                            modulo.codRep = rs1(1)
                            Me.Hide()
                            frmBusquedaPedidos.Show()
                        Else

                            sql = "select count(*),codC from cliente where codP = " & rs(1)
                            cargar1(sql)
                            While rs1.Read = True
                                If (rs1(0) = 1) Then
                                    modulo.codCliente = rs1(1)
                                    Me.Hide()
                                    frmMenu.Show()
                                    frmMenu.checkForPedido()
                                End If
                            End While
                        End If
                    End While

                    txtUsuario.Text = ""
                    txtContraseña.Text = ""


                End If

            End While

        End If

    End Sub

    Private Sub btnVer_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnVer.MouseMove
        txtContraseña.UseSystemPasswordChar = False
    End Sub

    Private Sub btnVer_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnVer.MouseLeave
        txtContraseña.UseSystemPasswordChar = True
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Me.Hide()
        Register.Show()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtContraseña_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContraseña.TextChanged

    End Sub
End Class
