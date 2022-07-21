<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDerakht
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
        Me.cboTedad_Derakht = New System.Windows.Forms.ComboBox
        Me.SelectDFNsBindingSource__bon = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_NoSaziDataSet = New Amlak.DB_NoSaziDataSet
        Me.cboNo_Derakht = New System.Windows.Forms.ComboBox
        Me.SelectDFNsBindingSource__No = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.Select_DFNsTableAdapter = New Amlak.DB_NoSaziDataSetTableAdapters.Select_DFNsTableAdapter
        Me.lblSHsh = New System.Windows.Forms.Label
        Me.TableAdapterManager = New Amlak.DB_NoSaziDataSetTableAdapters.TableAdapterManager
        Me.Select_Tbl_DerakhtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Select_Tbl_DerakhtTableAdapter = New Amlak.DB_NoSaziDataSetTableAdapters.Select_Tbl_DerakhtTableAdapter
        Me.Select_Tbl_DerakhtDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.SelectDFNsBindingSource__bon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_NoSaziDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectDFNsBindingSource__No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Select_Tbl_DerakhtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Select_Tbl_DerakhtDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(311, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "شماره شناسنامه زمین"
        '
        'cboTedad_Derakht
        '
        Me.cboTedad_Derakht.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTedad_Derakht.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTedad_Derakht.DataSource = Me.SelectDFNsBindingSource__bon
        Me.cboTedad_Derakht.DisplayMember = "name"
        Me.cboTedad_Derakht.FormattingEnabled = True
        Me.cboTedad_Derakht.Location = New System.Drawing.Point(38, 57)
        Me.cboTedad_Derakht.Name = "cboTedad_Derakht"
        Me.cboTedad_Derakht.Size = New System.Drawing.Size(121, 21)
        Me.cboTedad_Derakht.TabIndex = 1
        Me.cboTedad_Derakht.ValueMember = "code"
        '
        'SelectDFNsBindingSource__bon
        '
        Me.SelectDFNsBindingSource__bon.AllowNew = True
        Me.SelectDFNsBindingSource__bon.DataMember = "Select_DFNs"
        Me.SelectDFNsBindingSource__bon.DataSource = Me.DB_NoSaziDataSet
        Me.SelectDFNsBindingSource__bon.Filter = "code >=403 and code <=407"
        '
        'DB_NoSaziDataSet
        '
        Me.DB_NoSaziDataSet.DataSetName = "DB_NoSaziDataSet"
        Me.DB_NoSaziDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboNo_Derakht
        '
        Me.cboNo_Derakht.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboNo_Derakht.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNo_Derakht.DataSource = Me.SelectDFNsBindingSource__No
        Me.cboNo_Derakht.DisplayMember = "name"
        Me.cboNo_Derakht.FormattingEnabled = True
        Me.cboNo_Derakht.Location = New System.Drawing.Point(246, 57)
        Me.cboNo_Derakht.Name = "cboNo_Derakht"
        Me.cboNo_Derakht.Size = New System.Drawing.Size(121, 21)
        Me.cboNo_Derakht.TabIndex = 0
        Me.cboNo_Derakht.ValueMember = "code"
        '
        'SelectDFNsBindingSource__No
        '
        Me.SelectDFNsBindingSource__No.DataMember = "Select_DFNs"
        Me.SelectDFNsBindingSource__No.DataSource = Me.DB_NoSaziDataSet
        Me.SelectDFNsBindingSource__No.Filter = "code >= 400 and code <=402"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(373, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "نوع درخت"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(165, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "تعداد درخت"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(176, 250)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(91, 39)
        Me.btnOK.TabIndex = 14
        Me.btnOK.TabStop = False
        Me.btnOK.Text = "ذخیره"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(273, 250)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 39)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "انصراف"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(79, 250)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(91, 39)
        Me.btnNext.TabIndex = 12
        Me.btnNext.TabStop = False
        Me.btnNext.Text = "مشخصات ساختمان"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Select_DFNsTableAdapter
        '
        Me.Select_DFNsTableAdapter.ClearBeforeFill = True
        '
        'lblSHsh
        '
        Me.lblSHsh.AutoSize = True
        Me.lblSHsh.Location = New System.Drawing.Point(192, 15)
        Me.lblSHsh.Name = "lblSHsh"
        Me.lblSHsh.Size = New System.Drawing.Size(113, 13)
        Me.lblSHsh.TabIndex = 5
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
        'Select_Tbl_DerakhtBindingSource
        '
        Me.Select_Tbl_DerakhtBindingSource.DataMember = "Select_Tbl_Derakht"
        Me.Select_Tbl_DerakhtBindingSource.DataSource = Me.DB_NoSaziDataSet
        '
        'Select_Tbl_DerakhtTableAdapter
        '
        Me.Select_Tbl_DerakhtTableAdapter.ClearBeforeFill = True
        '
        'Select_Tbl_DerakhtDataGridView
        '
        Me.Select_Tbl_DerakhtDataGridView.AllowUserToAddRows = False
        Me.Select_Tbl_DerakhtDataGridView.AllowUserToDeleteRows = False
        Me.Select_Tbl_DerakhtDataGridView.AutoGenerateColumns = False
        Me.Select_Tbl_DerakhtDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Select_Tbl_DerakhtDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Select_Tbl_DerakhtDataGridView.DataSource = Me.Select_Tbl_DerakhtBindingSource
        Me.Select_Tbl_DerakhtDataGridView.Location = New System.Drawing.Point(88, 90)
        Me.Select_Tbl_DerakhtDataGridView.Name = "Select_Tbl_DerakhtDataGridView"
        Me.Select_Tbl_DerakhtDataGridView.ReadOnly = True
        Me.Select_Tbl_DerakhtDataGridView.Size = New System.Drawing.Size(276, 154)
        Me.Select_Tbl_DerakhtDataGridView.TabIndex = 15
        Me.Select_Tbl_DerakhtDataGridView.TabStop = False
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "No"
        Me.DataGridViewTextBoxColumn2.HeaderText = "نوع"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Bon"
        Me.DataGridViewTextBoxColumn3.HeaderText = "تعداد"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'FrmDerakht
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(462, 294)
        Me.Controls.Add(Me.Select_Tbl_DerakhtDataGridView)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.cboNo_Derakht)
        Me.Controls.Add(Me.cboTedad_Derakht)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSHsh)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDerakht"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "درخت"
        CType(Me.SelectDFNsBindingSource__bon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_NoSaziDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectDFNsBindingSource__No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Select_Tbl_DerakhtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Select_Tbl_DerakhtDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTedad_Derakht As System.Windows.Forms.ComboBox
    Friend WithEvents cboNo_Derakht As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents SelectDFNsBindingSource__No As System.Windows.Forms.BindingSource
    Friend WithEvents DB_NoSaziDataSet As Amlak.DB_NoSaziDataSet
    Friend WithEvents Select_DFNsTableAdapter As Amlak.DB_NoSaziDataSetTableAdapters.Select_DFNsTableAdapter
    Friend WithEvents SelectDFNsBindingSource__bon As System.Windows.Forms.BindingSource
    Friend WithEvents lblSHsh As System.Windows.Forms.Label
    Friend WithEvents TableAdapterManager As Amlak.DB_NoSaziDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Select_Tbl_DerakhtBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Select_Tbl_DerakhtTableAdapter As Amlak.DB_NoSaziDataSetTableAdapters.Select_Tbl_DerakhtTableAdapter
    Friend WithEvents Select_Tbl_DerakhtDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
