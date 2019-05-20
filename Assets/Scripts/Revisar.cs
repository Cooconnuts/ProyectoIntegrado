﻿/* ---------- DUDAS ----------
 * 
 * ¿Para la interfaz hay que tener algo en cuenta? ¿Se puede hacer plana para ponerla en una pared o algo o tiene que ser en 3D para VR sí o sí?
 * 
 * ¿En el simulador deberia haber colisiones con los objetos? Lo traspaso todo 
 * 
 * 
 * ¿Tengo que bajar la resolución de todos los archivos de las texturas para bajarle el peso? 
 * (algunas texturas están en 4K) 
 * ¿O sólo bajo la resolución de los archivos que más pesen? 
 * Son muchas texturas como para ir 1 a 1, si no hay otra manera pues se hace.
 * 
 * 
 */

/* ---------- PROBLEMAS ----------
 * 
 * He puesto que todos los prefabs de las paredes, suelos y techos generen sombras a ambos lados y algunas luces siguen traspasándolos
 * 
 * No puedo coger los objetos, como si no se detectaran los controladores, los objetos no reaccionan a estos
 * 
 * 
 * De repente Unity compila constantemente los scripts aun que no haya hecho ningún cambio en ellos, aun que sea modificando cualquier cosa de la escena o editor 
 *  se pone a compilar los scripts constantemente
 *  
 * A continuación
 * 
 * Al instalar SteamVR Plugin Unity instala constantemente el OpenVR, aun que lo desinstale lo vuelve a instalar inmediatamente. Lo único que soluciona esto es borrar
 *  la carpeta de SteamVR
 * 
 * Despues de cada mínimo cambio Unity compila los scripts e instala de nuevo el OpenVR
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