using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //refer to the script CyMover in the maze project for code explanation + with add on jump
     public CharacterController _controller;
     [SerializeField] public float _speed;
     public Transform cam;
     //for jump
     private Vector3 playerVelocity;
     private bool groundedPlayer;
     private float jumpHeight = 2.0f;
     private float gravityValue = -9.81f;

    
     private void Start()
     {
         _controller = gameObject.GetComponent<CharacterController>();
     }
     
    void Update()
    {
        float horizInput = Input.GetAxisRaw("Horizontal") * _speed;
        float verticInput = Input.GetAxisRaw("Vertical") * _speed;

        Vector3 _direction = new Vector3(horizInput, 0f, verticInput).normalized;

        //for jump
        groundedPlayer = _controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }
        
        if (_direction != Vector3.zero)
        {
            gameObject.transform.forward = _direction;
        }
        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        _controller.Move(playerVelocity * Time.deltaTime);
        
        //for local direction moevement (from the old script)
        if (_direction.magnitude >= 0.1f)
        {
            float _targetAngel = Mathf.Atan2(_direction.x, _direction.z) * Mathf.Rad2Deg+ cam.eulerAngles.y;
            transform.rotation = Quaternion.Euler(0f, _targetAngel, 0f);
            Vector3 moveDirection = Quaternion.Euler(0f, _targetAngel, 0f) * Vector3.forward;

            _controller.Move(moveDirection.normalized * _speed * Time.deltaTime);
        }
        
    }
}
