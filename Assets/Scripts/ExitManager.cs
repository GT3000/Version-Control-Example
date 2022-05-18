using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //If player hits
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //If screen is full screen then filp to false else quit out of the application
            if (Screen.fullScreen)
            { 
                Screen.fullScreen = !Screen.fullScreen;
            }
            else
            {
                Application.Quit();
            }
        }
    }
}
