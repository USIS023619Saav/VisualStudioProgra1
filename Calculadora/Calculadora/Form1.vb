Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles optsuma.CheckedChanged

    End Sub

    Private Sub cal_Click(sender As Object, e As EventArgs) Handles cal.Click
        Dim num1, num2 As Double

        num1 = txtnum1.Text
        num2 = txtnum2.Text

        If optsuma.Checked Then
            result.Text = num1 + num2
        End If


        If optresta.Checked Then
            result.Text = num1 - num2
        End If



        If optmultiplicacion.Checked Then
            result.Text = num1 * num2
        End If



        If optdivision.Checked Then
            result.Text = num1 / num2
        End If


        If optporcen.Checked Then
            result.Text = num1 * num2 / 100
        End If


        If optelevacion.Checked Then
            result.Text = num1 ^ num2
        End If





        If optmodis.Checked Then
            result.Text = num1 Mod num2
        End If











    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles optmodis.CheckedChanged

    End Sub
End Class
