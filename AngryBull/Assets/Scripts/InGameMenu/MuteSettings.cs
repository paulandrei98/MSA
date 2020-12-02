using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteSettings : MonoBehaviour
{
    public GameObject tomute;
    public GameObject tounmute;

    public void MuteShow()
    {
        tomute.SetActive(true);
        tounmute.SetActive(false);
    }

    public void UnMuteShow()
    {
        tomute.SetActive(false);
        tounmute.SetActive(true);
    }
}
