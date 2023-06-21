using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelFailed : MonoBehaviour
{
    public GameObject levelfailPanel;
    public TMP_Text messageText;
    public Button continueButton;

    private void Start()
    {
        HideWindow();
    }

    public void ShowWindow(string message)
    {
        levelfailPanel.SetActive(true);
        messageText.text = message;
    }

    public void HideWindow()
    {
        levelfailPanel.SetActive(false);
    }

    public void toLevelMap1()
    {
        PlayerPrefs.DeleteKey("exp");
        PlayerPrefs.DeleteKey("lvl");
        PlayerPrefs.DeleteKey("maxHP");
        PlayerPrefs.DeleteKey("maxMana");
        PlayerPrefs.DeleteKey("damage");
        PlayerPrefs.DeleteKey("lvlselectbutton1");
        PlayerPrefs.DeleteKey("lvlselectbutton2");
        PlayerPrefs.DeleteKey("lvlselectbutton3");
        PlayerPrefs.DeleteKey("lvlselectbutton4");
        PlayerPrefs.DeleteKey("lvlselectbutton5");
        PlayerPrefs.DeleteKey("lvlselectbutton6");
        PlayerPrefs.DeleteKey("lvlselectbutton7");
        PlayerPrefs.DeleteKey("lvlselectbutton8");
        SceneManager.LoadScene("LevelMap1");
    }
}
