using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterStats))]
public class CharacterCombat : MonoBehaviour
{

    public float attackSpeed = 1f;
    private float attackCooldown = 0f;
    CharacterStats myStats;
    void Start()
    {
        myStats = GetComponent<CharacterStats>();
    }

    void Update()
    {
        attackCooldown -= Time.deltaTime;
    }

    public void Attack(CharacterStats targetStats)
    {
        if(attackCooldown <= 0f)
        {
            targetStats.TakeDamage(myStats.damage.GetValue());
            attackCooldown = 1f/attackSpeed; //the greater the attack speed the lower the cooldown.
        }
    }

}
