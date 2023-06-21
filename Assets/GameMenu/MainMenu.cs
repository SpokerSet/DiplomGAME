using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        PlayerPrefs.DeleteKey("lvlselectbutton1");
        PlayerPrefs.DeleteKey("lvlselectbutton2");
        PlayerPrefs.DeleteKey("lvlselectbutton3");
        PlayerPrefs.DeleteKey("lvlselectbutton4");
        PlayerPrefs.DeleteKey("lvlselectbutton5");
        PlayerPrefs.DeleteKey("lvlselectbutton6");
        PlayerPrefs.DeleteKey("lvlselectbutton7");
        PlayerPrefs.DeleteKey("lvlselectbutton8");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    
}
