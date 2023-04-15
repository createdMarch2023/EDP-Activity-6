<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextCardNumber = New System.Windows.Forms.TextBox()
        Me.TextCardName = New System.Windows.Forms.TextBox()
        Me.DateTimePickerInsert = New System.Windows.Forms.DateTimePicker()
        Me.RadioForbidden = New System.Windows.Forms.RadioButton()
        Me.RadioLimited = New System.Windows.Forms.RadioButton()
        Me.Insert = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RadioUnlimited = New System.Windows.Forms.RadioButton()
        Me.PanelStatus = New System.Windows.Forms.Panel()
        Me.RadioTrap = New System.Windows.Forms.RadioButton()
        Me.RadioSpell = New System.Windows.Forms.RadioButton()
        Me.RadioMonster = New System.Windows.Forms.RadioButton()
        Me.Update = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.ButtonFind = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Monster = New System.Windows.Forms.PictureBox()
        Me.Trap = New System.Windows.Forms.PictureBox()
        Me.Spell = New System.Windows.Forms.PictureBox()
        Me.Logout = New System.Windows.Forms.Label()
        Me.ExportTable = New System.Windows.Forms.Button()
        Me.ImportDatabase = New System.Windows.Forms.Button()
        Me.GenerateReportButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelStatus.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Monster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Trap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Spell, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mom´sTypewriter", 16.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.OliveDrab
        Me.Label1.Location = New System.Drawing.Point(229, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(386, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BeLGado Activity 4"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(35, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Card Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(35, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Card Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(35, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Card Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(35, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 29)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(35, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 29)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Insert Date"
        '
        'TextCardNumber
        '
        Me.TextCardNumber.Location = New System.Drawing.Point(236, 85)
        Me.TextCardNumber.Name = "TextCardNumber"
        Me.TextCardNumber.Size = New System.Drawing.Size(455, 26)
        Me.TextCardNumber.TabIndex = 7
        '
        'TextCardName
        '
        Me.TextCardName.Location = New System.Drawing.Point(236, 126)
        Me.TextCardName.Name = "TextCardName"
        Me.TextCardName.Size = New System.Drawing.Size(455, 26)
        Me.TextCardName.TabIndex = 8
        '
        'DateTimePickerInsert
        '
        Me.DateTimePickerInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerInsert.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerInsert.Location = New System.Drawing.Point(236, 227)
        Me.DateTimePickerInsert.Name = "DateTimePickerInsert"
        Me.DateTimePickerInsert.Size = New System.Drawing.Size(455, 30)
        Me.DateTimePickerInsert.TabIndex = 11
        '
        'RadioForbidden
        '
        Me.RadioForbidden.AutoSize = True
        Me.RadioForbidden.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioForbidden.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RadioForbidden.Location = New System.Drawing.Point(3, 3)
        Me.RadioForbidden.Name = "RadioForbidden"
        Me.RadioForbidden.Size = New System.Drawing.Size(134, 29)
        Me.RadioForbidden.TabIndex = 12
        Me.RadioForbidden.TabStop = True
        Me.RadioForbidden.Text = "Forbidden"
        Me.RadioForbidden.UseVisualStyleBackColor = True
        '
        'RadioLimited
        '
        Me.RadioLimited.AutoSize = True
        Me.RadioLimited.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioLimited.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RadioLimited.Location = New System.Drawing.Point(152, 3)
        Me.RadioLimited.Name = "RadioLimited"
        Me.RadioLimited.Size = New System.Drawing.Size(106, 29)
        Me.RadioLimited.TabIndex = 13
        Me.RadioLimited.TabStop = True
        Me.RadioLimited.Text = "Limited"
        Me.RadioLimited.UseVisualStyleBackColor = True
        '
        'Insert
        '
        Me.Insert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insert.Location = New System.Drawing.Point(236, 329)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(86, 38)
        Me.Insert.TabIndex = 14
        Me.Insert.Text = "Insert"
        Me.Insert.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(40, 397)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(748, 247)
        Me.DataGridView1.TabIndex = 15
        '
        'RadioUnlimited
        '
        Me.RadioUnlimited.AutoSize = True
        Me.RadioUnlimited.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioUnlimited.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RadioUnlimited.Location = New System.Drawing.Point(276, 3)
        Me.RadioUnlimited.Name = "RadioUnlimited"
        Me.RadioUnlimited.Size = New System.Drawing.Size(126, 29)
        Me.RadioUnlimited.TabIndex = 16
        Me.RadioUnlimited.TabStop = True
        Me.RadioUnlimited.Text = "Unlimited"
        Me.RadioUnlimited.UseVisualStyleBackColor = True
        '
        'PanelStatus
        '
        Me.PanelStatus.Controls.Add(Me.RadioUnlimited)
        Me.PanelStatus.Controls.Add(Me.RadioForbidden)
        Me.PanelStatus.Controls.Add(Me.RadioLimited)
        Me.PanelStatus.Location = New System.Drawing.Point(236, 283)
        Me.PanelStatus.Name = "PanelStatus"
        Me.PanelStatus.Size = New System.Drawing.Size(433, 30)
        Me.PanelStatus.TabIndex = 24
        '
        'RadioTrap
        '
        Me.RadioTrap.AutoSize = True
        Me.RadioTrap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioTrap.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RadioTrap.Location = New System.Drawing.Point(553, 174)
        Me.RadioTrap.Name = "RadioTrap"
        Me.RadioTrap.Size = New System.Drawing.Size(82, 29)
        Me.RadioTrap.TabIndex = 19
        Me.RadioTrap.TabStop = True
        Me.RadioTrap.Text = "Trap"
        Me.RadioTrap.UseVisualStyleBackColor = True
        '
        'RadioSpell
        '
        Me.RadioSpell.AutoSize = True
        Me.RadioSpell.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioSpell.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RadioSpell.Location = New System.Drawing.Point(405, 173)
        Me.RadioSpell.Name = "RadioSpell"
        Me.RadioSpell.Size = New System.Drawing.Size(86, 29)
        Me.RadioSpell.TabIndex = 18
        Me.RadioSpell.TabStop = True
        Me.RadioSpell.Text = "Spell"
        Me.RadioSpell.UseVisualStyleBackColor = True
        '
        'RadioMonster
        '
        Me.RadioMonster.AutoSize = True
        Me.RadioMonster.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioMonster.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.RadioMonster.Location = New System.Drawing.Point(236, 173)
        Me.RadioMonster.Margin = New System.Windows.Forms.Padding(0)
        Me.RadioMonster.Name = "RadioMonster"
        Me.RadioMonster.Size = New System.Drawing.Size(115, 29)
        Me.RadioMonster.TabIndex = 17
        Me.RadioMonster.TabStop = True
        Me.RadioMonster.Text = "Monster"
        Me.RadioMonster.UseVisualStyleBackColor = True
        '
        'Update
        '
        Me.Update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update.Location = New System.Drawing.Point(342, 329)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(109, 38)
        Me.Update.TabIndex = 25
        Me.Update.Text = "Update"
        Me.Update.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(473, 329)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(109, 38)
        Me.Delete.TabIndex = 26
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'ButtonFind
        '
        Me.ButtonFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFind.Location = New System.Drawing.Point(702, 81)
        Me.ButtonFind.Name = "ButtonFind"
        Me.ButtonFind.Size = New System.Drawing.Size(86, 38)
        Me.ButtonFind.TabIndex = 27
        Me.ButtonFind.Text = "Find"
        Me.ButtonFind.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(702, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 38)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Find"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(702, 223)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 38)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Find"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(702, 277)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 38)
        Me.Button4.TabIndex = 31
        Me.Button4.Text = "Find"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(702, 175)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 38)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Find"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label4.Location = New System.Drawing.Point(40, 371)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 20)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "[ Refresh View ]"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.belgado_act_4.My.Resources.Resources.hicolor
        Me.PictureBox1.InitialImage = Global.belgado_act_4.My.Resources.Resources.hicolor
        Me.PictureBox1.Location = New System.Drawing.Point(40, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Monster
        '
        Me.Monster.BackColor = System.Drawing.Color.Transparent
        Me.Monster.Image = CType(resources.GetObject("Monster.Image"), System.Drawing.Image)
        Me.Monster.InitialImage = CType(resources.GetObject("Monster.InitialImage"), System.Drawing.Image)
        Me.Monster.Location = New System.Drawing.Point(354, 175)
        Me.Monster.Name = "Monster"
        Me.Monster.Size = New System.Drawing.Size(28, 28)
        Me.Monster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Monster.TabIndex = 20
        Me.Monster.TabStop = False
        '
        'Trap
        '
        Me.Trap.BackColor = System.Drawing.Color.Transparent
        Me.Trap.Image = Global.belgado_act_4.My.Resources.Resources.TRAP
        Me.Trap.InitialImage = Global.belgado_act_4.My.Resources.Resources.TRAP
        Me.Trap.Location = New System.Drawing.Point(641, 175)
        Me.Trap.Name = "Trap"
        Me.Trap.Size = New System.Drawing.Size(28, 28)
        Me.Trap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Trap.TabIndex = 22
        Me.Trap.TabStop = False
        '
        'Spell
        '
        Me.Spell.BackColor = System.Drawing.Color.Transparent
        Me.Spell.Image = Global.belgado_act_4.My.Resources.Resources.SPELL
        Me.Spell.InitialImage = Global.belgado_act_4.My.Resources.Resources.SPELL
        Me.Spell.Location = New System.Drawing.Point(497, 174)
        Me.Spell.Name = "Spell"
        Me.Spell.Size = New System.Drawing.Size(28, 28)
        Me.Spell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Spell.TabIndex = 21
        Me.Spell.TabStop = False
        '
        'Logout
        '
        Me.Logout.AutoSize = True
        Me.Logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout.ForeColor = System.Drawing.Color.Firebrick
        Me.Logout.Location = New System.Drawing.Point(684, 15)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(104, 25)
        Me.Logout.TabIndex = 34
        Me.Logout.Text = "[ Logout ]"
        '
        'ExportTable
        '
        Me.ExportTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExportTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExportTable.Location = New System.Drawing.Point(679, 650)
        Me.ExportTable.Name = "ExportTable"
        Me.ExportTable.Size = New System.Drawing.Size(109, 38)
        Me.ExportTable.TabIndex = 35
        Me.ExportTable.Text = "Export"
        Me.ExportTable.UseVisualStyleBackColor = True
        '
        'ImportDatabase
        '
        Me.ImportDatabase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImportDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImportDatabase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ImportDatabase.Location = New System.Drawing.Point(564, 650)
        Me.ImportDatabase.Name = "ImportDatabase"
        Me.ImportDatabase.Size = New System.Drawing.Size(109, 38)
        Me.ImportDatabase.TabIndex = 36
        Me.ImportDatabase.Text = "Import"
        Me.ImportDatabase.UseVisualStyleBackColor = True
        '
        'GenerateReportButton
        '
        Me.GenerateReportButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GenerateReportButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateReportButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GenerateReportButton.Location = New System.Drawing.Point(40, 650)
        Me.GenerateReportButton.Name = "GenerateReportButton"
        Me.GenerateReportButton.Size = New System.Drawing.Size(183, 38)
        Me.GenerateReportButton.TabIndex = 37
        Me.GenerateReportButton.Text = "Generate Report"
        Me.GenerateReportButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(808, 709)
        Me.ControlBox = False
        Me.Controls.Add(Me.GenerateReportButton)
        Me.Controls.Add(Me.ImportDatabase)
        Me.Controls.Add(Me.ExportTable)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonFind)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.Monster)
        Me.Controls.Add(Me.Trap)
        Me.Controls.Add(Me.Insert)
        Me.Controls.Add(Me.RadioMonster)
        Me.Controls.Add(Me.Spell)
        Me.Controls.Add(Me.DateTimePickerInsert)
        Me.Controls.Add(Me.RadioSpell)
        Me.Controls.Add(Me.TextCardName)
        Me.Controls.Add(Me.RadioTrap)
        Me.Controls.Add(Me.TextCardNumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelStatus)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Activity 4"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelStatus.ResumeLayout(False)
        Me.PanelStatus.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Monster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Trap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Spell, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextCardNumber As TextBox
    Friend WithEvents TextCardName As TextBox
    Friend WithEvents DateTimePickerInsert As DateTimePicker
    Friend WithEvents RadioForbidden As RadioButton
    Friend WithEvents RadioLimited As RadioButton
    Friend WithEvents Insert As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RadioUnlimited As RadioButton
    Friend WithEvents PanelStatus As Panel
    Friend WithEvents RadioTrap As RadioButton
    Friend WithEvents RadioSpell As RadioButton
    Public WithEvents Spell As PictureBox
    Friend WithEvents RadioMonster As RadioButton
    Public WithEvents Trap As PictureBox
    Public WithEvents Monster As PictureBox
    Friend WithEvents Update As Button
    Friend WithEvents Delete As Button
    Friend WithEvents ButtonFind As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Logout As Label
    Friend WithEvents ExportTable As Button
    Friend WithEvents ImportDatabase As Button
    Friend WithEvents GenerateReportButton As Button
End Class
