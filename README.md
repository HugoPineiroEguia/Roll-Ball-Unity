# Roll-Ball-Unity
Proyecto de Unity

* CAPSULA, NORIA y BARROTES

Tanto el script de Capsula, Noria y Barrotes lo único que hacen es
cambiar  la rotacion del objeto al que se le es asignado.
El script Capsula hace que el objeto que implemente su codigo rote en todos sus
ejes, a diferencia de los otros dos, que solo rotan en el eje Y.
Noria y Barrotes osn Scripts que implementaran plataformas que giran para hacer accesibles algunas
zonas del nivel.

+ CAMERA SCRIPT

En este script se establece que la camara seguirá al objeto que se le sea asignado,
en este caso para que acompañe al jugador.

+ PLATAFORMA

Lo que hace este script es mover de un lado a otro un objeto,
se establecen unos parametros de tipo GameObject que serán objetos 
vacíos que se usarán como referencia para saber hacia donde
tiene que dirigirse la plataforma a la que se le asigne el script.

+ PLAYERMOVE

Aquí seajustan los movimientos del jugador, con qué botones se moverá, la velocidad
y las direcciones.
Además se establece un trigger con el que interactuará con objetos que tengan
las etiquetas "capsula" y "respawn".
Cuando toque un objeto de etiqueta capsula, el objeto con la etiqueta desaparecerá y
sumara un valor de 1 a un contador de capsulas, cuando este contador supera unos valores
concretos, desparecerán unos objetos (pasados por parametros) que funcionan como puertas que impiden
el acceso a algunas zonas.
Cuando el objeto colisiona con un objeto de etiqueta "respawn", el jugador reestablecerá su posicion
a la posicion de inicio, done empieza el juego.








