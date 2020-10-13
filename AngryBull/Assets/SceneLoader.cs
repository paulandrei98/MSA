using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //used for loading scenes
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit !");
    }

}
