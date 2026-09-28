using UnityEngine;

public class DistanciaCilindroCubo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject cubo = GameObject.FindWithTag("Cube");
        GameObject cilindro = GameObject.FindWithTag("Cilinder");

        Vector3 posicionEsfera = transform.position;
        Vector3 posicionCubo = cubo.transform.position;
        Vector3 posicionCilindro = cilindro.transform.position;

        float distanciaEsferaCubo = Vector3.Distance(posicionEsfera, posicionCubo);
        float distanciaEsferaCilindro = Vector3.Distance(posicionEsfera, posicionCilindro);

        Debug.Log("Distancia entre esfera y cubo: " + distanciaEsferaCubo);
        Debug.Log("Distancia entre esfera y cilindro: " + distanciaEsferaCilindro);
    }

}
