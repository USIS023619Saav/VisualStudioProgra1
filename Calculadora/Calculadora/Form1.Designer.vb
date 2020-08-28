<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtcap = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.txtinteres = New System.Windows.Forms.TextBox()
        Me.txtaños = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblcompuesto = New System.Windows.Forms.Label()
        Me.lblsimple = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtcap
        '
        Me.txtcap.Location = New System.Drawing.Point(283, 148)
        Me.txtcap.Name = "txtcap"
        Me.txtcap.Size = New System.Drawing.Size(100, 26)
        Me.txtcap.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(180, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Capital :"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCalcular.Location = New System.Drawing.Point(283, 436)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(207, 94)
        Me.BtnCalcular.TabIndex = 2
        Me.BtnCalcular.Text = "CALCULAR"
        Me.BtnCalcular.UseVisualStyleBackColor = False
        '
        'txtinteres
        '
        Me.txtinteres.Location = New System.Drawing.Point(520, 151)
        Me.txtinteres.Name = "txtinteres"
        Me.txtinteres.Size = New System.Drawing.Size(100, 26)
        Me.txtinteres.TabIndex = 3
        '
        'txtaños
        '
        Me.txtaños.Location = New System.Drawing.Point(819, 152)
        Me.txtaños.Name = "txtaños"
        Me.txtaños.Size = New System.Drawing.Size(100, 26)
        Me.txtaños.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(686, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tiempo (Años)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(443, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Interes :"
        '
        'lblcompuesto
        '
        Me.lblcompuesto.AutoSize = True
        Me.lblcompuesto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblcompuesto.Location = New System.Drawing.Point(723, 326)
        Me.lblcompuesto.Name = "lblcompuesto"
        Me.lblcompuesto.Size = New System.Drawing.Size(153, 20)
        Me.lblcompuesto.TabIndex = 7
        Me.lblcompuesto.Text = "Interes Compuesto :"
        '
        'lblsimple
        '
        Me.lblsimple.AutoSize = True
        Me.lblsimple.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblsimple.Location = New System.Drawing.Point(263, 326)
        Me.lblsimple.Name = "lblsimple"
        Me.lblsimple.Size = New System.Drawing.Size(119, 20)
        Me.lblsimple.TabIndex = 9
        Me.lblsimple.Text = "Interes Simple :"
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnsalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsalir.Location = New System.Drawing.Point(623, 436)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(207, 94)
        Me.btnsalir.TabIndex = 10
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 669)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.lblsimple)
        Me.Controls.Add(Me.lblcompuesto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtaños)
        Me.Controls.Add(Me.txtinteres)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcap)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Ejercicios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtcap As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents txtinteres As TextBox
    Friend WithEvents txtaños As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblcompuesto As Label
    Friend WithEvents lblsimple As Label
    Friend WithEvents btnsalir As Button
End Class
