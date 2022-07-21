

Public Class Form2

    Dim _ConStr As String = "data source=.;initial catalog=DB_NoSazi;integrated security=true"
    Dim _dbl As New Sqldblayer.Dblayer(_ConStr)


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_NoSaziDataSet.Tbl_No_Estefadeh' table. You can move, or remove it, as needed.
        Me.Tbl_No_EstefadehTableAdapter.Fill(Me.DB_NoSaziDataSet.Tbl_No_Estefadeh)
        ' TextBox1.Text = _dbl.ExecsqlScalar("select code from dfns")


    End Sub

 


    Private Sub Tbl_No_EstefadehBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_No_EstefadehBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_No_EstefadehBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_NoSaziDataSet)

    End Sub
End Class