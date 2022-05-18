using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;    //Holds the Text object responsible for our score
    [SerializeField] private int score;        //Tracks how many points we've accumulated so far
    
    // Start is called before the first frame update
    void Start()
    {
        //Sets the score to zero 
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
        //Update score text by 1 point everytime you hit S
        if (Input.GetKeyDown(KeyCode.S))
        {
            UpdateScore(1);
        }
    }
    
    //Updates the score int with incoming points and also updates the text field right after
    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }
}
