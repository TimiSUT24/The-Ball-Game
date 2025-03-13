using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] private Animator myAnimationController;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            rb.constraints = RigidbodyConstraints.None;
            myAnimationController.gameObject.GetComponent<Animator>().enabled = false; 
        }
    }
    

}
