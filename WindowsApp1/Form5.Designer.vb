<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtus = New System.Windows.Forms.TextBox()
        Me.btndone = New System.Windows.Forms.Button()
        Me.dtpSched = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbservices = New System.Windows.Forms.ComboBox()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(74, 72)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.ReadOnly = True
        Me.txtFname.Size = New System.Drawing.Size(116, 20)
        Me.txtFname.TabIndex = 0
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(196, 72)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.ReadOnly = True
        Me.txtLname.Size = New System.Drawing.Size(116, 20)
        Me.txtLname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(28, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name:"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(645, 143)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.ReadOnly = True
        Me.txtemail.Size = New System.Drawing.Size(116, 20)
        Me.txtemail.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe Script", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label6.Location = New System.Drawing.Point(136, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(245, 30)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Welcome to Kirei Salon"
        '
        'txtus
        '
        Me.txtus.Location = New System.Drawing.Point(645, 117)
        Me.txtus.Name = "txtus"
        Me.txtus.ReadOnly = True
        Me.txtus.Size = New System.Drawing.Size(116, 20)
        Me.txtus.TabIndex = 53
        '
        'btndone
        '
        Me.btndone.BackColor = System.Drawing.Color.Transparent
        Me.btndone.Location = New System.Drawing.Point(62, 329)
        Me.btndone.Name = "btndone"
        Me.btndone.Size = New System.Drawing.Size(75, 22)
        Me.btndone.TabIndex = 62
        Me.btndone.Text = "Done"
        Me.btndone.UseVisualStyleBackColor = False
        '
        'dtpSched
        '
        Me.dtpSched.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSched.Location = New System.Drawing.Point(370, 135)
        Me.dtpSched.Name = "dtpSched"
        Me.dtpSched.Size = New System.Drawing.Size(127, 20)
        Me.dtpSched.TabIndex = 61
        Me.dtpSched.Value = New Date(2021, 11, 20, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(338, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Choose Appointment Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(194, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Price:"
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(214, 135)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.ReadOnly = True
        Me.txtprice.Size = New System.Drawing.Size(116, 20)
        Me.txtprice.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(26, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Services Description:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(26, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Services Available:"
        '
        'cmbservices
        '
        Me.cmbservices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbservices.FormattingEnabled = True
        Me.cmbservices.Location = New System.Drawing.Point(62, 134)
        Me.cmbservices.Name = "cmbservices"
        Me.cmbservices.Size = New System.Drawing.Size(116, 21)
        Me.cmbservices.TabIndex = 55
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(62, 182)
        Me.txtdesc.Multiline = True
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.ReadOnly = True
        Me.txtdesc.Size = New System.Drawing.Size(435, 141)
        Me.txtdesc.TabIndex = 54
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(143, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 22)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "LogOut"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(521, 375)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btndone)
        Me.Controls.Add(Me.dtpSched)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbservices)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.txtus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtFname)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scheduling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtus As TextBox
    Friend WithEvents btndone As Button
    Friend WithEvents dtpSched As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtprice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbservices As ComboBox
    Friend WithEvents txtdesc As TextBox
    Friend WithEvents Button1 As Button
End Class
