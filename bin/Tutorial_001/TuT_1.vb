Imports System.Net
Public Class TuT_1
    Dim WithEvents WC As New WebClient
    ' Private Sub TuT_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    WC.DownloadFileAsync(New Uri("DownloadLink"), My.Computer.FileSystem.CurrentDirectory)
    '  End Sub
    Public Sub WC_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles WC.DownloadProgressChanged
        DownloadProgress.Value = e.ProgressPercentage
        DonwloadProgressText.Text = "Progress:" & e.ProgressPercentage & "%" & "(" & e.BytesReceived & "/" & e.TotalBytesToReceive & ")"

        If DownloadProgress.Value = 100% Then
            DownloadFinish.Show()
        End If
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Using save As New SaveFileDialog
            With save
                .AddExtension = True
        .FileName = "Name of the file"
                .DefaultExt = ".zip"
                .FilterIndex = 1
                .Filter = "Zip File (*.zip)|*.zip"
                .InitialDirectory = My.Computer.FileSystem.CurrentDirectory
                .Title = "Save Downloaded File"
                .ValidateNames = True
            End With
            If save.ShowDialog = DialogResult.OK Then
    WC.DownloadFileAsync(New Uri("YOURDIRECTLINK"), save.FileName, False)
                BunifuButton1.Enabled = False
                BunifuButton1.ButtonText = "Download In Progress"
            End If
        End Using
    End Sub
    Private Sub MetroDefaultSetButton3_Click(sender As Object, e As EventArgs) Handles MetroDefaultSetButton3.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub MetroDefaultSetButton2_Click(sender As Object, e As EventArgs) Handles MetroDefaultSetButton2.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub MetroDefaultSetButton1_Click_1(sender As Object, e As EventArgs) Handles MetroDefaultSetButton1.Click
        If MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Application.ExitThread()
        End If
    End Sub
End Class
