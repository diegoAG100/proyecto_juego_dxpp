# Introduccion y vision general

El objetivo de este proyecto es hacer un juego corto de terror que dure entre 5 y 8 minutos.

El juego consistira en 4 minijuegos que se tendran que realizar mientras te proteges de un mountro

# Descripcion del juego

El juego estara ambientando en un circo abandonado, su estetica sera en pixel art y el juego sera de terror y en primera persona.

La historia es inexistente.

Tu objetivo es escapar del circo, para poder escapara del circo tendras que enfrentarte a 4 minijuegos del circo mientras te defiendes de un mounstro que intentara cabar con el jugador,los 4 minijuegos seran:

1. Escopeta: En este minijuego tendras que tirar 10 latas con disparos, en este minijuego el raton (del ordenador) se convertira en un circulo rojo, en cuanto pulses en un punto de la pantalla aparecera un nuevo circulo negro
alrededor del circulo rojo que mientras mantengas presionado el circlo ira haciendose mas pequeño hasta que se ponga del tamaña del circulo rojo, si tardas mas de 2 segundos en disparar despues de que llegue al circulo rojo
disparara a un punto de la pantalla, el circulo negro es el area en el que puede ir el disparo, asi que si le das muy pronto no tendras la suficiente precision y fallaras, cuando disparas tendras que esperar 2 segundos
para poder dispara de nuevo, en este tiempo de paura se ejecutara un sonido de recagara y el sprite de la escopeta se pondra hacia abajo.

2. Dardos: Este minijuego tiene como objetivo explotar 10 globos con unos dardos que dispararas, para este minijuego se usara un circulo tojo como puntero, en el momento en el que presiones el raton aparecera una barra
encima del puntero, esta barra tendra una linea negra que avnazara hacia delante y hacia detras y cuando lo sueltes la linea se parara, en medio de la barra habra una zona de color rojo, tu objetivo es hacer que la linea
negra se pare en la zona roja para que el dardo valla hacia donde esta el puntero, en caso de que te no caiga en la zona roja el tiro caera en un sitio aleatorio de la pantalla.

3. Baloncesto: El minijuego consistira en meter 10 balones en la canasta en un circulo que se mueve constantemente de derecha a izquierda y en el momento en el que presionas el click se parar y empezara a subir y bajar y en cuanto vuelvas a pulsar el click
se parara y la pelota se lanzara hacia el punto, el objetivo es que se meta en una canasta que este en medio de la pantalla, a medidad que avance la pelota hacia delante se hara mas pequeño para hacer el 
efecto de ilusion de movimiento hacia delante, si entra dentro anotara un punto y tardara 2 segundos en poder lanzar de nuevo el balon.

4. Vasos: En este minijuego habra 3 vasos y te enseñara como una pelota roja se mete dentro de un vaso, y se empezaran a bajara de intercambiando posiciones de manera aleatoria unos con otros, el objetivo es ver 
el vaso en el que esta la pelota y tendras que encontrar la pelota 3 veces.

Se transicionara entre minijuegos cuando se consiga la puntuacion necesaria con un fundido a negro que se usara para cambira de fondo y assets.

Mientras haces estos minijuegos tendras que lidiar con un mounstruo que te atacara, estara detras de ti y siempre tendras un boton que te permitira darte la vuelta para alumbrar al enemigo y que desaparezca,
pero si alumbras sin que el mountro este perderas una vida de las 3 que tendras, solo perderas vidas al alumbrar erroneamente al mountruo, la vidas estaran en una esquina arriba a la izquierda y seran corazones,
en el momento en el que vuelvas al minijuego, si es el minijuego de los vasos se reiniciara el ultimo intento para que puedas volver a ver donde se mete la bola, el mountruo tendra 3 posiciones en la que
podra estara, cuando aparezca en la primera posicion hara un ruido que te indicara que se movio, los mismo pasara con la segunda y tercera pero haciendo un sonido mas alto, el mounstruo tendra un 50% de posivilidades
de moverse cada 30 segundos, a mediada que avances en los minijuegos se reducira el tiempo que tarda en moverse, cuando el jugador acabe el primer nivel cada 25 cuando acabes el segundo cada 20 y cuando acabes el tercero 
cada 15.

# Personajes

El unico personaje que se podra ver sera el enemigo, sera un robot-mountruo con un disfraz de bufon

# Artes

Los artes seran en 2d Pixel Art y seran creados por mi, la estetica tendras