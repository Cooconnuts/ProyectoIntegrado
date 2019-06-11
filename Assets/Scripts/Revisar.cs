/*  ---------- TAREAS ----------
 * 
 * Testear en VR si todas las luces encienden como tienen que hacerlo (que el material se cambie)
 * 
 * Testear en VR si todos los interruptores y la linterna suenan al pulsarse
 * 
 * Testear en Vr si se puede subir la escalera y si hay que aumentar el Step Up Offset en VRTK_Scripts > BodyPhysics
 * 
 * 
 * Programar el cuadro de luces (hacer que funcione al activarlo y desactivarlo, no solo al activarlo la primera vez)
 * 
 * Hacer las puertas funcionales
 * 
 * Acabar la interfaz y hacerla funcional
 * 
 * 
 * Conteo de luces
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
 * ¿Hay alguna manera de meter imágenes y que queden con mejor calidad? Para la interfaz
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
 * He puesto que todos los prefabs de las paredes, suelos y techos generen sombras a ambos lados y algunas luces siguen traspasándolos
 * 
 * Cuando utilizo las gafas en la escuela, se me cambia la altura del avatar y aun que lo baje se me queda a la misma altura, ¿en algún sitio se puede cambiar la altura?
 * 
 * Pasa algo con las escaleras y parece como que impulsan hacia arriba cuando empiezas a subirlas
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