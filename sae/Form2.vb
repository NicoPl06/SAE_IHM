Public Class jeu
    Public remainingTime As Integer = 60

    Public Sub StartTimer()
        Timer1.Interval = 1000 ' 1 seconde
        Timer1.Start()
        lblTimer.Text = TimeSpan.FromSeconds(remainingTime).ToString("mm\:ss")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If remainingTime > 0 Then
            remainingTime -= 1
            lblTimer.Text = TimeSpan.FromSeconds(remainingTime).ToString("mm\:ss")
        Else
            Timer1.Stop()
            MessageBox.Show("Temps écoulé !")
        End If
    End Sub

    Private Sub jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Réinitialise le temps restant à chaque ouverture du formulaire
        remainingTime = 60
        lblTimer.Text = TimeSpan.FromSeconds(remainingTime).ToString("mm\:ss")
    End Sub

End Class
