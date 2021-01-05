using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverScreen : MonoBehaviour
{
    [SerializeField] public Text pointsText;

    public void Setup(int score)
    {
        
        pointsText.text = "Your Score "+score.ToString();
    }

    public void RestartButton(){
        SceneManager.LoadScene("Scene1");
        Time.timeScale = 1;
    }

    public void ExitButton(){
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }
}
