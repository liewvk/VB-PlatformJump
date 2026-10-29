Public Class Form1
    Dim moveLeft As Boolean = False
    Dim moveRight As Boolean = False
    Dim isJumping As Boolean = False
    Dim isFalling As Boolean = True

    Dim playerSpeed As Integer = 6
    Dim gravity As Integer = 2
    Dim jumpStrength As Integer = 22
    Dim verticalSpeed As Integer = 0

    Dim lives As Integer = 3
    Dim score As Integer = 0

    Dim gameStarted As Boolean = False
    Dim gameOver As Boolean = False

    Dim startX As Integer
    Dim startY As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        startX = picPlatform1.Left +
         (picPlatform1.Width - picPlayer.Width) \ 2
        startY = picPlatform1.Top - picPlayer.Height


        lblScore.Text = "Score: 0"
        lblLives.Text = "Lives: 3"
        lblStatus.Text = "Click Start to begin."

        gameTimer.Interval = 20
    End Sub

    Private Sub StartGame()
        lives = 3
        score = 0

        gameStarted = True
        gameOver = False

        picPlayer.Left = startX
        picPlayer.Top = startY

        moveLeft = False
        moveRight = False
        isJumping = False
        isFalling = True
        verticalSpeed = 0

        ResetCollectibles()

        lblScore.Text = "Score: 0"
        lblLives.Text = "Lives: 3"
        lblStatus.Text = "Reach the goal."

        gameTimer.Start()
    End Sub

    Private Sub StartJump()
        isJumping = True
        isFalling = True
        verticalSpeed = -jumpStrength
    End Sub

    Private Sub Form1_KeyDown(
    sender As Object,
    e As KeyEventArgs
) Handles Me.KeyDown

        If Not gameStarted OrElse gameOver Then Exit Sub

        Select Case e.KeyCode
            Case Keys.Left
                moveLeft = True
                e.SuppressKeyPress = True

            Case Keys.Right
                moveRight = True
                e.SuppressKeyPress = True

            Case Keys.Space
                If Not isJumping AndAlso Not isFalling Then
                    StartJump()
                End If
                e.SuppressKeyPress = True
        End Select
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Left Then
            moveLeft = False
        ElseIf e.KeyCode = Keys.Right Then
            moveRight = False
        End If
    End Sub

    Private Sub MovePlayerHorizontally()
        If moveLeft Then picPlayer.Left -= playerSpeed
        If moveRight Then picPlayer.Left += playerSpeed

        If picPlayer.Left < 0 Then picPlayer.Left = 0
        If picPlayer.Right > Me.ClientSize.Width Then
            picPlayer.Left = Me.ClientSize.Width - picPlayer.Width
        End If
    End Sub

    Private Sub ApplyGravity()
        verticalSpeed += gravity
        picPlayer.Top += verticalSpeed
    End Sub

    Private Sub CheckPlatformCollision()
        Dim landed As Boolean = False

        If verticalSpeed >= 0 Then
            Dim previousBottom As Integer =
            picPlayer.Bottom - verticalSpeed

            For Each ctrl As Control In Me.Controls
                If Object.Equals(ctrl.Tag, "platform") AndAlso ctrl.Visible Then

                    Dim overlapsHorizontally As Boolean =
                    picPlayer.Right > ctrl.Left AndAlso
                    picPlayer.Left < ctrl.Right

                    If overlapsHorizontally AndAlso
                   previousBottom <= ctrl.Top AndAlso
                   picPlayer.Bottom >= ctrl.Top Then

                        picPlayer.Top = ctrl.Top - picPlayer.Height
                        verticalSpeed = 0
                        isJumping = False
                        landed = True
                        Exit For
                    End If
                End If
            Next
        End If

        isFalling = Not landed
    End Sub

    Private Sub CheckCollectibles()
        For Each ctrl As Control In Me.Controls
            If ctrl.Tag = "coin" AndAlso ctrl.Visible Then
                If picPlayer.Bounds.IntersectsWith(ctrl.Bounds) Then
                    ctrl.Visible = False
                    score += 10
                    lblScore.Text = "Score: " & score.ToString()
                End If
            End If
        Next
    End Sub

    Private Sub CheckGoalCollision()
        If picPlayer.Bounds.IntersectsWith(picGoal.Bounds) Then
            ShowWin()
        End If
    End Sub

    Private Sub CheckFallOut()
        If picPlayer.Top > Me.ClientSize.Height Then
            LoseLifeAndReset()
        End If
    End Sub

    Private Sub LoseLifeAndReset()
        lives -= 1
        lblLives.Text = "Lives: " & lives.ToString()

        If lives <= 0 Then
            ShowGameOver()
        Else
            picPlayer.Left = startX
            picPlayer.Top = startY
            verticalSpeed = 0
            isJumping = False
            isFalling = True
        End If
    End Sub

    Private Sub ShowWin()
        gameTimer.Stop()
        gameStarted = False
        gameOver = True
        lblStatus.Text = "Level Complete!"
        MessageBox.Show("Congratulations! You reached the goal.")
    End Sub

    Private Sub ShowGameOver()
        gameTimer.Stop()
        gameStarted = False
        gameOver = True
        lblStatus.Text = "Game Over!"
        MessageBox.Show("You lost all your lives.")
    End Sub

    Private Sub ResetCollectibles()
        For Each ctrl As Control In Me.Controls
            If ctrl.Tag = "coin" Then ctrl.Visible = True
        Next
    End Sub

    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        If Not gameStarted OrElse gameOver Then Exit Sub

        MovePlayerHorizontally()
        ApplyGravity()
        CheckPlatformCollision()
        CheckCollectibles()
        CheckGoalCollision()
        CheckFallOut()
    End Sub
    Private Sub GameButtons_PreviewKeyDown(
    sender As Object,
    e As PreviewKeyDownEventArgs
) Handles btnStart.PreviewKeyDown, btnRestart.PreviewKeyDown

        Select Case e.KeyCode
            Case Keys.Left, Keys.Right, Keys.Space
                e.IsInputKey = True
        End Select
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StartGame()
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        StartGame()
    End Sub

End Class
