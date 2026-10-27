Imports Microsoft.Data.SqlClient

Public Class FormLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim cadena As String = "Server=(localdb)\MSSQLLocalDB; Database=ModeloAcademico; Integrated Security=true; TrustServerCertificate=True"

        Dim consulta As String = "SELECT u.id_persona " &
                                 "FROM Persona p " &
                                 "INNER JOIN Usuarios u ON u.id_persona = p.id_persona " &
                                 "WHERE p.nro_documento = @dni AND u.contrasena = @contrasena"

        Try
            Using connection As New SqlConnection(cadena)
                Using command As New SqlCommand(consulta, connection)

                    command.Parameters.Add("@dni", SqlDbType.VarChar).Value = txtUser.Text
                    command.Parameters.Add("@contrasena", SqlDbType.VarChar).Value = txtPassword.Text

                    Dim adapter As New SqlDataAdapter(command)
                    Dim tabla As New DataTable()
                    adapter.Fill(tabla)

                    If tabla.Rows.Count = 0 Then
                        MessageBox.Show("DNI o Contraseña incorrectos")
                    Else
                        Dim frm As New FormStart()
                        Me.Hide()
                        frm.Show()
                    End If

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al conectar: " & ex.Message)
        End Try
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class