using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelCompletion : MonoBehaviour
{
    public GameObject levelcompPanel;
    public TMP_Text messageText;
    public TMP_Text experienceText;
    public TMP_Text levelText;
    public TMP_Text coinsText;
    public Button continueButton;
    public Player unitStats;
    public int experienceReward = 200;
    public int coinsReward = 50;

    private void Start()
    {
        HideWindow();
    }

    public void ShowWindow(string message)
    {
        levelcompPanel.SetActive(true);
        messageText.text = message;
        unitStats.GainExperience((int)(experienceReward * DifficultyManager.rewardmultiplier));
        unitStats.coins += (int)(coinsReward * DifficultyManager.rewardmultiplier);

        experienceText.text = "Опыт: " + unitStats.experience.ToString() + " / " + unitStats.experienceToNextLevel.ToString();
        levelText.text = "Уровень: " + unitStats.currentLevel.ToString();
        coinsText.text = "Монеты: " + unitStats.coins.ToString();
    }

    public void HideWindow()
    {
        levelcompPanel.SetActive(false);
    }

    public void StartToLevelMap1()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton1", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton2", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton3", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap1");
    }
    public void UpperFightToLevelMap1()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton7", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton2", "false");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton3", "false");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap1");
    }
    public void MiddleFight1ToLevelMap1()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton4", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton1", "false");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton3", "false");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap1");
    }
    public void MiddleFight2ToLevelMap1()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton7", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap1");
    }
    public void UnderFight1ToLevelMap1()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton5", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton1", "false");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton2", "false");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap1");
    }
    public void UnderFight2ToLevelMap1()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton6", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap1");
    }
    public void UnderFight3ToLevelMap1()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton7", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap1");
    }
    public void CampToLevelMap1()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton8", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap1");
    }
    public void Boss1ToMap2()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("mapselectbutton2", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("mapstorybutton1", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap1");
    }



    public void StartToLevelMap2()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton1", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton2", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton3", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap2");
    }
    public void UpperFightToLevelMap2()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton7", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton2", "false");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton3", "false");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap2");
    }
    public void MiddleFight1ToLevelMap2()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton4", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton1", "false");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton3", "false");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap2");
    }
    public void MiddleFight2ToLevelMap2()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton7", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap2");
    }
    public void UnderFight1ToLevelMap2()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton5", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton1", "false");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton2", "false");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap2");
    }
    public void UnderFight2ToLevelMap2()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton6", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap2");
    }
    public void UnderFight3ToLevelMap2()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton7", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap2");
    }
    public void CampToLevelMap2()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton8", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap2");
    }
    public void Boss1ToMap3()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("mapselectbutton3", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("mapstorybutton2", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap2");
    }




    public void StartToLevelMap3()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton1", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton2", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton3", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap3");
    }
    public void UpperFightToLevelMap3()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton7", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton2", "false");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton3", "false");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap3");
    }
    public void MiddleFight1ToLevelMap3()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton4", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton1", "false");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton3", "false");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap3");
    }
    public void MiddleFight2ToLevelMap3()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton7", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap3");
    }
    public void UnderFight1ToLevelMap3()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton5", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton1", "false");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton2", "false");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap3");
    }
    public void UnderFight2ToLevelMap3()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton6", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap3");
    }
    public void UnderFight3ToLevelMap3()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton7", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap3");
    }
    public void CampToLevelMap3()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton8", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap3");
    }
    public void Boss1ToMap4()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("mapselectbutton4", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("mapstorybutton3", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap3");
    }





    public void StartToLevelMap4()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton1", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton2", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton3", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap4");
    }
    public void UpperFightToLevelMap4()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton7", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton2", "false");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton3", "false");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap4");
    }
    public void MiddleFight1ToLevelMap4()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton4", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton1", "false");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton3", "false");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap4");
    }
    public void MiddleFight2ToLevelMap4()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton7", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap4");
    }
    public void UnderFight1ToLevelMap4()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton5", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton1", "false");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton2", "false");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap4");
    }
    public void UnderFight2ToLevelMap4()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton6", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap4");
    }
    public void UnderFight3ToLevelMap4()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton7", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap4");
    }
    public void CampToLevelMap4()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton8", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap4");
    }
    public void Boss1ToMap5()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("mapselectbutton5", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("mapstorybutton4", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap4");
    }




    public void StartToLevelMap5()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton1", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton2", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton3", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap5");
    }
    public void UpperFightToLevelMap5()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton7", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton2", "false");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton3", "false");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap5");
    }
    public void MiddleFight1ToLevelMap5()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton4", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton1", "false");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton3", "false");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap5");
    }
    public void MiddleFight2ToLevelMap5()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton7", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap5");
    }
    public void UnderFight1ToLevelMap5()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton5", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton1", "false");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton2", "false");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap5");
    }
    public void UnderFight2ToLevelMap5()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton6", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap5");
    }
    public void UnderFight3ToLevelMap5()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton7", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap5");
    }
    public void CampToLevelMap5()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("lvlselectbutton8", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap5");
    }
    public void Boss1ToMap6()
    {
        PlayerPrefs.SetInt("coins", unitStats.coins);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("exp", unitStats.experience);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("lvl", unitStats.currentLevel);
        PlayerPrefs.Save();
        PlayerPrefs.SetString("mapselectbutton5", "true");
        PlayerPrefs.Save();
        PlayerPrefs.SetString("mapstorybutton5", "true");
        PlayerPrefs.Save();
        SceneManager.LoadScene("LevelMap5");
    }

}
