using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombat : MonoBehaviour
{

    public Animator animator;
    public int maxHealth = 100;
    int currentHealth;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -=damage;
        Debug.Log("Enemy takes "+damage);
        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        animator.SetTrigger("dead");
        Debug.Log("Enemy died! ");

        
        GetComponent<Collider>().enabled = false;
        this.enabled = false;

        
        Destroy(gameObject);

    }
}
