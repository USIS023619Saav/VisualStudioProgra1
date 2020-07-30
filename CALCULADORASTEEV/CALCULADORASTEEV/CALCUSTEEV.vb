Public Class CALCULADORASTEVV
    Private Sub CALCULADORASTEVV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles respuesta.Click

    End Sub

    Private Sub CALCULAR_Click(sender As Object, e As EventArgs) Handles CALCULAR.Click


        Dim nume1, nume2 As Double 'DEFINIMOS VARIABLES QUE UTILIZAREMOS EN NUESTRO PROYECTO.


        nume1 = txtnum1.Text   'Se captura el valor que digite el usario en la caja de texto numero 1 
        nume2 = txtnum2.Text   'Se captura el valor que digite el usario en la caja de texto numero 2

        '---------------------------------------------------------------------------------------------------------------'


        If optsuma.Checked Then   'UTILIZAMOS UNA CONDICION PARA ESCOGER QUE PROCESO QUEREMOS REALIZAR
            respuesta.Text = nume1 + nume2
        End If


        If optresta.Checked Then
            respuesta.Text = nume1 - nume2
        End If


        If optmultiplicacion.Checked Then
            respuesta.Text = nume1 * nume2
        End If



        If optdivision.Checked Then
            respuesta.Text = nume1 / nume2
        End If




        If optporcentaje.Checked Then
            respuesta.Text = nume1 * nume2 / 100
        End If





        If optexponente.Checked Then
            respuesta.Text = nume1 ^ nume2
        End If



        If optmod.Checked Then
            respuesta.Text = nume1 Mod nume2
        End If



        '-----------------------------------------------------------------------------------------------------------------'



        'TENGAN UNA LINDA TARDE'





    End Sub
End Class
