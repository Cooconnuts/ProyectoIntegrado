/*  ---------- TAREAS ----------
 * 
 * EN CASA
 * 
 * Programar el cuadro de luces (hacer que funcione al activarlo y desactivarlo, no solo al activarlo la primera vez)
 * 
 * Acabar la interfaz y hacerla funcional (testing)
 * 
 * Conteo de luces
 * 
 * Añadir movil para buscar, ponerlo en el baño de abajo
 * https://www.turbosquid.com/3d-models/3ds-max-6-apple-iphone/854423
 * 
 * 
 * 
 * EN LA ESCAV
 * 
 * Reajustar la escala de la casa
 * 
 * Ajustar colores e interacciones de los botones del menu principal
 * 
 */



/* ---------- DUDAS ----------
 * 
 * Como hacer el conteo las luces que se han encendido (*cuál*opcional y cuantas veces) y el tiempo que están encendidas.
 * 
 * Como hacer para que el script del Interruptor esté en distintos estados dependiendo de la escena
 * Menú principal: no hay cuadro de luces, por lo que o quitar el booleano o hacer que empiece en true 
 * Nivel bajo: que el booleano empiece en true por que en este nivel no hay que activarlo
 * Nivel alto: tal como está
 * 
 * Como hacer que los botones de la interfaz reaccionen al puntero
 *
 * 
 * Cómo incorporo lo del panel que sale al acabar con la info de las luces?
 * 
 * 
 * ¿Cómo hacer para entregarlo? Aumento la resolución de las luces y sombras para hacer el ejecutable?
 * 
 * Para abrir las puertas, ¿puedo limitar el ángulo en el que se abre la puerta como máximo?
 * https://www.moddb.com/tutorials/how-to-open-a-vr-door-in-unity-and-steamvr
 * 
 */

/* ---------- PROBLEMAS ----------
 * 
 * Al descargar del github el proyecto se me pierden los materiales de las lámparas cuando están apagadas habiéndolas puesto bien antes
 * 
 * Cuando utilizo las gafas en la escuela, se me cambia la altura del avatar y aun que lo baje se me queda a la misma altura, ¿en algún sitio se puede cambiar la altura?
 * 
 * 
 * Cuando cargo una escena desde el menu principal con las gafas no me deja moverme 
 * Los botones no cambian de color cuando el puntero los apunta, sí carga las escenas pero no se resalta de ninguna manera para dar a entender al jugador que es un boton.
 * 
 * Algo ha cambiado y el cuadro de luces ya no funciona como debería, ahora las luces se encienden independientemente de si el cuadro de luces está activo o no
 * 
 * 
 * Error Objetos con UVs sobrepuestas
 * https://docs.unity3d.com/Manual/ProgressiveLightmapper-UVOverlap.html
 * No me aparece el menú de Objects Maps en Lighting para corregir esas UVs
 * 
 * 
 */

/* ---------- OTRAS DUDAS ----------
 * 
 * ¿Qué hago con el exterior? ¿Creo una pequeña zona residencial para que no se quede la casa en el vacío?
 * ¿O qué otra cosa podría hacer? (sin que resulte en añadir muchos más elementos para no cargar la escena)
 * 
 * 
 * ¿Tengo que bajar la resolución de todos los archivos de las texturas para bajarle el peso? 
 * (algunas texturas están en 4K) 
 * ¿O sólo bajo la resolución de los archivos que más pesen? 
 * Son muchas texturas como para ir 1 a 1, si no hay otra manera pues se hace.
 * 
 * 
 */

/* ---------- SPRINTS ----------
 * 
 * SPRINT 1: 17 ABRIL AL 01 MAYO 
 * Prerrequisitos: gráficos y GDD (Objetivo y mecánicas)
 * Tareas: tareas de programación básicas (mecánicas) y diseño de niveles
 * 
 * SPRINT 2: 02 MAYO AL 15 MAYO
 * Prerrequisitos: Diseño de niveles terminado
 * Tareas: Programación avanzada e iluminación
 * 
 * SPRINT 3: 16 MAYO AL 29 MAYO
 * Prerrequisitos: Mecánicas terminadas
 * Tareas: Testeo y optimizacion y sonido
 * 
 * 
 */