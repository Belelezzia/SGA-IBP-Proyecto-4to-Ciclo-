Imports Microsoft.Data.SqlClient

Public Class FormEnrollment

    Dim cadena As String = "Server=(localdb)\MSSQLLocalDB; Database=ModeloAcademico; Integrated Security=true; TrustServerCertificate=True"




    Private Sub FormEnrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If idSeleccionado <> 0 Then
            MessageBox.Show("Pulsa Nuevo antes de registrar otro alumno")
            Return
        End If
        If Not DatosValidos() Then Return

        Dim sqlPersona As String = "INSERT INTO Persona (id_tipo_doc_identidad, nro_documento, nombres, " &
                                   "apellido_pat, apellido_mat, fecha_nac, correo, telefono, direccion) " &
                                   "VALUES (@tipoDoc, @dni, @nombres, @apPat, @apMat, @fechaNac, " &
                                   "@correo, @telefono, @direccion); " &
                                   "SELECT CAST(SCOPE_IDENTITY() AS INT);"

        Dim sqlEstudiante As String = "INSERT INTO Estudiante (id_persona, fecha_ingreso, " &
                                      "id_turno, id_modalidad, id_carrera) " &
                                      "VALUES (@id, @fechaIngreso, @turno, @modalidad, @carrera)"

        Try
            Using connection As New SqlConnection(cadena)
                connection.Open()
                Using tx As SqlTransaction = connection.BeginTransaction()

                    Dim nuevoId As Integer

                    Using cmdPersona As New SqlCommand(sqlPersona, connection, tx)
                        AgregarParametros(cmdPersona)
                        nuevoId = CInt(cmdPersona.ExecuteScalar())
                    End Using

                    Using cmdEstudiante As New SqlCommand(sqlEstudiante, connection, tx)
                        AgregarParametros(cmdEstudiante)
                        cmdEstudiante.Parameters.Add("@id", SqlDbType.Int).Value = nuevoId
                        cmdEstudiante.ExecuteNonQuery()
                    End Using

                    tx.Commit()
                End Using
            End Using

            MessageBox.Show("Alumno registrado")
            CargarAlumnos("")
            LimpiarFormulario()

        Catch ex As SqlException
            ManejarErrorSql(ex)
        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message)
        End Try
    End Sub

End Class