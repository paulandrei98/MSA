using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

public GameObject toHide;
public GameObject toShow;
public GameObject toShow2;

public GameObject hideJoystick;
    public void PauseGame()
    {

        Time.timeScale = 0;
        toHide.SetActive(false);
        toShow.SetActive(true);
        hideJoystick.SetActive(false);

    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        toHide.SetActive(false);
        toShow.SetActive(true);
        hideJoystick.SetActive(true);
    }

    public void SettingsGame()
    {
        toHide.SetActive(false);
        toShow2.SetActive(true);
    }

    public void ExitGame()
    {
        Debug.Log("QUIT !");
        Application.Quit();
    }

}
