using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyExplosion : MonoBehaviour
{
    [SerializeField] private GameObject explosionPrefab;            //Explosion animation prefab

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            //If there's no explosion prefab then throw a error otherwise, instantiate a GO named 'tempExplosion'
            //Destroy tempExplosion once it's animation is done playing destroy the current object in the meantime
            if (explosionPrefab != null)
            {
                GameObject tempExplosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
                Destroy(tempExplosion, tempExplosion.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
            }
            else
            {
                Debug.LogError("No explosion prefab assigned.");
            }

            //Destroys current enemy object
            Destroy(gameObject);
        }
    }
}
