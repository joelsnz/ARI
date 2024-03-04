- En nuestra periferia tenemos un módulo CM 4xIO-Link ST, que admite 4 dispositivos IO-Link.
- Conectaremos un sensor capacitivo IFM KI6000 en el primer puerto y una baliza BALLUFF BNI007T en el segundo puerto.

# Cableado

- En el manual del módulo podremos encontrar el siguiente esquema de cableado.
![[cableado_iolink.png]]

- Tendremos que alimentar a 24Vdc los bornes P1(+) y P2(-). **Se tienen que alimentar todos los módulos por separado**.
- Los bornes 9-12 son 24Vdc para cada dispositivo, los 13-15 son 0Vdc para cada dispositivo y los 1-4 son para la señal de cada dispositivo. Los bornes 5-8 no están conectados.
- Ambos detectores tienen el mismo cableado: Marrón(+), blanco(S) y azul(-). En la siguiente imagen podemos observar los colores de cada cable.
![[colores_cable.png]]
- Conectaremos el sensor capacitivo al primer canal (bornes 1(S), 9(+) y 13(-)) y la baliza al segundo canal (bornes 2(S), 10(+), 14(-)).
- Desde el programa, en las propiedades del módulo IO-Link accederemos a "CM 4xIO-Link -> Parámetros" y activaremos el diagnóstico para los dos puertos que vamos a usar. De este modo, en el módulo físico activaremos un piloto que nos indicará el estado de cada dispositivo.
- En este momento, si cargamos hardware y software, los pilotos C1 y C2 deberían empezar a parpadear, indicando que hay dispositivos IO-Link conectados pero no configurados.
- Ahora tendremos que configurar los dispositivos desde el "Device Tool", al que accederemos haciendo clic derecho en el módulo IO-Link y pulsando en "Iniciar Device Tool".
- Empezaremos importando los archivos IODD de cada dispositivo, que podemos descargar de la página del fabricante.
- Entraremos a "Herramientas -> Importar IODD". En la ventana emergente, pulsaremos "Examinar" y buscaremos los archivos IODD. **Tenemos que importar el archivo .zip**.
![[importar_iodd.png]]
- Pulsaremos "Mostrar" en cada dispositivo para importarlos y cerraremos la ventana. En el catálogo ya aparecerán nuestros dispositivos.
- Buscaremos los dispositivos en el catálogo y pulsaremos dos veces para agregarlos en el puerto. En el apartado "Información de Puertos" podremos ver que se hayan agregado correctamente.
![[informacion_puertos.png]]
- En el árbol del proyecto, podremos seleccionar cada dispositivo para entrar a su ventana. En "Identificación" podremos ver los datos que identifican el dispositivo. En "Parámetros" podremos ver y escribir parámetros del dispositivo. En "Observación" podremos ver las PDO del dispositivo (Tenemos que estar en conexión online). En "Diagnóstico" podremos ver otros datos del sensor. En "Conexión" podremos ver información sobre la conexión del dispositivo.
- Si volvemos a seleccionar el módulo en el árbol de proyecto y accedemos a "Direcciones" y marcamos "Mostrar direcciones del PLC" y "Todos los puertos" podremos ver las direcciones que asigna el módulo a cada puerto. Podemos cambiar estas direcciones si lo deseamos.
![[direcciones_iolink.png]]
- Pulsaremos "Crear archivo fuente para el tipo de datos PLC". Se generará un archivo que nos guardaremos. Este archivo guardará un tipo de datos que luego usaremos.
- Cerraremos el asistente. Nos preguntará si queremos guardar. Diremos que sí.
- Ahora, en el árbol de proyecto pulsaremos en "Fuentes externas -> Agregar nuevo archivo externo". Seleccionaremos el archivo que hemos generado anteriormente.
- Haremos clic derecho en el archivo ya agregado y pulsaremos en "Generar bloques a partir de fuente".
- Habremos generado un tipo de datos correspondiente a cada sensor, que podemos ver en "Tipos de datos PLC". Si accedemos al tipo de dato, podemos ver las señales de cada sensor y cambiar el nombre de cada señal.
- Ahora, podemos asignar este tipo de datos a variables, usando las direcciones que configuramos en el Device Tool. La dirección que pondremos será en bits, pero podemos crear variables auxiliar con otro tipo de datos para más comodidad.
![[variables_plc.png]]
- Según el manual del sensor capacitivo, esta es la trama que se está enviando.
![[trama_sensor.png]]
- BDC1 es el bit que se activa cuando el sensor detecta pieza, y PDV1 es una medida de 15 bits (de 0 a 10000) de la distancia del objeto al sensor.
- Para leer correctamente la distancia, tendremos que eliminar BDC1 de la trama, realizando un desplazamiento hacia la derecha.
![[shift_pdv1.png]]
- Según el manual de la baliza, esta es la trama que podemos escribir para el modo de funcionamiento "Segment Mode", que es el modo por defecto.
![[trama_baliza.png]]
- Esta trama es común para varios modelos de baliza, pero nuestro modelo no tiene buzzer. Por tanto, el bit 7 (Buzzer state) no funcionará.
- Con los bits 0-2 podemos seleccionar el color, según estas combinaciones.
![[combinaciones_colores.png]]
- Con el bit 3 activaremos el parpadeo, cuya frecuencia está definida en los parámetros de la baliza.