Imports System.Data.Odbc

Public Class ABMZona

    Dim sql As String
    Dim sql2 As String
    Dim codP As Integer
    Dim codU As Integer
    Dim codR As Integer
    Dim FechaNac As Date
    Dim FechaEx As Date

    'Formulario Programado Por Valentin Bertolini y diseñado por Valentina De Piero

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAzona.Click
        If (txtZonaA.Text <> "") Then
            sql = "select count(*) from zona where nombre = '" & txtZonaA.Text & "'"
            cargar(sql)
            While rs.Read = True
                If (rs(0) = 0) Then
                    sql = "select max(codZ) from zona"
                    cargar(sql)
                    While rs.Read = True
                        sql = "insert into zona values(" & rs(0) + 1 & ",'" & txtZonaA.Text & "')"
                        cargar1(sql)
                        MsgBox("Zona Cargada Correctamente!")
                        txtZonaA.Text = ""
                        loadZonas()
                    End While

                Else
                    MsgBox("Zona Ya Existente!", MsgBoxStyle.Critical)
                End If
            End While

        Else
            MsgBox("Ingrese una zona!")
        End If
    End Sub

    Private Sub ABMZona_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadZonas()
    End Sub

    Private Sub loadZonas()
        cbxZonaB.Items.Clear()
        cbxZonaM.Items.Clear()

        sql = "select nombre from zona order by nombre"
        modulo.cargar(sql)
        While rs.Read = True
            cbxZonaM.Items.Add(rs(0))
            cbxZonaB.Items.Add(rs(0))
        End While
    End Sub


    Private Sub btnMzona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMzona.Click
        If (cbxZonaM.Text <> "") Then
            sql = "select count(*) from zona where nombre = '" & txtZonaM.Text & "'"
            cargar(sql)
            While rs.Read = True
                If (rs(0) = 0) Then
                    sql = "update zona set nombre = '" & txtZonaM.Text & "' where nombre = '" & cbxZonaM.Text & "'"
                    cargar(sql)
                    MsgBox("Zona Actualizada Correctamente!")
                    txtZonaM.Text = ""
                    cbxZonaM.Text = ""
                    loadZonas()
                Else
                    MsgBox("Zona Ya Existente!", MsgBoxStyle.Critical)
                End If
            End While
        Else
            MsgBox("Seleccione una zona!")
        End If
    End Sub

    Private Sub btnBzona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBzona.Click
        If (cbxZonaB.Text <> "") Then
            sql = "delete from zona where nombre = '" & cbxZonaB.Text & "'"
            cargar(sql)
            MsgBox("Zona Borrada Correctamente!")
            cbxZonaB.Text = ""
            loadZonas()
        Else
            MsgBox("Seleccione una zona!")

        End If

    End Sub
End Class