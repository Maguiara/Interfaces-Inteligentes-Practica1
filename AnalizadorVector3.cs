using UnityEngine;

public class AnalizadorVector3 : MonoBehaviour
{
    public Vector3 miVector1 = new Vector3(0.0f, 1.0f, 0.0f);
    public Vector3 miVector2 = new Vector3(1.0f, 0.0f, 1.0f);

    public float magnitude1;
    public float magnitude2;
    public float angleBetween;
    public float distanceBetween;
    public string higherVectorMessage;
   
    void Start()
    {
        magnitude1 = miVector1.magnitude;
        magnitude2 = miVector2.magnitude;

        angleBetween = Vector3.Angle(miVector1, miVector2);

        distanceBetween = Vector3.Distance(miVector1, miVector2);

        if (miVector1.y > miVector2.y)
        {
            higherVectorMessage = "Vector 1 más alto que vector 2";
        } else if (miVector2.y > miVector1.y)
        {
            higherVectorMessage = "Vector 2 más alto que vector 1";
        } else
        {
            higherVectorMessage = "Están a la misma altura";
        }

        Debug.Log("Magnitug vector 1: " + magnitude1);
        Debug.Log("Magnitug vector 2: " + magnitude2);
        Debug.Log("Angulo entre ellos: " + angleBetween);
        Debug.Log("Distancia entre ellos: " + distanceBetween);
        Debug.Log("Cúal es más alto: " + higherVectorMessage);
    }
    
}
