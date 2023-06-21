using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MapSelection : MonoBehaviour
{
    public Button[] mapsButtons;

    void Update()
    {
        if(PlayerPrefs.GetString("mapselectbutton2") == "true")
        {
            mapsButtons[0].interactable = true;
        }
        if(PlayerPrefs.GetString("mapselectbutton3") == "true")
        {
            mapsButtons[1].interactable = true;
        }
        if(PlayerPrefs.GetString("mapselectbutton4") == "true")
        {
            mapsButtons[2].interactable = true;
        }
        if(PlayerPrefs.GetString("mapselectbutton5") == "true")
        {
            mapsButtons[3].interactable = true;
        }
    }

    public void toLevelMap1()
    {
        SceneManager.LoadScene("LevelMap1");
    }
    public void toLevelMap2()
    {
        SceneManager.LoadScene("LevelMap2");
        PlayerPrefs.DeleteKey("lvlselectbutton1");
        PlayerPrefs.DeleteKey("lvlselectbutton2");
        PlayerPrefs.DeleteKey("lvlselectbutton3");
        PlayerPrefs.DeleteKey("lvlselectbutton4");
        PlayerPrefs.DeleteKey("lvlselectbutton5");
        PlayerPrefs.DeleteKey("lvlselectbutton6");
        PlayerPrefs.DeleteKey("lvlselectbutton7");
        PlayerPrefs.DeleteKey("lvlselectbutton8");

    }
    public void toLevelMap3()
    {
        SceneManager.LoadScene("LevelMap3");
        PlayerPrefs.DeleteKey("lvlselectbutton1");
        PlayerPrefs.DeleteKey("lvlselectbutton2");
        PlayerPrefs.DeleteKey("lvlselectbutton3");
        PlayerPrefs.DeleteKey("lvlselectbutton4");
        PlayerPrefs.DeleteKey("lvlselectbutton5");
        PlayerPrefs.DeleteKey("lvlselectbutton6");
        PlayerPrefs.DeleteKey("lvlselectbutton7");
        PlayerPrefs.DeleteKey("lvlselectbutton8");
    }
    public void toLevelMap4()
    {
        SceneManager.LoadScene("LevelMap4");
        PlayerPrefs.DeleteKey("lvlselectbutton1");
        PlayerPrefs.DeleteKey("lvlselectbutton2");
        PlayerPrefs.DeleteKey("lvlselectbutton3");
        PlayerPrefs.DeleteKey("lvlselectbutton4");
        PlayerPrefs.DeleteKey("lvlselectbutton5");
        PlayerPrefs.DeleteKey("lvlselectbutton6");
        PlayerPrefs.DeleteKey("lvlselectbutton7");
        PlayerPrefs.DeleteKey("lvlselectbutton8");
    }
    public void toLevelMap5()
    {
        SceneManager.LoadScene("LevelMap5");
        PlayerPrefs.DeleteKey("lvlselectbutton1");
        PlayerPrefs.DeleteKey("lvlselectbutton2");
        PlayerPrefs.DeleteKey("lvlselectbutton3");
        PlayerPrefs.DeleteKey("lvlselectbutton4");
        PlayerPrefs.DeleteKey("lvlselectbutton5");
        PlayerPrefs.DeleteKey("lvlselectbutton6");
        PlayerPrefs.DeleteKey("lvlselectbutton7");
        PlayerPrefs.DeleteKey("lvlselectbutton8");
    }
}
