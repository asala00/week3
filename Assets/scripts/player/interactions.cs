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

        Pscore.text = (""+ polaroidCount); //to update the score 
        playerHP.text = ("" + HP);
        
        if (HP == 0)
        {
            Die();
        }
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
