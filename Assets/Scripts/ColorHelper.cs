using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ColorHelper
{
    public static void ColorChanger(GameObject obj, Color colorChoice)
    {
        obj.GetComponent<MeshRenderer>().material.SetColor("_Color", colorChoice);
    }
    
    public static void RandomColorChanger(GameObject obj)
    {
        float r = Random.Range(0, 1.0f);
        float g = Random.Range(0, 1.0f);
        float b = Random.Range(0, 1.0f);
        
        Color randomColor = new Color(r, g, b);
        
        obj.GetComponent<MeshRenderer>().material.SetColor("_Color", randomColor);
    }
}
