using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private bool triggerFall = false;
    [SerializeField] private bool teleports = false;
    [SerializeField] private Vector3 teleportPos;
    
    void Start()
    {
        Delegate.onClick += TurnRed;
        Delegate.onClick += Fall;

        Delegate.onTeleport += OnStart;
    }

    void Update()
    {
        
    }

    public void TurnRed()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public void Fall()
    {
        if (triggerFall)
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
    }

    public void OnStart(Vector3 pos)
    {
        if (teleports)
        {
            transform.position = pos; 
        }
    }
}
