Public Class FrmMoshakhasat_Malekin

    Private Sub FrmMoshakhasat_Malekin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Select_DFNsTableAdapter.Fill(Me.DB_NoSaziDataSet.Select_DFNs, "all")

            If _Load_Type = LT._Edit Then
                Me.Select_Tbl_Moshakhasat_MalekinTableAdapter.Fill(Me.DB_NoSaziDataSet.Select_Tbl_Moshakhasat_Malekin, _Shomareh_Shenasnameh)
                Load_For_Update()
                btnNext.Visible = False
                lblSHsh.Text = _Shomareh_Shenasnameh

            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

#Region "Functions"

    Function insert() As Integer
        Try
            _insert.Insert_Tbl_Moshakhasat_Malekin(_Shomareh_Shenasnameh, _
                                               txtTarikh_Tamallok.Text, _
                                               cboNoMalekiyatCode.SelectedValue, _
                                               txtNo_Malekiyat_Tedad.Text, _
                                               cboVazeyatTamallok.SelectedValue, _
                                              cboCodeNoMalekiyat.SelectedValue, _
                                               txtFName.Text, _
                                               txtLName.Text, _
                                               txtName_Pedar.Text, _
                                               txtSHsh.Text, _
                                               txtCodeMelli.Text, _
                                               txtMahal_Sodour.Text, _
                                               txtAddress.Text, _
                                               txtTel.Text)
            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function

    Sub Load_For_Update()

        Me.txtTarikh_Tamallok.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_MalekinBindingSource, "Tarikh_Tamallok", True))
        Me.cboNoMalekiyatCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_MalekinBindingSource, "No_Malekiyat_Code", True))
        Me.txtNo_Malekiyat_Tedad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_MalekinBindingSource, "No_Malekiyat_Tedad", True))
        Me.cboVazeyatTamallok.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_MalekinBindingSource, "Vaziyat_Tamallok", True))
        Me.cboCodeNoMalekiyat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_MalekinBindingSource, "Code_No_Malekiat", True))
        Me.txtFName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_MalekinBindingSource, "Malek_Name", True))
        Me.txtLName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_MalekinBindingSource, "Malek_Family", True))
        Me.txtName_Pedar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_MalekinBindingSource, "Malek_Name_Pedar", True))
        Me.txtSHsh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_MalekinBindingSource, "Malek_SHsh", True))
        Me.txtCodeMelli.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_MalekinBindingSource, "Malek_CodeMelli", True))
        Me.txtMahal_Sodour.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_MalekinBindingSource, "Malek_MahalSodur", True))
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_MalekinBindingSource, "Malek_Address", True))
        Me.txtTel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_Moshakhasat_MalekinBindingSource, "Malek_Tel", True))


    End Sub

    Dim code_melli As String

    Function update_db()
        Try
            _Update.Update_Tbl_Moshakhasat_Malekin(_Shomareh_Shenasnameh, _
                                                code_melli, _
                                            0, _
                                               txtTarikh_Tamallok.Text, _
                                               cboNoMalekiyatCode.SelectedValue, _
                                               txtNo_Malekiyat_Tedad.Text, _
                                               cboVazeyatTamallok.SelectedValue, _
                                               cboCodeNoMalekiyat.SelectedValue, _
                                               txtFName.Text, _
                                               txtLName.Text, _
                                               txtName_Pedar.Text, _
                                               txtSHsh.Text, _
                                               txtCodeMelli.Text, _
                                                txtMahal_Sodour.Text, _
                                               txtAddress.Text, _
                                               txtTel.Text)


            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function

#End Region

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If insert() Then
            FrmMahiyat_Fiziki.MdiParent = FrmMain
            FrmMahiyat_Fiziki.Show()
        End If

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Private Sub Select_Tbl_Moshakhasat_MalekinBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Select_Tbl_Moshakhasat_MalekinBindingSource.CurrentChanged
        If _Load_Type = LT._Edit Then
            code_melli = txtCodeMelli.Text
        End If
    End Sub

    Private Sub Select_Tbl_Moshakhasat_MalekinBindingSource_BindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.BindingCompleteEventArgs) Handles Select_Tbl_Moshakhasat_MalekinBindingSource.BindingComplete
        If _Load_Type = LT._Edit Then
            code_melli = txtCodeMelli.Text
        End If
    End Sub
End Class

