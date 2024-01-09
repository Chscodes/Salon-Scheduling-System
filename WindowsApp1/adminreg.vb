Imports System.Data
Imports MySql.Data.MySqlClient
Public Class adminreg
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=try;")
    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Private Sub txbEmail_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Public Sub register()
        If txbPass.Text <> TextBox4.Text Then
            MessageBox.Show("Please type same passwords")
        Else
            connection.Open()
            command = New MySqlCommand("Insert into employee (emp_fname, emp_Lname, emp_MN, emp_username, emp_pass, emp_Add, emp_email, emp_Cnum, emp_gender)
                                    values (@fname, @lname, @mn, @US, @pass, @add, @email, @num, @gen)", connection)
            command.Parameters.Add(New MySqlParameter("@fname", MySqlDbType.VarChar, 50)).Value = txbName.Text
            command.Parameters.Add(New MySqlParameter("@lname", MySqlDbType.VarChar, 50)).Value = TextBox1.Text
            command.Parameters.Add(New MySqlParameter("@mn", MySqlDbType.VarChar, 50)).Value = TextBox2.Text
            command.Parameters.Add(New MySqlParameter("@US", MySqlDbType.VarChar, 50)).Value = txbUser.Text
            command.Parameters.Add(New MySqlParameter("@pass", MySqlDbType.VarChar, 50)).Value = txbPass.Text
            command.Parameters.Add(New MySqlParameter("@add", MySqlDbType.VarChar, 50)).Value = TextBox3.Text
            command.Parameters.Add(New MySqlParameter("@email", MySqlDbType.VarChar, 50)).Value = txbEmail.Text
            command.Parameters.Add(New MySqlParameter("@num", MySqlDbType.VarChar, 50)).Value = txbNum.Text
            command.Parameters.Add(New MySqlParameter("@gen", MySqlDbType.VarChar, 50)).Value = ComboBox1.Text
            command.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("Information has been registered!")
            Me.Hide()
            ADMIN.Show()

        End If
    End Sub

    Private Sub Regbtn_Click(sender As Object, e As EventArgs)
        register()
        '   Dim con As SqlConnection = New SqlConnection("Data Source=AETH;Initial Catalog=userreg;Integrated Security=True")
        '   Dim cmd As SqlCommand = New SqlCommand("INSERT INTO [dbo].[userreg]
        '      ([Name]
        '      ,[Username]
        '      ,[Password]
        '      ,[Phone]
        '      ,[Email])
        'VALUES
        '      ('" + txbName.Text + "','" + txbUser.Text + "', '" + txbPass.Text + "', '" + txbEmail.Text + "', '" + txbNum.Text + "')", con)
        '   con.Open()
        '   cmd.ExecuteNonQuery()
        '   MessageBox.Show("you are now registered", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '   con.Close()



    End Sub

    Private Sub Regbtn_Click_2(sender As Object, e As EventArgs) Handles Regbtn.Click
        register()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        ADMIN.Show()
    End Sub
End Class