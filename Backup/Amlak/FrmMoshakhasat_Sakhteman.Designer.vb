<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMoshakhasat_Sakhteman
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTedad_Tabaghat = New TextualControl.TextualControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtMasahat_Zirbana = New TextualControl.TextualControl
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtMasahat_Bana = New TextualControl.TextualControl
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtHararat = New TextualControl.TextualControl
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtAsansor = New TextualControl.TextualControl
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtKhonak_Konandeh = New TextualControl.TextualControl
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtTahvieh = New TextualControl.TextualControl
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtMasahat_ZirZamin = New TextualControl.TextualControl
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.lblSHsh = New System.Windows.Forms.Label
        Me.txtNo_Divar = New TextualControl.TextualControl
        Me.txtNo_Saghf = New TextualControl.TextualControl
        Me.txtCode_No_Sakhteman = New TextualControl.TextualControl
        Me.label = New System.Windows.Forms.Label
        Me.txtNo_Nama = New TextualControl.TextualControl
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtNo_Nama_Code = New TextualControl.TextualControl
        Me.Label15 = New System.Windows.Forms.Label
        Me.Select_Tbl_Moshakhasat_SakhtemanDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Select_Tbl_Moshakhasat_SakhtemanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_NoSaziDataSet = New Amlak.DB_NoSaziDataSet
        Me.Select_Tbl_Moshakhasat_SakhtemanTableAdapter = New Amlak.DB_NoSaziDataSetTableAdapters.Select_Tbl_Moshakhasat_SakhtemanTableAdapter
        Me.TableAdapterManager = New Amlak.DB_NoSaziDataSetTableAdapters.TableAdapterManager
        Me.GroupBox1.SuspendLayout()
        CType(Me.Select_Tbl_Moshakhasat_SakhtemanDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Select_Tbl_Moshakhasat_SakhtemanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_NoSaziDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(477, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "شماره شناسنامه زمین"
        '
        'txtTedad_Tabaghat
        '
        Me.txtTedad_Tabaghat.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTedad_Tabaghat.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTedad_Tabaghat.DefaultColor = System.Drawing.Color.Empty
        Me.txtTedad_Tabaghat.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtTedad_Tabaghat.Location = New System.Drawing.Point(422, 35)
        Me.txtTedad_Tabaghat.Name = "txtTedad_Tabaghat"
        Me.txtTedad_Tabaghat.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtTedad_Tabaghat.Size = New System.Drawing.Size(100, 21)
        Me.txtTedad_Tabaghat.TabIndex = 0
        Me.txtTedad_Tabaghat.Text = "0"
        Me.txtTedad_Tabaghat.Type = TextualControl.TextualControl.No.Numeric
        Me.txtTedad_Tabaghat.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtTedad_Tabaghat.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(528, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "تعداد طبقات"
        '
        'txtMasahat_Zirbana
        '
        Me.txtMasahat_Zirbana.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMasahat_Zirbana.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtMasahat_Zirbana.DefaultColor = System.Drawing.Color.Empty
        Me.txtMasahat_Zirbana.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtMasahat_Zirbana.Location = New System.Drawing.Point(220, 35)
        Me.txtMasahat_Zirbana.Name = "txtMasahat_Zirbana"
        Me.txtMasahat_Zirbana.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtMasahat_Zirbana.Size = New System.Drawing.Size(100, 21)
        Me.txtMasahat_Zirbana.TabIndex = 1
        Me.txtMasahat_Zirbana.Text = "0"
        Me.txtMasahat_Zirbana.Type = TextualControl.TextualControl.No.Numeric
        Me.txtMasahat_Zirbana.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtMasahat_Zirbana.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(326, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "مساحت زیربنا"
        '
        'txtMasahat_Bana
        '
        Me.txtMasahat_Bana.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMasahat_Bana.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtMasahat_Bana.DefaultColor = System.Drawing.Color.Empty
        Me.txtMasahat_Bana.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtMasahat_Bana.Location = New System.Drawing.Point(38, 35)
        Me.txtMasahat_Bana.Name = "txtMasahat_Bana"
        Me.txtMasahat_Bana.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtMasahat_Bana.Size = New System.Drawing.Size(100, 21)
        Me.txtMasahat_Bana.TabIndex = 2
        Me.txtMasahat_Bana.Text = "0"
        Me.txtMasahat_Bana.Type = TextualControl.TextualControl.No.Numeric
        Me.txtMasahat_Bana.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtMasahat_Bana.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(144, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "مساحت بنا"
        '
        'txtHararat
        '
        Me.txtHararat.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHararat.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtHararat.DefaultColor = System.Drawing.Color.Empty
        Me.txtHararat.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtHararat.Location = New System.Drawing.Point(398, 38)
        Me.txtHararat.Name = "txtHararat"
        Me.txtHararat.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtHararat.Size = New System.Drawing.Size(100, 21)
        Me.txtHararat.TabIndex = 0
        Me.txtHararat.Text = "0"
        Me.txtHararat.Type = TextualControl.TextualControl.No.Numeric
        Me.txtHararat.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtHararat.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(398, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "حرارت مرکزی شوفاژ"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(545, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "نوع دیوار"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAsansor)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtKhonak_Konandeh)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtTahvieh)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtHararat)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(549, 78)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مساحت تأسیسات"
        '
        'txtAsansor
        '
        Me.txtAsansor.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAsansor.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtAsansor.DefaultColor = System.Drawing.Color.Empty
        Me.txtAsansor.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtAsansor.Location = New System.Drawing.Point(8, 38)
        Me.txtAsansor.Name = "txtAsansor"
        Me.txtAsansor.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtAsansor.Size = New System.Drawing.Size(100, 21)
        Me.txtAsansor.TabIndex = 3
        Me.txtAsansor.Text = "0"
        Me.txtAsansor.Type = TextualControl.TextualControl.No.Numeric
        Me.txtAsansor.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtAsansor.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(34, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "آسانسور"
        '
        'txtKhonak_Konandeh
        '
        Me.txtKhonak_Konandeh.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKhonak_Konandeh.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtKhonak_Konandeh.DefaultColor = System.Drawing.Color.Empty
        Me.txtKhonak_Konandeh.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtKhonak_Konandeh.Location = New System.Drawing.Point(138, 38)
        Me.txtKhonak_Konandeh.Name = "txtKhonak_Konandeh"
        Me.txtKhonak_Konandeh.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtKhonak_Konandeh.Size = New System.Drawing.Size(100, 21)
        Me.txtKhonak_Konandeh.TabIndex = 2
        Me.txtKhonak_Konandeh.Text = "0"
        Me.txtKhonak_Konandeh.Type = TextualControl.TextualControl.No.Numeric
        Me.txtKhonak_Konandeh.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtKhonak_Konandeh.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(143, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "خنک کننده مرکزی"
        '
        'txtTahvieh
        '
        Me.txtTahvieh.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTahvieh.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTahvieh.DefaultColor = System.Drawing.Color.Empty
        Me.txtTahvieh.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtTahvieh.Location = New System.Drawing.Point(263, 38)
        Me.txtTahvieh.Name = "txtTahvieh"
        Me.txtTahvieh.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtTahvieh.Size = New System.Drawing.Size(100, 21)
        Me.txtTahvieh.TabIndex = 1
        Me.txtTahvieh.Text = "0"
        Me.txtTahvieh.Type = TextualControl.TextualControl.No.Numeric
        Me.txtTahvieh.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtTahvieh.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(282, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "تهویه مطبوع"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(342, 149)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "نوع سقف"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(301, 370)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(332, 36)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "تعریف نوع دیوار و نوع سقف موجود نیست و  کد نوع ساختمان و نوع نمای ساختمان و کد نو" & _
            "ع نمای ساختمان چگونه پر می شود؟"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMasahat_ZirZamin
        '
        Me.txtMasahat_ZirZamin.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMasahat_ZirZamin.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtMasahat_ZirZamin.DefaultColor = System.Drawing.Color.Empty
        Me.txtMasahat_ZirZamin.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtMasahat_ZirZamin.Location = New System.Drawing.Point(42, 146)
        Me.txtMasahat_ZirZamin.Name = "txtMasahat_ZirZamin"
        Me.txtMasahat_ZirZamin.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtMasahat_ZirZamin.Size = New System.Drawing.Size(100, 21)
        Me.txtMasahat_ZirZamin.TabIndex = 6
        Me.txtMasahat_ZirZamin.Text = "0"
        Me.txtMasahat_ZirZamin.Type = TextualControl.TextualControl.No.Numeric
        Me.txtMasahat_ZirZamin.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtMasahat_ZirZamin.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(148, 149)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "مساحت زیرزمین"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(109, 370)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(91, 39)
        Me.btnOK.TabIndex = 19
        Me.btnOK.TabStop = False
        Me.btnOK.Text = "ذخیره"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(206, 370)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 39)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "انصراف"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(12, 370)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(91, 39)
        Me.btnNext.TabIndex = 17
        Me.btnNext.TabStop = False
        Me.btnNext.Text = "اشتراک و مستحدثات"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblSHsh
        '
        Me.lblSHsh.AutoSize = True
        Me.lblSHsh.Location = New System.Drawing.Point(358, 11)
        Me.lblSHsh.Name = "lblSHsh"
        Me.lblSHsh.Size = New System.Drawing.Size(113, 13)
        Me.lblSHsh.TabIndex = 7
        Me.lblSHsh.Text = "شماره شناسنامه زمین"
        '
        'txtNo_Divar
        '
        Me.txtNo_Divar.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNo_Divar.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtNo_Divar.DefaultColor = System.Drawing.Color.Empty
        Me.txtNo_Divar.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtNo_Divar.Location = New System.Drawing.Point(439, 146)
        Me.txtNo_Divar.Name = "txtNo_Divar"
        Me.txtNo_Divar.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtNo_Divar.Size = New System.Drawing.Size(100, 21)
        Me.txtNo_Divar.TabIndex = 4
        Me.txtNo_Divar.Type = TextualControl.TextualControl.No.Normal
        Me.txtNo_Divar.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtNo_Divar.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'txtNo_Saghf
        '
        Me.txtNo_Saghf.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNo_Saghf.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtNo_Saghf.DefaultColor = System.Drawing.Color.Empty
        Me.txtNo_Saghf.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtNo_Saghf.Location = New System.Drawing.Point(236, 146)
        Me.txtNo_Saghf.Name = "txtNo_Saghf"
        Me.txtNo_Saghf.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtNo_Saghf.Size = New System.Drawing.Size(100, 21)
        Me.txtNo_Saghf.TabIndex = 5
        Me.txtNo_Saghf.Type = TextualControl.TextualControl.No.Normal
        Me.txtNo_Saghf.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtNo_Saghf.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'txtCode_No_Sakhteman
        '
        Me.txtCode_No_Sakhteman.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCode_No_Sakhteman.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtCode_No_Sakhteman.DefaultColor = System.Drawing.Color.Empty
        Me.txtCode_No_Sakhteman.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtCode_No_Sakhteman.Location = New System.Drawing.Point(439, 173)
        Me.txtCode_No_Sakhteman.Name = "txtCode_No_Sakhteman"
        Me.txtCode_No_Sakhteman.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtCode_No_Sakhteman.Size = New System.Drawing.Size(100, 21)
        Me.txtCode_No_Sakhteman.TabIndex = 7
        Me.txtCode_No_Sakhteman.Text = "0"
        Me.txtCode_No_Sakhteman.Type = TextualControl.TextualControl.No.Numeric
        Me.txtCode_No_Sakhteman.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtCode_No_Sakhteman.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(545, 176)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(81, 13)
        Me.label.TabIndex = 12
        Me.label.Text = "کد نوع ساختمان"
        '
        'txtNo_Nama
        '
        Me.txtNo_Nama.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNo_Nama.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtNo_Nama.DefaultColor = System.Drawing.Color.Empty
        Me.txtNo_Nama.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtNo_Nama.Location = New System.Drawing.Point(236, 173)
        Me.txtNo_Nama.Name = "txtNo_Nama"
        Me.txtNo_Nama.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtNo_Nama.Size = New System.Drawing.Size(100, 21)
        Me.txtNo_Nama.TabIndex = 8
        Me.txtNo_Nama.Type = TextualControl.TextualControl.No.Normal
        Me.txtNo_Nama.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtNo_Nama.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(342, 176)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "نوع نمای ساختمان"
        '
        'txtNo_Nama_Code
        '
        Me.txtNo_Nama_Code.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNo_Nama_Code.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtNo_Nama_Code.DefaultColor = System.Drawing.Color.Empty
        Me.txtNo_Nama_Code.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtNo_Nama_Code.Location = New System.Drawing.Point(42, 173)
        Me.txtNo_Nama_Code.Name = "txtNo_Nama_Code"
        Me.txtNo_Nama_Code.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtNo_Nama_Code.Size = New System.Drawing.Size(100, 21)
        Me.txtNo_Nama_Code.TabIndex = 9
        Me.txtNo_Nama_Code.Text = "0"
        Me.txtNo_Nama_Code.Type = TextualControl.TextualControl.No.Numeric
        Me.txtNo_Nama_Code.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtNo_Nama_Code.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(148, 176)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "کد نوع نما"
        '
        'Select_Tbl_Moshakhasat_SakhtemanDataGridView
        '
        Me.Select_Tbl_Moshakhasat_SakhtemanDataGridView.AllowUserToAddRows = False
        Me.Select_Tbl_Moshakhasat_SakhtemanDataGridView.AllowUserToDeleteRows = False
        Me.Select_Tbl_Moshakhasat_SakhtemanDataGridView.AutoGenerateColumns = False
        Me.Select_Tbl_Moshakhasat_SakhtemanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Select_Tbl_Moshakhasat_SakhtemanDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.Select_Tbl_Moshakhasat_SakhtemanDataGridView.DataSource = Me.Select_Tbl_Moshakhasat_SakhtemanBindingSource
        Me.Select_Tbl_Moshakhasat_SakhtemanDataGridView.Location = New System.Drawing.Point(36, 220)
        Me.Select_Tbl_Moshakhasat_SakhtemanDataGridView.Name = "Select_Tbl_Moshakhasat_SakhtemanDataGridView"
        Me.Select_Tbl_Moshakhasat_SakhtemanDataGridView.ReadOnly = True
        Me.Select_Tbl_Moshakhasat_SakhtemanDataGridView.Size = New System.Drawing.Size(587, 144)
        Me.Select_Tbl_Moshakhasat_SakhtemanDataGridView.TabIndex = 28
        Me.Select_Tbl_Moshakhasat_SakhtemanDataGridView.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Shomare_Shenasnameh"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Shomare_Shenasnameh"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Tedad_Tabaghat"
        Me.DataGridViewTextBoxColumn2.HeaderText = "تعداد طبقات"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Masahat_Zirbana"
        Me.DataGridViewTextBoxColumn3.HeaderText = "مساحت زیربنا"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Masahat_Bana"
        Me.DataGridViewTextBoxColumn4.HeaderText = "مساحت بنا"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Sharh_No_Divar"
        Me.DataGridViewTextBoxColumn9.HeaderText = "نوع دیوار"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Sharh_No_Saghf"
        Me.DataGridViewTextBoxColumn10.HeaderText = "نوع سقف"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'Select_Tbl_Moshakhasat_SakhtemanBindingSource
        '
        Me.Select_Tbl_Moshakhasat_SakhtemanBindingSource.DataMember = "Select_Tbl_Moshakhasat_Sakhteman"
        Me.Select_Tbl_Moshakhasat_SakhtemanBindingSource.DataSource = Me.DB_NoSaziDataSet
        '
        'DB_NoSaziDataSet
        '
        Me.DB_NoSaziDataSet.DataSetName = "DB_NoSaziDataSet"
        Me.DB_NoSaziDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Select_Tbl_Moshakhasat_SakhtemanTableAdapter
        '
        Me.Select_Tbl_Moshakhasat_SakhtemanTableAdapter.ClearBeforeFill = True
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
        'FrmMoshakhasat_Sakhteman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(648, 421)
        Me.Controls.Add(Me.Select_Tbl_Moshakhasat_SakhtemanDataGridView)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNo_Nama)
        Me.Controls.Add(Me.txtNo_Saghf)
        Me.Controls.Add(Me.txtCode_No_Sakhteman)
        Me.Controls.Add(Me.txtNo_Divar)
        Me.Controls.Add(Me.txtNo_Nama_Code)
        Me.Controls.Add(Me.txtMasahat_ZirZamin)
        Me.Controls.Add(Me.txtTedad_Tabaghat)
        Me.Controls.Add(Me.txtMasahat_Bana)
        Me.Controls.Add(Me.txtMasahat_Zirbana)
        Me.Controls.Add(Me.lblSHsh)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMoshakhasat_Sakhteman"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مشخصات ساختمان"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Select_Tbl_Moshakhasat_SakhtemanDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Select_Tbl_Moshakhasat_SakhtemanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_NoSaziDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTedad_Tabaghat As TextualControl.TextualControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMasahat_Zirbana As TextualControl.TextualControl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMasahat_Bana As TextualControl.TextualControl
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtHararat As TextualControl.TextualControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAsansor As TextualControl.TextualControl
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtKhonak_Konandeh As TextualControl.TextualControl
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTahvieh As TextualControl.TextualControl
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RadifDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MasahatJebheh2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Masahatjebheh1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZaviehDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaAbarradifDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaAbarArzDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaAbarNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolBarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolZelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JahatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShomareShenasnamehDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtMasahat_ZirZamin As TextualControl.TextualControl
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents DB_NoSaziDataSet As Amlak.DB_NoSaziDataSet
    Friend WithEvents lblSHsh As System.Windows.Forms.Label
    Friend WithEvents txtNo_Divar As TextualControl.TextualControl
    Friend WithEvents txtNo_Saghf As TextualControl.TextualControl
    Friend WithEvents txtCode_No_Sakhteman As TextualControl.TextualControl
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents txtNo_Nama As TextualControl.TextualControl
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNo_Nama_Code As TextualControl.TextualControl
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Select_Tbl_Moshakhasat_SakhtemanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Select_Tbl_Moshakhasat_SakhtemanTableAdapter As Amlak.DB_NoSaziDataSetTableAdapters.Select_Tbl_Moshakhasat_SakhtemanTableAdapter
    Friend WithEvents TableAdapterManager As Amlak.DB_NoSaziDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Select_Tbl_Moshakhasat_SakhtemanDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
