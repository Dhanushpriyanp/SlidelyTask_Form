Imports System.Drawing.Drawing2D

Public Class SearchSubmissionForm
    Private Sub SearchSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler btnSearch.Paint, AddressOf OnButtonPaint
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
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
