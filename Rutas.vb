Public Class Rutas
    Dim comando As New OleDb.OleDbCommand
    Dim adaptador As New OleDb.OleDbDataAdapter
    Dim registro As New DataSet

    Private Sub propietario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(PictureBox6, "En este campo se aceptan Letras, Numeros y Caracteres")

        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(PictureBox5, "En este Campo se aceptan Letras y Nùmeros y Caracteres ")

        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(PictureBox4, "En este campo solo se aceptan Letas")

        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(PictureBox7, "En este campo se aceptan Letras, Numeros y Caracteres")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescripcion.KeyPress
        If Char.IsLetter(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Buttonregi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonregi.Click
        If (Me.txtruta.Text = "") Then
            MsgBox("El campo no puede estar vacio", MsgBoxStyle.Critical, "Atencion")
            Me.txtruta.Select()


        Else


            Dim lineas As Integer
            Dim dess As String = ""
            Dim direccions As String = ""
            Dim paradas As String = ""


            lineas = Me.txtruta.Text
            dess = Me.txtdescripcion.Text
            direccions = Me.txtdir.Text
            paradas = Me.txtparada.Text

            cmd.CommandType = CommandType.Text
            cmd.Connection = conexion


            sql = " UPDATE Rutas SET "
            sql += " Descripcion = ' " & dess & " ' , "
            sql += " Direccion = ' " & direccions & " ' , "
            sql += " Paradas = ' " & paradas & " '  "
            sql += " WHERE Linea =  " & lineas & "  "



            cmd.CommandText = sql

            Try

                cmd.ExecuteNonQuery()
                MsgBox("Actualizacion Exitosa")
                Accion.Show()
                Me.Hide()


            Catch ex As Exception

                MsgBox(ex.ToString)


            End Try

        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (Me.txtruta.Text = "") Then
            MsgBox("El campo no puede estar vacio", MsgBoxStyle.Critical, "Atencion")
            Me.txtruta.Select()


        Else


            Dim linea As Integer
            Dim des As String = ""
            Dim direccion As String = ""
            Dim parada As String = ""


            linea = Me.txtruta.Text
            des = Me.txtdescripcion.Text
            direccion = Me.txtdescripcion.Text
            parada = Me.txtparada.Text


            cmd.CommandType = CommandType.Text
            cmd.Connection = conexion



            sql = "INSERT INTO Rutas (Linea, Descripcion, Direccion, Paradas)"
            sql += "VALUES (" & linea & " , '" & des & "' , '" & direccion & "' , '" & parada & "')"


            cmd.CommandText = sql

            Try

                cmd.ExecuteNonQuery()
                MsgBox("Registro Exitoso")
                Accion.Show()
                Me.Hide()

            Catch ex As Exception
                If ex.ToString.Contains("Valores repetidos") Then
                    MsgBox("Registro ya existe")
                Else

                End If

                MsgBox(ex.ToString)

            End Try

        End If
    End Sub

    Private Sub btnmo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Esta seguro que desea salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            Accion.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub
End Class