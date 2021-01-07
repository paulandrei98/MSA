using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EndLevel : MonoBehaviour
{
    [SerializeField] public Text pointsText;



    public void Setup(int score)
    {
        pointsText.text = "Your Score "+score.ToString();
    }

    public void restart(){
        SceneManager.LoadScene("Scene1");
        Time.timeScale = 1;
    }

    public void nextLevel()
    {
        Debug.Log("Nex Level comming soon !");
        SceneManager.LoadScene("Scene2");
        Time.timeScale = 1;
    }
}
