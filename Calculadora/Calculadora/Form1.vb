Public Class Form1


    Dim objdirecciones = New direcciones()


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbodepto.Items.AddRange(objdirecciones.depto)
    End Sub




    Private Sub cboDepto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbodepto.SelectedIndexChanged
        cbomun.Items.Clear()
        cbomun.Text = ""
        cbomun.Items.AddRange(objdirecciones.mun(cbodepto.SelectedIndex))
    End Sub






    Class direcciones
        Public depto() As String = {"Seleccione un depto.", "Usulutan", "San Miguel", "La Union", "Morazan"}
        Public mun()() As String = {
            New String() {"Seleccione un depto."},
            New String() {"Seleccione un municipio", "Usulutan", "Jiquilisco", "Santa Elena", "Santa Maria"},
            New String() {"Seleccione un municipio", "San Miguel", "El Transito", "San Rafael Ote", "San Jorge"},
            New String() {"Seleccione un municipio", "La Union", "SRL", "Anamoros", "Bolivar"},
            New String() {"Seleccione un municipio", "Arambala", "Perquin", "Corinto", "Cacaopera"},
            New String() {"Seleccione un municipio", "San Salvador"}
            }



    End Class


    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub comb_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub n2_Click(sender As Object, e As EventArgs) Handles n2.Click

    End Sub
End Class
