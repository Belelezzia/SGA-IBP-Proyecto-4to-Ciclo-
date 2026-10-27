<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IntroForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        ProgressBar1 = New ProgressBar()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Schoolbook", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(20, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(449, 32)
        Label1.TabIndex = 0
        Label1.Text = "Sistema de Gestión Académica"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Schoolbook", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(12, 252)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 16)
        Label2.TabIndex = 1
        Label2.Text = "Belezzia Espinoza"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(117, 175)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(235, 23)
        ProgressBar1.TabIndex = 2
        ' 
        ' IntroForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Navy
        ClientSize = New Size(481, 277)
        Controls.Add(ProgressBar1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "IntroForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar

End Class
