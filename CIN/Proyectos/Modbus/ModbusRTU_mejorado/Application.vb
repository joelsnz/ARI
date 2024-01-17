Module Application
    ''' <summary>
    ''' configuración de la aplicación cuando está desactivada
    ''' </summary>
    Public Sub deactivateApplication()
        With Form1
            'tipo de letra para el formulario
            Fuente_Personal = New Font("Verdana", 15, FontStyle.Bold, GraphicsUnit.Pixel)
            .Font = Fuente_Personal

            .Button_Conectar.Enabled = True
            .Button_Desconectar.Enabled = False

            'inhabilitar controles de los esclavos
            .GroupBox_Variador.Enabled = False
            .GroupBox_E5CN.Enabled = False

            'mostrar estado del puerto
            With .Label_Estado_Puerto
                .ForeColor = Color.DarkRed
                .Text = "DESCONECTADO!!!"
                .Enabled = True
            End With
            With .PictureBox_Estado
                .BackgroundImageLayout = ImageLayout.Stretch
                .BackgroundImage = My.Resources.OFF
            End With

            'Añadimos valores de frecuencia al ComboBox_Frecuencia
            If (.ComboBox_Frecuencias.Items.Count = 0) Then
                For i = 1 To 6
                    .ComboBox_Frecuencias.Items.Add(i * 10)
                Next
            End If

            .BackColor = Color.AliceBlue 'color de fondo
            .Text = "COMUNICACIÓN MODBUS" 'título de la apicación

            'insertar texto y color en los objetos
            With .Button_Conectar
                .Text = "CONECTAR"
                .BackColor = Color.Green
            End With
            With .Button_Desconectar
                .Text = "DESCONECTAR"
                .BackColor = Color.Red
            End With

            Buscapuertos(.ComboBox_Puertos)

            'cambiar color de letra
            .Label_Frecuencias.ForeColor = Color.DarkRed
        End With
    End Sub

    ''' <summary>
    ''' configuración de la aplicación cuando está activa
    ''' </summary>
    Public Sub activateApplication()
        With Form1
            .PictureBox_Estado.BackgroundImage = My.Resources._ON
            .Label_Estado_Puerto.Text = "CONECTADO A " & .SerialPort.PortName
            .Label_Estado_Puerto.ForeColor = Color.Blue
            .Button_Conectar.BackColor = Color.LimeGreen

            .Button_Desconectar.Enabled = True
            .Button_Conectar.Enabled = False
            .GroupBox_Variador.Enabled = True
            .GroupBox_E5CN.Enabled = True
        End With
    End Sub
End Module
