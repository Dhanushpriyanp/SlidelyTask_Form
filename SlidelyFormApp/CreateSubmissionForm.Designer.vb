<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtGithubLink = New TextBox()
        txtPhoneNumber = New TextBox()
        txtEmail = New TextBox()
        txtName = New TextBox()
        btnToggleStopwatch = New Button()
        btnSubmit = New Button()
        lblStopwatchTime = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12.5F)
        Label4.Location = New Point(65, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 46)
        Label4.TabIndex = 18
        Label4.Text = "Github Link " & vbCrLf & " For Task 2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12.5F)
        Label3.Location = New Point(65, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 23)
        Label3.TabIndex = 17
        Label3.Text = "Phone Num"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.5F)
        Label2.Location = New Point(65, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 23)
        Label2.TabIndex = 16
        Label2.Text = "Email"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.5F)
        Label1.Location = New Point(65, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 23)
        Label1.TabIndex = 15
        Label1.Text = "Name"
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BorderStyle = BorderStyle.FixedSingle
        txtGithubLink.Font = New Font("Segoe UI", 12.5F)
        txtGithubLink.Location = New Point(190, 223)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(416, 30)
        txtGithubLink.TabIndex = 13
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle
        txtPhoneNumber.Font = New Font("Segoe UI", 12.5F)
        txtPhoneNumber.Location = New Point(190, 160)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(416, 30)
        txtPhoneNumber.TabIndex = 12
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Segoe UI", 12.5F)
        txtEmail.Location = New Point(190, 104)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(416, 30)
        txtEmail.TabIndex = 11
        ' 
        ' txtName
        ' 
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Font = New Font("Segoe UI", 12.5F)
        txtName.Location = New Point(190, 54)
        txtName.Name = "txtName"
        txtName.Size = New Size(416, 30)
        txtName.TabIndex = 10
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.FromArgb(CByte(254), CByte(236), CByte(152))
        btnToggleStopwatch.FlatAppearance.BorderColor = Color.Black
        btnToggleStopwatch.FlatStyle = FlatStyle.Flat
        btnToggleStopwatch.Font = New Font("Segoe UI", 12.5F)
        btnToggleStopwatch.Location = New Point(76, 293)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(340, 38)
        btnToggleStopwatch.TabIndex = 19
        btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(165), CByte(217), CByte(254))
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.Font = New Font("Segoe UI", 12.5F)
        btnSubmit.Location = New Point(153, 367)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(414, 45)
        btnSubmit.TabIndex = 20
        btnSubmit.Text = "SUBMIT (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(239))
        lblStopwatchTime.BorderStyle = BorderStyle.FixedSingle
        lblStopwatchTime.Font = New Font("Segoe UI", 18F)
        lblStopwatchTime.Location = New Point(442, 293)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Padding = New Padding(30, 2, 30, 2)
        lblStopwatchTime.Size = New Size(164, 38)
        lblStopwatchTime.TabIndex = 21
        lblStopwatchTime.Text = "00:00:00"
        ' 
        ' Timer1
        ' 
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(lblStopwatchTime)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        MaximizeBox = False
        MinimizeBox = False
        Name = "CreateSubmissionForm"
        Text = "Dhanushpriyan, Slidely Task 2 - Create Submission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents Timer1 As Timer
End Class
