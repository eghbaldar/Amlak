<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMahiyat_Fiziki
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkBayer = New System.Windows.Forms.CheckBox
        Me.chkBayerMahsour = New System.Windows.Forms.CheckBox
        Me.chkMoshajjar = New System.Windows.Forms.CheckBox
        Me.chkMazrouei = New System.Windows.Forms.CheckBox
        Me.chkBagh = New System.Windows.Forms.CheckBox
        Me.chkSakhteman_NimehTamam = New System.Windows.Forms.CheckBox
        Me.chkSakhteman_Tmam = New System.Windows.Forms.CheckBox
        Me.chkSayer = New System.Windows.Forms.CheckBox
        Me.GMahiyat = New System.Windows.Forms.GroupBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.lblSHsh = New System.Windows.Forms.Label
        Me.GMahiyat.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(288, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "شماره شناسنامه زمین"
        '
        'chkBayer
        '
        Me.chkBayer.AutoSize = True
        Me.chkBayer.Location = New System.Drawing.Point(307, 20)
        Me.chkBayer.Name = "chkBayer"
        Me.chkBayer.Size = New System.Drawing.Size(65, 17)
        Me.chkBayer.TabIndex = 0
        Me.chkBayer.Tag = "300"
        Me.chkBayer.Text = "زمین بایر"
        Me.chkBayer.UseVisualStyleBackColor = True
        '
        'chkBayerMahsour
        '
        Me.chkBayerMahsour.AutoSize = True
        Me.chkBayerMahsour.Location = New System.Drawing.Point(151, 19)
        Me.chkBayerMahsour.Name = "chkBayerMahsour"
        Me.chkBayerMahsour.Size = New System.Drawing.Size(99, 17)
        Me.chkBayerMahsour.TabIndex = 1
        Me.chkBayerMahsour.Tag = "301"
        Me.chkBayerMahsour.Text = "زمین بایر محصور"
        Me.chkBayerMahsour.UseVisualStyleBackColor = True
        '
        'chkMoshajjar
        '
        Me.chkMoshajjar.AutoSize = True
        Me.chkMoshajjar.Location = New System.Drawing.Point(44, 19)
        Me.chkMoshajjar.Name = "chkMoshajjar"
        Me.chkMoshajjar.Size = New System.Drawing.Size(81, 17)
        Me.chkMoshajjar.TabIndex = 2
        Me.chkMoshajjar.Tag = "302"
        Me.chkMoshajjar.Text = "زمین مشجر"
        Me.chkMoshajjar.UseVisualStyleBackColor = True
        '
        'chkMazrouei
        '
        Me.chkMazrouei.AutoSize = True
        Me.chkMazrouei.Location = New System.Drawing.Point(283, 37)
        Me.chkMazrouei.Name = "chkMazrouei"
        Me.chkMazrouei.Size = New System.Drawing.Size(89, 17)
        Me.chkMazrouei.TabIndex = 3
        Me.chkMazrouei.Tag = "303"
        Me.chkMazrouei.Text = "زمین مزروعی"
        Me.chkMazrouei.UseVisualStyleBackColor = True
        '
        'chkBagh
        '
        Me.chkBagh.AutoSize = True
        Me.chkBagh.Location = New System.Drawing.Point(211, 37)
        Me.chkBagh.Name = "chkBagh"
        Me.chkBagh.Size = New System.Drawing.Size(39, 17)
        Me.chkBagh.TabIndex = 4
        Me.chkBagh.Tag = "304"
        Me.chkBagh.Text = "باغ"
        Me.chkBagh.UseVisualStyleBackColor = True
        '
        'chkSakhteman_NimehTamam
        '
        Me.chkSakhteman_NimehTamam.AutoSize = True
        Me.chkSakhteman_NimehTamam.Location = New System.Drawing.Point(11, 37)
        Me.chkSakhteman_NimehTamam.Name = "chkSakhteman_NimehTamam"
        Me.chkSakhteman_NimehTamam.Size = New System.Drawing.Size(114, 17)
        Me.chkSakhteman_NimehTamam.TabIndex = 5
        Me.chkSakhteman_NimehTamam.Tag = "305"
        Me.chkSakhteman_NimehTamam.Text = "ساختمان نیمه تمام"
        Me.chkSakhteman_NimehTamam.UseVisualStyleBackColor = True
        '
        'chkSakhteman_Tmam
        '
        Me.chkSakhteman_Tmam.AutoSize = True
        Me.chkSakhteman_Tmam.Location = New System.Drawing.Point(256, 54)
        Me.chkSakhteman_Tmam.Name = "chkSakhteman_Tmam"
        Me.chkSakhteman_Tmam.Size = New System.Drawing.Size(116, 17)
        Me.chkSakhteman_Tmam.TabIndex = 6
        Me.chkSakhteman_Tmam.Tag = "306"
        Me.chkSakhteman_Tmam.Text = "ساختمان تمام شده"
        Me.chkSakhteman_Tmam.UseVisualStyleBackColor = True
        '
        'chkSayer
        '
        Me.chkSayer.AutoSize = True
        Me.chkSayer.Location = New System.Drawing.Point(202, 56)
        Me.chkSayer.Name = "chkSayer"
        Me.chkSayer.Size = New System.Drawing.Size(48, 17)
        Me.chkSayer.TabIndex = 7
        Me.chkSayer.Tag = "307"
        Me.chkSayer.Text = "سایر"
        Me.chkSayer.UseVisualStyleBackColor = True
        '
        'GMahiyat
        '
        Me.GMahiyat.Controls.Add(Me.chkBagh)
        Me.GMahiyat.Controls.Add(Me.chkBayer)
        Me.GMahiyat.Controls.Add(Me.chkSayer)
        Me.GMahiyat.Controls.Add(Me.chkBayerMahsour)
        Me.GMahiyat.Controls.Add(Me.chkSakhteman_Tmam)
        Me.GMahiyat.Controls.Add(Me.chkMoshajjar)
        Me.GMahiyat.Controls.Add(Me.chkMazrouei)
        Me.GMahiyat.Controls.Add(Me.chkSakhteman_NimehTamam)
        Me.GMahiyat.Location = New System.Drawing.Point(12, 39)
        Me.GMahiyat.Name = "GMahiyat"
        Me.GMahiyat.Size = New System.Drawing.Size(386, 98)
        Me.GMahiyat.TabIndex = 0
        Me.GMahiyat.TabStop = False
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(307, 152)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(91, 39)
        Me.btnOK.TabIndex = 8
        Me.btnOK.TabStop = False
        Me.btnOK.Text = "ذخیره"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(210, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 39)
        Me.Button1.TabIndex = 7
        Me.Button1.TabStop = False
        Me.Button1.Text = "انصراف"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(113, 152)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(91, 39)
        Me.btnNext.TabIndex = 6
        Me.btnNext.TabStop = False
        Me.btnNext.Text = "نوع استفاده"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblSHsh
        '
        Me.lblSHsh.AutoSize = True
        Me.lblSHsh.Location = New System.Drawing.Point(169, 23)
        Me.lblSHsh.Name = "lblSHsh"
        Me.lblSHsh.Size = New System.Drawing.Size(113, 13)
        Me.lblSHsh.TabIndex = 3
        Me.lblSHsh.Text = "شماره شناسنامه زمین"
        '
        'FrmMahiyat_Fiziki
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(421, 223)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.GMahiyat)
        Me.Controls.Add(Me.lblSHsh)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMahiyat_Fiziki"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ماهیت فیزیکی "
        Me.GMahiyat.ResumeLayout(False)
        Me.GMahiyat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkBayer As System.Windows.Forms.CheckBox
    Friend WithEvents chkBayerMahsour As System.Windows.Forms.CheckBox
    Friend WithEvents chkMoshajjar As System.Windows.Forms.CheckBox
    Friend WithEvents chkMazrouei As System.Windows.Forms.CheckBox
    Friend WithEvents chkBagh As System.Windows.Forms.CheckBox
    Friend WithEvents chkSakhteman_NimehTamam As System.Windows.Forms.CheckBox
    Friend WithEvents chkSakhteman_Tmam As System.Windows.Forms.CheckBox
    Friend WithEvents chkSayer As System.Windows.Forms.CheckBox
    Friend WithEvents GMahiyat As System.Windows.Forms.GroupBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblSHsh As System.Windows.Forms.Label
End Class
