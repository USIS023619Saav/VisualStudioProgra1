<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
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
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.lblcompuesto = New System.Windows.Forms.Label()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.lblrespuesta = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(459, 155)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(155, 26)
        Me.txtnum.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(349, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero :"
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
        'lblcompuesto
        '
        Me.lblcompuesto.AutoSize = True
        Me.lblcompuesto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblcompuesto.Location = New System.Drawing.Point(349, 348)
        Me.lblcompuesto.Name = "lblcompuesto"
        Me.lblcompuesto.Size = New System.Drawing.Size(153, 20)
        Me.lblcompuesto.TabIndex = 7
        Me.lblcompuesto.Text = "Interes Compuesto :"
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
        'lblrespuesta
        '
        Me.lblrespuesta.AutoSize = True
        Me.lblrespuesta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblrespuesta.Location = New System.Drawing.Point(526, 348)
        Me.lblrespuesta.Name = "lblrespuesta"
        Me.lblrespuesta.Size = New System.Drawing.Size(18, 20)
        Me.lblrespuesta.TabIndex = 11
        Me.lblrespuesta.Text = "?"
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 669)
        Me.Controls.Add(Me.lblrespuesta)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.lblcompuesto)
        Me.Controls.Add(Me.BtnCalcular)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnum)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "form1"
        Me.Text = "Ejercicios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents lblcompuesto As Label
    Friend WithEvents btnsalir As Button
    Friend WithEvents lblrespuesta As Label
End Class
