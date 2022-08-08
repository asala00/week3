using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactions : MonoBehaviour
{
    [SerializeField] private GameObject headphonesON;
    [SerializeField] private GameObject headphonesCOUNTER;
    public int polaroidCount ;
    [SerializeField] private soundManager sm;
        
    // Start is called before the first frame update
    void Start()
    {
        headphonesON.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            headphonesON.SetActive(true);
            headphonesCOUNTER.SetActive(false);
        }
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
}
