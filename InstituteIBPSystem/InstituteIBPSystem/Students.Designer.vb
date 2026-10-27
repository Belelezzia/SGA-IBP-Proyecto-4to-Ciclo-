<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStudents
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label12 = New Label()
        PictureBox1 = New PictureBox()
        Panel18 = New Panel()
        Panel17 = New Panel()
        Label18 = New Label()
        Panel16 = New Panel()
        Label17 = New Label()
        Panel15 = New Panel()
        Label16 = New Label()
        Panel14 = New Panel()
        Label15 = New Label()
        Panel13 = New Panel()
        Label14 = New Label()
        Panel6 = New Panel()
        Label1 = New Label()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel2 = New Panel()
        dtgStudents = New DataGridView()
        Label2 = New Label()
        txtId = New TextBox()
        txtNames = New TextBox()
        Label3 = New Label()
        txtLastName = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        dtpStudents = New DateTimePicker()
        Label6 = New Label()
        txtMajor = New TextBox()
        txtPhone = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        txtMail = New TextBox()
        Label9 = New Label()
        txtTime = New TextBox()
        Label10 = New Label()
        txtMode = New TextBox()
        Label11 = New Label()
        btnEdit = New Button()
        btnSave = New Button()
        btnUpdate = New Button()
        lblWelcome = New Label()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel17.SuspendLayout()
        Panel16.SuspendLayout()
        Panel15.SuspendLayout()
        Panel14.SuspendLayout()
        Panel13.SuspendLayout()
        Panel6.SuspendLayout()
        Panel4.SuspendLayout()
        CType(dtgStudents, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DimGray
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Panel18)
        Panel1.Controls.Add(Panel17)
        Panel1.Controls.Add(Panel16)
        Panel1.Controls.Add(Panel15)
        Panel1.Controls.Add(Panel14)
        Panel1.Controls.Add(Panel13)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 410)
        Panel1.TabIndex = 7
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.White
        Label12.Location = New Point(49, 381)
        Label12.Name = "Label12"
        Label12.Size = New Size(105, 17)
        Label12.TabIndex = 2
        Label12.Text = "CERRAR SESIÓN"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(18, 377)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(25, 25)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Panel18
        ' 
        Panel18.Location = New Point(3, 409)
        Panel18.Name = "Panel18"
        Panel18.Size = New Size(200, 41)
        Panel18.TabIndex = 10
        ' 
        ' Panel17
        ' 
        Panel17.Controls.Add(Label18)
        Panel17.Cursor = Cursors.Hand
        Panel17.Dock = DockStyle.Top
        Panel17.Location = New Point(0, 308)
        Panel17.Name = "Panel17"
        Panel17.Size = New Size(200, 48)
        Panel17.TabIndex = 9
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.White
        Label18.Location = New Point(32, 5)
        Label18.Name = "Label18"
        Label18.Size = New Size(148, 37)
        Label18.TabIndex = 1
        Label18.Text = "REPORTES"
        ' 
        ' Panel16
        ' 
        Panel16.Controls.Add(Label17)
        Panel16.Cursor = Cursors.Hand
        Panel16.Dock = DockStyle.Top
        Panel16.Location = New Point(0, 260)
        Panel16.Name = "Panel16"
        Panel16.Size = New Size(200, 48)
        Panel16.TabIndex = 8
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = Color.White
        Label17.Location = New Point(9, 5)
        Label17.Name = "Label17"
        Label17.Size = New Size(186, 37)
        Label17.TabIndex = 1
        Label17.Text = "ASISTENCIAS"
        ' 
        ' Panel15
        ' 
        Panel15.Controls.Add(Label16)
        Panel15.Cursor = Cursors.Hand
        Panel15.Dock = DockStyle.Top
        Panel15.Location = New Point(0, 212)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(200, 48)
        Panel15.TabIndex = 7
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.White
        Label16.Location = New Point(47, 5)
        Label16.Name = "Label16"
        Label16.Size = New Size(105, 37)
        Label16.TabIndex = 1
        Label16.Text = "NOTAS"
        ' 
        ' Panel14
        ' 
        Panel14.Controls.Add(Label15)
        Panel14.Cursor = Cursors.Hand
        Panel14.Dock = DockStyle.Top
        Panel14.Location = New Point(0, 164)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(200, 48)
        Panel14.TabIndex = 6
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.White
        Label15.Location = New Point(5, 3)
        Label15.Name = "Label15"
        Label15.Size = New Size(190, 37)
        Label15.TabIndex = 1
        Label15.Text = "INSCRIPCION"
        ' 
        ' Panel13
        ' 
        Panel13.Controls.Add(Label14)
        Panel13.Cursor = Cursors.Hand
        Panel13.Dock = DockStyle.Top
        Panel13.Location = New Point(0, 116)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(200, 48)
        Panel13.TabIndex = 5
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.White
        Label14.Location = New Point(25, 5)
        Label14.Name = "Label14"
        Label14.Size = New Size(151, 37)
        Label14.TabIndex = 1
        Label14.Text = "ALUMNOS"
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(Label1)
        Panel6.Cursor = Cursors.Hand
        Panel6.Dock = DockStyle.Top
        Panel6.Location = New Point(0, 68)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(200, 48)
        Panel6.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(47, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 37)
        Label1.TabIndex = 1
        Label1.Text = "INICIO"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Panel5)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(200, 68)
        Panel4.TabIndex = 2
        ' 
        ' Panel5
        ' 
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(200, 68)
        Panel5.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(202, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 71)
        Panel2.TabIndex = 1
        ' 
        ' dtgStudents
        ' 
        dtgStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgStudents.Location = New Point(215, 234)
        dtgStudents.Name = "dtgStudents"
        dtgStudents.Size = New Size(573, 164)
        dtgStudents.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(226, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(24, 17)
        Label2.TabIndex = 10
        Label2.Text = "Id:"
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(253, 77)
        txtId.Name = "txtId"
        txtId.Size = New Size(63, 23)
        txtId.TabIndex = 11
        ' 
        ' txtNames
        ' 
        txtNames.Location = New Point(399, 78)
        txtNames.Name = "txtNames"
        txtNames.Size = New Size(146, 23)
        txtNames.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(325, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 17)
        Label3.TabIndex = 12
        Label3.Text = "Nombres:"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(632, 77)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(146, 23)
        txtLastName.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(556, 78)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 17)
        Label4.TabIndex = 14
        Label4.Text = "Apellidos:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(226, 110)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 17)
        Label5.TabIndex = 16
        Label5.Text = "Fecha N.:"
        ' 
        ' dtpStudents
        ' 
        dtpStudents.Location = New Point(297, 107)
        dtpStudents.Name = "dtpStudents"
        dtpStudents.Size = New Size(70, 23)
        dtpStudents.TabIndex = 17
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(373, 110)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 17)
        Label6.TabIndex = 18
        Label6.Text = "Carrera:"
        ' 
        ' txtMajor
        ' 
        txtMajor.Location = New Point(430, 107)
        txtMajor.Name = "txtMajor"
        txtMajor.Size = New Size(146, 23)
        txtMajor.TabIndex = 19
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(655, 107)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(123, 23)
        txtPhone.TabIndex = 21
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(583, 110)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 17)
        Label7.TabIndex = 20
        Label7.Text = "Teléfono:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Navy
        Label8.Location = New Point(409, 211)
        Label8.Name = "Label8"
        Label8.Size = New Size(180, 20)
        Label8.TabIndex = 22
        Label8.Text = "LISTA DE ESTUDIANTES:"
        ' 
        ' txtMail
        ' 
        txtMail.Location = New Point(282, 138)
        txtMail.Name = "txtMail"
        txtMail.Size = New Size(123, 23)
        txtMail.TabIndex = 24
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(226, 141)
        Label9.Name = "Label9"
        Label9.Size = New Size(53, 17)
        Label9.TabIndex = 23
        Label9.Text = "Correo:"
        ' 
        ' txtTime
        ' 
        txtTime.Location = New Point(466, 138)
        txtTime.Name = "txtTime"
        txtTime.Size = New Size(123, 23)
        txtTime.TabIndex = 26
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(410, 141)
        Label10.Name = "Label10"
        Label10.Size = New Size(48, 17)
        Label10.TabIndex = 25
        Label10.Text = "Turno:"
        ' 
        ' txtMode
        ' 
        txtMode.Location = New Point(655, 138)
        txtMode.Name = "txtMode"
        txtMode.Size = New Size(123, 23)
        txtMode.TabIndex = 28
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(599, 141)
        Label11.Name = "Label11"
        Label11.Size = New Size(53, 17)
        Label11.TabIndex = 27
        Label11.Text = "Estado:"
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.Navy
        btnEdit.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(354, 179)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(88, 23)
        btnEdit.TabIndex = 29
        btnEdit.Text = "EDITAR"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Navy
        btnSave.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(456, 179)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(88, 23)
        btnSave.TabIndex = 30
        btnSave.Text = "GUARDAR"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Navy
        btnUpdate.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(558, 179)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(88, 23)
        btnUpdate.TabIndex = 31
        btnUpdate.Text = "ACTUALIZAR"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = Color.Navy
        lblWelcome.Location = New Point(6, 7)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(164, 37)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Estudiantes"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(lblWelcome)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(200, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(600, 50)
        Panel3.TabIndex = 32
        ' 
        ' FormStudents
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 410)
        Controls.Add(Panel3)
        Controls.Add(btnUpdate)
        Controls.Add(btnSave)
        Controls.Add(btnEdit)
        Controls.Add(txtMode)
        Controls.Add(Label11)
        Controls.Add(txtTime)
        Controls.Add(Label10)
        Controls.Add(txtMail)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(txtPhone)
        Controls.Add(Label7)
        Controls.Add(txtMajor)
        Controls.Add(Label6)
        Controls.Add(dtpStudents)
        Controls.Add(Label5)
        Controls.Add(txtLastName)
        Controls.Add(Label4)
        Controls.Add(txtNames)
        Controls.Add(Label3)
        Controls.Add(txtId)
        Controls.Add(Label2)
        Controls.Add(dtgStudents)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormStudents"
        Text = "Users"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel17.ResumeLayout(False)
        Panel17.PerformLayout()
        Panel16.ResumeLayout(False)
        Panel16.PerformLayout()
        Panel15.ResumeLayout(False)
        Panel15.PerformLayout()
        Panel14.ResumeLayout(False)
        Panel14.PerformLayout()
        Panel13.ResumeLayout(False)
        Panel13.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel4.ResumeLayout(False)
        CType(dtgStudents, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtgStudents As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtNames As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpStudents As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMajor As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTime As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMode As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Panel3 As Panel
End Class
