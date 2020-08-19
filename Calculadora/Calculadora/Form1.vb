Public Class Form1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtserie.TextChanged

    End Sub

    Private Sub btnmedia_Click(sender As Object, e As EventArgs) Handles btnmedia.Click
        Dim objestadistica As New estadistica

        lblmedia.Text = objestadistica.calmedia(txtserie.Text.Split(","))
        lblvarianza.Text = objestadistica.calvarianza(txtserie.Text.Split(","))
        lbldesviacion.Text = objestadistica.caldesviacion(txtserie.Text.Split(","))


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        txtserie.Clear()



    End Sub
End Class
