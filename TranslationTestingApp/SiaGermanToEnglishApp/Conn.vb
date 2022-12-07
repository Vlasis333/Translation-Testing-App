Imports System.Data
Imports System.Data.SqlClient

Module Conn

    Public conn As SqlConnection
    Public objcommand As SqlCommand

    Public Function GetConnect()
        conn = New SqlConnection("Data Source=localhost\sqlexpress;Initial Catalog=SiaDB;Trusted_Connection=yes;")

        Return conn
    End Function

    Public Function CommandInsert(ByVal groupID As Integer, ByVal German As String, ByVal Greek As String, ByRef Message As String)
        objcommand = New SqlCommand

        Try
            With objcommand
                .Connection = conn
                .CommandText = "INSERT INTO MainTable([Group],[German],[Greek]) " &
                "VALUES (" & groupID & ", N'" & German & "','" & Greek & "')"
            End With
            conn.Open()
            objcommand.ExecuteNonQuery()
            conn.Close()
            Message = "Data entry successful"
            Return Message
        Catch ex As Exception
            Message = ex.Message
            Return ex
        End Try

    End Function

    Public Function CommandSelect(ByVal groupID As Integer, ByVal CategorySelect As String, ByVal CategorySolution As String, ByRef RandWord As String, ByRef Soluc As String)

        Try
            If groupID = 0 Then
                conn.Open()

                Using cmd As New SqlCommand("SELECT [" & CategorySelect & "] ,[" & CategorySolution & "] FROM(SELECT *, Row_number() OVER(ORDER BY Newid()) RNO From [MainTable])A Where RNO = 1", conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Soluc = reader(CategorySolution)
                            RandWord = reader(CategorySelect)
                        End While
                    End Using
                End Using

                conn.Close()
            Else
                conn.Open()

                Using cmd As New SqlCommand("SELECT [" & CategorySelect & "] ,[" & CategorySolution & "] FROM(SELECT *, Row_number() OVER(Partition BY [Group] ORDER BY Newid()) RNO From [MainTable])A Where RNO = 1 And [Group] = " & groupID, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Soluc = reader(CategorySolution)
                            RandWord = reader(CategorySelect)
                        End While
                    End Using
                End Using

                conn.Close()
            End If

            Return RandWord
        Catch ex As Exception
            MsgBox(ex.Message)
            RandWord = ""
            Soluc = ""
            Return RandWord
        End Try

    End Function

End Module

