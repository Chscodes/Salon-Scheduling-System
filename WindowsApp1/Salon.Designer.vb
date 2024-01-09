<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADMIN))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.showBtn = New System.Windows.Forms.Button()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.time = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Pass = New System.Windows.Forms.Label()
        Me.User = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'showBtn
        '
        Me.showBtn.BackColor = System.Drawing.SystemColors.Control
        Me.showBtn.FlatAppearance.BorderSize = 0
        Me.showBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.showBtn.Location = New System.Drawing.Point(505, 229)
        Me.showBtn.Name = "showBtn"
        Me.showBtn.Size = New System.Drawing.Size(57, 24)
        Me.showBtn.TabIndex = 7
        Me.showBtn.Text = "Show"
        Me.showBtn.UseMnemonic = False
        Me.showBtn.UseVisualStyleBackColor = False
        '
        'btnReg
        '
        Me.btnReg.Location = New System.Drawing.Point(386, 277)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(85, 41)
        Me.btnReg.TabIndex = 20
        Me.btnReg.Text = "Register"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'time
        '
        Me.time.AutoSize = True
        Me.time.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.time.Location = New System.Drawing.Point(460, 254)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(0, 13)
        Me.time.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 50.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(151, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 106)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Kirei Salon"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(278, 277)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(85, 41)
        Me.btnLogin.TabIndex = 17
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(358, 231)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(141, 20)
        Me.txtPass.TabIndex = 16
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(358, 187)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(141, 20)
        Me.txtUser.TabIndex = 15
        '
        'Pass
        '
        Me.Pass.AutoSize = True
        Me.Pass.BackColor = System.Drawing.Color.Transparent
        Me.Pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pass.Location = New System.Drawing.Point(203, 220)
        Me.Pass.Name = "Pass"
        Me.Pass.Size = New System.Drawing.Size(142, 31)
        Me.Pass.TabIndex = 14
        Me.Pass.Text = "Password:"
        '
        'User
        '
        Me.User.AutoSize = True
        Me.User.BackColor = System.Drawing.Color.Transparent
        Me.User.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User.Location = New System.Drawing.Point(203, 176)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(147, 31)
        Me.User.TabIndex = 13
        Me.User.Text = "Username:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(334, 321)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(86, 13)
        Me.LinkLabel1.TabIndex = 21
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forgot Password"
        '
        'ADMIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(746, 425)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.time)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Pass)
        Me.Controls.Add(Me.User)
        Me.Controls.Add(Me.showBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ADMIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kirei Salon"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents showBtn As Button
    Friend WithEvents btnReg As Button
    Friend WithEvents time As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Pass As Label
    Friend WithEvents User As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
