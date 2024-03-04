- En nuestra periferia descentralizada hay dos módulos DI 8x24VDC HF, que admiten 8 entradas digitales.

# Cableado

- En el manual de usuario podemos encontrar el siguiente esquema.
![[cableado_entradas.png]]

- Tendremos que alimentar a 24Vdc los bornes P1(+) y P2(-). **Se tienen que alimentar todos los módulos por separado**.
- El módulo tiene 8 bornes de entrada y 8 bornes de 24Vdc, uno para cada sensor.
- Conectaremos un interruptor a la entrada 0, por lo que lo conectaremos entre los bornes 1 y 9.
- Para comprobar que está conectado correctamente, si lo activamos debería encenderse el piloto .0.
- Si desde el programa accedemos "Propiedades -> Direcciones E/S", podremos ver las direcciones de entrada del módulo.
![[direcciones_entrada.png]]
- Para acceder al interruptor, simplemente tendremos que acceder a su dirección de entrada como haríamos con las entradas físicas del PLC.