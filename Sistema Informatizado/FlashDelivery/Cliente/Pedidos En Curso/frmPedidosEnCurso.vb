Imports System.Data.Odbc

Public Class frmPedidosEnCurso

    Dim x As Integer
    Dim sql As String
    Dim ds As New DataSet
    Dim da As New OdbcDataAdapter
    Public estadoPed As String
    Dim codR As Integer
    Dim nomrep, aperep, telrep As String
    Dim tipoveh, colorveh, marcaveh, modeloveh As String
    Dim tieneRep, tieneCon As Boolean

    'Formulario Programado Por Valentin Bertolini y diseñado por Valentina De Piero
    Private Sub frmPedidosEnCurso_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        checkForDelivery(frmMenu.codPed)
    End Sub

    Private Sub frmPedidosEnCurso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sql = "select dp.codE as 'codigo de elemento', e.descripcion as 'Articulo', e.pu as 'Precio Unitario', dp.cant as 'cantidad' from Pedido p, DetallePedido dp, elemento e where p.CodPED=dp.CodPED and dp.codE=e.codE and dp.codPED=" & frmMenu.codPed
        cargar(Sql)
        ds.Tables.Add("XX")
        da = New OdbcDataAdapter(Sql, cnn)
        da.Fill(ds.Tables("XX"))
        Me.dgvPedCurso.DataSource = ds.Tables("XX")
    End Sub

    Private Sub btnVolver_Click(sender As System.Object, e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        If (tieneRep) Then
            frmRepartidorPed.Close()
        End If
        frmMenu.Show()
    End Sub


    Private Sub frmPedidosEnCurso_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        checkForDelivery(frmMenu.codPed)
    End Sub

    Public Sub checkForDelivery(ByVal codPed As Integer)
        Me.lblSinRepartidor.Visible = False
        Me.lblSinConfirmacion.Visible = False
        tieneCon = False
        tieneRep = False
        sql = "select estado from pedido where codPED = " & frmMenu.codPed
        cargar(sql)
        While rs.Read = True
            If (rs(0).Equals("confirmado") Or rs(0).Equals("StockConfirmado")) Then
                tieneCon = True
            Else
                lblSinConfirmacion.Visible = True
            End If
        End While

        If (tieneCon) Then
            sql = "select codSAP,estado from solicitudatencionpedido where codPED = " & frmMenu.codPed
            cargar(sql)
            While rs.Read = True
                If (rs(1).Equals("pendiente") Or rs(1).Equals("cancelada")) Then
                    Me.lblSinRepartidor.Visible = True
                    tieneRep = False
                Else
                    frmRepartidorPed.Show()
                    tieneRep = True
                    sql = "select codR,estado from solicitudrepartidor where codSAP = " & rs(0)
                    cargar1(sql)
                    While rs1.Read = True
                        estadoPed = rs1(1).ToString
                        codR = rs1(0)
                    End While

                    sql = "select nom,ape,tel from persona,repartidor where repartidor.codP = persona.codP and repartidor.codR = " & codR
                    cargar1(sql)
                    While rs1.Read = True
                        nomrep = rs1(0).ToString
                        aperep = rs1(1).ToString
                        telrep = rs1(2).ToString
                    End While

                    sql = "select tipo,color,marca,modelo from vehiculoregistrado where codR = " & codR
                    cargar1(sql)
                    While rs1.Read = True
                        tipoveh = rs1(0).ToString
                        colorveh = rs1(1).ToString
                        marcaveh = rs1(2).ToString
                        modeloveh = rs1(3).ToString
                    End While
                    frmRepartidorPed.lblNombre.Text = nomrep
                    frmRepartidorPed.lblApe.Text = aperep
                    frmRepartidorPed.lblTel.Text = telrep
                    frmRepartidorPed.lblTipo.Text = tipoveh
                    frmRepartidorPed.lblMarca.Text = marcaveh
                    frmRepartidorPed.lblModelo.Text = modeloveh
                    frmRepartidorPed.lblColor.Text = colorveh
                    frmRepartidorPed.lblEstado.Text = estadoPed
                End If

            End While



        End If
      

    End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSinConfirmacion.Click

    End Sub

    Private Sub lblSinRepartidor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSinRepartidor.Click

    End Sub
End Class