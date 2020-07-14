Public Class Form1
    Dim hora = 0, minuto = 0, segundo As Integer = 0



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        segundo -= 1

        If segundo < 0 Then

            minuto -= 1

            segundo = 59


            If minuto < 0 Then

                minuto = 59

                hora -= 1

            End If

        End If


        Try

            ProgressBar.Value -= 1
            LblReloj.Text = hora.ToString + ":" + minuto.ToString + ":" + segundo.ToString

        Catch ex As Exception

            Timer1.Stop()
            Dim sonido As New System.Media.SoundPlayer
            sonido.SoundLocation = "C:\Windows\Media\Alarm01.wav"
            sonido.Play()

        End Try

    End Sub
    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles BtnIniciar.Click

        hora = NudHoras.Value
        minuto = NudMinutos.Value
        segundo = NudSegundos.Value

        If hora = 0 And minuto = 0 And segundo = 0 Then

            MsgBox("Indicar tiempo valido")

        ElseIf BtnIniciar.Text = "Iniciar" Then

            'Panel o group box
            LblReloj.Text = hora.ToString + ":" + minuto.ToString + ":" + segundo.ToString
            ProgressBar.Maximum = segundo + (minuto * 60) + (hora * 3600)
            ProgressBar.Value = ProgressBar.Maximum
            Timer1.Start()
            BtnIniciar.Text = "Restablecer"
            BtnIniciar.BackColor = Color.Chocolate
        ElseIf BtnIniciar.Text = "Restablecer" Then

            Timer1.Stop()
            ProgressBar.Value = ProgressBar.Minimum
            LblReloj.Text = "00:00:00"
            BtnIniciar.Text = "Iniciar"
            BtnIniciar.BackColor = Color.MediumSeaGreen
            NudSegundos.Value = 0
            NudMinutos.Value = 0
            NudHoras.Value = 0
        End If

    End Sub

End Class
