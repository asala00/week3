using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;    
using TMPro;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TimerClock;
    [SerializeField] private int timeLeft;

    private void Start()
    {
        InvokeRepeating("countDown",1,1); //it waits 1 second to call the Countdown method, and then calls that method every 1 second.
    }

    void Update()
    {
        TimerClock.text = ("00:" + timeLeft);
        if (timeLeft==0)
        {
            SceneManager.LoadScene(0);
        }
    }

    void countDown()
    {
        timeLeft--;
    }
}
