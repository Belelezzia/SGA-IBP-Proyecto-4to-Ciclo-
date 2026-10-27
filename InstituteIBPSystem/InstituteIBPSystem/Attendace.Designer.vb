<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAttendance
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
        lblWelcome = New Label()
        Panel1 = New Panel()
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
        Panel3 = New Panel()
        Label9 = New Label()
        DataGridView1 = New DataGridView()
        Label7 = New Label()
        ComboBox4 = New ComboBox()
        Label5 = New Label()
        ComboBox2 = New ComboBox()
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label10 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        btnSave = New Button()
        Panel1.SuspendLayout()
        Panel17.SuspendLayout()
        Panel16.SuspendLayout()
        Panel15.SuspendLayout()
        Panel14.SuspendLayout()
        Panel13.SuspendLayout()
        Panel6.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = Color.Navy
        lblWelcome.Location = New Point(6, 7)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(158, 37)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Asistencias"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DimGray
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
        Panel1.Size = New Size(200, 450)
        Panel1.TabIndex = 7
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
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(lblWelcome)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(200, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(600, 50)
        Panel3.TabIndex = 10
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Navy
        Label9.Location = New Point(214, 144)
        Label9.Name = "Label9"
        Label9.Size = New Size(166, 20)
        Label9.TabIndex = 58
        Label9.Text = "LISTA DE ASISTENCIA:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(215, 167)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(573, 228)
        DataGridView1.TabIndex = 57
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(504, 108)
        Label7.Name = "Label7"
        Label7.Size = New Size(47, 17)
        Label7.TabIndex = 49
        Label7.Text = "Fecha:"
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(299, 105)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(189, 23)
        ComboBox4.TabIndex = 46
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(248, 108)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 17)
        Label5.TabIndex = 45
        Label5.Text = "Curso:"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(566, 73)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 42
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(504, 76)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 17)
        Label3.TabIndex = 41
        Label3.Text = "Sección:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(299, 73)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(189, 23)
        ComboBox1.TabIndex = 40
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(239, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 17)
        Label2.TabIndex = 39
        Label2.Text = "Carrera:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(557, 102)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(130, 23)
        DateTimePicker1.TabIndex = 60
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(230, 409)
        Label10.Name = "Label10"
        Label10.Size = New Size(81, 20)
        Label10.TabIndex = 61
        Label10.Text = "Presentes:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(338, 409)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 20)
        Label4.TabIndex = 62
        Label4.Text = "Tardanzas:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(446, 409)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 20)
        Label6.TabIndex = 63
        Label6.Text = "Faltas:"
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Navy
        btnSave.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(599, 409)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(88, 23)
        btnSave.TabIndex = 64
        btnSave.Text = "GUARDAR"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' FormAttendance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSave)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label10)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label9)
        Controls.Add(DataGridView1)
        Controls.Add(Label7)
        Controls.Add(ComboBox4)
        Controls.Add(Label5)
        Controls.Add(ComboBox2)
        Controls.Add(Label3)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Name = "FormAttendance"
        Text = "Attendace"
        Panel1.ResumeLayout(False)
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
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblWelcome As Label
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
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSave As Button
End Class
