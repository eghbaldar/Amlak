Public Class FrmNo_Estefadeh

    Private Sub FrmNo_Estefadeh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        lblSHsh.Text = _Shomareh_Shenasnameh

        If _Load_Type = LT._Edit Then
            Load_For_Update()
            Me.Select_Tbl_No_EstefadehTableAdapter.Fill(Me.DB_NoSaziDataSet.Select_Tbl_No_Estefadeh, _Shomareh_Shenasnameh)
        End If

    End Sub

#Region "Functions"

    Sub Load_For_Update()

        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SelectTblNoEstefadehBindingSource, "C351", True))
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SelectTblNoEstefadehBindingSource, "C352", True))
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SelectTblNoEstefadehBindingSource, "C353", True))
        Me.CheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SelectTblNoEstefadehBindingSource, "C350", True))
        Me.CheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SelectTblNoEstefadehBindingSource, "C355", True))
        Me.CheckBox6.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SelectTblNoEstefadehBindingSource, "C356", True))
        Me.CheckBox7.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SelectTblNoEstefadehBindingSource, "C357", True))
        Me.CheckBox8.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SelectTblNoEstefadehBindingSource, "C354", True))
        Me.CheckBox9.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SelectTblNoEstefadehBindingSource, "C359", True))
        Me.CheckBox10.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SelectTblNoEstefadehBindingSource, "C360", True))
        Me.CheckBox11.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SelectTblNoEstefadehBindingSource, "C361", True))
        Me.CheckBox12.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SelectTblNoEstefadehBindingSource, "C358", True))
        Me.CheckBox13.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SelectTblNoEstefadehBindingSource, "C363", True))
        Me.CheckBox14.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SelectTblNoEstefadehBindingSource, "C364", True))
        Me.CheckBox15.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SelectTblNoEstefadehBindingSource, "C365", True))
        Me.CheckBox16.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SelectTblNoEstefadehBindingSource, "C362", True))
        Me.CheckBox17.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SelectTblNoEstefadehBindingSource, "C367", True))
        Me.CheckBox18.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SelectTblNoEstefadehBindingSource, "C368", True))
        Me.CheckBox19.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SelectTblNoEstefadehBindingSource, "C369", True))
        Me.CheckBox20.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SelectTblNoEstefadehBindingSource, "C366", True))
        Me.CheckBox21.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SelectTblNoEstefadehBindingSource, "C371", True))
        Me.CheckBox22.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SelectTblNoEstefadehBindingSource, "C372", True))
        Me.CheckBox24.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SelectTblNoEstefadehBindingSource, "C370", True))



    End Sub

    Function Update_db() As Integer
        Try

            _Update.Update_Tbl_No_Estefadeh(lblSHsh.Text, _
                                            CheckBox4.Checked, _
                                            CheckBox1.Checked, _
                                            CheckBox2.Checked, _
                                            CheckBox3.Checked, _
                                            CheckBox8.Checked, _
                                            CheckBox5.Checked, _
                                            CheckBox6.Checked, _
                                            CheckBox7.Checked, _
                                            CheckBox12.Checked, _
                                            CheckBox9.Checked, _
                                            CheckBox10.Checked, _
                                            CheckBox11.Checked, _
                                            CheckBox16.Checked, _
                                            CheckBox13.Checked, _
                                            CheckBox14.Checked, _
                                            CheckBox15.Checked, _
                                            CheckBox20.Checked, _
                                            CheckBox17.Checked, _
                                            CheckBox18.Checked, _
                                            CheckBox19.Checked, _
                                            CheckBox24.Checked, _
                                            CheckBox21.Checked, _
                                            CheckBox22.Checked)
            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try

    End Function

    Function insert() As Integer
        Try

            _insert.Insert_Tbl_No_Estefadeh(lblSHsh.Text, _
                                            CheckBox4.Checked, _
                                            CheckBox1.Checked, _
                                            CheckBox2.Checked, _
                                            CheckBox3.Checked, _
                                            CheckBox8.Checked, _
                                            CheckBox5.Checked, _
                                            CheckBox6.Checked, _
                                            CheckBox7.Checked, _
                                            CheckBox12.Checked, _
                                            CheckBox9.Checked, _
                                            CheckBox10.Checked, _
                                            CheckBox11.Checked, _
                                            CheckBox16.Checked, _
                                            CheckBox13.Checked, _
                                            CheckBox14.Checked, _
                                            CheckBox15.Checked, _
                                            CheckBox20.Checked, _
                                            CheckBox17.Checked, _
                                            CheckBox18.Checked, _
                                            CheckBox19.Checked, _
                                            CheckBox24.Checked, _
                                            CheckBox21.Checked, _
                                            CheckBox22.Checked)

            Return 1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try

    End Function

#End Region

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        _Shomareh_Shenasnameh = lblSHsh.Text
        If insert() Then
            Me.Close()
            FrmDerakht.MdiParent = FrmMain
            FrmDerakht.Show()

        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        If _Load_Type = LT._New Then

            If insert() Then
                Me.Close()
            End If
        Else
            If Update_db() Then
                Me.Close()
            End If

        End If
    End Sub

End Class