# Proyecto final - POO

## Avisos
* Añadidas sprites para uso de todos, en dado caso no quieran crear las propias. No es evaluado si las crean o no
* El manual técnico cambia entre los grupos de tres y cuatro personas, leer sección de [documentación](#documentación)
* Entrega primer avance - **sábado 13 de junio (sin ponderación)**
* Entrega final - **lunes 22 de junio**

## Sumario
[**Definición formal**](#definición-formal) <br>
&nbsp;&nbsp;&nbsp;&nbsp;[Menú principal](#menú-principal)<br>
&nbsp;&nbsp;&nbsp;&nbsp;[Jugabilidad](#jugabilidad)<br>
[**Requerimientos técnicos**](#requerimientos-técnicos)<br>
&nbsp;&nbsp;&nbsp;&nbsp;[Conexión a BD](#conexión-a-bd)<br>
&nbsp;&nbsp;&nbsp;&nbsp;[Paradigma orientado a objetos](#paradigma-orientado-a-objetos)<br>
&nbsp;&nbsp;&nbsp;&nbsp;[Implementación del MVC](#implementación-del-mvc)<br>
&nbsp;&nbsp;&nbsp;&nbsp;[Buenas prácticas](#buenas-prácticas)<br>
&nbsp;&nbsp;&nbsp;&nbsp;[Repositorio de GitHub](#repositorio-de-github)<br>
[**Requerimientos metodológicos**](#requerimientos-metodológicos)<br>
&nbsp;&nbsp;&nbsp;&nbsp;[Herramientas](#herramientas)<br>
&nbsp;&nbsp;&nbsp;&nbsp;[Problemas en flujo de trabajo](#problemas-en-flujo-de-trabajo)<br>
[**Documentación**](#documentación)<br>

## Definición formal
El proyecto final de la materia consistirá en la recreación de un juego clásico, **Arkanoid**. Para las personas que nunca lo han jugado o escuchado, acá un breve video.

[![Video](./Res/fake.png)](https://www.youtube.com/watch?v=3luUb7WEm7k&feature=emb_logo)

Se pretende que el juego sea totalmente funcional, y que conste de un único nivel a su creatividad. El programa como tal deberá contener los siguientes aspectos:

### Menú principal
![Menú](./Res/menu.png)
Deberá contener las siguientes opciones:

**Jugar**<br>
Deberá solicitar un nombre de jugador a través de una pequeña ventana o cambio de panel dentro de la principal. El nombre del jugador deberá ir a buscar su existencia en una **BD**, en caso no exista deberá agregarse.

![Jugador](./Res/usuario.png)

**Puntajes**<br>
Se mostrará una ventana externa conteniendo un **Top 10** mejores puntajes, mostrando el nombre del jugador/usuario y el puntaje obtenido.


![Top](./Res/Top.png)


### Jugabilidad
La jugabilidad es esencial, y deberá ser fluida. Queda a disposición de los programadores la manera de desplazar la nave, los 
[sprites](https://www.geekno.com/glosario/sprites)
a utilizar, la disposición de los cuadros en pantalla, la movilidad si será con las direccionales, el WASD o el mouse, entre otros aspectos.

Los aspectos que son **obligatorios** en la jugabilidad serán:

![Top](./Res/Game.png)

* Un sistema de vidas<br>
Que el jugador inicie con una cantidad **n** y  a medida falle disminuyan hasta perder el juego.
* Un sistema de puntaje<br>
No podrán haber una disposición de bloques donde **todos sean del mismo color**. Dependiendo del color del bloque así será el puntaje.
* Diferenciación de destrucción de bloques<br>
Como mínimo, deben haber dos niveles de destrucción. A lo que esto refiere es la cantidad de veces que la bola/proyectil debe tocar el bloque para destruirlo. Pueden ser que bloques requieran 1 toque, mientras que otros necesiten 3.

## Requerimientos técnicos
Para los requerimientos técnicos, deberán implementar los siguientes elementos:

### Conexión a BD
Su programa deberá conectarse a una BD que deberá ser **creada** por su grupo de trabajo, en PostgreSQL.

### Paradigma orientado a objetos
A lo largo de su código deberá verse reflejado el aprendizaje de la materia, aplicando definiciones de clase e instanciaciones de objetos, conceptos como polimorfismo, clases estáticas, etc.

### Implementación del MVC
La organización de su código fuente en su solución debe aplicar la normativa del Modelo Vista-Controlador.

### Buenas prácticas
Su código fuente debe ser legible y estar comentado en las partes importantes. El **80%** de su código debe estar en inglés (nombres de funciones, variables, clases, atributos, etc. Los comentarios no, esos pueden ir en español).

### Repositorio de GitHub
La utilización del sistema de control de versiones Git será obligatoria. Su repositorio será público y nombrado de la siguiente manera:

**NombreGrupo_Arkanoid**

No se permitirá que hayan commits de un único contribuyente, todos los miembros del grupo deberán aportar.


## Requerimientos metodológicos

### Herramientas
En cuanto a requerimientos metodológicos, es necesaria la buena comunicación y organización de su equipo de trabajo.

Se evaluará la utilización de herramientas de planificación, como tableros u organigramas. La herramientra propuesta para la materia es 
[Trello](https://trello.com/). 

![Tablero](./Res/t.png) 

Trello consiste en la implemetación de un tablero, que contiene listas, y a su vez estas listas contienen tarjetas con información escrita por los miembros.

Se pretende que las listas estén categorizadas, por importancia, tipo de actividad, etc.

![Tarjetas](./Res/card.png) 

Las tarjetas dentro de las listas corresponden a actividades, y pueden ser personalizadas, agregando fechas límites, marcarlas con etiquetas, agregar miembros a la actividad, checklists, etc.

Su grupo de trabajo deberá crear un tablero y enlazarlo a GitHub.


### Problemas en flujo de trabajo
Si se dan problemas en el flujo de trabajo, por ejemplo, si un miembro no aporta, si hay desacuerdos, etc. estos deberán ser reportados en una **lista** de Trello. Esta lista se llamará **Issues** y deberá existir una tarjeta dentro de ella por cada problema presentado. 

Estos problemas **no** deberán ser reportados a su instructor/catedrático. En la revisión de su proyecto, se visualizarán los problemas que existan y se evaluará la nota de los miembros que no participen según esta información. También se tomará en consideración si se reportan otros errores para no afectar la nota grupal.

No se permitirá un tablero que no tenga esta lista, y que en esta lista no existan tarjetas.

## Documentación

### Para todos los grupos
Deberán entregar un manual técnico acerca de lo implementado en su proyecto. Este documento contendrá los siguientes elementos:

* Aspectos generales<br>
Contendrá la información del objetivo del documento, una descripción general del proyecto y el Software utilizado para la creación del mismo.
* UML<br>
Un diagrama de clases basado en su proyecto.
* Diagrama Entidad Relación Extendido<br>
Referente a la base de datos
* Diagrama Relacional
* Conceptos técnicos y distintos tipos de error<br>
Lista de clases implementadas y breve descripción. **No se consideran los eventos y excepciones**.
* Nomenclaturas<br>
Abreviaciones de nombres de variables utilizadas y su referencia.
* Eventos y excepciones.
Lista de eventos y excepciones con breve descripción.

[**Ver ejemplo de Manual Técnico**](https://drive.google.com/open?id=1dNDDZ_IYtaahgp0GBz18LiPQwmzV5g4W)

### Adicional para los grupos de cuatro integrantes
En la sección de UML del Manual Técnico deberá agregar un UML de diagrama de casos de uso.
