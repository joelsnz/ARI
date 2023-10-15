Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Cuando hacemos click en el botón cambia el mensaje de la etiqueta
        Label1.Text = "Hola Mundo"
        Label1.BackColor = Color.Aqua
        Label1.ForeColor = Color.AntiqueWhite
        Label1.AutoSize = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Definimos tipo de letra de los objetos del formulario:
        Fuente_Personal = New Font("Verdana", 15, FontStyle.Underline, GraphicsUnit.Pixel)
        Label1.Font = Fuente_Personal
        Button1.Font = Fuente_Personal
    End Sub
End Class