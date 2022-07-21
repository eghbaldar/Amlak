Imports System.Data.SqlClient


Public Class FrmMoshakhasat_Avalieh

    Private Sub TextualControl1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Back Then
            SendKeys.Send("{UP}")
        End If

    End Sub


    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        _Shomareh_Shenasnameh = shsh_insert()
        If insert() Then

            FrmTamlak.MdiParent = FrmMain
            FrmTamlak.Show()
            Me.Close()
        End If

    End Sub

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

    Private Sub FrmMoshakhasat_Avalieh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Try
            Me.Select_DFNsTableAdapter.Fill(Me.DB_NoSaziDataSet.Select_DFNs, "No_Moshakhasat")
            '# 1 #
            If _Load_Type = LT._Edit Then
                '# 3 #
                Load_For_Update()
                btnNext.Visible = False
            End If













        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub txtTabagheh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTabagheh.TextChanged, txtRadif_MGhabli.TextChanged, txtCodePosti.TextChanged, txtTedad_Zel.TextChanged, txtTedad_Vahed_Kasb.TextChanged, txtTedad_Sakhteman.TextChanged, txtTedad_Malek.TextChanged, txtTedad_Bar.TextChanged, txtTedad_Aparteman.TextChanged, txtTarikh_PMalekiyat.TextChanged, txtTarikh_Malekiyat.TextChanged, txtOnvan_Bar.TextChanged, txtMasahat_zamin.TextChanged, txtMasahat_PJebheh.TextChanged, txtMasahat_Melk.TextChanged, txtMasahat_Jebhah.TextChanged, txtMetrDar.TextChanged, txtTedad_Vahed.TextChanged
        If Trim(sender.text = "") Then
            sender.text = 0
        End If
    End Sub

#Region "Functions"

    Function shsh_insert() As String
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

    Sub shsh_Update()
        Dim queryString As String = "SELECT  Shomare_Shenasnameh FROM dbo.FSelect_TBL_Amlak_Mostaghelat ('" + _Shomareh_Shenasnameh + "')"

        Using connection As New SqlConnection()
            connection.ConnectionString = My.Settings.DB_NoSaziConnectionString
            Dim command As New SqlCommand(queryString, connection)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            Try

                While reader.Read()

                    txt1.Text = Mid((reader("Shomare_Shenasnameh")), 1, 1)
                    txt2.Text = Mid((reader("Shomare_Shenasnameh")), 2, 1)
                    txt3.Text = Mid((reader("Shomare_Shenasnameh")), 3, 1)
                    txt4.Text = Mid((reader("Shomare_Shenasnameh")), 4, 1)
                    txt5.Text = Mid((reader("Shomare_Shenasnameh")), 5, 1)
                    txt6.Text = Mid((reader("Shomare_Shenasnameh")), 6, 1)
                    txt7.Text = Mid((reader("Shomare_Shenasnameh")), 7, 1)
                    txt8.Text = Mid((reader("Shomare_Shenasnameh")), 8, 1)
                    txt9.Text = Mid((reader("Shomare_Shenasnameh")), 9, 1)
                    txt10.Text = Mid((reader("Shomare_Shenasnameh")), 10, 1)
                    txt11.Text = Mid((reader("Shomare_Shenasnameh")), 11, 1)
                    txt12.Text = Mid((reader("Shomare_Shenasnameh")), 12, 1)
                    txt13.Text = Mid((reader("Shomare_Shenasnameh")), 13, 1)
                    txt14.Text = Mid((reader("Shomare_Shenasnameh")), 14, 1)
                    txt15.Text = Mid((reader("Shomare_Shenasnameh")), 15, 1)
                    txt16.Text = Mid((reader("Shomare_Shenasnameh")), 16, 1)
                    txt17.Text = Mid((reader("Shomare_Shenasnameh")), 17, 1)
                    txt18.Text = Mid((reader("Shomare_Shenasnameh")), 18, 1)
                    txt19.Text = Mid((reader("Shomare_Shenasnameh")), 19, 1)
                    txt20.Text = Mid((reader("Shomare_Shenasnameh")), 20, 1)
                    txt21.Text = Mid((reader("Shomare_Shenasnameh")), 21, 1)
                    txt22.Text = Mid((reader("Shomare_Shenasnameh")), 22, 1)
                    txt23.Text = Mid((reader("Shomare_Shenasnameh")), 23, 1)
                    txt24.Text = Mid((reader("Shomare_Shenasnameh")), 24, 1)
                    txt25.Text = Mid((reader("Shomare_Shenasnameh")), 25, 1)
                    txt26.Text = Mid((reader("Shomare_Shenasnameh")), 26, 1)
                    txt27.Text = Mid((reader("Shomare_Shenasnameh")), 27, 1)
                End While
            Finally
                reader.Close()
            End Try
        End Using

    End Sub

    Function insert() As Integer
        Try


            _insert.Insert_TBL_Amlak_Mostaghelat(txtTarikh_Malekiyat.Text, _
                                             txtTarikh_PMalekiyat.Text, _
                                             shsh_insert(), _
                                             txtMashhour.Text, _
                                             txtKhiaban.Text, _
                                             txtMeydan.Text, _
                                             txtBazar.Text, _
                                             txtPasaj.Text, _
                                             txtKoucheh.Text, _
                                             txtBonBast.Text, _
                                             txtPelakAbi.Text, _
                                             txtBlock.Text, _
                                             txtTabagheh.Text, _
                                             txtCodePosti.Text, _
                                             txtRadif_MGhabli.Text, _
                                             txtMasahat_zamin.Text, _
                                             txtMasahat_Jebhah.Text, _
                                             txtMasahat_PJebheh.Text, _
                                             txtTedad_Zel.Text, _
                                             txtTedad_Bar.Text, _
                                             txtOnvan_Bar.Text, _
                                             txtTedad_Malek.Text, _
                                             cboNo_Moshakhasat.SelectedValue, _
                                             txtTedad_Sakhteman.Text, _
                                             txtTedad_Aparteman.Text, _
                                             txtTedad_Vahed_Kasb.Text, _
                                             txtMasahat_Melk.Text, _
                                             txtMetrDar.Text, _
                                             chkRah_Mostaghel.Checked, _
                                             txtTedad_Vahed.Text, _
                                             cboNo_Malekiyat.SelectedValue, _
                                             txtName_Malek.Text, _
                                             chkHozour.Checked)

            Return 1
        Catch ex As Exception

            MsgBox(ex.Message)
            Return 0
        End Try
    End Function

    Function Update_db() As Integer

        Try
            _Update.Update_Tbl_Amlak_Mostaghelat(_Shomareh_Shenasnameh, _
                                                 txtTarikh_Malekiyat.Text, _
                                             txtTarikh_PMalekiyat.Text, _
                                             shsh_insert(), _
                                             txtMashhour.Text, _
                                             txtKhiaban.Text, _
                                             txtMeydan.Text, _
                                             txtBazar.Text, _
                                             txtPasaj.Text, _
                                             txtKoucheh.Text, _
                                             txtBonBast.Text, _
                                             txtPelakAbi.Text, _
                                             txtBlock.Text, _
                                             txtTabagheh.Text, _
                                             txtCodePosti.Text, _
                                             txtRadif_MGhabli.Text, _
                                             txtMasahat_zamin.Text, _
                                             txtMasahat_Jebhah.Text, _
                                             txtMasahat_PJebheh.Text, _
                                             txtTedad_Zel.Text, _
                                             txtTedad_Bar.Text, _
                                             txtOnvan_Bar.Text, _
                                             txtTedad_Malek.Text, _
                                             cboNo_Moshakhasat.SelectedValue, _
                                             txtTedad_Sakhteman.Text, _
                                             txtTedad_Aparteman.Text, _
                                             txtTedad_Vahed_Kasb.Text, _
                                             txtMasahat_Melk.Text, _
                                             txtMetrDar.Text, _
                                             chkRah_Mostaghel.Checked, _
                                             txtTedad_Vahed.Text, _
                                             cboNo_Malekiyat.SelectedValue, _
                                             txtName_Malek.Text, _
                                             chkHozour.Checked)
            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function

    Sub Load_For_Update()
        shsh_Update()
        Dim queryString As String = "SELECT  Tarikh_Malekiat, Tarikh_PMalekiat, " + _
            "Shomare_Shenasnameh, N_Mashhoor, N_Khiaban, N_Meydan, N_Bazar, N_Pasaj, N_Koocheh, " + _
            "N_BonBast, N_PelakAbi, N_Name_Block, N_Tabagheh, N_Code_Posti, N_Radif_MGhabli, " + _
            "Masahat_Zamin, Masahat_Jebheh, Masahat_PJebheh, Tedad_Zel, Bar_Tedad, Bar_Onvan, " + _
            "Tedad_Malek, No_Moshakhasat, Tedad_Sakhteman, Tedad_Aparteman, Tedad_Vahed_Kasb, Masahat_Melk, " + _
            "Metr_Dar, Rah_Mostaghel, Tedad_Vahed ,No_Malekiyat, Name_Malek,Hozoor FROM dbo.FSelect_TBL_Amlak_Mostaghelat ('" + _Shomareh_Shenasnameh + "')"

        Using connection As New SqlConnection()
            connection.ConnectionString = My.Settings.DB_NoSaziConnectionString
            Dim command As New SqlCommand(queryString, connection)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            Try

                While reader.Read()


                    Me.txtMashhour.Text = (reader("N_Mashhoor"))
                    Me.txtKhiaban.Text = (reader("N_Khiaban"))
                    Me.txtMeydan.Text = (reader("N_Meydan"))
                    Me.txtBazar.Text = (reader("N_Bazar"))
                    Me.txtPasaj.Text = (reader("N_Pasaj"))
                    Me.txtKoucheh.Text = (reader("N_Koocheh"))
                    Me.txtBonBast.Text = (reader("N_BonBast"))
                    Me.txtPelakAbi.Text = (reader("N_PelakAbi"))
                    Me.txtBlock.Text = (reader("N_Name_Block"))
                    Me.txtTabagheh.Text = (reader("N_Tabagheh"))
                    Me.txtCodePosti.Text = (reader("N_Code_Posti"))
                    Me.txtRadif_MGhabli.Text = (reader("N_Radif_MGhabli"))
                    Me.txtTarikh_Malekiyat.Text = (reader("Tarikh_Malekiat"))
                    Me.txtTarikh_PMalekiyat.Text = (reader("Tarikh_PMalekiat"))
                    Me.txtMasahat_zamin.Text = (reader("Masahat_Zamin"))
                    Me.txtMasahat_Jebhah.Text = (reader("Masahat_Jebheh"))
                    Me.txtMasahat_PJebheh.Text = (reader("Masahat_PJebheh"))
                    Me.txtTedad_Malek.Text = (reader("Tedad_Malek"))
                    Me.txtTedad_Zel.Text = (reader("Tedad_Zel"))
                    Me.txtTedad_Bar.Text = (reader("Bar_Tedad"))
                    Me.txtOnvan_Bar.Text = (reader("Bar_Onvan"))
                    Me.txtTedad_Vahed_Kasb.Text = (reader("Tedad_Vahed_Kasb"))
                    Me.txtTedad_Sakhteman.Text = (reader("Tedad_Sakhteman"))
                    Me.txtTedad_Aparteman.Text = (reader("Tedad_Aparteman"))
                    Me.txtMasahat_Melk.Text = (reader("Masahat_Melk"))
                    Me.txtMetrDar.Text = (reader("Metr_Dar"))
                    Me.chkRah_Mostaghel.Checked = CBool(reader("Rah_Mostaghel"))
                    Me.cboNo_Moshakhasat.Text = (reader("No_Moshakhasat"))
                    Me.txtTedad_Vahed.Text = (reader("Tedad_Vahed"))
                    Me.cboNo_Malekiyat.Text = (reader("No_Malekiyat"))
                    Me.txtName_Malek.Text = (reader("Name_Malek"))
                    Me.chkHozour.Checked = CBool(reader("Hozoor"))


                End While
            Finally
                reader.Close()
            End Try
        End Using


    End Sub

#End Region



    Private Sub txt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1.TextChanged, txt9.TextChanged, txt8.TextChanged, txt7.TextChanged, txt6.TextChanged, txt5.TextChanged, txt4.TextChanged, txt3.TextChanged, txt27.TextChanged, txt26.TextChanged, txt25.TextChanged, txt24.TextChanged, txt23.TextChanged, txt22.TextChanged, txt21.TextChanged, txt20.TextChanged, txt2.TextChanged, txt19.TextChanged, txt18.TextChanged, txt17.TextChanged, txt16.TextChanged, txt15.TextChanged, txt14.TextChanged, txt13.TextChanged, txt12.TextChanged, txt11.TextChanged, txt10.TextChanged

        If sender.TextLength = 1 Then
            SendKeys.Send("{DOWN}")
        End If


    End Sub
End Class