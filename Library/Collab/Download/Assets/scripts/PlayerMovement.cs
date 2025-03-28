﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    public CharacterController controller;

    private Vector3 moveDirection;
    public float gravityScale;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        //moveDirection = new Vector3(Input.GetAxis("Horizontal")) * moveSpeed, moveDirection.y, Input.GetAxis("Vertical") * moveSpeed;

        float yStore = moveDirection.y;
         moveDirection = (transform.forward * Input.GetAxis("Vertical")) + (transform.right * Input.GetAxis("Horizontal"));
         moveDirection = moveDirection.normalized * moveSpeed;
         moveDirection.y = yStore;



        if (controller.isGrounded)
        {
            moveDirection.y = 0f; 
            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y = jumpForce; 
            }
        }
        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
        controller.Move(moveDirection * Time.deltaTime); 
    }
}
