<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ButtonGoToLogin = New System.Windows.Forms.Button()
        Me.ButtonGoToRegister = New System.Windows.Forms.Button()
        Me.PanelLogin = New System.Windows.Forms.Panel()
        Me.CheckBoxShowPass1 = New System.Windows.Forms.CheckBox()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.TextBoxPasswordLogin = New System.Windows.Forms.TextBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.TextBoxUsernameLogin = New System.Windows.Forms.TextBox()
        Me.LabelRegisterIcon = New System.Windows.Forms.Label()
        Me.PanelRegister = New System.Windows.Forms.Panel()
        Me.CheckBoxShowPass2 = New System.Windows.Forms.CheckBox()
        Me.TextBoxConfirmPassRegister = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.TextBoxPasswordRegister = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxUsernameRegister = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PanelLogin.SuspendLayout()
        Me.PanelRegister.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonGoToLogin
        '
        Me.ButtonGoToLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGoToLogin.Location = New System.Drawing.Point(57, 47)
        Me.ButtonGoToLogin.Name = "ButtonGoToLogin"
        Me.ButtonGoToLogin.Size = New System.Drawing.Size(90, 34)
        Me.ButtonGoToLogin.TabIndex = 0
        Me.ButtonGoToLogin.Text = "Login"
        Me.ButtonGoToLogin.UseVisualStyleBackColor = True
        '
        'ButtonGoToRegister
        '
        Me.ButtonGoToRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGoToRegister.Location = New System.Drawing.Point(57, 108)
        Me.ButtonGoToRegister.Name = "ButtonGoToRegister"
        Me.ButtonGoToRegister.Size = New System.Drawing.Size(90, 32)
        Me.ButtonGoToRegister.TabIndex = 1
        Me.ButtonGoToRegister.Text = "Register"
        Me.ButtonGoToRegister.UseVisualStyleBackColor = True
        '
        'PanelLogin
        '
        Me.PanelLogin.BackColor = System.Drawing.Color.Transparent
        Me.PanelLogin.Controls.Add(Me.CheckBoxShowPass1)
        Me.PanelLogin.Controls.Add(Me.ButtonEnter)
        Me.PanelLogin.Controls.Add(Me.TextBoxPasswordLogin)
        Me.PanelLogin.Controls.Add(Me.LabelPassword)
        Me.PanelLogin.Controls.Add(Me.LabelUsername)
        Me.PanelLogin.Controls.Add(Me.TextBoxUsernameLogin)
        Me.PanelLogin.Location = New System.Drawing.Point(34, 123)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Size = New System.Drawing.Size(476, 314)
        Me.PanelLogin.TabIndex = 3
        '
        'CheckBoxShowPass1
        '
        Me.CheckBoxShowPass1.AutoSize = True
        Me.CheckBoxShowPass1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.CheckBoxShowPass1.Location = New System.Drawing.Point(97, 115)
        Me.CheckBoxShowPass1.Name = "CheckBoxShowPass1"
        Me.CheckBoxShowPass1.Size = New System.Drawing.Size(75, 24)
        Me.CheckBoxShowPass1.TabIndex = 5
        Me.CheckBoxShowPass1.Text = "Show"
        Me.CheckBoxShowPass1.UseVisualStyleBackColor = True
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEnter.Location = New System.Drawing.Point(14, 200)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(90, 30)
        Me.ButtonEnter.TabIndex = 4
        Me.ButtonEnter.Text = "Enter"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'TextBoxPasswordLogin
        '
        Me.TextBoxPasswordLogin.Location = New System.Drawing.Point(17, 144)
        Me.TextBoxPasswordLogin.Name = "TextBoxPasswordLogin"
        Me.TextBoxPasswordLogin.Size = New System.Drawing.Size(184, 26)
        Me.TextBoxPasswordLogin.TabIndex = 3
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelPassword.Location = New System.Drawing.Point(13, 115)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(78, 20)
        Me.LabelPassword.TabIndex = 2
        Me.LabelPassword.Text = "Password"
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelUsername.Location = New System.Drawing.Point(13, 48)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(83, 20)
        Me.LabelUsername.TabIndex = 1
        Me.LabelUsername.Text = "Username"
        '
        'TextBoxUsernameLogin
        '
        Me.TextBoxUsernameLogin.Location = New System.Drawing.Point(17, 71)
        Me.TextBoxUsernameLogin.Name = "TextBoxUsernameLogin"
        Me.TextBoxUsernameLogin.Size = New System.Drawing.Size(184, 26)
        Me.TextBoxUsernameLogin.TabIndex = 0
        '
        'LabelRegisterIcon
        '
        Me.LabelRegisterIcon.AutoSize = True
        Me.LabelRegisterIcon.BackColor = System.Drawing.Color.Transparent
        Me.LabelRegisterIcon.Font = New System.Drawing.Font("Mom´sTypewriter", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRegisterIcon.ForeColor = System.Drawing.Color.Green
        Me.LabelRegisterIcon.Location = New System.Drawing.Point(312, 322)
        Me.LabelRegisterIcon.Name = "LabelRegisterIcon"
        Me.LabelRegisterIcon.Size = New System.Drawing.Size(223, 31)
        Me.LabelRegisterIcon.TabIndex = 5
        Me.LabelRegisterIcon.Text = "[ Registered ]"
        '
        'PanelRegister
        '
        Me.PanelRegister.BackColor = System.Drawing.Color.Transparent
        Me.PanelRegister.Controls.Add(Me.CheckBoxShowPass2)
        Me.PanelRegister.Controls.Add(Me.TextBoxConfirmPassRegister)
        Me.PanelRegister.Controls.Add(Me.Label3)
        Me.PanelRegister.Controls.Add(Me.ButtonRegister)
        Me.PanelRegister.Controls.Add(Me.TextBoxPasswordRegister)
        Me.PanelRegister.Controls.Add(Me.Label1)
        Me.PanelRegister.Controls.Add(Me.Label2)
        Me.PanelRegister.Controls.Add(Me.TextBoxUsernameRegister)
        Me.PanelRegister.Location = New System.Drawing.Point(37, 123)
        Me.PanelRegister.Name = "PanelRegister"
        Me.PanelRegister.Size = New System.Drawing.Size(476, 317)
        Me.PanelRegister.TabIndex = 5
        '
        'CheckBoxShowPass2
        '
        Me.CheckBoxShowPass2.AutoSize = True
        Me.CheckBoxShowPass2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.CheckBoxShowPass2.Location = New System.Drawing.Point(100, 97)
        Me.CheckBoxShowPass2.Name = "CheckBoxShowPass2"
        Me.CheckBoxShowPass2.Size = New System.Drawing.Size(75, 24)
        Me.CheckBoxShowPass2.TabIndex = 7
        Me.CheckBoxShowPass2.Text = "Show"
        Me.CheckBoxShowPass2.UseVisualStyleBackColor = True
        '
        'TextBoxConfirmPassRegister
        '
        Me.TextBoxConfirmPassRegister.Location = New System.Drawing.Point(20, 188)
        Me.TextBoxConfirmPassRegister.Name = "TextBoxConfirmPassRegister"
        Me.TextBoxConfirmPassRegister.Size = New System.Drawing.Size(195, 26)
        Me.TextBoxConfirmPassRegister.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(16, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Confirm Password"
        '
        'ButtonRegister
        '
        Me.ButtonRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRegister.Location = New System.Drawing.Point(20, 236)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(90, 30)
        Me.ButtonRegister.TabIndex = 4
        Me.ButtonRegister.Text = "Accept"
        Me.ButtonRegister.UseVisualStyleBackColor = True
        '
        'TextBoxPasswordRegister
        '
        Me.TextBoxPasswordRegister.Location = New System.Drawing.Point(20, 123)
        Me.TextBoxPasswordRegister.Name = "TextBoxPasswordRegister"
        Me.TextBoxPasswordRegister.Size = New System.Drawing.Size(195, 26)
        Me.TextBoxPasswordRegister.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(16, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(13, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'TextBoxUsernameRegister
        '
        Me.TextBoxUsernameRegister.Location = New System.Drawing.Point(20, 54)
        Me.TextBoxUsernameRegister.Name = "TextBoxUsernameRegister"
        Me.TextBoxUsernameRegister.Size = New System.Drawing.Size(195, 26)
        Me.TextBoxUsernameRegister.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.belgado_act_4.My.Resources.Resources._1
        Me.PictureBox1.InitialImage = Global.belgado_act_4.My.Resources.Resources._1
        Me.PictureBox1.Location = New System.Drawing.Point(336, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 195)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.belgado_act_4.My.Resources.Resources._5LYzTBVoS196gvYvw3zjwKyXWV2x1zamMkFN6MdNsGk
        Me.PictureBox2.InitialImage = Global.belgado_act_4.My.Resources.Resources._5LYzTBVoS196gvYvw3zjwKyXWV2x1zamMkFN6MdNsGk
        Me.PictureBox2.Location = New System.Drawing.Point(153, 47)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(88, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.belgado_act_4.My.Resources.Resources._5LYzTBVoS196gvYvw3zjwKyXWV2x1zamMkFN6MdNsGk
        Me.PictureBox3.InitialImage = Global.belgado_act_4.My.Resources.Resources._5LYzTBVoS196gvYvw3zjwKyXWV2x1zamMkFN6MdNsGk
        Me.PictureBox3.Location = New System.Drawing.Point(153, 108)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(88, 20)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 36
        Me.PictureBox3.TabStop = False
        '
        'Login_Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.belgado_act_4.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(547, 461)
        Me.Controls.Add(Me.LabelRegisterIcon)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonGoToRegister)
        Me.Controls.Add(Me.ButtonGoToLogin)
        Me.Controls.Add(Me.PanelLogin)
        Me.Controls.Add(Me.PanelRegister)
        Me.Name = "Login_Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "initialization"
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        Me.PanelRegister.ResumeLayout(False)
        Me.PanelRegister.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonGoToLogin As Button
    Friend WithEvents ButtonGoToRegister As Button
    Friend WithEvents PanelLogin As Panel
    Friend WithEvents LabelUsername As Label
    Friend WithEvents TextBoxUsernameLogin As TextBox
    Friend WithEvents TextBoxPasswordLogin As TextBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PanelRegister As Panel
    Friend WithEvents ButtonRegister As Button
    Friend WithEvents TextBoxPasswordRegister As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxUsernameRegister As TextBox
    Friend WithEvents TextBoxConfirmPassRegister As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Public WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelRegisterIcon As Label
    Friend WithEvents CheckBoxShowPass1 As CheckBox
    Friend WithEvents CheckBoxShowPass2 As CheckBox
End Class
