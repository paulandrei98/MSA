using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameController : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    public EndScreen end;
    public static int currScore = 0;
    [SerializeField] Text scoreAmount;
    void Start()
    {
        currScore = 0;
        UpdateScoreUI();
    }

    // Update is called once per frame
    public void AddScore(int amount)
    {
        currScore += amount;
        UpdateScoreUI();
    }

    public void UpdateScoreUI()
    {
        scoreAmount.text = currScore.ToString("0");
        //GameOverScreen.Setup(currScore);
        end.Setup(currScore);
    }
}
