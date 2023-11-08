Imports System.ComponentModel
Imports System.ComponentModel.Design.Serialization
Imports System.IO.Ports
Imports System.Linq.Expressions
Imports System.Security.Cryptography.X509Certificates

Public Class Form1
    Private Sub cargarForm(sender As Object, e As EventArgs) Handles MyBase.Load
        'Definimos tipo de letra de los objetos del formulario
        Fuente_Personal = New Font("Verdana", 15, FontStyle.Bold, GraphicsUnit.Pixel)
        'Habilito y deshabilito los Buttono conectar y desconectar
        ButtonConectar.Enabled = True
        ButtonDesconectar.Enabled = False

        'Deshabilito los botones del groupbox_salida0
        GroupBoxSalida0.Enabled = False
        GroupBoxSalida1.Enabled = False
        GroupBoxTodasSalidas.Enabled = False

        'Mostramos el estado del puerto
        With LabelEstadoPuerto
            .ForeColor = Color.DarkRed
            .Text = "DESCONECTADO"
            .AutoSize = True
        End With
        With PictureBoxEstadoPuerto
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.OFF
        End With

        'Personalizamos nuestro formulario
        With Me
            .Font = Fuente_Personal
            .BackColor = Color.AliceBlue
            .Text = "COMUNICACIÓN SERIE SIN PROTOCOLO NX1P2"
        End With

        'Insertamos texto y color en los objetos
        With ButtonConectar
            .Text = "CONECTAR"
            .BackColor = Color.Green
        End With

        With ButtonDesconectar
            .Text = "DESCONECTAR"
            .BackColor = Color.Red
        End With

        With ButtonSalida0On
            .Text = "ON"
            .BackColor = Color.Green
        End With

        With ButtonSalida0Off
            .Text = "OFF"
            .BackColor = Color.Red
        End With

        With ButtonSalida1On
            .Text = "ON"
            .BackColor = Color.Green
        End With

        With ButtonSalida1Off
            .Text = "OFF"
            .BackColor = Color.Red
        End With

        With ButtonTodasSalidasOn
            .Text = "ON"
            .BackColor = Color.Green
        End With

        With ButtonTodasSalidasOff
            .Text = "OFF"
            .BackColor = Color.Red
        End With

        With ButtonSalidaTemporizada
            .Text = "Salida 0 Temporizada"
            .BackColor = Color.Green
            .Enabled = False
        End With

        With ButtonPulsosOn
            .Text = "Pulsos ON"
            .BackColor = Color.Green
            .Enabled = False
        End With

        With ButtonPulsosOff
            .Text = "Pulsos OFF"
            .BackColor = Color.Red
            .Enabled = False
        End With

        'Leer estado entrada 0
        GroupBoxEntrada0.Text = "Entrada 0"
        With LabelEstadoEntrada0
            .Text = ""
            .AutoSize = False
            .Height = 20
            .Width = 60
            .BackColor = Color.Green
        End With

        'Leer estado entrada 1
        GroupBoxEntrada1.Text = "Entrada 1"
        With LabelEstadoEntrada1
            .Text = ""
            .AutoSize = False
            .Height = 20
            .Width = 60
            .BackColor = Color.Green
        End With

        'Leer estado entrada 2
        GroupBoxEntrada2.Text = "Entrada 2"
        With LabelEstadoEntrada2
            .Text = ""
            .AutoSize = False
            .Height = 20
            .Width = 60
            .BackColor = Color.Green
        End With

        'Función que busca los puertos existentes en la máquina donde se ejecuta
        'la aplicación y los enumera en el combobox para que el usuario escoja un puerto
        Buscapuertos()

        'Ajustamos la sensibilidad del puerto serie para leer
        SerialPort.ReceivedBytesThreshold = 2

        Timer.Interval = 5000

        TimerPulsos.Interval = 1000

        Salida1Activada = 0
    End Sub

    Private Sub cerrandoForm(sender As Object, e As EventArgs) Handles Me.Closing
        If SerialPort.IsOpen Then
            Call DesconectarPuerto(sender, e)
        End If
    End Sub

    Public Sub Buscapuertos()
        'Utilizamos un bloque Try catch para capturar cualquier excepción que nos de el PC
        Try
            ComboBoxPuertos.Items.Clear()
            'My.Computer.Ports.SerialPortNames es una lista de los nombres de los puertos disponibles
            For Each nombre As String In My.Computer.Ports.SerialPortNames
                'Añadimos al ComboPort los nombres de los puertos disponibles
                ComboBoxPuertos.Items.Add(nombre)
            Next
            'Si ha encontrado algún puerto disponible, seleccionamos el primero
            If ComboBoxPuertos.Items.Count > 0 Then
                ComboBoxPuertos.SelectedIndex = 0
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

    Private Sub ConectarPuerto(sender As Object, e As EventArgs) Handles ButtonConectar.Click
        'Utilizamos un bloque Try catch para capturar cualquier excepción que nos de windows
        Try
            'Configuro el puerto, le asigno el nombre y lo abrimos
            With SerialPort
                .BaudRate = 9600
                .DataBits = 8
                .Parity = IO.Ports.Parity.Even
                .StopBits = IO.Ports.StopBits.One
                'Asigno el nombre del puerto que ha encontrado el procedimiento buscapuertos()
                .PortName = ComboBoxPuertos.Text
                'Abrimos el puerto Enviar
                .Open()
                'Si hemos podido abrirlo, lo indicamos
                If .IsOpen Then
                    .DiscardInBuffer()
                    .DiscardOutBuffer()
                    PictureBoxEstadoPuerto.BackgroundImage = My.Resources._ON
                    LabelEstadoPuerto.Text = "CONECTADO A " & .PortName
                    LabelEstadoPuerto.ForeColor = Color.Blue
                    ButtonConectar.BackColor = Color.LimeGreen
                    'Habilitamos el button desconectar y deshabilitamos el button conectar
                    ButtonDesconectar.Enabled = True
                    ButtonConectar.Enabled = False
                    'Habilito los botones del groupbox_salida0
                    GroupBoxSalida0.Enabled = True
                    GroupBoxSalida1.Enabled = True
                    GroupBoxTodasSalidas.Enabled = True
                    ButtonSalidaTemporizada.Enabled = True
                    ButtonPulsosOn.Enabled = True
                    ButtonPulsosOff.Enabled = True
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

    Private Sub DesconectarPuerto(sender As Object, e As EventArgs) Handles ButtonDesconectar.Click
        'Si el puerto está abierto
        With SerialPort
            If .IsOpen Then
                'Limpia el puerto de salida y de entrada (Carácteres residuales)
                .DiscardInBuffer()
                .DiscardOutBuffer()
                'Cerramos el puerto de Enviar
                .Close()
                'Llamamos de nuevo al form1_Load, para que todo quede igual
                Call cargarForm(sender, e)
            Else Me.OnClosing(e)
                'Avisamos de que no estamos conectados
                MsgBox("EL PUERTO NO ESTÁ ABIERTO", MsgBoxStyle.Exclamation)
            End If
        End With
    End Sub

    Private Sub encenderSalida0(sender As Object, e As EventArgs) Handles ButtonSalida0On.Click
        Dim Trama_Saliente As Byte() 'Declaro la matriz de bytes
        'La trama es: 34 F2 '@' >>> 34 y F2 son los dos bytes que vamos a transmitir
        'El &H40 representa el carácter '@'
        Trama_Saliente = New Byte(2) {
                &H34,
                &HF2,
                &H40} 'Asigno a la matriz 3 posiciones
        'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
        'hasta el último componente de la matriz.
        enviarDatos(Trama_Saliente)
        ButtonSalida0On.Enabled = False
        ButtonSalida0Off.Enabled = True
    End Sub

    Private Sub apagarSalida0(sender As Object, e As EventArgs) Handles ButtonSalida0Off.Click
        Dim Trama_Saliente As Byte() 'Declaro la matriz de bytes
        'La trama es: 25 31 '@' >>> 34 y F2 son los dos bytes que vamos a transmitir
        'El &H40 representa el carácter '@'
        Trama_Saliente = New Byte(2) {
                &H25,
                &H31,
                &H40} 'Asigno a la matriz 3 posiciones
        'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
        'hasta el último componente de la matriz.
        enviarDatos(Trama_Saliente) 'Enviar trama
        ButtonSalida0On.Enabled = True
        ButtonSalida0Off.Enabled = False
    End Sub

    Private Sub encenderSalida0Temporizada(sender As Object, e As EventArgs) Handles ButtonSalidaTemporizada.Click
        Call encenderSalida0(sender, e)
        Timer.Enabled = True
    End Sub

    Private Sub apagarSalida0Temporizada(sender As Object, e As EventArgs) Handles Timer.Tick
        Call apagarSalida0(sender, e)
    End Sub

    Private Sub encenderSalida1(sender As Object, e As EventArgs) Handles ButtonSalida1On.Click
        Dim Trama_Saliente As Byte() 'Declaro la matriz de bytes
        'La trama es: 34 F2 '@' >>> 34 y F2 son los dos bytes que vamos a transmitir
        'El &H40 representa el carácter '@'
        Trama_Saliente = New Byte(2) {
                &H22,
                &HF1,
                &H40} 'Asigno a la matriz 3 posiciones
        'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
        'hasta el último componente de la matriz.
        enviarDatos(Trama_Saliente)
        ButtonSalida1On.Enabled = False
        ButtonSalida1Off.Enabled = True
    End Sub

    Private Sub apagarSalida1(sender As Object, e As EventArgs) Handles ButtonSalida1Off.Click
        Dim Trama_Saliente As Byte() 'Declaro la matriz de bytes
        'La trama es: 25 31 '@' >>> 34 y F2 son los dos bytes que vamos a transmitir
        'El &H40 representa el carácter '@'
        Trama_Saliente = New Byte(2) {
                &H11,
                &H23,
                &H40} 'Asigno a la matriz 3 posiciones
        'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
        'hasta el último componente de la matriz.
        enviarDatos(Trama_Saliente) 'Enviar trama
        ButtonSalida1On.Enabled = True
        ButtonSalida1Off.Enabled = False
    End Sub

    Private Sub encenderSalida1Pulsos(sender As Object, e As EventArgs) Handles ButtonPulsosOn.Click
        TimerPulsos.Enabled = True
    End Sub

    Private Sub apagarSalida1Pulsos(sender As Object, e As EventArgs) Handles ButtonPulsosOff.Click
        TimerPulsos.Enabled = False
        Salida1Activada = False
        Call apagarSalida1(sender, e)
    End Sub

    Private Sub conmutarSalida1(sender As Object, e As EventArgs) Handles TimerPulsos.Tick
        If Salida1Activada Then
            Call apagarSalida1(sender, e)
            Salida1Activada = False
        Else
            Call encenderSalida1(sender, e)
            Salida1Activada = True
        End If
    End Sub

    Private Sub encenderTodasSalidas(sender As Object, e As EventArgs) Handles ButtonTodasSalidasOn.Click
        Dim Trama_Saliente As Byte() 'Declaro la matriz de bytes
        'La trama es: 34 F2 '@' >>> 34 y F2 son los dos bytes que vamos a transmitir
        'El &H40 representa el carácter '@'
        Trama_Saliente = New Byte(2) {
                &HAA,
                &HBB,
                &H40} 'Asigno a la matriz 3 posiciones
        'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
        'hasta el último componente de la matriz.
        enviarDatos(Trama_Saliente)
        ButtonTodasSalidasOn.Enabled = False
        ButtonTodasSalidasOff.Enabled = True
    End Sub

    Private Sub apagarTodasSalidas(sender As Object, e As EventArgs) Handles ButtonTodasSalidasOff.Click
        Dim Trama_Saliente As Byte() 'Declaro la matriz de bytes
        'La trama es: 25 31 '@' >>> 34 y F2 son los dos bytes que vamos a transmitir
        'El &H40 representa el carácter '@'
        Trama_Saliente = New Byte(2) {
                &HCC,
                &HDD,
                &H40} 'Asigno a la matriz 3 posiciones
        'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
        'hasta el último componente de la matriz.
        enviarDatos(Trama_Saliente) 'Enviar trama
        ButtonTodasSalidasOn.Enabled = True
        ButtonTodasSalidasOff.Enabled = False
    End Sub

    Private Sub enviarDatos(Trama_Saliente As Byte())
        'Si el puerto está abierto
        If SerialPort.IsOpen Then
            'Voy a intentar enviar la trama de activar la salida 0 del PLC
            Try
                'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
                'hasta el último componente de la matriz.
                SerialPort.Write(Trama_Saliente, 0, Trama_Saliente.Length) 'Enviar trama
            Catch ex As Exception
                MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub leerDatos(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        Beep()
        'Defino el tamaño de la matriz de lectura, con el número de bytes,
        'presentes en el buffer de entrada, en el momento de la lectura
        With SerialPort
            Trama_Entrante = New Byte(.BytesToRead - 1) {}
            'leemos la trama recibida y la guardamos en la matriz Trama_Entrante
            .Read(Trama_Entrante, 0, 2)
            Me.Invoke(New EventHandler(AddressOf modificarLabelEntradas))
            'limpieza de buffers de entrada y salida
            .DiscardInBuffer()
            .DiscardOutBuffer()
        End With
    End Sub

    Public Sub modificarLabelEntradas()
        Select Case Trama_Entrante(0) And Trama_Entrante(1)
            Case &H22 And &H33
                LabelEstadoEntrada0.BackColor = Color.Green
            Case &H7B And &H5D
                LabelEstadoEntrada0.BackColor = Color.Red
            Case &H33 And &H44
                LabelEstadoEntrada1.BackColor = Color.Green
            Case &H8C And &H6E
                LabelEstadoEntrada1.BackColor = Color.Red
            Case &H44 And &H55
                LabelEstadoEntrada2.BackColor = Color.Green
            Case &H9D And &H7F
                LabelEstadoEntrada2.BackColor = Color.Red
        End Select
    End Sub
End Class