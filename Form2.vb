Public Class Form2
    Dim comando As New OleDb.OleDbCommand
    Dim adaptador As New OleDb.OleDbDataAdapter
    Dim registro As New DataSet

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If MsgBox("Esta seguro que desea salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            Accion.Show()
            cbssexo.Items.Clear()
            Textcedula2.Text = ""
            TextBox1.Text = ""
            Me.Hide()
        End If
    End Sub

    Private Sub Textcedula2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Textcedula2.KeyDown
        If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue >= 96 And e.KeyValue <= 105) OrElse (e.KeyValue = 8) OrElse (e.KeyValue = 13)) Then
            e.Handled = True
            MsgBox("Error este campo acepta numeros solamente", MsgBoxStyle.Critical)
            Textcedula2.Text = vbNullChar
        End If

    End Sub
    Private Sub propietario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(PictureBox3, "En este campo se aceptan Letras, Numeros y Caracteres")

        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(PictureBox4, "En este campo solo se aceptan Numeros")

        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(PictureBox6, "En este campo solo se puede escoger")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.TextLength < 6 Or TextBox1.TextLength > 9 Then
            MsgBox("Error la cedula no debe tener menos de 6 numeros ni mas de 9 numeros", MsgBoxStyle.Critical)
            TextBox1.Text = " "
            Me.TextBox1.Select()

        Else


            Dim Cedula As Integer
            Dim Clave As String = ""
            Dim Responsabilidad As String

            
            Cedula = Me.Textcedula2.Text
            Clave = Me.TextBox1.Text
            Responsabilidad = Me.cbssexo.Text

            cmd.CommandType = CommandType.Text
            cmd.Connection = conexion



            sql = "INSERT INTO usuario (Cedula, Clave, Responsabilidad)"
            sql += "VALUES ('" & Cedula & "' , '" & Clave & "', '" & Responsabilidad & "')"


            cmd.CommandText = sql

            Try

                cmd.ExecuteNonQuery()
                MsgBox("Registro Exitoso")
                Accion.Show()
                Me.Hide()
                Textcedula2.Text = ""
                TextBox1.Text = ""
                cbssexo.Items.Clear()


            Catch ex As Exception

                MsgBox(ex.ToString)


            End Try
        End If
    End Sub

    Private Sub Textcedula2_TextChanged(sender As System.Object, e As System.EventArgs) Handles Textcedula2.TextChanged
    End Sub

    Private Sub Buttonmodi_Click(sender As System.Object, e As System.EventArgs) Handles Buttonmodi.Click
        If (Me.TextBox1.Text = "") Then
            MsgBox("El campo no puede estar vacio", MsgBoxStyle.Critical, "Atencion")
            Me.TextBox1.Select()
        Else


            Dim Cedula As Integer
            Dim Clave As String = ""
            Dim Responsabilidad As String



            Cedula = Me.Textcedula2.Text
            Clave = Me.TextBox1.Text
            Responsabilidad = Me.cbssexo.SelectedItem



            cmd.CommandType = CommandType.Text
            cmd.Connection = conexion


            sql = " UPDATE usuario SET "
            sql += " Clave = ' " & Clave & " ' , "
            sql += " Responsabilidad = ' " & Responsabilidad & " '  "
            sql += " WHERE Cedula =  " & Cedula & "  "



            cmd.CommandText = sql

            Try

                cmd.ExecuteNonQuery()
                MsgBox("Actualizacion Exitosa")
                Accion.Show()
                Me.Hide()
                Textcedula2.Text = ""
                TextBox1.Text = ""
                cbssexo.Items.Clear()

            Catch ex As Exception

                MsgBox(ex.ToString)


            End Try

        End If
    End Sub
End Class