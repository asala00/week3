using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{ //Sound Managers work is they hold dozens of different audio clips for other game objects to play


    public AudioSource _AudioSource;
    public AudioClip jump, collect, win;
    
    void Start()
    {
        //plug in the AudioSource + inspector
        _AudioSource = GetComponent<AudioSource>();
    }

    
    //create a handful of methods, one for each sound effect so
    //other scripts will be able to call sound effects to play with ease

    public void JumpSFX()
    {
        _AudioSource.PlayOneShot(jump);
    }

    public void CollectSFX()
    {
        _AudioSource.PlayOneShot(collect);
    }

    public void WinSFX()
    {
        _AudioSource.PlayOneShot(win);
    }
    
}
