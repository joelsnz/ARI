---
type: Literature Note
tags:
  - Omron
status: doing
---
# Configuración EtherNetIP

# Configuración de comunicaciones

|  | NX1P2 | FQ2 |
| ---- | ---- | ---- |
| Configuración IP | - | Fija |
| Dirección IP | 192.168.250.1 | 192.168.250.2 |
| Máscara de subred | 255.255.255.0 | 255.255.255.0 |
| Puerta de enlace | - | 10.5.5.1 (Predeterminada) |
| KeepAlive | Usar (Predeterminado) | - |
| Tipo de comunicación | - | EtherNet/IP |
| Tamaño datos de salida | - | 32 bytes (Predeterminado) |

# Tipos de datos

## U_EIPFlag

Tipo de dato usado para acceder a las señales de control y estado.

| Nombre | Tipo |
| ---- | ---- |
| U_EIPFlag | UNION |
| F | BOOL[32] |
| W | DWORD |



# References
1. Página 11 manual