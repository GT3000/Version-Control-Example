using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Serializable lets you see it in the inspector
[Serializable]
public class Weapon : Item
{
    //These variables exist in addition to the base Item class that we derive from above, you can also override base class variables/methods here if you wish
    public int damage;

    //Method exclusive to weapon
    public void UpgradeWeapon()
    {
        Debug.Log("You upgraded " + name);
    }

    public override void Sell()
    {
        Debug.Log("You trade " + name + " for a hat and " + itemCost + "gold");
        
        goldAmount += itemCost;
        
        Debug.Log("Gold amount: " + goldAmount);
    }
}
