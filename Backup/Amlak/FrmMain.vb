Imports System.Windows.Forms

Public Class FrmMain

    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' SkinEngine1.SkinFile = Application.StartupPath + "\ssk\msn.ssk"
        ' _Shomareh_Shenasnameh = "000110036100               "

    End Sub

    Private Sub BtnArsehJadidToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuArsehJadid.Click
        _Load_Type = LT._New
        FrmDBlock.MdiParent = Me
        FrmDBlock.Show()
    End Sub

    Private Sub NavBarItem2_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem2.LinkClicked
        Form2.Show()
    End Sub

    Private Sub NavBarItem1_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked
        'Form2.MdiParent = Me
        'Form2.Show()

        FrmTamlak.MdiParent = Me
        FrmTamlak.Show()
    End Sub



#Region "Edit, LT ==> Load Type."



    Private Sub mnuAmlak_Mostaghalat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAmlak_Mostaghalat.Click
        _Edit_Forms = Edit.Moshakhasat_Avalieh
        FrmFind.MdiParent = Me
        FrmFind.Show()
    End Sub

    Private Sub mnuMoshakhasat_Zamin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMoshakhasat_Zamin.Click
        _Edit_Forms = Edit.Moshakhasat_Zamin
        FrmFind.MdiParent = Me
        FrmFind.Show()
    End Sub

    Private Sub mnuMoshakhasat_Malekin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMoshakhasat_Malekin.Click
        _Edit_Forms = Edit.Moshakhasat_Malekin
        FrmFind.MdiParent = Me
        FrmFind.Show()
    End Sub

    Private Sub mnuNo_Estefadeh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNo_Estefadeh.Click
        _Edit_Forms = Edit.No_Estefadeh
        FrmFind.MdiParent = Me
        FrmFind.Show()
    End Sub

    Private Sub mnuMoshakhasat_Sakhteman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMoshakhasat_Sakhteman.Click
        _Edit_Forms = Edit.Moshakhasat_Sakhteman
        FrmFind.MdiParent = Me
        FrmFind.Show()
    End Sub

    Private Sub mnuMoshakhasat_Eshterak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMoshakhasat_Eshterak.Click
        _Edit_Forms = Edit.Moshakhasat_Eshterak
        FrmFind.MdiParent = Me
        FrmFind.Show()
    End Sub

    Private Sub mnuMoshakhasat_Momayezi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMoshakhasat_Momayezi.Click
        _Edit_Forms = Edit.Moshakhasat_Momayezi
        FrmFind.MdiParent = Me
        FrmFind.Show()
    End Sub

    Private Sub mnuAfrad_Momayezi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAfrad_Momayezi.Click
        _Edit_Forms = Edit.Afrad_Momayezi
        FrmFind.MdiParent = Me
        FrmFind.Show()
    End Sub

    Private Sub mnuMahiatFiziki_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMahiatFiziki.Click
        _Edit_Forms = Edit.Mahiyat_Fiziki
        FrmFind.MdiParent = Me
        FrmFind.Show()
    End Sub

    Private Sub mnuNoDerakht_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNoDerakht.Click
        _Edit_Forms = Edit.Derakht
        FrmFind.MdiParent = Me
        FrmFind.Show()
    End Sub

    Private Sub mnuTamlak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTamlak.Click
        _Edit_Forms = Edit.Tamlak
        FrmFind.MdiParent = Me
        FrmFind.Show()
    End Sub
#End Region

#Region "NEW"

    Private Sub mnuNEWAmlak_Mostaghalat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNEWAmlak_Mostaghalat.Click
        _Load_Type = LT._New
        FrmMoshakhasat_Avalieh.MdiParent = Me
        FrmMoshakhasat_Avalieh.Show()
    End Sub

    Private Sub mnuNEWTamlak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNEWTamlak.Click
        _Load_Type = LT._New
        FrmTamlak.MdiParent = Me
        FrmTamlak.Show()
    End Sub

    Private Sub mnuNEWMoshakhasat_Zamin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNEWMoshakhasat_Zamin.Click
        _Load_Type = LT._New
        FrmMoshakhasat_Zamin.MdiParent = Me
        FrmMoshakhasat_Zamin.Show()
    End Sub

    Private Sub mnuNEWMoshakhasat_Malekin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNEWMoshakhasat_Malekin.Click
        _Load_Type = LT._New
        FrmMoshakhasat_Malekin.MdiParent = Me
        FrmMoshakhasat_Malekin.Show()
    End Sub

    Private Sub mnuNEWMahiatFiziki_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNEWMahiatFiziki.Click
        _Load_Type = LT._New
        FrmMahiyat_Fiziki.MdiParent = Me
        FrmMahiyat_Fiziki.Show()
    End Sub

    Private Sub mnuNEWNo_Estefadeh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNEWNo_Estefadeh.Click
        _Load_Type = LT._New
        FrmNo_Estefadeh.MdiParent = Me
        FrmNo_Estefadeh.Show()
    End Sub

    Private Sub mnuNEWNoDerakht_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNEWNoDerakht.Click
        _Load_Type = LT._New
        FrmDerakht.MdiParent = Me
        FrmDerakht.Show()
    End Sub

    Private Sub mnuNEWMoshakhasat_Sakhteman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNEWMoshakhasat_Sakhteman.Click
        _Load_Type = LT._New
        FrmMoshakhasat_Sakhteman.MdiParent = Me
        FrmMoshakhasat_Sakhteman.Show()
    End Sub

    Private Sub mnuNEWMoshakhasat_Eshterak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNEWMoshakhasat_Eshterak.Click
        _Load_Type = LT._New
        FrmMoshakhasat_Eshterak.MdiParent = Me
        FrmMoshakhasat_Eshterak.Show()
    End Sub

    Private Sub mnuNEWMoshakhasat_Momayezi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNEWMoshakhasat_Momayezi.Click
        _Load_Type = LT._New
        FrmMoshakhasat_Momayezi.MdiParent = Me
        FrmMoshakhasat_Momayezi.Show()
    End Sub

    Private Sub mnuNEWAfrad_Momayezi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNEWAfrad_Momayezi.Click
        _Load_Type = LT._New
        FrmAfrad_Momayezi.MdiParent = Me
        FrmAfrad_Momayezi.Show()
    End Sub
#End Region

    Private Sub mnuFind_Melk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFind_Melk.Click
        FrmFind.MdiParent = Me
        FrmFind.Show()
    End Sub




    Private Sub MnuArsehFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuArsehFind.Click
        _Load_Type = LT._Edit
        DlgView_DBlock.ShowDialog()
    End Sub
End Class
