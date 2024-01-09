Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Net.Mail
Public Class Form5
    Public connection As New MySqlConnection("host=localhost; user=root; password=;database=try;")
    Public adptr As New MySqlDataAdapter
    Public ds As New DataSet
    Public table As New DataTable
    Public Shared toUser As String

    Dim command As MySqlCommand
    Dim dataReader As MySqlDataReader
    Private Sub txtus_TextChanged(sender As Object, e As EventArgs) Handles txtus.TextChanged

        connection.Close()
        connection.Open()
        command = New MySqlCommand("Select * from customer where cust_username = '" & txtus.Text & "'", connection)
        dataReader = command.ExecuteReader
        While dataReader.Read
            Dim LName = dataReader.GetString("cust_Lname")
            Dim Fname = dataReader.GetString("cust_Fname")
            Dim email = dataReader.GetString("cust_email")

            txtLname.Text = LName
            txtFname.Text = Fname
            txtemail.Text = email
        End While

        If txtus.Text = Nothing Then
            txtFname.Clear()
            txtLname.Clear()
            txtemail.Clear()
        End If
        connection.Close()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbservices.Items.Clear()
        connection.Open()
        command = New MySqlCommand("select service_name from services ", connection)
        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim colName = dataReader.GetString("service_name")
            cmbservices.Items.Add(colName)
        End While
        connection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ha.txtUser.Clear()
        ha.txtPass.Clear()
        txtus.Clear()
        Me.Close()
        ha.Show()
    End Sub

    Private Sub cmbservices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbservices.SelectedIndexChanged
        connection.Close()
        connection.Open()
        command = New MySqlCommand("Select * from services where service_name = '" & cmbservices.Text & "'", connection)
        dataReader = command.ExecuteReader
        While dataReader.Read
            Dim price = dataReader.GetString("price")
            Dim desc = dataReader.GetString("service_desc")


            txtprice.Text = price
            txtdesc.Text = desc

        End While
        connection.Close()
    End Sub

    Private Sub btndone_Click(sender As Object, e As EventArgs) Handles btndone.Click
        connection.Close()
        connection.Open()
        command = New MySqlCommand("Insert into schedule (sched_Sname, sched_Price, sched_custUS, sched_date) values (@sname, @P, @US, @date)", connection)
        command.Parameters.Add(New MySqlParameter("@sname", MySqlDbType.VarChar, 50)).Value = cmbservices.Text
        command.Parameters.Add(New MySqlParameter("@P", MySqlDbType.VarChar, 50)).Value = txtprice.Text
        command.Parameters.Add(New MySqlParameter("@US", MySqlDbType.VarChar, 50)).Value = txtus.Text
        command.Parameters.Add(New MySqlParameter("@date", dtpSched.Value.Date))
        command.ExecuteNonQuery()

        connection.Close()

        Dim from, pass, messagebody As String
        Dim rand As Random = New Random()
        Dim message As MailMessage = New MailMessage()
        toUser = txtemail.Text
        'from = "arboledamhelarthur@gmail.com"
        'pass = "aR6s2A3D"
        from = "viadurango0227@gmail.com"
        pass = "Via200127"
        messagebody = "GOOD DAY OUR PRECIOUS CUSTOMER! " & txtFname.Text.ToUpper & vbCrLf & vbCrLf &
            "You have been set an appointment date on " & dtpSched.Value & " with a service of " & cmbservices.Text & " worth " & txtprice.Text & "." & vbCrLf &
            "Please come around 9am to 7pm on that day. We will wait for your presence. Or please contact 09284043118!" & vbCrLf & vbCrLf & "Have a Good Day Ahead! :)"
        message.To.Add(toUser)
        message.From = New MailAddress(from)
        message.Body = messagebody
        message.Subject = "Schedule Information"
        Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com")
        smtp.EnableSsl = True
        smtp.Port = 587
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network
        smtp.UseDefaultCredentials = False
        smtp.Credentials = New NetworkCredential(from, pass)
        Try
            smtp.Send(message)
            MessageBox.Show("Schedule has been set. Please Check Your Email.", "Scheduling", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtus.Clear()
            txtemail.Clear()
            ha.txtUser.Clear()
            ha.txtPass.Clear()
            Me.Close()
            ha.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class