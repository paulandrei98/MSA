using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    PlayerController playerHealth;
    public GameObject FloatingText;
    public int healthBonus = 15;

    void Awake()
    {
        playerHealth = FindObjectOfType<PlayerController>();

    }

    void OnTriggerEnter(Collider col)
    {
        if(FloatingText != null)
        {
            ShowFloatingText();
        }
        
        if(playerHealth.currentHealth < playerHealth.maxHealth)
        {
            Destroy(gameObject);
            playerHealth.currentHealth = playerHealth.currentHealth+healthBonus;
        }
    }

    void ShowFloatingText()
    {
        var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
        go.GetComponent<TextMesh>().text = "+"+healthBonus.ToString();
    }
}
