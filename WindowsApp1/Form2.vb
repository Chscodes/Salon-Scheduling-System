Imports System.Net
Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Public Class Form2
    Dim randomCode As String
    Public Shared toUser As String


    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=try;")
    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Private Sub showBtn_Click(sender As Object, e As EventArgs)
        If txtVerPass.UseSystemPasswordChar = True Then

            txtVerPass.UseSystemPasswordChar = False
            txtVerNewPass.UseSystemPasswordChar = False
            Me.showBtn.Text = "Hide"

        Else

            txtVerPass.UseSystemPasswordChar = True
            txtVerNewPass.UseSystemPasswordChar = True
            Me.showBtn.Text = "Show"

        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If (txtVerify.Text.Equals(randomCode)) Then
            toUser = txtEmail.Text
            txtVerify.Text = Nothing

            GroupBox1.Enabled = False
            GroupBox3.Visible = True

            'Dim Reset As Reset = New Reset()
            'Reset.Show()
            ''Dim sc As SendCode = New SendCode()
            ''sc.Hide()
        Else
            MessageBox.Show("Invalid Code")
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If txtVerPass.Text = txtVerNewPass.Text Then
            connection.Close()
            connection.Open()
            command = New MySqlCommand("UPDATE customer SET cust_pass ='" & txtVerPass.Text & "' where cust_username ='" & TextBox1.Text & "'", connection)
            dataReader = command.ExecuteReader
            MessageBox.Show("Your Password has been Updated", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            Dim sc As forgotpass = New forgotpass()
            sc.Close()
            Me.Close()
            ha.Show()
        Else
            MessageBox.Show("Please enter same password!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim from, pass, messagebody As String
        Dim rand As Random = New Random()
        randomCode = (rand.Next(999999)).ToString()
        Dim message As MailMessage = New MailMessage()
        toUser = txtEmail.Text
        'from = "arboledamhelarthur@gmail.com"
        'pass = "aR6s2A3D"
        from = "viadurango0227@gmail.com"
        pass = "Via200127"
        messagebody = " Your verification code is " & randomCode
        message.To.Add(toUser)
        message.From = New MailAddress(from)
        message.Body = messagebody
        message.Subject = "Good Day Here is your verification code!"
        Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com")
        smtp.EnableSsl = True
        smtp.Port = 587
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network
        smtp.UseDefaultCredentials = False
        smtp.Credentials = New NetworkCredential(from, pass)
        Try
            smtp.Send(message)
            GroupBox2.Enabled = False
            GroupBox1.Visible = True
            MessageBox.Show("Please check your email")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        connection.Close()
        connection.Open()
        command = New MySqlCommand("Select * from customer where cust_username = '" & TextBox1.Text & "'", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim LName = dataReader.GetString("cust_Lname")
            Dim Fname = dataReader.GetString("cust_Fname")
            Dim add = dataReader.GetString("cust_Add")
            Dim email = dataReader.GetString("cust_email")

            TextBox3.Text = LName
            TextBox2.Text = Fname
            TextBox4.Text = add
            txtEmail.Text = email
        End While

        If TextBox1.Text = "" Then
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            txtEmail.Clear()
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        ha.Show()
    End Sub
End Class