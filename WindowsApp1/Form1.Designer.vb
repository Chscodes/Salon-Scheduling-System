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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbName = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.Label()
        Me.txbEmail = New System.Windows.Forms.TextBox()
        Me.txbNum = New System.Windows.Forms.TextBox()
        Me.txbPass = New System.Windows.Forms.TextBox()
        Me.txbUser = New System.Windows.Forms.TextBox()
        Me.Regbtn = New System.Windows.Forms.Button()
        Me.txtNum = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBox1.Location = New System.Drawing.Point(136, 156)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(169, 21)
        Me.ComboBox1.TabIndex = 94
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(69, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Gender:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(136, 260)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(170, 52)
        Me.TextBox3.TabIndex = 92
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(77, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Address"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(136, 102)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(170, 20)
        Me.TextBox1.TabIndex = 90
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(136, 128)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(170, 20)
        Me.TextBox2.TabIndex = 89
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(53, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Middle Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(69, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Lastname"
        '
        'txbName
        '
        Me.txbName.Location = New System.Drawing.Point(136, 73)
        Me.txbName.Name = "txbName"
        Me.txbName.Size = New System.Drawing.Size(170, 20)
        Me.txbName.TabIndex = 86
        '
        'txtName
        '
        Me.txtName.AutoSize = True
        Me.txtName.BackColor = System.Drawing.Color.Transparent
        Me.txtName.Location = New System.Drawing.Point(87, 76)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(35, 13)
        Me.txtName.TabIndex = 85
        Me.txtName.Text = "Name"
        '
        'txbEmail
        '
        Me.txbEmail.Location = New System.Drawing.Point(136, 318)
        Me.txbEmail.Name = "txbEmail"
        Me.txbEmail.Size = New System.Drawing.Size(170, 20)
        Me.txbEmail.TabIndex = 84
        '
        'txbNum
        '
        Me.txbNum.Location = New System.Drawing.Point(136, 344)
        Me.txbNum.Name = "txbNum"
        Me.txbNum.Size = New System.Drawing.Size(170, 20)
        Me.txbNum.TabIndex = 83
        '
        'txbPass
        '
        Me.txbPass.Location = New System.Drawing.Point(136, 208)
        Me.txbPass.Name = "txbPass"
        Me.txbPass.Size = New System.Drawing.Size(170, 20)
        Me.txbPass.TabIndex = 82
        Me.txbPass.UseSystemPasswordChar = True
        '
        'txbUser
        '
        Me.txbUser.Location = New System.Drawing.Point(136, 182)
        Me.txbUser.Name = "txbUser"
        Me.txbUser.Size = New System.Drawing.Size(170, 20)
        Me.txbUser.TabIndex = 81
        '
        'Regbtn
        '
        Me.Regbtn.Location = New System.Drawing.Point(136, 370)
        Me.Regbtn.Name = "Regbtn"
        Me.Regbtn.Size = New System.Drawing.Size(75, 23)
        Me.Regbtn.TabIndex = 80
        Me.Regbtn.Text = "Register"
        Me.Regbtn.UseVisualStyleBackColor = True
        '
        'txtNum
        '
        Me.txtNum.AutoSize = True
        Me.txtNum.BackColor = System.Drawing.Color.Transparent
        Me.txtNum.Location = New System.Drawing.Point(41, 347)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(84, 13)
        Me.txtNum.TabIndex = 79
        Me.txtNum.Text = "Contact Number"
        '
        'txtEmail
        '
        Me.txtEmail.AutoSize = True
        Me.txtEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtEmail.Location = New System.Drawing.Point(53, 321)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(72, 13)
        Me.txtEmail.TabIndex = 78
        Me.txtEmail.Text = "Email address"
        '
        'txtPass
        '
        Me.txtPass.AutoSize = True
        Me.txtPass.BackColor = System.Drawing.Color.Transparent
        Me.txtPass.Location = New System.Drawing.Point(74, 211)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(53, 13)
        Me.txtPass.TabIndex = 77
        Me.txtPass.Text = "Password"
        '
        'txtUser
        '
        Me.txtUser.AutoSize = True
        Me.txtUser.BackColor = System.Drawing.Color.Transparent
        Me.txtUser.Location = New System.Drawing.Point(67, 185)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(55, 13)
        Me.txtUser.TabIndex = 76
        Me.txtUser.Text = "Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe Script", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(73, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 42)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Kirei Salon"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(230, 370)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 95
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(136, 234)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(170, 20)
        Me.TextBox4.TabIndex = 97
        Me.TextBox4.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(31, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Confirm Password"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(348, 413)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txbName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txbEmail)
        Me.Controls.Add(Me.txbNum)
        Me.Controls.Add(Me.txbPass)
        Me.Controls.Add(Me.txbUser)
        Me.Controls.Add(Me.Regbtn)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Registration:"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txbName As TextBox
    Friend WithEvents txtName As Label
    Friend WithEvents txbEmail As TextBox
    Friend WithEvents txbNum As TextBox
    Friend WithEvents txbPass As TextBox
    Friend WithEvents txbUser As TextBox
    Friend WithEvents Regbtn As Button
    Friend WithEvents txtNum As Label
    Friend WithEvents txtEmail As Label
    Friend WithEvents txtPass As Label
    Friend WithEvents txtUser As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
End Class
