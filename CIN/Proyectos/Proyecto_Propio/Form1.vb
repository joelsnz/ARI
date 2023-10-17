Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim bg As Boolean
    'Al pulsar el botón Close, cerrar la ventana
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    'Al pulsar el botón Beep, reproducir el sonido "beep"
    Private Sub ButtonBeep_Click(sender As Object, e As EventArgs) Handles ButtonBeep.Click
        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Beep)
    End Sub

    'Al pulsar el botón Fondo, cambiar el fondo de la ventana
    Private Sub ButtonFondo_Click(sender As Object, e As EventArgs) Handles ButtonFondo.Click
        If bg Then
            bg = False
            Me.BackColor = Color.White
        Else
            bg = True
            Me.BackColor = Color.Black
        End If
    End Sub

    Private Sub ComboBoxColors_Click(sender As Object, e As EventArgs) Handles ComboBoxColors.SelectedValueChanged
        Select Case ComboBoxColors.SelectedIndex
            Case 0
                Label1.BackColor = Color.Red
            Case 1
                Label1.BackColor = Color.Green
            Case 2
                Label1.BackColor = Color.Blue
        End Select
    End Sub
End Class
