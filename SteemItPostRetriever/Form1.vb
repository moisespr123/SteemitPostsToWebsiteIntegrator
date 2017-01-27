Public Class Form1
    Protected pageContent As String = ""
    Private counter As Integer = 0
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If WebBrowser1.Url().ToString = "about:blank" = False And counter = 0 Then
            Try
                pageContent = WebBrowser1.DocumentText
                'SQL Info
                Dim MySQLConnString = "server=" & TextBox2.Text & ";Port=" & TextBox3.Text & ";Database=" & TextBox6.Text & ";Uid=" & TextBox4.Text & ";Pwd=" & TextBox5.Text & ";Check Parameters=false;default command timeout=999;Connection Timeout=999;Pooling=false;allow user variables=true;"
                Dim truncateSQL = "TRUNCATE TABLE posts"
                Dim SQLConnection = New MySql.Data.MySqlClient.MySqlConnection(MySQLConnString)
                SQLConnection.Open()
                Dim SQLCommand1 As New MySql.Data.MySqlClient.MySqlCommand(truncateSQL, SQLConnection)
                SQLCommand1.ExecuteNonQuery()
                Dim parse1 As CsQuery.CQ = CsQuery.CQ.Create(pageContent, CsQuery.HtmlParsingMode.Auto, CsQuery.HtmlParsingOptions.IgnoreComments)
                Dim parseArticle As CsQuery.CQ = parse1("article.PostSummary.hentry.with-image")
                Dim SteemItURL As String = "https://steemit.com"
                Dim SQLInsert As String = ""
                For Each div In parseArticle
                    Dim innerHTML As CsQuery.CQ = div.InnerHTML
                    Dim link As String = innerHTML("div.PostSummary__content > div.PostSummary__header.show-for-medium > h3 > a").Attr("href")
                    Dim header As String = innerHTML("div.PostSummary__content > div.PostSummary__header.show-for-medium > h3 > a").Text()
                    Dim content As String = innerHTML("div.PostSummary__content > div.PostSummary__body.entry-content > a").Text()
                    Dim imagesource As String = innerHTML("a.PostSummary__image").Css("background-image")
                    Dim Resteemed As Integer = 0
                    If innerHTML("div.PostSummary__reblogged_by").Text() = " Resteemed" Then Resteemed = 1
                    SQLInsert += "INSERT INTO posts (header, content, link, image, resteemed) VALUES ('" & header.Replace("'", "\'") & "', '" & content.Replace("'", "\'").Replace("…", "...") & "', '" & SteemItURL + link & "', '" & imagesource.Remove(imagesource.Length - 1, 1).Remove(0, 4) & "', '" & Resteemed & "'); " & vbNewLine
                    If CheckBox1.Checked = True Then
                        SQLInsert += "UPDATE options SET value = '1' WHERE options = 'ShowResteemedPosts';"
                    Else
                        SQLInsert += "UPDATE options SET value = '0' WHERE options = 'ShowResteemedPosts';"
                    End If
                Next
                Dim SQLConnection2 = New MySql.Data.MySqlClient.MySqlConnection(MySQLConnString)
                SQLConnection2.Open()
                Dim SQLCommand2 As New MySql.Data.MySqlClient.MySqlCommand(SQLInsert, SQLConnection2)
                SQLCommand2.ExecuteNonQuery()
                counter = 1
                MsgBox("Posts added to database")
            Catch ex As Exception
                MsgBox("An error has occured. Please check the error below: " & vbNewLine & ex.ToString)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ValidationError As Boolean = False
        Dim ValidationErrorText As String = "The following fields are empty. Please fill them in order to populate the MySQL Server table with your Steemit Posts:" & vbNewLine
        If String.IsNullOrEmpty(TextBox1.Text) Then
            ValidationError = True
            ValidationErrorText += "-Steemit Account username is empty" & vbNewLine
        End If
        If String.IsNullOrEmpty(TextBox2.Text) Then
            ValidationError = True
            ValidationErrorText += "-MySQL Server Address is empty" & vbNewLine
        End If
        If String.IsNullOrEmpty(TextBox3.Text) = False Then
            If IsNumeric(TextBox3.Text) = False Then
                ValidationError = True
                ValidationErrorText += "-MySQL Server Port is not numeric" & vbNewLine
            End If
        Else
            ValidationError = True
            ValidationErrorText += "-MySQL Server Port is empty" & vbNewLine
        End If
        If String.IsNullOrEmpty(TextBox6.Text) Then
            ValidationError = True
            ValidationErrorText += "-MySQL Server Database is empty" & vbNewLine
        End If
        If String.IsNullOrEmpty(TextBox4.Text) Then
            ValidationError = True
            ValidationErrorText += "-MySQL Server Username is empty" & vbNewLine
        End If
        If String.IsNullOrEmpty(TextBox5.Text) Then
            ValidationError = True
            ValidationErrorText += "-MySQL Server Password is empty"
        End If
        If ValidationError = False Then
            Dim writer As New System.IO.StreamWriter("SteemitPostsToWebsiteConfig.conf", False)
            writer.WriteLine("Account=" & TextBox1.Text)
            writer.WriteLine("Server=" & TextBox2.Text)
            writer.WriteLine("Port=" & TextBox3.Text)
            writer.WriteLine("Database=" & TextBox6.Text)
            writer.WriteLine("Username=" & TextBox4.Text)
            writer.WriteLine("Password=" & TextBox5.Text)
            writer.WriteLine("ShowResteemedPosts=" & CheckBox1.Checked)
            writer.Close()
            counter = 0
            WebBrowser1.Navigate("https://steemit.com/@" + TextBox1.Text)
        Else
            MsgBox(ValidationErrorText)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim line As String
        Dim getdata As String()
        Dim result As String
        Try
            Using reader As New System.IO.StreamReader("SteemitPostsToWebsiteConfig.conf")
                While Not reader.EndOfStream
                    line = reader.ReadLine()
                    If line.Contains("Account") Then
                        getdata = line.Split("=")
                        result = getdata(1)
                        TextBox1.Text = result
                    ElseIf line.Contains("Server") Then
                        getdata = line.Split("=")
                        result = getdata(1)
                        TextBox2.Text = result
                    ElseIf line.Contains("Port") Then
                        getdata = line.Split("=")
                        result = getdata(1)
                        TextBox3.Text = result
                    ElseIf line.Contains("Database") Then
                        getdata = line.Split("=")
                        result = getdata(1)
                        TextBox6.Text = result
                    ElseIf line.Contains("Username") Then
                        getdata = line.Split("=")
                        result = getdata(1)
                        TextBox4.Text = result
                    ElseIf line.Contains("Password") Then
                        getdata = line.Split("=")
                        result = getdata(1)
                        TextBox5.Text = result
                    ElseIf line.Contains("ShowResteemedPosts") Then
                        getdata = line.Split("=")
                        result = getdata(1)
                        If result = True Then CheckBox1.Checked = True Else CheckBox1.Checked = False
                    End If
                End While
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Donations_Addresses.ShowDialog()
    End Sub
End Class
