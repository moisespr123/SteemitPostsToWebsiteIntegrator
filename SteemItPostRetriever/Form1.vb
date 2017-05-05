Public Class Form1
    Protected pageContent As String = ""
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If WebBrowser1.Url().ToString = "about:blank" = False Then
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
                    Dim imagesource As String = innerHTML("span.PostSummary__image").Css("background-image")
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
                Button1.Enabled = True
                If RadioButton1.Checked = True Then MsgBox("Posts added to database.") Else MsgBox("Posts añadidos a la Base de Datos.")
            Catch ex As Exception
                If RadioButton1.Checked = True Then MsgBox("An error has occured. Please check the error below: " & vbNewLine & ex.ToString) Else MsgBox("Ha ocurrido un error. Verifique el error a continuación: " & vbNewLine & ex.ToString)
                Button1.Enabled = True
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ValidationError As Boolean = False
        Dim ValidationErrorText As String = ""
        If RadioButton1.Checked Then ValidationErrorText = "The following fields are empty. Please fill them in order to populate the MySQL Server table with your Steemit Posts:" & vbNewLine Else ValidationErrorText = "Los siguientes campos están vacíos. Por favor, llénelos para poder transferir sus posts a la base de datos:" & vbNewLine
        If String.IsNullOrEmpty(TextBox1.Text) Then
            ValidationError = True
            If RadioButton1.Checked = True Then ValidationErrorText += "-Steemit Account username is empty" & vbNewLine Else ValidationErrorText += "-Nombre de usuario de Steemit está vacío" & vbNewLine
        End If
        If String.IsNullOrEmpty(TextBox2.Text) Then
            ValidationError = True
            If RadioButton1.Checked = True Then ValidationErrorText += "-MySQL Server Address is empty" & vbNewLine Else ValidationErrorText += "-Servidor MySQL está vacío" & vbNewLine
        End If
        If String.IsNullOrEmpty(TextBox3.Text) = False Then
            If IsNumeric(TextBox3.Text) = False Then
                ValidationError = True
                If RadioButton1.Checked = True Then ValidationErrorText += "-MySQL Server Port is not numeric" & vbNewLine Else ValidationErrorText += "-Puerto MySQL no es numérico" & vbNewLine
            End If
        Else
            ValidationError = True
            If RadioButton1.Checked = True Then ValidationErrorText += "-MySQL Server Port is empty" & vbNewLine Else ValidationErrorText += "-Puerto MySQL está vacío" & vbNewLine
        End If
        If String.IsNullOrEmpty(TextBox6.Text) Then
            ValidationError = True
            If RadioButton1.Checked = True Then ValidationErrorText += "-MySQL Server Database is empty" & vbNewLine Else ValidationErrorText += "-Base de Datos MySQL está vacío" & vbNewLine
        End If
        If String.IsNullOrEmpty(TextBox4.Text) Then
            ValidationError = True
            If RadioButton1.Checked = True Then ValidationErrorText += "-MySQL Server Username is empty" & vbNewLine Else ValidationErrorText += "-Nombre de usuario MySQL está vacío" & vbNewLine
        End If
        If String.IsNullOrEmpty(TextBox5.Text) Then
            ValidationError = True
            If RadioButton1.Checked = True Then ValidationErrorText += "-MySQL Server Password is empty" Else ValidationErrorText += "-Contraseña MySQL está vacío"
        End If
        If ValidationError = False Then
            My.Settings.Account = TextBox1.Text
            My.Settings.Server = TextBox2.Text
            My.Settings.Port = TextBox3.Text
            My.Settings.Database = TextBox6.Text
            My.Settings.Username = TextBox4.Text
            My.Settings.Password = TextBox5.Text
            My.Settings.ShowResteemedPosts = CheckBox1.Checked
            If RadioButton1.Checked = True Then
                My.Settings.Language = "English"
            Else
                My.Settings.Language = "Spanish"
            End If
            My.Settings.Save()
            Button1.Enabled = False
            WebBrowser1.Navigate("https://steemit.com/@" + TextBox1.Text)
        Else
            MsgBox(ValidationErrorText)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(My.Settings.Account) = False Then TextBox1.Text = My.Settings.Account
        If String.IsNullOrEmpty(My.Settings.Server) = False Then TextBox2.Text = My.Settings.Server
        If String.IsNullOrEmpty(My.Settings.Port) = False Then TextBox3.Text = My.Settings.Port
        If String.IsNullOrEmpty(My.Settings.Database) = False Then TextBox6.Text = My.Settings.Database
        If String.IsNullOrEmpty(My.Settings.Username) = False Then TextBox4.Text = My.Settings.Username
        If String.IsNullOrEmpty(My.Settings.Password) = False Then TextBox5.Text = My.Settings.Password
        If My.Settings.ShowResteemedPosts = True Then CheckBox1.Checked = True Else CheckBox1.Checked = False
        If String.IsNullOrEmpty(My.Settings.Language) = False Then
            If My.Settings.Language = "English" Then
                RadioButton1.Checked = True
            ElseIf My.Settings.Language = "Spanish" Then
                RadioButton2.Checked = True
            Else
                RadioButton1.Checked = True
            End If
        Else
            RadioButton1.Checked = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Donations_Addresses.ShowDialog()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        SoftwareDescriptionText.Text = My.Resources.EnglishDescription
        AccountNameText.Text = "Enter Steemit Account Name:"
        MySQLServerText.Text = "MySQL Server:"
        MySQLPortText.Text = "MySQL Port:"
        MySQLDatabaseText.Text = "MySQL Database:"
        MySQLUsernameText.Text = "MySQL Username:"
        MySQLPasswordText.Text = "MySQL Password:"
        CheckBox1.Text = "Show Resteemed Posts"
        Button1.Text = "Get Posts"
        Button2.Text = "Donate me Bitcoin, Gridcoin, Burstcoin or STEEM"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        SoftwareDescriptionText.Text = My.Resources.SpanishDescription
        AccountNameText.Text = "Entre su username de Steemit:"
        MySQLServerText.Text = "Servidor MySQL:"
        MySQLPortText.Text = "Puerto MySQL:"
        MySQLDatabaseText.Text = "Base de Datos MySQL:"
        MySQLUsernameText.Text = "Nombre de Usuario MySQL:"
        MySQLPasswordText.Text = "Contraseña MySQL:"
        CheckBox1.Text = "Mostrar Posts Resteemed"
        Button1.Text = "Transferir Posts"
        Button2.Text = "Donar Bitcoin, Gridcoin, Burstcoin o STEEM"
    End Sub
End Class
