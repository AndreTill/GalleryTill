Imports Un4seen.BassAsio
Imports System.ComponentModel

Public Class AudioEngine

    Public devices As String

    Public _vstHandle As Integer = 0

    Dim WithEvents f As vst

    Public Sub ShowVSTEd(dll As String, parentform As Form)
        _vstHandle = BassVst.BASS_VST_ChannelSetDSP(My.Settings.audio_buff, dll, BASSVSTDsp.BASS_VST_DEFAULT, 1)
        ' show the embedded editor
        Dim vstInfo As New BASS_VST_INFO()
        If BassVst.BASS_VST_GetInfo(_vstHandle, vstInfo) AndAlso vstInfo.hasEditor Then
            ' create a new System.Windows.Forms.Form
            f = New vst
            'f.MdiParent = parentform
            f.Width = vstInfo.editorWidth + 4
            f.Height = vstInfo.editorHeight + 34
            f.Text = vstInfo.effectName
            f.Show()
            BassVst.BASS_VST_EmbedEditor(_vstHandle, f.Handle)
        End If
    End Sub
    Private Sub f_Closed(sender As Object, e As CancelEventArgs) Handles f.FormClosing
        ' unembed the VST editor
        BassVst.BASS_VST_ChannelRemoveDSP(2, _vstHandle)
    End Sub

    Public Sub New(freq As Integer, parenthandle As Integer)
        Try
            Bass.LoadMe()
            For i As Integer = 1 To 5
                If Bass.BASS_Init(i, My.Settings.audio_freq, BASSInit.BASS_DEVICE_DEFAULT, parenthandle) Then
                    devices &= i & ","
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Distruct()
        Bass.BASS_Free()
        Bass.FreeMe()
        Bass.BASS_StreamFree(My.Settings.audio_buff)
    End Sub

    Public Sub PlayFile(file As String)
        My.Settings.audio_buff = Bass.BASS_StreamCreateFile(file, 0, 0, BASSFlag.BASS_DEFAULT)
        Bass.BASS_ChannelPlay(My.Settings.audio_buff, True)
    End Sub

    Public Sub ResumeChannel()
        Bass.BASS_ChannelPlay(My.Settings.audio_buff, False)
    End Sub

    Public Sub PauseChannel()
        Bass.BASS_ChannelPause(My.Settings.audio_buff)
    End Sub

    Public Sub SetVolumeChannel(vol As Single)
        Bass.BASS_SetVolume(vol / 10)
    End Sub

    Public Sub ChangeDevice(dev As Integer)
        Bass.BASS_ChannelSetDevice(My.Settings.audio_buff, dev)
    End Sub

    Public Sub OpenVST(dll As String)
        My.Settings.audio_buff = BassVst.BASS_VST_ChannelCreate(My.Settings.audio_freq, 2, dll, BASSFlag.BASS_DEFAULT)
        Bass.BASS_ChannelPlay(My.Settings.audio_buff, False)
    End Sub

End Class
