using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BattleHUD : MonoBehaviour
{
	[SerializeField]
	public TMP_Text nameText;
	[SerializeField]
	public TMP_Text levelText;
	[SerializeField]
	public TMP_Text XPText;
	[SerializeField]
	public TMP_Text ManaText;
	[SerializeField]
	public TMP_Text StaminaText;
	[SerializeField]
	public Slider hpSlider;
	[SerializeField]
	public Slider manaSlider;
	[SerializeField]
	public Slider staminaSlider;


	public void SetHUDhero(Player unit)
	{
		nameText.text = unit.unitName;
		levelText.text = "Lvl " + unit.currentLevel;
		XPText.text = string.Format("{0}/{1}", unit.currentHP, unit.maxHP);
		ManaText.text = string.Format("{0}/{1}", unit.currentMana, unit.maxMana);
		//StaminaText.text = string.Format("{0}/{1}", unit.currentStamina, unit.maxStamina);
		hpSlider.maxValue = unit.maxHP;
		hpSlider.value = unit.currentHP;
		manaSlider.maxValue = unit.maxMana;
		manaSlider.value = unit.currentMana;
		//staminaSlider.maxValue = unit.maxStamina;
		//staminaSlider.value = unit.currentStamina;
	}

	public void SetHUDenemy(Enemy unit)
	{
		nameText.text = unit.unitName;
		levelText.text = "Lvl " + unit.currentLevel;
		XPText.text = string.Format("{0}/{1}", unit.currentHP, unit.maxHP);
		ManaText.text = string.Format("{0}/{1}", unit.currentMana, unit.maxMana);
		//StaminaText.text = string.Format("{0}/{1}", unit.currentStamina, unit.maxStamina);
		hpSlider.maxValue = unit.maxHP;
		hpSlider.value = unit.currentHP;
		manaSlider.maxValue = unit.maxMana;
		manaSlider.value = unit.currentMana;
		//staminaSlider.maxValue = unit.maxStamina;
		//staminaSlider.value = unit.currentStamina;
	}

	public void SetHP(int hp)
	{
		hpSlider.value = hp;
	}

	public void SetMana(int mana)
	{
		manaSlider.value = mana;
	}

	public void SetStamina(int stamina)
	{
		staminaSlider.value = stamina;
	}

	public void UpdateHealthDisplay(Player unit)
    {
		nameText.text = unit.unitName;
        hpSlider.maxValue = unit.maxHP;
        hpSlider.value = unit.currentHP;
        XPText.text = string.Format("{0}/{1}", unit.currentHP, unit.maxHP);
    }

	public void UpdateManaDisplay(Player unit)
    {
		nameText.text = unit.unitName;
        manaSlider.maxValue = unit.maxMana;
        manaSlider.value = unit.currentMana;
        ManaText.text = string.Format("{0}/{1}", unit.currentMana, unit.maxMana);
    }

	public void UpdateStaminaDisplay(Player unit)
    {
        staminaSlider.maxValue = unit.maxStamina;
        staminaSlider.value = unit.currentStamina;
        StaminaText.text = string.Format("{0}/{1}", unit.currentStamina, unit.maxStamina);
    }

	public void UpdateHealthDisplay(Enemy unit)
    {
        hpSlider.maxValue = unit.maxHP;
        hpSlider.value = unit.currentHP;
        XPText.text = string.Format("{0}/{1}", unit.currentHP, unit.maxHP);
    }

	public void UpdateManaDisplay(Enemy unit)
    {
        manaSlider.maxValue = unit.maxMana;
        manaSlider.value = unit.currentMana;
        ManaText.text = string.Format("{0}/{1}", unit.currentMana, unit.maxMana);
    }

	public void UpdateStaminaDisplay(Enemy unit)
    {
        staminaSlider.maxValue = unit.maxStamina;
        staminaSlider.value = unit.currentStamina;
        StaminaText.text = string.Format("{0}/{1}", unit.currentStamina, unit.maxStamina);
    }
	

}
