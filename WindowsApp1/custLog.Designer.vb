<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ha
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ha))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnReg = New System.Windows.Forms.Button()
        Me.time = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Pass = New System.Windows.Forms.Label()
        Me.User = New System.Windows.Forms.Label()
        Me.showBtn = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'btnReg
        '
        Me.btnReg.Location = New System.Drawing.Point(315, 274)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(85, 41)
        Me.btnReg.TabIndex = 52
        Me.btnReg.Text = "Register"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'time
        '
        Me.time.AutoSize = True
        Me.time.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.time.Location = New System.Drawing.Point(389, 251)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(0, 13)
        Me.time.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 50.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(120, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 106)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Kirei Salon"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(207, 274)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(85, 41)
        Me.btnLogin.TabIndex = 49
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(287, 228)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(141, 20)
        Me.txtPass.TabIndex = 48
        Me.txtPass.UseSystemPasswordChar = True
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(287, 184)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(141, 20)
        Me.txtUser.TabIndex = 47
        '
        'Pass
        '
        Me.Pass.AutoSize = True
        Me.Pass.BackColor = System.Drawing.Color.Transparent
        Me.Pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pass.Location = New System.Drawing.Point(132, 217)
        Me.Pass.Name = "Pass"
        Me.Pass.Size = New System.Drawing.Size(142, 31)
        Me.Pass.TabIndex = 46
        Me.Pass.Text = "Password:"
        '
        'User
        '
        Me.User.AutoSize = True
        Me.User.BackColor = System.Drawing.Color.Transparent
        Me.User.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User.Location = New System.Drawing.Point(132, 173)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(147, 31)
        Me.User.TabIndex = 45
        Me.User.Text = "Username:"
        '
        'showBtn
        '
        Me.showBtn.BackColor = System.Drawing.SystemColors.Control
        Me.showBtn.FlatAppearance.BorderSize = 0
        Me.showBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.showBtn.Location = New System.Drawing.Point(434, 225)
        Me.showBtn.Name = "showBtn"
        Me.showBtn.Size = New System.Drawing.Size(57, 24)
        Me.showBtn.TabIndex = 44
        Me.showBtn.Text = "Show"
        Me.showBtn.UseMnemonic = False
        Me.showBtn.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(261, 318)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(86, 13)
        Me.LinkLabel1.TabIndex = 53
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forgot Password"
        '
        'ha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(685, 385)
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
        Me.Name = "ha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CUSTOMER LOG IN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnReg As Button
    Friend WithEvents time As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Pass As Label
    Friend WithEvents User As Label
    Friend WithEvents showBtn As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
