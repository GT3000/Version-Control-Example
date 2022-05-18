using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

//Once again calling IDamagable
public class Player : MonoBehaviour, IDamagable<int>
{
    public float speed = 100.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = new Vector3(-Input.GetAxisRaw("Vertical"),0 , Input.GetAxisRaw("Horizontal"));

        GetComponent<Rigidbody>().velocity = playerPos * Time.deltaTime * speed;
    }

    //Implementing the health property in IDamagable
    public int Health { get; set; }
    
    //Implementing the Damage method in IDamagable
    public void Damage(int damageAmount)
    {
        throw new System.NotImplementedException();
    }
}
