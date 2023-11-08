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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBoxControlPuerto = New System.Windows.Forms.GroupBox()
        Me.PictureBoxEstadoPuerto = New System.Windows.Forms.PictureBox()
        Me.LabelEstadoPuerto = New System.Windows.Forms.Label()
        Me.ButtonDesconectar = New System.Windows.Forms.Button()
        Me.ButtonConectar = New System.Windows.Forms.Button()
        Me.ComboBoxPuertos = New System.Windows.Forms.ComboBox()
        Me.GroupBoxSalida0 = New System.Windows.Forms.GroupBox()
        Me.ButtonSalida0Off = New System.Windows.Forms.Button()
        Me.ButtonSalida0On = New System.Windows.Forms.Button()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBoxSalida1 = New System.Windows.Forms.GroupBox()
        Me.ButtonSalida1Off = New System.Windows.Forms.Button()
        Me.ButtonSalida1On = New System.Windows.Forms.Button()
        Me.GroupBoxEntrada0 = New System.Windows.Forms.GroupBox()
        Me.LabelEstadoEntrada0 = New System.Windows.Forms.Label()
        Me.GroupBoxEntrada1 = New System.Windows.Forms.GroupBox()
        Me.LabelEstadoEntrada1 = New System.Windows.Forms.Label()
        Me.GroupBoxEntrada2 = New System.Windows.Forms.GroupBox()
        Me.LabelEstadoEntrada2 = New System.Windows.Forms.Label()
        Me.GroupBoxTodasSalidas = New System.Windows.Forms.GroupBox()
        Me.ButtonTodasSalidasOff = New System.Windows.Forms.Button()
        Me.ButtonTodasSalidasOn = New System.Windows.Forms.Button()
        Me.ButtonSalidaTemporizada = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonPulsosOn = New System.Windows.Forms.Button()
        Me.ButtonPulsosOff = New System.Windows.Forms.Button()
        Me.TimerPulsos = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBoxControlPuerto.SuspendLayout()
        CType(Me.PictureBoxEstadoPuerto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxSalida0.SuspendLayout()
        Me.GroupBoxSalida1.SuspendLayout()
        Me.GroupBoxEntrada0.SuspendLayout()
        Me.GroupBoxEntrada1.SuspendLayout()
        Me.GroupBoxEntrada2.SuspendLayout()
        Me.GroupBoxTodasSalidas.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxControlPuerto
        '
        Me.GroupBoxControlPuerto.Controls.Add(Me.PictureBoxEstadoPuerto)
        Me.GroupBoxControlPuerto.Controls.Add(Me.LabelEstadoPuerto)
        Me.GroupBoxControlPuerto.Controls.Add(Me.ButtonDesconectar)
        Me.GroupBoxControlPuerto.Controls.Add(Me.ButtonConectar)
        Me.GroupBoxControlPuerto.Controls.Add(Me.ComboBoxPuertos)
        Me.GroupBoxControlPuerto.Font = New System.Drawing.Font("Roboto Mono", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxControlPuerto.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxControlPuerto.Name = "GroupBoxControlPuerto"
        Me.GroupBoxControlPuerto.Size = New System.Drawing.Size(622, 106)
        Me.GroupBoxControlPuerto.TabIndex = 0
        Me.GroupBoxControlPuerto.TabStop = False
        Me.GroupBoxControlPuerto.Text = "CONTROL DE PUERTO"
        '
        'PictureBoxEstadoPuerto
        '
        Me.PictureBoxEstadoPuerto.Location = New System.Drawing.Point(211, 29)
        Me.PictureBoxEstadoPuerto.Name = "PictureBoxEstadoPuerto"
        Me.PictureBoxEstadoPuerto.Size = New System.Drawing.Size(64, 61)
        Me.PictureBoxEstadoPuerto.TabIndex = 4
        Me.PictureBoxEstadoPuerto.TabStop = False
        '
        'LabelEstadoPuerto
        '
        Me.LabelEstadoPuerto.AutoSize = True
        Me.LabelEstadoPuerto.Location = New System.Drawing.Point(7, 67)
        Me.LabelEstadoPuerto.Name = "LabelEstadoPuerto"
        Me.LabelEstadoPuerto.Size = New System.Drawing.Size(70, 23)
        Me.LabelEstadoPuerto.TabIndex = 3
        Me.LabelEstadoPuerto.Text = "Label1"
        '
        'ButtonDesconectar
        '
        Me.ButtonDesconectar.Location = New System.Drawing.Point(450, 29)
        Me.ButtonDesconectar.Name = "ButtonDesconectar"
        Me.ButtonDesconectar.Size = New System.Drawing.Size(163, 31)
        Me.ButtonDesconectar.TabIndex = 2
        Me.ButtonDesconectar.Text = "Disconnected"
        Me.ButtonDesconectar.UseVisualStyleBackColor = True
        '
        'ButtonConectar
        '
        Me.ButtonConectar.Location = New System.Drawing.Point(281, 29)
        Me.ButtonConectar.Name = "ButtonConectar"
        Me.ButtonConectar.Size = New System.Drawing.Size(152, 31)
        Me.ButtonConectar.TabIndex = 1
        Me.ButtonConectar.Text = "Connected"
        Me.ButtonConectar.UseVisualStyleBackColor = True
        '
        'ComboBoxPuertos
        '
        Me.ComboBoxPuertos.FormattingEnabled = True
        Me.ComboBoxPuertos.Location = New System.Drawing.Point(6, 29)
        Me.ComboBoxPuertos.Name = "ComboBoxPuertos"
        Me.ComboBoxPuertos.Size = New System.Drawing.Size(198, 31)
        Me.ComboBoxPuertos.TabIndex = 0
        '
        'GroupBoxSalida0
        '
        Me.GroupBoxSalida0.Controls.Add(Me.ButtonSalida0Off)
        Me.GroupBoxSalida0.Controls.Add(Me.ButtonSalida0On)
        Me.GroupBoxSalida0.Controls.Add(Me.ButtonSalidaTemporizada)
        Me.GroupBoxSalida0.Font = New System.Drawing.Font("Roboto Mono", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxSalida0.Location = New System.Drawing.Point(12, 124)
        Me.GroupBoxSalida0.Name = "GroupBoxSalida0"
        Me.GroupBoxSalida0.Size = New System.Drawing.Size(205, 117)
        Me.GroupBoxSalida0.TabIndex = 1
        Me.GroupBoxSalida0.TabStop = False
        Me.GroupBoxSalida0.Text = "Salida 0"
        '
        'ButtonSalida0Off
        '
        Me.ButtonSalida0Off.Location = New System.Drawing.Point(101, 30)
        Me.ButtonSalida0Off.Name = "ButtonSalida0Off"
        Me.ButtonSalida0Off.Size = New System.Drawing.Size(98, 36)
        Me.ButtonSalida0Off.TabIndex = 1
        Me.ButtonSalida0Off.Text = "Button2"
        Me.ButtonSalida0Off.UseVisualStyleBackColor = True
        '
        'ButtonSalida0On
        '
        Me.ButtonSalida0On.Location = New System.Drawing.Point(11, 30)
        Me.ButtonSalida0On.Name = "ButtonSalida0On"
        Me.ButtonSalida0On.Size = New System.Drawing.Size(84, 36)
        Me.ButtonSalida0On.TabIndex = 0
        Me.ButtonSalida0On.Text = "Button1"
        Me.ButtonSalida0On.UseVisualStyleBackColor = True
        '
        'SerialPort
        '
        '
        'GroupBoxSalida1
        '
        Me.GroupBoxSalida1.Controls.Add(Me.ButtonPulsosOff)
        Me.GroupBoxSalida1.Controls.Add(Me.ButtonSalida1Off)
        Me.GroupBoxSalida1.Controls.Add(Me.ButtonPulsosOn)
        Me.GroupBoxSalida1.Controls.Add(Me.ButtonSalida1On)
        Me.GroupBoxSalida1.Font = New System.Drawing.Font("Roboto Mono", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxSalida1.Location = New System.Drawing.Point(223, 124)
        Me.GroupBoxSalida1.Name = "GroupBoxSalida1"
        Me.GroupBoxSalida1.Size = New System.Drawing.Size(205, 117)
        Me.GroupBoxSalida1.TabIndex = 2
        Me.GroupBoxSalida1.TabStop = False
        Me.GroupBoxSalida1.Text = "Salida 1"
        '
        'ButtonSalida1Off
        '
        Me.ButtonSalida1Off.Location = New System.Drawing.Point(101, 29)
        Me.ButtonSalida1Off.Name = "ButtonSalida1Off"
        Me.ButtonSalida1Off.Size = New System.Drawing.Size(98, 36)
        Me.ButtonSalida1Off.TabIndex = 3
        Me.ButtonSalida1Off.Text = "Button2"
        Me.ButtonSalida1Off.UseVisualStyleBackColor = True
        '
        'ButtonSalida1On
        '
        Me.ButtonSalida1On.Location = New System.Drawing.Point(6, 29)
        Me.ButtonSalida1On.Name = "ButtonSalida1On"
        Me.ButtonSalida1On.Size = New System.Drawing.Size(89, 36)
        Me.ButtonSalida1On.TabIndex = 2
        Me.ButtonSalida1On.Text = "Button1"
        Me.ButtonSalida1On.UseVisualStyleBackColor = True
        '
        'GroupBoxEntrada0
        '
        Me.GroupBoxEntrada0.Controls.Add(Me.LabelEstadoEntrada0)
        Me.GroupBoxEntrada0.Font = New System.Drawing.Font("Roboto Mono", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxEntrada0.Location = New System.Drawing.Point(12, 247)
        Me.GroupBoxEntrada0.Name = "GroupBoxEntrada0"
        Me.GroupBoxEntrada0.Size = New System.Drawing.Size(205, 62)
        Me.GroupBoxEntrada0.TabIndex = 4
        Me.GroupBoxEntrada0.TabStop = False
        Me.GroupBoxEntrada0.Text = "Entrada 0"
        '
        'LabelEstadoEntrada0
        '
        Me.LabelEstadoEntrada0.AutoSize = True
        Me.LabelEstadoEntrada0.Location = New System.Drawing.Point(11, 30)
        Me.LabelEstadoEntrada0.Name = "LabelEstadoEntrada0"
        Me.LabelEstadoEntrada0.Size = New System.Drawing.Size(70, 23)
        Me.LabelEstadoEntrada0.TabIndex = 0
        Me.LabelEstadoEntrada0.Text = "Label2"
        '
        'GroupBoxEntrada1
        '
        Me.GroupBoxEntrada1.Controls.Add(Me.LabelEstadoEntrada1)
        Me.GroupBoxEntrada1.Font = New System.Drawing.Font("Roboto Mono", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxEntrada1.Location = New System.Drawing.Point(223, 247)
        Me.GroupBoxEntrada1.Name = "GroupBoxEntrada1"
        Me.GroupBoxEntrada1.Size = New System.Drawing.Size(205, 62)
        Me.GroupBoxEntrada1.TabIndex = 5
        Me.GroupBoxEntrada1.TabStop = False
        Me.GroupBoxEntrada1.Text = "Entrada 1"
        '
        'LabelEstadoEntrada1
        '
        Me.LabelEstadoEntrada1.AutoSize = True
        Me.LabelEstadoEntrada1.Location = New System.Drawing.Point(11, 30)
        Me.LabelEstadoEntrada1.Name = "LabelEstadoEntrada1"
        Me.LabelEstadoEntrada1.Size = New System.Drawing.Size(70, 23)
        Me.LabelEstadoEntrada1.TabIndex = 0
        Me.LabelEstadoEntrada1.Text = "Label2"
        '
        'GroupBoxEntrada2
        '
        Me.GroupBoxEntrada2.Controls.Add(Me.LabelEstadoEntrada2)
        Me.GroupBoxEntrada2.Font = New System.Drawing.Font("Roboto Mono", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxEntrada2.Location = New System.Drawing.Point(434, 247)
        Me.GroupBoxEntrada2.Name = "GroupBoxEntrada2"
        Me.GroupBoxEntrada2.Size = New System.Drawing.Size(200, 62)
        Me.GroupBoxEntrada2.TabIndex = 6
        Me.GroupBoxEntrada2.TabStop = False
        Me.GroupBoxEntrada2.Text = "Entrada 2"
        '
        'LabelEstadoEntrada2
        '
        Me.LabelEstadoEntrada2.AutoSize = True
        Me.LabelEstadoEntrada2.Location = New System.Drawing.Point(11, 30)
        Me.LabelEstadoEntrada2.Name = "LabelEstadoEntrada2"
        Me.LabelEstadoEntrada2.Size = New System.Drawing.Size(70, 23)
        Me.LabelEstadoEntrada2.TabIndex = 0
        Me.LabelEstadoEntrada2.Text = "Label2"
        '
        'GroupBoxTodasSalidas
        '
        Me.GroupBoxTodasSalidas.Controls.Add(Me.ButtonTodasSalidasOff)
        Me.GroupBoxTodasSalidas.Controls.Add(Me.ButtonTodasSalidasOn)
        Me.GroupBoxTodasSalidas.Font = New System.Drawing.Font("Roboto Mono", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxTodasSalidas.Location = New System.Drawing.Point(434, 124)
        Me.GroupBoxTodasSalidas.Name = "GroupBoxTodasSalidas"
        Me.GroupBoxTodasSalidas.Size = New System.Drawing.Size(205, 72)
        Me.GroupBoxTodasSalidas.TabIndex = 4
        Me.GroupBoxTodasSalidas.TabStop = False
        Me.GroupBoxTodasSalidas.Text = "Todas"
        '
        'ButtonTodasSalidasOff
        '
        Me.ButtonTodasSalidasOff.Location = New System.Drawing.Point(101, 29)
        Me.ButtonTodasSalidasOff.Name = "ButtonTodasSalidasOff"
        Me.ButtonTodasSalidasOff.Size = New System.Drawing.Size(98, 36)
        Me.ButtonTodasSalidasOff.TabIndex = 3
        Me.ButtonTodasSalidasOff.Text = "Button2"
        Me.ButtonTodasSalidasOff.UseVisualStyleBackColor = True
        '
        'ButtonTodasSalidasOn
        '
        Me.ButtonTodasSalidasOn.Location = New System.Drawing.Point(6, 29)
        Me.ButtonTodasSalidasOn.Name = "ButtonTodasSalidasOn"
        Me.ButtonTodasSalidasOn.Size = New System.Drawing.Size(89, 36)
        Me.ButtonTodasSalidasOn.TabIndex = 2
        Me.ButtonTodasSalidasOn.Text = "Button1"
        Me.ButtonTodasSalidasOn.UseVisualStyleBackColor = True
        '
        'ButtonSalidaTemporizada
        '
        Me.ButtonSalidaTemporizada.Location = New System.Drawing.Point(11, 72)
        Me.ButtonSalidaTemporizada.Name = "ButtonSalidaTemporizada"
        Me.ButtonSalidaTemporizada.Size = New System.Drawing.Size(188, 37)
        Me.ButtonSalidaTemporizada.TabIndex = 7
        Me.ButtonSalidaTemporizada.Text = "Button1"
        Me.ButtonSalidaTemporizada.UseVisualStyleBackColor = True
        '
        'Timer
        '
        '
        'ButtonPulsosOn
        '
        Me.ButtonPulsosOn.Location = New System.Drawing.Point(6, 71)
        Me.ButtonPulsosOn.Name = "ButtonPulsosOn"
        Me.ButtonPulsosOn.Size = New System.Drawing.Size(89, 37)
        Me.ButtonPulsosOn.TabIndex = 8
        Me.ButtonPulsosOn.Text = "Button1"
        Me.ButtonPulsosOn.UseVisualStyleBackColor = True
        '
        'ButtonPulsosOff
        '
        Me.ButtonPulsosOff.Location = New System.Drawing.Point(101, 71)
        Me.ButtonPulsosOff.Name = "ButtonPulsosOff"
        Me.ButtonPulsosOff.Size = New System.Drawing.Size(98, 37)
        Me.ButtonPulsosOff.TabIndex = 9
        Me.ButtonPulsosOff.Text = "Button1"
        Me.ButtonPulsosOff.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 319)
        Me.Controls.Add(Me.GroupBoxTodasSalidas)
        Me.Controls.Add(Me.GroupBoxEntrada2)
        Me.Controls.Add(Me.GroupBoxEntrada1)
        Me.Controls.Add(Me.GroupBoxEntrada0)
        Me.Controls.Add(Me.GroupBoxSalida1)
        Me.Controls.Add(Me.GroupBoxSalida0)
        Me.Controls.Add(Me.GroupBoxControlPuerto)
        Me.Name = "Form1"
        Me.Text = "Control PLC"
        Me.GroupBoxControlPuerto.ResumeLayout(False)
        Me.GroupBoxControlPuerto.PerformLayout()
        CType(Me.PictureBoxEstadoPuerto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxSalida0.ResumeLayout(False)
        Me.GroupBoxSalida1.ResumeLayout(False)
        Me.GroupBoxEntrada0.ResumeLayout(False)
        Me.GroupBoxEntrada0.PerformLayout()
        Me.GroupBoxEntrada1.ResumeLayout(False)
        Me.GroupBoxEntrada1.PerformLayout()
        Me.GroupBoxEntrada2.ResumeLayout(False)
        Me.GroupBoxEntrada2.PerformLayout()
        Me.GroupBoxTodasSalidas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxControlPuerto As GroupBox
    Friend WithEvents ComboBoxPuertos As ComboBox
    Friend WithEvents GroupBoxSalida0 As GroupBox
    Friend WithEvents ButtonConectar As Button
    Friend WithEvents ButtonDesconectar As Button
    Friend WithEvents LabelEstadoPuerto As Label
    Friend WithEvents PictureBoxEstadoPuerto As PictureBox
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents GroupBoxSalida1 As GroupBox
    Friend WithEvents GroupBoxEntrada0 As GroupBox
    Friend WithEvents LabelEstadoEntrada0 As Label
    Friend WithEvents GroupBoxEntrada1 As GroupBox
    Friend WithEvents LabelEstadoEntrada1 As Label
    Friend WithEvents GroupBoxEntrada2 As GroupBox
    Friend WithEvents LabelEstadoEntrada2 As Label
    Friend WithEvents ButtonSalida0Off As Button
    Friend WithEvents ButtonSalida0On As Button
    Friend WithEvents ButtonSalida1Off As Button
    Friend WithEvents ButtonSalida1On As Button
    Friend WithEvents GroupBoxTodasSalidas As GroupBox
    Friend WithEvents ButtonTodasSalidasOff As Button
    Friend WithEvents ButtonTodasSalidasOn As Button
    Friend WithEvents ButtonSalidaTemporizada As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents ButtonPulsosOn As Button
    Friend WithEvents ButtonPulsosOff As Button
    Friend WithEvents TimerPulsos As Timer
End Class
