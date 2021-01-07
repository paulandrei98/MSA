using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Experimental.Input;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{ 

    void Awake()
    {
        PlayerController.isdead = true;
        Time.timeScale = 1;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT !");
        Application.Quit();
    }
}
