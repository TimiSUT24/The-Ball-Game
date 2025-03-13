using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThings : MonoBehaviour
{
    
    [Header("Speed Settings")]
    public float walkSpeed;
    public float runSpeed;
    [SerializeField]
    private float Speed;
    Rigidbody rb;
   

    private void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        
        if (Input.GetButton("Sprint"))
            Speed = runSpeed;
        else if (Speed != walkSpeed)
            Speed = walkSpeed;
        
    }

    private void FixedUpdate()
    { 


        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");
         rb.MovePosition(transform.position + transform.TransformDirection(x, 0, z) * Time.deltaTime * Speed);
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ice")
        {
            walkSpeed = 8; 
        }
    }

     void OnCollisionExit(Collision collision)
    {
       if(collision.gameObject.tag == "Ground")
        {
            walkSpeed = 3; 
        }
    }



}