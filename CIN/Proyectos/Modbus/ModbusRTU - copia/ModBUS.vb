Module ModBUS
    Public Sub WMUltReg(nodo As Byte, inicio As Byte(), cantidad As Byte(), bytes As Byte, valores As Byte())
        Trama_Saliente = New Byte(8 + valores.Length) {}

        Trama_Saliente(0) = nodo
        Trama_Saliente(1) = &H10
        Trama_Saliente(2) = inicio(0)
        Trama_Saliente(3) = inicio(1)
        Trama_Saliente(4) = cantidad(0)
        Trama_Saliente(5) = cantidad(1)
        Trama_Saliente(6) = bytes

        For index = 0 To valores.Length - 1
            Trama_Saliente(index + 7) = valores(index)
        Next

        Dim crc As Byte() = Calculo_CRC(Trama_Saliente) 'Call CRC Calculator
        Trama_Saliente(Trama_Saliente.Length - 2) = crc(0) 'Error check Lo.
        Trama_Saliente(Trama_Saliente.Length - 1) = crc(1) 'Error check Hi.

        sendData(Trama_Saliente)
    End Sub
End Module
