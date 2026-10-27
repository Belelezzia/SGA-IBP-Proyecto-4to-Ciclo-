Public Class FormStart
    Private Sub pStudents_Click(sender As Object, e As EventArgs) Handles pStudents.Click
        Dim newStudentForm As New FormStudents()
        newStudentForm.Show()

        Me.Hide()
    End Sub

    Private Sub pEnrollment_Click(sender As Object, e As EventArgs) Handles pEnrollment.Click
        Dim newEnrollmentForm As New FormEnrollment()
        newEnrollmentForm.Show()

        Me.Hide()
    End Sub

    Private Sub pSections_Click(sender As Object, e As EventArgs) Handles pSections.Click
        Dim newSectionsForm As New FormSections()
        newSectionsForm.Show()

        Me.Hide()
    End Sub

    Private Sub pGrades_Click(sender As Object, e As EventArgs) Handles pGrades.Click
        Dim newGradesForm As New FormGrades()
        newGradesForm.Show()

        Me.Hide()
    End Sub

    Private Sub pAttendace_Click(sender As Object, e As EventArgs) Handles pAttendace.Click
        Dim newAttendanceForm As New FormAttendance()
        newAttendanceForm.Show()

        Me.Hide()
    End Sub

    Private Sub pReports_Click(sender As Object, e As EventArgs) Handles pReports.Click
        Dim newReportsForm As New FormReports()
        newReportsForm.Show()

        Me.Hide()
    End Sub



    Private Sub psideStart_Click(sender As Object, e As EventArgs) Handles psideStart.Click
        Dim newStartForm As New FormStart()
        newStartForm.Show()

        Me.Hide()
    End Sub

    Private Sub psideStudents_Click(sender As Object, e As EventArgs) Handles psideStudents.Click
        Dim newStudentForm As New FormStudents()
        newStudentForm.Show()

        Me.Hide()
    End Sub

    Private Sub psideEnrollment_Click(sender As Object, e As EventArgs) Handles psideEnrollment.Click
        Dim newEnrollmentForm As New FormEnrollment()
        newEnrollmentForm.Show()

        Me.Hide()
    End Sub

    Private Sub psideGrades_Click(sender As Object, e As EventArgs) Handles psideGrades.Click
        Dim newGradesForm As New FormGrades()
        newGradesForm.Show()

        Me.Hide()
    End Sub

    Private Sub psideAttendace_Click(sender As Object, e As EventArgs) Handles psideAttendace.Click
        Dim newAttendanceForm As New FormAttendance()
        newAttendanceForm.Show()

        Me.Hide()
    End Sub

    Private Sub psideReports_Click(sender As Object, e As EventArgs) Handles psideReports.Click
        Dim newReportsForm As New FormReports()
        newReportsForm.Show()

        Me.Hide()
    End Sub
End Class