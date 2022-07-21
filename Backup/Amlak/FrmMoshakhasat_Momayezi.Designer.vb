<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMoshakhasat_Momayezi
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboVazeiyat_Momayezi = New System.Windows.Forms.ComboBox
        Me.SelectDFNsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_NoSaziDataSet = New Amlak.DB_NoSaziDataSet
        Me.txtTarikh_Momayezi = New TextualControl.TextualControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Select_DFNsTableAdapter = New Amlak.DB_NoSaziDataSetTableAdapters.Select_DFNsTableAdapter
        Me.lblSHsh = New System.Windows.Forms.Label
        Me.SelectTblMomayeziBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Select_Tbl_MomayeziTableAdapter = New Amlak.DB_NoSaziDataSetTableAdapters.Select_Tbl_MomayeziTableAdapter
        Me.GroupBox1.SuspendLayout()
        CType(Me.SelectDFNsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_NoSaziDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectTblMomayeziBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(395, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "شماره شناسنامه زمین"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboVazeiyat_Momayezi)
        Me.GroupBox1.Controls.Add(Me.txtTarikh_Momayezi)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 48)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'cboVazeiyat_Momayezi
        '
        Me.cboVazeiyat_Momayezi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboVazeiyat_Momayezi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboVazeiyat_Momayezi.DataSource = Me.SelectDFNsBindingSource
        Me.cboVazeiyat_Momayezi.DisplayMember = "name"
        Me.cboVazeiyat_Momayezi.FormattingEnabled = True
        Me.cboVazeiyat_Momayezi.Location = New System.Drawing.Point(20, 14)
        Me.cboVazeiyat_Momayezi.Name = "cboVazeiyat_Momayezi"
        Me.cboVazeiyat_Momayezi.Size = New System.Drawing.Size(153, 21)
        Me.cboVazeiyat_Momayezi.TabIndex = 1
        Me.cboVazeiyat_Momayezi.ValueMember = "code"
        '
        'SelectDFNsBindingSource
        '
        Me.SelectDFNsBindingSource.DataMember = "Select_DFNs"
        Me.SelectDFNsBindingSource.DataSource = Me.DB_NoSaziDataSet
        '
        'DB_NoSaziDataSet
        '
        Me.DB_NoSaziDataSet.DataSetName = "DB_NoSaziDataSet"
        Me.DB_NoSaziDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtTarikh_Momayezi
        '
        Me.txtTarikh_Momayezi.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTarikh_Momayezi.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTarikh_Momayezi.DefaultColor = System.Drawing.Color.Empty
        Me.txtTarikh_Momayezi.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtTarikh_Momayezi.Location = New System.Drawing.Point(319, 14)
        Me.txtTarikh_Momayezi.Name = "txtTarikh_Momayezi"
        Me.txtTarikh_Momayezi.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtTarikh_Momayezi.Size = New System.Drawing.Size(100, 21)
        Me.txtTarikh_Momayezi.TabIndex = 0
        Me.txtTarikh_Momayezi.Type = TextualControl.TextualControl.No.Normal
        Me.txtTarikh_Momayezi.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtTarikh_Momayezi.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(179, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "وضعیت برگ ممیزی"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(425, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "تاریخ ممیزی"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(112, 93)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(91, 39)
        Me.btnOK.TabIndex = 25
        Me.btnOK.TabStop = False
        Me.btnOK.Text = "ذخیره"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(15, 93)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 39)
        Me.btnCancel.TabIndex = 24
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "انصراف"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Select_DFNsTableAdapter
        '
        Me.Select_DFNsTableAdapter.ClearBeforeFill = True
        '
        'lblSHsh
        '
        Me.lblSHsh.AutoSize = True
        Me.lblSHsh.Location = New System.Drawing.Point(276, 15)
        Me.lblSHsh.Name = "lblSHsh"
        Me.lblSHsh.Size = New System.Drawing.Size(113, 13)
        Me.lblSHsh.TabIndex = 5
        Me.lblSHsh.Text = "شماره شناسنامه زمین"
        '
        'SelectTblMomayeziBindingSource
        '
        Me.SelectTblMomayeziBindingSource.DataMember = "Select_Tbl_Momayezi"
        Me.SelectTblMomayeziBindingSource.DataSource = Me.DB_NoSaziDataSet
        '
        'Select_Tbl_MomayeziTableAdapter
        '
        Me.Select_Tbl_MomayeziTableAdapter.ClearBeforeFill = True
        '
        'FrmMoshakhasat_Momayezi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(523, 144)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblSHsh)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMoshakhasat_Momayezi"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ممیزی"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SelectDFNsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_NoSaziDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectTblMomayeziBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboVazeiyat_Momayezi As System.Windows.Forms.ComboBox
    Friend WithEvents txtTarikh_Momayezi As TextualControl.TextualControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents SelectDFNsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DB_NoSaziDataSet As Amlak.DB_NoSaziDataSet
    Friend WithEvents Select_DFNsTableAdapter As Amlak.DB_NoSaziDataSetTableAdapters.Select_DFNsTableAdapter
    Friend WithEvents lblSHsh As System.Windows.Forms.Label
    Friend WithEvents SelectTblMomayeziBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Select_Tbl_MomayeziTableAdapter As Amlak.DB_NoSaziDataSetTableAdapters.Select_Tbl_MomayeziTableAdapter
End Class
