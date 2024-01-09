Imports MySql.Data.MySqlClient
Public Class Form3

    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=try;")
    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader

    Public ds As New DataSet
    Public table As New DataTable
    Public adptr As New MySqlDataAdapter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Or TextBox3.Text = Nothing Or TextBox2.Text = Nothing Then
            MessageBox.Show("Please fill the empty spaces", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            connection.Open()
            command = New MySqlCommand("Insert into services (service_name, service_desc, Price) values (@SN, @SD, @P)", connection)
            command.Parameters.Add(New MySqlParameter("@SN", MySqlDbType.VarChar, 50)).Value = TextBox1.Text
            command.Parameters.Add(New MySqlParameter("@SD", MySqlDbType.VarChar, 50)).Value = TextBox3.Text
            command.Parameters.Add(New MySqlParameter("@P", MySqlDbType.VarChar, 50)).Value = TextBox2.Text
            command.ExecuteNonQuery()
            MessageBox.Show("Service has been added successfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            loaddgv()
            TextBox4.Clear()
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddgv()
    End Sub
    Public Sub loaddgv()
        connection.Open()
        command = New MySqlCommand("select service_name as 'Service Name', service_desc as 'Service Description', Price as 'Price' from services", connection)
        adptr.SelectCommand = command
        table.Clear()
        adptr.Fill(table)
        DataGridView1.DataSource = table
        connection.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Dim o As New Owner
        o.Show()
        cleartext()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex < 0 Then Exit Sub
        TextBox1.Text = DataGridView1.Item(0, e.RowIndex).Value.ToString
        TextBox3.Text = DataGridView1.Item(1, e.RowIndex).Value.ToString
        TextBox2.Text = DataGridView1.Item(2, e.RowIndex).Value.ToString

        connection.Open()
        command = New MySqlCommand("Select * from services where service_name = '" & TextBox1.Text & "' and service_desc = '" & TextBox3.Text & "' ", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim Sid = dataReader.GetString("service_name")

            TextBox4.Text = Sid
            If TextBox4.Text = "" Then
                TextBox2.Clear()
                TextBox3.Clear()
            End If
        End While
        connection.Close()
    End Sub
    Public Sub cleartext()
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox3.Text = Nothing

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connection.Open()
        command = New MySqlCommand("update services SET service_name='" & TextBox1.Text & "', service_desc='" & TextBox3.Text & "', Price='" & TextBox2.Text & "' where service_name='" & TextBox4.Text & "'", connection)
        dataReader = command.ExecuteReader
        MessageBox.Show("Your Service is  Updated", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        connection.Close()
        TextBox4.Clear()
        loaddgv()
        cleartext()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        connection.Open()
        command = New MySqlCommand("Delete from services where service_name ='" & TextBox4.Text & "'", connection)
        dataReader = command.ExecuteReader
        MessageBox.Show("Data Has Been Delete", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        connection.Close()
        TextBox4.Clear()
        loaddgv()
        cleartext()
    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class