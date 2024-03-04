- En nuestra periferia descentralizada hay dos módulos DQ 8x24VDC/0.5A HF, que admiten 8 salidas digitales.

# Cableado

- En el manual de usuario podemos encontrar el siguiente esquema.
![[cableado_salidas.png]]

- Tendremos que alimentar a 24Vdc los bornes P1(+) y P2(-). **Se tienen que alimentar todos los módulos por separado**.
- El módulo tiene 8 bornes de salida y 8 bornes de 0Vdc, uno para cada salida.
- Conectaremos un piloto a la salida 0, por lo que lo conectaremos entre los bornes 1(+) y 9(-).
- Si desde el programa accedemos "Propiedades -> Direcciones E/S", podremos ver las direcciones de entrada del módulo.
![[direcciones_salida.png]]
- Para acceder al piloto, simplemente tendremos que acceder a su dirección de salida como haríamos con las entradas físicas del PLC.