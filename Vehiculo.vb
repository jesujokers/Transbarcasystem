Public Class Vehiculo
    Dim comando As New OleDb.OleDbCommand
    Dim adaptador As New OleDb.OleDbDataAdapter
    Dim registro As New DataSet

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Esta seguro que desea salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            Accion.Show()
            Me.Hide()
            txtserial.Text = ""
            txtmodelo.Text = ""
            txtdes.Text = ""
            cbxactivo.Items.Clear()

        End If
    End Sub
    Private Sub Vehiculo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(PictureBox4, "En este campo se aceptan Letras, Nùmeros y Caracteres")

        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(PictureBox5, "En este campo se aceptan Letras, Nùmeros y Caracteres")

        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(PictureBox6, "En este campo solo se puede escoger")

        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(PictureBox7, "En este campo solo se aceptan Letras")
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdes.KeyPress
        If Char.IsLetter(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregistrar.Click

        If (Me.txtserial.Text = "") Then
            MsgBox("El campo no puede estar vacio", MsgBoxStyle.Critical, "Atencion")
            Me.txtserial.Select()

        Else


            Dim serial As Integer
            Dim modelo As String = ""
            Dim activo As String = ""
            Dim descripcion As String = ""


            serial = Val(Me.txtserial.Text)
            modelo = Me.txtmodelo.Text
            activo = Me.cbxactivo.SelectedItem
            descripcion = Me.txtdes.Text


            cmd.CommandType = CommandType.Text
            cmd.Connection = conexion



            sql = "INSERT INTO Transbarca (Serial, Modelo, Activo, Descripcion)"
            sql += "VALUES (" & serial & " , '" & modelo & "' , '" & activo & "' , '" & descripcion & "')"


            cmd.CommandText = sql

            Try

                cmd.ExecuteNonQuery()
                MsgBox("Registro Exitoso")
                Accion.Show()
                Me.Hide()
                txtserial.Text = ""
                txtmodelo.Text = ""
                txtdes.Text = ""
                cbxactivo.Items.Clear()

            Catch ex As Exception
                If ex.ToString.Contains("Valores repetidos") Then
                    MsgBox("Registro ya existe")
                Else

                End If

                MsgBox(ex.ToString)

            End Try

        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        If (Me.txtserial.Text = "") Then
            MsgBox("El campo no puede estar vacio", MsgBoxStyle.Critical, "Atencion")
            Me.txtserial.Select()
        Else


            Dim serialx As Integer
            Dim modelox As String = ""
            Dim activox As String = ""
            Dim descripcionx As String = ""


            serialx = Me.txtserial.Text
            modelox = Me.txtmodelo.Text
            activox = Me.cbxactivo.SelectedItem
            descripcionx = Me.txtdes.Text


            cmd.CommandType = CommandType.Text
            cmd.Connection = conexion


            sql = " UPDATE Transbarca SET "
            sql += " Modelo = ' " & modelox & " ' , "
            sql += " Activo = ' " & activox & " ' , "
            sql += " Descripcion = ' " & descripcionx & " '  "
            sql += " WHERE Serial =  " & serialx & "  "



            cmd.CommandText = sql

            Try

                cmd.ExecuteNonQuery()
                MsgBox("Actualizacion Exitosa")
                Accion.Show()
                Me.Hide()
                txtserial.Text = ""
                txtmodelo.Text = ""
                txtdes.Text = ""
                cbxactivo.Items.Clear()

            Catch ex As Exception

                MsgBox(ex.ToString)


            End Try

        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub txtserial_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtserial.TextChanged

    End Sub
End Class