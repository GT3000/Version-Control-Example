using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
    
    void Awake()
    {
        //This makes the Level Manager persist through each scene and ensures there is only one copy this is called a Singleton
        if (Instance != this && Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //When the player hit D on their keyboard it advances to the next level
        if (Input.GetKeyDown(KeyCode.D))
        {
            NextLevel();
        }
    }

    //This method first checks if the current scene's build index is less than the current amount of total scenes and if it is then it loads the next scene in the order
    private void NextLevel()
    {
        if(SceneManager.GetActiveScene().buildIndex < SceneManager.sceneCountInBuildSettings - 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
    
    //this allows the player to load a particular scene based on it's number and checks if the scene is valid
    public void LoadParticularScene(int sceneNumber)
    {
        if (SceneManager.GetActiveScene().buildIndex <= SceneManager.sceneCount - 1)
        {
            SceneManager.LoadScene(sceneNumber);
        }
        else
        {
            print("Not a valid scene.");
        }
    }
}
