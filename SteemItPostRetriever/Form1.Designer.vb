<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.AccountNameText = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.MySQLServerText = New System.Windows.Forms.Label()
        Me.MySQLPortText = New System.Windows.Forms.Label()
        Me.MySQLUsernameText = New System.Windows.Forms.Label()
        Me.MySQLPasswordText = New System.Windows.Forms.Label()
        Me.MySQLDatabaseText = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SoftwareDescriptionText = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(568, 288)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(100, 53)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        Me.WebBrowser1.Visible = False
        '
        'AccountNameText
        '
        Me.AccountNameText.AutoSize = True
        Me.AccountNameText.Location = New System.Drawing.Point(12, 9)
        Me.AccountNameText.Name = "AccountNameText"
        Me.AccountNameText.Size = New System.Drawing.Size(147, 13)
        Me.AccountNameText.TabIndex = 1
        Me.AccountNameText.Text = "Enter Steemit Account Name:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(15, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 51)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Get Posts"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(15, 67)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(158, 20)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(15, 112)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(158, 20)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Text = "3306"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(15, 209)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(158, 20)
        Me.TextBox4.TabIndex = 5
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(15, 259)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TextBox5.Size = New System.Drawing.Size(158, 20)
        Me.TextBox5.TabIndex = 6
        '
        'MySQLServerText
        '
        Me.MySQLServerText.AutoSize = True
        Me.MySQLServerText.Location = New System.Drawing.Point(12, 51)
        Me.MySQLServerText.Name = "MySQLServerText"
        Me.MySQLServerText.Size = New System.Drawing.Size(79, 13)
        Me.MySQLServerText.TabIndex = 8
        Me.MySQLServerText.Text = "MySQL Server:"
        '
        'MySQLPortText
        '
        Me.MySQLPortText.AutoSize = True
        Me.MySQLPortText.Location = New System.Drawing.Point(12, 96)
        Me.MySQLPortText.Name = "MySQLPortText"
        Me.MySQLPortText.Size = New System.Drawing.Size(64, 13)
        Me.MySQLPortText.TabIndex = 9
        Me.MySQLPortText.Text = "MySQL Port"
        '
        'MySQLUsernameText
        '
        Me.MySQLUsernameText.AutoSize = True
        Me.MySQLUsernameText.Location = New System.Drawing.Point(12, 193)
        Me.MySQLUsernameText.Name = "MySQLUsernameText"
        Me.MySQLUsernameText.Size = New System.Drawing.Size(96, 13)
        Me.MySQLUsernameText.TabIndex = 10
        Me.MySQLUsernameText.Text = "MySQL Username:"
        '
        'MySQLPasswordText
        '
        Me.MySQLPasswordText.AutoSize = True
        Me.MySQLPasswordText.Location = New System.Drawing.Point(12, 243)
        Me.MySQLPasswordText.Name = "MySQLPasswordText"
        Me.MySQLPasswordText.Size = New System.Drawing.Size(94, 13)
        Me.MySQLPasswordText.TabIndex = 11
        Me.MySQLPasswordText.Text = "MySQL Password:"
        '
        'MySQLDatabaseText
        '
        Me.MySQLDatabaseText.AutoSize = True
        Me.MySQLDatabaseText.Location = New System.Drawing.Point(12, 145)
        Me.MySQLDatabaseText.Name = "MySQLDatabaseText"
        Me.MySQLDatabaseText.Size = New System.Drawing.Size(94, 13)
        Me.MySQLDatabaseText.TabIndex = 12
        Me.MySQLDatabaseText.Text = "MySQL Database:"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(15, 161)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(158, 20)
        Me.TextBox6.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.SoftwareDescriptionText)
        Me.GroupBox1.Location = New System.Drawing.Point(191, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 330)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "About:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(9, 291)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(274, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Donate me Bitcoin, Gridcoin, Burstcoin or STEEM"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SoftwareDescriptionText
        '
        Me.SoftwareDescriptionText.AutoSize = True
        Me.SoftwareDescriptionText.Location = New System.Drawing.Point(6, 19)
        Me.SoftwareDescriptionText.Name = "SoftwareDescriptionText"
        Me.SoftwareDescriptionText.Size = New System.Drawing.Size(280, 260)
        Me.SoftwareDescriptionText.TabIndex = 0
        Me.SoftwareDescriptionText.Text = resources.GetString("SoftwareDescriptionText.Text")
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(15, 292)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(139, 17)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Show Resteemed Posts"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Location = New System.Drawing.Point(191, 345)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(143, 45)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Language"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(9, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton1.TabIndex = 17
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "English"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(74, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(63, 17)
        Me.RadioButton2.TabIndex = 18
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Español"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 401)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.MySQLDatabaseText)
        Me.Controls.Add(Me.MySQLPasswordText)
        Me.Controls.Add(Me.MySQLUsernameText)
        Me.Controls.Add(Me.MySQLPortText)
        Me.Controls.Add(Me.MySQLServerText)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.AccountNameText)
        Me.Controls.Add(Me.WebBrowser1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Steemit Posts to Website Integrator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents AccountNameText As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents MySQLServerText As Label
    Friend WithEvents MySQLPortText As Label
    Friend WithEvents MySQLUsernameText As Label
    Friend WithEvents MySQLPasswordText As Label
    Friend WithEvents MySQLDatabaseText As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SoftwareDescriptionText As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
