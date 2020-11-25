using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{
    public override void Die()
    {

        base.Die();

        //add dead animation
        PlayerManager.instance.KillPlayer();
        //Destroy(gameObject);
    }
}
