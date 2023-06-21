using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
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

    private void Start()
    {
        //InitializeCharacter();
    }

	// public void InitializeCharacter()
    // {
    //     maxHP = (int)(100 * DifficultyManager.enemyhealthmultiplier);
    //     currentHP = maxHP;
    //     maxMana = 100;
    //     currentMana = 100;
    //     //maxStamina = 100;
    //     //currentStamina = 100;
    //     damage = (int)(10 * DifficultyManager.enemyattackmultiplier);
    //     defense = 5;
    // }


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
}
