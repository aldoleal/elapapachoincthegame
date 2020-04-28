using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportkey : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
        { 
        if(collision.gameObject.tag== "Player")
        { 
        Warp.StartTeleport = 0;  
        }
}
}
