using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform RespawnPoint;


    private void OnCollisionEnter(Collision Player)
    {
        if (Player.gameObject.tag == "Player")
            Player.transform.position = RespawnPoint.transform.position;
    }
}
