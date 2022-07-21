<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAfrad_Momayezi
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtSNahiyeh_Name = New TextualControl.TextualControl
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtSNahiyeh_Tarikh = New TextualControl.TextualControl
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtMomayez_Name = New TextualControl.TextualControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtMomayez_Tarikh = New TextualControl.TextualControl
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtSMantagheh_Name = New TextualControl.TextualControl
        Me.txtSMantagheh_Tarikh = New TextualControl.TextualControl
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtBazbin_Name = New TextualControl.TextualControl
        Me.txtBazbin_Tarikh = New TextualControl.TextualControl
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.lblSHsh = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DB_NoSaziDataSet = New Amlak.DB_NoSaziDataSet
        Me.SelectTblAfradMomayeziBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Select_Tbl_Afrad_MomayeziTableAdapter = New Amlak.DB_NoSaziDataSetTableAdapters.Select_Tbl_Afrad_MomayeziTableAdapter
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DB_NoSaziDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectTblAfradMomayeziBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtSNahiyeh_Name)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.txtSNahiyeh_Tarikh)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Location = New System.Drawing.Point(274, 123)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(244, 81)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "سرپرست ممیزی ناحیه"
        '
        'txtSNahiyeh_Name
        '
        Me.txtSNahiyeh_Name.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSNahiyeh_Name.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtSNahiyeh_Name.DefaultColor = System.Drawing.Color.Empty
        Me.txtSNahiyeh_Name.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtSNahiyeh_Name.Location = New System.Drawing.Point(6, 47)
        Me.txtSNahiyeh_Name.Name = "txtSNahiyeh_Name"
        Me.txtSNahiyeh_Name.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtSNahiyeh_Name.Size = New System.Drawing.Size(137, 21)
        Me.txtSNahiyeh_Name.TabIndex = 1
        Me.txtSNahiyeh_Name.Type = TextualControl.TextualControl.No.Normal
        Me.txtSNahiyeh_Name.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtSNahiyeh_Name.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(149, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "نام و نام خانوادگی"
        '
        'txtSNahiyeh_Tarikh
        '
        Me.txtSNahiyeh_Tarikh.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSNahiyeh_Tarikh.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtSNahiyeh_Tarikh.DefaultColor = System.Drawing.Color.Empty
        Me.txtSNahiyeh_Tarikh.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtSNahiyeh_Tarikh.Location = New System.Drawing.Point(43, 23)
        Me.txtSNahiyeh_Tarikh.Name = "txtSNahiyeh_Tarikh"
        Me.txtSNahiyeh_Tarikh.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtSNahiyeh_Tarikh.Size = New System.Drawing.Size(100, 21)
        Me.txtSNahiyeh_Tarikh.TabIndex = 0
        Me.txtSNahiyeh_Tarikh.Type = TextualControl.TextualControl.No.Normal
        Me.txtSNahiyeh_Tarikh.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtSNahiyeh_Tarikh.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(210, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "تاریخ"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMomayez_Name)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtMomayez_Tarikh)
        Me.GroupBox3.Location = New System.Drawing.Point(274, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(244, 81)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ممیز"
        '
        'txtMomayez_Name
        '
        Me.txtMomayez_Name.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMomayez_Name.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtMomayez_Name.DefaultColor = System.Drawing.Color.Empty
        Me.txtMomayez_Name.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtMomayez_Name.Location = New System.Drawing.Point(4, 47)
        Me.txtMomayez_Name.Name = "txtMomayez_Name"
        Me.txtMomayez_Name.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtMomayez_Name.Size = New System.Drawing.Size(137, 21)
        Me.txtMomayez_Name.TabIndex = 1
        Me.txtMomayez_Name.Type = TextualControl.TextualControl.No.Normal
        Me.txtMomayez_Name.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtMomayez_Name.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(208, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "تاریخ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(147, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "نام و نام خانوادگی"
        '
        'txtMomayez_Tarikh
        '
        Me.txtMomayez_Tarikh.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMomayez_Tarikh.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtMomayez_Tarikh.DefaultColor = System.Drawing.Color.Empty
        Me.txtMomayez_Tarikh.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtMomayez_Tarikh.Location = New System.Drawing.Point(41, 23)
        Me.txtMomayez_Tarikh.Name = "txtMomayez_Tarikh"
        Me.txtMomayez_Tarikh.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtMomayez_Tarikh.Size = New System.Drawing.Size(100, 21)
        Me.txtMomayez_Tarikh.TabIndex = 0
        Me.txtMomayez_Tarikh.Type = TextualControl.TextualControl.No.Normal
        Me.txtMomayez_Tarikh.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtMomayez_Tarikh.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtSMantagheh_Name)
        Me.GroupBox4.Controls.Add(Me.txtSMantagheh_Tarikh)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(22, 123)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(244, 81)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "سرپرست ممیزی منطقه یا شهر"
        '
        'txtSMantagheh_Name
        '
        Me.txtSMantagheh_Name.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSMantagheh_Name.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtSMantagheh_Name.DefaultColor = System.Drawing.Color.Empty
        Me.txtSMantagheh_Name.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtSMantagheh_Name.Location = New System.Drawing.Point(3, 47)
        Me.txtSMantagheh_Name.Name = "txtSMantagheh_Name"
        Me.txtSMantagheh_Name.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtSMantagheh_Name.Size = New System.Drawing.Size(137, 21)
        Me.txtSMantagheh_Name.TabIndex = 1
        Me.txtSMantagheh_Name.Type = TextualControl.TextualControl.No.Normal
        Me.txtSMantagheh_Name.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtSMantagheh_Name.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'txtSMantagheh_Tarikh
        '
        Me.txtSMantagheh_Tarikh.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSMantagheh_Tarikh.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtSMantagheh_Tarikh.DefaultColor = System.Drawing.Color.Empty
        Me.txtSMantagheh_Tarikh.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtSMantagheh_Tarikh.Location = New System.Drawing.Point(40, 23)
        Me.txtSMantagheh_Tarikh.Name = "txtSMantagheh_Tarikh"
        Me.txtSMantagheh_Tarikh.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtSMantagheh_Tarikh.Size = New System.Drawing.Size(100, 21)
        Me.txtSMantagheh_Tarikh.TabIndex = 0
        Me.txtSMantagheh_Tarikh.Type = TextualControl.TextualControl.No.Normal
        Me.txtSMantagheh_Tarikh.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtSMantagheh_Tarikh.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(146, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "نام و نام خانوادگی"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(207, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "تاریخ"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtBazbin_Name)
        Me.GroupBox2.Controls.Add(Me.txtBazbin_Tarikh)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 81)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "بازبین ممیزی"
        '
        'txtBazbin_Name
        '
        Me.txtBazbin_Name.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBazbin_Name.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtBazbin_Name.DefaultColor = System.Drawing.Color.Empty
        Me.txtBazbin_Name.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtBazbin_Name.Location = New System.Drawing.Point(3, 47)
        Me.txtBazbin_Name.Name = "txtBazbin_Name"
        Me.txtBazbin_Name.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtBazbin_Name.Size = New System.Drawing.Size(137, 21)
        Me.txtBazbin_Name.TabIndex = 1
        Me.txtBazbin_Name.Type = TextualControl.TextualControl.No.Normal
        Me.txtBazbin_Name.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtBazbin_Name.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'txtBazbin_Tarikh
        '
        Me.txtBazbin_Tarikh.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBazbin_Tarikh.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtBazbin_Tarikh.DefaultColor = System.Drawing.Color.Empty
        Me.txtBazbin_Tarikh.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtBazbin_Tarikh.Location = New System.Drawing.Point(40, 23)
        Me.txtBazbin_Tarikh.Name = "txtBazbin_Tarikh"
        Me.txtBazbin_Tarikh.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtBazbin_Tarikh.Size = New System.Drawing.Size(100, 21)
        Me.txtBazbin_Tarikh.TabIndex = 0
        Me.txtBazbin_Tarikh.Type = TextualControl.TextualControl.No.Normal
        Me.txtBazbin_Tarikh.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtBazbin_Tarikh.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(207, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "تاریخ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(146, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "نام و نام خانوادگی"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(216, 233)
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
        Me.Button1.Location = New System.Drawing.Point(119, 233)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 39)
        Me.Button1.TabIndex = 15
        Me.Button1.TabStop = False
        Me.Button1.Text = "انصراف"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(22, 233)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(91, 39)
        Me.btnNext.TabIndex = 14
        Me.btnNext.TabStop = False
        Me.btnNext.Text = "مشخصات ممیزی"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblSHsh
        '
        Me.lblSHsh.AutoSize = True
        Me.lblSHsh.Location = New System.Drawing.Point(289, 9)
        Me.lblSHsh.Name = "lblSHsh"
        Me.lblSHsh.Size = New System.Drawing.Size(113, 13)
        Me.lblSHsh.TabIndex = 7
        Me.lblSHsh.Text = "شماره شناسنامه زمین"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(408, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "شماره شناسنامه زمین"
        '
        'DB_NoSaziDataSet
        '
        Me.DB_NoSaziDataSet.DataSetName = "DB_NoSaziDataSet"
        Me.DB_NoSaziDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SelectTblAfradMomayeziBindingSource
        '
        Me.SelectTblAfradMomayeziBindingSource.DataMember = "Select_Tbl_Afrad_Momayezi"
        Me.SelectTblAfradMomayeziBindingSource.DataSource = Me.DB_NoSaziDataSet
        '
        'Select_Tbl_Afrad_MomayeziTableAdapter
        '
        Me.Select_Tbl_Afrad_MomayeziTableAdapter.ClearBeforeFill = True
        '
        'FrmAfrad_Momayezi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 283)
        Me.Controls.Add(Me.lblSHsh)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Name = "FrmAfrad_Momayezi"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "افراد ممیزی"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DB_NoSaziDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectTblAfradMomayeziBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSNahiyeh_Name As TextualControl.TextualControl
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSNahiyeh_Tarikh As TextualControl.TextualControl
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMomayez_Name As TextualControl.TextualControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMomayez_Tarikh As TextualControl.TextualControl
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSMantagheh_Name As TextualControl.TextualControl
    Friend WithEvents txtSMantagheh_Tarikh As TextualControl.TextualControl
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBazbin_Name As TextualControl.TextualControl
    Friend WithEvents txtBazbin_Tarikh As TextualControl.TextualControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblSHsh As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DB_NoSaziDataSet As Amlak.DB_NoSaziDataSet
    Friend WithEvents SelectTblAfradMomayeziBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Select_Tbl_Afrad_MomayeziTableAdapter As Amlak.DB_NoSaziDataSetTableAdapters.Select_Tbl_Afrad_MomayeziTableAdapter
End Class
