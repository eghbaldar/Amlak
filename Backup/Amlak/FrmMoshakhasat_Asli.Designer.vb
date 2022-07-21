<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMoshakhasat_Asli
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
        Me.txtTedad_Malek = New TextualControl.TextualControl
        Me.SuspendLayout()
        '
        'txtTedad_Malek
        '
        Me.txtTedad_Malek.CharNotLoop = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTedad_Malek.ColorFocuse = System.Drawing.Color.Empty
        Me.txtTedad_Malek.DefaultColor = System.Drawing.Color.Empty
        Me.txtTedad_Malek.Language = TextualControl.TextualControl.Zaban.Persian
        Me.txtTedad_Malek.Location = New System.Drawing.Point(476, 135)
        Me.txtTedad_Malek.Name = "txtTedad_Malek"
        Me.txtTedad_Malek.SelectAllFocuse = TextualControl.TextualControl.SelectAllText.No
        Me.txtTedad_Malek.Size = New System.Drawing.Size(100, 20)
        Me.txtTedad_Malek.TabIndex = 6
        Me.txtTedad_Malek.Type = TextualControl.TextualControl.No.Numeric
        Me.txtTedad_Malek.Type_Poli = TextualControl.TextualControl.Poli.None
        Me.txtTedad_Malek.ValidationEmpty = TextualControl.TextualControl.Enable.GheyrFaal
        '
        'FrmMoshakhasat_Asli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 431)
        Me.Controls.Add(Me.txtTedad_Malek)
        Me.Name = "FrmMoshakhasat_Asli"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "FrmMoshakhasat_Asli"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTedad_Malek As TextualControl.TextualControl
End Class
