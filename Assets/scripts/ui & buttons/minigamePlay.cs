using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigamePlay : MonoBehaviour
{
    [SerializeField] private GameObject console;
    [SerializeField] private GameObject miniGameHUD;
    [SerializeField] GameObject miniGameCam;
    [SerializeField] private GameObject minigamecanvas;
    [SerializeField] private GameObject minigameON; //
    

    
    public void playMiniGame()
    {
        console.SetActive(true);
        miniGameHUD.SetActive(false);
        miniGameCam.SetActive(true);
        Invoke ("StartGame", 4);
        
    }

    void StartGame()
    {
        minigamecanvas.SetActive(true);
        minigameON.SetActive(true);
    }
}
