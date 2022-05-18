using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The difficulty levels
enum Difficulty
{
    EasyPeasy = 2,
    LemonSqueezy = 4,
    OhMyGodSendHelp = 8
}

public class Enum : MonoBehaviour
{
    //Sets the difficulty in the inspector
    [SerializeField] private Difficulty difficultyLevel;

    private void Start()
    {
        //If difficulty is set to a certain level print out the appropriate response.
        switch (difficultyLevel)
        {
            case Difficulty.EasyPeasy:
                print("What are you a baby?");
                break;
            
            case Difficulty.LemonSqueezy:
                print("Now you're feeling the pressure.");
                break;
            
            case Difficulty.OhMyGodSendHelp:
                print("No help is coming. You're all alone in this torturous nightmare. Difficulty is " + difficultyLevel);
                print("The score multiplier is: " + ((int)difficultyLevel));
                break;
        }
    }
}
