using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumUno : MonoBehaviour
{
    int num1=0;
    void Start()
    {
        num1 += 2;
        Debug.Log(num1);

        num1 *= num1;
        Debug.Log(num1);
    }

    void Update()
    {
        
    }
}
