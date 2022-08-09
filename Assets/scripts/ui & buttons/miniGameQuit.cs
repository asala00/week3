using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniGameQuit : MonoBehaviour
{
    private playerMovement playerScript;
    [SerializeField] private GameObject playerTBD;
    [SerializeField] private GameObject BudgetHUD;
    [SerializeField] private GameObject miniGameHUD;
    [SerializeField] GameObject TvPovCam;
    

    public void quit()
    {
        playerScript = playerTBD.GetComponent<playerMovement>();
        playerScript.enabled = true;
        
        BudgetHUD.SetActive(true);
        miniGameHUD.SetActive(false);
        TvPovCam.SetActive(false);
    }
}
