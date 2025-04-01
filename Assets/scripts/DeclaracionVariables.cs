using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionVariables : MonoBehaviour
{
    string nombre = "brigu";
    int cantidadAlumni = 1;
    float kilosVendidos = 1.6f;
    bool tieneComision = true; 

    void Start()
    {
        Debug.Log(nombre);
        Debug.Log(cantidadAlumni);
        Debug.Log(kilosVendidos);
        Debug.Log(tieneComision);
    }


    void Update()
    {
        
    }
}
