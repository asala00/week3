using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;     
using TMPro;
public class minigamePlayerMove : MonoBehaviour
{
    private int speed = 5;
    [SerializeField] int coins;
    [SerializeField] private Image healthBar; // the meter itself//will reference its component to change the amount.
    [SerializeField] private float healthAmount; //to keep track of how much Fill Amount our Image has
    [SerializeField] private GameObject disableOnGAMEOVER;
    [SerializeField] private GameObject EnableOnGAMEOVER;
  
    

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        float verticalInput = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
        transform.Translate(movement);
        
        
        //health bar using ui stuff:

        healthBar.fillAmount = healthAmount; //fill the health bar with how much health amount we have
        if (healthAmount < 0.2f)
        {
            disableOnGAMEOVER.SetActive(false);
            EnableOnGAMEOVER.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("CollectCoinMini"))
        {
            coins++;
            Destroy(col.gameObject);
        }

        if (col.gameObject.CompareTag("CollectDamageMini"))
        {
            healthAmount -= 0.2f;
            Destroy(col.gameObject);
        }
    }
}

