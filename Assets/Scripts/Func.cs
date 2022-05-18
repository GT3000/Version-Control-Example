using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Func : MonoBehaviour
{
    public Func<int> onGetName;
    public Func<int, int, int> onGetSum;

    private void Start()
    {
        onGetName = () => this.gameObject.name.Length;
        onGetSum = (a, b) => a + b;

        int charCount = onGetName();
        int totalsum = onGetSum(5, 5);

        print(charCount);
        print(totalsum);
    }
}
