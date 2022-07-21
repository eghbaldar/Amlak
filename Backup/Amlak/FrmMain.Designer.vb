<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MnuDFNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MnuArsehToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MnuArsehJadid = New System.Windows.Forms.ToolStripMenuItem
        Me.MnuArsehFind = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuArseh_GheymatJadid = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuArseh_GheymatFind = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuNoMalekiat = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuNama = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMelk = New System.Windows.Forms.ToolStripMenuItem
        Me.MnuNew_Melk = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTakmil = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuNEWAmlak_Mostaghalat = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuNEWTamlak = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuNEWMoshakhasat_Zamin = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuNEWMoshakhasat_Malekin = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuNEWMahiatFiziki = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuNEWNo_Estefadeh = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuNEWNoDerakht = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuNEWMoshakhasat_Sakhteman = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuNEWMoshakhasat_Eshterak = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuNEWAfrad_Momayezi = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuNEWMoshakhasat_Momayezi = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFind_Melk = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuAmlak_Mostaghalat = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTamlak = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMoshakhasat_Zamin = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMoshakhasat_Malekin = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMahiatFiziki = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuNo_Estefadeh = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuNoDerakht = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMoshakhasat_Sakhteman = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMoshakhasat_Eshterak = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuAfrad_Momayezi = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuMoshakhasat_Momayezi = New System.Windows.Forms.ToolStripMenuItem
        Me.XrDesignDockManager1 = New DevExpress.XtraReports.UserDesigner.XRDesignDockManager
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup
        Me.NavBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup
        Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem
        Me.NavBarItem2 = New DevExpress.XtraNavBar.NavBarItem
        Me.NavBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup
        Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.XrDesignDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hideContainerRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(610, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(38, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuDFNToolStripMenuItem, Me.mnuMelk})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(610, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MnuDFNToolStripMenuItem
        '
        Me.MnuDFNToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuArsehToolStripMenuItem, Me.ToolStripSeparator2, Me.mnuNoMalekiat, Me.mnuNama})
        Me.MnuDFNToolStripMenuItem.Name = "MnuDFNToolStripMenuItem"
        Me.MnuDFNToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.MnuDFNToolStripMenuItem.Text = "تعاریف"
        '
        'MnuArsehToolStripMenuItem
        '
        Me.MnuArsehToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuArsehJadid, Me.MnuArsehFind, Me.ToolStripSeparator1, Me.mnuArseh_GheymatJadid, Me.mnuArseh_GheymatFind})
        Me.MnuArsehToolStripMenuItem.Name = "MnuArsehToolStripMenuItem"
        Me.MnuArsehToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.MnuArsehToolStripMenuItem.Text = "ارزش عرصه"
        '
        'MnuArsehJadid
        '
        Me.MnuArsehJadid.Name = "MnuArsehJadid"
        Me.MnuArsehJadid.Size = New System.Drawing.Size(192, 22)
        Me.MnuArsehJadid.Text = "تعریف بلوک جدید"
        '
        'MnuArsehFind
        '
        Me.MnuArsehFind.Name = "MnuArsehFind"
        Me.MnuArsehFind.Size = New System.Drawing.Size(192, 22)
        Me.MnuArsehFind.Text = "جستجو و مشاهده بلوکها"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(189, 6)
        '
        'mnuArseh_GheymatJadid
        '
        Me.mnuArseh_GheymatJadid.Name = "mnuArseh_GheymatJadid"
        Me.mnuArseh_GheymatJadid.Size = New System.Drawing.Size(192, 22)
        Me.mnuArseh_GheymatJadid.Text = "تعریف قیمتها"
        '
        'mnuArseh_GheymatFind
        '
        Me.mnuArseh_GheymatFind.Name = "mnuArseh_GheymatFind"
        Me.mnuArseh_GheymatFind.Size = New System.Drawing.Size(192, 22)
        Me.mnuArseh_GheymatFind.Text = "جستجو و مشاهده قیمتها"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(157, 6)
        '
        'mnuNoMalekiat
        '
        Me.mnuNoMalekiat.Name = "mnuNoMalekiat"
        Me.mnuNoMalekiat.Size = New System.Drawing.Size(160, 22)
        Me.mnuNoMalekiat.Text = "نوع مالکیت"
        '
        'mnuNama
        '
        Me.mnuNama.Name = "mnuNama"
        Me.mnuNama.Size = New System.Drawing.Size(160, 22)
        Me.mnuNama.Text = "نوع نمای ساختمان"
        '
        'mnuMelk
        '
        Me.mnuMelk.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuNew_Melk, Me.mnuTakmil, Me.mnuFind_Melk, Me.mnuEdit})
        Me.mnuMelk.Name = "mnuMelk"
        Me.mnuMelk.Size = New System.Drawing.Size(40, 20)
        Me.mnuMelk.Text = "ملک"
        '
        'MnuNew_Melk
        '
        Me.MnuNew_Melk.Name = "MnuNew_Melk"
        Me.MnuNew_Melk.Size = New System.Drawing.Size(167, 22)
        Me.MnuNew_Melk.Text = "ملک جدید"
        '
        'mnuTakmil
        '
        Me.mnuTakmil.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNEWAmlak_Mostaghalat, Me.mnuNEWTamlak, Me.mnuNEWMoshakhasat_Zamin, Me.mnuNEWMoshakhasat_Malekin, Me.mnuNEWMahiatFiziki, Me.mnuNEWNo_Estefadeh, Me.mnuNEWNoDerakht, Me.mnuNEWMoshakhasat_Sakhteman, Me.mnuNEWMoshakhasat_Eshterak, Me.mnuNEWAfrad_Momayezi, Me.mnuNEWMoshakhasat_Momayezi})
        Me.mnuTakmil.Name = "mnuTakmil"
        Me.mnuTakmil.Size = New System.Drawing.Size(167, 22)
        Me.mnuTakmil.Text = "تکمیل فرمهای ناقص"
        '
        'mnuNEWAmlak_Mostaghalat
        '
        Me.mnuNEWAmlak_Mostaghalat.Name = "mnuNEWAmlak_Mostaghalat"
        Me.mnuNEWAmlak_Mostaghalat.Size = New System.Drawing.Size(220, 22)
        Me.mnuNEWAmlak_Mostaghalat.Text = "مشخصات اولیه"
        '
        'mnuNEWTamlak
        '
        Me.mnuNEWTamlak.Name = "mnuNEWTamlak"
        Me.mnuNEWTamlak.Size = New System.Drawing.Size(220, 22)
        Me.mnuNEWTamlak.Text = "مشخصات مورد محاسبه"
        '
        'mnuNEWMoshakhasat_Zamin
        '
        Me.mnuNEWMoshakhasat_Zamin.Name = "mnuNEWMoshakhasat_Zamin"
        Me.mnuNEWMoshakhasat_Zamin.Size = New System.Drawing.Size(220, 22)
        Me.mnuNEWMoshakhasat_Zamin.Text = "مشخصات زمین"
        '
        'mnuNEWMoshakhasat_Malekin
        '
        Me.mnuNEWMoshakhasat_Malekin.Name = "mnuNEWMoshakhasat_Malekin"
        Me.mnuNEWMoshakhasat_Malekin.Size = New System.Drawing.Size(220, 22)
        Me.mnuNEWMoshakhasat_Malekin.Text = "مشخصات مالکین"
        '
        'mnuNEWMahiatFiziki
        '
        Me.mnuNEWMahiatFiziki.Name = "mnuNEWMahiatFiziki"
        Me.mnuNEWMahiatFiziki.Size = New System.Drawing.Size(220, 22)
        Me.mnuNEWMahiatFiziki.Text = "ماهیت فیزیکی ملک"
        '
        'mnuNEWNo_Estefadeh
        '
        Me.mnuNEWNo_Estefadeh.Name = "mnuNEWNo_Estefadeh"
        Me.mnuNEWNo_Estefadeh.Size = New System.Drawing.Size(220, 22)
        Me.mnuNEWNo_Estefadeh.Text = "نوع استفاده از ملک"
        '
        'mnuNEWNoDerakht
        '
        Me.mnuNEWNoDerakht.Name = "mnuNEWNoDerakht"
        Me.mnuNEWNoDerakht.Size = New System.Drawing.Size(220, 22)
        Me.mnuNEWNoDerakht.Text = "نوع درخت"
        '
        'mnuNEWMoshakhasat_Sakhteman
        '
        Me.mnuNEWMoshakhasat_Sakhteman.Name = "mnuNEWMoshakhasat_Sakhteman"
        Me.mnuNEWMoshakhasat_Sakhteman.Size = New System.Drawing.Size(220, 22)
        Me.mnuNEWMoshakhasat_Sakhteman.Text = "مشخصات ساختمان"
        '
        'mnuNEWMoshakhasat_Eshterak
        '
        Me.mnuNEWMoshakhasat_Eshterak.Name = "mnuNEWMoshakhasat_Eshterak"
        Me.mnuNEWMoshakhasat_Eshterak.Size = New System.Drawing.Size(220, 22)
        Me.mnuNEWMoshakhasat_Eshterak.Text = "مشخصات اشتراک و مستحدثات"
        '
        'mnuNEWAfrad_Momayezi
        '
        Me.mnuNEWAfrad_Momayezi.Name = "mnuNEWAfrad_Momayezi"
        Me.mnuNEWAfrad_Momayezi.Size = New System.Drawing.Size(220, 22)
        Me.mnuNEWAfrad_Momayezi.Text = "افراد ممیزی"
        '
        'mnuNEWMoshakhasat_Momayezi
        '
        Me.mnuNEWMoshakhasat_Momayezi.Name = "mnuNEWMoshakhasat_Momayezi"
        Me.mnuNEWMoshakhasat_Momayezi.Size = New System.Drawing.Size(220, 22)
        Me.mnuNEWMoshakhasat_Momayezi.Text = "مشخصات ممیزی"
        '
        'mnuFind_Melk
        '
        Me.mnuFind_Melk.Name = "mnuFind_Melk"
        Me.mnuFind_Melk.Size = New System.Drawing.Size(167, 22)
        Me.mnuFind_Melk.Text = "جستجوی ملک"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAmlak_Mostaghalat, Me.mnuTamlak, Me.mnuMoshakhasat_Zamin, Me.mnuMoshakhasat_Malekin, Me.mnuMahiatFiziki, Me.mnuNo_Estefadeh, Me.mnuNoDerakht, Me.mnuMoshakhasat_Sakhteman, Me.mnuMoshakhasat_Eshterak, Me.mnuAfrad_Momayezi, Me.mnuMoshakhasat_Momayezi})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(167, 22)
        Me.mnuEdit.Text = "ویرایش ملک"
        '
        'mnuAmlak_Mostaghalat
        '
        Me.mnuAmlak_Mostaghalat.Name = "mnuAmlak_Mostaghalat"
        Me.mnuAmlak_Mostaghalat.Size = New System.Drawing.Size(220, 22)
        Me.mnuAmlak_Mostaghalat.Text = "مشخصات اولیه"
        '
        'mnuTamlak
        '
        Me.mnuTamlak.Name = "mnuTamlak"
        Me.mnuTamlak.Size = New System.Drawing.Size(220, 22)
        Me.mnuTamlak.Text = "مشخصات مورد محاسبه"
        '
        'mnuMoshakhasat_Zamin
        '
        Me.mnuMoshakhasat_Zamin.Name = "mnuMoshakhasat_Zamin"
        Me.mnuMoshakhasat_Zamin.Size = New System.Drawing.Size(220, 22)
        Me.mnuMoshakhasat_Zamin.Text = "مشخصات زمین"
        '
        'mnuMoshakhasat_Malekin
        '
        Me.mnuMoshakhasat_Malekin.Name = "mnuMoshakhasat_Malekin"
        Me.mnuMoshakhasat_Malekin.Size = New System.Drawing.Size(220, 22)
        Me.mnuMoshakhasat_Malekin.Text = "مشخصات مالکین"
        '
        'mnuMahiatFiziki
        '
        Me.mnuMahiatFiziki.Name = "mnuMahiatFiziki"
        Me.mnuMahiatFiziki.Size = New System.Drawing.Size(220, 22)
        Me.mnuMahiatFiziki.Text = "ماهیت فیزیکی ملک"
        '
        'mnuNo_Estefadeh
        '
        Me.mnuNo_Estefadeh.Name = "mnuNo_Estefadeh"
        Me.mnuNo_Estefadeh.Size = New System.Drawing.Size(220, 22)
        Me.mnuNo_Estefadeh.Text = "نوع استفاده از ملک"
        '
        'mnuNoDerakht
        '
        Me.mnuNoDerakht.Name = "mnuNoDerakht"
        Me.mnuNoDerakht.Size = New System.Drawing.Size(220, 22)
        Me.mnuNoDerakht.Text = "نوع درخت"
        '
        'mnuMoshakhasat_Sakhteman
        '
        Me.mnuMoshakhasat_Sakhteman.Name = "mnuMoshakhasat_Sakhteman"
        Me.mnuMoshakhasat_Sakhteman.Size = New System.Drawing.Size(220, 22)
        Me.mnuMoshakhasat_Sakhteman.Text = "مشخصات ساختمان"
        '
        'mnuMoshakhasat_Eshterak
        '
        Me.mnuMoshakhasat_Eshterak.Name = "mnuMoshakhasat_Eshterak"
        Me.mnuMoshakhasat_Eshterak.Size = New System.Drawing.Size(220, 22)
        Me.mnuMoshakhasat_Eshterak.Text = "مشخصات اشتراک و مستحدثات"
        '
        'mnuAfrad_Momayezi
        '
        Me.mnuAfrad_Momayezi.Name = "mnuAfrad_Momayezi"
        Me.mnuAfrad_Momayezi.Size = New System.Drawing.Size(220, 22)
        Me.mnuAfrad_Momayezi.Text = "افراد ممیزی"
        '
        'mnuMoshakhasat_Momayezi
        '
        Me.mnuMoshakhasat_Momayezi.Name = "mnuMoshakhasat_Momayezi"
        Me.mnuMoshakhasat_Momayezi.Size = New System.Drawing.Size(220, 22)
        Me.mnuMoshakhasat_Momayezi.Text = "مشخصات ممیزی"
        '
        'XrDesignDockManager1
        '
        Me.XrDesignDockManager1.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerRight})
        Me.XrDesignDockManager1.Form = Me
        Me.XrDesignDockManager1.ImageStream = CType(resources.GetObject("XrDesignDockManager1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.XrDesignDockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.FloatVertical = True
        Me.DockPanel1.ID = New System.Guid("4accdea7-cace-4127-9329-bf77b8d2f4b2")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.AllowDockBottom = False
        Me.DockPanel1.Options.AllowDockFill = False
        Me.DockPanel1.Options.AllowDockTop = False
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel1.SavedIndex = 0
        Me.DockPanel1.Size = New System.Drawing.Size(200, 453)
        Me.DockPanel1.Text = "دسترسی سریع"
        Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.PictureBox1)
        Me.DockPanel1_Container.Controls.Add(Me.NavBarControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 25)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(194, 425)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 103)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup1
        Me.NavBarControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NavBarControl1.ContentButtonHint = Nothing
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1, Me.NavBarGroup2, Me.NavBarGroup3})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NavBarItem1, Me.NavBarItem2})
        Me.NavBarControl1.Location = New System.Drawing.Point(17, 105)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 150
        Me.NavBarControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NavBarControl1.Size = New System.Drawing.Size(150, 287)
        Me.NavBarControl1.TabIndex = 24
        Me.NavBarControl1.Text = "NavBarControl1"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = " "
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'NavBarGroup2
        '
        Me.NavBarGroup2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.NavBarGroup2.Appearance.Options.UseBackColor = True
        Me.NavBarGroup2.Caption = "TEST"
        Me.NavBarGroup2.Expanded = True
        Me.NavBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem2)})
        Me.NavBarGroup2.Name = "NavBarGroup2"
        '
        'NavBarItem1
        '
        Me.NavBarItem1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NavBarItem1.Appearance.Options.UseBackColor = True
        Me.NavBarItem1.AppearanceDisabled.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NavBarItem1.AppearanceDisabled.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.NavBarItem1.AppearanceDisabled.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NavBarItem1.AppearanceDisabled.Options.UseBackColor = True
        Me.NavBarItem1.AppearanceDisabled.Options.UseBorderColor = True
        Me.NavBarItem1.AppearanceHotTracked.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NavBarItem1.AppearanceHotTracked.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NavBarItem1.AppearanceHotTracked.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NavBarItem1.AppearanceHotTracked.Options.UseBackColor = True
        Me.NavBarItem1.AppearanceHotTracked.Options.UseBorderColor = True
        Me.NavBarItem1.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NavBarItem1.AppearancePressed.BackColor2 = System.Drawing.Color.Moccasin
        Me.NavBarItem1.AppearancePressed.Image = CType(resources.GetObject("NavBarItem1.AppearancePressed.Image"), System.Drawing.Image)
        Me.NavBarItem1.AppearancePressed.Options.UseBackColor = True
        Me.NavBarItem1.AppearancePressed.Options.UseImage = True
        Me.NavBarItem1.Caption = "NavBarItem1"
        Me.NavBarItem1.Name = "NavBarItem1"
        '
        'NavBarItem2
        '
        Me.NavBarItem2.Caption = "NavBarItem2"
        Me.NavBarItem2.Name = "NavBarItem2"
        '
        'NavBarGroup3
        '
        Me.NavBarGroup3.Caption = ""
        Me.NavBarGroup3.Name = "NavBarGroup3"
        '
        'hideContainerRight
        '
        Me.hideContainerRight.Controls.Add(Me.DockPanel1)
        Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.hideContainerRight.Location = New System.Drawing.Point(610, 0)
        Me.hideContainerRight.Name = "hideContainerRight"
        Me.hideContainerRight.Size = New System.Drawing.Size(22, 453)
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.hideContainerRight)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.IsMdiContainer = True
        Me.Name = "FrmMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "FrmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.XrDesignDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hideContainerRight.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MnuDFNToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuArsehToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuArsehJadid As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuArsehFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuArseh_GheymatJadid As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuArseh_GheymatFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuNoMalekiat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNama As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMelk As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTakmil As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFind_Melk As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAmlak_Mostaghalat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMoshakhasat_Zamin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMoshakhasat_Malekin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMahiatFiziki As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNo_Estefadeh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNoDerakht As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMoshakhasat_Sakhteman As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMoshakhasat_Eshterak As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMoshakhasat_Momayezi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTamlak As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XrDesignDockManager1 As DevExpress.XtraReports.UserDesigner.XRDesignDockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem2 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarGroup3 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents mnuNEWTamlak As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNEWMoshakhasat_Zamin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNEWMoshakhasat_Malekin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNEWMahiatFiziki As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNEWNo_Estefadeh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNEWNoDerakht As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNEWMoshakhasat_Sakhteman As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNEWMoshakhasat_Eshterak As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNEWMoshakhasat_Momayezi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNEWAmlak_Mostaghalat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuNew_Melk As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNEWAfrad_Momayezi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAfrad_Momayezi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer

End Class
