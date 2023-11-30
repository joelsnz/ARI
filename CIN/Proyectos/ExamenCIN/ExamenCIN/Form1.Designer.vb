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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBoxControlPuerto = New System.Windows.Forms.GroupBox()
        Me.ButtonDesconectar = New System.Windows.Forms.Button()
        Me.ButtonConectar = New System.Windows.Forms.Button()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBoxSalida0 = New System.Windows.Forms.GroupBox()
        Me.ButtonSalida0Off = New System.Windows.Forms.Button()
        Me.ButtonSalida0On = New System.Windows.Forms.Button()
        Me.GroupBoxSalida1 = New System.Windows.Forms.GroupBox()
        Me.ButtonSalida1Off = New System.Windows.Forms.Button()
        Me.ButtonSalida1On = New System.Windows.Forms.Button()
        Me.GroupBoxControlPuerto.SuspendLayout()
        Me.GroupBoxSalida0.SuspendLayout()
        Me.GroupBoxSalida1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxControlPuerto
        '
        Me.GroupBoxControlPuerto.Controls.Add(Me.ButtonDesconectar)
        Me.GroupBoxControlPuerto.Controls.Add(Me.ButtonConectar)
        Me.GroupBoxControlPuerto.Font = New System.Drawing.Font("Roboto Mono", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxControlPuerto.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxControlPuerto.Name = "GroupBoxControlPuerto"
        Me.GroupBoxControlPuerto.Size = New System.Drawing.Size(343, 74)
        Me.GroupBoxControlPuerto.TabIndex = 1
        Me.GroupBoxControlPuerto.TabStop = False
        Me.GroupBoxControlPuerto.Text = "CONTROL DE PUERTO"
        '
        'ButtonDesconectar
        '
        Me.ButtonDesconectar.Location = New System.Drawing.Point(169, 29)
        Me.ButtonDesconectar.Name = "ButtonDesconectar"
        Me.ButtonDesconectar.Size = New System.Drawing.Size(163, 31)
        Me.ButtonDesconectar.TabIndex = 2
        Me.ButtonDesconectar.Text = "Disconnected"
        Me.ButtonDesconectar.UseVisualStyleBackColor = True
        '
        'ButtonConectar
        '
        Me.ButtonConectar.Location = New System.Drawing.Point(11, 29)
        Me.ButtonConectar.Name = "ButtonConectar"
        Me.ButtonConectar.Size = New System.Drawing.Size(152, 31)
        Me.ButtonConectar.TabIndex = 1
        Me.ButtonConectar.Text = "Connected"
        Me.ButtonConectar.UseVisualStyleBackColor = True
        '
        'GroupBoxSalida0
        '
        Me.GroupBoxSalida0.Controls.Add(Me.ButtonSalida0Off)
        Me.GroupBoxSalida0.Controls.Add(Me.ButtonSalida0On)
        Me.GroupBoxSalida0.Font = New System.Drawing.Font("Roboto Mono", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxSalida0.Location = New System.Drawing.Point(12, 92)
        Me.GroupBoxSalida0.Name = "GroupBoxSalida0"
        Me.GroupBoxSalida0.Size = New System.Drawing.Size(343, 75)
        Me.GroupBoxSalida0.TabIndex = 2
        Me.GroupBoxSalida0.TabStop = False
        Me.GroupBoxSalida0.Text = "Salida 0"
        '
        'ButtonSalida0Off
        '
        Me.ButtonSalida0Off.Location = New System.Drawing.Point(163, 30)
        Me.ButtonSalida0Off.Name = "ButtonSalida0Off"
        Me.ButtonSalida0Off.Size = New System.Drawing.Size(169, 36)
        Me.ButtonSalida0Off.TabIndex = 2
        Me.ButtonSalida0Off.Text = "Button2"
        Me.ButtonSalida0Off.UseVisualStyleBackColor = True
        '
        'ButtonSalida0On
        '
        Me.ButtonSalida0On.Location = New System.Drawing.Point(11, 30)
        Me.ButtonSalida0On.Name = "ButtonSalida0On"
        Me.ButtonSalida0On.Size = New System.Drawing.Size(146, 36)
        Me.ButtonSalida0On.TabIndex = 0
        Me.ButtonSalida0On.Text = "Button1"
        Me.ButtonSalida0On.UseVisualStyleBackColor = True
        '
        'GroupBoxSalida1
        '
        Me.GroupBoxSalida1.Controls.Add(Me.ButtonSalida1Off)
        Me.GroupBoxSalida1.Controls.Add(Me.ButtonSalida1On)
        Me.GroupBoxSalida1.Font = New System.Drawing.Font("Roboto Mono", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxSalida1.Location = New System.Drawing.Point(12, 173)
        Me.GroupBoxSalida1.Name = "GroupBoxSalida1"
        Me.GroupBoxSalida1.Size = New System.Drawing.Size(343, 75)
        Me.GroupBoxSalida1.TabIndex = 3
        Me.GroupBoxSalida1.TabStop = False
        Me.GroupBoxSalida1.Text = "Salida 1"
        '
        'ButtonSalida1Off
        '
        Me.ButtonSalida1Off.Location = New System.Drawing.Point(163, 30)
        Me.ButtonSalida1Off.Name = "ButtonSalida1Off"
        Me.ButtonSalida1Off.Size = New System.Drawing.Size(169, 36)
        Me.ButtonSalida1Off.TabIndex = 2
        Me.ButtonSalida1Off.Text = "Button2"
        Me.ButtonSalida1Off.UseVisualStyleBackColor = True
        '
        'ButtonSalida1On
        '
        Me.ButtonSalida1On.Location = New System.Drawing.Point(11, 30)
        Me.ButtonSalida1On.Name = "ButtonSalida1On"
        Me.ButtonSalida1On.Size = New System.Drawing.Size(146, 36)
        Me.ButtonSalida1On.TabIndex = 0
        Me.ButtonSalida1On.Text = "Button1"
        Me.ButtonSalida1On.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 257)
        Me.Controls.Add(Me.GroupBoxSalida1)
        Me.Controls.Add(Me.GroupBoxSalida0)
        Me.Controls.Add(Me.GroupBoxControlPuerto)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBoxControlPuerto.ResumeLayout(False)
        Me.GroupBoxSalida0.ResumeLayout(False)
        Me.GroupBoxSalida1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxControlPuerto As GroupBox
    Friend WithEvents ButtonDesconectar As Button
    Friend WithEvents ButtonConectar As Button
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents GroupBoxSalida0 As GroupBox
    Friend WithEvents ButtonSalida0On As Button
    Friend WithEvents ButtonSalida0Off As Button
    Friend WithEvents GroupBoxSalida1 As GroupBox
    Friend WithEvents ButtonSalida1Off As Button
    Friend WithEvents ButtonSalida1On As Button
End Class
