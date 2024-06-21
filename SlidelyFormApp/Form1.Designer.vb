<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnViewSubmissions = New Button()
        btnCreateSubmission = New Button()

        Me.MaximizeBox = False  ' Remove maximize button
        Me.MinimizeBox = False  ' Remove minimize button
        Me.KeyPreview = True ' Allows the form to receive key events before controls do


        ' Event handler for KeyDown event
        AddHandler Me.KeyDown, AddressOf Form1_KeyDown
        SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.FromArgb(CByte(254), CByte(236), CByte(152))
        btnViewSubmissions.FlatAppearance.BorderColor = Color.Black
        btnViewSubmissions.FlatStyle = FlatStyle.Flat
        btnViewSubmissions.Font = New Font("Segoe UI", 12.5F)
        btnViewSubmissions.Location = New Point(155, 145)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(428, 44)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL + V)"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnCreateSubmission
        ' 
        btnCreateSubmission.BackColor = Color.FromArgb(CByte(165), CByte(217), CByte(254))
        btnCreateSubmission.FlatAppearance.BorderColor = Color.Black
        btnCreateSubmission.FlatStyle = FlatStyle.Flat
        btnCreateSubmission.Font = New Font("Segoe UI", 12.5F)
        btnCreateSubmission.Location = New Point(155, 219)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(428, 44)
        btnCreateSubmission.TabIndex = 1
        btnCreateSubmission.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        btnCreateSubmission.UseVisualStyleBackColor = False
        ' 

        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(710, 450)
        Controls.Add(btnCreateSubmission)
        Controls.Add(btnViewSubmissions)
        Name = "Form1"
        Text = "Dhanushpriyan, Slidely Task 2 - Slidely Form App"
        ResumeLayout(False)

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs)
        ' Check for Ctrl+H key combination
        If e.Control AndAlso e.KeyCode = Keys.H Then
            ' Replace with your logic to display shortcuts
            MessageBox.Show("Shortcuts used: Ctrl+N for New, Ctrl+S for Save, etc.")
            ' Or you can open a dialog to display all shortcuts
            ' Dim shortcutsForm As New ShortcutsForm()
            ' shortcutsForm.Show()
        End If
    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button

End Class
