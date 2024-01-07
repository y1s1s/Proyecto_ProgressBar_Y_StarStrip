Public Class Form1


    Dim i As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Interval = 100

    End Sub

    Private Sub bt_ejemplo_Click(sender As Object, e As EventArgs) Handles bt_ejemplo.Click

        Timer1.Enabled = True
        ProgressBar1.Maximum = 100
        i = 1

    End Sub
    Private Sub bt_reset_Click(sender As Object, e As EventArgs) Handles bt_reset.Click
        i = 1
        Timer1.Enabled = False
        Label1.Text = ""
        ProgressBar1.Value = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 1
        Label1.Text = "Cargando " & ProgressBar1.Value & "%"
        i += 1
        If i > 100 Then
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub bt_statusStrip_Click(sender As Object, e As EventArgs) Handles bt_statusStrip.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
