<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lblScore = New Label()
        lblLives = New Label()
        lblStatus = New Label()
        btnStart = New Button()
        btnRestart = New Button()
        picPlayer = New PictureBox()
        picGoal = New PictureBox()
        gameTimer = New Timer(components)
        picPlatform1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel7 = New Panel()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        CType(picPlayer, ComponentModel.ISupportInitialize).BeginInit()
        CType(picGoal, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblScore.Location = New Point(37, 38)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(56, 25)
        lblScore.TabIndex = 0
        lblScore.Text = "Score"
        ' 
        ' lblLives
        ' 
        lblLives.AutoSize = True
        lblLives.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLives.Location = New Point(37, 80)
        lblLives.Name = "lblLives"
        lblLives.Size = New Size(50, 25)
        lblLives.TabIndex = 0
        lblLives.Text = "Lives"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(37, 127)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(60, 25)
        lblStatus.TabIndex = 0
        lblStatus.Text = "Status"
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(18, 183)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(79, 36)
        btnStart.TabIndex = 1
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' btnRestart
        ' 
        btnRestart.Location = New Point(18, 241)
        btnRestart.Name = "btnRestart"
        btnRestart.Size = New Size(79, 36)
        btnRestart.TabIndex = 1
        btnRestart.Text = "Restart"
        btnRestart.UseVisualStyleBackColor = True
        ' 
        ' picPlayer
        ' 
        picPlayer.Image = CType(resources.GetObject("picPlayer.Image"), Image)
        picPlayer.Location = New Point(200, 219)
        picPlayer.Name = "picPlayer"
        picPlayer.Size = New Size(45, 43)
        picPlayer.SizeMode = PictureBoxSizeMode.StretchImage
        picPlayer.TabIndex = 2
        picPlayer.TabStop = False
        ' 
        ' picGoal
        ' 
        picGoal.Image = CType(resources.GetObject("picGoal.Image"), Image)
        picGoal.Location = New Point(704, 38)
        picGoal.Name = "picGoal"
        picGoal.Size = New Size(84, 67)
        picGoal.SizeMode = PictureBoxSizeMode.StretchImage
        picGoal.TabIndex = 3
        picGoal.TabStop = False
        ' 
        ' gameTimer
        ' 
        ' 
        ' picPlatform1
        ' 
        picPlatform1.BackColor = Color.Blue
        picPlatform1.Location = New Point(200, 282)
        picPlatform1.Name = "picPlatform1"
        picPlatform1.Size = New Size(106, 19)
        picPlatform1.TabIndex = 4
        picPlatform1.Tag = "platform"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Blue
        Panel2.Location = New Point(343, 227)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(96, 18)
        Panel2.TabIndex = 4
        Panel2.Tag = "platform"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Blue
        Panel3.Location = New Point(501, 183)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(87, 21)
        Panel3.TabIndex = 4
        Panel3.Tag = "platform"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Red
        Panel4.Location = New Point(492, 296)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(96, 21)
        Panel4.TabIndex = 5
        Panel4.Tag = "hazard"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Red
        Panel5.Location = New Point(602, 241)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(96, 21)
        Panel5.TabIndex = 5
        Panel5.Tag = "hazard"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Red
        Panel6.Location = New Point(343, 118)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(96, 21)
        Panel6.TabIndex = 5
        Panel6.Tag = "hazard"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Blue
        Panel7.Location = New Point(580, 105)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(74, 17)
        Panel7.TabIndex = 4
        Panel7.Tag = "platform"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(268, 170)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(38, 34)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        PictureBox1.Tag = "coin"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(602, 39)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(38, 34)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        PictureBox2.Tag = "coin"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(452, 60)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(38, 34)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        PictureBox3.Tag = "coin"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(630, 157)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(38, 34)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 6
        PictureBox4.TabStop = False
        PictureBox4.Tag = "coin"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel7)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(picPlatform1)
        Controls.Add(picGoal)
        Controls.Add(picPlayer)
        Controls.Add(btnRestart)
        Controls.Add(btnStart)
        Controls.Add(lblStatus)
        Controls.Add(lblLives)
        Controls.Add(lblScore)
        Name = "Form1"
        Text = "Form1"
        CType(picPlayer, ComponentModel.ISupportInitialize).EndInit()
        CType(picGoal, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblScore As Label
    Friend WithEvents lblLives As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnRestart As Button
    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents picGoal As PictureBox
    Friend WithEvents gameTimer As Timer
    Friend WithEvents picPlatform1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox

End Class
