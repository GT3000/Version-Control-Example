using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//By inheiriting from IDamagable with a generic we have to set the type we'd like to use right after the implementation otherwise completely the same
public class EnemyInterface : MonoBehaviour, IDamagable<int>
{
    public int Health { get; set; }
    
    public void Damage(int damageAmount)
    {
        throw new System.NotImplementedException();
    }

    private void SomeOtherEnemyMethod()
    {
        //Enemy logic
    }
}
