using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundBoard : MonoBehaviour
{
    private AudioSource _audioSource; //the Audio Source component itself so we can control it thro script
    // [SerializeField] private AudioClip headphones; //we can add as many sound clips to this audiosource as we want
    void Start()
    {
       // Using the Start method to directly grab the Audio Source component from the game object itself and plug it in as our variable.
       _audioSource = GetComponent<AudioSource>();
       
    }

    
    void Update()
    {
        MusicBoxControls();
        
    }

    
    
    
    void MusicBoxControls()  //will code the audio to start acoording to input instead of on awake
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _audioSource.Play();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _audioSource.Stop();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _audioSource.Pause();
        }
    }
}
