using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class UpdateStats : MonoBehaviour
{
    public TMP_Text unitname;
    public TMP_Text experienceText;
    public TMP_Text levelText;
    public TMP_Text upgradePointsText;

    public TMP_Text XPtext;
    public TMP_Text Manatext;
    public TMP_Text Attacktext;
    public Player unitStats;

    void Update()
    {
        ShowWindow();
    }

    public void ShowWindow()
    {

        unitname.text = "Имя: " + PlayerPrefs.GetString("PlayerName");
        
        experienceText.text = "Опыт: " + PlayerPrefs.GetInt("exp").ToString() + " / " + unitStats.experienceToNextLevel.ToString();
        levelText.text = "Уровень: " + PlayerPrefs.GetInt("lvl").ToString();
        upgradePointsText.text = "Очки прокачки: " + PlayerPrefs.GetInt("upgradePoints").ToString();

        XPtext.text = "Здоровье: " + PlayerPrefs.GetInt("maxHP").ToString() + " + 10";
        Manatext.text = "Магия: " + PlayerPrefs.GetInt("maxMana").ToString()+ " + 10";
        Attacktext.text = "Атака: " + PlayerPrefs.GetInt("damage").ToString()+ " + 5";
    }

    public void UpdateMaxHp()
    {
        if(PlayerPrefs.GetInt("upgradePoints") > 0)
        {
            unitStats.upgradePoints = PlayerPrefs.GetInt("upgradePoints");
            PlayerPrefs.SetInt("maxHP", PlayerPrefs.GetInt("maxHP") + 10);
            PlayerPrefs.Save();
            unitStats.upgradePoints--;
            PlayerPrefs.SetInt("upgradePoints", unitStats.upgradePoints);
            PlayerPrefs.Save();
        }
    }
    public void UpdateMaxMana()
    {
        if(PlayerPrefs.GetInt("upgradePoints") > 0)
        {
            unitStats.upgradePoints = PlayerPrefs.GetInt("upgradePoints");
            PlayerPrefs.SetInt("maxMana", PlayerPrefs.GetInt("maxMana") + 10);
            PlayerPrefs.Save();
            unitStats.upgradePoints--;
            PlayerPrefs.SetInt("upgradePoints", unitStats.upgradePoints);
            PlayerPrefs.Save();
        }
    }
    public void UpdateDamage()
    {
        if(PlayerPrefs.GetInt("upgradePoints") > 0)
        {
            unitStats.upgradePoints = PlayerPrefs.GetInt("upgradePoints");
            PlayerPrefs.SetInt("damage", PlayerPrefs.GetInt("damage") + 5);
            PlayerPrefs.Save();
            unitStats.upgradePoints--;
            PlayerPrefs.SetInt("upgradePoints", unitStats.upgradePoints);
            PlayerPrefs.Save();
        }
    }

}
