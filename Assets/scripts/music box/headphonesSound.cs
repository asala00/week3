using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headphonesSound : MonoBehaviour
{
    private AudioSource song;
    
    void Start()
    {
        song = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            song.Play();
        }
    }
}
