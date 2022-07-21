Public Class FrmDerakht

    Private Sub FrmDerakht_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'TODO: This line of code loads data into the 'DB_NoSaziDataSet.Tbl_Derakht' table. You can move, or remove it, as needed.
            Me.Select_DFNsTableAdapter.Fill(Me.DB_NoSaziDataSet.Select_DFNs, "all")

            '# 1 #
            If _Load_Type = "edit" Then
                lblSHsh.Text = _Shomareh_Shenasnameh
                Load_For_Update()
                Me.Select_Tbl_DerakhtTableAdapter.Fill(Me.DB_NoSaziDataSet.Select_Tbl_Derakht, _Shomareh_Shenasnameh)
                btnNext.Visible = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try





    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If insert() Then
            Me.Close()
            FrmMoshakhasat_Sakhteman.MdiParent = FrmMain
            FrmMoshakhasat_Sakhteman.Show()

        End If
    End Sub


#Region "Functions"
    Function insert() As Integer
        Try
            _insert.Insert_Tbl_Derakht(lblSHsh.Text, _
                                   cboNo_Derakht.SelectedValue, _
                                   cboTedad_Derakht.SelectedValue)

            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try

    End Function

    Function Update_db() As Integer
        Try
            _Update.Update_Tbl_Derakht(lblSHsh.Text, _
                                       No, _
                                       Bon, _
                                       cboNo_Derakht.SelectedValue, _
                                       cboTedad_Derakht.SelectedValue)


            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function


    Sub Load_For_Update()

        Me.cboNo_Derakht.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_DerakhtBindingSource, "NO", True))
        Me.cboTedad_Derakht.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Select_Tbl_DerakhtBindingSource, "Bon", True))

    End Sub

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If insert() Then
            Me.Close()

        End If
    End Sub

    Dim No, Bon As Integer

    Private Sub SelectDFNsBindingSource__bon_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectDFNsBindingSource__bon.CurrentChanged, SelectDFNsBindingSource__No.CurrentChanged
        If _Load_Type = LT._Edit Then

            No = cboNo_Derakht.SelectedValue
            Bon = cboTedad_Derakht.SelectedValue

        End If
    End Sub
End Class