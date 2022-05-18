using System;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;
using Random = UnityEngine.Random;

public class Method : MonoBehaviour
{
    [SerializeField] private Vector3[] randomPositions = new Vector3[5];

    private void Start()
    {
        for (int i = 0; i < randomPositions.Length; i++)
        {
            randomPositions[i] = Vector3.zero;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = GenerateRandomPositon();
        }
    }

    private int GenerateRandomIndex()
    {
        return Random.Range(0, randomPositions.Length);
    }

    private Vector3 GenerateRandomPositon()
    {
        int x = Random.Range(0, 10);
        int y = Random.Range(0, 10);
        int z = Random.Range(0, 10);

        Vector3 randomlyGeneratedPosition = new Vector3(x, y, z);
        randomPositions[GenerateRandomIndex()] = randomlyGeneratedPosition;
        
        return randomPositions[GenerateRandomIndex()];
    }
}
