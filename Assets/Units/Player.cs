using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
	public string unitName;
	[SerializeField]
	public int currentLevel;
	[SerializeField]
	public int maxHP;
	[SerializeField]
	public int currentHP;
	[SerializeField]
	public int maxMana;
	[SerializeField]
    public int currentMana;
	[SerializeField]
	public int maxStamina;
	[SerializeField]
    public int currentStamina;
	[SerializeField]
	public int damage;
	[SerializeField]
	public int defense;
	[SerializeField]
    public int experience;
	[SerializeField]
    public int experienceToNextLevel;
    [SerializeField]
	public int upgradePoints;
    [SerializeField]
	public int coins;

	private void Start()
    {
        InitializeCharacter();
        
    }

	public void InitializeCharacter()
    {
		unitName = PlayerPrefs.GetString("PlayerName");

        if(currentLevel < 3)
        {
            PlayerPrefs.SetString("skillHeal", "false");
            PlayerPrefs.Save();
        }
        if(currentLevel < 5)
        {
            PlayerPrefs.SetString("skillFireball", "false");
            PlayerPrefs.Save(); 
        }

        if(PlayerPrefs.GetInt("maxHP") > 0)
        {
            maxHP = PlayerPrefs.GetInt("maxHP");
        }else{
            maxHP = (int)(100 * DifficultyManager.healthmultiplier);
            PlayerPrefs.SetInt("maxHP", maxHP);
            PlayerPrefs.Save();
        }
        currentHP = maxHP;
        if(PlayerPrefs.GetInt("maxMana") > 0)
        {
            maxMana = PlayerPrefs.GetInt("maxMana");
        }else{
            maxMana = (int)(100 * DifficultyManager.manamultiplier);
            PlayerPrefs.SetInt("maxMana", maxMana);
            PlayerPrefs.Save();
        }
        currentMana = maxMana;
        if(PlayerPrefs.GetInt("damage") > 0)
        {
            damage = PlayerPrefs.GetInt("damage");
        }else{
            damage = (int)(15 * DifficultyManager.attackmultiplier);
            PlayerPrefs.SetInt("damage", damage);
            PlayerPrefs.Save();
        }
        //maxStamina = 100;
        //currentStamina = 100;
        if(PlayerPrefs.GetInt("exp") > 0)
        {
            experience = PlayerPrefs.GetInt("exp");
        }else{
            experience = 0;
            PlayerPrefs.SetInt("exp", experience);
            PlayerPrefs.Save();
        }
        if(PlayerPrefs.GetInt("lvl") > 0)
        {
            currentLevel = PlayerPrefs.GetInt("lvl");
        }else{
            currentLevel = 1;
            PlayerPrefs.SetInt("lvl", currentLevel);
            PlayerPrefs.Save();
        }
        defense = 3;
        experienceToNextLevel = CalculateExperienceForNextLevel(PlayerPrefs.GetInt("lvl"));
        
        if(PlayerPrefs.GetInt("upgradePoints") > 0)
        {
            upgradePoints = PlayerPrefs.GetInt("upgradePoints");
        }else{
            upgradePoints = 0;
            PlayerPrefs.SetInt("upgradePoints", upgradePoints);
            PlayerPrefs.Save();
        }
        if(PlayerPrefs.GetInt("coins") > 0)
        {
            coins = PlayerPrefs.GetInt("coins");
        }else{
            coins = 0;
            PlayerPrefs.SetInt("coins", coins);
            PlayerPrefs.Save();
        }
        
    }
	public void GainExperience(int amount)
    {
        experience += amount;
        if (experience >= experienceToNextLevel)
        {
            LevelUp();
        }
    }

    public void LevelUp()
    {
        currentLevel++;
        upgradePoints++;
        PlayerPrefs.SetInt("upgradePoints", upgradePoints);
        PlayerPrefs.Save();
        if(currentLevel >= 3)
        {
            PlayerPrefs.SetString("skillHeal", "true");
            PlayerPrefs.Save(); 
        }
        if(currentLevel >= 5)
        {
            PlayerPrefs.SetString("skillFireball", "true");
            PlayerPrefs.Save(); 
        }
        experience -= experienceToNextLevel;
        experienceToNextLevel = CalculateExperienceForNextLevel(currentLevel);
        
    }
    private int CalculateExperienceForNextLevel(int level)
    {
        return level * 100;
    }

	public bool TakeDamage(int dmg)
	{
		currentHP -= dmg;

		if (currentHP <= 0)
		{
			currentHP = 0;
			return true;
		}else{
			return false;
		}

	}

    public bool TakeStrongDamage(int dmg)
	{
		currentHP -= dmg + 3;

		if (currentHP <= 0)
		{
			currentHP = 0;
			return true;
		}else{
			return false;
		}

	}

    public bool TakeMagicDamage(int dmg)
	{
		currentHP -= dmg + 7;

		if (currentHP <= 0)
		{
			currentHP = 0;
			return true;
		}else{
			return false;
		}

	}

	public void Heal(int amount)
	{
		currentHP += amount;
		if (currentHP > maxHP)
			currentHP = maxHP;
	}
}
