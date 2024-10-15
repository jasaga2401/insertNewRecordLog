Imports MySql.Data.MySqlClient

Public Class log

    Dim connectionString As String = "Server=localhost;Database=dbinsertrecordexample;User ID=root;Password=12Yellow34!"


    Private Sub log_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadLogData()

    End Sub


    Private Sub LoadLogData()

        Dim logList As New DataTable

        Using conn As New MySqlConnection(connectionString)

            conn.Open()

            Using cmd As New MySqlCommand("sp_get_log_data", conn)

                cmd.CommandType = CommandType.StoredProcedure

                Dim adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(logList)

                dvgLog.DataSource = logList

            End Using

        End Using



    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click

        Form1.Show()
        Me.Hide()

    End Sub
End Class