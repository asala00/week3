using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faceCamAAT : MonoBehaviour
{
    private Transform cam; 
    void Start()
    {
        cam = Camera.main.transform; //plug in the Main Camera's Transform as our Transform variable
    }


    private void LateUpdate()
    {
        Vector3 cameraForward = transform.position + cam.rotation * Vector3.forward;
        Vector3 cameraUp = cam.rotation * Vector3.up;
        transform. LookAt (cameraForward, cameraUp);
    }
}
