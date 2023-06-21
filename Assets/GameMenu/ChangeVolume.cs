using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeVolume : MonoBehaviour
{
    public Slider volumeSlider;
    public float VolumePlayerPrefsKey = 0.3f;
    void Start()
    {
        volumeSlider.onValueChanged.AddListener(ChangeSoundVolume);
    }

    private void ChangeSoundVolume(float volume)
    {
        VolumePlayerPrefsKey = volume;
        PlayerPrefs.SetFloat("VolumeSound", VolumePlayerPrefsKey);
        PlayerPrefs.Save();
    }
}
