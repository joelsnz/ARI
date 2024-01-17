Imports System.ComponentModel
Imports System.IO.Ports
Imports System.Linq.Expressions
Imports System.Threading

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'iniciar con la aplicación desactivada
        deactivateApplication()
    End Sub

    Private Sub Button_Conectar_Click(sender As Object, e As EventArgs) Handles Button_Conectar.Click
        'intentar abrir el puerto serie y mostrar el resultado
        OpenSerialPort(SerialPort, ComboBox_Puertos.Text)
        With SerialPort
            If SerialPort.IsOpen Then
                activateApplication()
            Else
                MsgBox("FALLO EN LA CONEXIÓN", MsgBoxStyle.Critical)
                Beep()
            End If
        End With
    End Sub

    Private Sub Button_Desconectar_Click(sender As Object, e As EventArgs) Handles Button_Desconectar.Click
        'desactivar aplicación y cerrar el puerto serie si estaba abierto
        Call deactivateApplication()

        If SerialPort.IsOpen Then
            closeSerialPort(SerialPort)
        Else
            MsgBox("EL PUERTO NO ESTÁ ABIERTO", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'desactivar la aplicación y cerrar el puerto serie si estaba abierto
        Call deactivateApplication()

        If SerialPort.IsOpen Then
            closeSerialPort(SerialPort)
        End If
    End Sub

    Private Sub ComboBox_Frecuencias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Frecuencias.SelectedIndexChanged
        Dim trama As New Long_trama
        Frecuencia = decToHex(ComboBox_Frecuencias.SelectedItem * 100)

        trama.nodo = nodos.MX2
        trama.funcion = funciones.WMultReg
        trama.inicio = {&H0, &H0}
        trama.cantidad = {&H0, &H2}
        trama.cantidad_bytes = &H4
        trama.valores = {&H0, &H0, Frecuencia(0), Frecuencia(1)}

        SendModBUS(trama)
    End Sub

    Private Sub SerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        'definir tamaño según los datos recibidos
        Trama_Entrante = New Byte(SerialPort.BytesToRead - 1) {}

        'leer la trama, almacenarla y mostrar los cambios
        SerialPort.Read(Trama_Entrante, 0, Trama_Entrante.Length)
        Me.Invoke(New EventHandler(AddressOf modificar))

        'limpiar buffers de entrada y salida
        SerialPort.DiscardInBuffer()
        SerialPort.DiscardOutBuffer()
    End Sub

    Private Sub Button_Run_Forward_Click(sender As Object, e As EventArgs) Handles Button_Run_Forward.Click
        Dim trama As Long_trama

        trama.nodo = nodos.MX2
        trama.funcion = funciones.WMultCoils
        trama.inicio = {&H0, &H0}
        trama.cantidad = {&H0, &H2}
        trama.cantidad_bytes = &H2
        trama.valores = {&H1, &H0}

        SendModBUS(trama)
    End Sub

    Private Sub Button_Run_Backward_Click(sender As Object, e As EventArgs) Handles Button_Run_Backward.Click
        Dim trama As Long_trama

        trama.nodo = nodos.MX2
        trama.funcion = funciones.WMultCoils
        trama.inicio = {&H0, &H0}
        trama.cantidad = {&H0, &H2}
        trama.cantidad_bytes = &H2
        trama.valores = {&H3, &H0}

        SendModBUS(trama)
    End Sub

    Private Sub Button_Stop_Click(sender As Object, e As EventArgs) Handles Button_Stop.Click
        Dim trama As Short_trama

        trama.nodo = nodos.MX2
        trama.funcion = funciones.WSingCoil
        trama.direccion = {&H0, &H0}
        trama.valores = {&H0, &H0}

        sendModBUS(trama)
    End Sub

    Private Sub Button_Limpiar_TextBox_Click(sender As Object, e As EventArgs) Handles Button_Limpiar_TextBox.Click
        'limpiar indicadores de tramas de entrada y salida
        TextBox_Trama_Enviada.Clear()
        TextBox_Trama_Recibida.Clear()
    End Sub

    Private Sub Button_Leer_Frecuencia_Click(sender As Object, e As EventArgs) Handles Button_Leer_Frecuencia.Click
        Dim trama As Short_trama

        trama.nodo = nodos.MX2
        trama.funcion = funciones.RHoldReg
        trama.direccion = {&H10, &H0}
        trama.valores = {&H0, &H2}

        sendModBUS(trama)
    End Sub

    Private Sub Button_Run_Click(sender As Object, e As EventArgs) Handles Button_Run.Click
        Dim trama As Short_trama

        trama.nodo = nodos.MX2
        trama.funcion = funciones.WSingCoil
        trama.direccion = {&H0, &H0}
        trama.valores = {&HFF, &H0}

        sendModBUS(trama)
    End Sub

    Private Sub Button_Forward_Click(sender As Object, e As EventArgs) Handles Button_Forward.Click
        Dim trama As Short_trama

        trama.nodo = nodos.MX2
        trama.funcion = funciones.WSingCoil
        trama.direccion = {&H0, &H1}
        trama.valores = {&HFF, &H0}

        sendModBUS(trama)
    End Sub

    Private Sub Button_Backward_Click(sender As Object, e As EventArgs) Handles Button_Backward.Click
        Dim trama As Short_trama

        trama.nodo = nodos.MX2
        trama.funcion = funciones.WSingCoil
        trama.direccion = {&H0, &H1}
        trama.valores = {&H0, &H0}

        sendModBUS(trama)
    End Sub

    Private Sub Button_Acelerar_5s_Click(sender As Object, e As EventArgs) Handles Button_Acelerar_5s.Click
        Dim trama As New Long_trama
        Frecuencia = decToHex(ComboBox_Frecuencias.SelectedItem * 100)

        trama.nodo = nodos.MX2
        trama.funcion = funciones.WMultReg
        trama.inicio = {&H11, &H2}
        trama.cantidad = {&H0, &H2}
        trama.cantidad_bytes = &H4
        trama.valores = {&H0, &H0, &H1, &HF4}

        SendModBUS(trama)
    End Sub

    Private Sub Button_Acelerar_500ms_Click(sender As Object, e As EventArgs) Handles Button_Acelerar_500ms.Click
        Dim trama As New Long_trama
        Frecuencia = decToHex(ComboBox_Frecuencias.SelectedItem * 100)

        trama.nodo = nodos.MX2
        trama.funcion = funciones.WMultReg
        trama.inicio = {&H11, &H2}
        trama.cantidad = {&H0, &H2}
        trama.cantidad_bytes = &H4
        trama.valores = {&H0, &H0, &H0, &H32}

        SendModBUS(trama)
    End Sub

    Private Sub Button_Decelerar_10s_Click(sender As Object, e As EventArgs) Handles Button_Decelerar_10s.Click
        Dim trama As New Long_trama
        Frecuencia = decToHex(ComboBox_Frecuencias.SelectedItem * 100)

        trama.nodo = nodos.MX2
        trama.funcion = funciones.WMultReg
        trama.inicio = {&H11, &H4}
        trama.cantidad = {&H0, &H2}
        trama.cantidad_bytes = &H4
        trama.valores = {&H0, &H0, &H3, &HE8}

        SendModBUS(trama)
    End Sub

    Private Sub Button_Decelerar_2s_Click(sender As Object, e As EventArgs) Handles Button_Decelerar_2s.Click
        Dim trama As New Long_trama
        Frecuencia = decToHex(ComboBox_Frecuencias.SelectedItem * 100)

        trama.nodo = nodos.MX2
        trama.funcion = funciones.WMultReg
        trama.inicio = {&H11, &H4}
        trama.cantidad = {&H0, &H2}
        trama.cantidad_bytes = &H4
        trama.valores = {&H0, &H0, &H0, &HC8}

        SendModBUS(trama)
    End Sub

    Private Sub Button_Leer_Temperatura_Click(sender As Object, e As EventArgs) Handles Button_Leer_Temperatura.Click
        Dim trama As Short_trama

        trama.nodo = nodos.E5CN
        trama.funcion = funciones.RHoldReg
        trama.direccion = {&H0, &H0}
        trama.valores = {&H0, &H2}

        sendModBUS(trama)
    End Sub

    Private Sub Button_run_e5cn_Click(sender As Object, e As EventArgs) Handles Button_run_e5cn.Click
        Dim trama As Short_trama

        trama.nodo = nodos.E5CN
        trama.funcion = funciones.WSingReg
        trama.direccion = {&H0, &H0}
        trama.valores = {&H1, &H0}

        sendModBUS(trama)
    End Sub

    Private Sub Button_stop_e5cn_Click(sender As Object, e As EventArgs) Handles Button_stop_e5cn.Click
        Dim trama As Short_trama

        trama.nodo = nodos.E5CN
        trama.funcion = funciones.WSingReg
        trama.direccion = {&H0, &H0}
        trama.valores = {&H1, &H1}

        sendModBUS(trama)
    End Sub
End Class