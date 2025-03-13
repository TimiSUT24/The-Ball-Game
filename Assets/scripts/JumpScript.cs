using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class JumpScript : MonoBehaviour
{
    public float jumpSpeed = 5f; 
    public bool isGrounded;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == ("Ground") && isGrounded == false)
        {
            isGrounded = true;
        }
        if (col.gameObject.tag == ("Ice") && isGrounded == false)
        {
            isGrounded = true; 
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector3(0, 2, 0) * jumpSpeed, ForceMode.Impulse);
            isGrounded = false;
        }
    }



}
