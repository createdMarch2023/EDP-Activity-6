Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class Login_Register

    Private Sub CheckBoxShowPass1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPass1.CheckedChanged
        'CHECKING IF THE CHECKBOX WAS CHECKED OR NOT.
        If CheckBoxShowPass1.CheckState = CheckState.Checked Then
            'IF TRUE, IT SHOWS THE TEXT
            TextBoxPasswordLogin.UseSystemPasswordChar = False
        Else
            'IF FALSE, IT WILL HIDE THE TEXT AND IT WILL TURN INTO BULLETS.
            TextBoxPasswordLogin.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub CheckBoxShowPass2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPass2.CheckedChanged

        'CHECKING IF THE CHECKBOX WAS CHECKED OR NOT.
        If CheckBoxShowPass2.CheckState = CheckState.Checked Then
            'IF TRUE, IT SHOWS THE TEXT
            TextBoxPasswordRegister.UseSystemPasswordChar = False
        Else
            'IF FALSE, IT WILL HIDE THE TEXT AND IT WILL TURN INTO BULLETS.
            TextBoxPasswordRegister.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click

        'Try
        Dim usernameRegister As String = TextBoxUsernameRegister.Text
            Dim passwordRegister As String = TextBoxPasswordRegister.Text
            Dim confirmPassRegister As String = TextBoxConfirmPassRegister.Text

            Dim connString As String

            'Connection String to connect with MySQL database.
            connString = "server=localhost;port=3306;userid=root;password=user;database=yugioh"

            Dim conn As New MySqlConnection(connString)

            conn.Open()

            'checking
            If confirmPassRegister = passwordRegister Then
                Dim FindCommand As String
                FindCommand = "Select * from users where Username = '" & usernameRegister & "'"

                Dim find = New MySqlCommand(FindCommand, conn)
                Dim dr As MySqlDataReader
                dr = find.ExecuteReader

            If dr.HasRows Then      'This checks if any duplicates exist
                MsgBox("Username already exists")
                TextBoxPasswordRegister.Clear()
                TextBoxConfirmPassRegister.Clear()
                TextBoxUsernameRegister.Clear()
            Else
                dr.Close()
                Dim InsertCommand As String
                    InsertCommand = "INSERT INTO users(Username, Password) VALUES(@usernameregister, @passwordregister)"

                    Dim cmd = New MySqlCommand(InsertCommand, conn)

                    cmd.Parameters.AddWithValue("@usernameregister", usernameRegister)
                    cmd.Parameters.AddWithValue("@passwordregister", passwordRegister)
                    cmd.Prepare()

                    If cmd.ExecuteNonQuery() > 0 Then
                        LabelRegisterIcon.Visible = True
                    Else
                        MessageBox.Show("Failed to Register User")
                    End If

                    conn.Close()
                End If

            Else
                MessageBox.Show("Password Doesn't Match")
            End If


            'Catch ex As Exception
        'Console.WriteLine(ex.Message)
        'End Try


    End Sub

    Private Sub ButtonEnter_Click(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Try
            Dim usernameLogin As String = TextBoxUsernameLogin.Text
            Dim passwordLogin As String = TextBoxPasswordLogin.Text

            Dim connString As String

            'Connection String to connect with MySQL database.
            connString = "server=localhost;port=3306;userid=root;password=user;database=yugioh"

            Dim conn As New MySqlConnection(connString)

            conn.Open()
            Dim FindCommand As String

            FindCommand = "SELECT * FROM users WHERE username = @usernamelogin AND password = @passwordlogin"

            Dim cmd = New MySqlCommand(FindCommand, conn)

            cmd.Parameters.AddWithValue("@usernamelogin", usernameLogin)
            cmd.Parameters.AddWithValue("@passwordlogin", passwordLogin)
            cmd.Prepare()

            cmd.ExecuteNonQuery()

            'FILLING THE DATA IN A SPECIFIC TABLE OF THE DATABASE
            Dim da As New MySqlDataAdapter
            da.SelectCommand = cmd

            Dim dt As New DataTable
            da.Fill(dt)
            Dim maxrow As Integer = dt.Rows.Count
            'CHECKING IF THE DATA IS EXIST IN THE ROW OF THE TABLE
            If maxrow > 0 Then
                Form1.Show()
                Me.Hide()
            Else
                MessageBox.Show("Login Failed")
            End If

            conn.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    'Display Login Panel
    Private Sub ButtonGoToLogin_Click(sender As Object, e As EventArgs) Handles ButtonGoToLogin.Click
        TextBoxPasswordLogin.Clear()
        TextBoxUsernameLogin.Clear()

        PictureBox2.Visible = True
        PictureBox3.Visible = False
        PanelLogin.Visible = True
        PanelRegister.Visible = False
        LabelRegisterIcon.Visible = False
        Me.DoubleBuffered = True
    End Sub

    'Display Register Panel
    Private Sub ButtonGoToRegister_Click(sender As Object, e As EventArgs) Handles ButtonGoToRegister.Click
        TextBoxPasswordRegister.Clear()
        TextBoxUsernameRegister.Clear()
        TextBoxConfirmPassRegister.Clear()

        PictureBox2.Visible = False
        PictureBox3.Visible = True
        PanelLogin.Visible = False
        PanelRegister.Visible = True
        LabelRegisterIcon.Visible = False
        Me.DoubleBuffered = True
    End Sub

    Private Sub Login_Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxPasswordLogin.UseSystemPasswordChar = True
        TextBoxPasswordRegister.UseSystemPasswordChar = True
        TextBoxConfirmPassRegister.UseSystemPasswordChar = True

        ButtonGoToLogin.PerformClick()
        Me.DoubleBuffered = True
    End Sub
End Class