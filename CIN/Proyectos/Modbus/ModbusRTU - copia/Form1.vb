Imports System.ComponentModel
Imports System.IO.Ports
Imports System.Linq.Expressions
Imports System.Threading

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        deactivateApplication()
    End Sub

    Private Sub Button_Conectar_Click(sender As Object, e As EventArgs) Handles Button_Conectar.Click
        openSerialPort(SerialPort, ComboBox_Puertos.Text)
        'Si hemos podido abrirlo, lo indicamos
        With SerialPort
            If SerialPort.IsOpen Then
                activateApplication()
            Else
                'Si no hemos podido abrirlo lo indicamos con MsgBox
                MsgBox("FALLO EN LA CONEXIÓN", MsgBoxStyle.Critical)
                Beep()
            End If
        End With
    End Sub

    Private Sub Button_Desconectar_Click(sender As Object, e As EventArgs) Handles Button_Desconectar.Click
        'Si el puerto está abierto
        If SerialPort.IsOpen Then
            closeSerialPort(SerialPort)
            'Llamamos deactivateApplication, para que todo quede igual
            Call deactivateApplication()
        Else
            'Avisamos de que no estamos conectados
            MsgBox("EL PUERTO NO ESTÁ ABIERTO", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'Si el puerto está abierto
        If SerialPort.IsOpen Then
            closeSerialPort(SerialPort)
            'Llamamos deactivateApplication, para que todo quede igual
            Call deactivateApplication()
        End If
    End Sub

    Private Sub ComboBox_Frecuencias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Frecuencias.SelectedIndexChanged
        'Ajustamos la sensibilidad del datareceived
        SerialPort.ReceivedBytesThreshold = 8

        Dim inicio As Byte() = {&H0, &H0}
        Dim cantidad As Byte() = {&H0, &H2}
        Dim bytes As Byte = &H4
        Dim valores As Byte() = {&H0, &H0, &H3, &HE8}

        WMUltReg(nodos.MX2, inicio, cantidad, bytes, valores)
    End Sub
End Class