using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    [SerializeField] private GameObject capsule;
    private bool isInvisible = false;
    private bool coroutineIsRunning = false;
    
    void Start()
    {
        StartCoroutine(Invisible());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && !coroutineIsRunning)
        {
            StartCoroutine(Invisible());
        }
    }

    private IEnumerator Invisible()
    {
        coroutineIsRunning = true;
        
        if (!isInvisible)
        {
            Color initalColor = capsule.GetComponent<MeshRenderer>().material.color;
            Color newColor = new Color(initalColor.r, initalColor.g, initalColor.b, 0f);
            float elapsedtime = 0f;

            while (elapsedtime < 5.0f)
            {
                elapsedtime += Time.deltaTime;
                Color currentColor = Color.Lerp(initalColor, newColor, elapsedtime / 5.0f);
                capsule.GetComponent<MeshRenderer>().material.color = currentColor;
                yield return null;
            }

            isInvisible = true;
        }
        else if (isInvisible)
        {
            Color initalColor = capsule.GetComponent<MeshRenderer>().material.color;
            Color newColor = new Color(initalColor.r, initalColor.g, initalColor.b, 1.0f);
            float elapsedtime = 0f;

            while (elapsedtime < 5.0f)
            {
                elapsedtime += Time.deltaTime;
                Color currentColor = Color.Lerp(initalColor, newColor, elapsedtime / 5.0f);
                capsule.GetComponent<MeshRenderer>().material.color = currentColor;
                yield return null;
            }
            
            isInvisible = false;
        }

        coroutineIsRunning = false;
    }
}
