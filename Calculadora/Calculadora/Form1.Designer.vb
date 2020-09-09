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
        Me.cbodepto = New System.Windows.Forms.ComboBox()
        Me.cbomun = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'n1
        '
        Me.n1.AutoSize = True
        Me.n1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.n1.Location = New System.Drawing.Point(203, 164)
        Me.n1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.n1.Name = "n1"
        Me.n1.Size = New System.Drawing.Size(159, 25)
        Me.n1.TabIndex = 0
        Me.n1.Text = "Departamento :"
        '
        'n2
        '
        Me.n2.AutoSize = True
        Me.n2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.n2.Location = New System.Drawing.Point(688, 167)
        Me.n2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.n2.Name = "n2"
        Me.n2.Size = New System.Drawing.Size(116, 25)
        Me.n2.TabIndex = 1
        Me.n2.Text = "Municipio :"
        '
        'cbodepto
        '
        Me.cbodepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbodepto.FormattingEnabled = True
        Me.cbodepto.Location = New System.Drawing.Point(371, 164)
        Me.cbodepto.Name = "cbodepto"
        Me.cbodepto.Size = New System.Drawing.Size(274, 33)
        Me.cbodepto.TabIndex = 5
        '
        'cbomun
        '
        Me.cbomun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomun.FormattingEnabled = True
        Me.cbomun.Location = New System.Drawing.Point(852, 164)
        Me.cbomun.Name = "cbomun"
        Me.cbomun.Size = New System.Drawing.Size(281, 33)
        Me.cbomun.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1600, 865)
        Me.Controls.Add(Me.cbomun)
        Me.Controls.Add(Me.cbodepto)
        Me.Controls.Add(Me.n2)
        Me.Controls.Add(Me.n1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "v"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents n1 As Label
    Friend WithEvents n2 As Label
    Friend WithEvents cbodepto As ComboBox
    Friend WithEvents cbomun As ComboBox
End Class
