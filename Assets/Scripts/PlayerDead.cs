using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour
{
    [SerializeField] private int playerHealth = 100;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CheckPlayerDeath(25);
        }
    }

    private void CheckPlayerDeath(int damageTaken)
    {
        if (playerHealth > 0)
        {
            playerHealth -= damageTaken;
        }
        else
        {
            playerHealth = 0;
        }
        
        print(playerHealth);
    }
}
