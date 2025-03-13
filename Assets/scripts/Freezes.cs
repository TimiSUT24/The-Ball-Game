using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freezes : MonoBehaviour
{

    public Rigidbody rb;
    

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            rb.constraints = RigidbodyConstraints.None;
           
        }
    }
}

