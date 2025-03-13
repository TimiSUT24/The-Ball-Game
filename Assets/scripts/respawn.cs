using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform RespawnPoint;

    void OnTriggerEnter(Collider Player)
    {
        if(Player.gameObject.tag == "Player")
        Player.transform.position = RespawnPoint.transform.position;
    }

   
}