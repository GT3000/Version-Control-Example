using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXClick : MonoBehaviour
{
    private AudioSource audioSource;            //the audio source
    [SerializeField] private AudioClip sfx;     //the sound effect clip
    
    // Start is called before the first frame update
    void Start()
    {
        //Sets the audiosource to the one attached to this object
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //When the player clicks and if the audioclip isn't null then play the sound effect
        if (Input.GetMouseButtonDown(0) && sfx != null)
        {
            audioSource.PlayOneShot(sfx);
        }
    }
}
