using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class Array : MonoBehaviour
{
    [SerializeField] private string[] playerNames = new string[5];
    [SerializeField] private int[] goldBagContents = {1, 45, 58, 29, 32};
    [SerializeField] private float[] projectileSpeeds = {2.5f, 45.5f, 0.75f, 32.5f, 17.75f};
    

    public GameObject[] cubes;

    private void Start()
    {
        for (int i = 0; i < cubes.Length; i++)
        {
            cubes[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubes[i].GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

    void Update()
    {
        
        
        
    }
}
