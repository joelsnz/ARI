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
        Me.GroupBox_Flujo_de_Tramas = New System.Windows.Forms.GroupBox()
        Me.Button_Limpiar_TextBox = New System.Windows.Forms.Button()
        Me.TextBox_Trama_Recibida = New System.Windows.Forms.TextBox()
        Me.TextBox_Trama_Enviada = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_Estado_Puerto = New System.Windows.Forms.Label()
        Me.Button_Desconectar = New System.Windows.Forms.Button()
        Me.Button_Conectar = New System.Windows.Forms.Button()
        Me.PictureBox_Estado = New System.Windows.Forms.PictureBox()
        Me.ComboBox_Puertos = New System.Windows.Forms.ComboBox()
        Me.GroupBox_Variador = New System.Windows.Forms.GroupBox()
        Me.Label_Frecuencia_Leida = New System.Windows.Forms.Label()
        Me.Button_Leer_Frecuencia = New System.Windows.Forms.Button()
        Me.Button_Run_Forward = New System.Windows.Forms.Button()
        Me.Button_Stop = New System.Windows.Forms.Button()
        Me.Button_Run_Backward = New System.Windows.Forms.Button()
        Me.ComboBox_Frecuencias = New System.Windows.Forms.ComboBox()
        Me.Label_Frecuencias = New System.Windows.Forms.Label()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox_Flujo_de_Tramas.SuspendLayout()
        CType(Me.PictureBox_Estado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Variador.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_Flujo_de_Tramas
        '
        Me.GroupBox_Flujo_de_Tramas.Controls.Add(Me.Button_Limpiar_TextBox)
        Me.GroupBox_Flujo_de_Tramas.Controls.Add(Me.TextBox_Trama_Recibida)
        Me.GroupBox_Flujo_de_Tramas.Controls.Add(Me.TextBox_Trama_Enviada)
        Me.GroupBox_Flujo_de_Tramas.Controls.Add(Me.Label2)
        Me.GroupBox_Flujo_de_Tramas.Controls.Add(Me.Label1)
        Me.GroupBox_Flujo_de_Tramas.Controls.Add(Me.Label_Estado_Puerto)
        Me.GroupBox_Flujo_de_Tramas.Controls.Add(Me.Button_Desconectar)
        Me.GroupBox_Flujo_de_Tramas.Controls.Add(Me.Button_Conectar)
        Me.GroupBox_Flujo_de_Tramas.Controls.Add(Me.PictureBox_Estado)
        Me.GroupBox_Flujo_de_Tramas.Controls.Add(Me.ComboBox_Puertos)
        Me.GroupBox_Flujo_de_Tramas.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Flujo_de_Tramas.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox_Flujo_de_Tramas.Name = "GroupBox_Flujo_de_Tramas"
        Me.GroupBox_Flujo_de_Tramas.Size = New System.Drawing.Size(1042, 185)
        Me.GroupBox_Flujo_de_Tramas.TabIndex = 0
        Me.GroupBox_Flujo_de_Tramas.TabStop = False
        Me.GroupBox_Flujo_de_Tramas.Text = "Flujo de Tramas"
        '
        'Button_Limpiar_TextBox
        '
        Me.Button_Limpiar_TextBox.Location = New System.Drawing.Point(748, 107)
        Me.Button_Limpiar_TextBox.Name = "Button_Limpiar_TextBox"
        Me.Button_Limpiar_TextBox.Size = New System.Drawing.Size(131, 70)
        Me.Button_Limpiar_TextBox.TabIndex = 9
        Me.Button_Limpiar_TextBox.Text = "Limpiar"
        Me.Button_Limpiar_TextBox.UseVisualStyleBackColor = True
        '
        'TextBox_Trama_Recibida
        '
        Me.TextBox_Trama_Recibida.Location = New System.Drawing.Point(268, 145)
        Me.TextBox_Trama_Recibida.Name = "TextBox_Trama_Recibida"
        Me.TextBox_Trama_Recibida.Size = New System.Drawing.Size(474, 32)
        Me.TextBox_Trama_Recibida.TabIndex = 8
        '
        'TextBox_Trama_Enviada
        '
        Me.TextBox_Trama_Enviada.Location = New System.Drawing.Point(268, 107)
        Me.TextBox_Trama_Enviada.Name = "TextBox_Trama_Enviada"
        Me.TextBox_Trama_Enviada.Size = New System.Drawing.Size(474, 32)
        Me.TextBox_Trama_Enviada.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Trama Recibida"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Trama Enviada"
        '
        'Label_Estado_Puerto
        '
        Me.Label_Estado_Puerto.AutoSize = True
        Me.Label_Estado_Puerto.Location = New System.Drawing.Point(6, 67)
        Me.Label_Estado_Puerto.Name = "Label_Estado_Puerto"
        Me.Label_Estado_Puerto.Size = New System.Drawing.Size(170, 25)
        Me.Label_Estado_Puerto.TabIndex = 4
        Me.Label_Estado_Puerto.Text = "Estado Puerto"
        '
        'Button_Desconectar
        '
        Me.Button_Desconectar.Location = New System.Drawing.Point(623, 31)
        Me.Button_Desconectar.Name = "Button_Desconectar"
        Me.Button_Desconectar.Size = New System.Drawing.Size(256, 33)
        Me.Button_Desconectar.TabIndex = 3
        Me.Button_Desconectar.Text = "Button_Desconectar"
        Me.Button_Desconectar.UseVisualStyleBackColor = True
        '
        'Button_Conectar
        '
        Me.Button_Conectar.Location = New System.Drawing.Point(361, 31)
        Me.Button_Conectar.Name = "Button_Conectar"
        Me.Button_Conectar.Size = New System.Drawing.Size(256, 33)
        Me.Button_Conectar.TabIndex = 2
        Me.Button_Conectar.Text = "Button_Conectar"
        Me.Button_Conectar.UseVisualStyleBackColor = True
        '
        'PictureBox_Estado
        '
        Me.PictureBox_Estado.Location = New System.Drawing.Point(268, 31)
        Me.PictureBox_Estado.Name = "PictureBox_Estado"
        Me.PictureBox_Estado.Size = New System.Drawing.Size(72, 61)
        Me.PictureBox_Estado.TabIndex = 1
        Me.PictureBox_Estado.TabStop = False
        '
        'ComboBox_Puertos
        '
        Me.ComboBox_Puertos.FormattingEnabled = True
        Me.ComboBox_Puertos.Location = New System.Drawing.Point(6, 31)
        Me.ComboBox_Puertos.Name = "ComboBox_Puertos"
        Me.ComboBox_Puertos.Size = New System.Drawing.Size(244, 33)
        Me.ComboBox_Puertos.TabIndex = 0
        '
        'GroupBox_Variador
        '
        Me.GroupBox_Variador.Controls.Add(Me.Label_Frecuencia_Leida)
        Me.GroupBox_Variador.Controls.Add(Me.Button_Leer_Frecuencia)
        Me.GroupBox_Variador.Controls.Add(Me.Button_Run_Forward)
        Me.GroupBox_Variador.Controls.Add(Me.Button_Stop)
        Me.GroupBox_Variador.Controls.Add(Me.Button_Run_Backward)
        Me.GroupBox_Variador.Controls.Add(Me.ComboBox_Frecuencias)
        Me.GroupBox_Variador.Controls.Add(Me.Label_Frecuencias)
        Me.GroupBox_Variador.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Variador.Location = New System.Drawing.Point(12, 203)
        Me.GroupBox_Variador.Name = "GroupBox_Variador"
        Me.GroupBox_Variador.Size = New System.Drawing.Size(1042, 76)
        Me.GroupBox_Variador.TabIndex = 1
        Me.GroupBox_Variador.TabStop = False
        Me.GroupBox_Variador.Text = "Variador MX2"
        '
        'Label_Frecuencia_Leida
        '
        Me.Label_Frecuencia_Leida.AutoSize = True
        Me.Label_Frecuencia_Leida.Location = New System.Drawing.Point(985, 37)
        Me.Label_Frecuencia_Leida.Name = "Label_Frecuencia_Leida"
        Me.Label_Frecuencia_Leida.Size = New System.Drawing.Size(41, 25)
        Me.Label_Frecuencia_Leida.TabIndex = 14
        Me.Label_Frecuencia_Leida.Text = "Hz"
        '
        'Button_Leer_Frecuencia
        '
        Me.Button_Leer_Frecuencia.Location = New System.Drawing.Point(821, 28)
        Me.Button_Leer_Frecuencia.Name = "Button_Leer_Frecuencia"
        Me.Button_Leer_Frecuencia.Size = New System.Drawing.Size(158, 33)
        Me.Button_Leer_Frecuencia.TabIndex = 13
        Me.Button_Leer_Frecuencia.Text = "Frecuencia?"
        Me.Button_Leer_Frecuencia.UseVisualStyleBackColor = True
        '
        'Button_Run_Forward
        '
        Me.Button_Run_Forward.Location = New System.Drawing.Point(656, 28)
        Me.Button_Run_Forward.Name = "Button_Run_Forward"
        Me.Button_Run_Forward.Size = New System.Drawing.Size(134, 33)
        Me.Button_Run_Forward.TabIndex = 12
        Me.Button_Run_Forward.Text = "RUN >>"
        Me.Button_Run_Forward.UseVisualStyleBackColor = True
        '
        'Button_Stop
        '
        Me.Button_Stop.Location = New System.Drawing.Point(516, 28)
        Me.Button_Stop.Name = "Button_Stop"
        Me.Button_Stop.Size = New System.Drawing.Size(134, 33)
        Me.Button_Stop.TabIndex = 11
        Me.Button_Stop.Text = "STOP"
        Me.Button_Stop.UseVisualStyleBackColor = True
        '
        'Button_Run_Backward
        '
        Me.Button_Run_Backward.Location = New System.Drawing.Point(376, 28)
        Me.Button_Run_Backward.Name = "Button_Run_Backward"
        Me.Button_Run_Backward.Size = New System.Drawing.Size(134, 33)
        Me.Button_Run_Backward.TabIndex = 10
        Me.Button_Run_Backward.Text = "<< RUN"
        Me.Button_Run_Backward.UseVisualStyleBackColor = True
        '
        'ComboBox_Frecuencias
        '
        Me.ComboBox_Frecuencias.FormattingEnabled = True
        Me.ComboBox_Frecuencias.Location = New System.Drawing.Point(215, 28)
        Me.ComboBox_Frecuencias.Name = "ComboBox_Frecuencias"
        Me.ComboBox_Frecuencias.Size = New System.Drawing.Size(125, 33)
        Me.ComboBox_Frecuencias.TabIndex = 10
        '
        'Label_Frecuencias
        '
        Me.Label_Frecuencias.AutoSize = True
        Me.Label_Frecuencias.Location = New System.Drawing.Point(6, 32)
        Me.Label_Frecuencias.Name = "Label_Frecuencias"
        Me.Label_Frecuencias.Size = New System.Drawing.Size(203, 25)
        Me.Label_Frecuencias.TabIndex = 10
        Me.Label_Frecuencias.Text = "Frecuencias (Hz)"
        '
        'SerialPort
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 288)
        Me.Controls.Add(Me.GroupBox_Variador)
        Me.Controls.Add(Me.GroupBox_Flujo_de_Tramas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox_Flujo_de_Tramas.ResumeLayout(False)
        Me.GroupBox_Flujo_de_Tramas.PerformLayout()
        CType(Me.PictureBox_Estado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Variador.ResumeLayout(False)
        Me.GroupBox_Variador.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox_Flujo_de_Tramas As GroupBox
    Friend WithEvents ComboBox_Puertos As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_Estado_Puerto As Label
    Friend WithEvents Button_Desconectar As Button
    Friend WithEvents Button_Conectar As Button
    Friend WithEvents PictureBox_Estado As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button_Limpiar_TextBox As Button
    Friend WithEvents TextBox_Trama_Recibida As TextBox
    Friend WithEvents TextBox_Trama_Enviada As TextBox
    Friend WithEvents GroupBox_Variador As GroupBox
    Friend WithEvents Label_Frecuencias As Label
    Friend WithEvents Button_Run_Forward As Button
    Friend WithEvents Button_Stop As Button
    Friend WithEvents Button_Run_Backward As Button
    Friend WithEvents ComboBox_Frecuencias As ComboBox
    Friend WithEvents Label_Frecuencia_Leida As Label
    Friend WithEvents Button_Leer_Frecuencia As Button
    Friend WithEvents SerialPort As IO.Ports.SerialPort
End Class
