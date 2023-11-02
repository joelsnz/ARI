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
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBoxSalida1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxSalida0 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSalida1 = New System.Windows.Forms.CheckBox()
        Me.GroupBoxControlPuerto.SuspendLayout()
        CType(Me.PictureBoxEstadoPuerto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxSalida0.SuspendLayout()
        Me.GroupBoxSalida1.SuspendLayout()
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
        Me.GroupBoxSalida0.Controls.Add(Me.CheckBoxSalida0)
        Me.GroupBoxSalida0.Font = New System.Drawing.Font("Roboto Mono", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxSalida0.Location = New System.Drawing.Point(12, 124)
        Me.GroupBoxSalida0.Name = "GroupBoxSalida0"
        Me.GroupBoxSalida0.Size = New System.Drawing.Size(308, 72)
        Me.GroupBoxSalida0.TabIndex = 1
        Me.GroupBoxSalida0.TabStop = False
        Me.GroupBoxSalida0.Text = "Salida 0"
        '
        'GroupBoxSalida1
        '
        Me.GroupBoxSalida1.Controls.Add(Me.CheckBoxSalida1)
        Me.GroupBoxSalida1.Font = New System.Drawing.Font("Roboto Mono", 10.2!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxSalida1.Location = New System.Drawing.Point(326, 124)
        Me.GroupBoxSalida1.Name = "GroupBoxSalida1"
        Me.GroupBoxSalida1.Size = New System.Drawing.Size(308, 72)
        Me.GroupBoxSalida1.TabIndex = 2
        Me.GroupBoxSalida1.TabStop = False
        Me.GroupBoxSalida1.Text = "Salida 1"
        '
        'CheckBoxSalida0
        '
        Me.CheckBoxSalida0.AutoSize = True
        Me.CheckBoxSalida0.Location = New System.Drawing.Point(11, 39)
        Me.CheckBoxSalida0.Name = "CheckBoxSalida0"
        Me.CheckBoxSalida0.Size = New System.Drawing.Size(112, 27)
        Me.CheckBoxSalida0.TabIndex = 0
        Me.CheckBoxSalida0.Text = "Conected"
        Me.CheckBoxSalida0.UseVisualStyleBackColor = True
        '
        'CheckBoxSalida1
        '
        Me.CheckBoxSalida1.AutoSize = True
        Me.CheckBoxSalida1.Location = New System.Drawing.Point(7, 39)
        Me.CheckBoxSalida1.Name = "CheckBoxSalida1"
        Me.CheckBoxSalida1.Size = New System.Drawing.Size(112, 27)
        Me.CheckBoxSalida1.TabIndex = 1
        Me.CheckBoxSalida1.Text = "Conected"
        Me.CheckBoxSalida1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 207)
        Me.Controls.Add(Me.GroupBoxSalida1)
        Me.Controls.Add(Me.GroupBoxSalida0)
        Me.Controls.Add(Me.GroupBoxControlPuerto)
        Me.Name = "Form1"
        Me.Text = "Control PLC"
        Me.GroupBoxControlPuerto.ResumeLayout(False)
        Me.GroupBoxControlPuerto.PerformLayout()
        CType(Me.PictureBoxEstadoPuerto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxSalida0.ResumeLayout(False)
        Me.GroupBoxSalida0.PerformLayout()
        Me.GroupBoxSalida1.ResumeLayout(False)
        Me.GroupBoxSalida1.PerformLayout()
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
    Friend WithEvents CheckBoxSalida0 As CheckBox
    Friend WithEvents CheckBoxSalida1 As CheckBox
End Class
