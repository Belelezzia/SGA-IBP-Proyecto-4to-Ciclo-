Imports Microsoft.Data.SqlClient

Public Class FormStudents

    'Private ReadOnly cadena As String = "Server=(localdb)\MSSQLLocalDB; Database=ModeloAcademico; Integrated Security=true; TrustServerCertificate=True"

    'Private idSeleccionado As Integer = 0

    'Private Sub FormAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    CargarCombos()
    '    CargarAlumnos("")
    '    LimpiarFormulario()
    '    ActualizarFormulario()
    'End Sub

    'Private Sub CargarCombos()
    '    CargarCombo(cmbDocType, "Tipo_Documento_Identidad", "id_tipo_doc_identidad", "nombre_tipo")
    '    CargarCombo(cmbMajor, "Carrera", "id_carrera", "nombre_carrera")
    '    CargarCombo(cmbTime, "Turno", "id_turno", "nombre_turno")
    '    CargarCombo(cmbMode, "Modalidad", "id_modalidad", "nombre_modalidad")
    'End Sub













    '    

    '    

    '    Private Sub FormAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        CargarCombos()
    '        CargarAlumnos("")
    '        LimpiarFormulario()
    '    End Sub

    '    Private Sub CargarCombos()
    '        CargarCombo(cmbDocType, "Tipo_Documento_Identidad", "id_tipo_doc_identidad", "nombre_tipo")
    '        CargarCombo(cmbMajor, "Carrera", "id_carrera", "nombre_carrera")
    '        CargarCombo(cmbTime, "Turno", "id_turno", "nombre_turno")
    '        CargarCombo(cmbMode, "Modalidad", "id_modalidad", "nombre_modalidad")
    '    End Sub

    '    Private Sub CargarCombo(combo As ComboBox, tabla As String, columnaId As String, columnaNombre As String)
    '        Dim consulta As String = "SELECT " & columnaId & " AS id, " & columnaNombre & " AS nombre " &
    '                                 "FROM " & tabla & " ORDER BY " & columnaNombre
    '        Try
    '            Using connection As New SqlConnection(cadena)
    '                Using adapter As New SqlDataAdapter(consulta, connection)
    '                    Dim dt As New DataTable()
    '                    adapter.Fill(dt)
    '                    combo.DropDownStyle = ComboBoxStyle.DropDownList
    '                    combo.DisplayMember = "nombre"
    '                    combo.ValueMember = "id"
    '                    combo.DataSource = dt
    '                End Using
    '            End Using
    '        Catch ex As Exception
    '            MessageBox.Show("Error al cargar " & tabla & ": " & ex.Message)
    '        End Try
    '    End Sub


    '    Private Sub CargarAlumnos(filtro As String)

    '        Dim consulta As String = "SELECT p.id_persona AS Id, " &
    '                                 "       p.nro_documento AS DNI, " &
    '                                 "       p.apellido_pat + ' ' + p.apellido_mat AS Apellidos, " &
    '                                 "       p.nombres AS Nombres, " &
    '                                 "       c.nombre_carrera AS Carrera, " &
    '                                 "       t.nombre_turno AS Turno, " &
    '                                 "       m.nombre_modalidad AS Modalidad " &
    '                                 "FROM Estudiante e " &
    '                                 "INNER JOIN Persona p ON p.id_persona = e.id_persona " &
    '                                 "INNER JOIN Carrera c ON c.id_carrera = e.id_carrera " &
    '                                 "INNER JOIN Turno t ON t.id_turno = e.id_turno " &
    '                                 "INNER JOIN Modalidad m ON m.id_modalidad = e.id_modalidad " &
    '                                 "WHERE p.nro_documento LIKE @filtro " &
    '                                 "   OR p.apellido_pat LIKE @filtro " &
    '                                 "   OR p.nombres LIKE @filtro " &
    '                                 "ORDER BY p.apellido_pat, p.nombres"

    '        Try
    '            Using connection As New SqlConnection(cadena)
    '                Using command As New SqlCommand(consulta, connection)

    '                    command.Parameters.Add("@filtro", SqlDbType.VarChar).Value = "%" & filtro & "%"

    '                    Dim adapter As New SqlDataAdapter(command)
    '                    Dim tabla As New DataTable()
    '                    adapter.Fill(tabla)

    '                    dgvAlumnos.DataSource = tabla
    '                    dgvAlumnos.Columns("Id").Visible = False
    '                    lblTotal.Text = tabla.Rows.Count & " alumnos encontrados"

    '                End Using
    '            End Using
    '        Catch ex As Exception
    '            MessageBox.Show("Error al cargar alumnos: " & ex.Message)
    '        End Try

    '    End Sub

    '    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
    '        CargarAlumnos(txtSearchBar.Text.Trim())
    '    End Sub

    '    Private Sub dgvAlumnos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlumnos.CellClick
    '        If e.RowIndex < 0 Then Return
    '        Dim id As Integer = CInt(dgvAlumnos.Rows(e.RowIndex).Cells("Id").Value)
    '        CargarDetalle(id)
    '    End Sub

    '    Private Sub CargarDetalle(id As Integer)

    '        Dim consulta As String = "SELECT p.id_tipo_doc_identidad, p.nro_documento, p.nombres, " &
    '                                 "       p.apellido_pat, p.apellido_mat, p.fecha_nac, p.correo, " &
    '                                 "       p.telefono, p.direccion, e.fecha_ingreso, " &
    '                                 "       e.id_turno, e.id_modalidad, e.id_carrera " &
    '                                 "FROM Persona p " &
    '                                 "INNER JOIN Estudiante e ON e.id_persona = p.id_persona " &
    '                                 "WHERE p.id_persona = @id"

    '        Try
    '            Using connection As New SqlConnection(cadena)
    '                Using command As New SqlCommand(consulta, connection)

    '                    command.Parameters.Add("@id", SqlDbType.Int).Value = id
    '                    connection.Open()

    '                    Using reader As SqlDataReader = command.ExecuteReader()
    '                        If reader.Read() Then
    '                            idSeleccionado = id
    '                            cmbDocType.SelectedValue = CInt(reader("id_tipo_doc_identidad"))
    '                            txtDocNumb.Text = reader("nro_documento").ToString()
    '                            txtNombres.Text = reader("nombres").ToString()
    '                            txtApellidoP.Text = reader("apellido_pat").ToString()
    '                            txtApellidoM.Text = reader("apellido_mat").ToString()
    '                            dtpBirthDate.Value = CDate(reader("fecha_nac"))
    '                            txtMail.Text = reader("correo").ToString()
    '                            txtPhone.Text = reader("telefono").ToString()
    '                            txtDirection.Text = reader("direccion").ToString()
    '                            dtpDate.Value = CDate(reader("fecha_ingreso"))
    '                            cmbTime.SelectedValue = CInt(reader("id_turno"))
    '                            cmbMode.SelectedValue = CInt(reader("id_modalidad"))
    '                            cmbMajor.SelectedValue = CInt(reader("id_carrera"))
    '                        End If
    '                    End Using

    '                End Using
    '            End Using
    '        Catch ex As Exception
    '            MessageBox.Show("Error al cargar el alumno: " & ex.Message)
    '        End Try

    '    End Sub

    '    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
    '        If idSeleccionado <> 0 Then
    '            MessageBox.Show("Pulsa Nuevo antes de registrar otro alumno")
    '            Return
    '        End If
    '        If Not DatosValidos() Then Return

    '        Dim sqlPersona As String = "INSERT INTO Persona (id_tipo_doc_identidad, nro_documento, nombres, " &
    '                                   "apellido_pat, apellido_mat, fecha_nac, correo, telefono, direccion) " &
    '                                   "VALUES (@tipoDoc, @dni, @nombres, @apPat, @apMat, @fechaNac, " &
    '                                   "@correo, @telefono, @direccion); " &
    '                                   "SELECT CAST(SCOPE_IDENTITY() AS INT);"

    '        Dim sqlEstudiante As String = "INSERT INTO Estudiante (id_persona, fecha_ingreso, " &
    '                                      "id_turno, id_modalidad, id_carrera) " &
    '                                      "VALUES (@id, @fechaIngreso, @turno, @modalidad, @carrera)"

    '        Try
    '            Using connection As New SqlConnection(cadena)
    '                connection.Open()
    '                Using tx As SqlTransaction = connection.BeginTransaction()

    '                    Dim nuevoId As Integer

    '                    Using cmdPersona As New SqlCommand(sqlPersona, connection, tx)
    '                        AgregarParametros(cmdPersona)
    '                        nuevoId = CInt(cmdPersona.ExecuteScalar())
    '                    End Using

    '                    Using cmdEstudiante As New SqlCommand(sqlEstudiante, connection, tx)
    '                        AgregarParametros(cmdEstudiante)
    '                        cmdEstudiante.Parameters.Add("@id", SqlDbType.Int).Value = nuevoId
    '                        cmdEstudiante.ExecuteNonQuery()
    '                    End Using

    '                    tx.Commit()
    '                End Using
    '            End Using

    '            MessageBox.Show("Alumno registrado")
    '            txtSearchBar.Clear()
    '            CargarAlumnos("")
    '            LimpiarFormulario()

    '        Catch ex As SqlException
    '            ManejarErrorSql(ex)
    '        Catch ex As Exception
    '            MessageBox.Show("Error al guardar: " & ex.Message)
    '        End Try
    '    End Sub

    '    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
    '        If idSeleccionado = 0 Then
    '            MessageBox.Show("Selecciona un alumno de la tabla")
    '            Return
    '        End If
    '        If Not DatosValidos() Then Return

    '        Dim sqlPersona As String = "UPDATE Persona SET id_tipo_doc_identidad = @tipoDoc, " &
    '                                   "nro_documento = @dni, nombres = @nombres, apellido_pat = @apPat, " &
    '                                   "apellido_mat = @apMat, fecha_nac = @fechaNac, correo = @correo, " &
    '                                   "telefono = @telefono, direccion = @direccion " &
    '                                   "WHERE id_persona = @id"

    '        Dim sqlEstudiante As String = "UPDATE Estudiante SET fecha_ingreso = @fechaIngreso, " &
    '                                      "id_turno = @turno, " &
    '                                      "id_modalidad = @modalidad, id_carrera = @carrera " &
    '                                      "WHERE id_persona = @id"

    '        Try
    '            Using connection As New SqlConnection(cadena)
    '                connection.Open()
    '                Using tx As SqlTransaction = connection.BeginTransaction()

    '                    Using cmdPersona As New SqlCommand(sqlPersona, connection, tx)
    '                        AgregarParametros(cmdPersona)
    '                        cmdPersona.Parameters.Add("@id", SqlDbType.Int).Value = idSeleccionado
    '                        cmdPersona.ExecuteNonQuery()
    '                    End Using

    '                    Using cmdEstudiante As New SqlCommand(sqlEstudiante, connection, tx)
    '                        AgregarParametros(cmdEstudiante)
    '                        cmdEstudiante.Parameters.Add("@id", SqlDbType.Int).Value = idSeleccionado
    '                        cmdEstudiante.ExecuteNonQuery()
    '                    End Using

    '                    tx.Commit()
    '                End Using
    '            End Using

    '            MessageBox.Show("Alumno actualizado")
    '            txtSearchBar.Clear()
    '            CargarAlumnos("")
    '            LimpiarFormulario()

    '        Catch ex As SqlException
    '            ManejarErrorSql(ex)
    '        Catch ex As Exception
    '            MessageBox.Show("Error al actualizar: " & ex.Message)
    '        End Try
    '    End Sub

    '    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
    '        If idSeleccionado = 0 Then
    '            MessageBox.Show("Selecciona un alumno de la tabla")
    '            Return
    '        End If

    '        Dim respuesta As DialogResult = MessageBox.Show("¿Eliminar a este alumno? Esta acción no se puede deshacer.",
    '                                                        "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
    '        If respuesta <> DialogResult.Yes Then Return

    '        Try
    '            Using connection As New SqlConnection(cadena)
    '                connection.Open()
    '                Using tx As SqlTransaction = connection.BeginTransaction()

    '                    Using cmdEstudiante As New SqlCommand("DELETE FROM Estudiante WHERE id_persona = @id", connection, tx)
    '                        cmdEstudiante.Parameters.Add("@id", SqlDbType.Int).Value = idSeleccionado
    '                        cmdEstudiante.ExecuteNonQuery()
    '                    End Using

    '                    Using cmdPersona As New SqlCommand("DELETE FROM Persona WHERE id_persona = @id", connection, tx)
    '                        cmdPersona.Parameters.Add("@id", SqlDbType.Int).Value = idSeleccionado
    '                        cmdPersona.ExecuteNonQuery()
    '                    End Using

    '                    tx.Commit()
    '                End Using
    '            End Using

    '            MessageBox.Show("Alumno eliminado")
    '            txtSearchBar.Clear()
    '            CargarAlumnos("")
    '            LimpiarFormulario()

    '        Catch ex As SqlException
    '            ManejarErrorSql(ex)
    '        Catch ex As Exception
    '            MessageBox.Show("Error al eliminar: " & ex.Message)
    '        End Try
    '    End Sub

    '    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
    '        LimpiarFormulario()
    '    End Sub

    '    Private Sub LimpiarFormulario()
    '        idSeleccionado = 0
    '        txtDocNumb.Clear()
    '        txtNombres.Clear()
    '        txtApellidoP.Clear()
    '        txtApellidoM.Clear()
    '        txtMail.Clear()
    '        txtPhone.Clear()
    '        txtDirection.Clear()
    '        dtpBirthDate.Value = Date.Today
    '        dtpDate.Value = Date.Today
    '        cmbDocType.SelectedIndex = -1
    '        cmbMajor.SelectedIndex = -1
    '        cmbTime.SelectedIndex = -1
    '        cmbMode.SelectedIndex = -1
    '        dgvAlumnos.ClearSelection()
    '        txtDocNumb.Focus()
    '    End Sub


    '    Private Sub AgregarParametros(cmd As SqlCommand)
    '        cmd.Parameters.Add("@tipoDoc", SqlDbType.Int).Value = CInt(cmbDocType.SelectedValue)
    '        cmd.Parameters.Add("@dni", SqlDbType.VarChar).Value = txtDocNumb.Text.Trim()
    '        cmd.Parameters.Add("@nombres", SqlDbType.VarChar).Value = txtNombres.Text.Trim()
    '        cmd.Parameters.Add("@apPat", SqlDbType.VarChar).Value = txtApellidoP.Text.Trim()
    '        cmd.Parameters.Add("@apMat", SqlDbType.VarChar).Value = txtApellidoM.Text.Trim()
    '        cmd.Parameters.Add("@fechaNac", SqlDbType.Date).Value = dtpBirthDate.Value.Date
    '        cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = txtMail.Text.Trim()
    '        cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = ValorONulo(txtPhone.Text)
    '        cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = ValorONulo(txtDirection.Text)
    '        cmd.Parameters.Add("@fechaIngreso", SqlDbType.Date).Value = dtpDate.Value.Date
    '        cmd.Parameters.Add("@turno", SqlDbType.Int).Value = CInt(cmbTime.SelectedValue)
    '        cmd.Parameters.Add("@modalidad", SqlDbType.Int).Value = CInt(cmbMode.SelectedValue)
    '        cmd.Parameters.Add("@carrera", SqlDbType.Int).Value = CInt(cmbMajor.SelectedValue)
    '    End Sub


    '    Private Function ValorONulo(texto As String) As Object
    '        If String.IsNullOrWhiteSpace(texto) Then Return DBNull.Value
    '        Return texto.Trim()
    '    End Function

    '    Private Function DatosValidos() As Boolean

    '        If txtDocNumb.Text.Trim() = "" OrElse txtNombres.Text.Trim() = "" OrElse
    '           txtApellidoP.Text.Trim() = "" OrElse txtApellidoM.Text.Trim() = "" OrElse
    '           txtMail.Text.Trim() = "" Then
    '            MessageBox.Show("Completa el documento, los nombres, los apellidos y el correo")
    '            Return False
    '        End If

    '        If Not txtMail.Text.Contains("@") Then
    '            MessageBox.Show("El correo no es válido")
    '            Return False
    '        End If

    '        If cmbDocType.SelectedValue Is Nothing Then
    '            MessageBox.Show("Falta el tipo de documento")
    '            Return False
    '        End If

    '        If cmbMajor.SelectedValue Is Nothing Then
    '            MessageBox.Show("Falta la carrera")
    '            Return False
    '        End If

    '        If cmbTime.SelectedValue Is Nothing Then
    '            MessageBox.Show("Falta el turno")
    '            Return False
    '        End If

    '        If cmbMode.SelectedValue Is Nothing Then
    '            MessageBox.Show("Falta la modalidad")
    '            Return False
    '        End If

    '        If dtpBirthDate.Value.Date >= Date.Today Then
    '            MessageBox.Show("La fecha de nacimiento debe ser anterior a hoy")
    '            Return False
    '        End If

    '        Return True

    '    End Function

    '    Private Sub ManejarErrorSql(ex As SqlException)
    '        Select Case ex.Number
    '            Case 2627, 2601
    '                MessageBox.Show("Ya existe una persona con ese documento o ese correo")
    '            Case 547
    '                MessageBox.Show("No se puede completar la operación: el alumno tiene registros asociados " &
    '                                "(matrículas, pagos o usuario).")
    '            Case Else
    '                MessageBox.Show("Error de base de datos: " & ex.Message)
    '        End Select
    '    End Sub

    '    Private Sub FormAlumnos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    '        Application.Exit()
    '    End Sub



    'End Class
End Class