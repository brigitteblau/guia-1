﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivisionProhibida : MonoBehaviour
{
    public int num1;
    public int num2;

    // Start is called before the first frame update
    void Start()
    {
        if (num2>0){
            Debug.Log( num1 + " / " + num2 + " = " + (num1 / num2));
        }
        else {
            Debug.Log("no se puede dividir por cero");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
