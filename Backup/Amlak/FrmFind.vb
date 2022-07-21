Imports System.Data.SqlClient


Public Class FrmFind

    Private Sub FrmFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DG("")
    End Sub

    Function shsh() As String
        Dim txt As String = ""


        If txt1.Text = "" Then
            txt += " "
        Else
            txt += txt1.Text
        End If
        If txt2.Text = "" Then
            txt += " "
        Else
            txt += txt2.Text
        End If
        If txt3.Text = "" Then
            txt += " "
        Else
            txt += txt3.Text
        End If
        If txt4.Text = "" Then
            txt += " "
        Else
            txt += txt4.Text
        End If
        If txt5.Text = "" Then
            txt += " "
        Else
            txt += txt5.Text
        End If
        If txt6.Text = "" Then
            txt += " "
        Else
            txt += txt6.Text
        End If
        If txt7.Text = "" Then
            txt += " "
        Else
            txt += txt7.Text
        End If
        If txt8.Text = "" Then
            txt += " "
        Else
            txt += txt8.Text
        End If
        If txt9.Text = "" Then
            txt += " "
        Else
            txt += txt9.Text
        End If
        If txt10.Text = "" Then
            txt += " "
        Else
            txt += txt10.Text
        End If
        If txt11.Text = "" Then
            txt += " "
        Else
            txt += txt11.Text
        End If
        If txt12.Text = "" Then
            txt += " "
        Else
            txt += txt12.Text
        End If
        If txt13.Text = "" Then
            txt += " "
        Else
            txt += txt13.Text
        End If
        If txt14.Text = "" Then
            txt += " "
        Else
            txt += txt14.Text
        End If
        If txt15.Text = "" Then
            txt += " "
        Else
            txt += txt15.Text
        End If
        If txt16.Text = "" Then
            txt += " "
        Else
            txt += txt16.Text
        End If
        If txt17.Text = "" Then
            txt += " "
        Else
            txt += txt17.Text
        End If
        If txt18.Text = "" Then
            txt += " "
        Else
            txt += txt18.Text
        End If
        If txt19.Text = "" Then
            txt += " "
        Else
            txt += txt19.Text
        End If
        If txt20.Text = "" Then
            txt += " "
        Else
            txt += txt20.Text
        End If
        If txt21.Text = "" Then
            txt += " "
        Else
            txt += txt21.Text
        End If
        If txt22.Text = "" Then
            txt += " "
        Else
            txt += txt22.Text
        End If
        If txt23.Text = "" Then
            txt += " "
        Else
            txt += txt23.Text
        End If
        If txt24.Text = "" Then
            txt += " "
        Else
            txt += txt24.Text
        End If
        If txt25.Text = "" Then
            txt += " "
        Else
            txt += txt25.Text
        End If
        If txt26.Text = "" Then
            txt += " "
        Else
            txt += txt26.Text
        End If
        If txt27.Text = "" Then
            txt += " "
        Else
            txt += txt27.Text
        End If

        Return txt
    End Function

    Public Sub DG(ByVal SH As String)
        _DBL = New Sqldblayer.Dblayer(My.Settings.DB_NoSaziConnectionString)

        With DataGridView1
            .DataSource = _DBL.Getdatatable("Select Shomare_Shenasnameh as [شماره شناسنامه] , Masahat_Zamin as [مساحت زمین] , N_Code_Posti as [کد پستی] from  [dbo].[TBL_Amlak_Mostaghelat] where Shomare_Shenasnameh like '%" + Trim(SH) + "%'")
            .Columns(0).Width = 150

        End With


    End Sub

    Private Sub txt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1.TextChanged, txt9.TextChanged, txt8.TextChanged, txt7.TextChanged, txt6.TextChanged, txt5.TextChanged, txt4.TextChanged, txt3.TextChanged, txt27.TextChanged, txt26.TextChanged, txt25.TextChanged, txt24.TextChanged, txt23.TextChanged, txt22.TextChanged, txt21.TextChanged, txt20.TextChanged, txt2.TextChanged, txt19.TextChanged, txt18.TextChanged, txt17.TextChanged, txt16.TextChanged, txt15.TextChanged, txt14.TextChanged, txt13.TextChanged, txt12.TextChanged, txt11.TextChanged, txt10.TextChanged

        shsh()
        DG(shsh())

        If sender.TextLength = 1 Then
            SendKeys.Send("{DOWN}")
        End If

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick

        Selected_SHsh()

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Selected_SHsh()
    End Sub

    Sub Selected_SHsh()
        Try

            _Load_Type = LT._Edit

            If Me.DataGridView1.RowCount > 0 Then

                _Shomareh_Shenasnameh = Me.DataGridView1.CurrentRow.Cells(0).Value.ToString
                Select Case (_Edit_Forms)
                    Case Edit.Moshakhasat_Avalieh
                        If count(_Shomareh_Shenasnameh, "Tbl_Amlak_Mostaghelat") Then
                            FrmMoshakhasat_Avalieh.MdiParent = FrmMain
                            FrmMoshakhasat_Avalieh.Show()
                        Else
                            MSG_Err_For_Update("مشخصات اولیه")
                        End If

                    Case Edit.Tamlak
                        If count(_Shomareh_Shenasnameh, "TAmlak") Then
                            FrmTamlak.MdiParent = FrmMain
                            FrmTamlak.Show()
                        Else
                            MSG_Err_For_Update("مشخصات مورد محاسبه")
                        End If

                    Case Edit.Moshakhasat_Zamin
                        If count(_Shomareh_Shenasnameh, "Tbl_Moshakhasat_Zamin") Then
                            FrmMoshakhasat_Zamin.MdiParent = FrmMain
                            FrmMoshakhasat_Zamin.Show()
                        Else
                            MSG_Err_For_Update("مشخصات زمین")
                        End If

                    Case Edit.Moshakhasat_Malekin
                        If count(_Shomareh_Shenasnameh, "Tbl_Moshakhasat_Malekin") Then

                            FrmMoshakhasat_Malekin.MdiParent = FrmMain
                            FrmMoshakhasat_Malekin.Show()
                        Else
                            MSG_Err_For_Update("مشخصات مالکین")
                        End If

                    Case Edit.Mahiyat_Fiziki
                        If count(_Shomareh_Shenasnameh, "Tbl_Mahiyat_Fiziki") Then
                            FrmMahiyat_Fiziki.MdiParent = FrmMain
                            FrmMahiyat_Fiziki.Show()
                        Else
                            MSG_Err_For_Update("ماهیت فیزیکی")

                        End If

                    Case Edit.No_Estefadeh
                        If count(_Shomareh_Shenasnameh, "Tbl_No_Estefadeh") Then
                            FrmNo_Estefadeh.MdiParent = FrmMain
                            FrmNo_Estefadeh.Show()
                        Else
                            MSG_Err_For_Update("نوع استفاده")
                        End If

                    Case Edit.Derakht
                        If count(_Shomareh_Shenasnameh, "Tbl_Derakht") Then
                            FrmDerakht.MdiParent = FrmMain
                            FrmDerakht.Show()
                        Else
                            MSG_Err_For_Update("نوع درخت")

                        End If

                    Case Edit.Moshakhasat_Sakhteman
                        If count(_Shomareh_Shenasnameh, "Tbl_Moshakhasat_Sakhteman") Then
                            FrmMoshakhasat_Sakhteman.MdiParent = FrmMain
                            FrmMoshakhasat_Sakhteman.Show()
                        Else
                            MSG_Err_For_Update("مشخصات ساختمان")

                        End If

                    Case Edit.Moshakhasat_Eshterak
                        If count(_Shomareh_Shenasnameh, "Tbl_Eshterak") Then
                            FrmMoshakhasat_Eshterak.MdiParent = FrmMain
                            FrmMoshakhasat_Eshterak.Show()
                        Else
                            MSG_Err_For_Update("مشخصات اشتراک و مستحدثات")

                        End If

                    Case Edit.Moshakhasat_Momayezi
                        If count(_Shomareh_Shenasnameh, "Tbl_Momayezi") Then
                            FrmMoshakhasat_Momayezi.MdiParent = FrmMain
                            FrmMoshakhasat_Momayezi.Show()
                        Else
                            MSG_Err_For_Update("مشخصات ممیزی")
                        End If

                    Case Edit.Afrad_Momayezi
                        If count(_Shomareh_Shenasnameh, "Tbl_Afrad_Momayezi") Then
                            FrmAfrad_Momayezi.MdiParent = FrmMain
                            FrmAfrad_Momayezi.Show()
                        Else
                            MSG_Err_For_Update("افراد ممیزی")
                        End If

                End Select
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function count(ByVal shsh As String, ByVal tbl_name As String) As Boolean

        Dim queryString As String = "exec [Exists_For_Update] [" + shsh + "] , '" + tbl_name + "'"
        Using connection As New SqlConnection()
            connection.ConnectionString = My.Settings.DB_NoSaziConnectionString
            Dim command As New SqlCommand(queryString, connection)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            Try

                While reader.Read()

                    If CInt((reader("count_"))) > 0 Then
                        Return True
                    End If

                End While
            Finally
                reader.Close()
            End Try
        End Using
    End Function

    Sub MSG_Err_For_Update(ByVal Form_Name As String)
        MsgBox("اطلاعاتی در مورد شماره شناسنامه مربوطه در فرم " + Form_Name + " وجود ندارد " + vbCrLf + "لطفا اطلاعات جدید را از قمست تکمیل فرمهای ناقص اطلاعات مربوطه را وارد نمایید")
    End Sub

End Class