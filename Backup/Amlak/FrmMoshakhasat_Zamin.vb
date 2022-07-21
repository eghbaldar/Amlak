Imports System.Data.SqlClient

Public Class FrmMoshakhasat_Zamin

    Private Sub FrmMoshakhasat_Zamin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Try

            '# 1 #


            lblSHsh.Text = _Shomareh_Shenasnameh
            Me.Select_DFNsTableAdapter.Fill(Me.DB_NoSaziDataSet.Select_DFNs, "Jahat")

            If _Load_Type = LT._Edit Then
                Load_For_Update()
                btnNext.Visible = False
                Me.Select_Tbl_Moshakhasat_ZaminTableAdapter.Fill(Me.DB_NoSaziDataSet.Select_Tbl_Moshakhasat_Zamin, _Shomareh_Shenasnameh)
                jahat = ComboBox1.SelectedValue

            Else
                lblRadif.Text = M_Public.Max_Radif(Me.DGZamin) + 1

            End If


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If insert() Then
            FrmMoshakhasat_Malekin.MdiParent = FrmMain
            FrmMoshakhasat_Malekin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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

            _insert.Insert_Tbl_Moshakhasat_Zamin(lblSHsh.Text, _
                                             lblRadif.Text, _
                                             ComboBox1.SelectedValue, _
                                             txtTool_Zel.Text, _
                                             txtTool_Bar.Text, _
                                             txtMaabar_Name.Text, _
                                             txtMaabar_Arz.Text, _
                                             txtMaabar_Radif.Text, _
                                             txtZavieh.Text, _
                                             txtJebheh_1.Text, _
                                             txtJebheh_2.Text)
            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function

    Function update_db() As Integer
        Try

            _Update.Update_Tbl_Moshakhasat_Zamin(_Shomareh_Shenasnameh, _
                                             jahat, _
                                            lblRadif.Text, _
                                             ComboBox1.SelectedValue, _
                                            txtTool_Zel.Text, _
                                            txtTool_Bar.Text, _
                                            txtMaabar_Name.Text, _
                                            txtMaabar_Arz.Text, _
                                            txtMaabar_Radif.Text, _
                                            txtZavieh.Text, _
                                            txtJebheh_1.Text, _
                                            txtJebheh_2.Text)

            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function

    Sub Load_For_Update()



        Me.lblRadif.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblMoshakhasatZaminBindingSource, "Radif", True))
        Me.lblSHsh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblMoshakhasatZaminBindingSource, "Shomare_Shenasnameh", True))
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblMoshakhasatZaminBindingSource, "jahat", True))
        Me.txtTool_Zel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblMoshakhasatZaminBindingSource, "Tool_Zel", True))
        Me.txtTool_Bar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblMoshakhasatZaminBindingSource, "Tool_Bar", True))
        Me.txtMaabar_Name.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblMoshakhasatZaminBindingSource, "MaAbar_Name", True))
        Me.txtMaabar_Arz.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblMoshakhasatZaminBindingSource, "MaAbar_Arz", True))
        Me.txtMaabar_Radif.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblMoshakhasatZaminBindingSource, "MaAbar_radif", True))
        Me.txtZavieh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblMoshakhasatZaminBindingSource, "zavieh", True))
        Me.txtJebheh_1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblMoshakhasatZaminBindingSource, "Masahat_jebheh1", True))
        Me.txtJebheh_2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectTblMoshakhasatZaminBindingSource, "Masahat_jebheh2", True))
        Me.SelectTblMoshakhasatZaminBindingSource.EndEdit()
    End Sub


#End Region


    Private Sub txtZavieh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtZavieh.TextChanged, txtTool_Zel.TextChanged, txtTool_Bar.TextChanged, txtMaabar_Radif.TextChanged, txtJebheh_2.TextChanged, txtJebheh_1.TextChanged, txtMaabar_Arz.TextChanged, TextualControl9.TextChanged, TextualControl7.TextChanged, TextualControl6.TextChanged, TextualControl10.TextChanged
        If sender.text = "" Then
            sender.text = 0
        End If
    End Sub

    Dim jahat As Integer

    Private Sub DGZamin_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGZamin.CellEnter
        If _Load_Type = LT._Edit Then
            jahat = Me.ComboBox1.SelectedValue
        End If
    End Sub

    Private Sub SelectTblMoshakhasatZaminBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectTblMoshakhasatZaminBindingSource.CurrentChanged
        If _Load_Type = LT._Edit Then
            jahat = Me.ComboBox1.SelectedValue
        End If
    End Sub

    Private Sub SelectTblMoshakhasatZaminBindingSource_BindingComplete(ByVal sender As System.Object, ByVal e As System.Windows.Forms.BindingCompleteEventArgs) Handles SelectTblMoshakhasatZaminBindingSource.BindingComplete
        If _Load_Type = LT._Edit Then
            jahat = Me.ComboBox1.SelectedValue
        End If
    End Sub
End Class