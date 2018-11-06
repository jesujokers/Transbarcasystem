Public Class usuario
        Dim comando As New OleDb.OleDbCommand
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim registro As New DataSet

        Private Property MaxLength As Integer

        Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Textcedula1.KeyDown
            If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue >= 96 And e.KeyValue <= 105) OrElse (e.KeyValue = 8) OrElse (e.KeyValue = 13)) Then
                e.Handled = True
                MsgBox("Error este campo acepta numeros solamente", MsgBoxStyle.Critical)
                Textcedula1.Text = vbNullChar
            End If
        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
            If MsgBox("Esta seguro que desea salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
                Accion.Show()
                Me.Hide()
                Textcedula1.Text = ""
                Textnombre1.Text = ""
                Textapellido1.Text = ""
                Textcargo1.Text = ""
                Textdir1.Text = ""
            Combosexo1.Items.Clear()
            ComboBox1.Items.Clear()
                Texttlf1.Text = ""
            End If
        End Sub
        Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub
        Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textnombre1.KeyPress
            If Char.IsLetter(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registrar.Click
            If (Me.Textcedula1.Text = "") Then
                MsgBox("El campo no puede estar vacio", MsgBoxStyle.Critical, "Atencion")
                Me.Textcedula1.Select()
            Else

                Dim cedula As Integer
                Dim nombre As String = ""
                Dim apellido As String = ""
                Dim cargo As String = ""
                Dim sexo As String = ""
                Dim direccion As String = ""
                Dim telefono As String = ""

                cedula = Me.Textcedula1.Text
                nombre = Me.Textnombre1.Text
                apellido = Me.Textapellido1.Text
                cargo = Me.Textcargo1.Text
                sexo = Me.Combosexo1.SelectedItem
                direccion = Me.Textdir1.Text
                telefono = Me.Texttlf1.Text

                cmd.CommandType = CommandType.Text
                cmd.Connection = conexion



                sql = "INSERT INTO Empleado (Cedula, Nombres, Apellidos, Cargo, Sexo, Direccion, Telefono)"
                sql += "VALUES (" & cedula & " , '" & nombre & "' , '" & apellido & "' , '" & cargo & "' , '" & sexo & "' , '" & direccion & "' , '" & telefono & "')"


                cmd.CommandText = sql

                Try

                    cmd.ExecuteNonQuery()
                    MsgBox("Registro Exitoso")
                    Accion.Show()
                    Me.Hide()
                    Textcedula1.Text = ""
                    Textnombre1.Text = ""
                    Textapellido1.Text = ""
                    Textcargo1.Text = ""
                    Textdir1.Text = ""
                    Combosexo1.Items.Clear()
                    ComboBox1.Items.Clear()
                    Texttlf1.Text = ""

                Catch ex As Exception
                    If ex.ToString.Contains("Valores repetidos") Then
                        MsgBox("Registro ya existe")
                    Else

                    End If

                    MsgBox(ex.ToString)


                End Try

            End If
        End Sub
        Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textapellido1.KeyPress
            If Char.IsLetter(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Textcargo1.KeyPress
            If Char.IsLetter(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion.Open()

            Me.ToolTip1.IsBalloon = True
            Me.ToolTip1.SetToolTip(PictureBox4, "En este campo solo se aceptan Nùmeros")

            Me.ToolTip1.IsBalloon = True
            Me.ToolTip1.SetToolTip(PictureBox5, "En este campo solo se aceptan Letras")

            Me.ToolTip1.IsBalloon = True
            Me.ToolTip1.SetToolTip(PictureBox6, "En este campo solo se aceptan Letras")

            Me.ToolTip1.IsBalloon = True
            Me.ToolTip1.SetToolTip(PictureBox7, "En este campo solo se aceptan Letras")

            Me.ToolTip1.IsBalloon = True
            Me.ToolTip1.SetToolTip(PictureBox8, "En este campo solo se puede escoger")

            Me.ToolTip1.IsBalloon = True
            Me.ToolTip1.SetToolTip(PictureBox9, "En este campo se aceptan Letras, Numeros y Caracteres")

            Me.ToolTip1.IsBalloon = True
            Me.ToolTip1.SetToolTip(PictureBox10, "En este campo se aceptan Letras, Numeros y Caracteres")

        End Sub

        Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modi.Click
            If (Me.Textcedula1.Text = "") Then
                MsgBox("El campo no puede estar vacio", MsgBoxStyle.Critical, "Atencion")
                Me.Textcedula1.Select()
            Else

                Dim cedulax As Integer
                Dim nombrex As String = ""
                Dim apellidox As String = ""
                Dim cargox As String = ""
                Dim sexox As String = ""
                Dim direccionx As String = ""
                Dim telefonox As String = ""

                cedulax = Me.Textcedula1.Text
                nombrex = Me.Textnombre1.Text
                apellidox = Me.Textapellido1.Text
                cargox = Me.Textcargo1.Text
                sexox = Me.Combosexo1.SelectedItem
                direccionx = Me.Textdir1.Text
                telefonox = Me.Texttlf1.Text

                cmd.CommandType = CommandType.Text
                cmd.Connection = conexion


                sql = " UPDATE Empleado SET "
                sql += " Nombres = ' " & nombrex & " ' , "
                sql += " Apellidos = ' " & apellidox & " ' , "
                sql += " Cargo = ' " & cargox & " ' , "
                sql += " Sexo = ' " & sexox & " ' , "
                sql += " Direccion = ' " & direccionx & " ' , "
                sql += " Telefono = ' " & telefonox & " '  "
                sql += " WHERE Cedula = " & cedulax & " "



                cmd.CommandText = sql

                Try

                    cmd.ExecuteNonQuery()
                    MsgBox("Actualizacion Exitosa")
                    Accion.Show()
                    Me.Hide()
                    Textcedula1.Text = ""
                    Textnombre1.Text = ""
                    Textapellido1.Text = ""
                    Textcargo1.Text = ""
                    Textdir1.Text = ""
                Combosexo1.Items.Clear()
                ComboBox1.Items.Clear()
                    Texttlf1.Text = ""

                Catch ex As Exception

                    MsgBox(ex.ToString)


                End Try

            End If
        End Sub

        Private Sub btnconsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultar.Click
        Dim consulta As String
        Dim lista As Byte

        If (Me.Textcedula1.Text = "") Then
            MsgBox("El campo no puede estar vacio", MsgBoxStyle.Critical, "Atencion")
            Me.Textcedula1.Select()
        Else

            If Textcedula1.Text <> "" Then
                consulta = "SELECT * FROM Empleado WHERE cedula = " & Textcedula1.Text & ""
                adaptador = New OleDb.OleDbDataAdapter(consulta, conexion)
                registro = New DataSet
                adaptador.Fill(registro, "Empleado")
                lista = registro.Tables("Empleado").Rows.Count
            Else
                MsgBox("El Registro no Existe", MsgBoxStyle.Critical, "Atencion")
            End If

            If lista <> 0 Then
                Textnombre1.Text = registro.Tables("Empleado").Rows(0).Item("Nombres")
                Textapellido1.Text = registro.Tables("Empleado").Rows(0).Item("Apellidos")
                Textcargo1.Text = registro.Tables("Empleado").Rows(0).Item("Cargo")
                Combosexo1.Text = registro.Tables("Empleado").Rows(0).Item("Sexo")
                Textdir1.Text = registro.Tables("Empleado").Rows(0).Item("Direccion")
                Texttlf1.Text = registro.Tables("Empleado").Rows(0).Item("Telefono")
           
            End If
        End If
    End Sub

        Private Sub Textcedula1_TextChanged(sender As System.Object, e As System.EventArgs) Handles Textcedula1.TextChanged

        End Sub
    End Class