using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnAnimation : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] private Transform Object;
    [SerializeField] private Transform RespawnPoint;
    [SerializeField] private Animator myAnimationController;


    void OnTriggerEnter(Collider other)
    {


        Object.transform.position = RespawnPoint.transform.position;
        rb.constraints = RigidbodyConstraints.FreezeAll;
        myAnimationController.gameObject.GetComponent<Animator>().enabled = true;

    }
}
