Imports System.Data.Odbc
Module modulo
    Public cmd As OdbcCommand
    Public cnn As OdbcConnection
    Public rs As OdbcDataReader
    Public rs1 As OdbcDataReader
    Public sql As String
    Public rs2 As OdbcDataReader

    Public codP As Integer
    Public user As String
    Public zona As String
    Public codU As Integer
    Public nom As String
    Public borrado As Boolean
    Public codRep As Integer
    Public codZona As Integer
    Public codCliente As Integer
    Public codPersona As Integer

    Public bandera As Boolean
    Public bandera2 As Boolean

    Public Sub cargar(ByVal sql As String)
        cmd = New OdbcCommand(sql, modulo.cnn)
        cmd.CommandType = CommandType.Text
        rs = cmd.ExecuteReader()
        cmd.Dispose()
    End Sub


    Public Sub x()
        cmd = New OdbcCommand(Sql, modulo.cnn)
        cmd.CommandType = CommandType.Text
        rs = cmd.ExecuteReader()
        cmd.Dispose()
    End Sub

    Public Sub y()

        cmd = New OdbcCommand(Sql, modulo.cnn)
        cmd.CommandType = CommandType.Text
        If bandera2 = False Then
            rs = cmd.ExecuteReader()
            bandera2 = True
        Else
            rs2 = cmd.ExecuteReader()
        End If
        cmd.Dispose()

    End Sub

    Public Sub cargar1(ByVal sql As String)
        cmd = New OdbcCommand(sql, Modulo.cnn)
        cmd.CommandType = CommandType.Text
        rs1 = cmd.ExecuteReader()
        cmd.Dispose()
    End Sub

    Public Sub con()
        cnn = New OdbcConnection("dsn=cantinademuscio")
        cnn.Open()
    End Sub
End Module
