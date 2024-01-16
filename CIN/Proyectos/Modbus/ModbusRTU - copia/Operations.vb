Imports System.IO.Ports
Imports System.Reflection
Imports System.Text

Module Operations
    Public Function Calculo_CRC(data As Byte()) As Byte()
        'Funcion que nos calculará el CRC de las tramas entrantes y salientes
        Dim CRCFull As UShort = &HFFFF
        Dim CRCHigh As Byte = &HF
        Dim CRCLow As Byte = &HFF
        Dim CRCLSB As Char
        Dim result As Byte() = New Byte(1) {}
        For i As Integer = 0 To (data.Length) - 3
            CRCFull = CUShort(CRCFull Xor data(i))
            For j As Integer = 0 To 7
                CRCLSB = ChrW(CRCFull And &H1)
                CRCFull = CUShort((CRCFull >> 1) And &HFFFF)

                If Convert.ToInt32(CRCLSB) = 1 Then
                    CRCFull = CUShort(CRCFull Xor &HA001)
                End If
            Next
        Next
        CRCHigh = CByte((CRCFull >> 8) And &HFF)
        CRCLow = CByte(CRCFull And &HFF)
        Return New Byte(1) {CRCLow, CRCHigh}
    End Function

    Public Function Conversor_tramaBytes_a_tramaString(trama As Byte()) As String
        'Función que transforma una matriz de números a una matriz Strings
        Dim result As String
        result = ""
        For Each componente As Byte In trama
            result = result + String.Format("{0:X2} ", componente)
        Next
        Return result
    End Function

    Function hexToDec(trama As String) As Double
        Dim decimal_result As Double = 0

        trama = StrReverse(trama)

        For index = 0 To trama.Length - 1
            If IsNumeric(trama(index)) Then
                decimal_result += Double.Parse(trama(index)) * (16 ^ index)
            Else
                decimal_result += (Asc(trama(index)) - 55) * (16 ^ index)
            End If
        Next

        Return decimal_result
    End Function
End Module