Imports MySql.Data.MySqlClient
Public Class Owner
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=try;")
    Public adptr As New MySqlDataAdapter
    Public ds As New DataSet
    Public table As New DataTable

    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form4.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        ADMIN.Show()
    End Sub

    Private Sub Owner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddgv()
    End Sub
    Public Sub loaddgv()
        connection.Close()
        connection.Open()
        command = New MySqlCommand("SELECT
                                        schedule.sched_ID AS 'ID',
                                        customer.cust_fname AS 'First Name',
                                        customer.cust_lname AS 'Last Name',
                                        schedule.sched_Sname AS 'Service Name',
                                        schedule.sched_price AS 'Price',
                                        schedule.sched_date AS 'Schedule',
                                        schedule.sched_issued AS 'Date Issued'
                                        
                                    FROM
                                        schedule
                                    INNER JOIN customer ON schedule.sched_custUS = customer.cust_username ", connection)
        adptr.SelectCommand = command
        table.Clear()
        adptr.Fill(table)
        DataGridView1.DataSource = table
        connection.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ques As Integer = MessageBox.Show("Is This Schedule Already been Fullfil? ", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ques = DialogResult.Yes Then
            connection.Open()
            command = New MySqlCommand("Delete from schedule where sched_ID  ='" & DataGridView1.SelectedRows(0).Cells(0).Value.ToString & "'", connection)
            dataReader = command.ExecuteReader
            MessageBox.Show("Data Has Been Delete")
            loaddgv()
            connection.Close()

        Else

        End If
    End Sub
End Class