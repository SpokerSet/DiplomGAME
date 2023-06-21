using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioClip[] sound;
    public AudioSource audioSource;
    public float savedVolume;
    public int savedMusicState;
    
    void Update()
    {
        savedVolume = PlayerPrefs.GetFloat("VolumeSound");
        savedMusicState = PlayerPrefs.GetInt("MusicState");
        audioSource.volume = savedVolume;
    }

    public void MenuSound()
    {

        if (savedMusicState == 1)
        {
            audioSource.clip = sound[0];
            audioSource.Play();
        }
        else if(savedMusicState == 0)
        {
            audioSource.clip = sound[0];
            audioSource.Stop();
        }
        
    }

}
