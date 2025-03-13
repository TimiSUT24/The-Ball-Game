using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource collectSound;

    private void OnTriggerEnter(Collider other)
    {
        collectSound.Play(); 
    }
}
