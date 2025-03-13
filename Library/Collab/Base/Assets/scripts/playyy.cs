using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playyy : MonoBehaviour
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
        //moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveDirection.y, Input.GetAxis("Vertical") * moveSpeed;

        moveDirection = (transform.forward * Input.GetAxis("Vertical") * moveSpeed)+ (transform.right * Input.GetAxis("Horizontal")) * moveSpeed;

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
