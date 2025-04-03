using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    public string  nombreUsuario;
public int edadUsuario;
public float alturaUsuario;
public bool esDonante;


    void Start()
    {
        Debug.Log("mi nombre es " + nombreUsuario + " mido"
            + alturaUsuario);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
