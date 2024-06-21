Imports System.Drawing.Drawing2D
Imports System.Net.Http

Public Class DeleteSubmissionForm
    Private ReadOnly _email As String
    Private Sub DeleteSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler btnDelete.Paint, AddressOf OnButtonPaint
        AddHandler btnCancel.Paint, AddressOf OnButtonPaint
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
    Public Sub New(email As String)
        InitializeComponent()
        _email = email
        lblEmail.Text = $"Email : {_email}"
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim baseUrl As String = "http://localhost:3000/"
            Dim client As New HttpClient()

            Dim response As HttpResponseMessage = Await client.DeleteAsync(baseUrl & $"delete/{Uri.EscapeDataString(_email)}")

            If response.IsSuccessStatusCode Then
                MessageBox.Show($"Submission with email '{_email}' deleted successfully.")
                DialogResult = DialogResult.OK
                Close()
            Else
                MessageBox.Show($"Failed to delete submission with email '{_email}'. Status code: {response.StatusCode}")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error deleting submission: {ex.Message}")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class
