Module ModBUS
    Public Sub WMUltReg(nodo As Byte, inicio As Byte(), cantidad As Byte(), bytes As Byte, valores As Byte())
        Trama_Saliente = New Byte(6) {
            nodo,
            &H10,
            inicio(0), inicio(1),
            cantidad(0), cantidad(1),
            bytes
        }

        Array.Resize(Trama_Saliente, Trama_Saliente.Length + valores.Length + 2)

        For index = 6 To valores.Length
            Trama_Saliente(index) = &H11
        Next

        Dim crc As Byte() = Calculo_CRC(Trama_Saliente) 'Call CRC Calculator
        Trama_Saliente.Append(crc(0)) 'Error check Lo.
        Trama_Saliente.Append(crc(1)) 'Error check Hi.

        sendData(Trama_Saliente)
    End Sub
End Module
