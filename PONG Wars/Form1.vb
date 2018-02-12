Public Class PONGMAIN
    Dim paused As Boolean
    Private Sub loadsettings()
        paused = False
    End Sub

#Region "End Game on Escape Press"

    Private Sub PONGMAIN_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form2.Show()
    End Sub


    ' Escape the game when escape has been pressed.
    Private Sub pongMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown


        If e.KeyValue = Keys.W Then
            pp1.Location = New Point(pp1.Location.X, pp1.Location.Y - 50)
        End If
        If e.KeyValue = Keys.S Then
            pp1.Location = New Point(pp1.Location.X, pp1.Location.Y + 50)
        End If

        If e.KeyValue = Keys.Up Then
            pp2.Location = New Point(pp2.Location.X, pp2.Location.Y - 50)
        End If
        If e.KeyValue = Keys.Down Then
            pp2.Location = New Point(pp2.Location.X, pp2.Location.Y + 50)
        End If

        If e.KeyValue = Keys.D Then

            Missile1.Start()
            PictureBox2.Visible = True
            My.Computer.Audio.Play(My.Resources.BowFireArrow, AudioPlayMode.Background)

        End If

        If e.KeyValue = Keys.Left Then

            Missile2.Start()
            PictureBox3.Visible = True
            My.Computer.Audio.Play(My.Resources.BowFireArrow, AudioPlayMode.Background)

        End If

    End Sub
#End Region


#Region "Globals"
    Dim speed As Single = 0.5                                      ' Ball Speed
    Dim rndInst As New Random()                                     ' Random instance
    Dim xVel As Single = Math.Cos(rndInst.Next(1, 1.01)) * speed + 1
    Dim yVel As Single = Math.Sin(rndInst.Next(1, 1.01)) * speed + 1

    ' The player's scores.
    Dim psoo As Integer = 0
    Dim pstt As Integer = 0
#End Region


    Private Sub gametimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gametimer.Tick
        ' Move the game ball.
        ball.Location = New Point(ball.Location.X + xVel, ball.Location.Y + yVel)
        ' Check for top wall.
        If ball.Location.Y < 60 Then
            My.Computer.Audio.Play(My.Resources.beeep, AudioPlayMode.Background)
            ball.Location = New Point(ball.Location.X, 60)
            yVel = -yVel
        End If
        ' Check for bottom wall.
        If ball.Location.Y > Me.Height - ball.Size.Height - 45 Then
            My.Computer.Audio.Play(My.Resources.beeep, AudioPlayMode.Background)
            ball.Location = New Point(ball.Location.X, Me.Height - ball.Size.Height - 45)
            yVel = -yVel
        End If
        ' Check for player 1 paddle.
        If ball.Bounds.IntersectsWith(pp1.Bounds) Then
            My.Computer.Audio.Play(My.Resources.peeeeeep, AudioPlayMode.Background)
            ball.Location = New Point(ball.Location.X, _ball.Location.Y)
            xVel = -xVel
        End If
        ' Check for player 2 paddle.
        If ball.Bounds.IntersectsWith(pp2.Bounds) Then
            My.Computer.Audio.Play(My.Resources.peeeeeep, AudioPlayMode.Background)
            ball.Location = New Point(ball.Location.X, _ball.Location.Y)
            xVel = -xVel
        End If

        'missiles.
        'Set the missile to move according to the paddle position."

        PictureBox2.Location = New Point(PictureBox2.Location.X, pp1.Location.Y)

        PictureBox3.Location = New Point(PictureBox3.Location.X, pp2.Location.Y)

        'scores.
        ' Check for right wall.
        If ball.Location.X > Me.Width - ball.Size.Width - pp1.Width Then
            pstt += 2
            ball.Location = New Point(Me.Size.Width / 2, Me.Size.Height / 2)
            pst.Text = Convert.ToString(pstt)
        End If
        ' Check for left wall.
        If ball.Location.X < 0 Then
            psoo += 2
            ball.Location = New Point(Me.Size.Width / 2, Me.Size.Height / 2)
            pso.Text = Convert.ToString(psoo)
        End If

        If pso.Text = Form2.TextBox1.Text Then
            gametimer.Stop()
            Form4.Show()
            Form4.Label2.Text = "Red Player defeats you by" & Val(pst.Text) - Val(pso.Text) & "-points."
            Form4.Label1.Text = "Red Player wins"
            pso.Text = ""
            pst.Text = ""
        ElseIf pst.Text = Form2.TextBox1.Text Then
            gametimer.Stop()
            Form4.Show()
            Form4.Label2.Text = "Blue Player defeats you by" & Val(pso.Text) - Val(pst.Text) & "-points."
            Form4.Label1.Text = "Blue Player wins"
            pst.Text = ""
            pso.Text = ""
        End If



        If pso.Text = Convert.ToString(a) Then
            gametimer.Stop()
            Form4.Show()
            Form4.Label2.Text = "Red Player defeats you by" & Val(pst.Text) - Val(pso.Text) - 1 & "-points."
            Form4.Label1.Text = "Red Player wins"
            pso.Text = ""
            pst.Text = ""
        ElseIf pst.Text = Convert.ToString(a) Then
            gametimer.Stop()
            Form4.Show()
            Form4.Label2.Text = "Blue Player defeats you by" & Val(pso.Text) - Val(pst.Text) - 1 & "-points."
            Form4.Label1.Text = "Blue Player wins"
            pst.Text = ""
            pso.Text = ""
        End If
    End Sub
    Dim a As Double = Val(Form2.TextBox1.Text) + 1
    Private Sub PONGMAIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gametimer.Enabled = False
        gt2.Enabled = False
        Timer1.Enabled = True
        Label1.Visible = True

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text -= 1
        My.Computer.Audio.Play(My.Resources.peeeeeep, AudioPlayMode.Background)
        If Label1.Text = "0" Then
            Label1.Visible = False
            Timer1.Stop()
            gametimer.Start()
            gt2.Start()

        End If

    End Sub

    Private Sub missile1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Missile1.Tick
        With Me.PictureBox2
            .Location = New Point(.Location.X + 15, .Location.Y)
            If Me.Bounds.Right = .Right Then Me.Missile1.Stop()
            Application.DoEvents()
        End With
    End Sub

    Private Sub Missile2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Missile2.Tick
        With Me.PictureBox3
            .Location = New Point(.Location.X - 15, .Location.Y)
            If Me.Bounds.Left = .Left Then Me.Missile2.Stop()
            Application.DoEvents()
        End With
    End Sub

    Private Sub gt2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gt2.Tick
        If PictureBox2.Bounds.IntersectsWith(pp2.Bounds) Then
            pstt += 1
            Missile1.Stop()
            pst.Text = Convert.ToString(pstt)
            My.Computer.Audio.Play(My.Resources.plop, AudioPlayMode.Background)
            PictureBox2.Visible = False
            PictureBox2.Location = New Point(36, 239)

        End If
        If PictureBox3.Bounds.IntersectsWith(pp1.Bounds) Then
            psoo += 1
            Missile2.Stop()
            pso.Text = Convert.ToString(psoo)
            My.Computer.Audio.Play(My.Resources.plop, AudioPlayMode.Background)
            PictureBox3.Visible = False
            PictureBox3.Location = New Point(774, 239)

        End If

        'right wall.

        If PictureBox2.Location.X > Me.Width - PictureBox2.Size.Width - pp1.Width Then
            Missile1.Stop()
            PictureBox2.Location = New Point(36, 239)
            PictureBox2.Visible = False
        End If

        'left wall.


        If PictureBox3.Location.X < 0 Then
            Missile2.Stop()
            PictureBox3.Location = New Point(774, 239)
            PictureBox3.Visible = False
        End If



    End Sub

    Private Sub PONGMAIN_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = "P" Or e.KeyChar = "p" Then
            If paused = False Then
                gametimer.Enabled = False And gt2.Enabled = False
                paused = True
                Label3.Visible = True
            ElseIf paused = True Then
                gametimer.Enabled = True And gt2.Enabled = True
                Label3.Visible = False
                paused = False
            End If
        End If
    End Sub


End Class
