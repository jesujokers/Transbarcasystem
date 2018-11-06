Public Class transportista
    Dim comando As New OleDb.OleDbCommand
    Dim adaptador As New OleDb.OleDbDataAdapter
    Dim registro As New DataSet

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Esta seguro que desea salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            Accion.Show()
            Me.Hide()
            txtcedula.Text = ""
            txtnombre.Text = ""
            txtapellido.Text = ""
            txtdireccion.Text = ""
            txttelefono.Text = ""
            cbssexo.Items.Clear()
            ComboBox1.Items.Clear()
        End If
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcedula.KeyDown
        If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue >= 96 And e.KeyValue <= 105) OrElse (e.KeyValue = 8) OrElse (e.KeyValue = 13)) Then
            e.Handled = True
            MsgBox("Error este campo acepta numeros solamente", MsgBoxStyle.Critical)
            txtcedula.Text = vbNullChar
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonregi.Click
        If txtcedula.TextLength < 6 Or txtcedula.TextLength > 9 Then
            MsgBox("Error la cedula no debe tener menos de 6 numeros ni mas de 9 numeros", MsgBoxStyle.Critical)
            txtcedula.Text = " "
            Me.txtcedula.Select()

        Else


            Dim cedula As Integer
            Dim nombre As String = ""
            Dim apellido As String = ""
            Dim sexo As String = ""
            Dim direccion As String = ""
            Dim telefono As String = ""

            cedula = Me.txtcedula.Text
            nombre = Me.txtnombre.Text
            apellido = Me.txtapellido.Text
            sexo = Me.cbssexo.SelectedItem
            direccion = Me.txtdireccion.Text
            telefono = Me.txttelefono.Text

            cmd.CommandType = CommandType.Text
            cmd.Connection = conexion



            sql = "INSERT INTO Choferes (Cedula, Nombres, Apellidos, Sexo, Direccion, Telefono)"
            sql += "VALUES (" & cedula & " , '" & nombre & "' , '" & apellido & "' , '" & sexo & "' , '" & direccion & "' , '" & telefono & "')"


            cmd.CommandText = sql

            Try

                cmd.ExecuteNonQuery()
                MsgBox("Registro Exitoso")
                Accion.Show()
                Me.Hide()
                txtcedula.Text = ""
                txtnombre.Text = ""
                txtapellido.Text = ""
                cbssexo.Items.Clear()
                txtdireccion.Text = ""
                txttelefono.Text = ""


            Catch ex As Exception

                MsgBox(ex.ToString)


            End Try
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        If Char.IsLetter(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtapellido.KeyPress
        If Char.IsLetter(e.KeyChar) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub transportista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(PictureBox4, "En este campo solo se aceptan Nùmeros")

        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(PictureBox5, "En este campo solo se aceptan Letras")

        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(PictureBox6, "En este campo solo se aceptan Letras")

        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(PictureBox7, "En este campo solo se puede escoger")

        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(PictureBox8, "En este campo se aceptan Letras, Numeros y Caracteres")

        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(PictureBox9, "En este campo se aceptan Letras, Numeros y Caracteres")


    End Sub

    Private Sub PictureBox8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox8.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtcedula.TextChanged

    End Sub

    Private Sub Buttonmodi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonmodi.Click
        If (Me.txtcedula.Text = "") Then
            MsgBox("El campo no puede estar vacio", MsgBoxStyle.Critical, "Atencion")
            Me.txtcedula.Select()
        Else

            Dim cedulas As Integer
            Dim nombres As String = ""
            Dim apellidos As String = ""
            Dim sexos As String = ""
            Dim direccions As String = ""
            Dim telefonos As String = ""

            cedulas = Me.txtcedula.Text
            nombres = Me.txtnombre.Text
            apellidos = Me.txtapellido.Text
            sexos = Me.cbssexo.SelectedItem
            direccions = Me.txtdireccion.Text
            telefonos = Me.txttelefono.Text


            cmd.CommandType = CommandType.Text
            cmd.Connection = conexion


            sql = " UPDATE Choferes SET "
            sql += " Nombres = ' " & nombres & " ' , "
            sql += " Apellidos = ' " & apellidos & " ' , "
            sql += " Sexo = ' " & sexos & " ' , "
            sql += " Direccion = ' " & direccions & " ' , "
            sql += " Telefono = ' " & telefonos & " '  "
            sql += " WHERE Cedula = " & cedulas & " "



            cmd.CommandText = sql

            Try

                cmd.ExecuteNonQuery()
                MsgBox("Actualizacion Exitosa")
                Accion.Show()
                Me.Hide()
                txtcedula.Text = ""
                txtnombre.Text = ""
                txtapellido.Text = ""
                cbssexo.Items.Clear()
                txtdireccion.Text = ""
                txttelefono.Text = ""

            Catch ex As Exception

                MsgBox(ex.ToString)


            End Try

        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim consulta As String
        Dim lista As Byte

        If (Me.txtcedula.Text = "") Then
            MsgBox("El campo no puede estar vacio", MsgBoxStyle.Critical, "Atencion")
            Me.txtcedula.Select()
        Else

            If txtcedula.Text <> "" Then
                consulta = "SELECT * FROM Choferes WHERE cedula = " & txtcedula.Text & ""
                adaptador = New OleDb.OleDbDataAdapter(consulta, conexion)
                registro = New DataSet
                adaptador.Fill(registro, "Choferes")
                lista = registro.Tables("Choferes").Rows.Count
            End If

            If lista <> 0 Then
                txtnombre.Text = registro.Tables("Choferes").Rows(0).Item("Nombres")
                txtapellido.Text = registro.Tables("Choferes").Rows(0).Item("Apellidos")
                cbssexo.Text = registro.Tables("Choferes").Rows(0).Item("Sexo")
                txtdireccion.Text = registro.Tables("Choferes").Rows(0).Item("Direccion")
                txttelefono.Text = registro.Tables("Choferes").Rows(0).Item("Telefono")

            End If
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

    End Sub
End Class