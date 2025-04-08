using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploExamen : MonoBehaviour
{

    public float num1;
    public string letra ;
    float montoMinimo = 1000;
    // Start is called before the first frame update
    void Start()
    {

        if (num1 < montoMinimo)
        {
            Debug.Log("el monto minimo es 1000");
            return;
        }
            if (letra == "D")
            {
                Debug.Log(num1 + "  pesos es igual a " + (num1 / 1300) + " dolares");
            }
            else if (letra == "E")
            {
                Debug.Log(num1 +  "  pesos es igual a" + (num1 / 1500) + " euros");
            }
            else if (letra == "R")
            {
                Debug.Log(num1 + "pesos es igual a" + (num1 / 500) + "reales");
            }
            else
            {
                Debug.Log("ingresa una letra apropiada D, E o R");
           
            }
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
