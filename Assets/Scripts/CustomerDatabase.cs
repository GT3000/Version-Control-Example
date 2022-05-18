using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Customer
{
    public string firstName;
    public string lastName;
    public int age;
    public string gender;
    public string occupation;
    
    public Customer(string customerFirstName, string customerLastName, int customerAge, string customerGender, string customerOccupation)
    {
        firstName = customerFirstName;
        lastName = customerLastName;
        age = customerAge;
        gender = customerGender;
        occupation = customerOccupation;
    }
}

public class CustomerDatabase : MonoBehaviour
{
    [SerializeField]private Customer[] customers = new Customer[3];
    
    void Start()
    {
        customers[0] = new Customer("John", "Smith", 25, "Male", "Cop");
        customers[1] = new Customer("Tom", "Willis", 45, "Male", "Fireman");
        customers[2] = new Customer("Mary", "Jones", 30, "Female", "Technician");
    }
}
