Public Class PlayerForm
    Private Sub Preload()
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.playinglabel.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub PlayerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Preload()
        ListVST_DLL()
        MainWin.Audio.PlayFile(OpenFileDialog1.FileName)
        MainWin.Audio.ChangeDevice(My.Settings.audio_device)
    End Sub

    Private Sub PlayerForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MainWin.Audio.PauseChannel()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.ValueChanged
        MainWin.Audio.SetVolumeChannel(TrackBar1.Value)
        MainWin.LogBox.Text = Bass.BASS_GetVolume()
    End Sub

    Private Sub TrackBar1_Scroll_1(sender As Object, e As EventArgs) Handles TrackBar1.Scroll

    End Sub

    Private Sub TrackBar1_MouseUp(sender As Object, e As MouseEventArgs) Handles TrackBar1.MouseUp
        MsgBox(TrackBar1.Value & vbCrLf & Bass.BASS_ErrorGetCode() & vbCrLf & Bass.BASS_GetVolume())
    End Sub

    Public Sub ListVST_DLL()
        For Each f In IO.Directory.GetFiles(My.Settings.VST_folder)
            If f.Split(".")(1) = "dll" Then
                Dim subf = f.Split("\")
                Me.ComboBox1.Items.Add(subf(subf.Length - 1))
            End If
        Next
    End Sub

    Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged

        MainWin.Audio.ShowVSTEd(My.Settings.VST_folder & "\" & ComboBox1.SelectedItem, MainWin)
    End Sub
End Class