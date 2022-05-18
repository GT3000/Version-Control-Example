using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GoldDistribution : MonoBehaviour
{
    [SerializeField] private string squadName;
    [SerializeField] private string unitName;

    //Used to calculate the salary if no units are present in this case a debug.log saying no units on payroll
    public virtual void CalculateUnitSalary()
    {
        Debug.Log("No units on payroll.");
    }

    //Has the unit identify themselves by name and squad name
    protected void UnitIdentification()
    {
        Debug.Log("Unit Name: " + unitName);
        Debug.Log("Squad Name: " + squadName);
    }
    
}
