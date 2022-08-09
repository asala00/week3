using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INminiGameQuit1 : MonoBehaviour
{
    [SerializeField] private GameObject preminigameHUD;
    [SerializeField] private GameObject miniGame;
    [SerializeField] private GameObject minigameCanvas;
    [SerializeField] private GameObject minigameCam;
   public void GoBackToMainMenu()
    {
        miniGame.SetActive(false);
        minigameCanvas.SetActive(false);
        minigameCam.SetActive(false);
        preminigameHUD.SetActive(true);
    }
}
