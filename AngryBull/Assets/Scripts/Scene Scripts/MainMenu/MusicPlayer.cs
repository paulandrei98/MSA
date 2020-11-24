using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{

    public AudioSource audioSource;

    private float musicVolume = 1f;
    private bool isMuted;


    // Start is called before the first frame update
    void Start()
    {
        audioSource.Play();
        isMuted = false;    
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = musicVolume;
    }

    public void UpdateVolume(float volume)
    {
        musicVolume = volume;
    }

    public void MutePressed()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
    }
}
