Public Class Main

    ' Auxiliar object that will allow us to do the querys
    Public fileName As String
    Private p As Train

    'Select and Connect to the database

    Private Sub ofdPath_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofdPath.FileOk
        Me.ofdPath.InitialDirectory = Application.StartupPath
    End Sub

    Private Sub btnSelectMain_Click(sender As Object, e As EventArgs) Handles btnSelectMain.Click
        If Me.ofdPath.ShowDialog = DialogResult.OK Then
            btnConnectMain.Enabled = True
            fileName = ofdPath.FileName
        End If
    End Sub

    Private Sub btnConnectMain_Click(sender As Object, e As EventArgs) Handles btnConnectMain.Click
        btnManagementMain.Enabled = True
        btnRankingsMain.Enabled = True
        btnTrainInfoMain.Enabled = True
        btnBestTripMain.Enabled = True
        btnConnectMain.Enabled = False
        btnSelectMain.Enabled = True
    End Sub


    'Auxiliar Functions Show/Hide the windows..
    Private Sub btnManagementMain_Click(sender As Object, e As EventArgs) Handles btnManagementMain.Click
        Dim f2 As New Management
        f2.Show()
    End Sub

    Private Sub btnRankingsMain_Click(sender As Object, e As EventArgs) Handles btnRankingsMain.Click
        Dim f1 As New Rankings
        f1.Show()
    End Sub

    Private Sub btnTrainInfoMain_Click(sender As Object, e As EventArgs) Handles btnTrainInfoMain.Click
        Dim f3 As New TrainInfo
        f3.Show()
    End Sub

    Private Sub btnBestTripMain_Click(sender As Object, e As EventArgs) Handles btnBestTripMain.Click
        Dim f4 As New BestTrip
        f4.Show()
    End Sub


    'AUXILIAR METHODS RELATED TO THE WINDOW

    'Como Hacer que la ventana se mueva arrastrando con el raton
    Dim x, y As Integer
    Dim newpoint As New Point

    Private Sub frm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub frm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    'Como hacer los botones de Cerrar aplicacion y minimizar la ventana
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub


    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Musica Easter Egg

    Dim easter_egg_counter As Integer = 0

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If (easter_egg_counter > 10) Then
            My.Computer.Audio.Play(My.Resources.De_camino_a_casa_final_version, AudioPlayMode.Background)
        Else
            easter_egg_counter += 1
        End If

    End Sub

End Class
