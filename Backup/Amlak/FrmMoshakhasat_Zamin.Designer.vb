<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMoshakhasat_Zamin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMoshakhasat_Zamin))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtTool_Zel = New TextualControl.TextualControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTool_Bar = New TextualControl.TextualControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtMaabar_Name = New TextualControl.TextualControl
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtMaabar_Arz = New TextualControl.TextualControl
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMaabar_Radif = New TextualControl.TextualControl
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextualControl8 = New TextualControl.TextualControl
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.TextualControl9 = New TextualControl.TextualControl
        Me.TextualControl10 = New TextualControl.TextualControl
        Me.TextualControl6 = New TextualControl.TextualControl
        Me.TextualControl7 = New TextualControl.TextualControl
        Me.txtZavieh = New TextualControl.TextualControl
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtJebheh_1 = New TextualControl.TextualControl
        Me.Label11 = New System.Windows.Forms.Label
        Me.DB_NoSaziDataSet = New Amlak.DB_NoSaziDataSet
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblRadif = New System.Windows.Forms.Label
        Me.SelectDFNsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnOK = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.Select_DFNsTableAdapter = New Amlak.DB_NoSaziDataSetTableAdapters.Select_DFNsTableAdapter
        Me.lblSHsh = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableAdapterManager = New Amlak.DB_NoSaziDataSetTableAdapters.TableAdapterManager
        Me.DGZamin = New System.Windows.Forms.DataGridView
        Me.ShomareShenasnamehDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RadifDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.JahatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MaAbarNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MaAbar_Arz = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SelectTblMoshakhasatZaminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Select_Tbl_Moshakhasat_ZaminTableAdapter = New Amlak.DB_NoSaziDataSetTableAdapters.Select_Tbl_Moshakhasat_ZaminTableAdapter
        Me.txtJebheh_2 = New TextualControl.TextualControl
        Me.XrDesignDockManager1 = New DevExpress.XtraReports.UserDesigner.XRDesignDockManager
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DB_NoSaziDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectDFNsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGZamin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectTblMoshakhasatZaminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrDesignDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(530, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "شماره شناسنامه زمین"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(613, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "جهت"
        '
        'txtTool_Zel
        '
        Me.txtTool_Zel.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTool_Zel.ColorFocuse = System.Drawing.Color.Empty
        Me.txtTool_Zel.DefaultColor = System.Drawing.Color.Empty
        Me.txtTool_Zel.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtTool_Zel.Location = New System.Drawing.Point(331, 36)
        Me.txtTool_Zel.Name = "txtTool_Zel"
        Me.txtTool_Zel.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtTool_Zel.Size = New System.Drawing.Size(100, 21)
        Me.txtTool_Zel.TabIndex = 1
        Me.txtTool_Zel.Text = "0"
        Me.txtTool_Zel.Type = TextualControl.TextualControl.No.Numeric
        Me.txtTool_Zel.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtTool_Zel.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(437, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "طول ضلع"
        '
        'txtTool_Bar
        '
        Me.txtTool_Bar.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTool_Bar.ColorFocuse = System.Drawing.Color.Empty
        Me.txtTool_Bar.DefaultColor = System.Drawing.Color.Empty
        Me.txtTool_Bar.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtTool_Bar.Location = New System.Drawing.Point(157, 36)
        Me.txtTool_Bar.Name = "txtTool_Bar"
        Me.txtTool_Bar.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtTool_Bar.Size = New System.Drawing.Size(100, 21)
        Me.txtTool_Bar.TabIndex = 2
        Me.txtTool_Bar.Text = "0"
        Me.txtTool_Bar.Type = TextualControl.TextualControl.No.Numeric
        Me.txtTool_Bar.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtTool_Bar.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(263, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "طول بر"
        '
        'txtMaabar_Name
        '
        Me.txtMaabar_Name.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMaabar_Name.ColorFocuse = System.Drawing.Color.Empty
        Me.txtMaabar_Name.DefaultColor = System.Drawing.Color.Empty
        Me.txtMaabar_Name.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtMaabar_Name.Location = New System.Drawing.Point(258, 20)
        Me.txtMaabar_Name.Name = "txtMaabar_Name"
        Me.txtMaabar_Name.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtMaabar_Name.Size = New System.Drawing.Size(196, 21)
        Me.txtMaabar_Name.TabIndex = 1
        Me.txtMaabar_Name.Type = TextualControl.TextualControl.No.Normal
        Me.txtMaabar_Name.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtMaabar_Name.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(460, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "نام"
        '
        'txtMaabar_Arz
        '
        Me.txtMaabar_Arz.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMaabar_Arz.ColorFocuse = System.Drawing.Color.Empty
        Me.txtMaabar_Arz.DefaultColor = System.Drawing.Color.Empty
        Me.txtMaabar_Arz.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtMaabar_Arz.Location = New System.Drawing.Point(103, 20)
        Me.txtMaabar_Arz.Name = "txtMaabar_Arz"
        Me.txtMaabar_Arz.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtMaabar_Arz.Size = New System.Drawing.Size(100, 21)
        Me.txtMaabar_Arz.TabIndex = 2
        Me.txtMaabar_Arz.Text = "0"
        Me.txtMaabar_Arz.Type = TextualControl.TextualControl.No.Numeric
        Me.txtMaabar_Arz.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtMaabar_Arz.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(209, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "عرض"
        '
        'txtMaabar_Radif
        '
        Me.txtMaabar_Radif.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMaabar_Radif.ColorFocuse = System.Drawing.Color.Empty
        Me.txtMaabar_Radif.DefaultColor = System.Drawing.Color.Empty
        Me.txtMaabar_Radif.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtMaabar_Radif.Location = New System.Drawing.Point(15, 20)
        Me.txtMaabar_Radif.Name = "txtMaabar_Radif"
        Me.txtMaabar_Radif.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtMaabar_Radif.Size = New System.Drawing.Size(35, 21)
        Me.txtMaabar_Radif.TabIndex = 3
        Me.txtMaabar_Radif.Text = "0"
        Me.txtMaabar_Radif.Type = TextualControl.TextualControl.No.Numeric
        Me.txtMaabar_Radif.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtMaabar_Radif.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "ردیف"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtMaabar_Name)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtMaabar_Arz)
        Me.GroupBox1.Controls.Add(Me.txtMaabar_Radif)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.TextualControl6)
        Me.GroupBox1.Controls.Add(Me.TextualControl7)
        Me.GroupBox1.Location = New System.Drawing.Point(147, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(493, 51)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "معبر"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextualControl8)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.TextualControl9)
        Me.GroupBox3.Controls.Add(Me.TextualControl10)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(493, 51)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "معبر"
        '
        'TextualControl8
        '
        Me.TextualControl8.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextualControl8.ColorFocuse = System.Drawing.Color.Empty
        Me.TextualControl8.DefaultColor = System.Drawing.Color.Empty
        Me.TextualControl8.Language = TextualControl.TextualControl.Zaban.Persian
        Me.TextualControl8.Location = New System.Drawing.Point(258, 20)
        Me.TextualControl8.Name = "TextualControl8"
        Me.TextualControl8.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.TextualControl8.Size = New System.Drawing.Size(196, 21)
        Me.TextualControl8.TabIndex = 0
        Me.TextualControl8.Type = TextualControl.TextualControl.No.Normal
        Me.TextualControl8.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.TextualControl8.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(56, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "ردیف"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(460, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(20, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "نام"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(209, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 13)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "عرض"
        '
        'TextualControl9
        '
        Me.TextualControl9.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextualControl9.ColorFocuse = System.Drawing.Color.Empty
        Me.TextualControl9.DefaultColor = System.Drawing.Color.Empty
        Me.TextualControl9.Language = TextualControl.TextualControl.Zaban.Persian
        Me.TextualControl9.Location = New System.Drawing.Point(103, 20)
        Me.TextualControl9.Name = "TextualControl9"
        Me.TextualControl9.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.TextualControl9.Size = New System.Drawing.Size(100, 21)
        Me.TextualControl9.TabIndex = 1
        Me.TextualControl9.Text = "0"
        Me.TextualControl9.Type = TextualControl.TextualControl.No.Numeric
        Me.TextualControl9.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.TextualControl9.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'TextualControl10
        '
        Me.TextualControl10.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextualControl10.ColorFocuse = System.Drawing.Color.Empty
        Me.TextualControl10.DefaultColor = System.Drawing.Color.Empty
        Me.TextualControl10.Language = TextualControl.TextualControl.Zaban.Persian
        Me.TextualControl10.Location = New System.Drawing.Point(15, 20)
        Me.TextualControl10.Name = "TextualControl10"
        Me.TextualControl10.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.TextualControl10.Size = New System.Drawing.Size(35, 21)
        Me.TextualControl10.TabIndex = 2
        Me.TextualControl10.Text = "0"
        Me.TextualControl10.Type = TextualControl.TextualControl.No.Numeric
        Me.TextualControl10.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.TextualControl10.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'TextualControl6
        '
        Me.TextualControl6.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextualControl6.ColorFocuse = System.Drawing.Color.Empty
        Me.TextualControl6.DefaultColor = System.Drawing.Color.Empty
        Me.TextualControl6.Language = TextualControl.TextualControl.Zaban.Persian
        Me.TextualControl6.Location = New System.Drawing.Point(184, -29)
        Me.TextualControl6.Name = "TextualControl6"
        Me.TextualControl6.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.TextualControl6.Size = New System.Drawing.Size(100, 21)
        Me.TextualControl6.TabIndex = 0
        Me.TextualControl6.Text = "0"
        Me.TextualControl6.Type = TextualControl.TextualControl.No.Numeric
        Me.TextualControl6.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.TextualControl6.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'TextualControl7
        '
        Me.TextualControl7.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextualControl7.ColorFocuse = System.Drawing.Color.Empty
        Me.TextualControl7.DefaultColor = System.Drawing.Color.Empty
        Me.TextualControl7.Language = TextualControl.TextualControl.Zaban.Persian
        Me.TextualControl7.Location = New System.Drawing.Point(10, -29)
        Me.TextualControl7.Name = "TextualControl7"
        Me.TextualControl7.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.TextualControl7.Size = New System.Drawing.Size(100, 21)
        Me.TextualControl7.TabIndex = 1
        Me.TextualControl7.Text = "0"
        Me.TextualControl7.Type = TextualControl.TextualControl.No.Numeric
        Me.TextualControl7.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.TextualControl7.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'txtZavieh
        '
        Me.txtZavieh.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtZavieh.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtZavieh.DefaultColor = System.Drawing.Color.Empty
        Me.txtZavieh.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtZavieh.Location = New System.Drawing.Point(554, 129)
        Me.txtZavieh.Name = "txtZavieh"
        Me.txtZavieh.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtZavieh.Size = New System.Drawing.Size(47, 21)
        Me.txtZavieh.TabIndex = 3
        Me.txtZavieh.Text = "0"
        Me.txtZavieh.Type = TextualControl.TextualControl.No.Numeric
        Me.txtZavieh.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtZavieh.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(605, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "زاویه"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(268, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "مساحت جبهه 2"
        '
        'txtJebheh_1
        '
        Me.txtJebheh_1.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJebheh_1.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtJebheh_1.DefaultColor = System.Drawing.Color.Empty
        Me.txtJebheh_1.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtJebheh_1.Location = New System.Drawing.Point(356, 129)
        Me.txtJebheh_1.Name = "txtJebheh_1"
        Me.txtJebheh_1.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtJebheh_1.Size = New System.Drawing.Size(100, 21)
        Me.txtJebheh_1.TabIndex = 4
        Me.txtJebheh_1.Text = "0"
        Me.txtJebheh_1.Type = TextualControl.TextualControl.No.Numeric
        Me.txtJebheh_1.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtJebheh_1.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(462, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "مساحت جبهه 1"
        '
        'DB_NoSaziDataSet
        '
        Me.DB_NoSaziDataSet.DataSetName = "DB_NoSaziDataSet"
        Me.DB_NoSaziDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(250, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "ردیف"
        '
        'lblRadif
        '
        Me.lblRadif.AutoSize = True
        Me.lblRadif.Location = New System.Drawing.Point(200, 9)
        Me.lblRadif.Name = "lblRadif"
        Me.lblRadif.Size = New System.Drawing.Size(44, 13)
        Me.lblRadif.TabIndex = 9
        Me.lblRadif.Text = "Label12"
        '
        'SelectDFNsBindingSource
        '
        Me.SelectDFNsBindingSource.DataMember = "Select_DFNs"
        Me.SelectDFNsBindingSource.DataSource = Me.DB_NoSaziDataSet
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(12, 65)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(91, 39)
        Me.btnOK.TabIndex = 13
        Me.btnOK.TabStop = False
        Me.btnOK.Text = "ذخیره"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(12, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 39)
        Me.Button1.TabIndex = 12
        Me.Button1.TabStop = False
        Me.Button1.Text = "انصراف"
        Me.ToolTip1.SetToolTip(Me.Button1, "سلام")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(12, 20)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(91, 39)
        Me.btnNext.TabIndex = 11
        Me.btnNext.TabStop = False
        Me.btnNext.Text = "مشخصات مالکین"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Select_DFNsTableAdapter
        '
        Me.Select_DFNsTableAdapter.ClearBeforeFill = True
        '
        'lblSHsh
        '
        Me.lblSHsh.Location = New System.Drawing.Point(300, 9)
        Me.lblSHsh.Name = "lblSHsh"
        Me.lblSHsh.Size = New System.Drawing.Size(224, 13)
        Me.lblSHsh.TabIndex = 1
        Me.lblSHsh.Text = "شماره شناسنامه زمین"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Dorj"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DFNsTableAdapter = Nothing
        Me.TableAdapterManager.TAmlakTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_Amlak_MostaghelatTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_Mahiyat_FizikiTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_Moshakhasat_MalekinTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_Moshakhasat_SakhtemanTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_Moshakhasat_Zamin1TableAdapter = Nothing
        Me.TableAdapterManager.Tbl_Moshakhasat_Zamin2TableAdapter = Nothing
        Me.TableAdapterManager.Tbl_Moshakhasat_ZaminTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_No_EstefadehTableAdapter = Nothing
        Me.TableAdapterManager.TblDFN_BlockTableAdapter = Nothing
        Me.TableAdapterManager.TblDFN_GheymatTableAdapter = Nothing
        Me.TableAdapterManager.TblDFN_SALTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Amlak.DB_NoSaziDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DGZamin
        '
        Me.DGZamin.AllowUserToAddRows = False
        Me.DGZamin.AllowUserToDeleteRows = False
        Me.DGZamin.AutoGenerateColumns = False
        Me.DGZamin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGZamin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ShomareShenasnamehDataGridViewTextBoxColumn, Me.RadifDataGridViewTextBoxColumn, Me.JahatDataGridViewTextBoxColumn, Me.MaAbarNameDataGridViewTextBoxColumn, Me.MaAbar_Arz})
        Me.DGZamin.DataSource = Me.SelectTblMoshakhasatZaminBindingSource
        Me.DGZamin.Location = New System.Drawing.Point(15, 167)
        Me.DGZamin.Name = "DGZamin"
        Me.DGZamin.ReadOnly = True
        Me.DGZamin.Size = New System.Drawing.Size(628, 127)
        Me.DGZamin.TabIndex = 21
        Me.DGZamin.TabStop = False
        '
        'ShomareShenasnamehDataGridViewTextBoxColumn
        '
        Me.ShomareShenasnamehDataGridViewTextBoxColumn.DataPropertyName = "Shomare_Shenasnameh"
        Me.ShomareShenasnamehDataGridViewTextBoxColumn.HeaderText = "Shomare_Shenasnameh"
        Me.ShomareShenasnamehDataGridViewTextBoxColumn.Name = "ShomareShenasnamehDataGridViewTextBoxColumn"
        Me.ShomareShenasnamehDataGridViewTextBoxColumn.ReadOnly = True
        Me.ShomareShenasnamehDataGridViewTextBoxColumn.Visible = False
        Me.ShomareShenasnamehDataGridViewTextBoxColumn.Width = 150
        '
        'RadifDataGridViewTextBoxColumn
        '
        Me.RadifDataGridViewTextBoxColumn.DataPropertyName = "Radif"
        Me.RadifDataGridViewTextBoxColumn.HeaderText = "ردیف"
        Me.RadifDataGridViewTextBoxColumn.Name = "RadifDataGridViewTextBoxColumn"
        Me.RadifDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JahatDataGridViewTextBoxColumn
        '
        Me.JahatDataGridViewTextBoxColumn.DataPropertyName = "jahat"
        Me.JahatDataGridViewTextBoxColumn.HeaderText = "جهت"
        Me.JahatDataGridViewTextBoxColumn.Name = "JahatDataGridViewTextBoxColumn"
        Me.JahatDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaAbarNameDataGridViewTextBoxColumn
        '
        Me.MaAbarNameDataGridViewTextBoxColumn.DataPropertyName = "MaAbar_Name"
        Me.MaAbarNameDataGridViewTextBoxColumn.HeaderText = "نام معبر"
        Me.MaAbarNameDataGridViewTextBoxColumn.Name = "MaAbarNameDataGridViewTextBoxColumn"
        Me.MaAbarNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaAbarNameDataGridViewTextBoxColumn.Width = 200
        '
        'MaAbar_Arz
        '
        Me.MaAbar_Arz.DataPropertyName = "MaAbar_Arz"
        Me.MaAbar_Arz.HeaderText = "عرض معبر"
        Me.MaAbar_Arz.Name = "MaAbar_Arz"
        Me.MaAbar_Arz.ReadOnly = True
        '
        'SelectTblMoshakhasatZaminBindingSource
        '
        Me.SelectTblMoshakhasatZaminBindingSource.DataMember = "Select_Tbl_Moshakhasat_Zamin"
        Me.SelectTblMoshakhasatZaminBindingSource.DataSource = Me.DB_NoSaziDataSet
        '
        'Select_Tbl_Moshakhasat_ZaminTableAdapter
        '
        Me.Select_Tbl_Moshakhasat_ZaminTableAdapter.ClearBeforeFill = True
        '
        'txtJebheh_2
        '
        Me.txtJebheh_2.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJebheh_2.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtJebheh_2.DefaultColor = System.Drawing.Color.Empty
        Me.txtJebheh_2.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtJebheh_2.Location = New System.Drawing.Point(162, 129)
        Me.txtJebheh_2.Name = "txtJebheh_2"
        Me.txtJebheh_2.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtJebheh_2.Size = New System.Drawing.Size(100, 21)
        Me.txtJebheh_2.TabIndex = 5
        Me.txtJebheh_2.Text = "0"
        Me.txtJebheh_2.Type = TextualControl.TextualControl.No.Numeric
        Me.txtJebheh_2.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtJebheh_2.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'XrDesignDockManager1
        '
        Me.XrDesignDockManager1.Form = Me
        Me.XrDesignDockManager1.ImageStream = CType(resources.GetObject("XrDesignDockManager1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.XrDesignDockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.SelectDFNsBindingSource
        Me.ComboBox1.DisplayMember = "name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(486, 36)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "code"
        '
        'FrmMoshakhasat_Zamin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(655, 306)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtTool_Zel)
        Me.Controls.Add(Me.txtTool_Bar)
        Me.Controls.Add(Me.DGZamin)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblRadif)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtJebheh_1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtJebheh_2)
        Me.Controls.Add(Me.txtZavieh)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSHsh)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMoshakhasat_Zamin"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مشخصات زمین"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DB_NoSaziDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectDFNsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGZamin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectTblMoshakhasatZaminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrDesignDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTool_Zel As TextualControl.TextualControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTool_Bar As TextualControl.TextualControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMaabar_Name As TextualControl.TextualControl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMaabar_Arz As TextualControl.TextualControl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMaabar_Radif As TextualControl.TextualControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtZavieh As TextualControl.TextualControl
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtJebheh_1 As TextualControl.TextualControl
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblRadif As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents SelectDFNsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DB_NoSaziDataSet As Amlak.DB_NoSaziDataSet
    Friend WithEvents Select_DFNsTableAdapter As Amlak.DB_NoSaziDataSetTableAdapters.Select_DFNsTableAdapter
    Friend WithEvents lblSHsh As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TableAdapterManager As Amlak.DB_NoSaziDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DGZamin As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextualControl8 As TextualControl.TextualControl
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextualControl9 As TextualControl.TextualControl
    Friend WithEvents TextualControl10 As TextualControl.TextualControl
    Friend WithEvents TextualControl6 As TextualControl.TextualControl
    Friend WithEvents TextualControl7 As TextualControl.TextualControl
    Friend WithEvents SelectTblMoshakhasatZaminBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtJebheh_2 As TextualControl.TextualControl
    Friend WithEvents Select_Tbl_Moshakhasat_ZaminTableAdapter As Amlak.DB_NoSaziDataSetTableAdapters.Select_Tbl_Moshakhasat_ZaminTableAdapter
    Friend WithEvents XrDesignDockManager1 As DevExpress.XtraReports.UserDesigner.XRDesignDockManager
    Friend WithEvents ShomareShenasnamehDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RadifDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JahatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaAbarNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaAbar_Arz As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
