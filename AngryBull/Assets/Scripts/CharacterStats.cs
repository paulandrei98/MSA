
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth { get; private set; }

    public Stat damage;

    void Awake ()
    {
        currentHealth = maxHealth;
    }



    public void TakeDamage (int damage)
    {
        Debug.Log(currentHealth);
    
        currentHealth -= damage;
        Debug.Log(transform.name + " takes "+ damage + " damage.");
    
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
