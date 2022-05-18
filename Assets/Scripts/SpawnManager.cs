using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;        
    [SerializeField] private int totalEnemiesToSpawn;       
    private int currentAmountSpawned;
    private GameObject enemyContaner;                    //Holds your shiny new enemy objects
    
    // Start is called before the first frame update
    void Start()
    {
        //assign the GameObject programmatically and name it in one shot
        enemyContaner = new GameObject("Enemy Container");
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (currentAmountSpawned < totalEnemiesToSpawn)
        {
            int RandomX = Random.Range(-10, 10);
            int RandomZ = Random.Range(-10, 10);
            
            Vector3 randomPositon = new Vector3(RandomX, 1, RandomZ);
            
            //this spawns the enemy prefab copy at random position then parent it to the spawn manager
            //GameObject tempEnemy = Instantiate(enemyPrefab, randomPositon, Quaternion.identity);
            //tempEnemy.transform.parent = transform;
            
            //this spawns the enemy prefab copy at random position then parent it to the new Enemy Container object
            GameObject tempEnemy = Instantiate(enemyPrefab, randomPositon, Quaternion.identity);
            tempEnemy.transform.parent = enemyContaner.transform;
            
            currentAmountSpawned++;
            
            yield return new WaitForSeconds(0.1f);
        }
        
        yield return null;
    }
}
