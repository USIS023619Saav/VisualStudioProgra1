Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnp_Click(sender As Object, e As EventArgs) Handles btnp.Click
        '----------------------------------------------------TABLA DE NUMEROS PARES DEL 1-20

        lstejercicios.Items.Clear()

        lstejercicios.Items.Add("numeros pares del 1 al 20")
        For i = 2 To 20 Step 2
            lstejercicios.Items.Add(i)
        Next

        lstejercicios.Items.Add("numeros impares del 1 al 20")
        For i = 1 To 20 Step 2
            lstejercicios.Items.Add(i)
        Next




    End Sub

    Private Sub btnpar_Click(sender As Object, e As EventArgs) Handles btnpar.Click

        '----------------------------------------------------------------------------DETECTOR DE NUMEROS PARES / IMPARES

        Dim num = txtnum.Text
        If num Mod 2 = 0 Then
            MessageBox.Show("el nummero " + num + " , es par")

        Else

            MessageBox.Show("el nummero " + num + " , es impar")

        End If






    End Sub

    Private Sub btnprimo_Click(sender As Object, e As EventArgs) Handles btnprimo.Click
        '------------------------------------------------------------------------ CREACION DE DETECTOR DE NUMEROS PRIMOS

        Dim num = txtnum.Text, i = 0, acu = 1

        While i < 3 And acu <= num


            If num Mod acu = 0 Then

                i += 1 ' i=i+1  


            End If

            acu += 1


        End While

        If i <= 2 Then

            MessageBox.Show("ES PRIMO")

        Else

            MessageBox.Show("NO es primo")

        End If




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncajero.Click


        '-------------------------------------------------------------------------------------------------------- CREACION DE CAJERO AUTOMATICO.
        Dim denominaciones() = {100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.1, 0.05, 0.01}, valor = txtnum.Text, cantidad = 0

        Dim denomina As String

        lstejercicios.Items.Clear()


        For Each denominacion In denominaciones
            While valor > 0 And denominacion <= valor
                valor = Math.Round(valor - denominacion, 2)
                cantidad += 1

            End While

            If cantidad > 0 Then
                If denominacion <= 1 Then
                    denomina = "moneda de"

                Else

                    denomina = " Billete de "


                End If

                lstejercicios.Items.Add(cantidad.ToString() + denomina + denominacion.ToString())
                cantidad = 0


            End If


        Next











    End Sub
End Class
