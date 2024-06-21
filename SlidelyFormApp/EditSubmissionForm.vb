Imports System.Drawing.Drawing2D
Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class EditSubmissionForm
    Private _submission As JObject

    Private Sub EditSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Handle button painting for custom appearance
        AddHandler btnSave.Paint, AddressOf OnButtonPaint
        AddHandler btnCancel.Paint, AddressOf OnButtonPaint
    End Sub

    Private Sub OnButtonPaint(sender As Object, e As PaintEventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        ' Define the rectangle and the radius for rounded corners
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

        ' Draw the border using a Pen
        Using pen As New Pen(Color.Black, 4) ' Adjust thickness as needed
            e.Graphics.DrawPath(pen, path)
        End Using
    End Sub

    ' Method to set the submission details on the form
    Public Sub SetSubmission(submission As JObject)
        _submission = submission
        If _submission IsNot Nothing Then
            ' Populate form fields with submission details
            txtName.Text = _submission("name").ToString()
            txtEmail.Text = _submission("email").ToString()
            txtEmail.ReadOnly = True ' Make the email field read-only
            txtPhone.Text = _submission("phone").ToString()
            txtGithubLink.Text = _submission("github_link").ToString()
            txtStopwatchTime.Text = _submission("stopwatch_time").ToString()
        End If
    End Sub

    ' Method to get the updated submission after editing
    Public Function GetUpdatedSubmission() As JObject
        Return _submission
    End Function

    Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Update the submission object with edited details
        _submission("name") = txtName.Text
        _submission("phone") = txtPhone.Text
        _submission("email") = txtEmail.Text
        _submission("github_link") = txtGithubLink.Text
        _submission("stopwatch_time") = txtStopwatchTime.Text

        ' Save the updated submission to the server
        Await SaveSubmissionAsync(_submission)

        ' Close the form after saving
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Async Function SaveSubmissionAsync(submission As JObject) As Task
        Dim baseUrl As String = "http://localhost:3000/" ' Replace with your API base URL
        Using client As New HttpClient()
            Dim jsonContent As New StringContent(submission.ToString(), System.Text.Encoding.UTF8, "application/json")
            Try
                Dim response As HttpResponseMessage = Await client.PutAsync(baseUrl & "edit/" & submission("email").ToString(), jsonContent)

                response.EnsureSuccessStatusCode() ' Ensure response is successful

            Catch ex As Exception
                MessageBox.Show($"Error updating submission: {ex.Message}")
            End Try
        End Using
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class
