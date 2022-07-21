Imports System.Data.SqlClient

Public Class FrmTamlak


    Private Sub FrmTamlak_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_NoSaziDataSet.TAmlak' table. You can move, or remove it, as needed.
        Me.TAmlakTableAdapter.Fill(Me.DB_NoSaziDataSet.TAmlak)

        Me.lblSHsh.Text = _Shomareh_Shenasnameh


        If _Load_Type = LT._Edit Then

            Load_For_Update()
            btnNext.Visible = False

        End If
    End Sub


#Region "Sub"


    Sub Load_For_Update()

        Dim queryString As String = "SELECT [Kasri],[Ezafat],[No_Melk],[Masahat_ZirBana],[Tedad_vahed],[Masahat_Bana]," + _
        "[Arzesh_Moamelati],[TKasri_Zamin],[TAzafe_tarakom],[THagh_Nezareh],[TSodore_ParvanehAnboh]," + _
        "[TSodore_ParvanehVilaie],[TSath_Shahr],[TNosazi],[TTamirat],[TTransfer],[TPazireh]  FROM [DB_NoSazi].[dbo].[TAmlak]  where SHsh= '" + _Shomareh_Shenasnameh.ToString + "'"

        Using connection As New SqlConnection()
            connection.ConnectionString = My.Settings.DB_NoSaziConnectionString
            Dim command As New SqlCommand(queryString, connection)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            Try

                While reader.Read()

                    Me.txtKasri.Text = (reader("Kasri"))
                    Me.txtEzafat.Text = (reader("Ezafat"))

                    If (reader("No_Melk")) = 8 Then
                        cboNo_Melk.SelectedText = "خانه مسکونی"
                    Else
                        cboNo_Melk.SelectedText = "مغازه"
                    End If

                    Text = (reader("No_Melk"))

                    Me.txtM_Zirbana.Text = (reader("Masahat_ZirBana"))
                    Me.txtTedad_Vahed.Text = (reader("Tedad_vahed"))
                    Me.txtM_Bana.Text = (reader("Masahat_Bana"))
                    Me.txtArzesh_Moamelati.Text = (reader("Arzesh_Moamelati"))
                    Me.chkTKasri_Zamin.Checked = (reader("TKasri_Zamin"))
                    Me.chkTAzafe_tarakom.Checked = (reader("TAzafe_tarakom"))
                    Me.chkTHagh_Nezareh.Checked = (reader("THagh_Nezareh"))
                    Me.chkTSodore_ParvanehAnboh.Checked = (reader("TSodore_ParvanehAnboh"))
                    Me.chkTSodore_ParvanehVilaie.Checked = (reader("TSodore_ParvanehVilaie"))
                    Me.txtSath_Shahr.Text = (reader("TSath_Shahr"))
                    Me.txtNosazi.Text = (reader("TNosazi"))
                    Me.txtTamirat.Text = (reader("TTamirat"))
                    Me.chkEntaghal.Checked = (reader("TTransfer"))
                    Me.chkPazireh.Checked = (reader("TPazireh"))
                End While
            Finally
                reader.Close()
            End Try
        End Using
    End Sub


    Function insert() As Integer

        Dim no_melk As Byte

        If cboNo_Melk.Text = "مغازه" Then
            no_melk = 9
        Else
            no_melk = 8
        End If
        MsgBox("in")
        Try
            _insert.Insert_TAmlak(_Shomareh_Shenasnameh, _
                                          txtKasri.Text, _
                                          txtEzafat.Text, _
                                          no_melk, _
                                          txtM_Zirbana.Text, _
                                          txtTedad_Vahed.Text, _
                                          txtM_Bana.Text, _
                                          txtArzesh_Moamelati.Text, _
                                          chkTKasri_Zamin.Checked, _
                                          chkTAzafe_tarakom.Checked, _
                                          chkTHagh_Nezareh.Checked, _
                                          chkTSodore_ParvanehAnboh.Checked, _
                                          chkTSodore_ParvanehVilaie.Checked, _
                                          txtSath_Shahr.Text, _
                                          txtNosazi.Text, _
                                          txtTamirat.Text, _
                                          chkEntaghal.Checked, _
                                          chkPazireh.Checked)


            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function


    Function Update_db() As Integer
        Dim no_melk As Byte

        If cboNo_Melk.Text = "مغازه" Then
            no_melk = 9
        Else
            no_melk = 8
        End If



        Try


            MsgBox("UP")



            'Dim cmd As New SqlCommand
            'Dim sqlConnection1 As New SqlConnection(My.Settings.DB_NoSaziConnectionString)

            'cmd.CommandType = System.Data.CommandType.Text
            'cmd.CommandText = "UPDATE [DB_NoSazi].[dbo].[TAmlak] set " + _
            '  " [Ezafat] = " + txtEzafat.Text + " , [No_Melk] = " + no_melk.ToString + " WHERE [SHsh] = '" + _Shomareh_Shenasnameh + "'"




            'cmd.Connection = sqlConnection1
            'sqlConnection1.Open()
            'cmd.ExecuteNonQuery()
            'sqlConnection1.Close()




            _Update.Update_TAmlak(lblSHsh.Text, _
            txtKasri.Text, _
            txtEzafat.Text, _
            no_melk, _
            txtM_Zirbana.Text, _
            txtTedad_Vahed.Text, _
            txtM_Bana.Text, _
            txtArzesh_Moamelati.Text, _
            chkTKasri_Zamin.Checked, _
            chkTAzafe_tarakom.Checked, _
            chkTHagh_Nezareh.Checked, _
            chkTSodore_ParvanehAnboh.Checked, _
            chkTSodore_ParvanehVilaie.Checked, _
            txtSath_Shahr.Text, _
            txtNosazi.Text, _
            txtTamirat.Text, _
            chkEntaghal.Checked, _
            chkPazireh.Checked)

            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try

    End Function

#End Region


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


    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        _Shomareh_Shenasnameh = lblSHsh.Text
        FrmMoshakhasat_Zamin.MdiParent = FrmMain
        FrmMoshakhasat_Zamin.Show()

    End Sub

    Private Sub txtTedad_Vahed_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTedad_Vahed.TextChanged

    End Sub

    
End Class