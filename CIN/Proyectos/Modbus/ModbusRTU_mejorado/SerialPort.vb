Imports System.IO.Ports

Module Ports
    ''' <summary>
    ''' Busca puertos existentes en el host y los lista en un objeto ComboBox
    ''' </summary>
    ''' <param name="ComboBox_Puertos">
    ''' Objeto ComboBox donde guardar los puertos encontrados
    ''' </param>
    Public Sub Buscapuertos(ComboBox_Puertos As ComboBox)
        Try
            ComboBox_Puertos.Items.Clear()
            'My.Computer.Ports.SerialPortNames: lista de los nombres de los puertos disponibles
            'añadir puertos disponibles al ComboBox
            For Each nombre As String In My.Computer.Ports.SerialPortNames
                ComboBox_Puertos.Items.Add(nombre)
            Next

            'seleccionar el primer puerto por defecto
            If ComboBox_Puertos.Items.Count > 0 Then
                ComboBox_Puertos.SelectedIndex = 0
            Else
                MsgBox("NO HAY PUERTOS DISPONIBLES")
                Beep()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ''' <summary>
    ''' Configurar el puerto serie y abrirlo
    ''' </summary>
    ''' <param name="port">
    ''' Objeto SerialPort que se abrirá
    ''' </param>
    ''' <param name="name">
    ''' Nombre del puerto que se abrirá
    ''' </param>
    Public Sub OpenSerialPort(port As SerialPort, name As String)
        Try
            With port
                .BaudRate = 4800
                .DataBits = 8
                .Parity = IO.Ports.Parity.Even
                .StopBits = IO.Ports.StopBits.One
                .PortName = name

                .Open()
                .DiscardInBuffer()
                .DiscardOutBuffer()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    ''' <summary>
    ''' Cerrar puerto serie
    ''' </summary>
    ''' <param name="port">
    ''' Puerto serie a cerrar
    ''' </param>
    Public Sub closeSerialPort(port As SerialPort)
        With port
            .DiscardInBuffer()
            .DiscardOutBuffer()
            .Close()
        End With
    End Sub

    ''' <summary>
    ''' Enviar datos por el puerto serie
    ''' </summary>
    ''' <param name="data">
    ''' Datos a enviar
    ''' </param>
    Public Sub sendData(data As Byte())
        Try
            Form1.SerialPort.Write(data, 0, data.Length)
        Catch ex As Exception
            MessageBox.Show(Form1, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
