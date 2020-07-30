Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles optsuma.CheckedChanged

    End Sub

    Private Sub cal_Click(sender As Object, e As EventArgs) Handles cal.Click

        'SE INICIALIZAN PRIMERAMENTE LAS VARIABLES.
        Dim num1, num2 As Double
        '-----------------------------------------------------------------------------------------


        'DEFINIMOS CADA UNA DE ELLAS.
        num1 = txtnum1.Text
        num2 = txtnum2.Text
        '----------------------------------------------------------------------------------------------


        'UTILIZAMOS UNA CONDICION PARA SELECCIONAR EL TIPO DE OPERACION QUE QUERAMOS REALIZAR.
        If optsuma.Checked Then
            result.Text = num1 + num2
        End If
        '---------------------------------------------------------------------------------------------

        If optresta.Checked Then
            result.Text = num1 - num2
        End If



        If optmultiplicacion.Checked Then
            result.Text = num1 * num2
        End If



        If optdivision.Checked Then
            result.Text = num1 / num2
        End If


        'PARA SACAR EL PORCENTAJE LA OPERACIO QUE TENEMOS QUE REALIZAR ES LA MULTIPLICACION DE DOS NUMEROS
        'ENTRE 100  
        If optporcen.Checked Then
            result.Text = num1 * num2 / 100
        End If
        '-------------------------------------------------------------------------------------------------------

        If optelevacion.Checked Then
            result.Text = num1 ^ num2
        End If





        If optmodis.Checked Then
            result.Text = num1 Mod num2
        End If



        '------------------------------------------------------------------------------------------------▽




        'TENGAN UN LINDO DIA, GRACIAS POR VER MI CODIGO.  ＾▽＾




        '-------------------------------------------------------------------------------------------------▽








    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles optmodis.CheckedChanged

    End Sub
End Class
