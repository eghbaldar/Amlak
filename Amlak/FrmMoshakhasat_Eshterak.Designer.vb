<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMoshakhasat_Eshterak
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
        Me.txtTel = New TextualControl.TextualControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAb = New TextualControl.TextualControl
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtBargh = New TextualControl.TextualControl
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtGaz = New TextualControl.TextualControl
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.lblSHsh = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtMos_Chah = New TextualControl.TextualControl
        Me.txtMos_Golkhaneh = New TextualControl.TextualControl
        Me.txtMos_Masahat_Estakhr = New TextualControl.TextualControl
        Me.txtMos_Hajm_Estakhr = New TextualControl.TextualControl
        Me.DB_NoSaziDataSet = New Amlak.DB_NoSaziDataSet
        Me.SelectTblEshterakBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Select_Tbl_EshterakTableAdapter = New Amlak.DB_NoSaziDataSetTableAdapters.Select_Tbl_EshterakTableAdapter
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DB_NoSaziDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectTblEshterakBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(452, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "شماره شناسنامه زمین"
        '
        'txtTel
        '
        Me.txtTel.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTel.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTel.DefaultColor = System.Drawing.Color.Empty
        Me.txtTel.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtTel.Location = New System.Drawing.Point(15, 39)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtTel.Size = New System.Drawing.Size(100, 21)
        Me.txtTel.TabIndex = 3
        Me.txtTel.Text = "0"
        Me.txtTel.Type = TextualControl.TextualControl.No.Numeric
        Me.txtTel.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtTel.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "شماره تلفن"
        '
        'txtAb
        '
        Me.txtAb.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAb.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtAb.DefaultColor = System.Drawing.Color.Empty
        Me.txtAb.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtAb.Location = New System.Drawing.Point(426, 39)
        Me.txtAb.Name = "txtAb"
        Me.txtAb.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtAb.Size = New System.Drawing.Size(100, 21)
        Me.txtAb.TabIndex = 0
        Me.txtAb.Text = "0"
        Me.txtAb.Type = TextualControl.TextualControl.No.Numeric
        Me.txtAb.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtAb.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(431, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "شماره اشتراک آب"
        '
        'txtBargh
        '
        Me.txtBargh.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBargh.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtBargh.DefaultColor = System.Drawing.Color.Empty
        Me.txtBargh.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtBargh.Location = New System.Drawing.Point(289, 39)
        Me.txtBargh.Name = "txtBargh"
        Me.txtBargh.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtBargh.Size = New System.Drawing.Size(100, 21)
        Me.txtBargh.TabIndex = 1
        Me.txtBargh.Text = "0"
        Me.txtBargh.Type = TextualControl.TextualControl.No.Numeric
        Me.txtBargh.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtBargh.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(291, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "شماره اشتراک برق"
        '
        'txtGaz
        '
        Me.txtGaz.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGaz.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtGaz.DefaultColor = System.Drawing.Color.Empty
        Me.txtGaz.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtGaz.Location = New System.Drawing.Point(152, 38)
        Me.txtGaz.Name = "txtGaz"
        Me.txtGaz.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtGaz.Size = New System.Drawing.Size(100, 21)
        Me.txtGaz.TabIndex = 2
        Me.txtGaz.Text = "0"
        Me.txtGaz.Type = TextualControl.TextualControl.No.Numeric
        Me.txtGaz.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtGaz.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(157, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "شماره اشتراک گاز"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtTel)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtGaz)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtAb)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtBargh)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(550, 77)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "اشتراک"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(109, 202)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(91, 39)
        Me.btnOK.TabIndex = 22
        Me.btnOK.TabStop = False
        Me.btnOK.Text = "ذخیره"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(206, 202)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 39)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "انصراف"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(12, 202)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(91, 39)
        Me.btnNext.TabIndex = 20
        Me.btnNext.TabStop = False
        Me.btnNext.Text = "افراد ممیزی"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblSHsh
        '
        Me.lblSHsh.AutoSize = True
        Me.lblSHsh.Location = New System.Drawing.Point(333, 9)
        Me.lblSHsh.Name = "lblSHsh"
        Me.lblSHsh.Size = New System.Drawing.Size(113, 13)
        Me.lblSHsh.TabIndex = 3
        Me.lblSHsh.Text = "شماره شناسنامه زمین"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMos_Chah)
        Me.GroupBox1.Controls.Add(Me.txtMos_Golkhaneh)
        Me.GroupBox1.Controls.Add(Me.txtMos_Masahat_Estakhr)
        Me.GroupBox1.Controls.Add(Me.txtMos_Hajm_Estakhr)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 77)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مستحدثات"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "تعداد چاه عمیق"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(300, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "مساحت استخر"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(131, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "مساحت گلخانه خارج از طبقات"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(445, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "حجم استخر"
        '
        'txtMos_Chah
        '
        Me.txtMos_Chah.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMos_Chah.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtMos_Chah.DefaultColor = System.Drawing.Color.Empty
        Me.txtMos_Chah.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtMos_Chah.Location = New System.Drawing.Point(15, 41)
        Me.txtMos_Chah.Name = "txtMos_Chah"
        Me.txtMos_Chah.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtMos_Chah.Size = New System.Drawing.Size(100, 21)
        Me.txtMos_Chah.TabIndex = 3
        Me.txtMos_Chah.Text = "0"
        Me.txtMos_Chah.Type = TextualControl.TextualControl.No.Numeric
        Me.txtMos_Chah.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtMos_Chah.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'txtMos_Golkhaneh
        '
        Me.txtMos_Golkhaneh.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMos_Golkhaneh.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtMos_Golkhaneh.DefaultColor = System.Drawing.Color.Empty
        Me.txtMos_Golkhaneh.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtMos_Golkhaneh.Location = New System.Drawing.Point(152, 39)
        Me.txtMos_Golkhaneh.Name = "txtMos_Golkhaneh"
        Me.txtMos_Golkhaneh.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtMos_Golkhaneh.Size = New System.Drawing.Size(100, 21)
        Me.txtMos_Golkhaneh.TabIndex = 2
        Me.txtMos_Golkhaneh.Text = "0"
        Me.txtMos_Golkhaneh.Type = TextualControl.TextualControl.No.Numeric
        Me.txtMos_Golkhaneh.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtMos_Golkhaneh.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'txtMos_Masahat_Estakhr
        '
        Me.txtMos_Masahat_Estakhr.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMos_Masahat_Estakhr.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtMos_Masahat_Estakhr.DefaultColor = System.Drawing.Color.Empty
        Me.txtMos_Masahat_Estakhr.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtMos_Masahat_Estakhr.Location = New System.Drawing.Point(289, 39)
        Me.txtMos_Masahat_Estakhr.Name = "txtMos_Masahat_Estakhr"
        Me.txtMos_Masahat_Estakhr.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtMos_Masahat_Estakhr.Size = New System.Drawing.Size(100, 21)
        Me.txtMos_Masahat_Estakhr.TabIndex = 1
        Me.txtMos_Masahat_Estakhr.Text = "0"
        Me.txtMos_Masahat_Estakhr.Type = TextualControl.TextualControl.No.Numeric
        Me.txtMos_Masahat_Estakhr.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtMos_Masahat_Estakhr.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'txtMos_Hajm_Estakhr
        '
        Me.txtMos_Hajm_Estakhr.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMos_Hajm_Estakhr.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtMos_Hajm_Estakhr.DefaultColor = System.Drawing.Color.Empty
        Me.txtMos_Hajm_Estakhr.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtMos_Hajm_Estakhr.Location = New System.Drawing.Point(426, 39)
        Me.txtMos_Hajm_Estakhr.Name = "txtMos_Hajm_Estakhr"
        Me.txtMos_Hajm_Estakhr.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtMos_Hajm_Estakhr.Size = New System.Drawing.Size(100, 21)
        Me.txtMos_Hajm_Estakhr.TabIndex = 0
        Me.txtMos_Hajm_Estakhr.Text = "0"
        Me.txtMos_Hajm_Estakhr.Type = TextualControl.TextualControl.No.Numeric
        Me.txtMos_Hajm_Estakhr.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtMos_Hajm_Estakhr.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'DB_NoSaziDataSet
        '
        Me.DB_NoSaziDataSet.DataSetName = "DB_NoSaziDataSet"
        Me.DB_NoSaziDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SelectTblEshterakBindingSource
        '
        Me.SelectTblEshterakBindingSource.DataMember = "Select_Tbl_Eshterak"
        Me.SelectTblEshterakBindingSource.DataSource = Me.DB_NoSaziDataSet
        '
        'Select_Tbl_EshterakTableAdapter
        '
        Me.Select_Tbl_EshterakTableAdapter.ClearBeforeFill = True
        '
        'FrmMoshakhasat_Eshterak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(577, 250)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblSHsh)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMoshakhasat_Eshterak"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اشتراک"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DB_NoSaziDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectTblEshterakBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTel As TextualControl.TextualControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAb As TextualControl.TextualControl
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBargh As TextualControl.TextualControl
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtGaz As TextualControl.TextualControl
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblSHsh As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMos_Chah As TextualControl.TextualControl
    Friend WithEvents txtMos_Golkhaneh As TextualControl.TextualControl
    Friend WithEvents txtMos_Masahat_Estakhr As TextualControl.TextualControl
    Friend WithEvents txtMos_Hajm_Estakhr As TextualControl.TextualControl
    Friend WithEvents DB_NoSaziDataSet As Amlak.DB_NoSaziDataSet
    Friend WithEvents SelectTblEshterakBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Select_Tbl_EshterakTableAdapter As Amlak.DB_NoSaziDataSetTableAdapters.Select_Tbl_EshterakTableAdapter
End Class
