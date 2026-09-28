using UnityEngine;

public class RandomColor : MonoBehaviour
{
    // Ejercicio 1: Crear un script asociado a un objeto que cada 120 frames cambie de color de manera aleatoria.
    public int framesToWait = 120; // public: se ve desde el inspector de unity
    private float[] colorsVector = new float[3];
    private int frameCounter = 0; // contador para saber cuántos frames han pasado
    private Renderer objectRenderer; // variable para guardar el componente Renderer del objeto

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objectRenderer = GetComponent<Renderer>(); // obtenemos el componente Renderer del objeto al que está asociado este script
        for (int i = 0; i < colorsVector.Length; i++)
        {
            colorsVector[i] = Random.Range(0f, 1f); // generamos un valor aleatorio entre 0 y 1 para cada componente de color
        }

        ApplyColorToObjet(); // Aplicamos un color al objeto
    }

    // Update is called once per frame
    void Update()
    {
        frameCounter++; //Aumentamos el contador de frames

        if (frameCounter >= framesToWait )
        {
            frameCounter = 0; //Reiniciamos
            int randomPosition = Random.Range(0, 3); // No coge el 3, va desde 0 hasta 2
            colorsVector[randomPosition] = Random.Range(0f, 1f); //Cambiamos el valor de una posicion aleatoria del vector
            ApplyColorToObjet(); //Asignamos el color al objeto
        }
    }

    // Funcion auxiliar para no reescribir codigo, crea un color nuevo con los valores del vector y los aplica
    void ApplyColorToObjet()
    {
        Color randomColor = new Color(colorsVector[0], colorsVector[1], colorsVector[2]);
        objectRenderer.material.color = randomColor; 
    }
}
