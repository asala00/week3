using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigamePlayerMove : MonoBehaviour
{
    private int speed = 5;
    [SerializeField] int coins;
    [SerializeField] int health = 5;

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        float verticalInput = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
        transform.Translate(movement);
    }

    // private void OnTriggerEnter(Collider other)
    // {
    //     Debug.Log("inside minigame trigger");
    //     
    //     if (other.CompareTag("CollectCoinMini"))
    //     {
    //         coins++;
    //         Destroy(other.gameObject);
    //     }
    //     else if (other.CompareTag("CollectDamageMini"))
    //     {
    //         health--;
    //         Destroy(other.gameObject);
    //     }
    // }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("CollectCoinMini"))
        {
            coins++;
            Destroy(col.gameObject);
        }

        if (col.gameObject.CompareTag("CollectDamageMini"))
        {
            health--;
            Destroy(col.gameObject);
        }
    }
}

