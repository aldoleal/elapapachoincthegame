using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour{
public static int StartTeleport = 1;

    public GameObject Portal, Player;
   

   private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.gameObject.tag == "Player" && Warp.StartTeleport == 0)
        {
        Warp.StartTeleport = 0;
            StartCoroutine(Teleport());        
    }
}

IEnumerator Teleport()
{
        yield return new WaitForSeconds(0);

        Player.transform.position = new Vector2(Portal.transform.position.x, Portal.transform.position.y);

         } 
} 

