<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.DataEntry = New System.Windows.Forms.Button()
        Me.DataEntryPanel = New System.Windows.Forms.Panel()
        Me.EntryGroupUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataEntryBTN = New System.Windows.Forms.Button()
        Me.GreekDataTxtBox = New System.Windows.Forms.TextBox()
        Me.GermanDataTxtBox = New System.Windows.Forms.TextBox()
        Me.GermanWR = New System.Windows.Forms.Button()
        Me.GreekWD = New System.Windows.Forms.Button()
        Me.Settings = New System.Windows.Forms.Button()
        Me.GermanWDPanel = New System.Windows.Forms.Panel()
        Me.SolutionGermanBTN = New System.Windows.Forms.Button()
        Me.RNGGermanBtn = New System.Windows.Forms.Button()
        Me.RNGGermanTxTBox = New System.Windows.Forms.TextBox()
        Me.GreekWDPanel = New System.Windows.Forms.Panel()
        Me.SolutionGreekBTN = New System.Windows.Forms.Button()
        Me.RNGGreekBTN = New System.Windows.Forms.Button()
        Me.RNGGreekTxTBox = New System.Windows.Forms.TextBox()
        Me.SettingsPanel = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SettingsGroupNumUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataEntryPanel.SuspendLayout()
        CType(Me.EntryGroupUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GermanWDPanel.SuspendLayout()
        Me.GreekWDPanel.SuspendLayout()
        Me.SettingsPanel.SuspendLayout()
        CType(Me.SettingsGroupNumUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataEntry
        '
        Me.DataEntry.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataEntry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataEntry.Location = New System.Drawing.Point(14, 15)
        Me.DataEntry.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataEntry.Name = "DataEntry"
        Me.DataEntry.Size = New System.Drawing.Size(87, 28)
        Me.DataEntry.TabIndex = 0
        Me.DataEntry.Text = "Data Entry"
        Me.DataEntry.UseVisualStyleBackColor = False
        '
        'DataEntryPanel
        '
        Me.DataEntryPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataEntryPanel.Controls.Add(Me.EntryGroupUpDown)
        Me.DataEntryPanel.Controls.Add(Me.Label3)
        Me.DataEntryPanel.Controls.Add(Me.Label2)
        Me.DataEntryPanel.Controls.Add(Me.Label1)
        Me.DataEntryPanel.Controls.Add(Me.DataEntryBTN)
        Me.DataEntryPanel.Controls.Add(Me.GreekDataTxtBox)
        Me.DataEntryPanel.Controls.Add(Me.GermanDataTxtBox)
        Me.DataEntryPanel.Location = New System.Drawing.Point(14, 50)
        Me.DataEntryPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataEntryPanel.Name = "DataEntryPanel"
        Me.DataEntryPanel.Size = New System.Drawing.Size(684, 143)
        Me.DataEntryPanel.TabIndex = 1
        '
        'EntryGroupUpDown
        '
        Me.EntryGroupUpDown.Location = New System.Drawing.Point(19, 71)
        Me.EntryGroupUpDown.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EntryGroupUpDown.Name = "EntryGroupUpDown"
        Me.EntryGroupUpDown.Size = New System.Drawing.Size(68, 21)
        Me.EntryGroupUpDown.TabIndex = 6
        Me.EntryGroupUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(32, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Group"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(429, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Greek Word"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(193, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "German Word"
        '
        'DataEntryBTN
        '
        Me.DataEntryBTN.Location = New System.Drawing.Point(579, 67)
        Me.DataEntryBTN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataEntryBTN.Name = "DataEntryBTN"
        Me.DataEntryBTN.Size = New System.Drawing.Size(87, 28)
        Me.DataEntryBTN.TabIndex = 2
        Me.DataEntryBTN.Text = "Insert"
        Me.DataEntryBTN.UseVisualStyleBackColor = True
        '
        'GreekDataTxtBox
        '
        Me.GreekDataTxtBox.Location = New System.Drawing.Point(371, 71)
        Me.GreekDataTxtBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GreekDataTxtBox.Name = "GreekDataTxtBox"
        Me.GreekDataTxtBox.Size = New System.Drawing.Size(201, 21)
        Me.GreekDataTxtBox.TabIndex = 1
        '
        'GermanDataTxtBox
        '
        Me.GermanDataTxtBox.Location = New System.Drawing.Point(141, 71)
        Me.GermanDataTxtBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GermanDataTxtBox.Name = "GermanDataTxtBox"
        Me.GermanDataTxtBox.Size = New System.Drawing.Size(201, 21)
        Me.GermanDataTxtBox.TabIndex = 0
        '
        'GermanWR
        '
        Me.GermanWR.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GermanWR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GermanWR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GermanWR.Location = New System.Drawing.Point(108, 15)
        Me.GermanWR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GermanWR.Name = "GermanWR"
        Me.GermanWR.Size = New System.Drawing.Size(156, 28)
        Me.GermanWR.TabIndex = 3
        Me.GermanWR.Text = "Random German Words"
        Me.GermanWR.UseVisualStyleBackColor = False
        '
        'GreekWD
        '
        Me.GreekWD.BackColor = System.Drawing.Color.AntiqueWhite
        Me.GreekWD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GreekWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GreekWD.Location = New System.Drawing.Point(272, 15)
        Me.GreekWD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GreekWD.Name = "GreekWD"
        Me.GreekWD.Size = New System.Drawing.Size(154, 28)
        Me.GreekWD.TabIndex = 4
        Me.GreekWD.Text = "Random Greek Words"
        Me.GreekWD.UseVisualStyleBackColor = False
        '
        'Settings
        '
        Me.Settings.BackColor = System.Drawing.SystemColors.Info
        Me.Settings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Settings.Location = New System.Drawing.Point(433, 15)
        Me.Settings.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Settings.Name = "Settings"
        Me.Settings.Size = New System.Drawing.Size(87, 28)
        Me.Settings.TabIndex = 5
        Me.Settings.Text = "Settings"
        Me.Settings.UseVisualStyleBackColor = False
        '
        'GermanWDPanel
        '
        Me.GermanWDPanel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GermanWDPanel.Controls.Add(Me.SolutionGermanBTN)
        Me.GermanWDPanel.Controls.Add(Me.RNGGermanBtn)
        Me.GermanWDPanel.Controls.Add(Me.RNGGermanTxTBox)
        Me.GermanWDPanel.Location = New System.Drawing.Point(14, 50)
        Me.GermanWDPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GermanWDPanel.Name = "GermanWDPanel"
        Me.GermanWDPanel.Size = New System.Drawing.Size(684, 143)
        Me.GermanWDPanel.TabIndex = 6
        '
        'SolutionGermanBTN
        '
        Me.SolutionGermanBTN.Location = New System.Drawing.Point(299, 92)
        Me.SolutionGermanBTN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SolutionGermanBTN.Name = "SolutionGermanBTN"
        Me.SolutionGermanBTN.Size = New System.Drawing.Size(87, 28)
        Me.SolutionGermanBTN.TabIndex = 5
        Me.SolutionGermanBTN.Text = "Solution"
        Me.SolutionGermanBTN.UseVisualStyleBackColor = True
        '
        'RNGGermanBtn
        '
        Me.RNGGermanBtn.Location = New System.Drawing.Point(478, 57)
        Me.RNGGermanBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RNGGermanBtn.Name = "RNGGermanBtn"
        Me.RNGGermanBtn.Size = New System.Drawing.Size(87, 28)
        Me.RNGGermanBtn.TabIndex = 1
        Me.RNGGermanBtn.Text = "Generate"
        Me.RNGGermanBtn.UseVisualStyleBackColor = True
        '
        'RNGGermanTxTBox
        '
        Me.RNGGermanTxTBox.Location = New System.Drawing.Point(119, 61)
        Me.RNGGermanTxTBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RNGGermanTxTBox.Name = "RNGGermanTxTBox"
        Me.RNGGermanTxTBox.ReadOnly = True
        Me.RNGGermanTxTBox.Size = New System.Drawing.Size(352, 21)
        Me.RNGGermanTxTBox.TabIndex = 0
        Me.RNGGermanTxTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GreekWDPanel
        '
        Me.GreekWDPanel.BackColor = System.Drawing.Color.AntiqueWhite
        Me.GreekWDPanel.Controls.Add(Me.SolutionGreekBTN)
        Me.GreekWDPanel.Controls.Add(Me.RNGGreekBTN)
        Me.GreekWDPanel.Controls.Add(Me.RNGGreekTxTBox)
        Me.GreekWDPanel.Location = New System.Drawing.Point(14, 50)
        Me.GreekWDPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GreekWDPanel.Name = "GreekWDPanel"
        Me.GreekWDPanel.Size = New System.Drawing.Size(684, 143)
        Me.GreekWDPanel.TabIndex = 7
        '
        'SolutionGreekBTN
        '
        Me.SolutionGreekBTN.Location = New System.Drawing.Point(299, 92)
        Me.SolutionGreekBTN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SolutionGreekBTN.Name = "SolutionGreekBTN"
        Me.SolutionGreekBTN.Size = New System.Drawing.Size(87, 28)
        Me.SolutionGreekBTN.TabIndex = 4
        Me.SolutionGreekBTN.Text = "Solution"
        Me.SolutionGreekBTN.UseVisualStyleBackColor = True
        '
        'RNGGreekBTN
        '
        Me.RNGGreekBTN.Location = New System.Drawing.Point(478, 57)
        Me.RNGGreekBTN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RNGGreekBTN.Name = "RNGGreekBTN"
        Me.RNGGreekBTN.Size = New System.Drawing.Size(87, 28)
        Me.RNGGreekBTN.TabIndex = 3
        Me.RNGGreekBTN.Text = "Generate"
        Me.RNGGreekBTN.UseVisualStyleBackColor = True
        '
        'RNGGreekTxTBox
        '
        Me.RNGGreekTxTBox.Location = New System.Drawing.Point(119, 61)
        Me.RNGGreekTxTBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RNGGreekTxTBox.Name = "RNGGreekTxTBox"
        Me.RNGGreekTxTBox.ReadOnly = True
        Me.RNGGreekTxTBox.Size = New System.Drawing.Size(352, 21)
        Me.RNGGreekTxTBox.TabIndex = 2
        Me.RNGGreekTxTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SettingsPanel
        '
        Me.SettingsPanel.BackColor = System.Drawing.SystemColors.Info
        Me.SettingsPanel.Controls.Add(Me.Label4)
        Me.SettingsPanel.Controls.Add(Me.SettingsGroupNumUpDown)
        Me.SettingsPanel.Controls.Add(Me.Label5)
        Me.SettingsPanel.Location = New System.Drawing.Point(14, 50)
        Me.SettingsPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SettingsPanel.Name = "SettingsPanel"
        Me.SettingsPanel.Size = New System.Drawing.Size(684, 143)
        Me.SettingsPanel.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(287, 32)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "0 - No trageted group (brings data from every group)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Number - Selectes data from" &
    " a single group"
        '
        'SettingsGroupNumUpDown
        '
        Me.SettingsGroupNumUpDown.Location = New System.Drawing.Point(6, 50)
        Me.SettingsGroupNumUpDown.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SettingsGroupNumUpDown.Name = "SettingsGroupNumUpDown"
        Me.SettingsGroupNumUpDown.Size = New System.Drawing.Size(68, 21)
        Me.SettingsGroupNumUpDown.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(19, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Group"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(706, 210)
        Me.Controls.Add(Me.Settings)
        Me.Controls.Add(Me.GreekWD)
        Me.Controls.Add(Me.GermanWR)
        Me.Controls.Add(Me.DataEntry)
        Me.Controls.Add(Me.DataEntryPanel)
        Me.Controls.Add(Me.GreekWDPanel)
        Me.Controls.Add(Me.GermanWDPanel)
        Me.Controls.Add(Me.SettingsPanel)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.Text = "Sia's German To English"
        Me.DataEntryPanel.ResumeLayout(False)
        Me.DataEntryPanel.PerformLayout()
        CType(Me.EntryGroupUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GermanWDPanel.ResumeLayout(False)
        Me.GermanWDPanel.PerformLayout()
        Me.GreekWDPanel.ResumeLayout(False)
        Me.GreekWDPanel.PerformLayout()
        Me.SettingsPanel.ResumeLayout(False)
        Me.SettingsPanel.PerformLayout()
        CType(Me.SettingsGroupNumUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataEntry As Button
    Friend WithEvents DataEntryPanel As Panel
    Friend WithEvents GermanWR As Button
    Friend WithEvents GreekWD As Button
    Friend WithEvents Settings As Button
    Friend WithEvents GermanWDPanel As Panel
    Friend WithEvents GreekWDPanel As Panel
    Friend WithEvents SettingsPanel As Panel
    Friend WithEvents GermanDataTxtBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataEntryBTN As Button
    Friend WithEvents GreekDataTxtBox As TextBox
    Friend WithEvents EntryGroupUpDown As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents RNGGermanTxTBox As TextBox
    Friend WithEvents RNGGermanBtn As Button
    Friend WithEvents RNGGreekBTN As Button
    Friend WithEvents RNGGreekTxTBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SettingsGroupNumUpDown As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents SolutionGreekBTN As Button
    Friend WithEvents SolutionGermanBTN As Button
End Class
