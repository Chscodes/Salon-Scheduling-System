Imports MySql.Data.MySqlClient
Public Class Form4
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=try;")
    Public adptr As New MySqlDataAdapter
    Public ds As New DataSet
    Public table As New DataTable
    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddgv()
    End Sub
    Public Sub loaddgv()
        connection.Open()
        command = New MySqlCommand("select cust_username as 'Customer UserName', cust_Fname as 'First Name', cust_Lname as 'Last Name', 
        cust_MN as 'Middle Name',cust_Gender as 'Gender', cust_Add as 'Address', cust_Cnum as 'Number', cust_email as 'Email' from customer", connection)
        adptr.SelectCommand = command
        table.Clear()
        adptr.Fill(table)
        DataGridView1.DataSource = table
        connection.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim o As New Owner
        Me.Close()
        o.Show()
    End Sub
End Class