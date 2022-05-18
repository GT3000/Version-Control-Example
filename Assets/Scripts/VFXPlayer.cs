using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXPlayer : MonoBehaviour
{
    [SerializeField] private int health = 3;
    [SerializeField] private GameObject damagedFx;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            health--;
            print(health);

            //If the player's health is 1 and thus near death activate the VFX then parent it to the player
            if (health == 1)
            {
                if (damagedFx != null)
                {
                    GameObject tempDamageFx = Instantiate(damagedFx, transform.position, damagedFx.transform.rotation);
                    tempDamageFx.transform.parent = transform; 
                }
            }
            
            //Once player hits zero destroy it and the VFX childed
            if (health == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
