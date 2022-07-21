<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTamlak
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
        Me.lblSHsh = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtKasri = New TextualControl.TextualControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtM_Bana = New TextualControl.TextualControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtEzafat = New TextualControl.TextualControl
        Me.txtM_Zirbana = New TextualControl.TextualControl
        Me.txtTedad_Vahed = New TextualControl.TextualControl
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboNo_Melk = New System.Windows.Forms.ComboBox
        Me.txtTamirat = New TextualControl.TextualControl
        Me.txtNosazi = New TextualControl.TextualControl
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtSath_Shahr = New TextualControl.TextualControl
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtArzesh_Moamelati = New TextualControl.TextualControl
        Me.label = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkTSodore_ParvanehVilaie = New System.Windows.Forms.CheckBox
        Me.chkEntaghal = New System.Windows.Forms.CheckBox
        Me.chkPazireh = New System.Windows.Forms.CheckBox
        Me.chkTAzafe_tarakom = New System.Windows.Forms.CheckBox
        Me.chkTSodore_ParvanehAnboh = New System.Windows.Forms.CheckBox
        Me.chkTHagh_Nezareh = New System.Windows.Forms.CheckBox
        Me.chkTKasri_Zamin = New System.Windows.Forms.CheckBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.DB_NoSaziDataSet = New Amlak.DB_NoSaziDataSet
        Me.TAmlakBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Amlak.DB_NoSaziDataSetTableAdapters.TableAdapterManager
        Me.TAmlakTableAdapter = New Amlak.DB_NoSaziDataSetTableAdapters.TAmlakTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DB_NoSaziDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAmlakBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSHsh
        '
        Me.lblSHsh.Location = New System.Drawing.Point(182, 21)
        Me.lblSHsh.Name = "lblSHsh"
        Me.lblSHsh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSHsh.Size = New System.Drawing.Size(215, 13)
        Me.lblSHsh.TabIndex = 0
        Me.lblSHsh.Text = "شش"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(402, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "شماره شناسنامه:"
        '
        'txtKasri
        '
        Me.txtKasri.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKasri.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtKasri.DefaultColor = System.Drawing.Color.Empty
        Me.txtKasri.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtKasri.Location = New System.Drawing.Point(285, 52)
        Me.txtKasri.Name = "txtKasri"
        Me.txtKasri.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtKasri.Size = New System.Drawing.Size(100, 21)
        Me.txtKasri.TabIndex = 0
        Me.txtKasri.Text = "0"
        Me.txtKasri.Type = TextualControl.TextualControl.No.Numeric
        Me.txtKasri.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtKasri.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(437, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "کسری"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(430, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "نوع ملک"
        '
        'txtM_Bana
        '
        Me.txtM_Bana.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtM_Bana.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtM_Bana.DefaultColor = System.Drawing.Color.Empty
        Me.txtM_Bana.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtM_Bana.Location = New System.Drawing.Point(285, 106)
        Me.txtM_Bana.Name = "txtM_Bana"
        Me.txtM_Bana.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtM_Bana.Size = New System.Drawing.Size(100, 21)
        Me.txtM_Bana.TabIndex = 4
        Me.txtM_Bana.Text = "0"
        Me.txtM_Bana.Type = TextualControl.TextualControl.No.Numeric
        Me.txtM_Bana.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtM_Bana.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(418, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "مساحت بنا"
        '
        'txtEzafat
        '
        Me.txtEzafat.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEzafat.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtEzafat.DefaultColor = System.Drawing.Color.Empty
        Me.txtEzafat.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtEzafat.Location = New System.Drawing.Point(15, 52)
        Me.txtEzafat.Name = "txtEzafat"
        Me.txtEzafat.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtEzafat.Size = New System.Drawing.Size(100, 21)
        Me.txtEzafat.TabIndex = 1
        Me.txtEzafat.Text = "0"
        Me.txtEzafat.Type = TextualControl.TextualControl.No.Numeric
        Me.txtEzafat.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtEzafat.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'txtM_Zirbana
        '
        Me.txtM_Zirbana.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtM_Zirbana.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtM_Zirbana.DefaultColor = System.Drawing.Color.Empty
        Me.txtM_Zirbana.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtM_Zirbana.Location = New System.Drawing.Point(285, 79)
        Me.txtM_Zirbana.Name = "txtM_Zirbana"
        Me.txtM_Zirbana.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtM_Zirbana.Size = New System.Drawing.Size(100, 21)
        Me.txtM_Zirbana.TabIndex = 2
        Me.txtM_Zirbana.Text = "0"
        Me.txtM_Zirbana.Type = TextualControl.TextualControl.No.Numeric
        Me.txtM_Zirbana.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtM_Zirbana.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'txtTedad_Vahed
        '
        Me.txtTedad_Vahed.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTedad_Vahed.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTedad_Vahed.DefaultColor = System.Drawing.Color.Empty
        Me.txtTedad_Vahed.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtTedad_Vahed.Location = New System.Drawing.Point(15, 79)
        Me.txtTedad_Vahed.Name = "txtTedad_Vahed"
        Me.txtTedad_Vahed.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtTedad_Vahed.Size = New System.Drawing.Size(100, 21)
        Me.txtTedad_Vahed.TabIndex = 3
        Me.txtTedad_Vahed.Text = "0"
        Me.txtTedad_Vahed.Type = TextualControl.TextualControl.No.Numeric
        Me.txtTedad_Vahed.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtTedad_Vahed.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(170, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "اضافات"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(406, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "مساحت زیربنا"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(155, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "تعداد واحد"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboNo_Melk)
        Me.GroupBox1.Controls.Add(Me.txtTamirat)
        Me.GroupBox1.Controls.Add(Me.txtNosazi)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtSath_Shahr)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtArzesh_Moamelati)
        Me.GroupBox1.Controls.Add(Me.label)
        Me.GroupBox1.Controls.Add(Me.txtTedad_Vahed)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblSHsh)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtKasri)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtEzafat)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtM_Zirbana)
        Me.GroupBox1.Controls.Add(Me.txtM_Bana)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(506, 194)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cboNo_Melk
        '
        Me.cboNo_Melk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboNo_Melk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNo_Melk.FormattingEnabled = True
        Me.cboNo_Melk.Items.AddRange(New Object() {"مغازه", "خانه مسکونی"})
        Me.cboNo_Melk.Location = New System.Drawing.Point(285, 133)
        Me.cboNo_Melk.Name = "cboNo_Melk"
        Me.cboNo_Melk.Size = New System.Drawing.Size(100, 21)
        Me.cboNo_Melk.TabIndex = 6
        '
        'txtTamirat
        '
        Me.txtTamirat.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTamirat.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTamirat.DefaultColor = System.Drawing.Color.Empty
        Me.txtTamirat.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtTamirat.Location = New System.Drawing.Point(15, 160)
        Me.txtTamirat.Name = "txtTamirat"
        Me.txtTamirat.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtTamirat.Size = New System.Drawing.Size(100, 21)
        Me.txtTamirat.TabIndex = 9
        Me.txtTamirat.Type = TextualControl.TextualControl.No.Normal
        Me.txtTamirat.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtTamirat.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'txtNosazi
        '
        Me.txtNosazi.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNosazi.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtNosazi.DefaultColor = System.Drawing.Color.Empty
        Me.txtNosazi.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtNosazi.Location = New System.Drawing.Point(285, 160)
        Me.txtNosazi.Name = "txtNosazi"
        Me.txtNosazi.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtNosazi.Size = New System.Drawing.Size(100, 21)
        Me.txtNosazi.TabIndex = 8
        Me.txtNosazi.Type = TextualControl.TextualControl.No.Normal
        Me.txtNosazi.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtNosazi.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(162, 163)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "تعیمرات"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(433, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "نوسازی"
        '
        'txtSath_Shahr
        '
        Me.txtSath_Shahr.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSath_Shahr.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtSath_Shahr.DefaultColor = System.Drawing.Color.Empty
        Me.txtSath_Shahr.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtSath_Shahr.Location = New System.Drawing.Point(15, 133)
        Me.txtSath_Shahr.Name = "txtSath_Shahr"
        Me.txtSath_Shahr.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtSath_Shahr.Size = New System.Drawing.Size(100, 21)
        Me.txtSath_Shahr.TabIndex = 7
        Me.txtSath_Shahr.Type = TextualControl.TextualControl.No.Normal
        Me.txtSath_Shahr.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtSath_Shahr.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(150, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "سطح شهر"
        '
        'txtArzesh_Moamelati
        '
        Me.txtArzesh_Moamelati.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtArzesh_Moamelati.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtArzesh_Moamelati.DefaultColor = System.Drawing.Color.Empty
        Me.txtArzesh_Moamelati.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtArzesh_Moamelati.Location = New System.Drawing.Point(15, 106)
        Me.txtArzesh_Moamelati.Name = "txtArzesh_Moamelati"
        Me.txtArzesh_Moamelati.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtArzesh_Moamelati.Size = New System.Drawing.Size(100, 21)
        Me.txtArzesh_Moamelati.TabIndex = 5
        Me.txtArzesh_Moamelati.Text = "0"
        Me.txtArzesh_Moamelati.Type = TextualControl.TextualControl.No.Numeric
        Me.txtArzesh_Moamelati.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtArzesh_Moamelati.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(132, 109)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(77, 13)
        Me.label.TabIndex = 2
        Me.label.Text = "ارزش معاملاتی"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkTSodore_ParvanehVilaie)
        Me.GroupBox2.Controls.Add(Me.chkEntaghal)
        Me.GroupBox2.Controls.Add(Me.chkPazireh)
        Me.GroupBox2.Controls.Add(Me.chkTAzafe_tarakom)
        Me.GroupBox2.Controls.Add(Me.chkTSodore_ParvanehAnboh)
        Me.GroupBox2.Controls.Add(Me.chkTHagh_Nezareh)
        Me.GroupBox2.Controls.Add(Me.chkTKasri_Zamin)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 212)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(506, 87)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'chkTSodore_ParvanehVilaie
        '
        Me.chkTSodore_ParvanehVilaie.AutoSize = True
        Me.chkTSodore_ParvanehVilaie.Location = New System.Drawing.Point(181, 64)
        Me.chkTSodore_ParvanehVilaie.Name = "chkTSodore_ParvanehVilaie"
        Me.chkTSodore_ParvanehVilaie.Size = New System.Drawing.Size(111, 17)
        Me.chkTSodore_ParvanehVilaie.TabIndex = 6
        Me.chkTSodore_ParvanehVilaie.Text = "صدور پروانه ویلایی"
        Me.chkTSodore_ParvanehVilaie.UseVisualStyleBackColor = True
        '
        'chkEntaghal
        '
        Me.chkEntaghal.AutoSize = True
        Me.chkEntaghal.Location = New System.Drawing.Point(240, 41)
        Me.chkEntaghal.Name = "chkEntaghal"
        Me.chkEntaghal.Size = New System.Drawing.Size(52, 17)
        Me.chkEntaghal.TabIndex = 4
        Me.chkEntaghal.Text = "انتقال"
        Me.chkEntaghal.UseVisualStyleBackColor = True
        '
        'chkPazireh
        '
        Me.chkPazireh.AutoSize = True
        Me.chkPazireh.Location = New System.Drawing.Point(65, 18)
        Me.chkPazireh.Name = "chkPazireh"
        Me.chkPazireh.Size = New System.Drawing.Size(48, 17)
        Me.chkPazireh.TabIndex = 2
        Me.chkPazireh.Text = "پذیره"
        Me.chkPazireh.UseVisualStyleBackColor = True
        '
        'chkTAzafe_tarakom
        '
        Me.chkTAzafe_tarakom.AutoSize = True
        Me.chkTAzafe_tarakom.Location = New System.Drawing.Point(213, 18)
        Me.chkTAzafe_tarakom.Name = "chkTAzafe_tarakom"
        Me.chkTAzafe_tarakom.Size = New System.Drawing.Size(79, 17)
        Me.chkTAzafe_tarakom.TabIndex = 1
        Me.chkTAzafe_tarakom.Text = "اضافه تراکم"
        Me.chkTAzafe_tarakom.UseVisualStyleBackColor = True
        '
        'chkTSodore_ParvanehAnboh
        '
        Me.chkTSodore_ParvanehAnboh.AutoSize = True
        Me.chkTSodore_ParvanehAnboh.Location = New System.Drawing.Point(372, 66)
        Me.chkTSodore_ParvanehAnboh.Name = "chkTSodore_ParvanehAnboh"
        Me.chkTSodore_ParvanehAnboh.Size = New System.Drawing.Size(101, 17)
        Me.chkTSodore_ParvanehAnboh.TabIndex = 5
        Me.chkTSodore_ParvanehAnboh.Text = "صدور پروانه انبوه"
        Me.chkTSodore_ParvanehAnboh.UseVisualStyleBackColor = True
        '
        'chkTHagh_Nezareh
        '
        Me.chkTHagh_Nezareh.AutoSize = True
        Me.chkTHagh_Nezareh.Location = New System.Drawing.Point(397, 43)
        Me.chkTHagh_Nezareh.Name = "chkTHagh_Nezareh"
        Me.chkTHagh_Nezareh.Size = New System.Drawing.Size(76, 17)
        Me.chkTHagh_Nezareh.TabIndex = 3
        Me.chkTHagh_Nezareh.Text = "حق النظاره"
        Me.chkTHagh_Nezareh.UseVisualStyleBackColor = True
        '
        'chkTKasri_Zamin
        '
        Me.chkTKasri_Zamin.AutoSize = True
        Me.chkTKasri_Zamin.Location = New System.Drawing.Point(390, 20)
        Me.chkTKasri_Zamin.Name = "chkTKasri_Zamin"
        Me.chkTKasri_Zamin.Size = New System.Drawing.Size(83, 17)
        Me.chkTKasri_Zamin.TabIndex = 0
        Me.chkTKasri_Zamin.Text = "کسری زمین"
        Me.chkTKasri_Zamin.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(310, 305)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(91, 39)
        Me.btnOK.TabIndex = 8
        Me.btnOK.TabStop = False
        Me.btnOK.Text = "ذخیره"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(213, 305)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 39)
        Me.Button1.TabIndex = 7
        Me.Button1.TabStop = False
        Me.Button1.Text = "انصراف"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(116, 305)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(91, 39)
        Me.btnNext.TabIndex = 6
        Me.btnNext.TabStop = False
        Me.btnNext.Text = "مشخصات زمین"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'DB_NoSaziDataSet
        '
        Me.DB_NoSaziDataSet.DataSetName = "DB_NoSaziDataSet"
        Me.DB_NoSaziDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TAmlakBindingSource
        '
        Me.TAmlakBindingSource.DataSource = Me.DB_NoSaziDataSet
        Me.TAmlakBindingSource.Position = 0
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DFNsTableAdapter = Nothing
        Me.TableAdapterManager.TAmlakTableAdapter = Me.TAmlakTableAdapter
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
        'TAmlakTableAdapter
        '
        Me.TAmlakTableAdapter.ClearBeforeFill = True
        '
        'FrmTamlak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(554, 369)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTamlak"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مشخصات مورد محاسبه"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DB_NoSaziDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAmlakBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSHsh As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKasri As TextualControl.TextualControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtM_Bana As TextualControl.TextualControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEzafat As TextualControl.TextualControl
    Friend WithEvents txtM_Zirbana As TextualControl.TextualControl
    Friend WithEvents txtTedad_Vahed As TextualControl.TextualControl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtArzesh_Moamelati As TextualControl.TextualControl
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents cboNo_Melk As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkTSodore_ParvanehVilaie As System.Windows.Forms.CheckBox
    Friend WithEvents chkEntaghal As System.Windows.Forms.CheckBox
    Friend WithEvents chkTAzafe_tarakom As System.Windows.Forms.CheckBox
    Friend WithEvents chkTSodore_ParvanehAnboh As System.Windows.Forms.CheckBox
    Friend WithEvents chkTHagh_Nezareh As System.Windows.Forms.CheckBox
    Friend WithEvents chkTKasri_Zamin As System.Windows.Forms.CheckBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents txtNosazi As TextualControl.TextualControl
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSath_Shahr As TextualControl.TextualControl
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTamirat As TextualControl.TextualControl
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkPazireh As System.Windows.Forms.CheckBox
    Friend WithEvents DB_NoSaziDataSet As Amlak.DB_NoSaziDataSet
    Friend WithEvents TAmlakBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TAmlakTableAdapter As Amlak.DB_NoSaziDataSetTableAdapters.TAmlakTableAdapter
    Friend WithEvents TableAdapterManager As Amlak.DB_NoSaziDataSetTableAdapters.TableAdapterManager
End Class
