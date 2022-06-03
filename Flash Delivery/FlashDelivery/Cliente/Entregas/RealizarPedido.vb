Imports System.Data.Odbc
Public Class frmRealizarPed
    Public codLocal As Integer
    Dim ds As New DataSet
    Dim da As OdbcDataAdapter
    Public ds1 As New DataSet
    Public da1 As OdbcDataAdapter
    Public ds2 As New DataSet
    Public da2 As OdbcDataAdapter
    Dim ds2v As New DataSet
    Dim da2v As OdbcDataAdapter
    Dim sql As String
    Dim dsbu As New DataSet
    Dim dabu As OdbcDataAdapter
    Dim hay As Boolean
    Dim x As Integer

    'Formulario Programado Por Valentin Bertolini y diseñado por Valentina De Piero

    Private Sub dgvPedido_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPedido.CellContentClick
        Dim nombreElemento As String = dgvPedido.Rows(e.RowIndex).Cells("Elemento").Value.ToString
        Dim PU As Integer = dgvPedido.Rows(e.RowIndex).Cells("Precio").Value
        Dim cant As Integer = dgvPedido.Rows(e.RowIndex).Cells("Cantidad").Value

        sql = "Select codE from elemento where codLA = " & codLocal & " and descripcion = '" & nombreElemento & "' and PU = " & PU
        cargar(sql)
        While rs.Read = True
            sql = "update TempDetallePedido set cant = cant-1 where codE = " & rs(0)
            cargar1(sql)
        End While

        sql = "delete from TempDetallePedido where cant = 0"
        cargar(sql)

        dsbu.Tables.Clear()
        sql = "select TempDetallePedido.cant as 'Cantidad', elemento.descripcion as 'Elemento', TempDetallePedido.PU as 'Precio' from TempDetallePedido,elemento where TempDetallePedido.codE = elemento.codE"
        cargar(sql)
        dsbu.Tables.Add("XX3")
        dabu = New OdbcDataAdapter(sql, cnn)
        dabu.Fill(dsbu.Tables("XX3"))
        Me.dgvPedido.DataSource = dsbu.Tables("XX3")

        CalcularMonto()


    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text <> "" Then
            dsbu.Tables.Clear()
            sql = "select descripcion as Elemento,PU as Precio from Elemento where descripcion like '%" & txtBuscar.Text & "%' and codLA = " & codLocal
            cargar(Sql)
            dsbu.Tables.Add("XX")
            dabu = New OdbcDataAdapter(Sql, cnn)
            dabu.Fill(dsbu.Tables("XX"))
            Me.dgvElementos.DataSource = dsbu.Tables("XX")

        Else
            ds.Tables.Clear()
            sql = "select descripcion as Elemento,PU as Precio from Elemento where codLA = " & codLocal
            cargar(Sql)
            ds.Tables.Add("XX")
            da = New OdbcDataAdapter(Sql, cnn)
            da.Fill(ds.Tables("XX"))
            Me.dgvElementos.DataSource = ds.Tables("XX")
        End If
    End Sub

    Private Sub frmRealizarPed_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        dsbu.Tables.Clear()
        sql = "select TempDetallePedido.cant as 'Cantidad', elemento.descripcion as 'Elemento', TempDetallePedido.PU as 'Precio' from TempDetallePedido,elemento where TempDetallePedido.codE = elemento.codE"
        cargar(sql)
        dsbu.Tables.Add("XX3")
        dabu = New OdbcDataAdapter(sql, cnn)
        dabu.Fill(dsbu.Tables("XX3"))
        Me.dgvPedido.DataSource = dsbu.Tables("XX3")
    End Sub

    Private Sub frmRealizarPed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dsbu.Tables.Clear()
        sql = "truncate TempDetallePedido"
        cargar(sql)
        dsbu.Tables.Add("XX2")
        dabu = New OdbcDataAdapter(sql, cnn)
        dabu.Fill(dsbu.Tables("XX2"))
        Me.dgvPedido.DataSource = dsbu.Tables("XX2")
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Hide()
        frmLocalesNear.Show()
        txtBuscar.Text = ""
        lblMONTO.Text = ""
        dsbu.Tables.Clear()
    End Sub

    Private Sub dgvElementos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvElementos.CellContentClick
        Dim nombreElemento As String = dgvElementos.Rows(e.RowIndex).Cells("Elemento").Value.ToString
        Dim PU As Integer = dgvElementos.Rows(e.RowIndex).Cells("Precio").Value
        sql = "select codE from elemento where descripcion = '" & nombreElemento & "' and PU=" & PU & "  and codLa = " & codLocal
        cargar(sql)
        While rs.Read = True
            sql = "select count(*) from TempDetallePedido where codE = " & rs(0)
            cargar1(sql)
            While rs1.Read = True
                If rs1(0) = 0 Then
                    sql = "insert into TempDetallePedido values(''," & rs(0) & ",1," & PU & ")"
                    cargar(sql)
                Else
                    sql = "update TempDetallePedido set cant = cant + 1 where codE = " & rs(0)
                    cargar(sql)

                End If
            End While
        End While


        CalcularMonto()


        dsbu.Tables.Clear()
        sql = "select TempDetallePedido.cant as 'Cantidad', elemento.descripcion as 'Elemento', TempDetallePedido.PU as 'Precio' from TempDetallePedido,elemento where TempDetallePedido.codE = elemento.codE"
        cargar(sql)
        dsbu.Tables.Add("XX3")
        dabu = New OdbcDataAdapter(sql, cnn)
        dabu.Fill(dsbu.Tables("XX3"))
        Me.dgvPedido.DataSource = dsbu.Tables("XX3")

    End Sub

    Private Sub CalcularMonto()
        Dim monto As Double
        sql = "select PU,cant from TempDetallePedido "
        cargar(sql)
        While rs.Read = True
            monto = monto + rs(0) * rs(1)
        End While

        lblMONTO.Text = monto.ToString()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmarPed.Click
        Dim codPED As Integer
        sql = "select max(codPED) from Pedido"
        cargar1(sql)
        While rs1.Read = True
            codPED = Val(rs1(0)) + 1
        End While

        sql = "select count(*) from TempDetallePedido"
        cargar(sql)
        While rs.Read = True
            If rs(0) = 0 Then
                hay = False
                MsgBox("Seleccione Algun Articulo!")
            Else

                    sql = "insert into Pedido values(" & codPED & "," & modulo.codCliente & "," & codLocal & ",1,'" & Format(Date.Today, "yyyy/MM/dd") & "','" & Format(Date.Now, "HH:mm:ss") & "','','','pendiente')"
                    cargar1(sql)

                    Dim monto As Integer
                    sql = "select * from TempDetallePedido"
                    cargar(sql)
                    While rs.Read = True

                        Dim codDP As Integer
                        sql = "select max(codDP) from DetallePedido"
                        cargar1(sql)
                        If rs1.Read = True Then
                            codDP = rs1(0) + 1
                        End If

                        sql = "select descripcion from elemento where codE = " & rs(1)
                        cargar1(sql)
                        While rs1.Read = True
                            frmEspera.lstDesc.Items.Add(rs1(0).ToString)
                        End While

                        frmEspera.lstCant.Items.Add(Val(rs(2)))

                        frmEspera.lstMonto.Items.Add(Val(rs(2) * rs(3)))

                        monto = monto + rs(2) * rs(3)

                        sql = "insert into DetallePedido values(" & codDP & "," & codPED & "," & rs(1) & "," & rs(2) & "," & rs(3) & ")"
                        cargar1(sql)

                    End While

                    frmEspera.lblMonto.Text = monto.ToString
                    frmEspera.lblFormaPago.Text = "Efectivo"

                dsbu.Tables.Clear()
                sql = "truncate tempdetallepedido"
                cargar(sql)

                    frmMenu.checkForPedido()
                    Me.Hide()
                    frmEspera.Show()



            End If
        End While

    End Sub
End Class