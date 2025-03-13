using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocksound : MonoBehaviour
{


    public AudioSource rock; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            rock.Play();
            Destroy(gameObject);
        }
        
    }

        }
