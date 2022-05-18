using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats
{
    public int userLevel;
    public string userName;
    public int manaLevel;

    public static int goldTotal;

    public PlayerStats()
    {
        Debug.Log("PlayerStats instance members initialized. These are the non-unique instances");
    }

    static PlayerStats()
    {
        goldTotal = 1000;
        Debug.Log("Static members iniitalized here. These are the unique static members that hold data.");
    }
}

public class PlayerCharacter: MonoBehaviour
{
    private void Start()
    {
        PlayerStats p1 = new PlayerStats();
        PlayerStats p2 = new PlayerStats();
        PlayerStats p3 = new PlayerStats();
    }
}
