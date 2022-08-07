using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactions : MonoBehaviour
{
    [SerializeField] private GameObject headphonesON;
    [SerializeField] private GameObject headphonesCOUNTER;
    
        
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
}
