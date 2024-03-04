- Para agregar la periferia al proyecto, lo haremos desde el **catálogo de hardware**.
![[ruta_periferia.png]]

- En la lista de dispositivos aparecerá la periferia. Para asignarla al PLC, donde pone "no asignado" seleccionaremos nuestro PLC.
![[dispositivos.png]]

- Si es la primera vez que conectamos la periferia, tendremos que agregarle una IP y un nombre. Para hacerlo, primero la mostraremos desde "Online -> Dispositivos Accesibles".
- A continuación, nos conectaremos al dispositivo y desde el **árbol del proyecto** accederemos a "Dispositivos no agrupados -> \[nombre de la periferia] -> Online y diagnóstico".
- En esta pestaña, accederemos a "Funciones -> Asignar dirección IP" e introduciremos la IP que queremos que tenga el dispositivo.
![[asignar_ip.png]]
- Después accederemos a "Funciones -> Asignar nombre de dispositivo PROFINET" e introduciremos el nombre que queramos que tenga.
![[asignar_nombre.png]]

- Con un nombre y una IP establecidos, en las propiedades de la periferia descentralizada añadiremos la IP que le asignamos. Es importante que las direcciones del PLC y de la periferia estén en el mismo rango.