<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.n1 = New System.Windows.Forms.Label()
        Me.n2 = New System.Windows.Forms.Label()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.cal = New System.Windows.Forms.Button()
        Me.optsuma = New System.Windows.Forms.RadioButton()
        Me.optresta = New System.Windows.Forms.RadioButton()
        Me.optdivision = New System.Windows.Forms.RadioButton()
        Me.optmultiplicacion = New System.Windows.Forms.RadioButton()
        Me.optporcen = New System.Windows.Forms.RadioButton()
        Me.optmodis = New System.Windows.Forms.RadioButton()
        Me.optelevacion = New System.Windows.Forms.RadioButton()
        Me.result = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'n1
        '
        Me.n1.AutoSize = True
        Me.n1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.n1.Location = New System.Drawing.Point(132, 75)
        Me.n1.Name = "n1"
        Me.n1.Size = New System.Drawing.Size(38, 13)
        Me.n1.TabIndex = 0
        Me.n1.Text = "Num 1"
        '
        'n2
        '
        Me.n2.AutoSize = True
        Me.n2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.n2.Location = New System.Drawing.Point(350, 75)
        Me.n2.Name = "n2"
        Me.n2.Size = New System.Drawing.Size(38, 13)
        Me.n2.TabIndex = 1
        Me.n2.Text = "Num 2"
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(177, 72)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(100, 20)
        Me.txtnum1.TabIndex = 2
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(414, 72)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(100, 20)
        Me.txtnum2.TabIndex = 3
        '
        'cal
        '
        Me.cal.BackColor = System.Drawing.SystemColors.HotTrack
        Me.cal.Location = New System.Drawing.Point(294, 181)
        Me.cal.Name = "cal"
        Me.cal.Size = New System.Drawing.Size(75, 23)
        Me.cal.TabIndex = 4
        Me.cal.Text = "Calcular"
        Me.cal.UseVisualStyleBackColor = False
        '
        'optsuma
        '
        Me.optsuma.AutoSize = True
        Me.optsuma.Checked = True
        Me.optsuma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.optsuma.Location = New System.Drawing.Point(12, 150)
        Me.optsuma.Name = "optsuma"
        Me.optsuma.Size = New System.Drawing.Size(31, 17)
        Me.optsuma.TabIndex = 5
        Me.optsuma.TabStop = True
        Me.optsuma.Text = "+"
        Me.optsuma.UseVisualStyleBackColor = True
        '
        'optresta
        '
        Me.optresta.AutoSize = True
        Me.optresta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.optresta.Location = New System.Drawing.Point(12, 181)
        Me.optresta.Name = "optresta"
        Me.optresta.Size = New System.Drawing.Size(28, 17)
        Me.optresta.TabIndex = 6
        Me.optresta.Text = "-"
        Me.optresta.UseVisualStyleBackColor = True
        '
        'optdivision
        '
        Me.optdivision.AutoSize = True
        Me.optdivision.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.optdivision.Location = New System.Drawing.Point(12, 214)
        Me.optdivision.Name = "optdivision"
        Me.optdivision.Size = New System.Drawing.Size(30, 17)
        Me.optdivision.TabIndex = 7
        Me.optdivision.Text = "/"
        Me.optdivision.UseVisualStyleBackColor = True
        '
        'optmultiplicacion
        '
        Me.optmultiplicacion.AutoSize = True
        Me.optmultiplicacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.optmultiplicacion.Location = New System.Drawing.Point(12, 246)
        Me.optmultiplicacion.Name = "optmultiplicacion"
        Me.optmultiplicacion.Size = New System.Drawing.Size(29, 17)
        Me.optmultiplicacion.TabIndex = 8
        Me.optmultiplicacion.Text = "*"
        Me.optmultiplicacion.UseVisualStyleBackColor = True
        '
        'optporcen
        '
        Me.optporcen.AutoSize = True
        Me.optporcen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.optporcen.Location = New System.Drawing.Point(12, 278)
        Me.optporcen.Name = "optporcen"
        Me.optporcen.Size = New System.Drawing.Size(33, 17)
        Me.optporcen.TabIndex = 9
        Me.optporcen.Text = "%"
        Me.optporcen.UseVisualStyleBackColor = True
        '
        'optmodis
        '
        Me.optmodis.AutoSize = True
        Me.optmodis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.optmodis.Location = New System.Drawing.Point(12, 346)
        Me.optmodis.Name = "optmodis"
        Me.optmodis.Size = New System.Drawing.Size(50, 17)
        Me.optmodis.TabIndex = 10
        Me.optmodis.Text = "MOD"
        Me.optmodis.UseVisualStyleBackColor = True
        '
        'optelevacion
        '
        Me.optelevacion.AutoSize = True
        Me.optelevacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.optelevacion.Location = New System.Drawing.Point(12, 314)
        Me.optelevacion.Name = "optelevacion"
        Me.optelevacion.Size = New System.Drawing.Size(31, 17)
        Me.optelevacion.TabIndex = 11
        Me.optelevacion.Text = "^"
        Me.optelevacion.UseVisualStyleBackColor = True
        '
        'result
        '
        Me.result.AutoSize = True
        Me.result.Location = New System.Drawing.Point(566, 79)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(67, 13)
        Me.result.TabIndex = 12
        Me.result.Text = "Respuesta ?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.optelevacion)
        Me.Controls.Add(Me.optmodis)
        Me.Controls.Add(Me.optporcen)
        Me.Controls.Add(Me.optmultiplicacion)
        Me.Controls.Add(Me.optdivision)
        Me.Controls.Add(Me.optresta)
        Me.Controls.Add(Me.optsuma)
        Me.Controls.Add(Me.cal)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.n2)
        Me.Controls.Add(Me.n1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents n1 As Label
    Friend WithEvents n2 As Label
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents cal As Button
    Friend WithEvents optsuma As RadioButton
    Friend WithEvents optresta As RadioButton
    Friend WithEvents optdivision As RadioButton
    Friend WithEvents optmultiplicacion As RadioButton
    Friend WithEvents optporcen As RadioButton
    Friend WithEvents optmodis As RadioButton
    Friend WithEvents optelevacion As RadioButton
    Friend WithEvents result As Label
End Class
