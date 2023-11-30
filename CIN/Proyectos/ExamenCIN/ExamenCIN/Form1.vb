Imports System.IO.Ports

Public Class Form1
    Private Sub cargarForm(sender As Object, e As EventArgs) Handles MyBase.Load
        'Definimos tipo de letra de los objetos del formulario
        Fuente_Personal = New Font("Verdana", 15, FontStyle.Bold, GraphicsUnit.Pixel)
        'Habilito y deshabilito los Buttono conectar y desconectar
        ButtonConectar.Enabled = True
        ButtonDesconectar.Enabled = False

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

        'Deshabilito los botones del groupbox_salida0
        GroupBoxSalida0.Enabled = False
        GroupBoxSalida1.Enabled = False
    End Sub

    Private Sub cerrandoForm(sender As Object, e As EventArgs) Handles Me.Closing
        If SerialPort.IsOpen Then
            Call DesconectarPuerto(sender, e)
        End If
    End Sub

    Private Sub ConectarPuerto(sender As Object, e As EventArgs) Handles ButtonConectar.Click
        'Utilizamos un bloque Try catch para capturar cualquier excepción que nos de windows
        Try
            'Configuro el puerto, le asigno el nombre y lo abrimos
            With SerialPort
                .BaudRate = 19200
                .DataBits = 8
                .Parity = IO.Ports.Parity.Odd
                .StopBits = IO.Ports.StopBits.One
                'Asigno el nombre del puerto que ha encontrado el procedimiento buscapuertos()
                .PortName = "COM5"
                'Abrimos el puerto Enviar
                .Open()
                'Si hemos podido abrirlo, lo indicamos
                If .IsOpen Then
                    .DiscardInBuffer()
                    .DiscardOutBuffer()
                    ButtonConectar.BackColor = Color.LimeGreen
                    'Habilitamos el button desconectar y deshabilitamos el button conectar
                    ButtonDesconectar.Enabled = True
                    ButtonConectar.Enabled = False
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
                Call cargarForm(sender, e)
            Else Me.OnClosing(e)
                'Avisamos de que no estamos conectados
                MsgBox("EL PUERTO NO ESTÁ ABIERTO", MsgBoxStyle.Exclamation)
            End If
        End With
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

    Private Sub encenderSalida0(sender As Object, e As EventArgs) Handles ButtonSalida0On.Click
        Dim Trama_Saliente As Byte() 'Declaro la matriz de bytes
        'La trama es: 34 F2 '@' >>> 34 y F2 son los dos bytes que vamos a transmitir
        'El &H40 representa el carácter '@'
        Trama_Saliente = New Byte(8) {
                &HAA,
                &HBB,
                &HCC,
                &HDD,
                &H0,
                &H0,
                &H0,
                &H0,
                &H42} 'Asigno a la matriz 3 posiciones
        'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
        'hasta el último componente de la matriz.
        enviarDatos(Trama_Saliente)
    End Sub

    Private Sub apagarSalida0(sender As Object, e As EventArgs) Handles ButtonSalida0Off.Click
        Dim Trama_Saliente As Byte() 'Declaro la matriz de bytes
        'La trama es: 34 F2 '@' >>> 34 y F2 son los dos bytes que vamos a transmitir
        'El &H40 representa el carácter '@'
        Trama_Saliente = New Byte(8) {
                &H0,
                &H0,
                &H0,
                &H0,
                &H11,
                &H22,
                &H33,
                &H44,
                &H42} 'Asigno a la matriz 3 posiciones
        'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
        'hasta el último componente de la matriz.
        enviarDatos(Trama_Saliente)
    End Sub

    Private Sub encenderSalida1(sender As Object, e As EventArgs) Handles ButtonSalida1On.Click
        Dim Trama_Saliente As Byte() 'Declaro la matriz de bytes
        'La trama es: 34 F2 '@' >>> 34 y F2 son los dos bytes que vamos a transmitir
        'El &H40 representa el carácter '@'
        Trama_Saliente = New Byte(8) {
                &H1A,
                &H1B,
                &H1C,
                &H1D,
                &H0,
                &H0,
                &H0,
                &H0,
                &H42} 'Asigno a la matriz 3 posiciones
        'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
        'hasta el último componente de la matriz.
        enviarDatos(Trama_Saliente)
    End Sub

    Private Sub apagarSalida1(sender As Object, e As EventArgs) Handles ButtonSalida1Off.Click
        Dim Trama_Saliente As Byte() 'Declaro la matriz de bytes
        'La trama es: 34 F2 '@' >>> 34 y F2 son los dos bytes que vamos a transmitir
        'El &H40 representa el carácter '@'
        Trama_Saliente = New Byte(8) {
                &H0,
                &H0,
                &H0,
                &H0,
                &HA1,
                &HB1,
                &HC1,
                &HD1,
                &H42} 'Asigno a la matriz 3 posiciones
        'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
        'hasta el último componente de la matriz.
        enviarDatos(Trama_Saliente)
    End Sub
End Class
