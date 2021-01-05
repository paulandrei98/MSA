using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : MonoBehaviour
{
    public GameObject player;
    public GameObject FloatingText;
    public int scoreBonus = 60;

    void OnTriggerEnter(Collider col)
    {
        if(FloatingText != null)
        {
            ShowFloatingText();
        }
        
        player.GetComponent<GameController>().AddScore(scoreBonus);
        Destroy(gameObject);


    }

    void ShowFloatingText()
    {
        var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
        go.GetComponent<TextMesh>().text = "+"+scoreBonus.ToString();
    }
}
