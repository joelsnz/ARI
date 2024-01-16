Imports System.IO.Ports

Module Ports
    Public Sub Buscapuertos(ComboBox_Puertos As ComboBox)
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

    Public Sub openSerialPort(port As SerialPort, name As String)
        Try
            With port
                .BaudRate = 38400
                .DataBits = 8
                .Parity = IO.Ports.Parity.Even
                .StopBits = IO.Ports.StopBits.One
                'Asigno el nombre del puerto que ha encontrado el procedimiento buscapuertos()
                .PortName = name
                'Abrimos el puerto Enviar
                .Open()
                .DiscardInBuffer()
                .DiscardOutBuffer()
            End With
        Catch ex As Exception
            'Capturo la excepción
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub closeSerialPort(port As SerialPort)
        'Limpia el puerto de salida y de entrada (Carácteres residuales)
        With port
            .DiscardInBuffer()
            .DiscardOutBuffer()
            'Cerramos el puerto de Enviar
            .Close()
            'Llamamos de nuevo al form1_Load, para que todo quede igual
            Call deactivateApplication()
        End With
    End Sub

    Public Sub sendData(data As Byte())
        Try
            'Mostramos la trama en un TextBox
            Form1.TextBox_Trama_Enviada.Text = Conversor_tramaBytes_a_tramaString(data)
            'Enviamos la trama de bytes por el puerto. Desde el componente 0 de la matriz
            'hasta el último componente de la matriz
            Form1.SerialPort.Write(data, 0, data.Length) 'Enviar trama
        Catch ex As Exception
            MessageBox.Show(Form1, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
