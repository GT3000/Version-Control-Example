using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Derives from Gold Distribution
public class Soldier : GoldDistribution
{
    [SerializeField] private int unitSalary = 5000;
    
    //Overrides the base class of Gold Distribution's CalculateUnitSalary to say how much this unit gets paid
    public override void CalculateUnitSalary()
    {
        Debug.Log("Payroll: " + unitSalary);
    }
    
    //Calls UnitIdentification in the base GoldDistribution class and the runs the overrides CalculateUnit Salary from GoldDistribution
    private void Start()
    {
        UnitIdentification();
        CalculateUnitSalary();
    }
}
