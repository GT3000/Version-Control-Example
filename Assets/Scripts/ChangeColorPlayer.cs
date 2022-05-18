using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorPlayer : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ColorHelper.ColorChanger(gameObject, Color.blue);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ColorHelper.RandomColorChanger(gameObject);
        }
    }
}
