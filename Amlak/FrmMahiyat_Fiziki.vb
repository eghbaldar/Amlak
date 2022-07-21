Imports System.Data.SqlClient


Public Class FrmMahiyat_Fiziki


    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click


        If _Load_Type = LT._New Then

            If insert() Then
                Me.Close()
            End If


        Else
            If Update_db() Then
                Me.Close()
            End If


        End If
    End Sub

#Region "Functions"
    Sub Load_for_Update()


        Dim queryString As String = "SELECT [Shomare_Shenasnameh] as sss, [C300] ,[C301], [C302],[C303],[C304],[C305],[C306]  ,[C307]  FROM [DB_NoSazi].[dbo].[Tbl_Mahiyat_Fiziki] where  Shomare_Shenasnameh = '" + _Shomareh_Shenasnameh + "'"

        Using connection As New SqlConnection()
            connection.ConnectionString = My.Settings.DB_NoSaziConnectionString
            Dim command As New SqlCommand(queryString, connection)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            Try

                While reader.Read()


                    lblSHsh.Text = (reader("sss"))
                    chkBayer.Checked = (reader("C300"))
                    chkBayerMahsour.Checked = (reader("C301"))
                    chkMoshajjar.Checked = (reader("C302"))
                    chkMazrouei.Checked = (reader("C303"))
                    chkBagh.Checked = (reader("C304"))
                    chkSakhteman_NimehTamam.Checked = (reader("C305"))
                    chkSakhteman_Tmam.Checked = (reader("C306"))
                    chkSayer.Checked = (reader("C307"))

                End While
            Finally
                reader.Close()
            End Try
        End Using

    End Sub

    Function Update_db() As Integer
        Try
            _Update.Update_Tbl_Mahiyat_Fiziki(_Shomareh_Shenasnameh, _
                                              chkBayer.Checked, _
                                              chkBayerMahsour.Checked, _
                                              chkMoshajjar.Checked, _
                                              chkMazrouei.Checked, _
                                              chkBagh.Checked, _
                                              chkSakhteman_NimehTamam.Checked, _
                                              chkSakhteman_Tmam.Checked, _
                                              chkSayer.Checked)
            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try

    End Function

    Function insert() As Integer
        Try

            For Each chk As CheckBox In GMahiyat.Controls
                If chk.Checked Then

                    _insert.Insert_Tbl_Mahiyat_Fiziki(_Shomareh_Shenasnameh, _
                                              chkBayer.Checked, _
                                              chkBayerMahsour.Checked, _
                                              chkMoshajjar.Checked, _
                                              chkMazrouei.Checked, _
                                              chkBagh.Checked, _
                                              chkSakhteman_NimehTamam.Checked, _
                                              chkSakhteman_Tmam.Checked, _
                                              chkSayer.Checked)
                End If
            Next

            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try


    End Function

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If insert() Then
            FrmNo_Estefadeh.MdiParent = FrmMain
            FrmNo_Estefadeh.Show()
        End If

    End Sub

    Private Sub FrmMahiyat_Fiziki_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _Load_Type = LT._Edit Then
            Load_For_Update()
            btnNext.Visible = False
        End If
    End Sub
End Class