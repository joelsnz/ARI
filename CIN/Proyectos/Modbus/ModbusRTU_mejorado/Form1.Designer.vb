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
        Me.Button_Decelerar_10s = New System.Windows.Forms.Button()
        Me.Button_Decelerar_2s = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button_Acelerar_5s = New System.Windows.Forms.Button()
        Me.Button_Acelerar_500ms = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_Backward = New System.Windows.Forms.Button()
        Me.Button_Run = New System.Windows.Forms.Button()
        Me.Button_Forward = New System.Windows.Forms.Button()
        Me.Label_Frecuencia_Leida = New System.Windows.Forms.Label()
        Me.Button_Leer_Frecuencia = New System.Windows.Forms.Button()
        Me.Button_Run_Backward = New System.Windows.Forms.Button()
        Me.Button_Stop = New System.Windows.Forms.Button()
        Me.Button_Run_Forward = New System.Windows.Forms.Button()
        Me.ComboBox_Frecuencias = New System.Windows.Forms.ComboBox()
        Me.Label_Frecuencias = New System.Windows.Forms.Label()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox_E5CN = New System.Windows.Forms.GroupBox()
        Me.Button_run_e5cn = New System.Windows.Forms.Button()
        Me.Button_stop_e5cn = New System.Windows.Forms.Button()
        Me.Label_Temperatura_Leida = New System.Windows.Forms.Label()
        Me.Button_Leer_Temperatura = New System.Windows.Forms.Button()
        Me.GroupBox_Flujo_de_Tramas.SuspendLayout()
        CType(Me.PictureBox_Estado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Variador.SuspendLayout()
        Me.GroupBox_E5CN.SuspendLayout()
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
        Me.GroupBox_Flujo_de_Tramas.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox_Flujo_de_Tramas.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox_Flujo_de_Tramas.Name = "GroupBox_Flujo_de_Tramas"
        Me.GroupBox_Flujo_de_Tramas.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox_Flujo_de_Tramas.Size = New System.Drawing.Size(782, 150)
        Me.GroupBox_Flujo_de_Tramas.TabIndex = 0
        Me.GroupBox_Flujo_de_Tramas.TabStop = False
        Me.GroupBox_Flujo_de_Tramas.Text = "Flujo de Tramas"
        '
        'Button_Limpiar_TextBox
        '
        Me.Button_Limpiar_TextBox.Location = New System.Drawing.Point(561, 87)
        Me.Button_Limpiar_TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Limpiar_TextBox.Name = "Button_Limpiar_TextBox"
        Me.Button_Limpiar_TextBox.Size = New System.Drawing.Size(98, 57)
        Me.Button_Limpiar_TextBox.TabIndex = 9
        Me.Button_Limpiar_TextBox.Text = "Limpiar"
        Me.Button_Limpiar_TextBox.UseVisualStyleBackColor = True
        '
        'TextBox_Trama_Recibida
        '
        Me.TextBox_Trama_Recibida.Location = New System.Drawing.Point(201, 118)
        Me.TextBox_Trama_Recibida.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox_Trama_Recibida.Name = "TextBox_Trama_Recibida"
        Me.TextBox_Trama_Recibida.Size = New System.Drawing.Size(356, 27)
        Me.TextBox_Trama_Recibida.TabIndex = 8
        '
        'TextBox_Trama_Enviada
        '
        Me.TextBox_Trama_Enviada.Location = New System.Drawing.Point(201, 87)
        Me.TextBox_Trama_Enviada.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox_Trama_Enviada.Name = "TextBox_Trama_Enviada"
        Me.TextBox_Trama_Enviada.Size = New System.Drawing.Size(356, 27)
        Me.TextBox_Trama_Enviada.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 118)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Trama Recibida"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Trama Enviada"
        '
        'Label_Estado_Puerto
        '
        Me.Label_Estado_Puerto.AutoSize = True
        Me.Label_Estado_Puerto.Location = New System.Drawing.Point(4, 54)
        Me.Label_Estado_Puerto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_Estado_Puerto.Name = "Label_Estado_Puerto"
        Me.Label_Estado_Puerto.Size = New System.Drawing.Size(133, 18)
        Me.Label_Estado_Puerto.TabIndex = 4
        Me.Label_Estado_Puerto.Text = "Estado Puerto"
        '
        'Button_Desconectar
        '
        Me.Button_Desconectar.Location = New System.Drawing.Point(467, 25)
        Me.Button_Desconectar.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Desconectar.Name = "Button_Desconectar"
        Me.Button_Desconectar.Size = New System.Drawing.Size(192, 27)
        Me.Button_Desconectar.TabIndex = 3
        Me.Button_Desconectar.Text = "Button_Desconectar"
        Me.Button_Desconectar.UseVisualStyleBackColor = True
        '
        'Button_Conectar
        '
        Me.Button_Conectar.Location = New System.Drawing.Point(271, 25)
        Me.Button_Conectar.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Conectar.Name = "Button_Conectar"
        Me.Button_Conectar.Size = New System.Drawing.Size(192, 27)
        Me.Button_Conectar.TabIndex = 2
        Me.Button_Conectar.Text = "Button_Conectar"
        Me.Button_Conectar.UseVisualStyleBackColor = True
        '
        'PictureBox_Estado
        '
        Me.PictureBox_Estado.Location = New System.Drawing.Point(201, 25)
        Me.PictureBox_Estado.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox_Estado.Name = "PictureBox_Estado"
        Me.PictureBox_Estado.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox_Estado.TabIndex = 1
        Me.PictureBox_Estado.TabStop = False
        '
        'ComboBox_Puertos
        '
        Me.ComboBox_Puertos.FormattingEnabled = True
        Me.ComboBox_Puertos.Location = New System.Drawing.Point(4, 25)
        Me.ComboBox_Puertos.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox_Puertos.Name = "ComboBox_Puertos"
        Me.ComboBox_Puertos.Size = New System.Drawing.Size(184, 26)
        Me.ComboBox_Puertos.TabIndex = 0
        '
        'GroupBox_Variador
        '
        Me.GroupBox_Variador.Controls.Add(Me.Button_Decelerar_10s)
        Me.GroupBox_Variador.Controls.Add(Me.Button_Decelerar_2s)
        Me.GroupBox_Variador.Controls.Add(Me.Label4)
        Me.GroupBox_Variador.Controls.Add(Me.Button_Acelerar_5s)
        Me.GroupBox_Variador.Controls.Add(Me.Button_Acelerar_500ms)
        Me.GroupBox_Variador.Controls.Add(Me.Label3)
        Me.GroupBox_Variador.Controls.Add(Me.Button_Backward)
        Me.GroupBox_Variador.Controls.Add(Me.Button_Run)
        Me.GroupBox_Variador.Controls.Add(Me.Button_Forward)
        Me.GroupBox_Variador.Controls.Add(Me.Label_Frecuencia_Leida)
        Me.GroupBox_Variador.Controls.Add(Me.Button_Leer_Frecuencia)
        Me.GroupBox_Variador.Controls.Add(Me.Button_Run_Backward)
        Me.GroupBox_Variador.Controls.Add(Me.Button_Stop)
        Me.GroupBox_Variador.Controls.Add(Me.Button_Run_Forward)
        Me.GroupBox_Variador.Controls.Add(Me.ComboBox_Frecuencias)
        Me.GroupBox_Variador.Controls.Add(Me.Label_Frecuencias)
        Me.GroupBox_Variador.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Variador.Location = New System.Drawing.Point(9, 165)
        Me.GroupBox_Variador.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox_Variador.Name = "GroupBox_Variador"
        Me.GroupBox_Variador.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox_Variador.Size = New System.Drawing.Size(782, 151)
        Me.GroupBox_Variador.TabIndex = 1
        Me.GroupBox_Variador.TabStop = False
        Me.GroupBox_Variador.Text = "Variador MX2"
        '
        'Button_Decelerar_10s
        '
        Me.Button_Decelerar_10s.Location = New System.Drawing.Point(440, 118)
        Me.Button_Decelerar_10s.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Decelerar_10s.Name = "Button_Decelerar_10s"
        Me.Button_Decelerar_10s.Size = New System.Drawing.Size(152, 27)
        Me.Button_Decelerar_10s.TabIndex = 23
        Me.Button_Decelerar_10s.Text = "10 Segundos"
        Me.Button_Decelerar_10s.UseVisualStyleBackColor = True
        '
        'Button_Decelerar_2s
        '
        Me.Button_Decelerar_2s.Location = New System.Drawing.Point(282, 118)
        Me.Button_Decelerar_2s.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Decelerar_2s.Name = "Button_Decelerar_2s"
        Me.Button_Decelerar_2s.Size = New System.Drawing.Size(152, 27)
        Me.Button_Decelerar_2s.TabIndex = 22
        Me.Button_Decelerar_2s.Text = "2 Segundos"
        Me.Button_Decelerar_2s.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 118)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 18)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Tiempo deceleración"
        '
        'Button_Acelerar_5s
        '
        Me.Button_Acelerar_5s.Location = New System.Drawing.Point(440, 86)
        Me.Button_Acelerar_5s.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Acelerar_5s.Name = "Button_Acelerar_5s"
        Me.Button_Acelerar_5s.Size = New System.Drawing.Size(152, 27)
        Me.Button_Acelerar_5s.TabIndex = 20
        Me.Button_Acelerar_5s.Text = "5 Segundos"
        Me.Button_Acelerar_5s.UseVisualStyleBackColor = True
        '
        'Button_Acelerar_500ms
        '
        Me.Button_Acelerar_500ms.Location = New System.Drawing.Point(282, 86)
        Me.Button_Acelerar_500ms.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Acelerar_500ms.Name = "Button_Acelerar_500ms"
        Me.Button_Acelerar_500ms.Size = New System.Drawing.Size(152, 27)
        Me.Button_Acelerar_500ms.TabIndex = 19
        Me.Button_Acelerar_500ms.Text = "0,5 Segundos"
        Me.Button_Acelerar_500ms.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Tiempo aceleración"
        '
        'Button_Backward
        '
        Me.Button_Backward.Location = New System.Drawing.Point(492, 53)
        Me.Button_Backward.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Backward.Name = "Button_Backward"
        Me.Button_Backward.Size = New System.Drawing.Size(100, 27)
        Me.Button_Backward.TabIndex = 17
        Me.Button_Backward.Text = ">>"
        Me.Button_Backward.UseVisualStyleBackColor = True
        '
        'Button_Run
        '
        Me.Button_Run.Location = New System.Drawing.Point(387, 53)
        Me.Button_Run.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Run.Name = "Button_Run"
        Me.Button_Run.Size = New System.Drawing.Size(100, 27)
        Me.Button_Run.TabIndex = 16
        Me.Button_Run.Text = "RUN"
        Me.Button_Run.UseVisualStyleBackColor = True
        '
        'Button_Forward
        '
        Me.Button_Forward.Location = New System.Drawing.Point(282, 53)
        Me.Button_Forward.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Forward.Name = "Button_Forward"
        Me.Button_Forward.Size = New System.Drawing.Size(100, 27)
        Me.Button_Forward.TabIndex = 15
        Me.Button_Forward.Text = "<<"
        Me.Button_Forward.UseVisualStyleBackColor = True
        '
        'Label_Frecuencia_Leida
        '
        Me.Label_Frecuencia_Leida.AutoSize = True
        Me.Label_Frecuencia_Leida.Location = New System.Drawing.Point(739, 30)
        Me.Label_Frecuencia_Leida.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_Frecuencia_Leida.Name = "Label_Frecuencia_Leida"
        Me.Label_Frecuencia_Leida.Size = New System.Drawing.Size(31, 18)
        Me.Label_Frecuencia_Leida.TabIndex = 14
        Me.Label_Frecuencia_Leida.Text = "Hz"
        '
        'Button_Leer_Frecuencia
        '
        Me.Button_Leer_Frecuencia.Location = New System.Drawing.Point(616, 23)
        Me.Button_Leer_Frecuencia.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Leer_Frecuencia.Name = "Button_Leer_Frecuencia"
        Me.Button_Leer_Frecuencia.Size = New System.Drawing.Size(118, 27)
        Me.Button_Leer_Frecuencia.TabIndex = 13
        Me.Button_Leer_Frecuencia.Text = "Frecuencia?"
        Me.Button_Leer_Frecuencia.UseVisualStyleBackColor = True
        '
        'Button_Run_Backward
        '
        Me.Button_Run_Backward.Location = New System.Drawing.Point(492, 23)
        Me.Button_Run_Backward.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Run_Backward.Name = "Button_Run_Backward"
        Me.Button_Run_Backward.Size = New System.Drawing.Size(100, 27)
        Me.Button_Run_Backward.TabIndex = 12
        Me.Button_Run_Backward.Text = "RUN >>"
        Me.Button_Run_Backward.UseVisualStyleBackColor = True
        '
        'Button_Stop
        '
        Me.Button_Stop.Location = New System.Drawing.Point(387, 23)
        Me.Button_Stop.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Stop.Name = "Button_Stop"
        Me.Button_Stop.Size = New System.Drawing.Size(100, 27)
        Me.Button_Stop.TabIndex = 11
        Me.Button_Stop.Text = "STOP"
        Me.Button_Stop.UseVisualStyleBackColor = True
        '
        'Button_Run_Forward
        '
        Me.Button_Run_Forward.Location = New System.Drawing.Point(282, 23)
        Me.Button_Run_Forward.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Run_Forward.Name = "Button_Run_Forward"
        Me.Button_Run_Forward.Size = New System.Drawing.Size(100, 27)
        Me.Button_Run_Forward.TabIndex = 10
        Me.Button_Run_Forward.Text = "<< RUN"
        Me.Button_Run_Forward.UseVisualStyleBackColor = True
        '
        'ComboBox_Frecuencias
        '
        Me.ComboBox_Frecuencias.FormattingEnabled = True
        Me.ComboBox_Frecuencias.Location = New System.Drawing.Point(161, 23)
        Me.ComboBox_Frecuencias.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox_Frecuencias.Name = "ComboBox_Frecuencias"
        Me.ComboBox_Frecuencias.Size = New System.Drawing.Size(95, 26)
        Me.ComboBox_Frecuencias.TabIndex = 10
        '
        'Label_Frecuencias
        '
        Me.Label_Frecuencias.AutoSize = True
        Me.Label_Frecuencias.Location = New System.Drawing.Point(4, 26)
        Me.Label_Frecuencias.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_Frecuencias.Name = "Label_Frecuencias"
        Me.Label_Frecuencias.Size = New System.Drawing.Size(158, 18)
        Me.Label_Frecuencias.TabIndex = 10
        Me.Label_Frecuencias.Text = "Frecuencias (Hz)"
        '
        'SerialPort
        '
        '
        'GroupBox_E5CN
        '
        Me.GroupBox_E5CN.Controls.Add(Me.Button_run_e5cn)
        Me.GroupBox_E5CN.Controls.Add(Me.Button_stop_e5cn)
        Me.GroupBox_E5CN.Controls.Add(Me.Label_Temperatura_Leida)
        Me.GroupBox_E5CN.Controls.Add(Me.Button_Leer_Temperatura)
        Me.GroupBox_E5CN.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox_E5CN.Location = New System.Drawing.Point(9, 322)
        Me.GroupBox_E5CN.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox_E5CN.Name = "GroupBox_E5CN"
        Me.GroupBox_E5CN.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox_E5CN.Size = New System.Drawing.Size(782, 62)
        Me.GroupBox_E5CN.TabIndex = 2
        Me.GroupBox_E5CN.TabStop = False
        Me.GroupBox_E5CN.Text = "E5CN"
        '
        'Button_run_e5cn
        '
        Me.Button_run_e5cn.Location = New System.Drawing.Point(282, 25)
        Me.Button_run_e5cn.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_run_e5cn.Name = "Button_run_e5cn"
        Me.Button_run_e5cn.Size = New System.Drawing.Size(152, 27)
        Me.Button_run_e5cn.TabIndex = 25
        Me.Button_run_e5cn.Text = "RUN"
        Me.Button_run_e5cn.UseVisualStyleBackColor = True
        '
        'Button_stop_e5cn
        '
        Me.Button_stop_e5cn.Location = New System.Drawing.Point(440, 25)
        Me.Button_stop_e5cn.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_stop_e5cn.Name = "Button_stop_e5cn"
        Me.Button_stop_e5cn.Size = New System.Drawing.Size(152, 27)
        Me.Button_stop_e5cn.TabIndex = 24
        Me.Button_stop_e5cn.Text = "STOP"
        Me.Button_stop_e5cn.UseVisualStyleBackColor = True
        '
        'Label_Temperatura_Leida
        '
        Me.Label_Temperatura_Leida.AutoSize = True
        Me.Label_Temperatura_Leida.Location = New System.Drawing.Point(151, 32)
        Me.Label_Temperatura_Leida.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_Temperatura_Leida.Name = "Label_Temperatura_Leida"
        Me.Label_Temperatura_Leida.Size = New System.Drawing.Size(29, 18)
        Me.Label_Temperatura_Leida.TabIndex = 24
        Me.Label_Temperatura_Leida.Text = "ºC"
        '
        'Button_Leer_Temperatura
        '
        Me.Button_Leer_Temperatura.Location = New System.Drawing.Point(8, 25)
        Me.Button_Leer_Temperatura.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Leer_Temperatura.Name = "Button_Leer_Temperatura"
        Me.Button_Leer_Temperatura.Size = New System.Drawing.Size(138, 27)
        Me.Button_Leer_Temperatura.TabIndex = 24
        Me.Button_Leer_Temperatura.Text = "Temperatura?"
        Me.Button_Leer_Temperatura.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 391)
        Me.Controls.Add(Me.GroupBox_E5CN)
        Me.Controls.Add(Me.GroupBox_Variador)
        Me.Controls.Add(Me.GroupBox_Flujo_de_Tramas)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox_Flujo_de_Tramas.ResumeLayout(False)
        Me.GroupBox_Flujo_de_Tramas.PerformLayout()
        CType(Me.PictureBox_Estado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Variador.ResumeLayout(False)
        Me.GroupBox_Variador.PerformLayout()
        Me.GroupBox_E5CN.ResumeLayout(False)
        Me.GroupBox_E5CN.PerformLayout()
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
    Friend WithEvents Button_Run_Backward As Button
    Friend WithEvents Button_Stop As Button
    Friend WithEvents Button_Run_Forward As Button
    Friend WithEvents ComboBox_Frecuencias As ComboBox
    Friend WithEvents Label_Frecuencia_Leida As Label
    Friend WithEvents Button_Leer_Frecuencia As Button
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents Button_Backward As Button
    Friend WithEvents Button_Run As Button
    Friend WithEvents Button_Forward As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_Decelerar_10s As Button
    Friend WithEvents Button_Decelerar_2s As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button_Acelerar_5s As Button
    Friend WithEvents Button_Acelerar_500ms As Button
    Friend WithEvents GroupBox_E5CN As GroupBox
    Friend WithEvents Button_Leer_Temperatura As Button
    Friend WithEvents Label_Temperatura_Leida As Label
    Friend WithEvents Button_run_e5cn As Button
    Friend WithEvents Button_stop_e5cn As Button
End Class
