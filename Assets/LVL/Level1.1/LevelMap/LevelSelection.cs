using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    public Button[] lvlButtons;
    public Button[] storyButton;
    

    void Start()
    {
        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if(i > 0)
            {
                lvlButtons[i].interactable = false;
            }
        }
    }

    void Update()
    {
        if(PlayerPrefs.GetString("lvlselectbutton1") == "true")
        {
            lvlButtons[1].interactable = true;
        }
        if(PlayerPrefs.GetString("lvlselectbutton2") == "true")
        {
            lvlButtons[2].interactable = true;
        }
        if(PlayerPrefs.GetString("lvlselectbutton3") == "true")
        {
            lvlButtons[3].interactable = true;
        }
        if(PlayerPrefs.GetString("lvlselectbutton4") == "true")
        {
            lvlButtons[4].interactable = true;
        }
        if(PlayerPrefs.GetString("lvlselectbutton5") == "true")
        {
            lvlButtons[5].interactable = true;
        }
        if(PlayerPrefs.GetString("lvlselectbutton6") == "true")
        {
            lvlButtons[6].interactable = true;
        }
        if(PlayerPrefs.GetString("lvlselectbutton7") == "true")
        {
            lvlButtons[7].interactable = true;
        }
        if(PlayerPrefs.GetString("lvlselectbutton8") == "true")
        {
            lvlButtons[8].interactable = true;
        }
        if(PlayerPrefs.GetString("mapstorybutton1") == "true")
        {
            storyButton[0].interactable = true;
        }
        if(PlayerPrefs.GetString("mapstorybutton2") == "true")
        {
            storyButton[1].interactable = true;
        }
        if(PlayerPrefs.GetString("mapstorybutton3") == "true")
        {
            storyButton[2].interactable = true;
        }
        if(PlayerPrefs.GetString("mapstorybutton4") == "true")
        {
            storyButton[3].interactable = true;
        }
        if(PlayerPrefs.GetString("mapstorybutton5") == "true")
        {
            storyButton[4].interactable = true;
        }
    }
}
