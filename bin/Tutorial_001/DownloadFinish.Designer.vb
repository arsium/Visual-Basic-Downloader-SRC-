<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DownloadFinish
    Inherits MetroSet_UI.Forms.MetroSetForm

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MetroSetLabel1 = New MetroSet_UI.Controls.MetroSetLabel()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button2.ForeColor = System.Drawing.SystemColors.Window
        Me.Button2.Location = New System.Drawing.Point(205, 50)
        Me.Button2.Margin = New System.Windows.Forms.Padding(1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 26)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Ok"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'MetroSetLabel1
        '
        Me.MetroSetLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroSetLabel1.Location = New System.Drawing.Point(4, 50)
        Me.MetroSetLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroSetLabel1.Name = "MetroSetLabel1"
        Me.MetroSetLabel1.Size = New System.Drawing.Size(189, 26)
        Me.MetroSetLabel1.Style = MetroSet_UI.Design.Style.Dark
        Me.MetroSetLabel1.StyleManager = Nothing
        Me.MetroSetLabel1.TabIndex = 2
        Me.MetroSetLabel1.Text = "The file has been saved !"
        Me.MetroSetLabel1.ThemeAuthor = "Narwin"
        Me.MetroSetLabel1.ThemeName = "MetroDark"
        '
        'DownloadFinish
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(339, 111)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroSetLabel1)
        Me.Controls.Add(Me.Button2)
        Me.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "DownloadFinish"
        Me.Padding = New System.Windows.Forms.Padding(2, 60, 2, 2)
        Me.ShowHeader = True
        Me.ShowLeftRect = False
        Me.SmallLineColor1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.SmallLineColor2 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Style = MetroSet_UI.Design.Style.Dark
        Me.Text = "FILE(S) DOWNLOADED !"
        Me.TextAlign = MetroSet_UI.Design.TextAlign.Center
        Me.TextColor = System.Drawing.Color.White
        Me.ThemeAuthor = "ddddd"
        Me.ThemeName = "MetroDark"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents MetroSetLabel1 As MetroSet_UI.Controls.MetroSetLabel
End Class
