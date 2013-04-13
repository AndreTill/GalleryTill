Public Class vst

    Private Sub vst_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub vst_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        Dim vstInfo As New BASS_VST_INFO()
        BassVst.BASS_VST_GetInfo(MainWin.Audio._vstHandle, vstInfo)
        Me.Width = vstInfo.editorWidth + 4
        Me.Height = vstInfo.editorHeight + 34
    End Sub
End Class