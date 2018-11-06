<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(usuario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Textcedula1 = New System.Windows.Forms.TextBox()
        Me.Textnombre1 = New System.Windows.Forms.TextBox()
        Me.Textapellido1 = New System.Windows.Forms.TextBox()
        Me.Textcargo1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.registrar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Textdir1 = New System.Windows.Forms.TextBox()
        Me.Texttlf1 = New System.Windows.Forms.TextBox()
        Me.Combosexo1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.modi = New System.Windows.Forms.Button()
        Me.btnconsultar = New System.Windows.Forms.Button()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Wide Latin", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 33)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Empleado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(184, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cedula:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(184, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nombres:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(184, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Apellidos:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(184, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Cargo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(182, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Sexo:"
        '
        'Textcedula1
        '
        Me.Textcedula1.Location = New System.Drawing.Point(280, 95)
        Me.Textcedula1.MaxLength = 8
        Me.Textcedula1.Name = "Textcedula1"
        Me.Textcedula1.Size = New System.Drawing.Size(100, 20)
        Me.Textcedula1.TabIndex = 13
        '
        'Textnombre1
        '
        Me.Textnombre1.Location = New System.Drawing.Point(280, 129)
        Me.Textnombre1.MaxLength = 30
        Me.Textnombre1.Name = "Textnombre1"
        Me.Textnombre1.Size = New System.Drawing.Size(100, 20)
        Me.Textnombre1.TabIndex = 14
        '
        'Textapellido1
        '
        Me.Textapellido1.Location = New System.Drawing.Point(280, 163)
        Me.Textapellido1.MaxLength = 30
        Me.Textapellido1.Name = "Textapellido1"
        Me.Textapellido1.Size = New System.Drawing.Size(100, 20)
        Me.Textapellido1.TabIndex = 15
        '
        'Textcargo1
        '
        Me.Textcargo1.Location = New System.Drawing.Point(280, 196)
        Me.Textcargo1.MaxLength = 30
        Me.Textcargo1.Name = "Textcargo1"
        Me.Textcargo1.Size = New System.Drawing.Size(100, 20)
        Me.Textcargo1.TabIndex = 16
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(233, 94)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(41, 23)
        Me.ComboBox1.TabIndex = 18
        '
        'registrar
        '
        Me.registrar.BackColor = System.Drawing.Color.Firebrick
        Me.registrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.registrar.ForeColor = System.Drawing.Color.Black
        Me.registrar.Location = New System.Drawing.Point(222, 307)
        Me.registrar.Name = "registrar"
        Me.registrar.Size = New System.Drawing.Size(63, 23)
        Me.registrar.TabIndex = 19
        Me.registrar.Text = "Registrar"
        Me.registrar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Firebrick
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(290, 341)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Atras"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(182, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Dirección:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(182, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Teléfono:"
        '
        'Textdir1
        '
        Me.Textdir1.Location = New System.Drawing.Point(280, 255)
        Me.Textdir1.MaxLength = 50
        Me.Textdir1.Name = "Textdir1"
        Me.Textdir1.Size = New System.Drawing.Size(100, 20)
        Me.Textdir1.TabIndex = 36
        '
        'Texttlf1
        '
        Me.Texttlf1.Location = New System.Drawing.Point(280, 281)
        Me.Texttlf1.MaxLength = 12
        Me.Texttlf1.Name = "Texttlf1"
        Me.Texttlf1.Size = New System.Drawing.Size(100, 20)
        Me.Texttlf1.TabIndex = 37
        '
        'Combosexo1
        '
        Me.Combosexo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combosexo1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Combosexo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combosexo1.FormattingEnabled = True
        Me.Combosexo1.Location = New System.Drawing.Point(280, 228)
        Me.Combosexo1.Name = "Combosexo1"
        Me.Combosexo1.Size = New System.Drawing.Size(100, 23)
        Me.Combosexo1.TabIndex = 40
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.TransbarcaSystem.My.Resources.Resources._4891b5f6c604304b74f030ce8a13f762_icono_de_signo_de_interrogaci_n_3d_rojo_by_vexels
        Me.PictureBox10.Location = New System.Drawing.Point(386, 279)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(33, 20)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 39
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.TransbarcaSystem.My.Resources.Resources._4891b5f6c604304b74f030ce8a13f762_icono_de_signo_de_interrogaci_n_3d_rojo_by_vexels
        Me.PictureBox9.Location = New System.Drawing.Point(385, 255)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(33, 20)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 38
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.TransbarcaSystem.My.Resources.Resources._4891b5f6c604304b74f030ce8a13f762_icono_de_signo_de_interrogaci_n_3d_rojo_by_vexels
        Me.PictureBox8.Location = New System.Drawing.Point(386, 226)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(33, 20)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 32
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.TransbarcaSystem.My.Resources.Resources._4891b5f6c604304b74f030ce8a13f762_icono_de_signo_de_interrogaci_n_3d_rojo_by_vexels
        Me.PictureBox7.Location = New System.Drawing.Point(386, 196)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(33, 20)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 31
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.TransbarcaSystem.My.Resources.Resources._4891b5f6c604304b74f030ce8a13f762_icono_de_signo_de_interrogaci_n_3d_rojo_by_vexels
        Me.PictureBox6.Location = New System.Drawing.Point(385, 163)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(33, 20)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 30
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.TransbarcaSystem.My.Resources.Resources._4891b5f6c604304b74f030ce8a13f762_icono_de_signo_de_interrogaci_n_3d_rojo_by_vexels
        Me.PictureBox5.Location = New System.Drawing.Point(385, 129)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(33, 20)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 29
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.TransbarcaSystem.My.Resources.Resources._4891b5f6c604304b74f030ce8a13f762_icono_de_signo_de_interrogaci_n_3d_rojo_by_vexels
        Me.PictureBox4.Location = New System.Drawing.Point(385, 95)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(33, 20)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 28
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(446, 295)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(79, 69)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TransbarcaSystem.My.Resources.Resources.bfc3bcbb9ca525fbf3d0179e239cfe96
        Me.PictureBox1.Location = New System.Drawing.Point(403, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(2, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(174, 373)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'modi
        '
        Me.modi.BackColor = System.Drawing.Color.Firebrick
        Me.modi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.modi.ForeColor = System.Drawing.Color.Black
        Me.modi.Location = New System.Drawing.Point(291, 307)
        Me.modi.Name = "modi"
        Me.modi.Size = New System.Drawing.Size(63, 23)
        Me.modi.TabIndex = 41
        Me.modi.Text = "Modificar"
        Me.modi.UseVisualStyleBackColor = False
        '
        'btnconsultar
        '
        Me.btnconsultar.BackColor = System.Drawing.Color.Firebrick
        Me.btnconsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnconsultar.ForeColor = System.Drawing.Color.Black
        Me.btnconsultar.Location = New System.Drawing.Point(368, 307)
        Me.btnconsultar.Name = "btnconsultar"
        Me.btnconsultar.Size = New System.Drawing.Size(63, 23)
        Me.btnconsultar.TabIndex = 42
        Me.btnconsultar.Text = "Consultar"
        Me.btnconsultar.UseVisualStyleBackColor = False
        '
        'usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(530, 377)
        Me.Controls.Add(Me.btnconsultar)
        Me.Controls.Add(Me.modi)
        Me.Controls.Add(Me.Combosexo1)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.Texttlf1)
        Me.Controls.Add(Me.Textdir1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.registrar)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Textcargo1)
        Me.Controls.Add(Me.Textapellido1)
        Me.Controls.Add(Me.Textnombre1)
        Me.Controls.Add(Me.Textcedula1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.ForeColor = System.Drawing.Color.Red
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleado"
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Textcedula1 As System.Windows.Forms.TextBox
    Friend WithEvents Textnombre1 As System.Windows.Forms.TextBox
    Friend WithEvents Textapellido1 As System.Windows.Forms.TextBox
    Friend WithEvents Textcargo1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents registrar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Textdir1 As System.Windows.Forms.TextBox
    Friend WithEvents Texttlf1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents Combosexo1 As System.Windows.Forms.ComboBox
    Friend WithEvents modi As System.Windows.Forms.Button
    Friend WithEvents btnconsultar As System.Windows.Forms.Button
End Class
