Public Class FrmDGheymat_Arseh


    Private Sub FrmDGheymat_Arseh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub txtGheymat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGheymat.TextChanged
        lblGheymat_Str.Text = "قیمت به حروف:" + NUM_TO_STR(txtGheymat.PoolString) + "ریال"

    End Sub

    Private Sub btnGheymat_Jadid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGheymat_Jadid.Click
        Gheymat_Insert()
        txtSharh.Text = ""
        txtGheymat.Text = 0
        lblGheymat_Str.Text = "قیمت به حروف:"
        txtSharh.Focus()


    End Sub

#Region "Function"

    Sub Gheymat_Insert()

        txtGheymat.Text = 0
        txtSharh.Text = ""
    End Sub

#End Region


    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        Gheymat_Insert()
        Me.Close()
    End Sub



End Class