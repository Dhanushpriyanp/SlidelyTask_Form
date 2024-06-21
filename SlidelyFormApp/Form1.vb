Imports System.Drawing.Drawing2D

Public Class Form1
    Private viewForm As ViewSubmissionsForm = Nothing
    Private createForm As CreateSubmissionForm = Nothing
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialization code if needed

        ' Setup button appearance
        AddHandler btnViewSubmissions.Paint, AddressOf OnButtonPaint
        AddHandler btnCreateSubmission.Paint, AddressOf OnButtonPaint
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

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        If viewForm Is Nothing OrElse viewForm.IsDisposed Then
            viewForm = New ViewSubmissionsForm()
        End If

        If viewForm.Visible Then
            viewForm.BringToFront()
        Else
            viewForm.Show()
        End If
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        If createForm Is Nothing OrElse createForm.IsDisposed Then
            createForm = New CreateSubmissionForm()
        End If

        If createForm.Visible Then
            createForm.BringToFront()
        Else
            createForm.Show()
        End If
    End Sub

    Private Function HandleKey(keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.V) Then
            Invoke(Sub() btnViewSubmissions.PerformClick())
            Return True
        ElseIf keyData = (Keys.Control Or Keys.N) Then
            Invoke(Sub() btnCreateSubmission.PerformClick())
            Return True

        End If
        Return False
    End Function

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Return HandleKey(keyData)
    End Function
End Class

Public Class Submission
    Public Property name As String
    Public Property email As String
    Public Property phone As String
    Public Property github_link As String
    Public Property stopwatch_time As String
End Class
