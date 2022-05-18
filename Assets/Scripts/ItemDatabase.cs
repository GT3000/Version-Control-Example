using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public Item goldBar = new Item();
    public Weapon bastardSword = new Weapon();

    private void Start()
    {
        goldBar.Sell();
        bastardSword.Buy();
        bastardSword.Sell();
    }
}
