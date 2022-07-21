Public Class FrmMoshakhasat_Eshterak

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If insert() Then
            Me.Close()
            FrmAfrad_Momayezi.MdiParent = FrmMain
            FrmAfrad_Momayezi.Show()
        End If
    End Sub


#Region "Functions"
    Function insert() As Integer
        Try
            _insert.Insert_Tbl_Eshterak(lblSHsh.Text, _
                                    txtMos_Hajm_Estakhr.Text, _
                                    txtMos_Masahat_Estakhr.Text, _
                                    txtMos_Golkhaneh.Text, _
                                    txtMos_Chah.Text, _
                                    txtAb.Text, _
                                    txtBargh.Text, _
                                    txtGaz.Text, _
                                    txtTel.Text)

            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try

    End Function

    Function update_db() As Integer

        Try
            _Update.Update_Tbl_Eshterak(lblSHsh.Text, _
                                        txtMos_Hajm_Estakhr.Text, _
                                        txtMos_Masahat_Estakhr.Text, _
                                        txtMos_Golkhaneh.Text, _
                                        txtMos_Chah.Text, _
                                        txtAb.Text, _
                                        txtBargh.Text, _
                                        txtGaz.Text, _
                                        txtTel.Text)


            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try

    End Function



    Sub Load_For_Update()
        Me.txtAb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblEshterakBindingSource, "Tedad_Tabaghat", True))
        Me.txtBargh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblEshterakBindingSource, "Tedad_Tabaghat", True))
        Me.txtGaz.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblEshterakBindingSource, "Tedad_Tabaghat", True))
        Me.txtTel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblEshterakBindingSource, "Tedad_Tabaghat", True))
        Me.txtMos_Hajm_Estakhr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblEshterakBindingSource, "Tedad_Tabaghat", True))
        Me.txtMos_Masahat_Estakhr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblEshterakBindingSource, "Tedad_Tabaghat", True))
        Me.txtMos_Golkhaneh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblEshterakBindingSource, "Tedad_Tabaghat", True))
        Me.txtMos_Chah.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblEshterakBindingSource, "Tedad_Tabaghat", True))


    End Sub

#End Region

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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub FrmMoshakhasat_Eshterak_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try


            If _Load_Type = LT._Edit Then
                Load_For_Update()
                lblSHsh.Text = _Shomareh_Shenasnameh
                Me.Select_Tbl_EshterakTableAdapter.Fill(Me.DB_NoSaziDataSet.Select_Tbl_Eshterak, Me.lblSHsh.Text)
                btnNext.Visible = False

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class