<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeleteSubmissionForm
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
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

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblEmail = New Label()
        lblConfirmMessage = New Label()
        btnDelete = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(45, 35)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(133, 21)
        lblEmail.TabIndex = 0
        lblEmail.Text = "Email to delete: "
        ' 
        ' lblConfirmMessage
        ' 
        lblConfirmMessage.AutoSize = True
        lblConfirmMessage.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblConfirmMessage.Location = New Point(45, 82)
        lblConfirmMessage.Name = "lblConfirmMessage"
        lblConfirmMessage.Size = New Size(308, 21)
        lblConfirmMessage.TabIndex = 1
        lblConfirmMessage.Text = "Are you sure you want to delete this email?"
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(49, 142)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(120, 40)
        btnDelete.TabIndex = 2
        btnDelete.Text = "Confirm"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(197, 142)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(120, 40)
        btnCancel.TabIndex = 3
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' DeleteSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(400, 200)
        Controls.Add(btnCancel)
        Controls.Add(btnDelete)
        Controls.Add(lblConfirmMessage)
        Controls.Add(lblEmail)
        MaximizeBox = False
        MinimizeBox = False
        Name = "DeleteSubmissionForm"
        Text = "Delete Submission"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblEmail As Label
    Friend WithEvents lblConfirmMessage As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnCancel As Button
End Class
