Public Class Accion
    Private Sub CerrarSecionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSecionToolStripMenuItem.Click
        If MsgBox("Esta seguro que desea cerrar secion?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            Iniciar.Show()
            Me.Close()
        End If
    End Sub


    Private Sub SalirDelProgramaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirDelProgramaToolStripMenuItem.Click
        If MsgBox("Esta seguro que desea salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub

    Private Sub VerLaAyudaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VerLaAyudaToolStripMenuItem.Click
        ayuda.Show()
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuarioToolStripMenuItem.Click
        usuario.Show()
        usuario.Combosexo1.Items.Add("Hombre")
        usuario.Combosexo1.Items.Add("Mujer")
        usuario.ComboBox1.Items.Add("V-")
        usuario.ComboBox1.Items.Add("E-")
        Me.Hide()
        usuario.registrar.Visible = True
        usuario.modi.Visible = False
        usuario.btnconsultar.Visible = False
        Me.Hide()
    End Sub

    Private Sub TransportistaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransportistaToolStripMenuItem.Click
        usuario.Show()
        usuario.Combosexo1.Items.Add("Hombre")
        usuario.Combosexo1.Items.Add("Mujer")
        usuario.ComboBox1.Items.Add("V-")
        usuario.ComboBox1.Items.Add("E-")
        Me.Hide()
        usuario.btnconsultar.Visible = True
        usuario.registrar.Visible = False
        usuario.modi.Visible = False
        Me.Hide()
    End Sub

    Private Sub VehiculoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehiculoToolStripMenuItem.Click
        usuario.Show()
        usuario.Combosexo1.Items.Add("Hombre")
        usuario.Combosexo1.Items.Add("Mujer")
        usuario.ComboBox1.Items.Add("V-")
        usuario.ComboBox1.Items.Add("E-")
        Me.Hide()
        usuario.modi.Visible = True
        usuario.registrar.Visible = False
        usuario.btnconsultar.Visible = True
        Me.Hide()
    End Sub

    Private Sub PropietarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropietarioToolStripMenuItem.Click
        eliminar.Show()
        usuario.Combosexo1.Items.Add("Hombre")
        usuario.Combosexo1.Items.Add("Mujer")
        usuario.ComboBox1.Items.Add("V-")
        usuario.ComboBox1.Items.Add("E-")
        Me.Hide()
        eliminar.eliminarvehiculo.Visible = False
        eliminar.eliminarconductor.Visible = False
        eliminar.txtlinea2.Visible = False
        eliminar.cedula2.Visible = False
        eliminar.Label2.Visible = False
        eliminar.Label6.Visible = False
        eliminar.PictureBox5.Visible = False
        eliminar.PictureBox6.Visible = False
        eliminar.PictureBox7.Visible = False
        eliminar.Label3.Visible = False
        eliminar.Button1.Visible = False
        eliminar.TextBox1.Visible = False

        eliminar.Label5.Visible = True
        eliminar.Textcedula2.Visible = True
        eliminar.eliminarempleado.Visible = True
        eliminar.PictureBox4.Visible = True

    End Sub

    Private Sub EmpleadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadoToolStripMenuItem.Click
        transportista.Show()
        transportista.cbssexo.Items.Add("Hombre")
        transportista.cbssexo.Items.Add("Mujer")
        transportista.ComboBox1.Items.Add("V-")
        transportista.ComboBox1.Items.Add("E-")
        Me.Hide()
        transportista.Buttonregi.Visible = True
        transportista.Buttonmodi.Visible = False
        transportista.Button1.Visible = False

        Me.Hide()
    End Sub

    Private Sub VehiculoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehiculoToolStripMenuItem1.Click
        transportista.Show()
        transportista.cbssexo.Items.Add("Hombre")
        transportista.cbssexo.Items.Add("Mujer")
        transportista.ComboBox1.Items.Add("V-")
        transportista.ComboBox1.Items.Add("E-")
        Me.Hide()
        transportista.Buttonregi.Visible = False
        transportista.Buttonmodi.Visible = True
        transportista.Button1.Visible = True
        Me.Hide()
    End Sub

    Private Sub RutasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RutasToolStripMenuItem.Click
        eliminar.Show()
        Me.Hide()
        eliminar.Label6.Visible = False
        eliminar.Textcedula2.Visible = False
        eliminar.eliminarempleado.Visible = False
        eliminar.Label5.Visible = False
        eliminar.txtlinea2.Visible = False
        eliminar.eliminarvehiculo.Visible = False
        eliminar.PictureBox4.Visible = False
        eliminar.PictureBox5.Visible = False
        eliminar.PictureBox7.Visible = False
        eliminar.Label3.Visible = False
        eliminar.Button1.Visible = False
        eliminar.TextBox1.Visible = False

        eliminar.Label2.Visible = True
        eliminar.cedula2.Visible = True
        eliminar.eliminarconductor.Visible = True
        eliminar.PictureBox6.Visible = True
    End Sub

    Private Sub EmpleadoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadoToolStripMenuItem1.Click
        Vehiculo.Show()
        Vehiculo.cbxactivo.Items.Add("Si")
        Vehiculo.cbxactivo.Items.Add("No")
        Me.Hide()
        Vehiculo.btnmodificar.Visible = False
        Vehiculo.Button1.Visible = False
        Vehiculo.btnregistrar.Visible = True

    End Sub

    Private Sub TransportistaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransportistaToolStripMenuItem2.Click
        Vehiculo.cbxactivo.Items.Add("Si")
        Vehiculo.cbxactivo.Items.Add("No")
        Me.Hide()
        Vehiculo.btnmodificar.Visible = False
        Vehiculo.btnregistrar.Visible = False
        Vehiculo.Button1.Visible = True

    End Sub

    Private Sub VehiculoToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehiculoToolStripMenuItem2.Click
        Vehiculo.Show()
        Vehiculo.cbxactivo.Items.Add("Si")
        Vehiculo.cbxactivo.Items.Add("No")
        Me.Hide()
        Vehiculo.btnmodificar.Visible = True
        Vehiculo.btnregistrar.Visible = False
        Vehiculo.Button1.Visible = True

    End Sub

    Private Sub RutasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RutasToolStripMenuItem1.Click
        eliminar.Show()
        Me.Hide()
        eliminar.Label2.Visible = False
        eliminar.Textcedula2.Visible = False
        eliminar.eliminarempleado.Visible = False
        eliminar.Label5.Visible = False
        eliminar.cedula2.Visible = False
        eliminar.eliminarconductor.Visible = False
        eliminar.PictureBox4.Visible = False
        eliminar.PictureBox6.Visible = False
        eliminar.PictureBox7.Visible = False
        eliminar.Label3.Visible = False
        eliminar.Button1.Visible = False
        eliminar.TextBox1.Visible = False

        eliminar.Label6.Visible = True
        eliminar.txtlinea2.Visible = True
        eliminar.eliminarvehiculo.Visible = True
        eliminar.PictureBox5.Visible = True
        Me.Hide()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click

    End Sub

    Private Sub EmpleadoToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadoToolStripMenuItem2.Click
        Rutas.Show()
        Me.Hide()
        Rutas.Button1.Visible = True
        Rutas.Buttonregi.Visible = False
        Rutas.Button3.Visible = False

    End Sub

    Private Sub VehiculoToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehiculoToolStripMenuItem3.Click
        Rutas.Show()
        Me.Hide()
        Rutas.Button1.Visible = False
        Rutas.Buttonregi.Visible = True
        Rutas.Button3.Visible = True
    End Sub

    Private Sub TransportistaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransportistaToolStripMenuItem1.Click
        transportista.Show()
        transportista.cbssexo.Items.Add("Hombre")
        transportista.cbssexo.Items.Add("Mujer")
        transportista.ComboBox1.Items.Add("V-")
        transportista.ComboBox1.Items.Add("E-")
        Me.Hide()
        transportista.Buttonregi.Visible = False
        transportista.Buttonmodi.Visible = False
        transportista.Button1.Visible = True
    End Sub

    Private Sub RutasToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TransportistaToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransportistaToolStripMenuItem3.Click
        Rutas.Show()
        Me.Hide()
        Rutas.Button1.Visible = False
        Rutas.Buttonregi.Visible = False
        Rutas.Button3.Visible = True
    End Sub

    Private Sub LolToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        transportista.Show()
    End Sub

    Private Sub LolToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs)
        Vehiculo.Show()
    End Sub

    Private Sub LolToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs)
        Rutas.Show()
    End Sub

    Private Sub RegistrarToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles RegistrarToolStripMenuItem1.Click
        Form2.Show()
        Form2.cbssexo.Items.Add("Administrador")
        Form2.cbssexo.Items.Add("Usuario")
        Me.Hide()
        Form2.Button1.Visible = True
        Form2.Buttonmodi.Visible = False
        Form2.Button3.Visible = False
        Me.Hide()
    End Sub

    Private Sub ConsultarToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ConsultarToolStripMenuItem1.Click
        Form2.Show()
        Form2.cbssexo.Items.Add("Administrador")
        Form2.cbssexo.Items.Add("Usuario")
        Me.Hide()
        Form2.Button1.Visible = False
        Form2.Buttonmodi.Visible = False
        Form2.Button3.Visible = True
        Me.Hide()
    End Sub

    Private Sub ModificarToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ModificarToolStripMenuItem1.Click
        Form2.Show()
        Form2.cbssexo.Items.Add("Administrador")
        Form2.cbssexo.Items.Add("Usuario")
        Me.Hide()
        Form2.Button1.Visible = False
        Form2.Buttonmodi.Visible = True
        Form2.Button3.Visible = True
        Me.Hide()
    End Sub

    Private Sub EliminarToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem1.Click
        eliminar.Show()
        Me.Hide()
        eliminar.Label2.Visible = False
        eliminar.Textcedula2.Visible = False
        eliminar.eliminarempleado.Visible = False
        eliminar.Label5.Visible = False
        eliminar.cedula2.Visible = False
        eliminar.eliminarconductor.Visible = False
        eliminar.PictureBox4.Visible = False
        eliminar.PictureBox6.Visible = False
        eliminar.Label6.Visible = False
        eliminar.txtlinea2.Visible = False
        eliminar.eliminarvehiculo.Visible = False
        eliminar.PictureBox5.Visible = False

        eliminar.PictureBox7.Visible = True
        eliminar.Label3.Visible = True
        eliminar.Button1.Visible = True
        eliminar.TextBox1.Visible = True
        Me.Hide()
    End Sub

    Private Sub RegistrarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistrarToolStripMenuItem.Click

    End Sub
End Class