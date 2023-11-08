Imports System.ComponentModel
Imports System.ComponentModel.Design.Serialization
Imports System.IO.Ports
Imports System.Linq.Expressions

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Definimos tipo de letra de los objetos del formulario
        Fuente_Personal = New Font("Verdana", 15, FontStyle.Bold, GraphicsUnit.Pixel)
        'Habilito y deshabilito los Buttono conectar y desconectar
        ButtonConectar.Enabled = True
        ButtonDesconectar.Enabled = False

        'Deshabilito los botones del groupbox_salida0
        GroupBoxSalida0.Enabled = False
        GroupBoxSalida1.Enabled = False

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
                Call Form1_Load(sender, e)
            Else Me.OnClosing(e)
                'Avisamos de que no estamos conectados
                MsgBox("EL PUERTO NO ESTÁ ABIERTO", MsgBoxStyle.Exclamation)
            End If
        End With
    End Sub

    Private Sub cerrandoForm(sender As Object, e As EventArgs) Handles Me.Closing
        If SerialPort.IsOpen Then
            Call DesconectarPuerto(sender, e)
        End If
    End Sub

    Private Sub conmutarEntrada0(sender As Object, e As EventArgs) Handles CheckBoxSalida0.CheckedChanged
        Dim Trama_Saliente As Byte() 'Declaro la matriz de bytes
        If CheckBoxSalida0.Checked Then
            'La trama es: 34 F2 '@' >>> 34 y F2 son los dos bytes que vamos a transmitir
            'El &H40 representa el carácter '@'
            Trama_Saliente = New Byte(2) {
                &H34,
                &HF2,
                &H40} 'Asigno a la matriz 3 posiciones
            'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
            'hasta el último componente de la matriz.
            enviarDatos(Trama_Saliente)
        Else
            'La trama es: 25 31 '@' >>> 34 y F2 son los dos bytes que vamos a transmitir
            'El &H40 representa el carácter '@'
            Trama_Saliente = New Byte(2) {
                &H25,
                &H31,
                &H40} 'Asigno a la matriz 3 posiciones
            'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
            'hasta el último componente de la matriz.
            enviarDatos(Trama_Saliente) 'Enviar trama
        End If
    End Sub

    Private Sub conmutarEntrada1(sender As Object, e As EventArgs) Handles CheckBoxSalida1.CheckedChanged
        Dim Trama_Saliente As Byte() 'Declaro la matriz de bytes
        If CheckBoxSalida1.Checked Then
            'La trama es: 34 F2 '@' >>> 34 y F2 son los dos bytes que vamos a transmitir
            'El &H40 representa el carácter '@'
            Trama_Saliente = New Byte(2) {
                &H22,
                &HF1,
                &H40} 'Asigno a la matriz 3 posiciones
            'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
            'hasta el último componente de la matriz.
            enviarDatos(Trama_Saliente)
        Else
            'La trama es: 25 31 '@' >>> 34 y F2 son los dos bytes que vamos a transmitir
            'El &H40 representa el carácter '@'
            Trama_Saliente = New Byte(2) {
                &H11,
                &H23,
                &H40} 'Asigno a la matriz 3 posiciones
            'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
            'hasta el último componente de la matriz.
            enviarDatos(Trama_Saliente) 'Enviar trama
        End If
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

    Private Sub manejarDatosEntrantes(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        Beep()
        'Defino el tamaño de la matriz de lectura, con el número de bytes,
        'presentes en el buffer de entrada, en el momento de la lectura
        With SerialPort
            Trama_Entrante = New Byte(.BytesToRead - 1) {}
            'leemos la trama recibida y la guardamos en la matriz Trama_Entrante
            .Read(Trama_Entrante, 0, 2)
            Me.Invoke(New EventHandler(AddressOf modificarSalidaPLC))
            'limpieza de buffers de entrada y salida
            .DiscardInBuffer()
            .DiscardOutBuffer()
        End With
    End Sub

    Public Sub modificarSalidaPLC()
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