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
        Me.lstejercicios = New System.Windows.Forms.ListBox()
        Me.btnp = New System.Windows.Forms.Button()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.btnpar = New System.Windows.Forms.Button()
        Me.btnprimo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncajero = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstejercicios
        '
        Me.lstejercicios.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lstejercicios.FormattingEnabled = True
        Me.lstejercicios.Location = New System.Drawing.Point(28, 38)
        Me.lstejercicios.Name = "lstejercicios"
        Me.lstejercicios.Size = New System.Drawing.Size(170, 264)
        Me.lstejercicios.TabIndex = 0
        '
        'btnp
        '
        Me.btnp.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnp.Location = New System.Drawing.Point(42, 310)
        Me.btnp.Name = "btnp"
        Me.btnp.Size = New System.Drawing.Size(138, 89)
        Me.btnp.TabIndex = 1
        Me.btnp.Text = "NPARES"
        Me.btnp.UseVisualStyleBackColor = False
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(340, 93)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(170, 20)
        Me.txtnum.TabIndex = 2
        '
        'btnpar
        '
        Me.btnpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnpar.Location = New System.Drawing.Point(263, 168)
        Me.btnpar.Name = "btnpar"
        Me.btnpar.Size = New System.Drawing.Size(99, 63)
        Me.btnpar.TabIndex = 3
        Me.btnpar.Text = "PAR  / IMPAR"
        Me.btnpar.UseVisualStyleBackColor = True
        '
        'btnprimo
        '
        Me.btnprimo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnprimo.Location = New System.Drawing.Point(377, 168)
        Me.btnprimo.Name = "btnprimo"
        Me.btnprimo.Size = New System.Drawing.Size(75, 63)
        Me.btnprimo.TabIndex = 4
        Me.btnprimo.Text = "PRIMO"
        Me.btnprimo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(244, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "NUMERO"
        '
        'btncajero
        '
        Me.btncajero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btncajero.Location = New System.Drawing.Point(467, 168)
        Me.btncajero.Name = "btncajero"
        Me.btncajero.Size = New System.Drawing.Size(75, 63)
        Me.btncajero.TabIndex = 6
        Me.btncajero.Text = "CAJERO"
        Me.btncajero.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(650, 450)
        Me.Controls.Add(Me.btncajero)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnprimo)
        Me.Controls.Add(Me.btnpar)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.btnp)
        Me.Controls.Add(Me.lstejercicios)
        Me.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Name = "Form1"
        Me.Text = "EJERCICIOS BASICOS"
        Me.TransparencyKey = System.Drawing.Color.DarkRed
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstejercicios As ListBox
    Friend WithEvents btnp As Button
    Friend WithEvents txtnum As TextBox
    Friend WithEvents btnpar As Button
    Friend WithEvents btnprimo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btncajero As Button
End Class
