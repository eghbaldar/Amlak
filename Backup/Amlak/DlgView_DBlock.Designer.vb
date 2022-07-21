<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DlgView_DBlock
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
        Me.Select_DFN_BLOCKDataGridView = New System.Windows.Forms.DataGridView
        Me.Select_DFN_BLOCKTableAdapter = New Amlak.DB_NoSaziDataSetTableAdapters.Select_DFN_BLOCKTableAdapter
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnOK = New System.Windows.Forms.Button
        Me.txtSharh = New TextualControl.TextualControl
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCode = New TextualControl.TextualControl
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Select_DFN_BLOCKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_NoSaziDataSet = New Amlak.DB_NoSaziDataSet
        Me.TableAdapterManager = New Amlak.DB_NoSaziDataSetTableAdapters.TableAdapterManager
        CType(Me.Select_DFN_BLOCKDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Select_DFN_BLOCKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_NoSaziDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Select_DFN_BLOCKDataGridView
        '
        Me.Select_DFN_BLOCKDataGridView.AutoGenerateColumns = False
        Me.Select_DFN_BLOCKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Select_DFN_BLOCKDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Select_DFN_BLOCKDataGridView.DataSource = Me.Select_DFN_BLOCKBindingSource
        Me.Select_DFN_BLOCKDataGridView.Location = New System.Drawing.Point(12, 83)
        Me.Select_DFN_BLOCKDataGridView.Name = "Select_DFN_BLOCKDataGridView"
        Me.Select_DFN_BLOCKDataGridView.Size = New System.Drawing.Size(515, 214)
        Me.Select_DFN_BLOCKDataGridView.TabIndex = 3
        '
        'Select_DFN_BLOCKTableAdapter
        '
        Me.Select_DFN_BLOCKTableAdapter.ClearBeforeFill = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(12, 303)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 35)
        Me.BtnCancel.TabIndex = 15
        Me.BtnCancel.TabStop = False
        Me.BtnCancel.Text = "انصراف"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(93, 303)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(75, 35)
        Me.BtnOK.TabIndex = 14
        Me.BtnOK.TabStop = False
        Me.BtnOK.Text = "تأیید"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'txtSharh
        '
        Me.txtSharh.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSharh.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtSharh.DefaultColor = System.Drawing.Color.Empty
        Me.txtSharh.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtSharh.Location = New System.Drawing.Point(6, 22)
        Me.txtSharh.Name = "txtSharh"
        Me.txtSharh.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtSharh.Size = New System.Drawing.Size(307, 21)
        Me.txtSharh.TabIndex = 1
        Me.txtSharh.Type = TextualControl.TextualControl.No.Normal
        Me.txtSharh.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtSharh.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(488, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "کد"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(319, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "شرح"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSharh)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 56)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "جستجو بر اساس"
        '
        'txtCode
        '
        Me.txtCode.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCode.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtCode.DefaultColor = System.Drawing.Color.Empty
        Me.txtCode.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtCode.Location = New System.Drawing.Point(382, 22)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtCode.Size = New System.Drawing.Size(100, 21)
        Me.txtCode.TabIndex = 1
        Me.txtCode.Type = TextualControl.TextualControl.No.Normal
        Me.txtCode.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtCode.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn1.HeaderText = "کد"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Code_SHsh"
        Me.DataGridViewTextBoxColumn2.HeaderText = "کد سه رقمی"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Sharh"
        Me.DataGridViewTextBoxColumn3.HeaderText = "شرح"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'Select_DFN_BLOCKBindingSource
        '
        Me.Select_DFN_BLOCKBindingSource.DataMember = "Select_DFN_BLOCK"
        Me.Select_DFN_BLOCKBindingSource.DataSource = Me.DB_NoSaziDataSet
        '
        'DB_NoSaziDataSet
        '
        Me.DB_NoSaziDataSet.DataSetName = "DB_NoSaziDataSet"
        Me.DB_NoSaziDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'DlgView_DBlock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 350)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Select_DFN_BLOCKDataGridView)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DlgView_DBlock"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DlgView_DBlock"
        CType(Me.Select_DFN_BLOCKDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Select_DFN_BLOCKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_NoSaziDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DB_NoSaziDataSet As Amlak.DB_NoSaziDataSet
    Friend WithEvents Select_DFN_BLOCKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Select_DFN_BLOCKTableAdapter As Amlak.DB_NoSaziDataSetTableAdapters.Select_DFN_BLOCKTableAdapter
    Friend WithEvents TableAdapterManager As Amlak.DB_NoSaziDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Select_DFN_BLOCKDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents txtSharh As TextualControl.TextualControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCode As TextualControl.TextualControl

End Class
