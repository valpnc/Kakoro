using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstructurasControl : MonoBehaviour
{
    public int vida = 30;

    // Start is called before the first frame update
    void Start()
    {
        /*if (vida > 50)
        {
            Debug.Log("ESTAS MUY SALUDABLE");
        }
        else if (vida >25)
        {
            Debug.Log("ECHALE GANAS MIJO");
        }
        else
        {
            Debug.Log("PRECAUCION MORIRAS");
        }*/

    }

    // Update is called once per frame
    void Update()
    {
        if (vida > 50)
        {
            Debug.Log("ESTAS MUY SALUDABLE");
        }
        else if (vida > 25)
        {
            Debug.Log("ECHALE GANAS MIJO");
        }
        else
        {
            Debug.Log("PRECAUCION MORIRAS");
        }
    }
}
