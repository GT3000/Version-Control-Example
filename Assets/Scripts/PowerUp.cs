using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PowerUpType { SpeedBoost, Firepower, Invisibility }

public class PowerUp : MonoBehaviour
{
   [SerializeField] private PowerUpType powerUpType;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Player>())
        {
            switch (powerUpType)
            {
                case PowerUpType.SpeedBoost:
                    //Do speed boost
                    print("Make player go fast!");

                    other.gameObject.GetComponent<Player>().speed *= 2;
                    
                    Destroy(gameObject);
                    break;
            
                case PowerUpType.Firepower:
                    //Do firepower boost
                    print("Make player go boom!");
                    Destroy(gameObject);
                    break;
            
                case PowerUpType.Invisibility:
                    //Do Invisible boost
                    print("Make player go invisible!");
                    Destroy(gameObject);
                    break;
            }
        }
    }
}
