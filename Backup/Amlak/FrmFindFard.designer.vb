<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFindFard
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TxtName = New System.Windows.Forms.TextBox
        Me.TxtShomareM = New System.Windows.Forms.TextBox
        Me.BtnOK = New System.Windows.Forms.Button
        Me.GBoxFard = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TMnuGFard = New System.Windows.Forms.StatusStrip
        Me.TLblVasaiel = New System.Windows.Forms.ToolStripStatusLabel
        Me.TLblEblagh = New System.Windows.Forms.ToolStripStatusLabel
        Me.TLblDash = New System.Windows.Forms.ToolStripStatusLabel
        Me.TLblNumBed = New System.Windows.Forms.ToolStripStatusLabel
        Me.TLblTextBed = New System.Windows.Forms.ToolStripStatusLabel
        Me.DGridFFard = New System.Windows.Forms.DataGridView
        Me.ClmName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClmShomareM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GBoxFard.SuspendLayout()
        Me.TMnuGFard.SuspendLayout()
        CType(Me.DGridFFard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(491, 12)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(169, 21)
        Me.TxtName.TabIndex = 7
        '
        'TxtShomareM
        '
        Me.TxtShomareM.Location = New System.Drawing.Point(229, 12)
        Me.TxtShomareM.Name = "TxtShomareM"
        Me.TxtShomareM.Size = New System.Drawing.Size(169, 21)
        Me.TxtShomareM.TabIndex = 9
        '
        'BtnOK
        '
        Me.BtnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnOK.Location = New System.Drawing.Point(16, 12)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(76, 33)
        Me.BtnOK.TabIndex = 32
        Me.BtnOK.Text = "ذخیره"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'GBoxFard
        '
        Me.GBoxFard.Controls.Add(Me.Label4)
        Me.GBoxFard.Controls.Add(Me.Label1)
        Me.GBoxFard.Controls.Add(Me.BtnOK)
        Me.GBoxFard.Controls.Add(Me.TxtShomareM)
        Me.GBoxFard.Controls.Add(Me.TxtName)
        Me.GBoxFard.Location = New System.Drawing.Point(11, 1)
        Me.GBoxFard.Name = "GBoxFard"
        Me.GBoxFard.Size = New System.Drawing.Size(742, 70)
        Me.GBoxFard.TabIndex = 33
        Me.GBoxFard.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(405, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "شماره ملی:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(666, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "نام خانوادگی:"
        '
        'TMnuGFard
        '
        Me.TMnuGFard.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TLblVasaiel, Me.TLblEblagh, Me.TLblDash, Me.TLblNumBed, Me.TLblTextBed})
        Me.TMnuGFard.Location = New System.Drawing.Point(0, 324)
        Me.TMnuGFard.Name = "TMnuGFard"
        Me.TMnuGFard.Size = New System.Drawing.Size(764, 22)
        Me.TMnuGFard.TabIndex = 35
        '
        'TLblVasaiel
        '
        Me.TLblVasaiel.Name = "TLblVasaiel"
        Me.TLblVasaiel.Size = New System.Drawing.Size(134, 17)
        Me.TLblVasaiel.Text = "تعداد وسایل تعریف شده : 1"
        '
        'TLblEblagh
        '
        Me.TLblEblagh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TLblEblagh.Name = "TLblEblagh"
        Me.TLblEblagh.Size = New System.Drawing.Size(143, 17)
        Me.TLblEblagh.Text = "تعداد ابلاغیه در سال جاری : 2"
        '
        'TLblDash
        '
        Me.TLblDash.Name = "TLblDash"
        Me.TLblDash.Size = New System.Drawing.Size(291, 17)
        Me.TLblDash.Spring = True
        Me.TLblDash.Text = "-"
        '
        'TLblNumBed
        '
        Me.TLblNumBed.Name = "TLblNumBed"
        Me.TLblNumBed.Size = New System.Drawing.Size(85, 17)
        Me.TLblNumBed.Text = "بدهی : 800.000"
        '
        'TLblTextBed
        '
        Me.TLblTextBed.Name = "TLblTextBed"
        Me.TLblTextBed.Size = New System.Drawing.Size(96, 17)
        Me.TLblTextBed.Text = "هشتصد هزار تومان"
        '
        'DGridFFard
        '
        Me.DGridFFard.AllowUserToAddRows = False
        Me.DGridFFard.AllowUserToDeleteRows = False
        Me.DGridFFard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGridFFard.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClmName, Me.Column1, Me.ClmShomareM})
        Me.DGridFFard.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGridFFard.Location = New System.Drawing.Point(0, 96)
        Me.DGridFFard.Name = "DGridFFard"
        Me.DGridFFard.ReadOnly = True
        Me.DGridFFard.Size = New System.Drawing.Size(764, 228)
        Me.DGridFFard.TabIndex = 36
        '
        'ClmName
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ClmName.DefaultCellStyle = DataGridViewCellStyle1
        Me.ClmName.HeaderText = " نام"
        Me.ClmName.Name = "ClmName"
        Me.ClmName.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "نام خانوادگی"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 176
        '
        'ClmShomareM
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ClmShomareM.DefaultCellStyle = DataGridViewCellStyle2
        Me.ClmShomareM.HeaderText = "شماره ملی"
        Me.ClmShomareM.Name = "ClmShomareM"
        Me.ClmShomareM.ReadOnly = True
        Me.ClmShomareM.Width = 200
        '
        'FrmFindFard
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(764, 346)
        Me.Controls.Add(Me.DGridFFard)
        Me.Controls.Add(Me.TMnuGFard)
        Me.Controls.Add(Me.GBoxFard)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "FrmFindFard"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "جستجوی افراد"
        Me.GBoxFard.ResumeLayout(False)
        Me.GBoxFard.PerformLayout()
        Me.TMnuGFard.ResumeLayout(False)
        Me.TMnuGFard.PerformLayout()
        CType(Me.DGridFFard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents TxtShomareM As System.Windows.Forms.TextBox
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents GBoxFard As System.Windows.Forms.GroupBox
    Friend WithEvents TMnuGFard As System.Windows.Forms.StatusStrip
    Friend WithEvents TLblVasaiel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TLblEblagh As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TLblDash As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TLblNumBed As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TLblTextBed As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents DGridFFard As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ClmName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClmShomareM As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
