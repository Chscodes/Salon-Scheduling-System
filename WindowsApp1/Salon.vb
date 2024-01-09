Imports MySql.Data.MySqlClient
Public Class ADMIN
    Dim attemp As Integer = 0

    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=try;")
    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader

    Private Sub btnLogin_Click(sender As Object, e As EventArgs)
        If txtUser.Text = Nothing Or txtPass.Text = Nothing Then
            MessageBox.Show("Please Input the needed!")
            Return
        End If
        'Dim con As SqlConnection = New SqlConnection("Data Source=AETH;Initial Catalog=vbmultiuser;Integrated Security=True")
        'Dim cmd As SqlCommand = New SqlCommand("select * from login where username= '" & txtUser.Text & "' and password='" & txtPass.Text & "'and usertype='" & cmbUsertype.SelectedItem & "'", con)
        'Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        'Dim dt As DataTable = New DataTable()
        'sda.Fill(dt)

        'If String.IsNullOrEmpty(txtUser.Text) Then
        '    MsgBox("username is required")
        'ElseIf String.IsNullOrEmpty(txtPass.Text) Then
        '    MsgBox("password is required")
        'ElseIf String.IsNullOrEmpty(cmbUsertype.Text) Then
        '    MsgBox("usertype is required")
        'ElseIf (dt.Rows.Count > 0) Then
        '    MessageBox.Show("Login as " + dt.Rows(0)(2))
        '    If (cmbUsertype.SelectedIndex = 0) Then
        '        Dim o As New Owner
        '        o.Show()
        '        Me.Hide()
        '    Else
        '        Dim c As New Customer
        '        c.Show()
        '        Me.Hide()
        '    End If
        'Else
        '    MessageBox.Show("Invalid username or password")
        '    attemp += 1
        '    If attemp = 3 Then
        '        txtUser.Enabled = False
        '        txtPass.Enabled = False
        '        btnLogin.Enabled = False
        '        MessageBox.Show("You Already Use your 3 Attempt, Temporary Closed in 30 Sec")
        '        If Timer1.Enabled = True Then
        '            Timer1.Start()
        '        Else
        '            time.Text = 30
        '            time.ForeColor = Color.Black
        '            Timer1.Start()
        '        End If

        '    End If
        'End If
        'con.Close()
        connection.Open()
            command = New MySqlCommand("select * from employee where emp_username='" & txtUser.Text & "' and emp_pass='" & txtPass.Text & "'", connection)
            dataReader = command.ExecuteReader
            Dim Login As Integer
            Login = 0
            While dataReader.Read
                Login = Login + 1
            End While

            If Login = 1 Then
                Me.Hide()
                Dim o As New Owner
                o.ShowDialog()

            Else
                MessageBox.Show("Username and Password don't Match!")
            End If
            connection.Close()

    End Sub

    Private Sub showBtn_Click(sender As Object, e As EventArgs) Handles showBtn.Click
        If txtPass.UseSystemPasswordChar = True Then

            txtPass.UseSystemPasswordChar = False
            Me.showBtn.Text = "Hide"

        Else

            txtPass.UseSystemPasswordChar = True
            Me.showBtn.Text = "Show"

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPass.UseSystemPasswordChar = True


    End Sub

    Private Sub User_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtUser_LostFocus(sender As Object, e As EventArgs)
        Dim n As Integer
        If Len(txtUser.Text) = 0 Then
            Exit Sub
        Else
            For i = 0 To Len(txtUser.Text) - 1
                n = Asc(txtUser.Text(i))
                If (n < 48) Or ((n > 57) And (n < 65)) Or ((n > 90) And (n < 97)) Or (n > 122) Then
                    MsgBox("Invalid username cointains special character")
                    txtUser.Clear()
                    txtUser.Focus()
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        Timer1.Interval = 1000


        If time.Text = 0 Then
            attemp = 0
            time.Text = 30
            txtUser.Enabled = True
            txtPass.Enabled = True
            btnLogin.Enabled = True
            Timer1.Stop()
            time.ForeColor = Color.Transparent


        Else
            time.Text = Val(time.Text) - 1
        End If
    End Sub

    Private Sub TxtPass_LostFocus(sender As Object, e As EventArgs)
        Dim n As Integer
        If Len(txtPass.Text) = 0 Then
            Exit Sub
        Else
            For i = 0 To Len(txtPass.Text) - 1
                n = Asc(txtPass.Text(i))
                If (n < 48) Or ((n > 57) And (n < 65)) Or ((n > 90) And (n < 97)) Or (n > 122) Then
                    MsgBox("Invalid password cointains special character")
                    txtPass.Clear()
                    txtPass.Focus()
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs)
        'If cmbUsertype.Text = "Owner" Then
        '    userreg.Show()
        '    Me.Hide()
        'ElseIf cmbUsertype.Text = "Customer" Then
        '    Form1.Show()
        '    Me.Hide()
        'ElseIf cmbUsertype.Text = "" Then
        '    MessageBox.Show("Please select a user type")
        'End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Dim sc As forgotpass = New forgotpass()
        sc.Show()
        Me.Hide()
    End Sub


    Private Sub btnReg_Click_1(sender As Object, e As EventArgs) Handles btnReg.Click
        adminreg.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        connection.Open()
        command = New MySqlCommand("select * from employee where emp_username='" & txtUser.Text & "' and emp_pass='" & txtPass.Text & "'", connection)
        dataReader = command.ExecuteReader
        Dim Login As Integer
        Login = 0
        While dataReader.Read
            Login = Login + 1
        End While

        If Login = 1 Then
            txtUser.Clear()
            txtPass.Clear()
            Me.Hide()
            Dim o As New Owner
            o.ShowDialog()

        Else
            MessageBox.Show("Username and Password don't Match!")
        End If
        connection.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        forgotpass.Show()
    End Sub
End Class
