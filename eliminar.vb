Public Class eliminar

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Textcedula1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Textcedula2.TextChanged

    End Sub
    Private Sub Textcedula2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Textcedula2.KeyDown
        If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue >= 96 And e.KeyValue <= 105) OrElse (e.KeyValue = 8) OrElse (e.KeyValue = 13)) Then
            e.Handled = True
            MsgBox("Error este campo acepta numeros solamente", MsgBoxStyle.Critical)
            Textcedula2.Text = vbNullChar
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Esta seguro que desea salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            Accion.Show()
            Me.Hide()
            txtlinea2.Text = ""
            Textcedula2.Text = ""
            txtlinea2.Text = ""
            Me.Hide()

        End If
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminarempleado.Click
        If (Me.Textcedula2.Text = "") Then
            MsgBox("El campo no puede estar vacio", MsgBoxStyle.Critical, "Atencion")
            Me.Textcedula2.Select()
        Else

            Dim cedular As Integer
            cedular = Val(Me.Textcedula2.Text)

            cmd.CommandType = CommandType.Text
            cmd.Connection = conexion

            sql = "DELETE FROM Empleado WHERE cedula = " & cedular & " "


            cmd.CommandText = sql

            Try

                cmd.ExecuteNonQuery()

                MsgBox("Eliminado Exitosamente")
                Accion.Show()
                Me.Hide()
                Textcedula2.Text = ""


            Catch ex As Exception

                MsgBox(ex.ToString)


            End Try
        End If


    End Sub

    Private Sub eliminarvehiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminarvehiculo.Click

        Dim serial As Integer
        serial = Me.txtlinea2.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conexion

        sql = "DELETE FROM Transbarca WHERE serial = " & serial & " "


        cmd.CommandText = sql

        Try

            cmd.ExecuteNonQuery()

            MsgBox("Eliminado Exitosamente")
            Accion.Show()
            Me.Hide()
            txtlinea2.Text = ""


        Catch ex As Exception

            MsgBox(ex.ToString)


        End Try
    End Sub

    Private Sub eliminarconductor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminarconductor.Click
        Dim cedula As Integer

        cedula = Me.cedula2.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conexion

        sql = "DELETE FROM Choferes WHERE  cedula = " & cedula & " "


        cmd.CommandText = sql

        Try

            cmd.ExecuteNonQuery()

            MsgBox("Eliminado Exitosamente")
            Accion.Show()
            Me.Hide()
            cedula2.Text = ""

        Catch ex As Exception

            MsgBox(ex.ToString)


        End Try
    End Sub
    Private Sub cedula2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cedula2.TextChanged

    End Sub

    Private Sub cedula2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cedula2.KeyDown
        If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue >= 96 And e.KeyValue <= 105) OrElse (e.KeyValue = 8) OrElse (e.KeyValue = 13)) Then
            e.Handled = True
            MsgBox("Error este campo acepta numeros solamente", MsgBoxStyle.Critical)
            cedula2.Text = vbNullChar
        End If

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

    End Sub


    Private Sub eliminar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(PictureBox4, "En este campo solo se aceptan Nùmeros")
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(PictureBox5, "En este campo se aceptan Letras, Nùmeros y Caracteres")
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(PictureBox6, "En este campo solo se aceptan Nùmeros")
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(PictureBox7, "En este campo solo se aceptan Nùmeros")


    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub txtlinea2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtlinea2.TextChanged

    End Sub
    Private Sub Txtbox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue >= 96 And e.KeyValue <= 105) OrElse (e.KeyValue = 8) OrElse (e.KeyValue = 13)) Then
            e.Handled = True
            MsgBox("Error este campo acepta numeros solamente", MsgBoxStyle.Critical)
            TextBox1.Text = vbNullChar
        End If
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim cedula As Integer

        cedula = Me.TextBox1.Text

        cmd.CommandType = CommandType.Text
        cmd.Connection = conexion

        sql = "DELETE FROM usuario WHERE  cedula = " & cedula & " "


        cmd.CommandText = sql

        Try

            cmd.ExecuteNonQuery()

            MsgBox("Eliminado Exitosamente")
            Accion.Show()
            Me.Hide()
            TextBox1.Text = ""

        Catch ex As Exception

            MsgBox(ex.ToString)


        End Try
    End Sub
End Class