using System;
using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using Random = UnityEngine.Random;

public class Lists : MonoBehaviour
{
    [SerializeField] private List<GameObject> spawnObjects;
    [SerializeField] private List<GameObject> createdObjects;
    
    void Start()
    {
        spawnObjects = new List<GameObject>(3);
        
        print(spawnObjects.Count);
        
        for (int i = 0; i < 3; i++)
        {
            GameObject tempObj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            spawnObjects.Add(tempObj);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (createdObjects.Count >= 10)
            {
                foreach (var obj in createdObjects)
                {
                    obj.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.green);
                }
            }
            else
            {
                int randomIndex = Random.Range(0, spawnObjects.Count);
                Vector3 randomPos = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0);

                GameObject newObject = Instantiate(spawnObjects[randomIndex], randomPos, Quaternion.identity);
            
                createdObjects.Add(newObject);
            }
        }
    }
}
