Module Modulebd
    Public cmd As New OleDb.OleDbCommand
    Public dr As OleDb.OleDbDataReader
    Public conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=transbarcabd2.accdb;Persist Security Info=False")
    Public sql As String = ""

    Public Sub conectarse()

        Try
            conexion.Open()

        Catch ex As Exception
            MsgBox(ex. ToString)
        End Try



    End Sub



End Module
