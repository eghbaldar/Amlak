
Public Class FrmMoshakhasat_Sakhteman

    Private Sub FrmMoshakhasat_Sakhteman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            If _Load_Type = LT._Edit Then
                Me.lblSHsh.Text = _Shomareh_Shenasnameh
                Load_For_Update()
                Me.Select_Tbl_Moshakhasat_SakhtemanTableAdapter.Fill(Me.DB_NoSaziDataSet.Select_Tbl_Moshakhasat_Sakhteman, Me.lblSHsh.Text)
                btnNext.Visible = False
            End If


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click


        If _Load_Type = LT._New Then

            If insert() Then
                Me.Close()
            End If


        Else
            If update_db() Then
                Me.Close()
            End If


        End If
    End Sub

#Region "Functions"
    Function insert() As Integer

        Try
            _insert.Insert_Tbl_Moshakhasat_Sakhteman(lblSHsh.Text, _
                                                 txtTedad_Tabaghat.Text, _
                                                 txtMasahat_Zirbana.Text, _
                                                 txtMasahat_Bana.Text, _
                                                 txtHararat.Text, _
                                                 txtTahvieh.Text, _
                                                 txtKhonak_Konandeh.Text, _
                                                 txtAsansor.Text, _
                                                 txtNo_Divar.Text, _
                                                 txtNo_Saghf.Text, _
                                                 txtCode_No_Sakhteman.Text, _
                                                 txtNo_Nama.Text, _
                                                 txtNo_Nama_Code.Text, _
                                                 txtMasahat_ZirZamin.Text)




            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try

    End Function

    Function update_db() As Integer
        Try
            _Update.Update_Tbl_Moshakhasat_Sakhteman(lblSHsh.Text, _
                                                      Convert.ToSingle(Masahat_Zirbana), _
                                                    Convert.ToSingle(Masahat_bana), _
                                                 txtTedad_Tabaghat.Text, _
                                                 txtMasahat_Zirbana.Text, _
                                                 txtMasahat_Bana.Text, _
                                                 txtHararat.Text, _
                                                 txtTahvieh.Text, _
                                                 txtKhonak_Konandeh.Text, _
                                                 txtAsansor.Text, _
                                                  txtNo_Divar.Text, _
                                                 txtNo_Saghf.Text, _
                                                 txtCode_No_Sakhteman.Text, _
                                                 txtNo_Nama.Text, _
                                                 txtNo_Nama_Code.Text, _
                                                 txtMasahat_ZirZamin.Text)
            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try


    End Function

    Sub Load_For_Update()

        Me.txtTedad_Tabaghat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_SakhtemanBindingSource, "Tedad_Tabaghat", True))
        Me.txtMasahat_Zirbana.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_SakhtemanBindingSource, "Masahat_Zirbana", True))
        Me.txtMasahat_Bana.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_SakhtemanBindingSource, "Masahat_Bana", True))
        Me.txtHararat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_SakhtemanBindingSource, "Masahat_Hararat", True))
        Me.txtTahvieh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_SakhtemanBindingSource, "Masahat_Tahvieh", True))
        Me.txtKhonak_Konandeh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_SakhtemanBindingSource, "Masahat_Khonak", True))
        Me.txtAsansor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_SakhtemanBindingSource, "Masahat_Asansor", True))
        Me.txtNo_Divar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_SakhtemanBindingSource, "Sharh_No_Divar", True))
        Me.txtNo_Saghf.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_SakhtemanBindingSource, "Sharh_No_Saghf", True))
        Me.txtMasahat_ZirZamin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_SakhtemanBindingSource, "Masahat_zirzamin", True))
        Me.txtCode_No_Sakhteman.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_SakhtemanBindingSource, "Code_no_Sakhteman", True))
        Me.txtNo_Nama.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_SakhtemanBindingSource, "No_Nama", True))
        Me.txtNo_Nama_Code.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_SakhtemanBindingSource, "No_Nama_Code", True))


    End Sub



#End Region

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If insert() Then
            FrmMoshakhasat_Eshterak.MdiParent = FrmMain
            FrmMoshakhasat_Eshterak.Show()
        End If

        If _Load_Type = LT._New Then

            If insert() Then
                Me.Close()
            End If


        Else
            If update_db() Then
                Me.Close()

            End If


        End If

    End Sub

    Dim Masahat_bana, Masahat_Zirbana As String

    Private Sub Select_Tbl_Moshakhasat_SakhtemanBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Select_Tbl_Moshakhasat_SakhtemanBindingSource.CurrentChanged
        If _Load_Type = LT._Edit Then
            Masahat_bana = txtMasahat_Bana.Text
            Masahat_Zirbana = txtMasahat_Zirbana.Text
        End If

    End Sub

    Private Sub Select_Tbl_Moshakhasat_SakhtemanBindingSource_BindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.BindingCompleteEventArgs) Handles Select_Tbl_Moshakhasat_SakhtemanBindingSource.BindingComplete
        If _Load_Type = LT._Edit Then
            Masahat_bana = txtMasahat_Bana.Text
            Masahat_Zirbana = txtMasahat_Zirbana.Text
        End If

    End Sub
End Class