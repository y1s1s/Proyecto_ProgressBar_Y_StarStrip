Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'vamos a inicializar el progressbar con la barra de progreso completa al principio

        ProgressBar1.Value = 100



    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

        'En el caso de clickar en el primer elemento de la lista, el progressbar se ira vaciando en 1 unidad por segundo

        If CheckedListBox1.SelectedIndex = 0 Then

            Timer1.Interval = 1000

            Timer1.Start()

        End If

        'En el caso de que se clicke en el segundo de la lista la progressbar se ira vaciando en 2 unidades por segundo

        If CheckedListBox1.SelectedIndex = 1 Then

            Timer1.Interval = 500

            Timer1.Start()

        End If

        'En el caso de que se clicke en el tercero de la lista la progressbar se ira vaciando en 3 unidades por segundo

        If CheckedListBox1.SelectedIndex = 2 Then

            Timer1.Interval = 333

            Timer1.Start()

        End If

        'En el caso de que se clicke en el cuarto de la lista la progressbar se ira vaciando en 4 unidades por segundo

        If CheckedListBox1.SelectedIndex = 3 Then

            Timer1.Interval = 250

            Timer1.Start()

        End If



    End Sub

    Private Sub timer1_tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'En el caso de que el progressbar llegue a 0, se parara el timer y se mostrara un mensaje

        If ProgressBar1.Value = 0 Then

            Timer1.Stop()

            MsgBox("La barra de progreso se ha vaciado")

        Else

            'En el caso de que el progressbar no llegue a 0, se ira vaciando en 1 unidad por segundo

            ProgressBar1.Value = ProgressBar1.Value - 1

        End If

    End Sub


End Class
