Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports Microsoft.VisualBasic.FileIO
Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Imports System.Net

Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Insert.Click
        Try
            Dim cardno As Integer = TextCardNumber.Text
            Dim cardname As String = TextCardName.Text
            Dim type As String = ""
            If RadioMonster.Checked = True Then
                type = "Monster"
            ElseIf RadioSpell.Checked Then
                type = "Spell"
            Else
                type = "Trap"
            End If
            Dim insertdate As DateTime = DateTimePickerInsert.Text
            Dim cardstatus As String = ""
            If RadioForbidden.Checked = True Then
                cardstatus = "Forbidden"
            ElseIf RadioLimited.Checked Then
                cardstatus = "Limited"
            Else
                cardstatus = "Unlimited"
            End If


            Dim connString As String

            'Connection String to connect with MySQL database.
            connString = "server=localhost;port=3306;userid=root;password=user;database=yugioh"

            Dim conn As New MySqlConnection(connString)

            conn.Open()
            Dim InsertCommand As String

            InsertCommand = "INSERT INTO card(CardNumber,CardName, Type, InsertDate, CardStatus) VALUES(@cardno,@cardname,@type, @insertdate, @cardstatus)"

            Dim cmd = New MySqlCommand(InsertCommand, conn)

            cmd.Parameters.AddWithValue("@cardno", cardno)
            cmd.Parameters.AddWithValue("@cardname", cardname)
            cmd.Parameters.AddWithValue("@type", type)
            cmd.Parameters.AddWithValue("@insertdate", insertdate)
            cmd.Parameters.AddWithValue("@cardstatus", cardstatus)
            cmd.Prepare()

            cmd.ExecuteNonQuery()
            MessageBox.Show("Records Inserted")
            LoadDataInGrid()
            conn.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub LoadDataInGrid()
        Dim connString As String

        'Connection String to connect with MySQL database.
        connString = "server=localhost;port=3306;userid=root;password=user;database=yugioh"

        Dim conn As New MySqlConnection(connString)

        conn.Open()
        Dim ViewCommand As String

        ViewCommand = "select * from yugioh.card"

        Dim cmd = New MySqlCommand(ViewCommand, conn)

        Dim sda As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataInGrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Update.Click
        Try
            Dim cardno As Integer = TextCardNumber.Text
            Dim cardnoOriginal As Integer = cardno
            Dim cardname As String = TextCardName.Text
            Dim type As String = ""
            If RadioMonster.Checked = True Then
                type = "Monster"
            ElseIf RadioSpell.Checked Then
                type = "Spell"
            Else
                type = "Trap"
            End If
            Dim insertdate As DateTime = DateTimePickerInsert.Text
            Dim cardstatus As String = ""
            If RadioForbidden.Checked = True Then
                cardstatus = "Forbidden"
            ElseIf RadioLimited.Checked Then
                cardstatus = "Limited"
            Else
                cardstatus = "Unlimited"
            End If


            Dim connString As String

            'Connection String to connect with MySQL database.
            connString = "server=localhost;port=3306;userid=root;password=user;database=yugioh"

            Dim conn As New MySqlConnection(connString)

            conn.Open()
            Dim UpdateCommand As String

            UpdateCommand = "UPDATE card SET CardNumber = @cardno, CardName = @cardname,Type = @type, InsertDate = @insertdate, CardStatus = @cardstatus WHERE CardNumber = @cardno OR Cardname = @cardname"

            Dim cmd = New MySqlCommand(UpdateCommand, conn)

            cmd.Parameters.AddWithValue("@cardno", cardno)
            cmd.Parameters.AddWithValue("@cardname", cardname)
            cmd.Parameters.AddWithValue("@type", type)
            cmd.Parameters.AddWithValue("@insertdate", insertdate)
            cmd.Parameters.AddWithValue("@cardstatus", cardstatus)
            cmd.Prepare()

            cmd.ExecuteNonQuery()
            MessageBox.Show("Record Updated")
            LoadDataInGrid()
            conn.Close()


        Catch ex As Exception
            Console.WriteLine(ex.Message)

        End Try
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        'Try


        Dim connString As String

        'Connection String to connect with MySQL database.
        connString = "server=localhost;port=3306;userid=root;password=user;database=yugioh"

        Dim conn As New MySqlConnection(connString)
        conn.Open()
        Dim DeleteCommand As String

        If String.IsNullOrWhiteSpace(TextCardNumber.Text) = False Then
            Dim cardno As Integer = TextCardNumber.Text
            Dim cardname As String = TextCardName.Text
            DeleteCommand = "DELETE from card WHERE CardNumber = @cardno"
            MessageBox.Show("Record(s) Deleted")

            Dim cmd = New MySqlCommand(DeleteCommand, conn)

            cmd.Parameters.AddWithValue("@cardno", cardno)
            cmd.Parameters.AddWithValue("@cardname", cardname)
            cmd.Prepare()

            cmd.ExecuteNonQuery()
            LoadDataInGrid()
            conn.Close()
        ElseIf String.IsNullOrWhiteSpace(TextCardNumber.Text) = True Then
            MessageBox.Show("Specify the Card Number")

        End If


        'Catch ex As Exception
        'Console.WriteLine(ex.Message)
        'End Try
    End Sub

    Private Sub ButtonFind_Click(sender As Object, e As EventArgs) Handles ButtonFind.Click
        Try
            Dim cardno As Integer = TextCardNumber.Text


            Dim connString As String

            'Connection String to connect with MySQL database.
            connString = "server=localhost;port=3306;userid=root;password=user;database=yugioh"

            Dim conn As New MySqlConnection(connString)

            conn.Open()
            Dim FindCommand As String

            FindCommand = "Select * FROM card WHERE CardNumber = @cardno"

            Dim cmd = New MySqlCommand(FindCommand, conn)

            cmd.Parameters.AddWithValue("@cardno", cardno)
            cmd.Prepare()

            cmd.ExecuteNonQuery()

            Dim sda As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            sda.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cardname As String = TextCardName.Text

            Dim connString As String

            'Connection String to connect with MySQL database.
            connString = "server=localhost;port=3306;userid=root;password=user;database=yugioh"

            Dim conn As New MySqlConnection(connString)

            conn.Open()
            Dim FindCommand As String

            FindCommand = "Select * FROM card WHERE CardName = @cardname"

            Dim cmd = New MySqlCommand(FindCommand, conn)

            cmd.Parameters.AddWithValue("@cardname", cardname)
            cmd.Prepare()

            cmd.ExecuteNonQuery()

            Dim sda As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            sda.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim type As String = ""
            If RadioMonster.Checked = True Then
                type = "Monster"
            ElseIf RadioSpell.Checked Then
                type = "Spell"
            Else
                type = "Trap"
            End If

            Dim connString As String

            'Connection String to connect with MySQL database.
            connString = "server=localhost;port=3306;userid=root;password=user;database=yugioh"

            Dim conn As New MySqlConnection(connString)

            conn.Open()
            Dim FindCommand As String

            FindCommand = "Select * FROM card WHERE Type = @type"

            Dim cmd = New MySqlCommand(FindCommand, conn)

            cmd.Parameters.AddWithValue("@type", type)
            cmd.Prepare()

            cmd.ExecuteNonQuery()

            Dim sda As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            sda.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try
            Dim insertdate As DateTime = DateTimePickerInsert.Text

            Dim connString As String

            'Connection String to connect with MySQL database.
            connString = "server=localhost;port=3306;userid=root;password=user;database=yugioh"

            Dim conn As New MySqlConnection(connString)

            conn.Open()
            Dim FindCommand As String

            FindCommand = "Select * FROM card WHERE InsertDate = @insertdate"

            Dim cmd = New MySqlCommand(FindCommand, conn)

            cmd.Parameters.AddWithValue("@insertdate", insertdate)
            cmd.Prepare()

            cmd.ExecuteNonQuery()

            Dim sda As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            sda.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Try
            Dim cardstatus As String = ""
            If RadioForbidden.Checked = True Then
                cardstatus = "Forbidden"
            ElseIf RadioLimited.Checked Then
                cardstatus = "Limited"
            Else
                cardstatus = "Unlimited"
            End If

            Dim connString As String

            'Connection String to connect with MySQL database.
            connString = "server=localhost;port=3306;userid=root;password=user;database=yugioh"

            Dim conn As New MySqlConnection(connString)

            conn.Open()
            Dim FindCommand As String

            FindCommand = "Select * FROM card WHERE CardStatus = @cardstatus"

            Dim cmd = New MySqlCommand(FindCommand, conn)

            cmd.Parameters.AddWithValue("@cardstatus", cardstatus)
            cmd.Prepare()

            cmd.ExecuteNonQuery()

            Dim sda As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            sda.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        LoadDataInGrid()
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Login_Register.Show()
        Login_Register.TextBoxPasswordLogin.Clear()
        Me.Hide()
    End Sub

    Private Sub ExportTable_Click(sender As Object, e As EventArgs) Handles ExportTable.Click
        Dim connectionString As String = "Server=localhost;Database=yugioh;Uid=root;Pwd=user;"
        Dim tableName As String = "card"

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Retrieve the data from the database
            Dim query As String = "SELECT * FROM " + tableName
            Dim command As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            ' Prompt the user to choose a save file location
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv"
            saveFileDialog.Title = "Export table as CSV"
            saveFileDialog.ShowDialog()

            If saveFileDialog.FileName <> "" Then
                ' Write the data to the CSV file
                Using writer As New StreamWriter(saveFileDialog.FileName)
                    ' Write the column headers
                    For i As Integer = 0 To reader.FieldCount - 1
                        writer.Write(reader.GetName(i))
                        If i < reader.FieldCount - 1 Then
                            writer.Write(",")
                        End If
                    Next
                    writer.WriteLine()

                    ' Write the data rows
                    While reader.Read()
                        For i As Integer = 0 To reader.FieldCount - 1
                            If Not reader.IsDBNull(i) Then
                                writer.Write(reader(i).ToString())
                            End If
                            If i < reader.FieldCount - 1 Then
                                writer.Write(",")
                            End If
                        Next
                        writer.WriteLine()
                    End While
                End Using

                MessageBox.Show("Export complete!")
            End If

            reader.Close()
            connection.Close()
        End Using
    End Sub

    Private Sub ImportDatabase_Click(sender As Object, e As EventArgs) Handles ImportDatabase.Click
        'Show the OpenFileDialog to let the user select a CSV file.
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"

        Dim connStr As String = "server=localhost;user=root;database=yugioh;port=3306;password=user;"
        Dim conn As New MySqlConnection(connStr)
        conn.Open()

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            'Create a new DataTable object to store the CSV data.
            Dim dataTable As New DataTable()

            'Open the CSV file using the TextFieldParser class.
            Using parser As New TextFieldParser(openFileDialog.FileName)
                parser.TextFieldType = FieldType.Delimited
                parser.SetDelimiters(",")
                parser.HasFieldsEnclosedInQuotes = True

                'Read the CSV file line by line.
                While Not parser.EndOfData
                    Dim fields = parser.ReadFields()

                    'Add the first row as column headers.
                    If dataTable.Columns.Count = 0 Then
                        For Each field In fields
                            dataTable.Columns.Add(field)
                        Next
                    Else
                        'Add a new row to the DataTable.
                        dataTable.Rows.Add(fields)
                    End If
                End While
            End Using

            'Set the DataTable as the DataSource of the DataGridView.
            DataGridView1.DataSource = dataTable
            'LoadDataInGrid()

            Dim dropTableQuery As String = "DROP TABLE IF EXISTS card"
            Using cmdDrop As New MySqlCommand(dropTableQuery, conn)
                cmdDrop.ExecuteNonQuery()
            End Using

            Dim createTableQuery As String = "CREATE TABLE card (CardNumber INT, CardName VARCHAR(45), Type VARCHAR(45), InsertDate VARCHAR(45), CardStatus VARCHAR(45))"
            Using cmdCreate As New MySqlCommand(createTableQuery, conn)
                cmdCreate.ExecuteNonQuery()
            End Using

            Dim cmd As New MySqlCommand()
            cmd.Connection = conn
            For Each row As DataRow In dataTable.Rows
                cmd.CommandText = "INSERT INTO card (CardNumber, CardName, Type, InsertDate, CardStatus) VALUES (@col1, @col2, @col3, @col4, @col5) ON DUPLICATE KEY UPDATE CardNumber=@col1, CardName=@col2, Type=@col3, InsertDate=@col4, Cardstatus=@col5"
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@col1", row(1))
                cmd.Parameters.AddWithValue("@col2", row(2))
                cmd.Parameters.AddWithValue("@col3", row(3))
                cmd.Parameters.AddWithValue("@col4", row(4))
                cmd.Parameters.AddWithValue("@col5", row(5))
                cmd.ExecuteNonQuery()
            Next

            ' Clean up
            conn.Close()
            MessageBox.Show("Import successful!")
        End If
    End Sub

    Private Sub GenerateReportButton_Click(sender As Object, e As EventArgs) Handles GenerateReportButton.Click
        'Dim connectionString As String = "Server=localhost;Database=yugioh;Uid=root;Pwd=user;"
        'Dim tableName As String = "card"

        Dim connectionString As String = "Server=localhost;Database=yugioh;Uid=root;Pwd=user;"

        Dim excelApp As New Excel.Application
        Dim excelWorkbook As Excel.Workbook = excelApp.Workbooks.Add()
        Dim excelWorksheet As Excel.Worksheet = excelWorkbook.Sheets("Sheet1")

        'Dim excelWorksheet As Excel.Worksheet = CType(excelWorkbook.Sheets.Add(), Excel.Worksheet)

        Dim sqlQuery As String = "SELECT Type, COUNT(*) as Count FROM card GROUP BY Type"
        Dim sqlConnection As New MySqlConnection(connectionString)
        Dim sqlCommand As New MySqlCommand(sqlQuery, sqlConnection)
        sqlConnection.Open()
        Dim sqlReader As MySqlDataReader = sqlCommand.ExecuteReader()

        Dim countSpell As Integer = 0
        Dim countTrap As Integer = 0
        Dim countMonster As Integer = 0

        While sqlReader.Read()
            Dim value As String = sqlReader("Type")
            Dim count As Integer = Convert.ToInt32(sqlReader("Count"))
            ' do something with the value and count, such as add them to a dictionary or list
            If value = "Spell" Then
                countSpell = count
            ElseIf value = "Trap" Then
                countTrap = count
            ElseIf value = "Monster" Then
                countMonster = count
            End If
        End While


        excelWorksheet.Range("A1, B1").Interior.Color = RGB(0, 0, 0)
        excelWorksheet.Range("A1, B1").Font.Color = RGB(255, 255, 255)
        excelWorksheet.Cells(1, 1) = "Category"
        excelWorksheet.Cells(1, 2) = "Value"
        excelWorksheet.Cells(2, 1) = "Spell"
        excelWorksheet.Cells(2, 2) = countSpell
        excelWorksheet.Cells(3, 1) = "Trap"
        excelWorksheet.Cells(3, 2) = countTrap
        excelWorksheet.Cells(4, 1) = "Monster"
        excelWorksheet.Cells(4, 2) = countMonster

        'Dim chartLocation As Excel.Range = excelWorksheet.Range("D5:J20")

        ' select the data to use for the circle graph
        Dim chartRange As Excel.Range = excelWorksheet.Range("A1:B4")

        ' create a new chart and set its type to pie
        Dim chartObjects As Excel.ChartObjects = excelWorksheet.ChartObjects()
        Dim chartObject As Excel.ChartObject = chartObjects.Add(100, 100, 200, 200)
        Dim chart As Excel.Chart = chartObject.Chart
        chart.ChartType = Excel.XlChartType.xlPie

        ' format the chart and apply styling
        chart.SetSourceData(Source:=chartRange)
        chart.ChartTitle.Text = ""
        Try
            ' add an image to the worksheet
            Dim appPath As String = Application.StartupPath
            Dim imageFilePath As String = Path.Combine(appPath, "Resources\Yugioh_Logo_Black.png")

            Dim imageShape As Excel.Shape = excelWorksheet.Shapes.AddPicture(imageFilePath,
            Microsoft.Office.Core.MsoTriState.msoFalse,
            Microsoft.Office.Core.MsoTriState.msoTrue, 0, 0, 100, 50)

            ' position the image above the chart
            imageShape.Top = chartObject.Top - imageShape.Height - 10 ' adjust the offset as needed
            imageShape.Left = chartObject.Left + (chartObject.Width - imageShape.Width) / 2
        Catch ex As Exception
        End Try

        chart.Legend.Position = Excel.XlLegendPosition.xlLegendPositionBottom

        ' calculate the top-left corner of cell D5
        Dim cellD5 As Excel.Range = excelWorksheet.Range("D5")
        Dim chartTop As Double = cellD5.Top
        Dim chartLeft As Double = cellD5.Left

        ' set the chart location to cell D5
        chartObject.Top = chartTop
        chartObject.Left = chartLeft


        Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim excelFilePath As String = Path.Combine(desktopPath, "YuGiOh Report.xlsx")
        excelWorkbook.SaveAs(excelFilePath)
        excelWorkbook.Close()
        excelApp.Quit()

        releaseObject(excelWorksheet)
        releaseObject(chartObject)
        releaseObject(chartObjects)
        releaseObject(chart)
        releaseObject(excelWorkbook)
        releaseObject(excelApp)
        sqlReader.Close()
        sqlConnection.Close()

        MessageBox.Show("Export complete!")

    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class


