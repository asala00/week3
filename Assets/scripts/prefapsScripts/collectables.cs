using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectables : MonoBehaviour
{
    
    private float coinAngel = 0.9f;
    
    void Update()
    {
        transform.Rotate(transform.up, 360 * coinAngel * Time.deltaTime);
    }
}
