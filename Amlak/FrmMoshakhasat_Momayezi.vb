Public Class FrmMoshakhasat_Momayezi

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If insert() Then
            Me.Close()
        End If
    End Sub

#Region "Functions"

    Sub Load_For_Update()

        Me.txtTarikh_Momayezi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblMomayeziBindingSource, "Tarikh", True))
        Me.cboVazeiyat_Momayezi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblMomayeziBindingSource, "Vazeiat", True))

    End Sub

    Function insert() As Integer
        Try
            _insert.Insert_Tbl_Momayezi(lblSHsh.Text, _
                                    txtTarikh_Momayezi.Text, _
                                    cboVazeiyat_Momayezi.SelectedValue)
            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try

    End Function

    Function Update_db() As Integer
        Try
            _Update.Update_Tbl_Momayezi(lblSHsh.Text, _
                                    txtTarikh_Momayezi.Text, _
                                    cboVazeiyat_Momayezi.SelectedValue)
            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try

    End Function
#End Region

    Private Sub FrmMoshakhasat_Momayezi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Select_DFNsTableAdapter.Fill(Me.DB_NoSaziDataSet.Select_DFNs, "Vazeiat")

            If _Load_Type = LT._Edit Then
                Load_For_Update()
                lblSHsh.Text = _Shomareh_Shenasnameh
                Me.Select_Tbl_MomayeziTableAdapter.Fill(Me.DB_NoSaziDataSet.Select_Tbl_Momayezi, Me.lblSHsh.Text)
            
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class