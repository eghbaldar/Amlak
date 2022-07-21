Public Class FrmCalc

    
    Private Sub FrmCalc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Try
            Me.FSelect_CalcTableAdapter.Fill(Me.DB_NoSaziDataSet.FSelect_Calc, "000110036100               ")
            Try
                'TODO: This line of code loads data into the 'DB_NoSaziDataSet.TblDFN_Gheymat' table. You can move, or remove it, as needed.
                Me.TblDFN_GheymatTableAdapter.Fill(Me.DB_NoSaziDataSet.TblDFN_Gheymat, "")
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtSharh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSharh.TextChanged
        Me.TblDFN_GheymatTableAdapter.Fill(Me.DB_NoSaziDataSet.TblDFN_Gheymat, txtSharh.Text)
    End Sub

   
    Private Sub TblDFN_GheymatDataGridView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblDFN_GheymatDataGridView.CellClick, TblDFN_GheymatDataGridView.CellEnter
        Try
            'FSelect_SalTableAdapter.Fill(Me.DB_NoSaziDataSet.FSelect_Sal, _
            '                             TblDFN_GheymatDataGridView.Rows(e.RowIndex).Cells(0).Value.ToString, _
            '                             TblDFN_GheymatDataGridView.Rows(e.RowIndex).Cells(2).Value.ToString)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TblDFN_GheymatDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblDFN_GheymatDataGridView.CellContentClick

    End Sub
End Class