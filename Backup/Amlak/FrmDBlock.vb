Public Class FrmDBlock

  

    Private Sub FrmDBlock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _Load_Type = LT._Edit Then

            Load_For_Update()
            Me.Select_DFN_BLOCKTableAdapter.Fill(Me.DB_NoSaziDataSet.Select_DFN_BLOCK, DlgView_DBlock.code, DlgView_DBlock.sharh)
        End If


    End Sub

 
    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            If _Load_Type = LT._New Then



            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnGheymat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGheymat.Click
        With FrmDGheymat_Arseh
            .MdiParent = FrmMain
            _Codeblock = Me.txtCode.Text
            .Show()
            .lblCodeBlock.Text = Me.txtCode.Text
            .lblSharhBlock.Text = "(" + Me.txtSharh.Text + ")"
            .FSelect_Sal_GheymatTableAdapter.Fill(Me.DB_NoSaziDataSet.FSelect_Sal_Gheymat, Me.txtCode3Raghami.Text)

        End With


    End Sub


#Region "Functions"

    Function Insert() As Integer
        Try
            _insert.Insert_DFN_BLOCK(txtCode.Text, _
                                     txtCode3Raghami.Text, _
                                     txtSharh.Text, _
                                     txtShomal.Text, _
                                     txtShargh.Text, _
                                     txtJonoub.Text, _
                                     txtGharb.Text)

            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function

    Function Update_db() As Integer
        Try
            _Update.Update_TblDFN_Block(txtCode.Text, _
                                     txtCode3Raghami.Text, _
                                     txtSharh.Text, _
                                     txtShomal.Text, _
                                     txtShargh.Text, _
                                     txtJonoub.Text, _
                                     txtGharb.Text)


            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function


    Sub Load_For_Update()
        Me.txtCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectDFNBLOCKBindingSource, "Code", True))
        Me.txtCode3Raghami.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectDFNBLOCKBindingSource, "Code_SHsh", True))
        Me.txtSharh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectDFNBLOCKBindingSource, "Sharh", True))
        Me.txtShomal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectDFNBLOCKBindingSource, "Shomal", True))
        Me.txtShargh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectDFNBLOCKBindingSource, "Shargh", True))
        Me.txtJonoub.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectDFNBLOCKBindingSource, "Jonoub", True))
        Me.txtGharb.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectDFNBLOCKBindingSource, "Gharb", True))


    End Sub

#End Region


    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        _Load_Type = LT._Edit
        DlgView_DBlock.ShowDialog()

    End Sub
End Class