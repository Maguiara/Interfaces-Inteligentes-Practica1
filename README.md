# Practica 1 Interfaces Inteligentes

## Ejercicios Scrips: Movimientos

### Ejercicio 1

**Enunciado:** Crea un script asociado a un objeto en la escena que inicialice un vector de 3 posiciones con valores entre 0.0 y 1.0, para tomarlo como un vector de color (Color). Cada 120 frames se debe cambiar el valor de una posición aleatoria y asignar el nuevo color al objeto. Parametrizar la cantidad de frames de espera para poderlo cambiar desde el inspector.

**Archivo:** RandomColor.cs

**Conceptos clave aplicados:**

- Captura de componentes con `GetComponent<Renderer>()`.
- Diferencia de ejecución entre `Start()` y `Update()`.
- Parametrización de variables públicas (`framesToWait`) desde el Inspector.

**Gif de demostracion:**
![Desmostración de cambio de color](gifs1/Ejercicio1.gif)

### Ejercicio 2

**Enunciado:** Crea un script asociado a la esfera con dos variables Vector3 públicas. Dale valor a cada componente de los vectores desde el inspector. Muestra en la consola:

- La magnitud de cada uno de ellos.
- El ángulo que forman
- La distancia entre ambos.
- Un mensaje indicando qué vector está a una altura mayor.

Muestra en el inspector cada uno de esos valores.

**Archivo:** AnalizadorVector3.cs

**Conceptos clave aplicados:**

- Uso de la estructura `Vector3` + su constructor
- Utilidades matemáticas de la API de Unity: `Vector3.Distance()` y `Vector3.Angle()`.
- Acceso a propiedades internas de un vector: `.magnitude` y ejes individuales (como `.y`).
- Uso de `Debug.Log()` para mostrar informacion en la consola de Unity

**Gif de demostracion:**
![Desmostración analizador vectores](gifs1/Ejercicio2.gif)

### Ejercicio 3

**Enunciado:** Muestra en pantalla el vector con la posición de la esfera.

**Archivo:** PosicionVectorEsfera.cs

**Conceptos clave aplicados:**

- Importación de módulos específicos de Unity `using TMPpro`
- Búsqueda dinámica de GameObjects en la jerarquía mediante `GameObject.Find("Nombre")`.
- Acceso y manipulación de componentes de interfaz con `GetComponent<TextMeshProUGUI>()`.

**Gif de demostracion:**
![Desmostración de mostrar vector en pantalla](gifs1/Ejercicio3.gif)

### Ejercicio 4

**Enunciado:** Crea un script para la esfera que muestre en consola la distancia a la que están el cubo y el cilindro.

**Archivo:** DistanciaCilindroCubo.cs

**Conceptos clave aplicados:**

- Búsqueda de objetos en la jerarquía mediante `GameObject.FindWithTag()`.
- Extracción de componentes y coordenadas mediante `GetComponent<Transform>().position`.
- Aplicación de fórmulas espaciales usando el método `Vector3.Distance()`.

**Gif de demostracion:**
![Desmostración de mostrar vector en pantalla](gifs1/Ejercicio4.gif)
