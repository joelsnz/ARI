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
        Me.ComboBoxColors = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonBeep = New System.Windows.Forms.Button()
        Me.ButtonFondo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBoxColors
        '
        Me.ComboBoxColors.FormattingEnabled = True
        Me.ComboBoxColors.Items.AddRange(New Object() {"Rojo", "Verde", "Azul"})
        Me.ComboBoxColors.Location = New System.Drawing.Point(13, 13)
        Me.ComboBoxColors.Name = "ComboBoxColors"
        Me.ComboBoxColors.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxColors.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(141, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "             "
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(195, 13)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 24)
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonBeep
        '
        Me.ButtonBeep.Location = New System.Drawing.Point(195, 43)
        Me.ButtonBeep.Name = "ButtonBeep"
        Me.ButtonBeep.Size = New System.Drawing.Size(75, 24)
        Me.ButtonBeep.TabIndex = 3
        Me.ButtonBeep.Text = "Beep"
        Me.ButtonBeep.UseVisualStyleBackColor = True
        '
        'ButtonFondo
        '
        Me.ButtonFondo.Location = New System.Drawing.Point(195, 73)
        Me.ButtonFondo.Name = "ButtonFondo"
        Me.ButtonFondo.Size = New System.Drawing.Size(75, 24)
        Me.ButtonFondo.TabIndex = 4
        Me.ButtonFondo.Text = "Fondo"
        Me.ButtonFondo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 107)
        Me.Controls.Add(Me.ButtonFondo)
        Me.Controls.Add(Me.ButtonBeep)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxColors)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxColors As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonClose As Button
    Friend WithEvents ButtonBeep As Button
    Friend WithEvents ButtonFondo As Button
End Class
