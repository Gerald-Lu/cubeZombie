using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerHealthScript TakeDamage;

   void OnCollisionEnter(Collision collisionInfo)
   {
        if (collisionInfo.collider.tag == "Enemy")
        {
            Debug.Log("Encounter");
        }
   }

}
