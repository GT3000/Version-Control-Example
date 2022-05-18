using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private int health;
    [SerializeField] private int gems;

    public virtual void Attack()
    {
        
    }

    public virtual void Death()
    {
        
    }
}

public class Slimer : Enemy
{
    public override void Attack()
    {
        throw new NotImplementedException();
    }

    public override void Death()
    {
        //Implement particles unique to this class
        base.Death();
    }
}
