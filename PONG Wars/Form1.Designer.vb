<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PONGMAIN
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PONGMAIN))
        Me.pso = New System.Windows.Forms.Label()
        Me.pst = New System.Windows.Forms.Label()
        Me.pp1 = New System.Windows.Forms.Label()
        Me.pp2 = New System.Windows.Forms.Label()
        Me.gametimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Missile1 = New System.Windows.Forms.Timer(Me.components)
        Me.Missile2 = New System.Windows.Forms.Timer(Me.components)
        Me.gt2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ball = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pso
        '
        Me.pso.BackColor = System.Drawing.Color.Silver
        Me.pso.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pso.Location = New System.Drawing.Point(12, 9)
        Me.pso.Name = "pso"
        Me.pso.Size = New System.Drawing.Size(140, 48)
        Me.pso.TabIndex = 1
        Me.pso.Text = "0"
        '
        'pst
        '
        Me.pst.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pst.BackColor = System.Drawing.Color.Silver
        Me.pst.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pst.Location = New System.Drawing.Point(750, 9)
        Me.pst.Name = "pst"
        Me.pst.Size = New System.Drawing.Size(140, 48)
        Me.pst.TabIndex = 2
        Me.pst.Text = "0"
        '
        'pp1
        '
        Me.pp1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pp1.BackColor = System.Drawing.Color.Blue
        Me.pp1.Location = New System.Drawing.Point(12, 215)
        Me.pp1.Name = "pp1"
        Me.pp1.Size = New System.Drawing.Size(18, 69)
        Me.pp1.TabIndex = 3
        '
        'pp2
        '
        Me.pp2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.pp2.BackColor = System.Drawing.Color.Red
        Me.pp2.Location = New System.Drawing.Point(872, 215)
        Me.pp2.Name = "pp2"
        Me.pp2.Size = New System.Drawing.Size(18, 69)
        Me.pp2.TabIndex = 4
        '
        'gametimer
        '
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Consolas", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(309, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 160)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "5"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Missile1
        '
        Me.Missile1.Interval = 30
        '
        'Missile2
        '
        Me.Missile2.Interval = 30
        '
        'gt2
        '
        Me.gt2.Interval = 10
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(309, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(269, 160)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Game Paused"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(823, 239)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(43, 17)
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(36, 239)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(44, 17)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'ball
        '
        Me.ball.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ball.BackColor = System.Drawing.Color.Black
        Me.ball.Image = CType(resources.GetObject("ball.Image"), System.Drawing.Image)
        Me.ball.Location = New System.Drawing.Point(425, 239)
        Me.ball.Name = "ball"
        Me.ball.Size = New System.Drawing.Size(14, 17)
        Me.ball.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(1, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(901, 366)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PONGMAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(902, 426)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ball)
        Me.Controls.Add(Me.pp2)
        Me.Controls.Add(Me.pp1)
        Me.Controls.Add(Me.pst)
        Me.Controls.Add(Me.pso)
        Me.Controls.Add(Me.PictureBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "PONGMAIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pong Wars"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pso As System.Windows.Forms.Label
    Friend WithEvents pst As System.Windows.Forms.Label
    Friend WithEvents pp1 As System.Windows.Forms.Label
    Friend WithEvents ball As System.Windows.Forms.Label
    Friend WithEvents gametimer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Missile1 As System.Windows.Forms.Timer
    Friend WithEvents Missile2 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents gt2 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents pp2 As Label
End Class
