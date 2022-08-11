using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;     //to code the text & images ui
using TMPro;
using UnityEngine.SceneManagement; //to access textmeshpro

public class interactions : MonoBehaviour
{
    [SerializeField] private GameObject headphonesON;
    [SerializeField] private GameObject headphonesCOUNTER;
    public int polaroidCount ;
    [SerializeField] private soundManager sm;
    [SerializeField] private TextMeshProUGUI Pscore;     //Text variables grant us access to those objects' Text components
    public int HP = 5;
    [SerializeField] private TextMeshProUGUI playerHP;
    [SerializeField] private GameObject sitPrompt;
    [SerializeField] private Transform couch;
    [SerializeField] private Transform player;
    [SerializeField] private Transform TVtarget;
    [SerializeField] GameObject TvPovCam;
    private playerMovement playerScript;
    [SerializeField] private GameObject playerTBD;
    [SerializeField] private GameObject BudgetHUD;
    [SerializeField] private GameObject miniGameHUD;
    [SerializeField] private GameObject flashlight;
    [SerializeField] private GameObject nightstand;
    void Start()
    {
        headphonesON.SetActive(false);
        Pscore.text = ("0");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            headphonesON.SetActive(true);
            headphonesCOUNTER.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (flashlight.activeInHierarchy)
            {
                flashlight.SetActive(false);
            }
            else
            {
                flashlight.SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (nightstand.activeInHierarchy)
            {
                nightstand.SetActive(false);
            }
            else
            {
                nightstand.SetActive(true);
            }
        }


        Pscore.text = (""+ polaroidCount); //to update the score 
        playerHP.text = ("" + HP);
        
        if (HP == 0)
        {
            Die();
        }

        if (sitPrompt.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
               miniGamePOV();
            }
        }
    }

    void miniGamePOV()
    {
        player.position = couch.position;
        sitPrompt.SetActive(false);
        player.transform.LookAt(TVtarget);
                
        playerScript = playerTBD.GetComponent<playerMovement>();
        playerScript.enabled = false;
        BudgetHUD.SetActive(false);
        TvPovCam.SetActive(true);
        miniGameHUD.SetActive(true);
        
    }
    private void Die()
    {
        SceneManager.LoadScene(0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("collect"))
        {
            polaroidCount++;
            Destroy(other.gameObject);
            sm.CollectSFX();
        }

        if (other.CompareTag("collect") && polaroidCount == 19) 
        {
            polaroidCount++;
            Destroy(other.gameObject);
            sm.CollectSFX();
            sm.WinSFX();
        }
        if (other.CompareTag("couchfront"))
        {
            sitPrompt.SetActive(true);
        }

    }


    private void OnControllerColliderHit (ControllerColliderHit col) //using this instead of oncolliderenter becz th game attached to this script has a char controller and wont be affected by it
    {
        if (col.gameObject.CompareTag("collectDamage"))
        {
            HP--;
            Destroy(col.gameObject);
        }
        
    }
}
