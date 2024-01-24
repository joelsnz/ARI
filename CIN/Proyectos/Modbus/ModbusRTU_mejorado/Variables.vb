Module Variables
    Public Fuente_Personal As Font
    'Trama petición del maestro ModBUS
    Public Trama_Saliente As Byte()
    'Trama respuesta de un esclavo ModBUS
    Public Trama_Entrante As Byte()
    'Frecuencia hexadecimal del esclavo MX2 extraída de una trama leída
    Public Frecuencia As Byte()

    Public temperatura As Double

    Public motor_activo As Boolean
End Module
