using System;
using System.Collections;
using System.Collections.Generic;
using Ludiq.PeekCore;
using UnityEngine;

public class Delegate : MonoBehaviour
{
    public delegate void ChangeColor(Color newColor);
    public ChangeColor onColorChange;

    public delegate void OnComplete();
    public OnComplete onComplete;

    public delegate void ActionClick();
    public static event ActionClick onClick;

    public delegate void Teleport(Vector3 pos);
    public static event Teleport onTeleport;

    public delegate void OnDeath();
    public static event OnDeath onDeath;

    public Action<int, int> Sum;
    
    void Start()
    {
        onColorChange = UpdateColor;
        onColorChange(Color.green);
        onComplete = Task;
        onComplete();

        Sum = (a, b) =>
        {
            int total = a + b;
            Debug.Log(total);
        };

        Sum(5, 2);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Death();
        }
    }

    public void UpdateColor(Color newColor)
    {
        Debug.Log("Change color: " + newColor.ToString());
    }

    public void Task()
    {
        print("Task complete.");
    }

    public void ButtonClick()
    {
        if (onClick != null)
        {
            onClick();
        }
        
    }

    private void Death()
    {
        if (onDeath != null)
        {
            onDeath();
        }
    }
}
