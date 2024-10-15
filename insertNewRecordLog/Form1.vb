Imports System.Reflection
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Public Class Form1

    Dim connectionString As String = "Server=localhost; User ID=root; Password=12Yellow34!; Database=dbinsertrecordexample"
    Dim currentIndex As Integer = 0
    Dim customerList As New DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadCustomerData()
        displayUser(currentIndex)

    End Sub

    Private Sub LoadCustomerData()

        customerList.Clear()

        Using conn As New MySqlConnection(connectionString)

            conn.Open()

            Using cmd As New MySqlCommand("sp_get_customer_data", conn)

                cmd.CommandType = CommandType.StoredProcedure

                Dim adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(customerList)

            End Using

        End Using

    End Sub

    Private Sub displayUser(currentIndex As Integer)

        If customerList.Rows.Count > 0 AndAlso currentIndex >= 0 AndAlso currentIndex < customerList.Rows.Count Then

            txtUid.Text = customerList.Rows(currentIndex)("uid").ToString()
            txtTitle.Text = customerList.Rows(currentIndex)("title").ToString()
            txtForename.Text = customerList.Rows(currentIndex)("forename").ToString()
            txtSurname.Text = customerList.Rows(currentIndex)("surname").ToString()
            txtUsername.Text = customerList.Rows(currentIndex)("username").ToString()
            txtPassword.Text = customerList.Rows(currentIndex)("passwd").ToString()

        End If

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If currentIndex < customerList.Rows.Count - 1 Then
            currentIndex += 1
            displayUser(currentIndex)
        Else
            MsgBox("You are at the last record")
        End If

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click

        If currentIndex > 0 Then
            currentIndex -= 1
            displayUser(currentIndex)
        Else
            MsgBox("You are at the first record")
        End If

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        txtUid.Clear()
        txtTitle.Clear()
        txtForename.Clear()
        txtSurname.Clear()
        txtUsername.Clear()
        txtPassword.Clear()

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

        Using conn As New MySqlConnection(connectionString)

            conn.Open()

            Using cmd As New MySqlCommand("sp_insert_customer", conn)

                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@p_title", txtTitle.Text)
                cmd.Parameters.AddWithValue("@p_forename", txtForename.Text)
                cmd.Parameters.AddWithValue("@p_surname", txtSurname.Text)
                cmd.Parameters.AddWithValue("@p_username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@p_passwd", txtPassword.Text)

                cmd.ExecuteNonQuery()

                MessageBox.Show("New user inserted successfully!")

                LoadCustomerData()
                currentIndex = customerList.Rows.Count - 1
                displayUser(currentIndex)

            End Using

        End Using

    End Sub

    Private Sub lblOpenLog_Click(sender As Object, e As EventArgs) Handles lblOpenLog.Click

        log.Show()
        Me.Hide()

    End Sub
End Class
