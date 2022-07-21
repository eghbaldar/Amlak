<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDGheymat_Arseh
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
        Me.lblSharhBlock = New System.Windows.Forms.Label
        Me.lblCodeBlock = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblRadif = New System.Windows.Forms.Label
        Me.txtSharh = New TextualControl.TextualControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtGheymat = New TextualControl.TextualControl
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblGheymat_Str = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnGheymat_Jadid = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnOk = New System.Windows.Forms.Button
        Me.txtSal = New TextualControl.TextualControl
        Me.Label2 = New System.Windows.Forms.Label
        Me.DB_NoSaziDataSet = New Amlak.DB_NoSaziDataSet
        Me.FSelect_Sal_GheymatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FSelect_Sal_GheymatTableAdapter = New Amlak.DB_NoSaziDataSetTableAdapters.FSelect_Sal_GheymatTableAdapter
        Me.TableAdapterManager = New Amlak.DB_NoSaziDataSetTableAdapters.TableAdapterManager
        Me.FSelect_Sal_GheymatDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextualControl1 = New TextualControl.TextualControl
        CType(Me.DB_NoSaziDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FSelect_Sal_GheymatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FSelect_Sal_GheymatDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSharhBlock
        '
        Me.lblSharhBlock.Location = New System.Drawing.Point(93, 9)
        Me.lblSharhBlock.Name = "lblSharhBlock"
        Me.lblSharhBlock.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblSharhBlock.Size = New System.Drawing.Size(383, 13)
        Me.lblSharhBlock.TabIndex = 0
        Me.lblSharhBlock.Text = "شرح بلوک"
        '
        'lblCodeBlock
        '
        Me.lblCodeBlock.Location = New System.Drawing.Point(482, 9)
        Me.lblCodeBlock.Name = "lblCodeBlock"
        Me.lblCodeBlock.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblCodeBlock.Size = New System.Drawing.Size(53, 13)
        Me.lblCodeBlock.TabIndex = 1
        Me.lblCodeBlock.Text = "شماره بلوک"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(587, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ردیف"
        '
        'lblRadif
        '
        Me.lblRadif.AutoSize = True
        Me.lblRadif.Location = New System.Drawing.Point(481, 48)
        Me.lblRadif.Name = "lblRadif"
        Me.lblRadif.Size = New System.Drawing.Size(29, 13)
        Me.lblRadif.TabIndex = 4
        Me.lblRadif.Text = "ردیف"
        '
        'txtSharh
        '
        Me.txtSharh.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSharh.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtSharh.DefaultColor = System.Drawing.Color.Empty
        Me.txtSharh.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtSharh.Location = New System.Drawing.Point(13, 79)
        Me.txtSharh.Multiline = True
        Me.txtSharh.Name = "txtSharh"
        Me.txtSharh.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtSharh.Size = New System.Drawing.Size(497, 46)
        Me.txtSharh.TabIndex = 1
        Me.txtSharh.Type = TextualControl.TextualControl.No.Normal
        Me.txtSharh.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtSharh.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(516, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "شرح و موقعیت محل"
        '
        'txtGheymat
        '
        Me.txtGheymat.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGheymat.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtGheymat.DefaultColor = System.Drawing.Color.Empty
        Me.txtGheymat.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtGheymat.Location = New System.Drawing.Point(409, 133)
        Me.txtGheymat.Name = "txtGheymat"
        Me.txtGheymat.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtGheymat.Size = New System.Drawing.Size(100, 21)
        Me.txtGheymat.TabIndex = 2
        Me.txtGheymat.Text = "0"
        Me.txtGheymat.Type = TextualControl.TextualControl.No.Numeric
        Me.txtGheymat.Type_Poli = TextualControl.TextualControl.Poli.WithoutDot
        Me.txtGheymat.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(583, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "قیمت"
        '
        'lblGheymat_Str
        '
        Me.lblGheymat_Str.Location = New System.Drawing.Point(164, 161)
        Me.lblGheymat_Str.Name = "lblGheymat_Str"
        Me.lblGheymat_Str.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblGheymat_Str.Size = New System.Drawing.Size(452, 23)
        Me.lblGheymat_Str.TabIndex = 9
        Me.lblGheymat_Str.Text = "قیمت به حروف:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(379, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "ریال"
        '
        'btnGheymat_Jadid
        '
        Me.btnGheymat_Jadid.Location = New System.Drawing.Point(13, 210)
        Me.btnGheymat_Jadid.Name = "btnGheymat_Jadid"
        Me.btnGheymat_Jadid.Size = New System.Drawing.Size(75, 35)
        Me.btnGheymat_Jadid.TabIndex = 11
        Me.btnGheymat_Jadid.TabStop = False
        Me.btnGheymat_Jadid.Text = "قیمت جدید"
        Me.btnGheymat_Jadid.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(13, 292)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 35)
        Me.BtnCancel.TabIndex = 14
        Me.BtnCancel.TabStop = False
        Me.BtnCancel.Text = "انصراف"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(13, 251)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(75, 35)
        Me.BtnOk.TabIndex = 14
        Me.BtnOk.TabStop = False
        Me.BtnOk.Text = "ذخیره"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'txtSal
        '
        Me.txtSal.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSal.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtSal.DefaultColor = System.Drawing.Color.Empty
        Me.txtSal.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtSal.Location = New System.Drawing.Point(215, 45)
        Me.txtSal.Name = "txtSal"
        Me.txtSal.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtSal.Size = New System.Drawing.Size(100, 21)
        Me.txtSal.TabIndex = 0
        Me.txtSal.Type = TextualControl.TextualControl.No.Numeric
        Me.txtSal.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtSal.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(321, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "سال"
        '
        'DB_NoSaziDataSet
        '
        Me.DB_NoSaziDataSet.DataSetName = "DB_NoSaziDataSet"
        Me.DB_NoSaziDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FSelect_Sal_GheymatBindingSource
        '
        Me.FSelect_Sal_GheymatBindingSource.DataMember = "FSelect_Sal_Gheymat"
        Me.FSelect_Sal_GheymatBindingSource.DataSource = Me.DB_NoSaziDataSet
        '
        'FSelect_Sal_GheymatTableAdapter
        '
        Me.FSelect_Sal_GheymatTableAdapter.ClearBeforeFill = True
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
        'FSelect_Sal_GheymatDataGridView
        '
        Me.FSelect_Sal_GheymatDataGridView.AutoGenerateColumns = False
        Me.FSelect_Sal_GheymatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FSelect_Sal_GheymatDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.FSelect_Sal_GheymatDataGridView.DataSource = Me.FSelect_Sal_GheymatBindingSource
        Me.FSelect_Sal_GheymatDataGridView.Location = New System.Drawing.Point(103, 211)
        Me.FSelect_Sal_GheymatDataGridView.Name = "FSelect_Sal_GheymatDataGridView"
        Me.FSelect_Sal_GheymatDataGridView.Size = New System.Drawing.Size(511, 220)
        Me.FSelect_Sal_GheymatDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "sharh"
        Me.DataGridViewTextBoxColumn2.HeaderText = "sharh"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "gheymat"
        Me.DataGridViewTextBoxColumn3.HeaderText = "gheymat"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "sal"
        Me.DataGridViewTextBoxColumn4.HeaderText = "sal"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(541, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "شماره بلوک:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(321, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "درصد"
        '
        'TextualControl1
        '
        Me.TextualControl1.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextualControl1.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextualControl1.DefaultColor = System.Drawing.Color.Empty
        Me.TextualControl1.Language = TextualControl.TextualControl.Zaban.Persian
        Me.TextualControl1.Location = New System.Drawing.Point(215, 133)
        Me.TextualControl1.Name = "TextualControl1"
        Me.TextualControl1.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.TextualControl1.Size = New System.Drawing.Size(100, 21)
        Me.TextualControl1.TabIndex = 0
        Me.TextualControl1.Text = "0"
        Me.TextualControl1.Type = TextualControl.TextualControl.No.Numeric
        Me.TextualControl1.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.TextualControl1.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'FrmDGheymat_Arseh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(626, 451)
        Me.Controls.Add(Me.FSelect_Sal_GheymatDataGridView)
        Me.Controls.Add(Me.TextualControl1)
        Me.Controls.Add(Me.txtSal)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.btnGheymat_Jadid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblGheymat_Str)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtGheymat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSharh)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblRadif)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblCodeBlock)
        Me.Controls.Add(Me.lblSharhBlock)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDGheymat_Arseh"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تعریف قیمت عرصه"
        CType(Me.DB_NoSaziDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FSelect_Sal_GheymatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FSelect_Sal_GheymatDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSharhBlock As System.Windows.Forms.Label
    Friend WithEvents lblCodeBlock As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblRadif As System.Windows.Forms.Label
    Friend WithEvents txtSharh As TextualControl.TextualControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGheymat As TextualControl.TextualControl
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblGheymat_Str As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnGheymat_Jadid As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents txtSal As TextualControl.TextualControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DB_NoSaziDataSet As Amlak.DB_NoSaziDataSet
    Friend WithEvents FSelect_Sal_GheymatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FSelect_Sal_GheymatTableAdapter As Amlak.DB_NoSaziDataSetTableAdapters.FSelect_Sal_GheymatTableAdapter
    Friend WithEvents TableAdapterManager As Amlak.DB_NoSaziDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FSelect_Sal_GheymatDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextualControl1 As TextualControl.TextualControl
End Class
