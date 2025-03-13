using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collapse : MonoBehaviour
{
    public GameObject destroyedVersion;


     void OnTriggerEnter(Collider other)
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
       
    
    }
       
