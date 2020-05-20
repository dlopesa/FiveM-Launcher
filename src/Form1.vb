Public Class Launcher
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    '                                                    
    Private Sub Launcher_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top

    End Sub

    Private Sub Launcher_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Launcher_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub
    '                                                   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close() ' 
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    '                                   CONFIG
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Shell("Explorer.exe fivem://connect/localhost") 'SERVER IP
        Shell("Explorer.exe ts3server://localhost") ' TEAMSPEAL IP
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Shell("Explorer.exe https://discord.gg/") 'DISCORD SERVER
    End Sub

    Private Sub Creditos(sender As Object, e As EventArgs) Handles Button4.Click, PictureBox2.Click
        Shell("Explorer.exe https://github.com/dosermind")
    End Sub

End Class
