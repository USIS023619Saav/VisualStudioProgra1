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

    Private Sub grbestadistica_KeyUp(sender As Object, e As KeyEventArgs) Handles grbestadistica.KeyUp


        Dim nfilas = grbestadistica.Rows.Count - 1,
       totalf1 = 0,
       totalx1xf1 = 0.0,
           totalx21xf1 = 0.0

            Dim fila As New DataGridViewRow
        For i = 0 To nfilas - 1
            fila = grbestadistica.Rows(i)

            Dim x1 = 0, f1 = 0

            If fila.Cells("x1").Value <> "" Then

                x1 = Integer.Parse(fila.Cells("x1").Value.ToString())
            End If

            If fila.Cells("f1").Value <> "" Then

                x1 = Integer.Parse(fila.Cells("f1").Value.ToString())
            End If

            totalf1 += f1
            totalx1xf1 += x1 * f1
            totalx21xf1 += x1 ^ 2 * f1

            fila.Cells("n1").Value = totalf1.ToString()
            fila.Cells("x1xf1").Value = (x1 * f1).ToString()
            fila.Cells("x21xf1").Value = (x1 ^ 2 * f1).ToString()


        Next

        lbltotalf1.Text = totalf1.ToString()
        lbltotal1x1xf1.Text = totalx1xf1.ToString()
        lbltotalx21xf1.Text = totalx21xf1.ToString()

        Dim media = Math.Round(totalx1xf1 / totalf1, 2),
         varianza = Math.Round(totalx21xf1 / totalf1 - media ^ 2, 2)
        lblmedia.Text = media.ToString()
        lblvarianza.Text = varianza.ToString()
        lbldesviacion.Text = Math.Round(Math.Sqrt(varianza), 2).ToString()








    End Sub
End Class
