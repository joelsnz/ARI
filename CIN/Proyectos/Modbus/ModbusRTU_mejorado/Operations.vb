Imports System.IO.Ports
Imports System.Reflection
Imports System.Reflection.Emit
Imports System.Text

Module Operations
    ''' <summary>
    ''' Cálculo del CRC de una trama ModBUS
    ''' </summary>
    ''' <param name="data">
    ''' Trama ModBUS de la cual calcular el CRC
    ''' </param>
    ''' <returns>
    ''' CRCLow, CRCHigh
    ''' </returns>
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

    ''' <summary>
    ''' Convertir una trama en bytes a su representación en cadena de texto
    ''' </summary>
    ''' <param name="trama">
    ''' Trama a transformar
    ''' </param>
    ''' <returns>
    ''' Trama transformada a cadena de texto
    ''' </returns>
    Public Function Conversor_tramaBytes_a_tramaString(trama As Byte()) As String
        Dim result As String
        result = ""
        For Each componente As Byte In trama
            result = result + String.Format("{0:X2} ", componente)
        Next
        Return result
    End Function

    ''' <summary>
    ''' Conversor de hexadecimal a decimal
    ''' </summary>
    ''' <param name="trama">
    ''' Valor hexadecimal en arreglo de bytes
    ''' </param>
    ''' <returns>
    ''' Valor convertido a decimal
    ''' </returns>
    Function hexToDec(trama As Byte()) As Integer
        Dim trama_string As String = Conversor_tramaBytes_a_tramaString(trama)

        trama_string = trama_string.Replace(" ", "")

        Return Convert.ToInt32(trama_string, 16)
    End Function

    ''' <summary>
    ''' Conversor de decimal a hexadecimal
    ''' </summary>
    ''' <param name="valor">
    ''' Valor decimal entero
    ''' </param>
    ''' <returns>
    ''' Valor convertido a hexadecimal en arreglo de bytes (&HXX)
    ''' </returns>
    Function decToHex(valor As Integer) As Byte()
        Dim hex_value As String
        Dim result As Byte()

        hex_value = Hex(valor).PadLeft(4, "0"c)

        result = {Convert.ToByte(Mid(hex_value, 1, 2), 16),
                  Convert.ToByte(Mid(hex_value, 3, 2), 16)}

        Return result
    End Function

    ''' <summary>
    ''' Representar los datos recibidos de una trama respuesta
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Public Sub modificar(sender As Object, e As EventArgs)
        Dim numero_nodo As nodos
        Dim function_code As funciones

        numero_nodo = Trama_Entrante(0)
        function_code = Trama_Entrante(1)

        Form1.TextBox_Trama_Recibida.Text = Conversor_tramaBytes_a_tramaString(Trama_Entrante)

        If function_code = funciones.RHoldReg Then
            Select Case numero_nodo
                Case nodos.MX2
                    Form1.Label_Frecuencia_Leida.Text = hexToDec({Trama_Entrante(5), Trama_Entrante(6)}) / 100
                Case nodos.E5CN
                    temperatura = hexToDec({Trama_Entrante(5), Trama_Entrante(6)}) / 10
                    Form1.Label_Temperatura_Leida.Text = temperatura
            End Select
        End If
    End Sub

    Public Sub arrancar_motor()
        Dim trama As Short_trama

        trama.nodo = nodos.MX2
        trama.funcion = funciones.WSingCoil
        trama.direccion = {&H0, &H0}
        trama.valores = {&HFF, &H0}

        sendModBUS(trama)
    End Sub

    Public Sub parar_motor()
        Dim trama As Short_trama

        trama.nodo = nodos.MX2
        trama.funcion = funciones.WSingCoil
        trama.direccion = {&H0, &H0}
        trama.valores = {&H0, &H0}

        sendModBUS(trama)
    End Sub
End Module