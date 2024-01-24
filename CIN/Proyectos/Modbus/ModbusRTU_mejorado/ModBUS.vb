Imports System.IO.Ports

Module ModBUS
    ''' <summary>
    ''' Direcciones de los esclavos conectados
    ''' </summary>
    Public Enum nodos
        MX2 = &H1
        E5CN = &H2
        C40 = &H3
    End Enum

    ''' <summary>
    ''' Direcciones de las funciones ModBUS
    ''' </summary>
    Public Enum funciones
        WMultReg = &H10
        RHoldReg = &H3
        RInReg = &H4
        WMultCoils = &HF
        WSingCoil = &H5
        WSingReg = &H6
    End Enum

    ''' <summary>
    ''' Trama ModBUS nodo, función, dirección inicial, cantidad de registros, cantidad de bytes y valores
    ''' </summary>
    Structure Long_trama
        Dim nodo As Byte
        Dim funcion As Byte
        Dim inicio As Byte()
        Dim cantidad As Byte()
        Dim cantidad_bytes As Byte
        Dim valores As Byte()
    End Structure

    ''' <summary>
    ''' Trama ModBUs nodo, función, dirección inicial y valores
    ''' </summary>
    Structure Short_trama
        Dim nodo As Byte
        Dim funcion As Byte
        Dim direccion As Byte()
        Dim valores As Byte()
    End Structure

    ''' <summary>
    ''' Construye y envía una trama ModBUS
    ''' </summary>
    ''' <param name="trama">
    ''' Trama ModBUS a enviar
    ''' </param>
    Public Sub SendModBUS(trama As Long_trama)
        'definir la longitud en bytes de la respuesta de la trama
        If trama.funcion = funciones.RHoldReg Then
            Form1.SerialPort.ReceivedBytesThreshold = 9
        Else
            Form1.SerialPort.ReceivedBytesThreshold = 8
        End If

        'declarar y construir la trama a enviar
        Trama_Saliente = New Byte(8 + trama.valores.Length) {}

        Trama_Saliente(0) = trama.nodo
        Trama_Saliente(1) = trama.funcion
        Trama_Saliente(2) = trama.inicio(0)
        Trama_Saliente(3) = trama.inicio(1)
        Trama_Saliente(4) = trama.cantidad(0)
        Trama_Saliente(5) = trama.cantidad(1)
        Trama_Saliente(6) = trama.cantidad_bytes

        For index = 0 To trama.valores.Length - 1
            Trama_Saliente(index + 7) = trama.valores(index)
        Next

        'cálculo del crc y adición a la trama
        Dim crc As Byte() = Calculo_CRC(Trama_Saliente)
        Trama_Saliente(Trama_Saliente.Length - 2) = crc(0)
        Trama_Saliente(Trama_Saliente.Length - 1) = crc(1)

        'mostrar la trama en un TextBox
        Form1.TextBox_Trama_Enviada.Text = Conversor_tramaBytes_a_tramaString(Trama_Saliente)

        sendData(Trama_Saliente)
    End Sub

    ''' <summary>
    ''' Construye y envía una trama ModBUS
    ''' </summary>
    ''' <param name="trama">
    ''' Trama ModBUS a enviar
    ''' </param>
    Public Sub sendModBUS(trama As Short_trama)
        'definir la longitud en bytes de la respuesta de la trama
        If trama.funcion = funciones.RHoldReg Or trama.funcion = funciones.RInReg Then
            Form1.SerialPort.ReceivedBytesThreshold = 9
        Else
            Form1.SerialPort.ReceivedBytesThreshold = 8
        End If

        Trama_Saliente = New Byte(7) {}

        Trama_Saliente(0) = trama.nodo
        Trama_Saliente(1) = trama.funcion
        Trama_Saliente(2) = trama.direccion(0)
        Trama_Saliente(3) = trama.direccion(1)
        Trama_Saliente(4) = trama.valores(0)
        Trama_Saliente(5) = trama.valores(1)

        'cálculo del crc y adición a la trama
        Dim crc As Byte() = Calculo_CRC(Trama_Saliente)
        Trama_Saliente(Trama_Saliente.Length - 2) = crc(0)
        Trama_Saliente(Trama_Saliente.Length - 1) = crc(1)

        'mostrar la trama en un TextBox
        Form1.TextBox_Trama_Enviada.Text = Conversor_tramaBytes_a_tramaString(Trama_Saliente)

        sendData(Trama_Saliente)
    End Sub
End Module
