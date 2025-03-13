using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rolling : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] private Transform Object;
    [SerializeField] private Transform RespawnPoint;



    void OnTriggerEnter(Collider other)
    {


        Object.transform.position = RespawnPoint.transform.position;
    }
   
}