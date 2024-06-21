Imports System.Drawing.Drawing2D
Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private submissions As List(Of JObject)

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Make text boxes read-only to avoid cursor blink
        AddHandler btnPrevious.Paint, AddressOf OnButtonPaint
        AddHandler btnNext.Paint, AddressOf OnButtonPaint
        AddHandler btnSearch.Paint, AddressOf OnButtonPaint
        AddHandler btnEdit.Paint, AddressOf OnButtonPaint
        AddHandler btnDelete.Paint, AddressOf OnButtonPaint
        txtName.ReadOnly = True
        txtEmail.ReadOnly = True
        txtPhoneNumber.ReadOnly = True
        txtGithubLink.ReadOnly = True
        txtStopwatchTime.ReadOnly = True

        Await FetchSubmissionsAsync()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Async Function FetchSubmissionsAsync() As Task
        Dim baseUrl As String = "http://localhost:3000/"
        Dim json As String = ""

        Using client As New HttpClient()
            client.DefaultRequestHeaders.Accept.Add(New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

            Try
                ' Send GET request to fetch submissions
                Dim response As HttpResponseMessage = Await client.GetAsync(baseUrl & "read")

                If response.IsSuccessStatusCode Then
                    json = Await response.Content.ReadAsStringAsync()
                    Dim result As JObject = JsonConvert.DeserializeObject(Of JObject)(json)
                    submissions = result("submissions").ToObject(Of List(Of JObject))()
                Else
                    MessageBox.Show($"Failed to fetch submissions. Status code: {response.StatusCode}")
                End If
            Catch ex As Exception
                MessageBox.Show($"Error fetching submissions: {ex.Message}")
            End Try
        End Using
    End Function

    Private Sub DisplaySubmission(index As Integer)
        If submissions Is Nothing OrElse index < 0 OrElse index >= submissions.Count Then
            Return
        End If

        Dim submission = submissions(index)

        txtName.Text = submission("name").ToString()
        txtEmail.Text = submission("email").ToString()
        txtPhoneNumber.Text = submission("phone").ToString()
        txtGithubLink.Text = submission("github_link").ToString()
        txtStopwatchTime.Text = submission("stopwatch_time").ToString()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If submissions IsNot Nothing AndAlso currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Create an instance of the SearchSubmissionForm
        Dim searchForm As New SearchSubmissionForm()

        ' Show the form as a dialog and check if the user clicked the search button
        If searchForm.ShowDialog() = DialogResult.OK Then
            Dim email As String = searchForm.txtEmail.Text

            If String.IsNullOrEmpty(email) Then
                Return
            End If

            Try
                Dim baseUrl As String = "http://localhost:3000/"
                Dim client As New HttpClient()
                client.DefaultRequestHeaders.Accept.Add(New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

                Dim response As HttpResponseMessage = Await client.GetAsync(baseUrl & $"search?email={Uri.EscapeDataString(email)}")

                If response.IsSuccessStatusCode Then
                    Dim json As String = Await response.Content.ReadAsStringAsync()
                    Dim submission As JObject = JsonConvert.DeserializeObject(Of JObject)(json)

                    ' Find the index of the submission
                    Dim index As Integer = submissions.FindIndex(Function(s) s("email").ToString() = email)

                    If index >= 0 Then
                        currentIndex = index
                        DisplaySubmission(currentIndex)
                    Else
                        MessageBox.Show($"Submission with email '{email}' not found.")
                    End If
                Else
                    MessageBox.Show($"Ensure the email '{email}' is correct. Status code: {response.StatusCode}")
                End If
            Catch ex As Exception
                MessageBox.Show($"Error searching submission: {ex.Message}")
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If submissions IsNot Nothing AndAlso currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            Dim editForm As New EditSubmissionForm()
            editForm.SetSubmission(submissions(currentIndex))

            If editForm.ShowDialog() = DialogResult.OK Then
                ' Update the local submission with the edited one
                submissions(currentIndex) = editForm.GetUpdatedSubmission()

                ' Display the updated submission
                DisplaySubmission(currentIndex)
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If submissions IsNot Nothing AndAlso currentIndex >= 0 AndAlso currentIndex < submissions.Count Then
            ' Get the email of the current submission
            Dim email As String = submissions(currentIndex)("email").ToString()

            ' Show the delete submission form to confirm deletion
            Using deleteForm As New DeleteSubmissionForm(email)
                Dim result As DialogResult = deleteForm.ShowDialog()

                If result = DialogResult.OK Then
                    ' Delete the submission locally
                    submissions.RemoveAt(currentIndex)

                    ' Adjust currentIndex if needed
                    If currentIndex >= submissions.Count Then
                        currentIndex = submissions.Count - 1
                    End If

                    ' Display the next submission or clear the form if no submissions are left
                    If submissions.Count > 0 Then
                        DisplaySubmission(currentIndex)
                    Else
                        ClearFields()
                    End If
                End If
            End Using
        End If
    End Sub

    Private Sub ClearFields()
        txtName.Text = ""
        txtEmail.Text = ""
        txtPhoneNumber.Text = ""
        txtGithubLink.Text = ""
        txtStopwatchTime.Text = ""
    End Sub

    Private Sub OnButtonPaint(sender As Object, e As PaintEventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        ' Define the rectangle and the radius
        Dim rect As New Rectangle(0, 0, btn.Width, btn.Height)
        Dim radius As Integer = 20

        ' Create the path with rounded corners
        Dim path As New GraphicsPath()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()

        ' Set the button's region to the rounded rectangle
        btn.Region = New Region(path)

        ' Draw the border
        Using pen As New Pen(Color.Black, 4) ' Set pen thickness to 3 for a bolder border
            e.Graphics.DrawPath(pen, path)
        End Using
    End Sub

    Private Function HandleKey(keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.P) Then
            Invoke(Sub() btnPrevious.PerformClick())
            Return True
        ElseIf keyData = (Keys.Control Or Keys.N) Then
            Invoke(Sub() btnNext.PerformClick())
            Return True
        End If
        Return False
    End Function

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Return HandleKey(keyData)
    End Function
End Class
