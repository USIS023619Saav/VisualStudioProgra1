<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CALCULADORASTEVV
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbltxtn1 = New System.Windows.Forms.Label()
        Me.lbltxtn2 = New System.Windows.Forms.Label()
        Me.respuesta = New System.Windows.Forms.Label()
        Me.optsuma = New System.Windows.Forms.RadioButton()
        Me.optresta = New System.Windows.Forms.RadioButton()
        Me.optmultiplicacion = New System.Windows.Forms.RadioButton()
        Me.optdivision = New System.Windows.Forms.RadioButton()
        Me.optporcentaje = New System.Windows.Forms.RadioButton()
        Me.optexponente = New System.Windows.Forms.RadioButton()
        Me.optmod = New System.Windows.Forms.RadioButton()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.CALCULAR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbltxtn1
        '
        Me.lbltxtn1.AutoSize = True
        Me.lbltxtn1.Location = New System.Drawing.Point(221, 81)
        Me.lbltxtn1.Name = "lbltxtn1"
        Me.lbltxtn1.Size = New System.Drawing.Size(38, 13)
        Me.lbltxtn1.TabIndex = 0
        Me.lbltxtn1.Text = "NUM1"
        '
        'lbltxtn2
        '
        Me.lbltxtn2.AutoSize = True
        Me.lbltxtn2.Location = New System.Drawing.Point(377, 81)
        Me.lbltxtn2.Name = "lbltxtn2"
        Me.lbltxtn2.Size = New System.Drawing.Size(38, 13)
        Me.lbltxtn2.TabIndex = 1
        Me.lbltxtn2.Text = "NUM2"
        '
        'respuesta
        '
        Me.respuesta.AutoSize = True
        Me.respuesta.Location = New System.Drawing.Point(595, 84)
        Me.respuesta.Name = "respuesta"
        Me.respuesta.Size = New System.Drawing.Size(87, 13)
        Me.respuesta.TabIndex = 2
        Me.respuesta.Text = "RESPUESTA ??"
        '
        'optsuma
        '
        Me.optsuma.AutoSize = True
        Me.optsuma.Location = New System.Drawing.Point(665, 197)
        Me.optsuma.Name = "optsuma"
        Me.optsuma.Size = New System.Drawing.Size(31, 17)
        Me.optsuma.TabIndex = 3
        Me.optsuma.TabStop = True
        Me.optsuma.Text = "+"
        Me.optsuma.UseVisualStyleBackColor = True
        '
        'optresta
        '
        Me.optresta.AutoSize = True
        Me.optresta.Location = New System.Drawing.Point(665, 220)
        Me.optresta.Name = "optresta"
        Me.optresta.Size = New System.Drawing.Size(28, 17)
        Me.optresta.TabIndex = 4
        Me.optresta.TabStop = True
        Me.optresta.Text = "-"
        Me.optresta.UseVisualStyleBackColor = True
        '
        'optmultiplicacion
        '
        Me.optmultiplicacion.AutoSize = True
        Me.optmultiplicacion.Location = New System.Drawing.Point(665, 243)
        Me.optmultiplicacion.Name = "optmultiplicacion"
        Me.optmultiplicacion.Size = New System.Drawing.Size(29, 17)
        Me.optmultiplicacion.TabIndex = 5
        Me.optmultiplicacion.TabStop = True
        Me.optmultiplicacion.Text = "*"
        Me.optmultiplicacion.UseVisualStyleBackColor = True
        '
        'optdivision
        '
        Me.optdivision.AutoSize = True
        Me.optdivision.Location = New System.Drawing.Point(665, 266)
        Me.optdivision.Name = "optdivision"
        Me.optdivision.Size = New System.Drawing.Size(30, 17)
        Me.optdivision.TabIndex = 6
        Me.optdivision.TabStop = True
        Me.optdivision.Text = "/"
        Me.optdivision.UseVisualStyleBackColor = True
        '
        'optporcentaje
        '
        Me.optporcentaje.AutoSize = True
        Me.optporcentaje.Location = New System.Drawing.Point(665, 289)
        Me.optporcentaje.Name = "optporcentaje"
        Me.optporcentaje.Size = New System.Drawing.Size(33, 17)
        Me.optporcentaje.TabIndex = 7
        Me.optporcentaje.TabStop = True
        Me.optporcentaje.Text = "%"
        Me.optporcentaje.UseVisualStyleBackColor = True
        '
        'optexponente
        '
        Me.optexponente.AutoSize = True
        Me.optexponente.Location = New System.Drawing.Point(665, 312)
        Me.optexponente.Name = "optexponente"
        Me.optexponente.Size = New System.Drawing.Size(31, 17)
        Me.optexponente.TabIndex = 8
        Me.optexponente.TabStop = True
        Me.optexponente.Text = "^"
        Me.optexponente.UseVisualStyleBackColor = True
        '
        'optmod
        '
        Me.optmod.AutoSize = True
        Me.optmod.Location = New System.Drawing.Point(665, 335)
        Me.optmod.Name = "optmod"
        Me.optmod.Size = New System.Drawing.Size(50, 17)
        Me.optmod.TabIndex = 9
        Me.optmod.TabStop = True
        Me.optmod.Text = "MOD"
        Me.optmod.UseVisualStyleBackColor = True
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(267, 81)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(100, 20)
        Me.txtnum1.TabIndex = 10
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(432, 81)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(100, 20)
        Me.txtnum2.TabIndex = 11
        '
        'CALCULAR
        '
        Me.CALCULAR.Location = New System.Drawing.Point(357, 197)
        Me.CALCULAR.Name = "CALCULAR"
        Me.CALCULAR.Size = New System.Drawing.Size(75, 23)
        Me.CALCULAR.TabIndex = 12
        Me.CALCULAR.Text = "CALCULAR"
        Me.CALCULAR.UseVisualStyleBackColor = True
        '
        'CALCULADORASTEVV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CALCULAR)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.optmod)
        Me.Controls.Add(Me.optexponente)
        Me.Controls.Add(Me.optporcentaje)
        Me.Controls.Add(Me.optdivision)
        Me.Controls.Add(Me.optmultiplicacion)
        Me.Controls.Add(Me.optresta)
        Me.Controls.Add(Me.optsuma)
        Me.Controls.Add(Me.respuesta)
        Me.Controls.Add(Me.lbltxtn2)
        Me.Controls.Add(Me.lbltxtn1)
        Me.Name = "CALCULADORASTEVV"
        Me.Text = "CALCULADORASTEEEV"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltxtn1 As Label
    Friend WithEvents lbltxtn2 As Label
    Friend WithEvents respuesta As Label
    Friend WithEvents optsuma As RadioButton
    Friend WithEvents optresta As RadioButton
    Friend WithEvents optmultiplicacion As RadioButton
    Friend WithEvents optdivision As RadioButton
    Friend WithEvents optporcentaje As RadioButton
    Friend WithEvents optexponente As RadioButton
    Friend WithEvents optmod As RadioButton
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents CALCULAR As Button
End Class
