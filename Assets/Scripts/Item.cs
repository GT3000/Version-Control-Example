using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Serializable lets you see it in the inspector
[Serializable]
public class Item
{
    //Item variables that all items share
    public string name;
    public int itemID;
    public int itemCost;
    public Sprite itemsprite;

    public static int goldAmount = 500;
    
    //Generic item methods that every item has
    public void Buy()
    {
        Debug.Log("You bought " + name);

        if (goldAmount >= itemCost)
        {
            goldAmount -= itemCost;
            
            Debug.Log("Gold amount: " + goldAmount);
        }
        else
        {
            Debug.Log("Yer too broke for this");
        }
    }

    public virtual void Sell()
    {
        Debug.Log("You sold " + name);
        goldAmount += itemCost;
        
        Debug.Log("Gold amount: " + goldAmount);
    }
}
