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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.btnmedia = New System.Windows.Forms.Button()
        Me.lblmedia = New System.Windows.Forms.Label()
        Me.lblvarianza = New System.Windows.Forms.Label()
        Me.lbldesviacion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(25, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Serie :"
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(106, 32)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(100, 20)
        Me.txtserie.TabIndex = 15
        Me.txtserie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnmedia
        '
        Me.btnmedia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnmedia.Location = New System.Drawing.Point(28, 182)
        Me.btnmedia.Name = "btnmedia"
        Me.btnmedia.Size = New System.Drawing.Size(75, 52)
        Me.btnmedia.TabIndex = 16
        Me.btnmedia.Text = "OPERAR"
        Me.btnmedia.UseVisualStyleBackColor = True
        '
        'lblmedia
        '
        Me.lblmedia.AutoSize = True
        Me.lblmedia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblmedia.Location = New System.Drawing.Point(158, 67)
        Me.lblmedia.Name = "lblmedia"
        Me.lblmedia.Size = New System.Drawing.Size(13, 13)
        Me.lblmedia.TabIndex = 17
        Me.lblmedia.Text = "?"
        '
        'lblvarianza
        '
        Me.lblvarianza.AutoSize = True
        Me.lblvarianza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblvarianza.Location = New System.Drawing.Point(158, 108)
        Me.lblvarianza.Name = "lblvarianza"
        Me.lblvarianza.Size = New System.Drawing.Size(13, 13)
        Me.lblvarianza.TabIndex = 18
        Me.lblvarianza.Text = "?"
        '
        'lbldesviacion
        '
        Me.lbldesviacion.AutoSize = True
        Me.lbldesviacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbldesviacion.Location = New System.Drawing.Point(158, 144)
        Me.lbldesviacion.Name = "lbldesviacion"
        Me.lbldesviacion.Size = New System.Drawing.Size(13, 13)
        Me.lbldesviacion.TabIndex = 19
        Me.lbldesviacion.Text = "?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(25, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "VARIANZA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(25, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "DESVIACION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(25, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "MEDIA"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(131, 182)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 52)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "NUEVO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 302)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbldesviacion)
        Me.Controls.Add(Me.lblvarianza)
        Me.Controls.Add(Me.lblmedia)
        Me.Controls.Add(Me.btnmedia)
        Me.Controls.Add(Me.txtserie)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Name = "Form1"
        Me.Text = "MATRICES Y POO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtserie As TextBox
    Friend WithEvents btnmedia As Button
    Friend WithEvents lblmedia As Label
    Friend WithEvents lblvarianza As Label
    Friend WithEvents lbldesviacion As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
