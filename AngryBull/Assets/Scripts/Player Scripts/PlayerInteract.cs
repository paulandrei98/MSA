using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.name);
        /*
        if(collisionInfo.collider.tag == "enemyTag")
        {
            Debug.Log("we hit an enemy");
     
        }
    */
    }
}
