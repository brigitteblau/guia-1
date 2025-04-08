using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParImpar : MonoBehaviour
{
    public int num1;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 % 2 != 0){
            Debug.Log("el numero ingrasado es impar");
        }
        else {
            Debug.Log("el numero  ingresado es par");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
