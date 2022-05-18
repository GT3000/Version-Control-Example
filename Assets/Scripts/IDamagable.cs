using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//replacinig int with the T keyword allows you to use anything in the place of T
//however you must explicitly code the type into each implementation of IDamagable
public interface IDamagable<T>
{
     T Health
    {
        get;
        set;
    }

     void Damage(T damageAmount);
}
