Imports System.Drawing.Drawing2D
Imports System.Net.Http
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()

    Private Sub CreateSubmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialization code if needed

        ' Setup button appearance
        AddHandler btnToggleStopwatch.Paint, AddressOf OnButtonPaint
        AddHandler btnSubmit.Paint, AddressOf OnButtonPaint
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

    Public Sub New()
        InitializeComponent()
        Timer1.Interval = 1000 ' Interval in milliseconds (1 second)
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            Timer1.Stop() ' Stop timer updates
        Else
            stopwatch.Start()
            Timer1.Start() ' Start timer updates
        End If
        UpdateStopwatchDisplay()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateStopwatchDisplay()
    End Sub

    Private Sub UpdateStopwatchDisplay()
        lblStopwatchTime.Text = String.Format("{0:hh\:mm\:ss}", stopwatch.Elapsed)
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MessageBox.Show("Email field is mandatory.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmail.Focus()
            Return
        End If

        Dim submission As New Dictionary(Of String, String) From {
            {"name", txtName.Text},
            {"email", txtEmail.Text},
            {"phone", txtPhoneNumber.Text},
            {"github_link", txtGithubLink.Text},
            {"stopwatch_time", lblStopwatchTime.Text}
        }

        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim baseUrl As String = "http://localhost:3000/"

        Try
            Await SubmitDataAsync(baseUrl, json)
            MessageBox.Show("Submission successful!")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show($"Error submitting data: {ex.Message}")
        End Try
    End Sub

    Private Async Function SubmitDataAsync(baseUrl As String, jsonData As String) As Task
        Using client As New HttpClient()
            client.DefaultRequestHeaders.Accept.Add(New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

            Dim content As New StringContent(jsonData, System.Text.Encoding.UTF8, "application/json")

            Dim response As HttpResponseMessage = Await client.PostAsync(baseUrl & "submit", content)

            If Not response.IsSuccessStatusCode Then
                Throw New Exception($"Server error (HTTP {response.StatusCode}): {response.ReasonPhrase}")
            End If
        End Using
    End Function

    Private Async Function HandleKeyAsync(keyData As Keys) As Task(Of Boolean)
        If keyData = (Keys.Control Or Keys.T) Then
            btnToggleStopwatch.PerformClick()
            Return Await Task.FromResult(True)
        ElseIf keyData = (Keys.Control Or Keys.S) Then
            btnSubmit.PerformClick()
            Return Await Task.FromResult(True)
        End If
        Return Await Task.FromResult(False)
    End Function

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Return HandleKeyAsync(keyData).GetAwaiter().GetResult()
    End Function

    Private Sub lblStopwatchTime_Click(sender As Object, e As EventArgs) Handles lblStopwatchTime.Click

    End Sub
End Class
