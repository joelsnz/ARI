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
        Me.ButtonDesconectarSalida = New System.Windows.Forms.Button()
        Me.ButtonConectarSalida = New System.Windows.Forms.Button()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBoxControlPuerto.SuspendLayout()
        CType(Me.PictureBoxEstadoPuerto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxSalida0.SuspendLayout()
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
        Me.GroupBoxSalida0.Controls.Add(Me.ButtonDesconectarSalida)
        Me.GroupBoxSalida0.Controls.Add(Me.ButtonConectarSalida)
        Me.GroupBoxSalida0.Font = New System.Drawing.Font("Roboto Mono", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxSalida0.Location = New System.Drawing.Point(12, 124)
        Me.GroupBoxSalida0.Name = "GroupBoxSalida0"
        Me.GroupBoxSalida0.Size = New System.Drawing.Size(622, 72)
        Me.GroupBoxSalida0.TabIndex = 1
        Me.GroupBoxSalida0.TabStop = False
        Me.GroupBoxSalida0.Text = "Salida 0"
        '
        'ButtonDesconectarSalida
        '
        Me.ButtonDesconectarSalida.Location = New System.Drawing.Point(461, 29)
        Me.ButtonDesconectarSalida.Name = "ButtonDesconectarSalida"
        Me.ButtonDesconectarSalida.Size = New System.Drawing.Size(152, 30)
        Me.ButtonDesconectarSalida.TabIndex = 5
        Me.ButtonDesconectarSalida.Text = "Desconectar"
        Me.ButtonDesconectarSalida.UseVisualStyleBackColor = True
        '
        'ButtonConectarSalida
        '
        Me.ButtonConectarSalida.Location = New System.Drawing.Point(11, 29)
        Me.ButtonConectarSalida.Name = "ButtonConectarSalida"
        Me.ButtonConectarSalida.Size = New System.Drawing.Size(152, 30)
        Me.ButtonConectarSalida.TabIndex = 4
        Me.ButtonConectarSalida.Text = "Conectar"
        Me.ButtonConectarSalida.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 207)
        Me.Controls.Add(Me.GroupBoxSalida0)
        Me.Controls.Add(Me.GroupBoxControlPuerto)
        Me.Name = "Form1"
        Me.Text = "Control PLC"
        Me.GroupBoxControlPuerto.ResumeLayout(False)
        Me.GroupBoxControlPuerto.PerformLayout()
        CType(Me.PictureBoxEstadoPuerto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxSalida0.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxControlPuerto As GroupBox
    Friend WithEvents ComboBoxPuertos As ComboBox
    Friend WithEvents GroupBoxSalida0 As GroupBox
    Friend WithEvents ButtonConectar As Button
    Friend WithEvents ButtonDesconectar As Button
    Friend WithEvents LabelEstadoPuerto As Label
    Friend WithEvents ButtonConectarSalida As Button
    Friend WithEvents PictureBoxEstadoPuerto As PictureBox
    Friend WithEvents ButtonDesconectarSalida As Button
    Friend WithEvents SerialPort As IO.Ports.SerialPort
End Class
