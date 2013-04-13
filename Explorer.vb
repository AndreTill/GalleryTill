Public Class Explorer

    Private nextone As Integer

    Private Sub Explorer_Load(sender As Object, e As EventArgs) Handles MyClass.Load
        FillTree()
    End Sub

    Public Sub FillTree()
        TreeView1.Nodes.Clear()
        Dim files = My.Computer.FileSystem.GetFiles(My.Settings.selectedpath.ToString)
        For Each fl In files
            Dim flsht As String() = fl.Split("\")
            Dim node As New TreeNode
            node.Name = fl
            node.Text = flsht(flsht.Length - 1)
            If (node.Text.Substring(node.Text.Length - 3, 3) = "jpg" Or node.Text.Substring(node.Text.Length - 3, 3) = "JPG" Or node.Text.Substring(node.Text.Length - 3, 3) = "jpeg" Or node.Text.Substring(node.Text.Length - 3, 3) = "gif") Then
                Me.TreeView1.Nodes.Add(node)
            End If
        Next
        If Me.TreeView1.Nodes.Count = 0 Then
            MsgBox("Папка пуста")
        End If
    End Sub


    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Me.nextone = Me.TreeView1.Nodes.IndexOf(Me.TreeView1.SelectedNode)
        Me.PictureBox1.ImageLocation = Me.TreeView1.SelectedNode.Name
        Me.SlideLabel.Text = Me.TreeView1.SelectedNode.Text & " (" & (Me.TreeView1.SelectedNode.Index + 1).ToString & " из " & Me.TreeView1.Nodes.Count.ToString & ")"
    End Sub

    Private Sub Explorer_MaximizedBoundsChanged(sender As Object, e As EventArgs) Handles Me.MaximizedBoundsChanged

    End Sub

    Private Sub Explorer_Resize(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        MainWin.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
    End Sub

    Private Sub PictureBox1_DClick(sender As Object, e As EventArgs)


    End Sub

    Sub FullScreen(Enable As Boolean)
        If Enable Then
            With Me
                .MdiParent = Nothing
                .TopMost = True
                .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                .SetDesktopLocation(0, 0)
                .Size = My.Computer.Screen.Bounds.Size
            End With
        Else
            With Me
                .TopMost = False
                .MdiParent = MainWin
            End With
        End If
    End Sub

    Private Function NextSlide(i As Integer)
        Try
            Me.PictureBox1.ImageLocation = Me.TreeView1.Nodes(Me.TreeView1.SelectedNode.Index + i).Name
            Me.TreeView1.SelectedNode = Me.TreeView1.Nodes(Me.TreeView1.SelectedNode.Index + i)
            Me.PictureBox1.Focus()
        Catch ex As Exception
            Me.SlideLabel.Text = ex.Message
        End Try
        Return Me.TreeView1.SelectedNode.Text
    End Function

    Private Function PrevSlide()
        Try
            Me.PictureBox1.ImageLocation = Me.TreeView1.Nodes(Me.TreeView1.SelectedNode.Index - 1).Name
            Me.TreeView1.SelectedNode = Me.TreeView1.Nodes(Me.TreeView1.SelectedNode.Index - 1)
            Me.PictureBox1.Focus()
        Catch ex As Exception
            Me.SlideLabel.Text = ex.Message
        End Try
        Return Me.TreeView1.SelectedNode.Text
    End Function

    Private Function RemoveSlide()
        Try
            My.Computer.FileSystem.DeleteFile(Me.PictureBox1.ImageLocation)
            Me.TreeView1.Nodes.Remove(Me.TreeView1.SelectedNode)
            Me.TreeView1.SelectedNode = Me.TreeView1.Nodes(Me.nextone)
            Me.PictureBox1.Focus()
        Catch ex As Exception
            Me.SlideLabel.Text = ex.Message
        End Try
        Return Me.TreeView1.SelectedNode.Text
    End Function

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        Try
            NextSlide(50)
        Catch ex As Exception
            MainWin.LogToConsole(ex.Message, True)
        End Try
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PictureBox1.MouseUp
        Try
            If e.Button = Windows.Forms.MouseButtons.Left Then
                Me.SlideLabel.Text = NextSlide(1) & " (" & (Me.TreeView1.SelectedNode.Index + 1).ToString & " из " & Me.TreeView1.Nodes.Count.ToString & ")"
            ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
                Me.SlideLabel.Text = RemoveSlide(1) & " (" & (Me.TreeView1.SelectedNode.Index + 1).ToString & " из " & Me.TreeView1.Nodes.Count.ToString & ")"
            ElseIf e.Button = Windows.Forms.MouseButtons.Middle Then
                FullScreen(Me.IsMdiChild)
            End If
        Catch ex As Exception
            Me.SlideLabel.Text = ex.Message
        End Try
    End Sub



    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseWheel
        Try
            If e.Delta > 0 Then
                Me.SlideLabel.Text = Me.PrevSlide() & " (" & (Me.TreeView1.SelectedNode.Index + 1).ToString & " из " & Me.TreeView1.Nodes.Count.ToString & ")"
            Else
                Me.SlideLabel.Text = Me.NextSlide(1) & " (" & (Me.TreeView1.SelectedNode.Index + 1).ToString & " из " & Me.TreeView1.Nodes.Count.ToString & ")"
            End If
        Catch ex As Exception
            Me.SlideLabel.Text = ex.Message
        End Try
    End Sub
End Class