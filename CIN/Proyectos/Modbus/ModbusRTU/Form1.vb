Imports System.IO.Ports
Imports System.Threading

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Definimos tipo de letra de los objetos del formulario
        Fuente_Personal = New Font("Verdana", 15, FontStyle.Bold, GraphicsUnit.Pixel)

        'Habilito y deshabilito los Button conectar y desconectar
        Button_Conectar.Enabled = True
        Button_Desconectar.Enabled = False

        'Deshabilitamos el GroupBox Variador
        GroupBox_Variador.Enabled = False

        'Mostramos el estado del puerto
        Label_Estado_Puerto.ForeColor = Color.DarkRed
        Label_Estado_Puerto.Text = "DESCONECTADO!!!"
        Label_Estado_Puerto.Enabled = True
        PictureBox_Estado.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox_Estado.BackgroundImage = My.Resources.OFF

        If (ComboBox_Frecuencias.Items.Count = 0) Then
            'Añadimos valores al ComboBox_Frecuencia
            For i = 1 To 6
                ComboBox_Frecuencias.Items.Add(i * 10)
            Next
        End If

        'Personalizamos nuestro formulario
        With Me
            .Font = Fuente_Personal
            .BackColor = Color.AliceBlue
            .Text = "COMUNICACIÓN MODBUS"
        End With

        'Insertamos texto y color en los objetos
        Button_Conectar.Text = "CONECTAR"
        Button_Conectar.BackColor = Color.Green
        Button_Desconectar.Text = "DESCONECTAR"
        Button_Desconectar.BackColor = Color.Red

        'Función que busca los puertos existentes en la máquina donde se ejecuta
        'la aplicación y los enumera en el combox para que le usuario escoja un puente
        Buscapuertos()

        'Personalizamos la etiqueta de frecuencias
        Label_Frecuencias.ForeColor = Color.DarkRed
    End Sub

    Public Sub Buscapuertos()
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
End Class