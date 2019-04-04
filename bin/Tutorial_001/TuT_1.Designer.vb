<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TuT_1
    Inherits MetroSet_UI.Forms.MetroSetForm

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TuT_1))
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.DonwloadProgressText = New System.Windows.Forms.Label()
        Me.DownloadProgress = New System.Windows.Forms.ProgressBar()
        Me.BunifuButton1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.MetroDefaultSetButton3 = New MetroSet_UI.Controls.MetroDefaultSetButton()
        Me.MetroDefaultSetButton2 = New MetroSet_UI.Controls.MetroDefaultSetButton()
        Me.MetroDefaultSetButton1 = New MetroSet_UI.Controls.MetroDefaultSetButton()
        Me.SuspendLayout()
        '
        'DonwloadProgressText
        '
        Me.DonwloadProgressText.AutoSize = True
        Me.DonwloadProgressText.BackColor = System.Drawing.Color.Transparent
        Me.DonwloadProgressText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DonwloadProgressText.ForeColor = System.Drawing.Color.White
        Me.DonwloadProgressText.Location = New System.Drawing.Point(12, 41)
        Me.DonwloadProgressText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DonwloadProgressText.Name = "DonwloadProgressText"
        Me.DonwloadProgressText.Size = New System.Drawing.Size(76, 20)
        Me.DonwloadProgressText.TabIndex = 0
        Me.DonwloadProgressText.Text = "Progress:"
        '
        'DownloadProgress
        '
        Me.DownloadProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DownloadProgress.Location = New System.Drawing.Point(16, 74)
        Me.DownloadProgress.Margin = New System.Windows.Forms.Padding(2)
        Me.DownloadProgress.Name = "DownloadProgress"
        Me.DownloadProgress.Size = New System.Drawing.Size(443, 25)
        Me.DownloadProgress.TabIndex = 1
        '
        'BunifuButton1
        '
        Me.BunifuButton1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.BackgroundImage = CType(resources.GetObject("BunifuButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton1.ButtonText = "Download My Tools"
        Me.BunifuButton1.ButtonTextMarginLeft = 0
        Me.BunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BunifuButton1.DisabledFillColor = System.Drawing.Color.Gray
        Me.BunifuButton1.DisabledForecolor = System.Drawing.Color.White
        Me.BunifuButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconPadding = 10
        Me.BunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BunifuButton1.IdleBorderRadius = 1
        Me.BunifuButton1.IdleBorderThickness = 0
        Me.BunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BunifuButton1.IdleIconLeftImage = Nothing
        Me.BunifuButton1.IdleIconRightImage = Nothing
        Me.BunifuButton1.Location = New System.Drawing.Point(16, 122)
        Me.BunifuButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.BunifuButton1.Name = "BunifuButton1"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties1.BorderRadius = 1
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.BunifuButton1.onHoverState = StateProperties1
        Me.BunifuButton1.Size = New System.Drawing.Size(443, 31)
        Me.BunifuButton1.TabIndex = 2
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroDefaultSetButton3
        '
        Me.MetroDefaultSetButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroDefaultSetButton3.BackColor = System.Drawing.Color.Transparent
        Me.MetroDefaultSetButton3.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MetroDefaultSetButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroDefaultSetButton3.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroDefaultSetButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroDefaultSetButton3.HoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MetroDefaultSetButton3.HoverColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MetroDefaultSetButton3.HoverTextColor = System.Drawing.Color.White
        Me.MetroDefaultSetButton3.Location = New System.Drawing.Point(409, 3)
        Me.MetroDefaultSetButton3.MaximumSize = New System.Drawing.Size(28, 23)
        Me.MetroDefaultSetButton3.MinimumSize = New System.Drawing.Size(28, 23)
        Me.MetroDefaultSetButton3.Name = "MetroDefaultSetButton3"
        Me.MetroDefaultSetButton3.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MetroDefaultSetButton3.NormalColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.MetroDefaultSetButton3.NormalTextColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroDefaultSetButton3.PressBorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MetroDefaultSetButton3.PressColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MetroDefaultSetButton3.PressTextColor = System.Drawing.Color.White
        Me.MetroDefaultSetButton3.Size = New System.Drawing.Size(28, 23)
        Me.MetroDefaultSetButton3.Style = MetroSet_UI.Design.Style.Dark
        Me.MetroDefaultSetButton3.StyleManager = Nothing
        Me.MetroDefaultSetButton3.TabIndex = 5
        Me.MetroDefaultSetButton3.Text = "+"
        Me.MetroDefaultSetButton3.ThemeAuthor = "Narwin"
        Me.MetroDefaultSetButton3.ThemeName = "MetroDark"
        '
        'MetroDefaultSetButton2
        '
        Me.MetroDefaultSetButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroDefaultSetButton2.BackColor = System.Drawing.Color.Transparent
        Me.MetroDefaultSetButton2.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MetroDefaultSetButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroDefaultSetButton2.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroDefaultSetButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroDefaultSetButton2.HoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MetroDefaultSetButton2.HoverColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MetroDefaultSetButton2.HoverTextColor = System.Drawing.Color.White
        Me.MetroDefaultSetButton2.Location = New System.Drawing.Point(375, 3)
        Me.MetroDefaultSetButton2.MaximumSize = New System.Drawing.Size(28, 23)
        Me.MetroDefaultSetButton2.MinimumSize = New System.Drawing.Size(28, 23)
        Me.MetroDefaultSetButton2.Name = "MetroDefaultSetButton2"
        Me.MetroDefaultSetButton2.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MetroDefaultSetButton2.NormalColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.MetroDefaultSetButton2.NormalTextColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroDefaultSetButton2.PressBorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MetroDefaultSetButton2.PressColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MetroDefaultSetButton2.PressTextColor = System.Drawing.Color.White
        Me.MetroDefaultSetButton2.Size = New System.Drawing.Size(28, 23)
        Me.MetroDefaultSetButton2.Style = MetroSet_UI.Design.Style.Dark
        Me.MetroDefaultSetButton2.StyleManager = Nothing
        Me.MetroDefaultSetButton2.TabIndex = 6
        Me.MetroDefaultSetButton2.Text = "-"
        Me.MetroDefaultSetButton2.ThemeAuthor = "Narwin"
        Me.MetroDefaultSetButton2.ThemeName = "MetroDark"
        '
        'MetroDefaultSetButton1
        '
        Me.MetroDefaultSetButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroDefaultSetButton1.BackColor = System.Drawing.Color.Transparent
        Me.MetroDefaultSetButton1.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.MetroDefaultSetButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroDefaultSetButton1.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroDefaultSetButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroDefaultSetButton1.HoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MetroDefaultSetButton1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MetroDefaultSetButton1.HoverTextColor = System.Drawing.Color.White
        Me.MetroDefaultSetButton1.Location = New System.Drawing.Point(443, 3)
        Me.MetroDefaultSetButton1.MaximumSize = New System.Drawing.Size(28, 23)
        Me.MetroDefaultSetButton1.MinimumSize = New System.Drawing.Size(28, 23)
        Me.MetroDefaultSetButton1.Name = "MetroDefaultSetButton1"
        Me.MetroDefaultSetButton1.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MetroDefaultSetButton1.NormalColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.MetroDefaultSetButton1.NormalTextColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroDefaultSetButton1.PressBorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MetroDefaultSetButton1.PressColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MetroDefaultSetButton1.PressTextColor = System.Drawing.Color.White
        Me.MetroDefaultSetButton1.Size = New System.Drawing.Size(28, 23)
        Me.MetroDefaultSetButton1.Style = MetroSet_UI.Design.Style.Dark
        Me.MetroDefaultSetButton1.StyleManager = Nothing
        Me.MetroDefaultSetButton1.TabIndex = 7
        Me.MetroDefaultSetButton1.Text = "X"
        Me.MetroDefaultSetButton1.ThemeAuthor = "Narwin"
        Me.MetroDefaultSetButton1.ThemeName = "MetroDark"
        '
        'TuT_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(476, 223)
        Me.Controls.Add(Me.MetroDefaultSetButton1)
        Me.Controls.Add(Me.MetroDefaultSetButton2)
        Me.Controls.Add(Me.BunifuButton1)
        Me.Controls.Add(Me.MetroDefaultSetButton3)
        Me.Controls.Add(Me.DownloadProgress)
        Me.Controls.Add(Me.DonwloadProgressText)
        Me.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TuT_1"
        Me.Padding = New System.Windows.Forms.Padding(2, 60, 2, 2)
        Me.ShowHeader = True
        Me.ShowLeftRect = False
        Me.SmallLineColor1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.SmallLineColor2 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Style = MetroSet_UI.Design.Style.Custom
        Me.Text = "DOWNLOAD"
        Me.TextAlign = MetroSet_UI.Design.TextAlign.Center
        Me.TextColor = System.Drawing.Color.White
        Me.ThemeAuthor = "dddd"
        Me.ThemeName = "MetroDark"
        Me.UseSlideAnimation = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DonwloadProgressText As System.Windows.Forms.Label
    Friend WithEvents DownloadProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents MetroDefaultSetButton3 As MetroSet_UI.Controls.MetroDefaultSetButton
    Friend WithEvents MetroDefaultSetButton2 As MetroSet_UI.Controls.MetroDefaultSetButton
    Friend WithEvents MetroDefaultSetButton1 As MetroSet_UI.Controls.MetroDefaultSetButton
End Class
