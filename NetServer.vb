Imports System.Web
Imports System.Runtime.Hosting
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.IO
Imports System.Text

Public Class NetServer

    'Слушатель по указанному порту
    Shared myListener As TcpListener
    Shared connection As Socket
    Shared readThread As Thread

    Shared socketStream As NetworkStream

    Private Shared writer As BinaryWriter
    Private Shared reader As BinaryReader

    Public Sub Init()
        Try
            myListener = New TcpListener(IPAddress.Any, 800)
            myListener.Start()
            Dim thread As New Thread(New ThreadStart(AddressOf RunServer))
            thread.Start()
            MainWin.LogToConsole("Сервер запущен", False)
        Catch ex As Exception
            MainWin.LogToConsole(ex.Message, True)
        End Try
    End Sub

    Public Sub StopSrv()
        Try
            writer.Close()
            reader.Close()
            socketStream.Close()
            connection.Close()
        Catch ex As Exception

        End Try

    End Sub

    'Отправка содержания страницы
    Private Sub SendData(ByVal data As Byte(), ByRef sockets As Socket)
        Dim numberOfBytes As Integer = 0
        Try
            If sockets.Connected = True Then
                If (numberOfBytes = sockets.Send(data, data.Length, SocketFlags.None)) = -1 Then
                    MainWin.LogToConsole("ТИПА ОШИБКА", True)
                Else
                    MainWin.LogToConsole("Послано байт : " & numberOfBytes, False)
                End If
            Else
                MainWin.LogToConsole("Соединение не установлено", True)
            End If
        Catch ex As Exception
            MainWin.LogToConsole(ex.Message, True)
        End Try
    End Sub

    'Перегруженный метод
    Private Sub SendData(ByVal data As String, ByRef sockets As Socket)
        SendData(Encoding.ASCII.GetBytes(data), sockets)
    End Sub

    Public Shared Sub RunServer()
        Dim counter As Integer = 1
        Try
            While True
                MainWin.LogToConsole("Waiting for connection", False)
                connection = myListener.AcceptSocket()
                socketStream = New NetworkStream(connection)
                writer = New BinaryWriter(socketStream)
                reader = New BinaryReader(socketStream)
                MainWin.LogToConsole("Connection " & counter & " received.", False)
                writer.Write("SERVER>>> Connection successful")
                Dim theReply As String = ""
                Try
                    Do
                        theReply = reader.ReadString()
                        MainWin.LogToConsole(theReply, False)
                    Loop While (theReply <> "CLIENT>>> TERMINATE" _
                       AndAlso connection.Connected)
                Catch inputOutputException As IOException
                    MainWin.LogToConsole("Client application closing", False)
                Finally
                    MainWin.LogToConsole("User terminated connection", False)
                    writer.Close()
                    reader.Close()
                    socketStream.Close()
                    connection.Close()
                    counter += 1
                End Try
            End While
        Catch inputOutputException As IOException
            MainWin.LogToConsole("Server application closing", True)
        End Try
    End Sub

End Class
