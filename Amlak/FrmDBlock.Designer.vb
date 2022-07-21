<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDBlock
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
        Dim CodeLabel As System.Windows.Forms.Label
        Dim SharhLabel As System.Windows.Forms.Label
        Dim ShomalLabel As System.Windows.Forms.Label
        Dim SharghLabel As System.Windows.Forms.Label
        Dim JonoubLabel As System.Windows.Forms.Label
        Dim GharbLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.txtCode = New TextualControl.TextualControl
        Me.txtSharh = New TextualControl.TextualControl
        Me.txtJonoub = New System.Windows.Forms.TextBox
        Me.txtShargh = New System.Windows.Forms.TextBox
        Me.txtShomal = New System.Windows.Forms.TextBox
        Me.txtGharb = New System.Windows.Forms.TextBox
        Me.BtnGheymat = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.txtCode3Raghami = New TextualControl.TextualControl
        Me.btnView = New System.Windows.Forms.Button
        Me.DB_NoSaziDataSet = New Amlak.DB_NoSaziDataSet
        Me.SelectDFNBLOCKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Select_DFN_BLOCKTableAdapter = New Amlak.DB_NoSaziDataSetTableAdapters.Select_DFN_BLOCKTableAdapter
        CodeLabel = New System.Windows.Forms.Label
        SharhLabel = New System.Windows.Forms.Label
        ShomalLabel = New System.Windows.Forms.Label
        SharghLabel = New System.Windows.Forms.Label
        JonoubLabel = New System.Windows.Forms.Label
        GharbLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        CType(Me.DB_NoSaziDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectDFNBLOCKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodeLabel
        '
        CodeLabel.AutoSize = True
        CodeLabel.Location = New System.Drawing.Point(687, 26)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(43, 13)
        CodeLabel.TabIndex = 1
        CodeLabel.Text = "کد بلوک"
        '
        'SharhLabel
        '
        SharhLabel.AutoSize = True
        SharhLabel.Location = New System.Drawing.Point(339, 26)
        SharhLabel.Name = "SharhLabel"
        SharhLabel.Size = New System.Drawing.Size(55, 13)
        SharhLabel.TabIndex = 3
        SharhLabel.Text = "شرح بلوک"
        '
        'ShomalLabel
        '
        ShomalLabel.AutoSize = True
        ShomalLabel.Location = New System.Drawing.Point(695, 56)
        ShomalLabel.Name = "ShomalLabel"
        ShomalLabel.Size = New System.Drawing.Size(35, 13)
        ShomalLabel.TabIndex = 5
        ShomalLabel.Text = "شمالا"
        '
        'SharghLabel
        '
        SharghLabel.AutoSize = True
        SharghLabel.Location = New System.Drawing.Point(699, 150)
        SharghLabel.Name = "SharghLabel"
        SharghLabel.Size = New System.Drawing.Size(31, 13)
        SharghLabel.TabIndex = 7
        SharghLabel.Text = "شرقا"
        '
        'JonoubLabel
        '
        JonoubLabel.AutoSize = True
        JonoubLabel.Location = New System.Drawing.Point(701, 244)
        JonoubLabel.Name = "JonoubLabel"
        JonoubLabel.Size = New System.Drawing.Size(29, 13)
        JonoubLabel.TabIndex = 9
        JonoubLabel.Text = "جنوبا"
        '
        'GharbLabel
        '
        GharbLabel.AutoSize = True
        GharbLabel.Location = New System.Drawing.Point(705, 338)
        GharbLabel.Name = "GharbLabel"
        GharbLabel.Size = New System.Drawing.Size(25, 13)
        GharbLabel.TabIndex = 11
        GharbLabel.Text = "غربا"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(503, 26)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(68, 13)
        Label1.TabIndex = 1
        Label1.Text = "کد سه رقمی"
        '
        'txtCode
        '
        Me.txtCode.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCode.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtCode.DefaultColor = System.Drawing.Color.Empty
        Me.txtCode.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtCode.Location = New System.Drawing.Point(581, 23)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCode.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtCode.Size = New System.Drawing.Size(100, 21)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Type = TextualControl.TextualControl.No.Numeric
        Me.txtCode.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtCode.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'txtSharh
        '
        Me.txtSharh.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSharh.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtSharh.DefaultColor = System.Drawing.Color.Empty
        Me.txtSharh.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtSharh.Location = New System.Drawing.Point(60, 23)
        Me.txtSharh.Name = "txtSharh"
        Me.txtSharh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSharh.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtSharh.Size = New System.Drawing.Size(273, 21)
        Me.txtSharh.TabIndex = 2
        Me.txtSharh.Type = TextualControl.TextualControl.No.Normal
        Me.txtSharh.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtSharh.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'txtJonoub
        '
        Me.txtJonoub.Location = New System.Drawing.Point(60, 241)
        Me.txtJonoub.Multiline = True
        Me.txtJonoub.Name = "txtJonoub"
        Me.txtJonoub.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtJonoub.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJonoub.Size = New System.Drawing.Size(621, 88)
        Me.txtJonoub.TabIndex = 5
        '
        'txtShargh
        '
        Me.txtShargh.Location = New System.Drawing.Point(60, 147)
        Me.txtShargh.Multiline = True
        Me.txtShargh.Name = "txtShargh"
        Me.txtShargh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtShargh.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtShargh.Size = New System.Drawing.Size(621, 88)
        Me.txtShargh.TabIndex = 4
        '
        'txtShomal
        '
        Me.txtShomal.Location = New System.Drawing.Point(60, 53)
        Me.txtShomal.Multiline = True
        Me.txtShomal.Name = "txtShomal"
        Me.txtShomal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtShomal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtShomal.Size = New System.Drawing.Size(621, 88)
        Me.txtShomal.TabIndex = 3
        '
        'txtGharb
        '
        Me.txtGharb.Location = New System.Drawing.Point(60, 335)
        Me.txtGharb.Multiline = True
        Me.txtGharb.Name = "txtGharb"
        Me.txtGharb.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtGharb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGharb.Size = New System.Drawing.Size(621, 88)
        Me.txtGharb.TabIndex = 6
        '
        'BtnGheymat
        '
        Me.BtnGheymat.Location = New System.Drawing.Point(263, 429)
        Me.BtnGheymat.Name = "BtnGheymat"
        Me.BtnGheymat.Size = New System.Drawing.Size(75, 35)
        Me.BtnGheymat.TabIndex = 13
        Me.BtnGheymat.TabStop = False
        Me.BtnGheymat.Text = "تعریف قیمتها"
        Me.BtnGheymat.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(182, 429)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 35)
        Me.BtnSave.TabIndex = 13
        Me.BtnSave.TabStop = False
        Me.BtnSave.Text = "ذخیره"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(101, 429)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 35)
        Me.BtnCancel.TabIndex = 13
        Me.BtnCancel.TabStop = False
        Me.BtnCancel.Text = "انصراف"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'txtCode3Raghami
        '
        Me.txtCode3Raghami.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCode3Raghami.ColorFocuse = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtCode3Raghami.DefaultColor = System.Drawing.Color.Empty
        Me.txtCode3Raghami.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtCode3Raghami.Location = New System.Drawing.Point(397, 23)
        Me.txtCode3Raghami.Name = "txtCode3Raghami"
        Me.txtCode3Raghami.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCode3Raghami.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.Yes
        Me.txtCode3Raghami.Size = New System.Drawing.Size(100, 21)
        Me.txtCode3Raghami.TabIndex = 1
        Me.txtCode3Raghami.Type = TextualControl.TextualControl.No.Numeric
        Me.txtCode3Raghami.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtCode3Raghami.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(344, 429)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(77, 35)
        Me.btnView.TabIndex = 13
        Me.btnView.TabStop = False
        Me.btnView.Text = "لیست بلوکها"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'DB_NoSaziDataSet
        '
        Me.DB_NoSaziDataSet.DataSetName = "DB_NoSaziDataSet"
        Me.DB_NoSaziDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SelectDFNBLOCKBindingSource
        '
        Me.SelectDFNBLOCKBindingSource.DataMember = "Select_DFN_BLOCK"
        Me.SelectDFNBLOCKBindingSource.DataSource = Me.DB_NoSaziDataSet
        '
        'Select_DFN_BLOCKTableAdapter
        '
        Me.Select_DFN_BLOCKTableAdapter.ClearBeforeFill = True
        '
        'FrmDBlock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(754, 476)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.BtnGheymat)
        Me.Controls.Add(Label1)
        Me.Controls.Add(CodeLabel)
        Me.Controls.Add(Me.txtCode3Raghami)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(SharhLabel)
        Me.Controls.Add(Me.txtSharh)
        Me.Controls.Add(ShomalLabel)
        Me.Controls.Add(Me.txtJonoub)
        Me.Controls.Add(SharghLabel)
        Me.Controls.Add(Me.txtShargh)
        Me.Controls.Add(JonoubLabel)
        Me.Controls.Add(Me.txtShomal)
        Me.Controls.Add(GharbLabel)
        Me.Controls.Add(Me.txtGharb)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDBlock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تعریف بلوک"
        CType(Me.DB_NoSaziDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectDFNBLOCKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCode As TextualControl.TextualControl
    Friend WithEvents txtSharh As TextualControl.TextualControl
    Friend WithEvents txtJonoub As System.Windows.Forms.TextBox
    Friend WithEvents txtShargh As System.Windows.Forms.TextBox
    Friend WithEvents txtShomal As System.Windows.Forms.TextBox
    Friend WithEvents txtGharb As System.Windows.Forms.TextBox
    Friend WithEvents BtnGheymat As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents txtCode3Raghami As TextualControl.TextualControl
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents SelectDFNBLOCKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DB_NoSaziDataSet As Amlak.DB_NoSaziDataSet
    Friend WithEvents Select_DFN_BLOCKTableAdapter As Amlak.DB_NoSaziDataSetTableAdapters.Select_DFN_BLOCKTableAdapter
End Class
