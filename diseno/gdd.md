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

El unico personaje que se podra ver sera el enemigo, sera un robot-mountruo con un disfraz de bufon.

# Artes

El juego sera 2d y con estetica pixel art, ambientado en un circo, y el arte estara hecho por mi, los asset necesarios son:

1. 5 fondos uno para cada minijuego y 1 para cuando te des la vuelta.
2. La escopeta
3. 2 tipos de latas diferentes una alta y delgada y otra pequeña y ancha, tendran 2 recolores cada una.
4. Un dardo
5. Un globo pero que tenda 5 recolores: rojo,verde,naranja,amarillo y rosa.
6. Una animacion de una pelota de baloncesto en la que se rote hacia delante.
7. Un vaso
8. Una bola
9. El mountruo
10. El corazon de la intefaz
11. Puntero raton

# Sonidos y musica

El juego no tendra musica como tal, tendra un sonido anbiente que sera de viento y de vez en cuando sonara ruidos como una rama rompiendose, un grillo y sonidos de animales, ademas de esto el enemigo principal hara un sonido cada vez mas fuerte, y cuando interactues con los minijuegos tambien haran sonidos:

1. La escopeta tendra un sonido de disparo y de recarga y las latas a las que disparas cuando sean impactadas haran un sonido.
2. Los dardos cuando sean lanzados haran un sonido y cuando impactan con se quedan enganchados tambien tendran un sonido, ademas lo globos tendran su propio sonido.
3. La pelota tambien tendra un sonido al ser lanzada y cuando se meta en la canasta tendra otro sonido.
4. Los vasos haran ruido cuando se muevan y cuando haciertes la posicion de la bola tendras un sonido de victorio sin embargo si fallas tendras un sonido de derrota.

# Plataformas y tecnologias

El juego sera desarollado en unity, los assets seran creados en Aseprite, el juego estara disponible para pc,webgl y movil en la tienda itchio, aunque es probable que por bugs inesperados no se pueda lanzar en webgl o en movil.

# Estrategia de marketing

La principal promocion la hare en mis redes sociales del desarollo del proyecto, la red principal sera youtube ([ameneduwudev](https://www.youtube.com/@AMENEDUWUDEV/videos)) en la que subire short y tik tok ([ameneduwudev](https://www.tiktok.com/@ameneduwudev)) en el que los resubire, ademas, al final hare un video largo explicando las fases de el desarollo de un videojuego y ejemplificandolo con este poyecto.

El titulo del juego no lo tengo pensado aun, pero quiero que tenga las palabras circo, carnaval o terror.

# Lista de issues

- [ ] Artes
    - [ ] Fondo 1
    - [ ] Fondo 2
    - [ ] Fondo 3
    - [ ] Fondo 4
    - [ ] Fondo 5
    - [ ] Lata 1
    - [ ] Lata 2
    - [ ] Ecopeta
    - [ ] Dardo
    - [ ] Globos
    - [ ] Animacion balon
    - [ ] Bola
    - [ ] Vasos
    - [ ] Mountruo
    - [ ] Corazon
- [ ] Crear clase que modifica el puntero del raton
- [ ] Minijuego escopeta
    - [ ] Adaptar la clase del puntero para este minijuego
    - [ ] Programar segundo circulo
    - [ ] Hacer que el segundo circulo disminulla su tamaño
    - [ ] Hacer que cuando llegue a un punto el circulo deje de disminuir su tamaño
    - [ ] Hacer que pueda disparar a un punto aleatorio de la pantalla si tardas demasiado
    - [ ] Hacer que dispare a un punto aleatorio del circulo rojo
    - [ ] Programar la interaccion con las latas del disparo
- [ ] Minijuego dardos
    - [ ] Programar barra
    - [ ] Programar lanzamiento dardo
    - [ ] Programar interaccion con globo
- [ ] Minijuego baloncesto
    - [ ] Programar puntero
    - [ ] Programar lanzamiento
    - [ ] Programar interaccion canasta
- [ ] Minijuego vasos
    - [ ] Programar movimiento vaso
    - [ ] Programar Interaccion de puntero con vaso
- [ ] Mecanica mounstruo
    - [ ] Programar movimiento mountruo
    - [ ] Programar ataque mountruo
    - [ ] Programar interaccion con la linterna
