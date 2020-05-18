Public Class Launcher
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    '                                                    [START-DRAG] (Possiblita o pessoal a mexer o form)
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
    '                                                   [START-END] (Possiblita o pessoal a mexer o form)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close() ' Fecha o launcher 
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized 'Minimiza o launcher 
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Shell("Explorer.exe fivem://connect/185.113.141.65:30120") 'Abre o FiveM e da connect ao server
        Shell("Explorer.exe ts3server://185.113.141.230:9994?password=nacionalrp") 'Abre o TS3 e da connect ao server (o user tem de por a pass a 1 vez que liga o pc)
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Shell("Explorer.exe https://discord.gg/txBqeJB") 'Discord de candidaturas
    End Sub

    Private Sub Creditos(sender As Object, e As EventArgs) Handles Button4.Click, PictureBox2.Click
        Shell("Explorer.exe https://www.twitch.tv/dosermind") 'Se quiserem deixar é sempre uma ajuda :) | O evento está no na imagem "PictureBox2"
    End Sub

End Class

'                           FAQ
' 1 - Porque fiz isto?
' Como sabem fui de ferias e então já que nao tinha como ajudar o server jogando decidi fazer um  launcher (a pedido nas sugestões)
' 2 - Porque há antivirus que dão positivo
' Nao sei mas posso garantir que é seguro usarem
