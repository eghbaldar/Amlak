<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMoshakhasat_Malekin
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
        Me.SelectDFNsBindingSource___No_Malekiyat = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_NoSaziDataSet = New Amlak.DB_NoSaziDataSet
        Me.txtTarikh_Tamallok = New TextualControl.TextualControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SelectDFNsBindingSource__Vaziyat_Tamallok = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.SelectDFNsBindingSource__Code_NO_Malekiyat = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtTel = New TextualControl.TextualControl
        Me.txtAddress = New TextualControl.TextualControl
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtMahal_Sodour = New TextualControl.TextualControl
        Me.txtCodeMelli = New TextualControl.TextualControl
        Me.txtSHsh = New TextualControl.TextualControl
        Me.txtName_Pedar = New TextualControl.TextualControl
        Me.txtLName = New TextualControl.TextualControl
        Me.txtFName = New TextualControl.TextualControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblRadif = New System.Windows.Forms.Label
        Me.txtNo_Malekiyat_Tedad = New TextualControl.TextualControl
        Me.Label15 = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.Select_DFNsTableAdapter = New Amlak.DB_NoSaziDataSetTableAdapters.Select_DFNsTableAdapter
        Me.lblSHsh = New System.Windows.Forms.Label
        Me.TableAdapterManager = New Amlak.DB_NoSaziDataSetTableAdapters.TableAdapterManager
        Me.Select_Tbl_Moshakhasat_MalekinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Select_Tbl_Moshakhasat_MalekinTableAdapter = New Amlak.DB_NoSaziDataSetTableAdapters.Select_Tbl_Moshakhasat_MalekinTableAdapter
        Me.Select_Tbl_Moshakhasat_MalekinDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cboCodeNoMalekiyat = New System.Windows.Forms.ComboBox
        Me.cboVazeyatTamallok = New System.Windows.Forms.ComboBox
        Me.cboNoMalekiyatCode = New System.Windows.Forms.ComboBox
        CType(Me.SelectDFNsBindingSource___No_Malekiyat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_NoSaziDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectDFNsBindingSource__Vaziyat_Tamallok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectDFNsBindingSource__Code_NO_Malekiyat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Select_Tbl_Moshakhasat_MalekinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Select_Tbl_Moshakhasat_MalekinDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(604, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "شماره شناسنامه زمین"
        '
        'SelectDFNsBindingSource___No_Malekiyat
        '
        Me.SelectDFNsBindingSource___No_Malekiyat.DataMember = "Select_DFNs"
        Me.SelectDFNsBindingSource___No_Malekiyat.DataSource = Me.DB_NoSaziDataSet
        Me.SelectDFNsBindingSource___No_Malekiyat.Filter = "code >= 250 and code <=252"
        '
        'DB_NoSaziDataSet
        '
        Me.DB_NoSaziDataSet.DataSetName = "DB_NoSaziDataSet"
        Me.DB_NoSaziDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtTarikh_Tamallok
        '
        Me.txtTarikh_Tamallok.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTarikh_Tamallok.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTarikh_Tamallok.DefaultColor = System.Drawing.Color.Empty
        Me.txtTarikh_Tamallok.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtTarikh_Tamallok.Location = New System.Drawing.Point(498, 45)
        Me.txtTarikh_Tamallok.Name = "txtTarikh_Tamallok"
        Me.txtTarikh_Tamallok.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtTarikh_Tamallok.Size = New System.Drawing.Size(100, 21)
        Me.txtTarikh_Tamallok.TabIndex = 0
        Me.txtTarikh_Tamallok.Type = TextualControl.TextualControl.No.Normal
        Me.txtTarikh_Tamallok.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtTarikh_Tamallok.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(604, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "تاریخ تملک"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(370, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "نوع مالیکت طبق سند"
        '
        'SelectDFNsBindingSource__Vaziyat_Tamallok
        '
        Me.SelectDFNsBindingSource__Vaziyat_Tamallok.DataMember = "Select_DFNs"
        Me.SelectDFNsBindingSource__Vaziyat_Tamallok.DataSource = Me.DB_NoSaziDataSet
        Me.SelectDFNsBindingSource__Vaziyat_Tamallok.Filter = "code >= 253 and code <=255"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(604, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "وضعیت تملک"
        '
        'SelectDFNsBindingSource__Code_NO_Malekiyat
        '
        Me.SelectDFNsBindingSource__Code_NO_Malekiyat.DataMember = "Select_DFNs"
        Me.SelectDFNsBindingSource__Code_NO_Malekiyat.DataSource = Me.DB_NoSaziDataSet
        Me.SelectDFNsBindingSource__Code_NO_Malekiyat.Filter = "code >= 0 and code <=14"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(370, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "نوع مالکیت"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtTel)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtMahal_Sodour)
        Me.GroupBox1.Controls.Add(Me.txtCodeMelli)
        Me.GroupBox1.Controls.Add(Me.txtSHsh)
        Me.GroupBox1.Controls.Add(Me.txtName_Pedar)
        Me.GroupBox1.Controls.Add(Me.txtLName)
        Me.GroupBox1.Controls.Add(Me.txtFName)
        Me.GroupBox1.Location = New System.Drawing.Point(127, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(587, 160)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مشخصات مالک یا مالکین"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(295, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "نام خانوادگی"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(295, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "محل صدور"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(531, 131)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "تلفن"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(295, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "شماره شناسنامه"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(530, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "نشانی"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(529, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "کد ملی"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(529, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "نام پدر"
        '
        'txtTel
        '
        Me.txtTel.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTel.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTel.DefaultColor = System.Drawing.Color.Empty
        Me.txtTel.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtTel.Location = New System.Drawing.Point(426, 128)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtTel.Size = New System.Drawing.Size(100, 21)
        Me.txtTel.TabIndex = 7
        Me.txtTel.Type = TextualControl.TextualControl.No.Normal
        Me.txtTel.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtTel.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'txtAddress
        '
        Me.txtAddress.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtAddress.DefaultColor = System.Drawing.Color.Empty
        Me.txtAddress.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtAddress.Location = New System.Drawing.Point(38, 101)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtAddress.Size = New System.Drawing.Size(488, 21)
        Me.txtAddress.TabIndex = 6
        Me.txtAddress.Type = TextualControl.TextualControl.No.Normal
        Me.txtAddress.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtAddress.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(529, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "نام"
        '
        'txtMahal_Sodour
        '
        Me.txtMahal_Sodour.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMahal_Sodour.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtMahal_Sodour.DefaultColor = System.Drawing.Color.Empty
        Me.txtMahal_Sodour.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtMahal_Sodour.Location = New System.Drawing.Point(189, 74)
        Me.txtMahal_Sodour.Name = "txtMahal_Sodour"
        Me.txtMahal_Sodour.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtMahal_Sodour.Size = New System.Drawing.Size(100, 21)
        Me.txtMahal_Sodour.TabIndex = 5
        Me.txtMahal_Sodour.Type = TextualControl.TextualControl.No.Normal
        Me.txtMahal_Sodour.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtMahal_Sodour.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'txtCodeMelli
        '
        Me.txtCodeMelli.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodeMelli.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtCodeMelli.DefaultColor = System.Drawing.Color.Empty
        Me.txtCodeMelli.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtCodeMelli.Location = New System.Drawing.Point(426, 74)
        Me.txtCodeMelli.Name = "txtCodeMelli"
        Me.txtCodeMelli.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtCodeMelli.Size = New System.Drawing.Size(100, 21)
        Me.txtCodeMelli.TabIndex = 4
        Me.txtCodeMelli.Type = TextualControl.TextualControl.No.Normal
        Me.txtCodeMelli.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtCodeMelli.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'txtSHsh
        '
        Me.txtSHsh.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSHsh.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtSHsh.DefaultColor = System.Drawing.Color.Empty
        Me.txtSHsh.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtSHsh.Location = New System.Drawing.Point(189, 47)
        Me.txtSHsh.Name = "txtSHsh"
        Me.txtSHsh.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtSHsh.Size = New System.Drawing.Size(100, 21)
        Me.txtSHsh.TabIndex = 3
        Me.txtSHsh.Text = "0"
        Me.txtSHsh.Type = TextualControl.TextualControl.No.Normal
        Me.txtSHsh.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtSHsh.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'txtName_Pedar
        '
        Me.txtName_Pedar.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName_Pedar.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtName_Pedar.DefaultColor = System.Drawing.Color.Empty
        Me.txtName_Pedar.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtName_Pedar.Location = New System.Drawing.Point(426, 47)
        Me.txtName_Pedar.Name = "txtName_Pedar"
        Me.txtName_Pedar.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtName_Pedar.Size = New System.Drawing.Size(100, 21)
        Me.txtName_Pedar.TabIndex = 2
        Me.txtName_Pedar.Type = TextualControl.TextualControl.No.Normal
        Me.txtName_Pedar.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtName_Pedar.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'txtLName
        '
        Me.txtLName.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLName.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtLName.DefaultColor = System.Drawing.Color.Empty
        Me.txtLName.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtLName.Location = New System.Drawing.Point(97, 20)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtLName.Size = New System.Drawing.Size(192, 21)
        Me.txtLName.TabIndex = 1
        Me.txtLName.Type = TextualControl.TextualControl.No.Normal
        Me.txtLName.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtLName.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'txtFName
        '
        Me.txtFName.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFName.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtFName.DefaultColor = System.Drawing.Color.Empty
        Me.txtFName.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtFName.Location = New System.Drawing.Point(426, 20)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtFName.Size = New System.Drawing.Size(100, 21)
        Me.txtFName.TabIndex = 0
        Me.txtFName.Type = TextualControl.TextualControl.No.Normal
        Me.txtFName.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtFName.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(303, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "ردیف"
        Me.Label4.Visible = False
        '
        'lblRadif
        '
        Me.lblRadif.AutoSize = True
        Me.lblRadif.Location = New System.Drawing.Point(252, 20)
        Me.lblRadif.Name = "lblRadif"
        Me.lblRadif.Size = New System.Drawing.Size(0, 13)
        Me.lblRadif.TabIndex = 10
        Me.lblRadif.Visible = False
        '
        'txtNo_Malekiyat_Tedad
        '
        Me.txtNo_Malekiyat_Tedad.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNo_Malekiyat_Tedad.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtNo_Malekiyat_Tedad.DefaultColor = System.Drawing.Color.Empty
        Me.txtNo_Malekiyat_Tedad.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtNo_Malekiyat_Tedad.Location = New System.Drawing.Point(84, 45)
        Me.txtNo_Malekiyat_Tedad.Name = "txtNo_Malekiyat_Tedad"
        Me.txtNo_Malekiyat_Tedad.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtNo_Malekiyat_Tedad.Size = New System.Drawing.Size(100, 21)
        Me.txtNo_Malekiyat_Tedad.TabIndex = 2
        Me.txtNo_Malekiyat_Tedad.Text = "0"
        Me.txtNo_Malekiyat_Tedad.Type = TextualControl.TextualControl.No.Normal
        Me.txtNo_Malekiyat_Tedad.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtNo_Malekiyat_Tedad.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(185, 49)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 13)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "==>  تعداد"
        '
        'btnOK
        '
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.Location = New System.Drawing.Point(27, 164)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(91, 39)
        Me.btnOK.TabIndex = 16
        Me.btnOK.TabStop = False
        Me.btnOK.Text = "ذخیره"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(27, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 39)
        Me.Button1.TabIndex = 15
        Me.Button1.TabStop = False
        Me.Button1.Text = "انصراف"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNext.Location = New System.Drawing.Point(27, 119)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(91, 39)
        Me.btnNext.TabIndex = 14
        Me.btnNext.TabStop = False
        Me.btnNext.Text = "ماهیت فیزیکی"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Select_DFNsTableAdapter
        '
        Me.Select_DFNsTableAdapter.ClearBeforeFill = True
        '
        'lblSHsh
        '
        Me.lblSHsh.AutoSize = True
        Me.lblSHsh.Location = New System.Drawing.Point(488, 21)
        Me.lblSHsh.Name = "lblSHsh"
        Me.lblSHsh.Size = New System.Drawing.Size(113, 13)
        Me.lblSHsh.TabIndex = 3
        Me.lblSHsh.Text = "شماره شناسنامه زمین"
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
        'Select_Tbl_Moshakhasat_MalekinBindingSource
        '
        Me.Select_Tbl_Moshakhasat_MalekinBindingSource.DataMember = "Select_Tbl_Moshakhasat_Malekin"
        Me.Select_Tbl_Moshakhasat_MalekinBindingSource.DataSource = Me.DB_NoSaziDataSet
        '
        'Select_Tbl_Moshakhasat_MalekinTableAdapter
        '
        Me.Select_Tbl_Moshakhasat_MalekinTableAdapter.ClearBeforeFill = True
        '
        'Select_Tbl_Moshakhasat_MalekinDataGridView
        '
        Me.Select_Tbl_Moshakhasat_MalekinDataGridView.AllowUserToAddRows = False
        Me.Select_Tbl_Moshakhasat_MalekinDataGridView.AllowUserToDeleteRows = False
        Me.Select_Tbl_Moshakhasat_MalekinDataGridView.AutoGenerateColumns = False
        Me.Select_Tbl_Moshakhasat_MalekinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Select_Tbl_Moshakhasat_MalekinDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.Select_Tbl_Moshakhasat_MalekinDataGridView.DataSource = Me.Select_Tbl_Moshakhasat_MalekinBindingSource
        Me.Select_Tbl_Moshakhasat_MalekinDataGridView.Location = New System.Drawing.Point(27, 270)
        Me.Select_Tbl_Moshakhasat_MalekinDataGridView.Name = "Select_Tbl_Moshakhasat_MalekinDataGridView"
        Me.Select_Tbl_Moshakhasat_MalekinDataGridView.ReadOnly = True
        Me.Select_Tbl_Moshakhasat_MalekinDataGridView.Size = New System.Drawing.Size(687, 150)
        Me.Select_Tbl_Moshakhasat_MalekinDataGridView.TabIndex = 19
        Me.Select_Tbl_Moshakhasat_MalekinDataGridView.TabStop = False
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Tarikh_Tamallok"
        Me.DataGridViewTextBoxColumn2.HeaderText = "تاریخ تملک"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "No_Malekiyat_Code"
        Me.DataGridViewTextBoxColumn3.HeaderText = "No_Malekiyat_Code"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "No_Malekiyat_Tedad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "No_Malekiyat_Tedad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Vaziyat_Tamallok"
        Me.DataGridViewTextBoxColumn5.HeaderText = "وضعیت تملک"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Code_No_Malekiat"
        Me.DataGridViewTextBoxColumn6.HeaderText = "نوع مالکیت"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 200
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Malek_Name"
        Me.DataGridViewTextBoxColumn7.HeaderText = "نام"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 75
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Malek_Family"
        Me.DataGridViewTextBoxColumn8.HeaderText = "نام خانوادگی"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Malek_Name_Pedar"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Malek_Name_Pedar"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Malek_SHsh"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Malek_SHsh"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Malek_CodeMelli"
        Me.DataGridViewTextBoxColumn11.HeaderText = "کد ملی"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Malek_MahalSodur"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Malek_MahalSodur"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Malek_Address"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Malek_Address"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Malek_Tel"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Malek_Tel"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'cboCodeNoMalekiyat
        '
        Me.cboCodeNoMalekiyat.DataSource = Me.SelectDFNsBindingSource__Code_NO_Malekiyat
        Me.cboCodeNoMalekiyat.DisplayMember = "name"
        Me.cboCodeNoMalekiyat.FormattingEnabled = True
        Me.cboCodeNoMalekiyat.Location = New System.Drawing.Point(84, 75)
        Me.cboCodeNoMalekiyat.Name = "cboCodeNoMalekiyat"
        Me.cboCodeNoMalekiyat.Size = New System.Drawing.Size(280, 21)
        Me.cboCodeNoMalekiyat.TabIndex = 4
        Me.cboCodeNoMalekiyat.ValueMember = "code"
        '
        'cboVazeyatTamallok
        '
        Me.cboVazeyatTamallok.DataSource = Me.SelectDFNsBindingSource__Vaziyat_Tamallok
        Me.cboVazeyatTamallok.DisplayMember = "name"
        Me.cboVazeyatTamallok.FormattingEnabled = True
        Me.cboVazeyatTamallok.Location = New System.Drawing.Point(433, 72)
        Me.cboVazeyatTamallok.Name = "cboVazeyatTamallok"
        Me.cboVazeyatTamallok.Size = New System.Drawing.Size(165, 21)
        Me.cboVazeyatTamallok.TabIndex = 3
        Me.cboVazeyatTamallok.ValueMember = "code"
        '
        'cboNoMalekiyatCode
        '
        Me.cboNoMalekiyatCode.FormattingEnabled = True
        Me.cboNoMalekiyatCode.Location = New System.Drawing.Point(244, 45)
        Me.cboNoMalekiyatCode.Name = "cboNoMalekiyatCode"
        Me.cboNoMalekiyatCode.Size = New System.Drawing.Size(121, 21)
        Me.cboNoMalekiyatCode.TabIndex = 1
        '
        'FrmMoshakhasat_Malekin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(734, 433)
        Me.Controls.Add(Me.cboNoMalekiyatCode)
        Me.Controls.Add(Me.cboVazeyatTamallok)
        Me.Controls.Add(Me.cboCodeNoMalekiyat)
        Me.Controls.Add(Me.Select_Tbl_Moshakhasat_MalekinDataGridView)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.txtNo_Malekiyat_Tedad)
        Me.Controls.Add(Me.lblRadif)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTarikh_Tamallok)
        Me.Controls.Add(Me.lblSHsh)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMoshakhasat_Malekin"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "مشخصات مالکین"
        CType(Me.SelectDFNsBindingSource___No_Malekiyat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_NoSaziDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectDFNsBindingSource__Vaziyat_Tamallok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectDFNsBindingSource__Code_NO_Malekiyat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Select_Tbl_Moshakhasat_MalekinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Select_Tbl_Moshakhasat_MalekinDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTarikh_Tamallok As TextualControl.TextualControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTel As TextualControl.TextualControl
    Friend WithEvents txtAddress As TextualControl.TextualControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMahal_Sodour As TextualControl.TextualControl
    Friend WithEvents txtCodeMelli As TextualControl.TextualControl
    Friend WithEvents txtSHsh As TextualControl.TextualControl
    Friend WithEvents txtName_Pedar As TextualControl.TextualControl
    Friend WithEvents txtLName As TextualControl.TextualControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblRadif As System.Windows.Forms.Label
    Friend WithEvents txtNo_Malekiyat_Tedad As TextualControl.TextualControl
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents SelectDFNsBindingSource___No_Malekiyat As System.Windows.Forms.BindingSource
    Friend WithEvents DB_NoSaziDataSet As Amlak.DB_NoSaziDataSet
    Friend WithEvents Select_DFNsTableAdapter As Amlak.DB_NoSaziDataSetTableAdapters.Select_DFNsTableAdapter
    Friend WithEvents SelectDFNsBindingSource__Vaziyat_Tamallok As System.Windows.Forms.BindingSource
    Friend WithEvents SelectDFNsBindingSource__Code_NO_Malekiyat As System.Windows.Forms.BindingSource
    Friend WithEvents lblSHsh As System.Windows.Forms.Label
    Friend WithEvents TableAdapterManager As Amlak.DB_NoSaziDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RadifDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Select_Tbl_Moshakhasat_MalekinBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Select_Tbl_Moshakhasat_MalekinTableAdapter As Amlak.DB_NoSaziDataSetTableAdapters.Select_Tbl_Moshakhasat_MalekinTableAdapter
    Friend WithEvents Select_Tbl_Moshakhasat_MalekinDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboCodeNoMalekiyat As System.Windows.Forms.ComboBox
    Friend WithEvents cboVazeyatTamallok As System.Windows.Forms.ComboBox
    Friend WithEvents cboNoMalekiyatCode As System.Windows.Forms.ComboBox
    Friend WithEvents txtFName As TextualControl.TextualControl
End Class
