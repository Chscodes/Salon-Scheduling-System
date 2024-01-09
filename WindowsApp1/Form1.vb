Imports MySql.Data.MySqlClient
Public Class Form1
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=try;")
    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Private Sub Regbtn_Click(sender As Object, e As EventArgs) Handles Regbtn.Click
        Try
            If txbPass.Text <> TextBox4.Text Then
                MessageBox.Show("Please type same passwords")
            Else
                connection.Open()
                command = New MySqlCommand("Insert into customer (cust_fname, cust_Lname, cust_MN, cust_username, cust_pass, cust_Add, cust_email, cust_Cnum, cust_gender)
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
                ha.Show()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        ha.Show()
    End Sub
End Class