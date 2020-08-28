Public Class form1
    Dim objromano = New conversor_romanos

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        lblrespuesta.Text = objromano.convertir(txtnum.Text)
    End Sub
End Class
Class conversor_romanos
    Dim romanos()() As String =
        {New String() {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"},
        New String() {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"},
        New String() {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"}}

    Dim u, d, c, temp As Integer



    Public Function convertir(ByVal num As Integer)
        u = num Mod 10
        c = num \ 100
        temp = num Mod 100
        d = temp \ 10
        Return romanos(2)(c) + romanos(1)(d) + romanos(0)(u)
    End Function







End Class