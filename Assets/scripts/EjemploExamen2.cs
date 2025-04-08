using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploExamen2 : MonoBehaviour
{

    public string nombreAlumno;
    public int añoAlumno;
    public string espAlumno;
    // Start is called before the first frame update
    void Start()
    {
        if ( nombreAlumno == null || añoAlumno < 6 && añoAlumno > 0)
        {
            Debug.Log("error, ingresa datos validos");
            return;
        }
        else 
        {
            Debug.Log("mmm");
        }
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}
