using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class GameOverScreen : MonoBehaviour
{
    [SerializeField] public Text pointsText;
    //[SerializeField] public TextMeshProUGUI pointsText;

    public void Setup(int score)
    {
        
        pointsText.text = "Your Score "+score.ToString();
    }

    void start(){
        //Time.timeScale = 0;
    }

    public void RestartButton(){
        //Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }

    public void ExitButton(){
        //Time.timeScale = 1;
        SceneManager.LoadScene(0);
        
    }
}
