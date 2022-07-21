Imports System.Windows.Forms

Public Class DlgView_DBlock

    Public code, sharh As String


    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        If _Load_Type = LT._Edit Then

            code = Me.Select_DFN_BLOCKDataGridView.CurrentRow.Cells(1).Value
            sharh = Me.Select_DFN_BLOCKDataGridView.CurrentRow.Cells(2).Value

            FrmDBlock.MdiParent = FrmMain
            FrmDBlock.Show()
            Me.Close()
        End If

    End Sub

    Private Sub DlgView_DBlock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Select_DFN_BLOCKTableAdapter.Fill(Me.DB_NoSaziDataSet.Select_DFN_BLOCK, "", "")

    End Sub

    Private Sub Select_DFN_BLOCKDataGridView_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Select_DFN_BLOCKDataGridView.CellMouseDoubleClick
        If _Load_Type = LT._Edit Then

            code = Me.Select_DFN_BLOCKDataGridView.CurrentRow.Cells(1).Value
            sharh = Me.Select_DFN_BLOCKDataGridView.CurrentRow.Cells(1).Value

            FrmDBlock.MdiParent = FrmMain
            FrmDBlock.Show()
            Me.Close()
        End If
    End Sub

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSharh.TextChanged
        FrmDBlock.Select_DFN_BLOCKTableAdapter.Fill(Me.DB_NoSaziDataSet.Select_DFN_BLOCK, txtCode.Text, txtSharh.Text)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class
