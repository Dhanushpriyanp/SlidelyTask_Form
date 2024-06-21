<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchSubmissionForm
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
        txtEmail = New TextBox()
        btnSearch = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.5F)
        Label1.Location = New Point(64, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 23)
        Label1.TabIndex = 15
        Label1.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Segoe UI", 12.5F)
        txtEmail.Location = New Point(151, 52)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(416, 30)
        txtEmail.TabIndex = 11
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(254), CByte(236), CByte(152))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Segoe UI", 12.5F)
        btnSearch.Location = New Point(75, 120)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(220, 45)
        btnSearch.TabIndex = 20
        btnSearch.Text = "SEARCH SUBMISSION"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(165), CByte(217), CByte(254))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 12.5F)
        btnCancel.Location = New Point(342, 120)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(225, 45)
        btnCancel.TabIndex = 21
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' SearchSubmissionForm
        ' 
        AcceptButton = btnSearch
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(666, 221)
        Controls.Add(btnCancel)
        Controls.Add(btnSearch)
        Controls.Add(txtEmail)
        Controls.Add(Label1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "SearchSubmissionForm"
        Text = "Search Submission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnCancel As Button ' Add Cancel button
End Class
