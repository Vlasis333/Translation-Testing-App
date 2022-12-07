Public Class MainForm

    Public GreekWordSoluc As String = ""
    Public GermanWordSoluc As String = ""
    Private Sub DataEntry_Click(sender As Object, e As EventArgs) Handles DataEntry.Click
        DataEntryPanel.BringToFront()
    End Sub

    Private Sub GermanWR_Click(sender As Object, e As EventArgs) Handles GermanWR.Click
        GermanWDPanel.BringToFront()
    End Sub

    Private Sub GreekWD_Click(sender As Object, e As EventArgs) Handles GreekWD.Click
        GreekWDPanel.BringToFront()
    End Sub

    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles Settings.Click
        SettingsPanel.BringToFront()
    End Sub

    Private Sub DataEntryBTN_Click(sender As Object, e As EventArgs) Handles DataEntryBTN.Click
        If GermanDataTxtBox.Text <> "" Or GermanDataTxtBox.Text <> Nothing Then
            If GreekDataTxtBox.Text <> "" Or GreekDataTxtBox.Text <> Nothing Then
                If EntryGroupUpDown.Value > 0 Then
                    Dim Message As String = ""
                    Conn.GetConnect()
                    Conn.CommandInsert(EntryGroupUpDown.Value, GermanDataTxtBox.Text.ToString, GreekDataTxtBox.Text, Message)


                    MessageBox.Show(Message, "Notification")
                    GermanDataTxtBox.Text = ""
                    GreekDataTxtBox.Text = ""
                Else
                    MessageBox.Show("Please select a group.", "Notification")
                End If
            Else
                MessageBox.Show("Please enter a greek word.", "Notification")
            End If
        Else
            MessageBox.Show("Please enter a german word.", "Notification")
        End If
    End Sub

    Private Sub RNGGermanBtn_Click(sender As Object, e As EventArgs) Handles RNGGermanBtn.Click
        Dim GroupID = SettingsGroupNumUpDown.Value
        Dim RandomWord As String = ""

        Conn.GetConnect()
        Conn.CommandSelect(GroupID, "German", "Greek", RandomWord, GermanWordSoluc)
        If RandomWord <> "" Then
            RNGGermanTxTBox.Text = RandomWord
        End If
    End Sub

    Private Sub RNGGreekBTN_Click(sender As Object, e As EventArgs) Handles RNGGreekBTN.Click
        Dim GroupID = SettingsGroupNumUpDown.Value
        Dim RandomWord As String = ""

        Conn.GetConnect()
        Conn.CommandSelect(GroupID, "Greek", "German", RandomWord, GreekWordSoluc)
        If RandomWord <> "" Then
            RNGGreekTxTBox.Text = RandomWord
        End If
    End Sub

    Private Sub SolutionGreekBTN_Click(sender As Object, e As EventArgs) Handles SolutionGreekBTN.Click
        If GreekWordSoluc <> "" Then
            MessageBox.Show(GreekWordSoluc, "German Solution.")
        End If
    End Sub

    Private Sub SolutionGermanBTN_Click(sender As Object, e As EventArgs) Handles SolutionGermanBTN.Click
        If GermanWordSoluc <> "" Then
            MessageBox.Show(GermanWordSoluc, "Greek Solution.")
        End If
    End Sub
End Class
