﻿Imports System.ComponentModel
Imports System.ComponentModel.Design.Serialization
Imports System.IO.Ports

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
        LabelEstadoPuerto.ForeColor = Color.DarkRed
        LabelEstadoPuerto.Text = "DESCONECTADO"
        LabelEstadoPuerto.AutoSize = True
        PictureBoxEstadoPuerto.BackgroundImageLayout = ImageLayout.Stretch
        PictureBoxEstadoPuerto.BackgroundImage = My.Resources.OFF

        'Personalizamos nuestro formulario
        With Me
            .Font = Fuente_Personal
            .BackColor = Color.AliceBlue
            .Text = "COMUNICACIÓN SERIE SIN PROTOCOLO NX1P2"
        End With

        'Insertamos texto y color en los objetos
        ButtonConectar.Text = "CONECTAR"
        ButtonConectar.BackColor = Color.Green
        ButtonDesconectar.Text = "DESCONECTAR"
        ButtonDesconectar.BackColor = Color.Red

        'Leer estado entrada 0
        GroupBoxEntrada0.Text = "Entrada 0"
        LabelEstadoEntrada0.Text = ""
        LabelEstadoEntrada0.AutoSize = False
        LabelEstadoEntrada0.Height = 20
        LabelEstadoEntrada0.Width = 60
        LabelEstadoEntrada0.BackColor = Color.Green

        'Leer estado entrada 1
        GroupBoxEntrada1.Text = "Entrada 1"
        LabelEstadoEntrada1.Text = ""
        LabelEstadoEntrada1.AutoSize = False
        LabelEstadoEntrada1.Height = 20
        LabelEstadoEntrada1.Width = 60
        LabelEstadoEntrada1.BackColor = Color.Green

        'Leer estado entrada 2
        GroupBoxEntrada2.Text = "Entrada 2"
        LabelEstadoEntrada2.Text = ""
        LabelEstadoEntrada2.AutoSize = False
        LabelEstadoEntrada2.Height = 20
        LabelEstadoEntrada2.Width = 60
        LabelEstadoEntrada2.BackColor = Color.Green

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

    Private Sub ButtonConectar_Click(sender As Object, e As EventArgs) Handles ButtonConectar.Click
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
                    SerialPort.DiscardInBuffer()
                    SerialPort.DiscardOutBuffer()
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

    Private Sub ButtonDesconectar_Click(sender As Object, e As EventArgs) Handles ButtonDesconectar.Click
        'Si el puerto está abierto
        If SerialPort.IsOpen Then
            'Limpia el puerto de salida y de entrada (Carácteres residuales)
            SerialPort.DiscardInBuffer()
            SerialPort.DiscardOutBuffer()
            'Cerramos el puerto de Enviar
            SerialPort.Close()
            'Llamamos de nuevo al form1_Load, para que todo quede igual
            Call Form1_Load(sender, e)
        Else
            'Avisamos de que no estamos conectados
            MsgBox("EL PUERTO NO ESTÁ ABIERTO", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If SerialPort.IsOpen Then
            Call ButtonDesconectar_Click(sender, e)
        End If
    End Sub

    Private Sub CheckBoxSalida0_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSalida0.CheckedChanged
        If CheckBoxSalida0.Checked Then
            'Si el puerto está abierto
            If SerialPort.IsOpen Then
                'Voy a intentar enviar la trama de activar la salida 0 del PLC
                Try
                    Dim Trama_Saliente As Byte() 'Declaro la matriz de bytes
                    Trama_Saliente = New Byte(2) {} 'Asigno a la matriz 3 posiciones
                    'Asigno un valor a cada byte
                    'La trama es: 34 F2 '@' >>> 34 y F2 son los dos bytes que vamos a transmitir
                    Trama_Saliente(0) = &H34
                    Trama_Saliente(1) = &HF2
                    Trama_Saliente(2) = &H40 'El &H40 representa el carácter '@'
                    'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
                    'hasta el último componente de la matriz.
                    SerialPort.Write(Trama_Saliente, 0, Trama_Saliente.Length) 'Enviar trama
                Catch ex As Exception
                    MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            'Si el puerto está abierto
            If SerialPort.IsOpen Then
                'Voy a intentar enviar la trama de activar la salida 0 del PLC
                Try
                    Dim Trama_Saliente As Byte() 'Declaro la matriz de bytes
                    Trama_Saliente = New Byte(2) {} 'Asigno a la matriz 3 posiciones
                    'Asigno un valor a cada byte
                    'La trama es: 25 31 '@' >>> 34 y F2 son los dos bytes que vamos a transmitir
                    Trama_Saliente(0) = &H25
                    Trama_Saliente(1) = &H31
                    Trama_Saliente(2) = &H40 'El &H40 representa el carácter '@'
                    'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
                    'hasta el último componente de la matriz.
                    SerialPort.Write(Trama_Saliente, 0, Trama_Saliente.Length) 'Enviar trama
                Catch ex As Exception
                    MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub CheckBoxSalida1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSalida1.CheckedChanged
        If CheckBoxSalida1.Checked Then
            'Si el puerto está abierto
            If SerialPort.IsOpen Then
                'Voy a intentar enviar la trama de activar la salida 0 del PLC
                Try
                    Dim Trama_Saliente As Byte() 'Declaro la matriz de bytes
                    Trama_Saliente = New Byte(2) {} 'Asigno a la matriz 3 posiciones
                    'Asigno un valor a cada byte
                    'La trama es: 22 F1 '@' >>> 34 y F2 son los dos bytes que vamos a transmitir
                    Trama_Saliente(0) = &H22
                    Trama_Saliente(1) = &HF1
                    Trama_Saliente(2) = &H40 'El &H40 representa el carácter '@'
                    'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
                    'hasta el último componente de la matriz.
                    SerialPort.Write(Trama_Saliente, 0, Trama_Saliente.Length) 'Enviar trama
                Catch ex As Exception
                    MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            'Si el puerto está abierto
            If SerialPort.IsOpen Then
                'Voy a intentar enviar la trama de activar la salida 0 del PLC
                Try
                    Dim Trama_Saliente As Byte() 'Declaro la matriz de bytes
                    Trama_Saliente = New Byte(2) {} 'Asigno a la matriz 3 posiciones
                    'Asigno un valor a cada byte
                    'La trama es: 11 23 '@' >>> 34 y F2 son los dos bytes que vamos a transmitir
                    Trama_Saliente(0) = &H11
                    Trama_Saliente(1) = &H23
                    Trama_Saliente(2) = &H40 'El &H40 representa el carácter '@'
                    'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
                    'hasta el último componente de la matriz.
                    SerialPort.Write(Trama_Saliente, 0, Trama_Saliente.Length) 'Enviar trama
                Catch ex As Exception
                    MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub SerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        Beep()
        'Defino el tamaño de la matriz de lectura, con el número de bytes,
        'presentes en el buffer de entrada, en el momento de la lectura
        Trama_Entrante = New Byte(SerialPort.BytesToRead - 1) {}
        'leemos la trama recibida y la guardamos en la matriz Trama_Entrante
        SerialPort.Read(Trama_Entrante, 0, 2)
        Me.Invoke(New EventHandler(AddressOf modificar))
        'limpieza de buffers de entrada y salida
        SerialPort.DiscardInBuffer()
        SerialPort.DiscardOutBuffer()
    End Sub

    Public Sub modificar()
        If (Trama_Entrante(0) = &H22) And (Trama_Entrante(1) = &H33) Then
            LabelEstadoEntrada0.BackColor = Color.Green
        End If
        If (Trama_Entrante(0)) = &H7B And (Trama_Entrante(1) = &H5D) Then
            LabelEstadoEntrada0.BackColor = Color.Red
        End If
        If (Trama_Entrante(0) = &H33) And (Trama_Entrante(1) = &H44) Then
            LabelEstadoEntrada1.BackColor = Color.Green
        End If
        If (Trama_Entrante(0)) = &H8C And (Trama_Entrante(1) = &H6E) Then
            LabelEstadoEntrada1.BackColor = Color.Red
        End If
        If (Trama_Entrante(0) = &H44) And (Trama_Entrante(1) = &H55) Then
            LabelEstadoEntrada2.BackColor = Color.Green
        End If
        If (Trama_Entrante(0)) = &H9D And (Trama_Entrante(1) = &H7F) Then
            LabelEstadoEntrada2.BackColor = Color.Red
        End If
    End Sub
End Class