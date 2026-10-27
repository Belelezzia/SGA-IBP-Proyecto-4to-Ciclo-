<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        lbForgotPassword = New LinkLabel()
        Label2 = New Label()
        Label1 = New Label()
        btnLogin = New Button()
        txtPassword = New TextBox()
        txtUser = New TextBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbForgotPassword
        ' 
        lbForgotPassword.AutoSize = True
        lbForgotPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbForgotPassword.ForeColor = Color.Navy
        lbForgotPassword.Location = New Point(274, 373)
        lbForgotPassword.Name = "lbForgotPassword"
        lbForgotPassword.Size = New Size(143, 15)
        lbForgotPassword.TabIndex = 13
        lbForgotPassword.TabStop = True
        lbForgotPassword.Text = "Olvidaste tu contraseña?"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(274, 270)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 17)
        Label2.TabIndex = 12
        Label2.Text = "Contraseña:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(274, 231)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 17)
        Label1.TabIndex = 11
        Label1.Text = "Usuario:"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Navy
        btnLogin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = SystemColors.Control
        btnLogin.Location = New Point(330, 309)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(152, 44)
        btnLogin.TabIndex = 10
        btnLogin.Text = "Entrar"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.White
        txtPassword.Location = New Point(361, 267)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = "Ingrese contraseña"
        txtPassword.Size = New Size(166, 23)
        txtPassword.TabIndex = 9
        ' 
        ' txtUser
        ' 
        txtUser.BackColor = Color.White
        txtUser.Location = New Point(361, 227)
        txtUser.Name = "txtUser"
        txtUser.PlaceholderText = "Ingrese usuario"
        txtUser.Size = New Size(166, 23)
        txtUser.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Image = My.Resources.Resources.logo
        PictureBox1.Location = New Point(274, 73)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(253, 118)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(lbForgotPassword)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUser)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormLogin"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbForgotPassword As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
