Public Class Form1
    Dim objintereses As New interes()



    Class interes
        Dim _interes As Double, _ntiempo As Int16, _capital As Double

        Public Property inter
            Set(value)
                If value >= 0 And value <= 100 Then
                    _interes = value
                Else
                    MessageBox.Show("El valor del interes no es valido", "Intereses", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Set
            Get
                Return _interes
            End Get
        End Property
        Public Property tiempo
            Set(value)
                If value >= 1 And value <= 120 Then
                    _ntiempo = value
                Else
                    MessageBox.Show("Tiempo no es valido", "Intereses", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Set
            Get
                Return _ntiempo
            End Get
        End Property
        Public Property monto
            Set(value)
                If value > 0 Then
                    _capital = value
                Else
                    MessageBox.Show("El capital debe ser mayor a 0", "Intereses", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Set
            Get
                Return _capital
            End Get
        End Property

        Public Function interesSimple()
            Dim ins = _capital * (_interes / 100) * (_ntiempo / 12)
            Return Math.Round(ins, 2)
        End Function
        Public Function interesCompuesto()
            Dim inC = _capital * (1 + _interes / 100) ^ _ntiempo
            Return Math.Round(inC, 2)
        End Function

    End Class



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub comb_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        objintereses.inter = txtinteres.Text
        objintereses.tiempo = txtaños.Text

        objintereses.monto = txtcap.Text
        lblsimple.Text = "interes simple : $" & objintereses.interesSimple()

        lblcompuesto.Text = "Interes Compuesto: $" & objintereses.interesCompuesto()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click

        MessageBox.Show("Tenga un buen dia.")

        End

    End Sub
End Class
