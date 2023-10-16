Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Definimos tipo de letra de los objetos del formulario
        Fuente_Personal = New Font("Verdana", 15, FontStyle.Bold, GraphicsUnit.Pixel)
        'Habilito y deshabilito los Buttono conectar y desconectar
        ButtonConectar.Enabled = True
        ButtonDesconectar.Enabled = False

        'Mostramos el estado del puerto
        LabelEstadoPuerto.ForeColor = Color.DarkRed
        LabelEstadoPuerto.Text = "DESCONECTADO"
        LabelEstadoPuerto.AutoSize = True
        PictureBoxEstadoPuerto.BackgroundImageLayout = ImageLayout.Stretch
        PictureBoxEstadoPuerto.BackgroundImage = My.Resources.OFF

        'Personalizamos nuestro formulario
        With Me
            .Font = Fuente_Personal
            .BackColor = Color.AliceBlue
            .Text = "COMUNICACIÓN SERIE SIN PROTOCOLO NX1P2"
        End With

        'Insertamos texto y color en los objetos
        ButtonConectar.Text = "CONECTAR"
        ButtonConectar.BackColor = Color.Green
        ButtonDesconectar.Text = "DESCONECTAR"
        ButtonDesconectar.BackColor = Color.Red

    End Sub

End Class