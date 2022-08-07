using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //refer to the script CyMover in the maze project for code explanation 
     public CharacterController _controller;
     [SerializeField] public float _speed;
     public Transform cam;
   
    
    void Update()
    {
        float horizInput = Input.GetAxisRaw("Horizontal") * _speed;
        float verticInput = Input.GetAxisRaw("Vertical") * _speed;

        Vector3 _direction = new Vector3(horizInput, 0f, verticInput).normalized;

        if (_direction.magnitude >= 0.1f)
        {
            float _targetAngel = Mathf.Atan2(_direction.x, _direction.z) * Mathf.Rad2Deg+ cam.eulerAngles.y;
            transform.rotation = Quaternion.Euler(0f, _targetAngel, 0f);
            Vector3 moveDirection = Quaternion.Euler(0f, _targetAngel, 0f) * Vector3.forward;

            _controller.Move(moveDirection.normalized * _speed * Time.deltaTime);
        }
    }
}
