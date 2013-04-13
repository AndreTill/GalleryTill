<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWin))
        Me.OpenFolderMenuStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelFolDownStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorsBox = New System.Windows.Forms.ToolStripComboBox()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ProgressB = New System.Windows.Forms.ToolStripProgressBar()
        Me.SaveFolderDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.LogBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AudioStatLabel = New System.Windows.Forms.Label()
        Me.AudioChkBox = New System.Windows.Forms.CheckBox()
        Me.ServStatLabel = New System.Windows.Forms.Label()
        Me.ServChkBox = New System.Windows.Forms.CheckBox()
        Me.AudioParamsGroup = New System.Windows.Forms.GroupBox()
        Me.FreqBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DeviceBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DriverBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SettingsLog = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LogTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BackWorker = New System.ComponentModel.BackgroundWorker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.СоздатьToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ОткрытьToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowPlayerBtn = New System.Windows.Forms.ToolStripButton()
        Me.GlobalPlayBtn = New System.Windows.Forms.ToolStripButton()
        Me.GlobalPauseBtn = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ПечатьToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SelToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.errorscount = New System.Windows.Forms.ToolStripLabel()
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.MainMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.PhotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventExplorerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DebugButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.VSTFolderBrowseDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.AudioParamsGroup.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.MainMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFolderMenuStrip
        '
        Me.OpenFolderMenuStrip.Name = "OpenFolderMenuStrip"
        Me.OpenFolderMenuStrip.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenFolderMenuStrip.Size = New System.Drawing.Size(174, 22)
        Me.OpenFolderMenuStrip.Text = "Просмотр"
        '
        'DToolStripMenuItem
        '
        Me.DToolStripMenuItem.Name = "DToolStripMenuItem"
        Me.DToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.DToolStripMenuItem.Text = "Скачать с..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(199, 22)
        Me.ToolStripMenuItem2.Text = "..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(171, 6)
        '
        'SelFolDownStripMenuItem
        '
        Me.SelFolDownStripMenuItem.Name = "SelFolDownStripMenuItem"
        Me.SelFolDownStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.SelFolDownStripMenuItem.Text = "Выбрать папку загрузки"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.TestToolStripMenuItem.Text = "test"
        '
        'ErrorsBox
        '
        Me.ErrorsBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ErrorsBox.Items.AddRange(New Object() {"Классический", "Профессиональный", "Администрирование", "Отладка"})
        Me.ErrorsBox.Name = "ErrorsBox"
        Me.ErrorsBox.Size = New System.Drawing.Size(121, 23)
        '
        'FolderBrowserDialog
        '
        Me.FolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ProgressB})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 757)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(1225, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Margin = New System.Windows.Forms.Padding(0, 3, 2, 2)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(38, 17)
        Me.ToolStripStatusLabel1.Text = "Готов"
        '
        'ProgressB
        '
        Me.ProgressB.Name = "ProgressB"
        Me.ProgressB.Size = New System.Drawing.Size(100, 16)
        Me.ProgressB.Visible = False
        '
        'LogBox
        '
        Me.LogBox.Location = New System.Drawing.Point(3, 24)
        Me.LogBox.Multiline = True
        Me.LogBox.Name = "LogBox"
        Me.LogBox.ReadOnly = True
        Me.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LogBox.Size = New System.Drawing.Size(277, 144)
        Me.LogBox.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AudioStatLabel)
        Me.Panel1.Controls.Add(Me.AudioChkBox)
        Me.Panel1.Controls.Add(Me.ServStatLabel)
        Me.Panel1.Controls.Add(Me.ServChkBox)
        Me.Panel1.Controls.Add(Me.AudioParamsGroup)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LogBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(942, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(283, 733)
        Me.Panel1.TabIndex = 7
        '
        'AudioStatLabel
        '
        Me.AudioStatLabel.AccessibleName = ""
        Me.AudioStatLabel.AutoSize = True
        Me.AudioStatLabel.Location = New System.Drawing.Point(205, 586)
        Me.AudioStatLabel.Name = "AudioStatLabel"
        Me.AudioStatLabel.Size = New System.Drawing.Size(57, 13)
        Me.AudioStatLabel.TabIndex = 13
        Me.AudioStatLabel.Text = "Отключен"
        '
        'AudioChkBox
        '
        Me.AudioChkBox.AccessibleName = ""
        Me.AudioChkBox.AutoSize = True
        Me.AudioChkBox.Location = New System.Drawing.Point(9, 585)
        Me.AudioChkBox.Name = "AudioChkBox"
        Me.AudioChkBox.Size = New System.Drawing.Size(56, 17)
        Me.AudioChkBox.TabIndex = 12
        Me.AudioChkBox.Text = "Аудио"
        Me.AudioChkBox.UseVisualStyleBackColor = True
        '
        'ServStatLabel
        '
        Me.ServStatLabel.AutoSize = True
        Me.ServStatLabel.Location = New System.Drawing.Point(205, 563)
        Me.ServStatLabel.Name = "ServStatLabel"
        Me.ServStatLabel.Size = New System.Drawing.Size(57, 13)
        Me.ServStatLabel.TabIndex = 11
        Me.ServStatLabel.Text = "Отключен"
        '
        'ServChkBox
        '
        Me.ServChkBox.AutoSize = True
        Me.ServChkBox.Location = New System.Drawing.Point(9, 562)
        Me.ServChkBox.Name = "ServChkBox"
        Me.ServChkBox.Size = New System.Drawing.Size(63, 17)
        Me.ServChkBox.TabIndex = 10
        Me.ServChkBox.Text = "Сервер"
        Me.ServChkBox.UseVisualStyleBackColor = True
        '
        'AudioParamsGroup
        '
        Me.AudioParamsGroup.Controls.Add(Me.FreqBox)
        Me.AudioParamsGroup.Controls.Add(Me.Label4)
        Me.AudioParamsGroup.Controls.Add(Me.DeviceBox)
        Me.AudioParamsGroup.Controls.Add(Me.Label3)
        Me.AudioParamsGroup.Controls.Add(Me.DriverBox)
        Me.AudioParamsGroup.Controls.Add(Me.Label2)
        Me.AudioParamsGroup.Location = New System.Drawing.Point(4, 440)
        Me.AudioParamsGroup.Name = "AudioParamsGroup"
        Me.AudioParamsGroup.Size = New System.Drawing.Size(279, 115)
        Me.AudioParamsGroup.TabIndex = 9
        Me.AudioParamsGroup.TabStop = False
        Me.AudioParamsGroup.Text = "Audio Settings"
        '
        'FreqBox
        '
        Me.FreqBox.FormattingEnabled = True
        Me.FreqBox.Items.AddRange(New Object() {"8000", "11025", "12000", "16000", "22050", "32000", "44100", "48000", "96000", "192000"})
        Me.FreqBox.Location = New System.Drawing.Point(81, 81)
        Me.FreqBox.Name = "FreqBox"
        Me.FreqBox.Size = New System.Drawing.Size(121, 21)
        Me.FreqBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Частота"
        '
        'DeviceBox
        '
        Me.DeviceBox.FormattingEnabled = True
        Me.DeviceBox.Items.AddRange(New Object() {"0", "1", "2"})
        Me.DeviceBox.Location = New System.Drawing.Point(81, 49)
        Me.DeviceBox.Name = "DeviceBox"
        Me.DeviceBox.Size = New System.Drawing.Size(186, 21)
        Me.DeviceBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Устройство"
        '
        'DriverBox
        '
        Me.DriverBox.FormattingEnabled = True
        Me.DriverBox.Items.AddRange(New Object() {"BASS", "ASIO"})
        Me.DriverBox.Location = New System.Drawing.Point(81, 17)
        Me.DriverBox.Name = "DriverBox"
        Me.DriverBox.Size = New System.Drawing.Size(186, 21)
        Me.DriverBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Драйвер"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SettingsLog)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 183)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(277, 250)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Значения параметров"
        '
        'SettingsLog
        '
        Me.SettingsLog.Location = New System.Drawing.Point(6, 19)
        Me.SettingsLog.Multiline = True
        Me.SettingsLog.Name = "SettingsLog"
        Me.SettingsLog.ReadOnly = True
        Me.SettingsLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SettingsLog.Size = New System.Drawing.Size(265, 225)
        Me.SettingsLog.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Системные сообщения"
        '
        'LogTimer
        '
        Me.LogTimer.Interval = 1000
        '
        'BackWorker
        '
        Me.BackWorker.WorkerReportsProgress = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СоздатьToolStripButton, Me.ОткрытьToolStripButton, Me.ToolStripSeparator3, Me.ShowPlayerBtn, Me.GlobalPlayBtn, Me.GlobalPauseBtn, Me.toolStripSeparator, Me.ПечатьToolStripButton, Me.SelToolStripButton, Me.ToolStripSeparator4, Me.ToolStripLabel1, Me.errorscount})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(942, 39)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'СоздатьToolStripButton
        '
        Me.СоздатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.СоздатьToolStripButton.Image = CType(resources.GetObject("СоздатьToolStripButton.Image"), System.Drawing.Image)
        Me.СоздатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.СоздатьToolStripButton.Name = "СоздатьToolStripButton"
        Me.СоздатьToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.СоздатьToolStripButton.Text = "Просмотр папки"
        '
        'ОткрытьToolStripButton
        '
        Me.ОткрытьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ОткрытьToolStripButton.Image = CType(resources.GetObject("ОткрытьToolStripButton.Image"), System.Drawing.Image)
        Me.ОткрытьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ОткрытьToolStripButton.Name = "ОткрытьToolStripButton"
        Me.ОткрытьToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.ОткрытьToolStripButton.Text = "&Открыть"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'ShowPlayerBtn
        '
        Me.ShowPlayerBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ShowPlayerBtn.Image = CType(resources.GetObject("ShowPlayerBtn.Image"), System.Drawing.Image)
        Me.ShowPlayerBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ShowPlayerBtn.Name = "ShowPlayerBtn"
        Me.ShowPlayerBtn.Size = New System.Drawing.Size(36, 36)
        Me.ShowPlayerBtn.Text = "Плеер"
        '
        'GlobalPlayBtn
        '
        Me.GlobalPlayBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GlobalPlayBtn.Image = CType(resources.GetObject("GlobalPlayBtn.Image"), System.Drawing.Image)
        Me.GlobalPlayBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GlobalPlayBtn.Name = "GlobalPlayBtn"
        Me.GlobalPlayBtn.Size = New System.Drawing.Size(36, 36)
        Me.GlobalPlayBtn.Text = "Играть"
        '
        'GlobalPauseBtn
        '
        Me.GlobalPauseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GlobalPauseBtn.Image = CType(resources.GetObject("GlobalPauseBtn.Image"), System.Drawing.Image)
        Me.GlobalPauseBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GlobalPauseBtn.Name = "GlobalPauseBtn"
        Me.GlobalPauseBtn.Size = New System.Drawing.Size(36, 36)
        Me.GlobalPauseBtn.Text = "Пауза"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 39)
        '
        'ПечатьToolStripButton
        '
        Me.ПечатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ПечатьToolStripButton.Image = CType(resources.GetObject("ПечатьToolStripButton.Image"), System.Drawing.Image)
        Me.ПечатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ПечатьToolStripButton.Name = "ПечатьToolStripButton"
        Me.ПечатьToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.ПечатьToolStripButton.Text = "&Печать"
        '
        'SelToolStripButton
        '
        Me.SelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SelToolStripButton.Image = CType(resources.GetObject("SelToolStripButton.Image"), System.Drawing.Image)
        Me.SelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SelToolStripButton.Name = "SelToolStripButton"
        Me.SelToolStripButton.Size = New System.Drawing.Size(36, 36)
        Me.SelToolStripButton.Text = "Спр&авка"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(43, 36)
        Me.ToolStripLabel1.Text = "Errors: "
        '
        'errorscount
        '
        Me.errorscount.Name = "errorscount"
        Me.errorscount.Size = New System.Drawing.Size(13, 36)
        Me.errorscount.Text = "0"
        '
        'BackgroundWorker
        '
        Me.BackgroundWorker.WorkerReportsProgress = True
        '
        'ImageList
        '
        Me.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList.ImageSize = New System.Drawing.Size(128, 128)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'MainMenuStrip
        '
        Me.MainMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PhotoToolStripMenuItem, Me.ExitToolStripMenuItem, Me.EventsToolStripMenuItem})
        Me.MainMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainMenuStrip.Name = "MainMenuStrip"
        Me.MainMenuStrip.Size = New System.Drawing.Size(1225, 24)
        Me.MainMenuStrip.TabIndex = 13
        Me.MainMenuStrip.Text = "MenuStrip1"
        '
        'PhotoToolStripMenuItem
        '
        Me.PhotoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExplorerToolStripMenuItem, Me.DownloadToolStripMenuItem})
        Me.PhotoToolStripMenuItem.Name = "PhotoToolStripMenuItem"
        Me.PhotoToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.PhotoToolStripMenuItem.Text = "Photo"
        '
        'ExplorerToolStripMenuItem
        '
        Me.ExplorerToolStripMenuItem.Name = "ExplorerToolStripMenuItem"
        Me.ExplorerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ExplorerToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ExplorerToolStripMenuItem.Text = "Explorer"
        '
        'DownloadToolStripMenuItem
        '
        Me.DownloadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LinksToolStripMenuItem, Me.VKToolStripMenuItem})
        Me.DownloadToolStripMenuItem.Name = "DownloadToolStripMenuItem"
        Me.DownloadToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.DownloadToolStripMenuItem.Text = "Download from"
        '
        'LinksToolStripMenuItem
        '
        Me.LinksToolStripMenuItem.Name = "LinksToolStripMenuItem"
        Me.LinksToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.LinksToolStripMenuItem.Text = "Links"
        '
        'VKToolStripMenuItem
        '
        Me.VKToolStripMenuItem.Name = "VKToolStripMenuItem"
        Me.VKToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.VKToolStripMenuItem.Text = "VK"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EventsToolStripMenuItem
        '
        Me.EventsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EventExplorerToolStripMenuItem1})
        Me.EventsToolStripMenuItem.Name = "EventsToolStripMenuItem"
        Me.EventsToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.EventsToolStripMenuItem.Text = "Events"
        '
        'EventExplorerToolStripMenuItem1
        '
        Me.EventExplorerToolStripMenuItem1.Name = "EventExplorerToolStripMenuItem1"
        Me.EventExplorerToolStripMenuItem1.Size = New System.Drawing.Size(116, 22)
        Me.EventExplorerToolStripMenuItem1.Text = "Explorer"
        '
        'DebugButton
        '
        Me.DebugButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DebugButton.Location = New System.Drawing.Point(1150, 0)
        Me.DebugButton.Name = "DebugButton"
        Me.DebugButton.Size = New System.Drawing.Size(75, 24)
        Me.DebugButton.TabIndex = 14
        Me.DebugButton.Text = "Debug"
        Me.DebugButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "MP3 files|*.mp3"
        '
        'VSTFolderBrowseDialog
        '
        Me.VSTFolderBrowseDialog.Description = "VST folder"
        Me.VSTFolderBrowseDialog.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.VSTFolderBrowseDialog.ShowNewFolderButton = False
        '
        'MainWin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1225, 779)
        Me.Controls.Add(Me.DebugButton)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MainMenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MainMenuStrip
        Me.Name = "MainWin"
        Me.Text = "Gallery - v. 1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.AudioParamsGroup.ResumeLayout(False)
        Me.AudioParamsGroup.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MainMenuStrip.ResumeLayout(False)
        Me.MainMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ФайлToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFolderMenuStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents DEVCONSOLEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SaveFolderDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents LogBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SettingsLog As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LogTimer As System.Windows.Forms.Timer
    Friend WithEvents НастройкиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelFolDownStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErrorsBox As System.Windows.Forms.ToolStripComboBox
    Public WithEvents BackWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents TestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents ProgressB As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ОткрытьToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ShowPlayerBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ПечатьToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelToolStripButton As System.Windows.Forms.ToolStripButton
    Public WithEvents СоздатьToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
    Public WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents errorscount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DebugButton As System.Windows.Forms.Button
    Friend WithEvents PhotoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExplorerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownloadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LinksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VKToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventExplorerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GlobalPlayBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents GlobalPauseBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents AudioParamsGroup As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FreqBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DeviceBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DriverBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents VSTFolderBrowseDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents AudioStatLabel As System.Windows.Forms.Label
    Friend WithEvents AudioChkBox As System.Windows.Forms.CheckBox
    Friend WithEvents ServStatLabel As System.Windows.Forms.Label
    Friend WithEvents ServChkBox As System.Windows.Forms.CheckBox

End Class
