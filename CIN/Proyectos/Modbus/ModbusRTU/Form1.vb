Imports System.ComponentModel
Imports System.IO.Ports
Imports System.Linq.Expressions
Imports System.Threading

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Definimos tipo de letra de los objetos del formulario
        Fuente_Personal = New Font("Verdana", 15, FontStyle.Bold, GraphicsUnit.Pixel)

        'Habilito y deshabilito los Button conectar y desconectar
        Button_Conectar.Enabled = True
        Button_Desconectar.Enabled = False

        'Deshabilitamos el GroupBox Variador
        GroupBox_Variador.Enabled = False

        'Mostramos el estado del puerto
        Label_Estado_Puerto.ForeColor = Color.DarkRed
        Label_Estado_Puerto.Text = "DESCONECTADO!!!"
        Label_Estado_Puerto.Enabled = True
        PictureBox_Estado.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox_Estado.BackgroundImage = My.Resources.OFF

        If (ComboBox_Frecuencias.Items.Count = 0) Then
            'Añadimos valores al ComboBox_Frecuencia
            For i = 1 To 6
                ComboBox_Frecuencias.Items.Add(i * 10)
            Next
        End If

        'Personalizamos nuestro formulario
        With Me
            .Font = Fuente_Personal
            .BackColor = Color.AliceBlue
            .Text = "COMUNICACIÓN MODBUS"
        End With

        'Insertamos texto y color en los objetos
        Button_Conectar.Text = "CONECTAR"
        Button_Conectar.BackColor = Color.Green
        Button_Desconectar.Text = "DESCONECTAR"
        Button_Desconectar.BackColor = Color.Red

        'Función que busca los puertos existentes en la máquina donde se ejecuta
        'la aplicación y los enumera en el combox para que le usuario escoja un puente
        Buscapuertos()

        'Personalizamos la etiqueta de frecuencias
        Label_Frecuencias.ForeColor = Color.DarkRed
    End Sub

    Public Sub Buscapuertos()
        'Utilizamos un bloque Try catch para capturar cualquier excepción que nos de el PC
        Try
            ComboBox_Puertos.Items.Clear()
            'My.Computer.Ports.SerialPortNames es una lista de los nombres de los puertos disponibles
            For Each nombre As String In My.Computer.Ports.SerialPortNames
                'Añadimos al ComboPort los nombres de los puertos disponibles
                ComboBox_Puertos.Items.Add(nombre)
            Next
            'Si ha encontrado algún puerto disponible, seleccionamos el primero
            If ComboBox_Puertos.Items.Count > 0 Then
                ComboBox_Puertos.SelectedIndex = 0
            Else
                'Si no hay puertos disponibles, aviso al usuario
                MsgBox("NO HAY PUERTOS DISPONIBLES")
                'Beep()
                'Me.Close()
            End If
            'Captura la excepción (error posible que nos da el sistema operativo del PC)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button_Conectar_Click(sender As Object, e As EventArgs) Handles Button_Conectar.Click
        'Utilizamos un bloque Try catch para capturar cualquier excepción que nos de windows
        Try
            'Configuro el puerto, le asigno el nombre y lo abrimos
            With SerialPort
                .BaudRate = 38400
                .DataBits = 8
                .Parity = IO.Ports.Parity.Even
                .StopBits = IO.Ports.StopBits.One
                'Asigno el nombre del puerto que ha encontrado el procedimiento buscapuertos()
                .PortName = ComboBox_Puertos.Text
                'Abrimos el puerto Enviar
                .Open()
                'Si hemos podido abrirlo, lo indicamos
                If .IsOpen Then
                    SerialPort.DiscardInBuffer()
                    SerialPort.DiscardOutBuffer()
                    PictureBox_Estado.BackgroundImage = My.Resources._ON
                    Label_Estado_Puerto.Text = "CONECTADO A " & .PortName
                    Label_Estado_Puerto.ForeColor = Color.Blue
                    Button_Conectar.BackColor = Color.LimeGreen
                    'Habilitamos el button desconectar y deshabilitamos el button conectar
                    Button_Desconectar.Enabled = True
                    Button_Conectar.Enabled = False
                    GroupBox_Variador.Enabled = True
                Else
                    'Si no hemos podido abrirlo lo indicamos con MsgBox
                    MsgBox("FALLO EN LA CONEXIÓN", MsgBoxStyle.Critical)
                    Beep()
                End If
            End With
        Catch ex As Exception
            'Capturo la excepción
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button_Desconectar_Click(sender As Object, e As EventArgs) Handles Button_Desconectar.Click
        'Si el puerto está abierto
        If SerialPort.IsOpen Then
            'Limpia el puerto de salida y de entrada (Carácteres residuales)
            SerialPort.DiscardInBuffer()
            SerialPort.DiscardOutBuffer()
            'Cerramos el puerto de Enviar
            SerialPort.Close()
            'Llamamos de nuevo al form1_Load, para que todo quede igual
            Call Form1_Load(sender, e)
            GroupBox_Variador.Enabled = False
        Else
            'Avisamos de que no estamos conectados
            MsgBox("EL PUERTO NO ESTÁ ABIERTO", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If SerialPort.IsOpen Then
            Call Button_Desconectar_Click(sender, e)
        End If
    End Sub

    Private Sub ComboBox_Frecuencias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Frecuencias.SelectedIndexChanged
        'Ajustamos la sensibilidad del datareceived
        SerialPort.ReceivedBytesThreshold = 8

        If SerialPort.IsOpen Then
            Trama_Saliente = New Byte(12) {} 'Asigno a la matriz de 13 posiciones
            Trama_Saliente(0) = &H1
            Trama_Saliente(1) = &H10
            Trama_Saliente(2) = &H0
            Trama_Saliente(3) = &H0
            Trama_Saliente(4) = &H0
            Trama_Saliente(5) = &H2
            Trama_Saliente(6) = &H4
            Trama_Saliente(7) = &H0
            Trama_Saliente(8) = &H0
            Select Case ComboBox_Frecuencias.SelectedItem
                Case 10
                    Trama_Saliente(9) = &H3
                    Trama_Saliente(10) = &HE8
                Case 20
                    Trama_Saliente(9) = &H7
                    Trama_Saliente(10) = &HD0
                Case 30
                    Trama_Saliente(9) = &HB
                    Trama_Saliente(10) = &HB8
                Case 40
                    Trama_Saliente(9) = &HF
                    Trama_Saliente(10) = &HA0
                Case 50
                    Trama_Saliente(9) = &H13
                    Trama_Saliente(10) = &H88
                Case 60
                    Trama_Saliente(9) = &H17
                    Trama_Saliente(10) = &H70
            End Select
            Dim crc As Byte() = Calculo_CRC(Trama_Saliente) 'Call CRC Calculator
            Trama_Saliente(11) = crc(0) 'Error check Lo.
            Trama_Saliente(12) = crc(1) 'Error check Hi.

            Try
                'Mostramos la trama en un TextBox
                TextBox_Trama_Enviada.Text = Conversor_tramaBytes_a_tramaString(Trama_Saliente)
                'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
                'hasta el último componente de la matriz
                SerialPort.Write(Trama_Saliente, 0, Trama_Saliente.Length) 'Enviar trama
            Catch ex As Exception
                MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub SerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        'Defino el tamaño de la matriz de lectura, con el número de bytes,
        'presentes en el buffer de entrada, en el momento de la lectura
        Trama_Entrante = New Byte(SerialPort.BytesToRead - 1) {}
        'leemos la trama recibida y la guardamos en la matriz Trama_Entrante
        SerialPort.Read(Trama_Entrante, 0, Trama_Entrante.Length)
        Me.Invoke(New EventHandler(AddressOf modificar))
        'limpieza de buffers de entrada y salida
        SerialPort.DiscardInBuffer()
        SerialPort.DiscardOutBuffer()
    End Sub

    Private Sub modificar(sender As Object, e As EventArgs)
        Beep()
        Dim numero_nodo As String
        Dim function_code As String
        numero_nodo = Mid(Conversor_tramaBytes_a_tramaString(Trama_Entrante), 1, 2)
        function_code = Mid(Conversor_tramaBytes_a_tramaString(Trama_Entrante), 4, 2)
        Try
            Select Case numero_nodo
                Case "01" 'Analizamos las respuestas del variador MX2
                    TextBox_Trama_Recibida.Text = Conversor_tramaBytes_a_tramaString(Trama_Entrante)
            End Select
        Catch
        End Try

        If function_code = "03" Then
            Dim byte_1 As String
            Dim byte_2 As String
            byte_1 = Mid(Conversor_tramaBytes_a_tramaString(Trama_Entrante), 16, 2)
            byte_2 = Mid(Conversor_tramaBytes_a_tramaString(Trama_Entrante), 19, 2)
            Select Case byte_1 + byte_2
                Case "03E8"
                    Label_Frecuencia_Leida.Text = "10Hz"
                Case "07D0"
                    Label_Frecuencia_Leida.Text = "20Hz"
                Case "0BB8"
                    Label_Frecuencia_Leida.Text = "30Hz"
                Case "0FA0"
                    Label_Frecuencia_Leida.Text = "40Hz"
                Case "1388"
                    Label_Frecuencia_Leida.Text = "50Hz"
                Case "1770"
                    Label_Frecuencia_Leida.Text = "60Hz"
            End Select
        End If
    End Sub

    Private Sub Button_Run_Forward_Click(sender As Object, e As EventArgs) Handles Button_Run_Backward.Click
        'Ajustamos la sensibilidad del datareceived
        SerialPort.ReceivedBytesThreshold = 8

        If SerialPort.IsOpen Then
            Trama_Saliente = New Byte(10) {} 'Asigno a la matriz de 13 posiciones
            Trama_Saliente(0) = &H1
            Trama_Saliente(1) = &HF
            Trama_Saliente(2) = &H0
            Trama_Saliente(3) = &H0
            Trama_Saliente(4) = &H0
            Trama_Saliente(5) = &H2
            Trama_Saliente(6) = &H2
            Trama_Saliente(7) = &H1
            Trama_Saliente(8) = &H0
            Dim crc As Byte() = Calculo_CRC(Trama_Saliente) 'Call CRC Calculator
            Trama_Saliente(9) = crc(0) 'Error check Lo.
            Trama_Saliente(10) = crc(1) 'Error check Hi.

            Try
                'Mostramos la trama en un TextBox
                TextBox_Trama_Enviada.Text = Conversor_tramaBytes_a_tramaString(Trama_Saliente)
                'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
                'hasta el último componente de la matriz
                SerialPort.Write(Trama_Saliente, 0, Trama_Saliente.Length) 'Enviar trama
            Catch ex As Exception
                MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Button_Run_Backward_Click(sender As Object, e As EventArgs) Handles Button_Run_Forward.Click
        'Ajustamos la sensibilidad del datareceived
        SerialPort.ReceivedBytesThreshold = 8

        If SerialPort.IsOpen Then
            Trama_Saliente = New Byte(10) {} 'Asigno a la matriz de 13 posiciones
            Trama_Saliente(0) = &H1
            Trama_Saliente(1) = &HF
            Trama_Saliente(2) = &H0
            Trama_Saliente(3) = &H0
            Trama_Saliente(4) = &H0
            Trama_Saliente(5) = &H2
            Trama_Saliente(6) = &H2
            Trama_Saliente(7) = &H3
            Trama_Saliente(8) = &H0
            Dim crc As Byte() = Calculo_CRC(Trama_Saliente) 'Call CRC Calculator
            Trama_Saliente(9) = crc(0) 'Error check Lo.
            Trama_Saliente(10) = crc(1) 'Error check Hi.

            Try
                'Mostramos la trama en un TextBox
                TextBox_Trama_Enviada.Text = Conversor_tramaBytes_a_tramaString(Trama_Saliente)
                'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
                'hasta el último componente de la matriz
                SerialPort.Write(Trama_Saliente, 0, Trama_Saliente.Length) 'Enviar trama
            Catch ex As Exception
                MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Button_Stop_Click(sender As Object, e As EventArgs) Handles Button_Stop.Click
        'Ajustamos la sensibilidad del datareceived
        SerialPort.ReceivedBytesThreshold = 8

        If SerialPort.IsOpen Then
            Trama_Saliente = New Byte(7) {} 'Asigno a la matriz de 13 posiciones
            Trama_Saliente(0) = &H1
            Trama_Saliente(1) = &H5
            Trama_Saliente(2) = &H0
            Trama_Saliente(3) = &H0
            Trama_Saliente(4) = &H0
            Trama_Saliente(5) = &H0
            Dim crc As Byte() = Calculo_CRC(Trama_Saliente) 'Call CRC Calculator
            Trama_Saliente(6) = crc(0) 'Error check Lo.
            Trama_Saliente(7) = crc(1) 'Error check Hi.

            Try
                'Mostramos la trama en un TextBox
                TextBox_Trama_Enviada.Text = Conversor_tramaBytes_a_tramaString(Trama_Saliente)
                'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
                'hasta el último componente de la matriz
                SerialPort.Write(Trama_Saliente, 0, Trama_Saliente.Length) 'Enviar trama
            Catch ex As Exception
                MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Button_Limpiar_TextBox_Click(sender As Object, e As EventArgs) Handles Button_Limpiar_TextBox.Click
        TextBox_Trama_Enviada.Text = ""
        TextBox_Trama_Recibida.Text = ""
    End Sub

    Private Sub Button_Leer_Frecuencia_Click(sender As Object, e As EventArgs) Handles Button_Leer_Frecuencia.Click
        'Ajustamos la sensibilidad del datareceived
        SerialPort.ReceivedBytesThreshold = 9

        If SerialPort.IsOpen Then
            Trama_Saliente = New Byte(7) {} 'Asigno a la matriz de 13 posiciones
            Trama_Saliente(0) = &H1
            Trama_Saliente(1) = &H3
            Trama_Saliente(2) = &H0
            Trama_Saliente(3) = &H0
            Trama_Saliente(4) = &H0
            Trama_Saliente(5) = &H2
            Dim crc As Byte() = Calculo_CRC(Trama_Saliente) 'Call CRC Calculator
            Trama_Saliente(6) = crc(0) 'Error check Lo.
            Trama_Saliente(7) = crc(1) 'Error check Hi.

            Try
                'Mostramos la trama en un TextBox
                TextBox_Trama_Enviada.Text = Conversor_tramaBytes_a_tramaString(Trama_Saliente)
                'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
                'hasta el último componente de la matriz
                SerialPort.Write(Trama_Saliente, 0, Trama_Saliente.Length) 'Enviar trama
            Catch ex As Exception
                MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Button_Run_Click(sender As Object, e As EventArgs) Handles Button_Run.Click
        'Ajustamos la sensibilidad del datareceived
        SerialPort.ReceivedBytesThreshold = 8

        If SerialPort.IsOpen Then
            Trama_Saliente = New Byte(7) {} 'Asigno a la matriz de 13 posiciones
            Trama_Saliente(0) = &H1
            Trama_Saliente(1) = &H5
            Trama_Saliente(2) = &H0
            Trama_Saliente(3) = &H0
            Trama_Saliente(4) = &HFF
            Trama_Saliente(5) = &H0
            Dim crc As Byte() = Calculo_CRC(Trama_Saliente) 'Call CRC Calculator
            Trama_Saliente(6) = crc(0) 'Error check Lo.
            Trama_Saliente(7) = crc(1) 'Error check Hi.

            Try
                'Mostramos la trama en un TextBox
                TextBox_Trama_Enviada.Text = Conversor_tramaBytes_a_tramaString(Trama_Saliente)
                'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
                'hasta el último componente de la matriz
                SerialPort.Write(Trama_Saliente, 0, Trama_Saliente.Length) 'Enviar trama
            Catch ex As Exception
                MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Button_Forward_Click(sender As Object, e As EventArgs) Handles Button_Forward.Click
        'Ajustamos la sensibilidad del datareceived
        SerialPort.ReceivedBytesThreshold = 8

        If SerialPort.IsOpen Then
            Trama_Saliente = New Byte(7) {} 'Asigno a la matriz de 13 posiciones
            Trama_Saliente(0) = &H1
            Trama_Saliente(1) = &H5
            Trama_Saliente(2) = &H0
            Trama_Saliente(3) = &H1
            Trama_Saliente(4) = &HFF
            Trama_Saliente(5) = &H0
            Dim crc As Byte() = Calculo_CRC(Trama_Saliente) 'Call CRC Calculator
            Trama_Saliente(6) = crc(0) 'Error check Lo.
            Trama_Saliente(7) = crc(1) 'Error check Hi.

            Try
                'Mostramos la trama en un TextBox
                TextBox_Trama_Enviada.Text = Conversor_tramaBytes_a_tramaString(Trama_Saliente)
                'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
                'hasta el último componente de la matriz
                SerialPort.Write(Trama_Saliente, 0, Trama_Saliente.Length) 'Enviar trama
            Catch ex As Exception
                MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Button_Backward_Click(sender As Object, e As EventArgs) Handles Button_Backward.Click
        'Ajustamos la sensibilidad del datareceived
        SerialPort.ReceivedBytesThreshold = 8

        If SerialPort.IsOpen Then
            Trama_Saliente = New Byte(7) {} 'Asigno a la matriz de 13 posiciones
            Trama_Saliente(0) = &H1
            Trama_Saliente(1) = &H5
            Trama_Saliente(2) = &H0
            Trama_Saliente(3) = &H1
            Trama_Saliente(4) = &H0
            Trama_Saliente(5) = &H0
            Dim crc As Byte() = Calculo_CRC(Trama_Saliente) 'Call CRC Calculator
            Trama_Saliente(6) = crc(0) 'Error check Lo.
            Trama_Saliente(7) = crc(1) 'Error check Hi.

            Try
                'Mostramos la trama en un TextBox
                TextBox_Trama_Enviada.Text = Conversor_tramaBytes_a_tramaString(Trama_Saliente)
                'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
                'hasta el último componente de la matriz
                SerialPort.Write(Trama_Saliente, 0, Trama_Saliente.Length) 'Enviar trama
            Catch ex As Exception
                MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class