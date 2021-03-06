﻿
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public static int currentHealth { get; private set; }

    public Stat damage;

    public event System.Action<int,int> OnHealthChanged;

    void Awake ()
    {
        currentHealth = maxHealth;
    }



    public void TakeDamage (int damage)
    {
        Debug.Log(currentHealth);
    
        currentHealth -= damage;
        Debug.Log(transform.name + " takes "+ damage + " damage.");
        
        if(OnHealthChanged != null)
        {
            OnHealthChanged(maxHealth,currentHealth);
        }
        
        if(currentHealth <= 0)
        {
            Die();
        }
    }


    public virtual void Die()
    {
        // overwrite the message with die animation and dissapear character from map.
        Debug.Log(transform.name + " died. ");
    }

}
