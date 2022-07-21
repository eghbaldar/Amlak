Public Class FrmAfrad_Momayezi

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        If _Load_Type = LT._New Then

            If Insert() Then
                Me.Close()
            End If


        Else
            If Update_db() Then
                Me.Close()
            End If


        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If Insert() Then
            FrmMoshakhasat_Momayezi.MdiParent = FrmMain
            FrmMoshakhasat_Momayezi.Show()
            Me.Close()
        End If
    End Sub

    Private Sub FrmAfrad_Momayezi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try


            If _Load_Type = LT._Edit Then
                Load_For_Update()
                lblSHsh.Text = _Shomareh_Shenasnameh
                Me.Select_Tbl_Afrad_MomayeziTableAdapter.Fill(Me.DB_NoSaziDataSet.Select_Tbl_Afrad_Momayezi, Me.lblSHsh.Text)
                btnNext.Visible = False

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#Region "Functions"

    Sub Load_For_Update()
        Me.txtMomayez_Tarikh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblAfradMomayeziBindingSource, "Momayez_Tarikh", True))
        Me.txtMomayez_Name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblAfradMomayeziBindingSource, "Momayez_Name", True))
        Me.txtBazbin_Tarikh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblAfradMomayeziBindingSource, "Bazbin_Tarikh", True))
        Me.txtBazbin_Name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblAfradMomayeziBindingSource, "Bazbin_Name", True))
        Me.txtSNahiyeh_Tarikh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblAfradMomayeziBindingSource, "SNahieh_Tarikh", True))
        Me.txtSNahiyeh_Name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblAfradMomayeziBindingSource, "SNahieh_Name", True))
        Me.txtSMantagheh_Tarikh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblAfradMomayeziBindingSource, "SMantagheh_Tarikh", True))
        Me.txtSMantagheh_Name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblAfradMomayeziBindingSource, "SMantagheh_Name", True))


    End Sub

    Function Insert() As Integer


        Try
            _insert.Insert_Tbl_Afrad_Momayezi(lblSHsh.Text, _
                                        txtMomayez_Tarikh.Text, _
                                        txtMomayez_Name.Text, _
                                        txtBazbin_Tarikh.Text, _
                                        txtBazbin_Name.Text, _
                                        txtSNahiyeh_Tarikh.Text, _
                                        txtSNahiyeh_Name.Text, _
                                        txtMomayez_Tarikh.Text, _
                                        txtSMantagheh_Name.Text)
            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function

    Function Update_db() As Integer

        Try
            _Update.Update_Tbl_Afrad_Momayezi(lblSHsh.Text, _
                                        txtMomayez_Tarikh.Text, _
                                        txtMomayez_Name.Text, _
                                        txtBazbin_Tarikh.Text, _
                                        txtBazbin_Name.Text, _
                                        txtSNahiyeh_Tarikh.Text, _
                                        txtSNahiyeh_Name.Text, _
                                        txtMomayez_Tarikh.Text, _
                                        txtSMantagheh_Name.Text)
            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function

#End Region



End Class