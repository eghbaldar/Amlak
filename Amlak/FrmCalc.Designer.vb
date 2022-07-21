<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCalc))
        Me.lblMasahat_Melk = New System.Windows.Forms.Label
        Me.FSelect_CalcBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_NoSaziDataSet = New Amlak.DB_NoSaziDataSet
        Me.lblTedad_Bar = New System.Windows.Forms.Label
        Me.lblRah_Mostaghel = New System.Windows.Forms.Label
        Me.lblMeydan = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.FSelect_CalcTableAdapter = New Amlak.DB_NoSaziDataSetTableAdapters.FSelect_CalcTableAdapter
        Me.TableAdapterManager = New Amlak.DB_NoSaziDataSetTableAdapters.TableAdapterManager
        Me.TblDFN_GheymatTableAdapter = New Amlak.DB_NoSaziDataSetTableAdapters.TblDFN_GheymatTableAdapter
        Me.FSelect_SalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Code_BlockToolStripLabel = New System.Windows.Forms.ToolStripLabel
        Me.Code_BlockToolStripTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.DGFSelect_Sal = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FSelect_SalTableAdapter = New Amlak.DB_NoSaziDataSetTableAdapters.FSelect_SalTableAdapter
        Me.txtSharh = New TextualControl.TextualControl
        Me.TblDFN_GheymatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblDFN_GheymatDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        CType(Me.FSelect_CalcBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_NoSaziDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FSelect_SalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGFSelect_Sal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDFN_GheymatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDFN_GheymatDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMasahat_Melk
        '
        Me.lblMasahat_Melk.AutoSize = True
        Me.lblMasahat_Melk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMasahat_Melk.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FSelect_CalcBindingSource, "Masahat_Melk", True))
        Me.lblMasahat_Melk.Location = New System.Drawing.Point(43, 18)
        Me.lblMasahat_Melk.Name = "lblMasahat_Melk"
        Me.lblMasahat_Melk.Size = New System.Drawing.Size(38, 13)
        Me.lblMasahat_Melk.TabIndex = 3
        Me.lblMasahat_Melk.Text = "Label1"
        '
        'FSelect_CalcBindingSource
        '
        Me.FSelect_CalcBindingSource.DataMember = "FSelect_Calc"
        Me.FSelect_CalcBindingSource.DataSource = Me.DB_NoSaziDataSet
        '
        'DB_NoSaziDataSet
        '
        Me.DB_NoSaziDataSet.DataSetName = "DB_NoSaziDataSet"
        Me.DB_NoSaziDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblTedad_Bar
        '
        Me.lblTedad_Bar.AutoSize = True
        Me.lblTedad_Bar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTedad_Bar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FSelect_CalcBindingSource, "Bar_Tedad", True))
        Me.lblTedad_Bar.Location = New System.Drawing.Point(43, 51)
        Me.lblTedad_Bar.Name = "lblTedad_Bar"
        Me.lblTedad_Bar.Size = New System.Drawing.Size(38, 13)
        Me.lblTedad_Bar.TabIndex = 3
        Me.lblTedad_Bar.Text = "Label1"
        '
        'lblRah_Mostaghel
        '
        Me.lblRah_Mostaghel.AutoSize = True
        Me.lblRah_Mostaghel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblRah_Mostaghel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FSelect_CalcBindingSource, "Rah_Mostaghel", True))
        Me.lblRah_Mostaghel.Location = New System.Drawing.Point(43, 113)
        Me.lblRah_Mostaghel.Name = "lblRah_Mostaghel"
        Me.lblRah_Mostaghel.Size = New System.Drawing.Size(38, 13)
        Me.lblRah_Mostaghel.TabIndex = 3
        Me.lblRah_Mostaghel.Text = "Label1"
        '
        'lblMeydan
        '
        Me.lblMeydan.AutoSize = True
        Me.lblMeydan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMeydan.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FSelect_CalcBindingSource, "N_Meydan", True))
        Me.lblMeydan.Location = New System.Drawing.Point(43, 81)
        Me.lblMeydan.Name = "lblMeydan"
        Me.lblMeydan.Size = New System.Drawing.Size(38, 13)
        Me.lblMeydan.TabIndex = 3
        Me.lblMeydan.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(581, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FSelect_CalcTableAdapter
        '
        Me.FSelect_CalcTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DFNsTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_Moshakhasat_ZaminTableAdapter = Nothing
        Me.TableAdapterManager.TblDFN_BlockTableAdapter = Nothing
        Me.TableAdapterManager.TblDFN_GheymatTableAdapter = Me.TblDFN_GheymatTableAdapter
        Me.TableAdapterManager.TblDFN_SALTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Amlak.DB_NoSaziDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblDFN_GheymatTableAdapter
        '
        Me.TblDFN_GheymatTableAdapter.ClearBeforeFill = True
        '
        'FSelect_SalBindingSource
        '
        Me.FSelect_SalBindingSource.DataMember = "FSelect_Sal"
        Me.FSelect_SalBindingSource.DataSource = Me.DB_NoSaziDataSet
        '
        'Code_BlockToolStripLabel
        '
        Me.Code_BlockToolStripLabel.Name = "Code_BlockToolStripLabel"
        Me.Code_BlockToolStripLabel.Size = New System.Drawing.Size(66, 22)
        Me.Code_BlockToolStripLabel.Text = "Code_Block:"
        '
        'Code_BlockToolStripTextBox
        '
        Me.Code_BlockToolStripTextBox.Name = "Code_BlockToolStripTextBox"
        Me.Code_BlockToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'DGFSelect_Sal
        '
        Me.DGFSelect_Sal.AllowUserToAddRows = False
        Me.DGFSelect_Sal.AllowUserToDeleteRows = False
        Me.DGFSelect_Sal.AutoGenerateColumns = False
        Me.DGFSelect_Sal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGFSelect_Sal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DGFSelect_Sal.DataSource = Me.FSelect_SalBindingSource
        Me.DGFSelect_Sal.Location = New System.Drawing.Point(12, 170)
        Me.DGFSelect_Sal.Name = "DGFSelect_Sal"
        Me.DGFSelect_Sal.ReadOnly = True
        Me.DGFSelect_Sal.Size = New System.Drawing.Size(170, 220)
        Me.DGFSelect_Sal.TabIndex = 7
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "gheymat"
        Me.DataGridViewTextBoxColumn5.HeaderText = "قیمت"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 60
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "sal"
        Me.DataGridViewTextBoxColumn6.HeaderText = "سال"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 40
        '
        'FSelect_SalTableAdapter
        '
        Me.FSelect_SalTableAdapter.ClearBeforeFill = True
        '
        'txtSharh
        '
        Me.txtSharh.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSharh.ColorFocuse = System.Drawing.Color.Empty
        Me.txtSharh.DefaultColor = System.Drawing.Color.Empty
        Me.txtSharh.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtSharh.Location = New System.Drawing.Point(227, 142)
        Me.txtSharh.Name = "txtSharh"
        Me.txtSharh.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.No
        Me.txtSharh.Size = New System.Drawing.Size(239, 21)
        Me.txtSharh.TabIndex = 8
        Me.txtSharh.Type = TextualControl.TextualControl.No.Normal
        Me.txtSharh.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtSharh.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'TblDFN_GheymatBindingSource
        '
        Me.TblDFN_GheymatBindingSource.DataMember = "TblDFN_Gheymat"
        Me.TblDFN_GheymatBindingSource.DataSource = Me.DB_NoSaziDataSet
        '
        'TblDFN_GheymatDataGridView
        '
        Me.TblDFN_GheymatDataGridView.AllowUserToAddRows = False
        Me.TblDFN_GheymatDataGridView.AllowUserToDeleteRows = False
        Me.TblDFN_GheymatDataGridView.AutoGenerateColumns = False
        Me.TblDFN_GheymatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblDFN_GheymatDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TblDFN_GheymatDataGridView.DataSource = Me.TblDFN_GheymatBindingSource
        Me.TblDFN_GheymatDataGridView.Location = New System.Drawing.Point(188, 170)
        Me.TblDFN_GheymatDataGridView.Name = "TblDFN_GheymatDataGridView"
        Me.TblDFN_GheymatDataGridView.ReadOnly = True
        Me.TblDFN_GheymatDataGridView.Size = New System.Drawing.Size(468, 220)
        Me.TblDFN_GheymatDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Radif"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Radif"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Sharh"
        Me.DataGridViewTextBoxColumn2.HeaderText = "شرح و موقعیت محل"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 400
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Code_Block"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Code_Block"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(472, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "جستجو بر اساس شرح و موقعیت محل:"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.FSelect_SalBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(665, 25)
        Me.BindingNavigator1.TabIndex = 11
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'FrmCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 402)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TblDFN_GheymatDataGridView)
        Me.Controls.Add(Me.txtSharh)
        Me.Controls.Add(Me.DGFSelect_Sal)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblMeydan)
        Me.Controls.Add(Me.lblRah_Mostaghel)
        Me.Controls.Add(Me.lblTedad_Bar)
        Me.Controls.Add(Me.lblMasahat_Melk)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Name = "FrmCalc"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "FrmCalc"
        CType(Me.FSelect_CalcBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_NoSaziDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FSelect_SalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGFSelect_Sal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDFN_GheymatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDFN_GheymatDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DB_NoSaziDataSet As Amlak.DB_NoSaziDataSet
    Friend WithEvents FSelect_CalcBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FSelect_CalcTableAdapter As Amlak.DB_NoSaziDataSetTableAdapters.FSelect_CalcTableAdapter
    Friend WithEvents TableAdapterManager As Amlak.DB_NoSaziDataSetTableAdapters.TableAdapterManager
    Friend WithEvents lblMasahat_Melk As System.Windows.Forms.Label
    Friend WithEvents lblTedad_Bar As System.Windows.Forms.Label
    Friend WithEvents lblRah_Mostaghel As System.Windows.Forms.Label
    Friend WithEvents lblMeydan As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FSelect_SalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Code_BlockToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Code_BlockToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents DGFSelect_Sal As System.Windows.Forms.DataGridView
    Friend WithEvents FSelect_SalTableAdapter As Amlak.DB_NoSaziDataSetTableAdapters.FSelect_SalTableAdapter
    Friend WithEvents txtSharh As TextualControl.TextualControl
    Friend WithEvents TblDFN_GheymatTableAdapter As Amlak.DB_NoSaziDataSetTableAdapters.TblDFN_GheymatTableAdapter
    Friend WithEvents TblDFN_GheymatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblDFN_GheymatDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
