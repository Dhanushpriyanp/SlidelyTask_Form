<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditSubmissionForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        btnSave = New Button()
        btnCancel = New Button()
        SuspendLayout()
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
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12.5F)
        Label4.Location = New Point(65, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 46)
        Label4.TabIndex = 18
        Label4.Text = "Github Link " & vbCrLf & "For Task 2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12.5F)
        Label5.Location = New Point(65, 268)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 23)
        Label5.TabIndex = 19
        Label5.Text = "Stopwatch Time"
        ' 
        ' txtName
        ' 
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Font = New Font("Segoe UI", 12.5F)
        txtName.Location = New Point(216, 52)
        txtName.Name = "txtName"
        txtName.Size = New Size(416, 30)
        txtName.TabIndex = 10
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Segoe UI", 12.5F)
        txtEmail.Location = New Point(216, 102)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(416, 30)
        txtEmail.TabIndex = 11
        ' 
        ' txtPhone
        ' 
        txtPhone.BorderStyle = BorderStyle.FixedSingle
        txtPhone.Font = New Font("Segoe UI", 12.5F)
        txtPhone.Location = New Point(216, 158)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(416, 30)
        txtPhone.TabIndex = 12
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BorderStyle = BorderStyle.FixedSingle
        txtGithubLink.Font = New Font("Segoe UI", 12.5F)
        txtGithubLink.Location = New Point(216, 215)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(416, 30)
        txtGithubLink.TabIndex = 13
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.BorderStyle = BorderStyle.FixedSingle
        txtStopwatchTime.Font = New Font("Segoe UI", 12.5F)
        txtStopwatchTime.Location = New Point(216, 266)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.Size = New Size(416, 30)
        txtStopwatchTime.TabIndex = 14
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(254), CByte(236), CByte(152))
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 12.5F)
        btnSave.Location = New Point(112, 339)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(241, 45)
        btnSave.TabIndex = 20
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(165), CByte(217), CByte(254))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 12.5F)
        btnCancel.Location = New Point(366, 339)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(236, 45)
        btnCancel.TabIndex = 21
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' EditSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(745, 453)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "EditSubmissionForm"
        Text = "Edit Submission"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
