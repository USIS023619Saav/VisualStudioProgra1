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




        Dim nt, i As Int64

        i = 1


        nt = txttabla.Text

        lsttabla.Items.Clear()

        '----------------------------------------------------------------------------------------------------------
        'PONEMOS EN PRACTICA ESTRUCTURA DO WHILE

        Do While i <= 10


            lsttabla.Items.Add(nt.ToString() + "X" + i.ToString() + "=" + (nt * i).ToString())


            i = i + 1

        Loop











    End Sub
End Class
