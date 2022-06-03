Imports System.Data.Odbc

Public Class frmMenu

    Dim sql As String
    Public codPed As Integer
    Dim pedEnCurso As Boolean
    Dim estadoPed As String
    Dim horaPed As String
    Dim localPed As String

    'Formulario Programado Por Valentin Bertolini y diseñado por Valentina De Piero

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmLocalesNear.lblZona.Text = lblZona.Text
        Me.Hide()
        frmLocalesNear.Show()
    End Sub

    Private Sub frmMenu_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.checkForPedido()
    End Sub

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        checkForPedido()
    End Sub

    Public Sub checkForPedido()

        sql = "select count(*), l.nom, p.horapedido, p.codPED,p.estado from pedido p, localadherido l where l.codLA=p.codLA and (p.estado='pendiente' or p.estado='confirmado') and p.codC=" & modulo.codCliente & ""
        modulo.cargar1(sql)
        While rs1.Read = True

            If modulo.rs1(0) = 1 Then 'tiene 1 pedido

                pedEnCurso = True
                codPed = modulo.rs1(3)
                localPed = rs1(1)
                horaPed = rs1(2).ToString

                If (rs1(4) = "confirmado") Then
                    pedEnCurso = estaEnCurso(rs1(3))
                End If

            ElseIf modulo.rs1(0) > 1 Then
                Dim cont As Integer = 0
                Dim maxCont As Integer = modulo.rs1(0)
                sql = "select l.nom, p.horapedido, p.codPED,p.estado from pedido p, localadherido l where l.codLA=p.codLA and (p.estado='pendiente' or p.estado='confirmado') and p.codC=" & modulo.codCliente & ""
                cargar(sql)
                While rs.Read = True
                    cont = cont + 1
                    If cont = maxCont Then
                        pedEnCurso = True
                        codPed = rs(2)
                        localPed = rs(0)
                        horaPed = rs(1).ToString
                        If (rs(3) = "confirmado") Then
                            pedEnCurso = estaEnCurso(rs(2))
                        End If
                    End If
          

                End While

            ElseIf modulo.rs1(0) = 0 Then

                pedEnCurso = False

            End If

        End While



        If pedEnCurso = True Then
            lblHora.Text = horaPed
            lblLocal.Text = localPed
            grbPed.Visible = True
            grbPed.Enabled = True
            btnVerPed.Enabled = True
        Else
            grbPed.Visible = False
            grbPed.Enabled = False
            btnVerPed.Enabled = False
        End If

    End Sub

    Public Function estaEnCurso(ByVal codPed As Integer)
        Dim EnCurso As Boolean = True

        sql = "select count(*),codSAP,estado from solicitudatencionpedido where codPED = " & codPed & " and (estado = 'pendiente' or estado = 'aceptada')"
        cargar1(sql)
        While rs1.Read = True
            If (rs1(0) = 1) Then 'solicitud atencion pedido aceptada
                If rs1(2) = "aceptada" Then
                    sql = "select count(*),estado from solicitudrepartidor where codSAP = " & codPed & " and (estado <> 'entregada' and estado <> 'cancelada')"
                    cargar(sql)
                    While rs.Read = True
                        If (rs(0) = 1) Then 'ESTA EN CURSO
                            EnCurso = True
                            estadoPed = rs(1)
                        Else 'ESTA FINALIZADO EL PEDIDO
                            EnCurso = False
                        End If
                    End While
                End If
            End If
        End While

        Return EnCurso
    End Function

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Me.Hide()
        Login.Show()
        Login.txtContraseña.Text = ""
        Login.txtUsuario.Text = ""
    End Sub

    Private Sub btnPedCurso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        frmPedidosEnCurso.Show()
    End Sub


    Private Sub btnVerPed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerPed.Click
        Me.Hide()
        frmPedidosEnCurso.Show()
    End Sub


    Private Sub btnRealizarPed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRealizarPed.Click
        If (grbPed.Visible = False) Then
            frmLocalesNear.lblZona.Text = lblZona.Text
            frmLocalesNear.cargarRestaurantes()
            Me.Hide()
            frmLocalesNear.Show()
        Else
            MsgBox("TIENES UN PEDIDO EN CURSO!", MsgBoxStyle.Critical)
        End If


    End Sub


    Private Sub abm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        ABMVehiculoRegistrado.Show()
    End Sub

    Private Sub btnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUser.Click

        sql = "select nom,ape,tel,direc,email from persona where codP = " & modulo.codP
        cargar(sql)
        While rs.Read = True
            frmAjustes.txtNom.Text = rs(0).ToString
            frmAjustes.txtApe.Text = rs(1).ToString
            frmAjustes.txtTel.Text = rs(2).ToString
            frmAjustes.txtDirec.Text = rs(3).ToString
            frmAjustes.txtEmail.Text = rs(4).ToString
        End While

        sql = "select nickname,password from usuario where codP = " & modulo.codP
        cargar(sql)
        While rs.Read = True
            frmAjustes.txtNick.Text = rs(0).ToString
            frmAjustes.txtPass.Text = rs(1).ToString
            frmAjustes.txtPass2.Text() = rs(1).ToString
        End While

        Me.Hide()
        frmAjustes.Show()
    End Sub
End Class