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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttabla = New System.Windows.Forms.TextBox()
        Me.lsttabla = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TABLA"
        '
        'txttabla
        '
        Me.txttabla.Location = New System.Drawing.Point(223, 136)
        Me.txttabla.Name = "txttabla"
        Me.txttabla.Size = New System.Drawing.Size(100, 20)
        Me.txttabla.TabIndex = 1
        '
        'lsttabla
        '
        Me.lsttabla.FormattingEnabled = True
        Me.lsttabla.Location = New System.Drawing.Point(419, 94)
        Me.lsttabla.Name = "lsttabla"
        Me.lsttabla.Size = New System.Drawing.Size(274, 238)
        Me.lsttabla.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(223, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 78)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "PROCESO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lsttabla)
        Me.Controls.Add(Me.txttabla)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txttabla As TextBox
    Friend WithEvents lsttabla As ListBox
    Friend WithEvents Button1 As Button
End Class
