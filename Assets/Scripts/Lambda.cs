using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lambda : MonoBehaviour
{
    private Action GetName;
    
    void Start()
    {
        GetName = () => print("Name: " + gameObject.name);
        GetName();
    }

    void Update()
    {
        
    }
}
