Module Module1
    'Variable para guardar un estilo de letra
    Public Fuente_Personal As Font
    'Declaro una cadena String para guardar la trama leida, convertida previamente
    Public Cadena_Entrante As String
    'Declaro una matriz de bytes para la trama leida
    Public Trama_Entrante As Byte()
    'Declaro una matriz de bytes para la trama enviada
    Public Trama_Saliente As Byte()
    Public Temperatura_String As String
    Public Frecuencia_String As String
    Public Temperatura_Numerica As Int32
    Public Frecuencia_Numerica As Int32
    Public Temperatura_Numerica_Doble As Double

    'Funcion que nos calculará el CRC de las tramas entrantes y salientes
    Public Function Calculo_CRC(data As Byte()) As Byte()
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

    'Función que transforma una matriz de números a una matriz Strings
    Public Function Conversor_tramaBytes_a_tramaString(trama As Byte()) As String
        Dim result As String
        result = ""
        For Each componente As Byte In trama
            result = result + String.Format("{0:X2} ", componente)
        Next
        Return result
    End Function
End Module