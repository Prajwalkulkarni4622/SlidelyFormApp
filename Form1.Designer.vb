<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCreateNewSubmission = New System.Windows.Forms.Button()
        Me.btnViewSubmissions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(248, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Prajwal Kulkarni, Slidely Task 2 - Slidely Form App" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnCreateNewSubmission
        '
        Me.btnCreateNewSubmission.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCreateNewSubmission.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCreateNewSubmission.Location = New System.Drawing.Point(251, 259)
        Me.btnCreateNewSubmission.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        Me.btnCreateNewSubmission.Size = New System.Drawing.Size(274, 33)
        Me.btnCreateNewSubmission.TabIndex = 5
        Me.btnCreateNewSubmission.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        Me.btnCreateNewSubmission.UseVisualStyleBackColor = False
        '
        'btnViewSubmissions
        '
        Me.btnViewSubmissions.BackColor = System.Drawing.SystemColors.Info
        Me.btnViewSubmissions.Location = New System.Drawing.Point(251, 209)
        Me.btnViewSubmissions.Margin = New System.Windows.Forms.Padding(4)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(274, 33)
        Me.btnViewSubmissions.TabIndex = 4
        Me.btnViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL + V)"
        Me.btnViewSubmissions.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCreateNewSubmission)
        Me.Controls.Add(Me.btnViewSubmissions)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCreateNewSubmission As Button
    Friend WithEvents btnViewSubmissions As Button
End Class
