Public Class DownloadFinish
    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TuT_1.DownloadProgress.Value = 100% Then
            TuT_1.DownloadProgress.Value = 0
            TuT_1.DonwloadProgressText.Text = "Progress:"
            TuT_1.BunifuButton1.ButtonText = "Download My Tools"
            TuT_1.BunifuButton1.Enabled = True
            Me.Close()
        End If
    End Sub
End Class