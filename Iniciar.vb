Imports System.Data.OleDb
Imports System.Data

Public Class Iniciar

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Esta seguro que desea salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            Me.Close()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Esta seguro que desea salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            Me.Close()
            conexion.Close()

        End If
    End Sub
    Private Sub Clave_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Claves.KeyDown
        If (Me.Usuario.Text = "" And Me.Claves.Text = "") Then
            MsgBox("El o los campo no puede estar vacio", MsgBoxStyle.Critical, "Atencion")
            Me.Usuario.Select()

        Else
            Dim cedula As Integer
            Dim Clave As String

            cedula = Me.Usuario.Text
            Clave = Me.Claves.Text


            Select Case e.KeyData
                Case Keys.Enter
                    If Usuario.Text = cedula And Clave = Claves.Text Then
                        Accion.Show()
                        Me.Hide()
                        Usuario.Text = ""
                        Claves.Text = ""
                    Else
                        MsgBox("Usuario o Contaseña Incorrecta", vbOKOnly, "Error")
                        Usuario.Text = ""
                        Claves.Text = ""
                    End If


            End Select
        End If
    End Sub


    Private Sub Iniciar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Combosexo1.Items.Add("Administrador")
        Me.Combosexo1.Items.Add("Usuario")
    End Sub



    Private Sub Secion_Click(sender As System.Object, e As System.EventArgs) Handles Secion.Click
        Dim cedula As Integer
        Dim clave As String

        If (Me.Usuario.Text = "" And Me.Claves.Text = "") Then
            MsgBox("El o los campo no puede estar vacio", MsgBoxStyle.Critical, "Atencion")
            Me.Usuario.Select()

        Else

            cedula = Me.Usuario.Text
            clave = Me.Claves.Text


            If Usuario.Text = cedula And Claves.Text = clave Then
                Accion.Show()
                Me.Hide()
                Usuario.Text = ""
                Claves.Text = ""
            Else
                MsgBox("Usuario o Contaseña Incorrecta", vbOKOnly, "Error")
                Usuario.Text = ""
                Claves.Text = ""
            End If
        End If
    End Sub
End Class


