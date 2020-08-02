Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub cal_Click(sender As Object, e As EventArgs) 
















        '------------------------------------------------------------------------------------------------▽






















        'TENGAN UN LINDO DIA, GRACIAS POR VER MI CODIGO.  ＾▽＾




        '-------------------------------------------------------------------------------------------------▽








    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) 

    End Sub

    Private Sub comb_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click




        Dim nt, i As SByte


        nt = txttabla.Text

        lsttabla.Items.Clear()
        If nt <= 12 Then


            For i = 1 To 10
                lsttabla.Items.Add(nt.ToString() + "X" + i.ToString() + "=" + (nt * i).ToString())
            Next

        Else
            lsttabla.Items.Add("Ingrese solo tablas menores o iguales a 12")

        End If









    End Sub
End Class
