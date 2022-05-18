using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        //When the player object hits this gameObject change it red
        if (other.gameObject.GetComponent<Player>())
        {
            GetComponent<MeshRenderer>().material.SetColor("_Color", Color.red);
        }

        //When another gameObject like this one hits this one, turn it green
        if (other.gameObject.GetComponent<ChangeColor>())
        {
            GetComponent<MeshRenderer>().material.SetColor("_Color", Color.green);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //when player object enters the trigger collider, turn it blue
        if (other.gameObject.GetComponent<Player>())
        {
            other.gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.blue);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //when player object leaves the trigger collider, turn it grey
        if (other.gameObject.GetComponent<Player>())
        {
            other.gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.grey);
        }
    }
}
