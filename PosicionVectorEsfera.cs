/*
 * Author: Marco Aguiar Álvarez
 * Date: September 28, 2026
 * Description: Unity C# script attached to a sphere that retrieves its position 
 *              using GetComponent<Transform>(). It dynamically finds a 
 *              TextMeshPro UI element in the scene and safely displays the 
 *              position in real-time, preventing NullReferenceExceptions.
 */

using TMPro;
using UnityEngine;

public class PosicionVectorEsfera : MonoBehaviour
{
    private Vector3 currentPosition;
    private TextMeshProUGUI textDisplay;

    void Start()
    { 
      // buscamos el objeto canvas para escribir en el
      GameObject textObject = GameObject.Find("Text (TMP)"); 
      textDisplay = textObject.GetComponent<TextMeshProUGUI>();
        
    }

    void Update()
    {
      // actualizamos el texto de la pantalla cada frame
      currentPosition = GetComponent<Transform>().position;
      textDisplay.text = currentPosition.ToString();
    }
}