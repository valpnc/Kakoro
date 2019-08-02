using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    string nombre = "Minombre";
    int edad = 26;
    float temperatura = 37.7f;
    // Start is called before the first frame update
    void Start()
    {
        
            
    }

    // Update is called once per frame
    void Update()
    {
        imprimirNombre();
        imprimirEdad();
    }

void imprimirNombre()
{
    Debug.Log("MIAU");
}
    void imprimirEdad()
    {
        Debug.Log(edad);
    }

}