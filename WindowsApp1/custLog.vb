Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class ha
    Dim username As String = forgotpass.toUser

    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=try;")
    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        '       If (txtVerPass.Text.Equals(txtVerNewPass.Text)) Then
        '           Dim con As SqlConnection = New SqlConnection("Data Source=AETH;Initial Catalog=forgotvb;Integrated Security=True")
        '           Dim cmd As SqlCommand = New SqlCommand("UPDATE [dbo].[loginforget]
        '  SET [username] = '" + username + "',
        '     ,[password] = '" + txtVerNewPass.Text + "'
        'WHERE [username]='" + username + "'", con)
        '           con.Open()
        '           cmd.ExecuteNonQuery()
        '           MessageBox.Show("password reseted successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '           con.Close()
        '       Else
        '           MessageBox.Show("Please enter the same password")
        '       End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        'If txtVerPass.Text = txtVerNewPass.Text Then
        '    connection.Open()
        '    command = New MySqlCommand("UPDATE employee SET emp_pass ='" & txtVerPass.Text & "' where emp_username ='" & TextBox1.Text & "'", connection)
        '    dataReader = command.ExecuteReader
        '    MessageBox.Show("Your Password has been Updated", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    connection.Close()
        '    Dim sc As SendCode = New SendCode()
        '    sc.Close()
        '    Me.Close()
        '    Salon.Show()
        'Else
        '    MessageBox.Show("Please enter same password!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        connection.Open()
        command = New MySqlCommand("select * from customer where cust_username='" & txtUser.Text & "' and cust_pass='" & txtPass.Text & "'", connection)
        dataReader = command.ExecuteReader
        Dim Login As Integer
        Login = 0
        While dataReader.Read
            Login = Login + 1
        End While

        If Login = 1 Then
            Dim f5 As New Form5
            f5.txtus.Text = txtUser.Text
            Me.Hide()
            f5.ShowDialog()

        Else
            MessageBox.Show("Username and Password don't Match!")
        End If
        connection.Close()
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        Me.Hide()
        Form1.ShowDialog()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form2.ShowDialog()
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
End Class