Module Application
    Public Sub deactivateApplication()
        With Form1
            'Definimos tipo de letra de los objetos del formulario
            Fuente_Personal = New Font("Verdana", 15, FontStyle.Bold, GraphicsUnit.Pixel)

            'Habilito y deshabilito los Button conectar y desconectar
            .Button_Conectar.Enabled = True
            .Button_Desconectar.Enabled = False

            'Deshabilitamos el GroupBox Variador
            .GroupBox_Variador.Enabled = False
            .GroupBox_E5CN.Enabled = False

            'Mostramos el estado del puerto
            With .Label_Estado_Puerto
                .ForeColor = Color.DarkRed
                .Text = "DESCONECTADO!!!"
                .Enabled = True
            End With
            With .PictureBox_Estado
                .BackgroundImageLayout = ImageLayout.Stretch
                .BackgroundImage = My.Resources.OFF
            End With

            If (.ComboBox_Frecuencias.Items.Count = 0) Then
                'Añadimos valores al ComboBox_Frecuencia
                For i = 1 To 6
                    .ComboBox_Frecuencias.Items.Add(i * 10)
                Next
            End If

            .Font = Fuente_Personal
            .BackColor = Color.AliceBlue
            .Text = "COMUNICACIÓN MODBUS"

            'Insertamos texto y color en los objetos
            With .Button_Conectar
                .Text = "CONECTAR"
                .BackColor = Color.Green
            End With
            With .Button_Desconectar
                .Text = "DESCONECTAR"
                .BackColor = Color.Red
            End With

            'Función que busca los puertos existentes en la máquina donde se ejecuta
            'la aplicación y los enumera en el combox para que le usuario escoja un puente
            Buscapuertos(.ComboBox_Puertos)

            'Personalizamos la etiqueta de frecuencias
            .Label_Frecuencias.ForeColor = Color.DarkRed
        End With
    End Sub

    Public Sub activateApplication()
        With Form1
            .PictureBox_Estado.BackgroundImage = My.Resources._ON
            .Label_Estado_Puerto.Text = "CONECTADO A " & .SerialPort.PortName
            .Label_Estado_Puerto.ForeColor = Color.Blue
            .Button_Conectar.BackColor = Color.LimeGreen
            'Habilitamos el button desconectar y deshabilitamos el button conectar
            .Button_Desconectar.Enabled = True
            .Button_Conectar.Enabled = False
            .GroupBox_Variador.Enabled = True
            .GroupBox_E5CN.Enabled = True
        End With
    End Sub
End Module
