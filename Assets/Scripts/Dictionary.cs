using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour
{
    public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();

    void Start()
    {
        //Make a new item
        Weapon sword = new Weapon();
        sword.name = "Big Sword";
        sword.itemID = 0;
        
        //Make a new item
        Weapon mace = new Weapon();
        mace.name = "Big Mace";
        mace.itemID = 1;
        
        //Make a new item
        Weapon axe = new Weapon();
        axe.name = "Big Axe";
        axe.itemID = 2;
        
        //add the item to the dictionary and set a key of 0
        itemDictionary.Add(0, sword);
        itemDictionary.Add(1, mace);
        itemDictionary.Add(2, axe);
        
        //prints the item's name in the dictionary using the key
        print(itemDictionary[0].name);

        //Removes one of the entries
        itemDictionary.Remove(0);
        
        //Loop over the dictionary an dlist off the item name and value
        foreach (var item in itemDictionary)
        {
            print("Item Name: " + item.Value.name + " " + "Item ID: " + item.Key);
            
            //Same thing with "proper" formatting
            string s = string.Format("Name: {0} ID: {1}", item.Value.name, item.Key);
            print(s);
        }
    }

    void Update()
    {
        
    }
}
