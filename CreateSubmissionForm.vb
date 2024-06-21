Imports System.Net
Imports System.Text

Public Class CreateSubmissionForm
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub
    ' Form overrides dispose to clean up the component list.
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblStopwatchTime As Button

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblGithubLink = New System.Windows.Forms.Label()
        Me.txtGithubLink = New System.Windows.Forms.TextBox()
        Me.btnToggleStopwatch = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStopwatchTime = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(264, 71)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(47, 16)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(389, 68)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(228, 22)
        Me.txtName.TabIndex = 1
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(264, 113)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(44, 16)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(389, 110)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(228, 22)
        Me.txtEmail.TabIndex = 3
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(264, 158)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(100, 16)
        Me.lblPhone.TabIndex = 4
        Me.lblPhone.Text = "Phone Number:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(389, 155)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(228, 22)
        Me.txtPhone.TabIndex = 5
        '
        'lblGithubLink
        '
        Me.lblGithubLink.AutoSize = True
        Me.lblGithubLink.Location = New System.Drawing.Point(264, 198)
        Me.lblGithubLink.Name = "lblGithubLink"
        Me.lblGithubLink.Size = New System.Drawing.Size(78, 16)
        Me.lblGithubLink.TabIndex = 6
        Me.lblGithubLink.Text = "GitHub Link:"
        '
        'txtGithubLink
        '
        Me.txtGithubLink.Location = New System.Drawing.Point(389, 195)
        Me.txtGithubLink.Name = "txtGithubLink"
        Me.txtGithubLink.Size = New System.Drawing.Size(228, 22)
        Me.txtGithubLink.TabIndex = 7
        '
        'btnToggleStopwatch
        '
        Me.btnToggleStopwatch.BackColor = System.Drawing.SystemColors.Info
        Me.btnToggleStopwatch.Location = New System.Drawing.Point(190, 271)
        Me.btnToggleStopwatch.Name = "btnToggleStopwatch"
        Me.btnToggleStopwatch.Size = New System.Drawing.Size(237, 25)
        Me.btnToggleStopwatch.TabIndex = 10
        Me.btnToggleStopwatch.Text = "TOOGLE STOPWATCH (CTRL + T)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnToggleStopwatch.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSubmit.Location = New System.Drawing.Point(190, 328)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(237, 25)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "SUBMIT (CTRL + S)"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(264, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Prajwal Kulkarni, Slidely Task 2 - Create Submission" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblStopwatchTime
        '
        Me.lblStopwatchTime.Location = New System.Drawing.Point(551, 273)
        Me.lblStopwatchTime.Name = "lblStopwatchTime"
        Me.lblStopwatchTime.Size = New System.Drawing.Size(75, 23)
        Me.lblStopwatchTime.TabIndex = 13
        Me.lblStopwatchTime.Text = "START"
        Me.lblStopwatchTime.UseVisualStyleBackColor = True
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 468)
        Me.Controls.Add(Me.lblStopwatchTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnToggleStopwatch)
        Me.Controls.Add(Me.txtGithubLink)
        Me.Controls.Add(Me.lblGithubLink)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "Create Submission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button




    Private stopwatchRunning As Boolean = False
    Private stopwatchStartTime As DateTime
    Private totalStopwatchTime As TimeSpan = TimeSpan.Zero

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatchRunning Then
            ' Stop the stopwatch
            totalStopwatchTime += DateTime.Now - stopwatchStartTime
            stopwatchRunning = False
            lblStopwatchTime.Text = totalStopwatchTime.ToString("hh\:mm\:ss")  ' Format TimeSpan as hours:minutes:seconds
            btnToggleStopwatch.Text = "Start"  ' Change button text to "Start"
        Else
            ' Start the stopwatch
            stopwatchStartTime = DateTime.Now
            stopwatchRunning = True
            btnToggleStopwatch.Text = "Stop"  ' Change button text to "Stop"
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhone.Text
        Dim github As String = txtGithubLink.Text

        Dim jsonData As String
        jsonData = $"{{""key"": ""name"", ""value"": ""{name}""}}"
        SendData(jsonData)

        jsonData = $"{{""key"": ""email"", ""value"": ""{email}""}}"
        SendData(jsonData)

        jsonData = $"{{""key"": ""phone"", ""value"": ""{phone}""}}"
        SendData(jsonData)

        jsonData = $"{{""key"": ""github"", ""value"": ""{github}""}}"
        SendData(jsonData)
    End Sub

    Private Sub SendData(jsonData As String)
        Dim url As String = "http://localhost:3000/submit"
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        request.Method = "POST"
        request.ContentType = "application/json"
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(jsonData)
        request.ContentLength = bytes.Length

        Using stream As IO.Stream = request.GetRequestStream()
            stream.Write(bytes, 0, bytes.Length)
        End Using

        Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            Using reader As New IO.StreamReader(response.GetResponseStream())
                Dim responseText As String = reader.ReadToEnd()
                MessageBox.Show(responseText)
            End Using
        End Using
    End Sub
End Class