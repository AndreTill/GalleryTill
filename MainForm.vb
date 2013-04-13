Imports Un4seen
Imports Un4seen.Bass

Public Class MainWin
    Delegate Sub SetTextCallback(texts As String)

    Dim viewer As Explorer
    Public Audio As AudioEngine
    Public srvx As NetServer
#Region "Main"
    Private Sub Preload(mode As Integer, withaudio As Boolean)
        Try
            Select Case mode
                Case 1

            End Select
            LogTimer.Start()
            SaveFolderSelected()
            VSTFolderSelected()
            Me.DriverBox.SelectedText = My.Settings.audio_driver
            Me.DeviceBox.SelectedIndex = My.Settings.audio_device
            Me.FreqBox.SelectedText = My.Settings.audio_freq
        Catch ex As Exception
            LogToConsole(ex.Message, True)
        End Try
    End Sub


    Private Sub MainWin_Load(sender As Object, e As EventArgs) Handles Me.Load

        Preload(0, True)


    End Sub

#End Region

#Region "Funcs"
    Friend Sub OpenView(parent As Form)
        If Not viewer Is Nothing Then
            viewer.Close()
        End If
        Dim opendialog As New FolderBrowserDialog()
        opendialog.SelectedPath = My.Settings.selectedpath
        If (opendialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            My.Settings.Item("selectedpath") = opendialog.SelectedPath
            viewer = New Explorer
            viewer.MdiParent = parent
            viewer.StartPosition = FormStartPosition.CenterParent
            viewer.WindowState = FormWindowState.Maximized
            viewer.Show()
            My.Settings.Save()
        End If
    End Sub

    Private Sub SetProgress(ByVal texts As String)


        Dim d As New SetTextCallback(AddressOf SetProgress)
        Me.Invoke(d, New Object() {texts})


    End Sub

    Public Sub OpenFolder()

        Dim viewer As New Explorer
        viewer.MdiParent = Me
        viewer.StartPosition = FormStartPosition.CenterParent
        viewer.WindowState = FormWindowState.Maximized
        viewer.Show()
    End Sub

    Public Sub VSTFolderSelected()
        If My.Settings.VST_folder = "" Then
            If VSTFolderBrowseDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                My.Settings.VST_folder = VSTFolderBrowseDialog.SelectedPath
            End If
        End If
    End Sub

    Public Sub SaveFolderSelected()
        If (My.Settings.selectedpath = "") Then
            Me.ToolStripStatusLabel1.ActiveLinkColor = Color.Red
            Me.ToolStripStatusLabel1.Text = "Каталог для загрузки фотографий не выбран. (нажмите чтобы исправить)"

        Else

            Me.ToolStripStatusLabel1.Text = "Готов"

        End If
    End Sub

    Private Sub SelectDownloadFolder() Handles SelToolStripButton.Click
        If (Me.SaveFolderDialog.ShowDialog = Windows.Forms.DialogResult.OK) Then
            My.Settings.selectedpath = Me.SaveFolderDialog.SelectedPath
            My.Settings.Save()
            LogToConsole("Folder selected: " & My.Settings.selectedpath, False)
        End If
    End Sub

    Private Function ResolveFreq(selection As String) As Integer
        Dim res As Integer
        Select Case selection
            Case "8000"
                res = 0
            Case "11025"
                res = 1
            Case "12000"
                res = 2
            Case "16000"
                res = 3
            Case "22050"
                res = 4
            Case "32000"
                res = 5
            Case "44100"
                res = 6
            Case "48000"
                res = 7
            Case "96000"
                res = 8
            Case "192000"
                res = 9
        End Select
        Return res
    End Function


#End Region

#Region "Log"
    Public Sub LogToConsole(mssg As String, isError As Boolean)
        Select Case isError
            Case False
                Me.LogBox.Text &= "--- Information ---"
            Case True
                Me.LogBox.Text &= "--- Error ---"
                Me.errorscount.Text = Me.errorscount.Text + 1
        End Select
        Me.LogBox.Text &= vbCrLf & mssg.ToString & vbCrLf
    End Sub

    Private Sub RefreshParamsLog()
        Me.SettingsLog.Clear()
        For Each par As System.Configuration.SettingsProperty In My.Settings.Properties
            Me.SettingsLog.Text &= par.Name & "  ==  '" & My.Settings.Item(par.Name).ToString & "'" & vbCrLf
        Next
        If Not srvx Is Nothing Then
            Me.ServStatLabel.Text = "Подключен"
        Else
            Me.ServStatLabel.Text = "Отключен"
        End If
        If Not Audio Is Nothing Then
            Me.AudioStatLabel.Text = "Подключен"
        Else
            Me.AudioStatLabel.Text = "Отключен"
        End If
    End Sub

    Private Sub LogTimer_Tick(sender As Object, e As EventArgs) Handles LogTimer.Tick
        RefreshParamsLog()
    End Sub

    Private Sub LogBox_TextChanged(sender As Object, e As EventArgs) Handles LogBox.TextChanged
        Me.LogBox.ScrollToCaret()
    End Sub

#End Region

#Region "DownloadFromLinks"

    'Private Sub BackWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackWorker.DoWork
    '    Dim worker As System.ComponentModel.BackgroundWorker = CType(sender, System.ComponentModel.BackgroundWorker)
    '    Dim istep As Integer = 0
    '    For Each href As String In e.Argument.Lines
    '        Dim fname As String = href.Substring(href.Length - 9, 9)
    '        Dim destfolder As String = LinksForm.SaveToLable.Text + "\" + fname
    '        My.Computer.Network.DownloadFile(href, destfolder, Nothing, Nothing, False, 1000, True)
    '        istep = istep + 1
    '        BackWorker.ReportProgress(istep, "Файл " + destfolder + " успешно загружен")

    '    Next
    '    BackWorker.ReportProgress(0, "Загрузка заверена")
    'End Sub

    Private Sub BackWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackWorker.ProgressChanged
        Me.ProgressB.Value = e.ProgressPercentage
        Me.LogBox.Text &= vbCrLf & e.UserState

    End Sub

#End Region

#Region "KeysAndOtherEvents"

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        If (Me.ToolStripStatusLabel1.Text = "Готов") Then
            MsgBox("Все в норме. Действий не требуется.", MsgBoxStyle.Information)
        ElseIf (Me.ToolStripStatusLabel1.Text = "Каталог для загрузки фотографий не выбран. (нажмите чтобы исправить)") Then
            SelectDownloadFolder()
        End If
    End Sub

    Private Sub ExitMenuStrip_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Public Sub OpenFolderMenuStrip_Click(sender As Object, e As EventArgs) Handles OpenFolderMenuStrip.Click
        OpenView(Me)
    End Sub

    Private Sub MainWin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not Audio Is Nothing Then Audio.Distruct()
        My.Settings.audio_buff = Nothing
    End Sub

    Private Sub DEVCONSOLEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DebugButton.Click
        If (Me.Panel1.Visible = True) Then
            Me.LogTimer.Stop()
            Me.Panel1.Hide()
        Else
            Me.Panel1.Show()
            Me.LogTimer.Start()
        End If
    End Sub

    Private Sub ОткрытьToolStripButton_Click(sender As Object, e As EventArgs) Handles ОткрытьToolStripButton.Click, ExplorerToolStripMenuItem.Click
        OpenView(Me)
    End Sub

#End Region




#Region "AudioSection"
    Private Sub PlayerShow(sender As Object, e As EventArgs) Handles ShowPlayerBtn.Click
        Dim player As New PlayerForm
        player.MdiParent = Me
        player.Show()
    End Sub

    Private Sub GlobalPlay(sender As Object, e As EventArgs) Handles GlobalPlayBtn.Click
        Audio.ResumeChannel()
    End Sub

    Private Sub GlobalPause(sender As Object, e As EventArgs) Handles GlobalPauseBtn.Click
        Audio.PauseChannel()
    End Sub

    Private Sub DeviceBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DeviceBox.SelectedIndexChanged
        If Not Audio Is Nothing Then
            Audio.ChangeDevice(DeviceBox.SelectedItem)
        End If
        My.Settings.audio_device = DeviceBox.SelectedItem
    End Sub

    Private Sub FreqBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FreqBox.SelectedIndexChanged
        My.Settings.audio_freq = FreqBox.SelectedItem
    End Sub
#End Region

    Private Sub ПечатьToolStripButton_Click(sender As Object, e As EventArgs) Handles ПечатьToolStripButton.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Audio.ShowVSTEd(Me.OpenFileDialog1.FileName, Me)
        End If
    End Sub

    Private Sub ServChkBox_CheckedChanged(sender As Object, e As EventArgs) Handles ServChkBox.CheckedChanged
        If Me.ServChkBox.Checked = True Then
            srvx = New NetServer
            srvx.Init()
        Else
            srvx.StopSrv()
            srvx = Nothing
        End If
    End Sub

    Private Sub AudioChkBox_CheckedChanged(sender As Object, e As EventArgs) Handles AudioChkBox.CheckedChanged
        If AudioChkBox.Checked = True Then
            Audio = New AudioEngine(My.Settings.audio_freq, Me.Handle)
        Else
            Audio.Distruct()
            Audio = Nothing
        End If
    End Sub
End Class
