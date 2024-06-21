<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNumber = New TextBox()
        txtGithubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnNext = New Button()
        btnPrevious = New Button()
        btnSearch = New Button()
        btnDelete = New Button()
        btnEdit = New Button()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(239))
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Font = New Font("Segoe UI", 14.25F)
        txtName.Location = New Point(230, 29)
        txtName.Name = "txtName"
        txtName.Size = New Size(388, 33)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(239))
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Segoe UI", 14.25F)
        txtEmail.Location = New Point(230, 86)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(388, 33)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(239))
        txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle
        txtPhoneNumber.Font = New Font("Segoe UI", 14.25F)
        txtPhoneNumber.Location = New Point(230, 142)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(388, 33)
        txtPhoneNumber.TabIndex = 2
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(239))
        txtGithubLink.BorderStyle = BorderStyle.FixedSingle
        txtGithubLink.Font = New Font("Segoe UI", 14.25F)
        txtGithubLink.Location = New Point(230, 203)
        txtGithubLink.Multiline = True
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(388, 34)
        txtGithubLink.TabIndex = 3
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.BackColor = Color.FromArgb(CByte(232), CByte(237), CByte(239))
        txtStopwatchTime.BorderStyle = BorderStyle.FixedSingle
        txtStopwatchTime.Font = New Font("Segoe UI", 14.25F)
        txtStopwatchTime.Location = New Point(230, 276)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.Size = New Size(388, 33)
        txtStopwatchTime.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(114, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 25)
        Label1.TabIndex = 5
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F)
        Label2.Location = New Point(114, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 25)
        Label2.TabIndex = 6
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F)
        Label3.Location = New Point(100, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 25)
        Label3.TabIndex = 7
        Label3.Text = "Phone Num"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F)
        Label4.Location = New Point(100, 197)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 50)
        Label4.TabIndex = 8
        Label4.Text = "Github Link " & vbCrLf & " For Task 2" & vbCrLf
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F)
        Label5.Location = New Point(100, 270)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 50)
        Label5.TabIndex = 9
        Label5.Text = "Stopwatch" & vbCrLf & "     time"
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.FromArgb(CByte(165), CByte(217), CByte(254))
        btnNext.FlatAppearance.BorderColor = Color.Black
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.Font = New Font("Segoe UI", 12.5F)
        btnNext.Location = New Point(364, 334)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(269, 43)
        btnNext.TabIndex = 22
        btnNext.Text = "NEXT (CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.FromArgb(CByte(254), CByte(236), CByte(152))
        btnPrevious.FlatAppearance.BorderColor = Color.Black
        btnPrevious.FlatStyle = FlatStyle.Flat
        btnPrevious.Font = New Font("Segoe UI", 12.5F)
        btnPrevious.Location = New Point(85, 334)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(268, 43)
        btnPrevious.TabIndex = 21
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.LightGray
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI", 12.5F)
        btnSearch.Location = New Point(85, 385)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(268, 43)
        btnSearch.TabIndex = 23
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 12.5F)
        btnDelete.Location = New Point(226, 436)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(268, 43)
        btnDelete.TabIndex = 24
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(200), CByte(255), CByte(200))
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI", 12.5F)
        btnEdit.Location = New Point(364, 385)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(268, 43)
        btnEdit.TabIndex = 25
        btnEdit.Text = "EDIT"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(734, 491)
        Controls.Add(btnEdit)
        Controls.Add(btnDelete)
        Controls.Add(btnSearch)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        MaximizeBox = False
        MinimizeBox = False
        Name = "ViewSubmissionsForm"
        Text = "Dhanushpriyan, Slidely Task 2 - View Submissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
End Class
