using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleSystem : MonoBehaviour
{
	public InstallCustom installPlayer;
	public Button image1;
	public Button image2;
	public Button image3;
	public Button image4;

	private int clickCount1;
	private int clickCount2;
	private int clickCount3;
	private int clickCount4;

	public GameObject playerPrefab;
	public GameObject enemyPrefab;

	public Transform playerBattleStation;
	public Transform enemyBattleStation;

	Player playerUnit;
	Enemy enemyUnit;

	public TMP_Text dialogueText;

	public BattleHUD playerHUD;
	public BattleHUD enemyHUD;

	public BattleState state;

	public LevelCompletion levelCompletion;
	public LevelFailed levelFailed;
	public Button[] skillsButtons;

    void Start()
    {
		state = BattleState.START;
		image1.onClick.AddListener(OnAttackButton);
		image2.onClick.AddListener(OnStrongAttackButton);
		image3.onClick.AddListener(OnMagicAttackButton);
		StartCoroutine(SetupBattle());
    }

	void Update()
	{
		
		// if(PlayerPrefs.GetString("skillHeal") == "true")
        // {
        //     skillsButtons[0].interactable = true;
        // }
		// if(PlayerPrefs.GetString("skillFireball") == "true")
        // {
        //     skillsButtons[1].interactable = true;
        // }
		if(playerUnit.currentLevel >= 3)
        {
            skillsButtons[0].interactable = true;
        }
		if(playerUnit.currentLevel >= 5)
        {
            skillsButtons[1].interactable = true;
        }
	}

	IEnumerator SetupBattle()
	{
		GameObject playerGO = Instantiate(playerPrefab, playerBattleStation);
		installPlayer.InstCustomColor();
		installPlayer.InstCustomParts();
		playerUnit = playerGO.GetComponent<Player>();

		GameObject enemyGO = Instantiate(enemyPrefab, enemyBattleStation);
		enemyUnit = enemyGO.GetComponent<Enemy>();

		yield return new WaitForSeconds(1f);

		enemyHUD.SetHUDenemy(enemyUnit);
		playerHUD.SetHUDhero(playerUnit);
		
		dialogueText.text = "Начало сражения...";

		yield return new WaitForSeconds(1f);

		state = BattleState.PLAYERTURN;
		PlayerTurn();
	}

	IEnumerator EnemyTurn()
	{
		
		dialogueText.text = enemyUnit.unitName + " будет атаковать!";

		yield return new WaitForSeconds(1f);

		int randomNumber = Random.Range(1, 4);
		bool isDead;
		switch(randomNumber)
		{
			case 1:
				
				enemyPrefab.GetComponent<Animator>().Play("attack");
				dialogueText.text = "Атака врага!";
				isDead = playerUnit.TakeDamage(enemyUnit.damage);

				playerHUD.SetHP(playerUnit.currentHP);
				playerHUD.UpdateHealthDisplay(playerUnit);

				yield return new WaitForSeconds(1f);

				if(isDead)
				{
					playerPrefab.GetComponent<Animator>().Play("player_die");
					state = BattleState.LOST;
					EndBattle();
				} else
				{
					state = BattleState.PLAYERTURN;
					PlayerTurn();
				}
				break;
			case 2:
				
				enemyPrefab.GetComponent<Animator>().Play("attack");
				dialogueText.text = "Сильная атака врага!";
				isDead = playerUnit.TakeStrongDamage(enemyUnit.damage);

				playerHUD.SetHP(playerUnit.currentHP);
				playerHUD.UpdateHealthDisplay(playerUnit);

				yield return new WaitForSeconds(1f);

				if(isDead)
				{
					playerPrefab.GetComponent<Animator>().Play("player_die");
					state = BattleState.LOST;
					EndBattle();
				} else
				{
					state = BattleState.PLAYERTURN;
					PlayerTurn();
				}
				break;
			case 3:
				
				enemyPrefab.GetComponent<Animator>().Play("attack");
				dialogueText.text = "Магическая атака врага!";
				isDead = playerUnit.TakeMagicDamage(enemyUnit.damage);

				enemyUnit.currentMana -= 20;
				enemyHUD.SetMana(enemyUnit.currentMana);
				enemyHUD.UpdateManaDisplay(enemyUnit);
				playerHUD.SetHP(playerUnit.currentHP);
				playerHUD.UpdateHealthDisplay(playerUnit);

				yield return new WaitForSeconds(1f);

				if(isDead)
				{
					playerPrefab.GetComponent<Animator>().Play("player_die");
					state = BattleState.LOST;
					EndBattle();
				} else
				{
					state = BattleState.PLAYERTURN;
					PlayerTurn();
				}
				break;
		}
	}

	void PlayerTurn()
	{
		clickCount1 = 0;
		clickCount2 = 0;
		clickCount3 = 0;
		image1.interactable = true;
		image2.interactable = true;
		image3.interactable = true;
		image4.interactable = true;
		dialogueText.text = "Выберите действие:";
	}

	void EndBattle()
	{
		if(state == BattleState.WON)
		{
			dialogueText.text = "Ты победил!";
			Victory();
		} else if (state == BattleState.LOST)
		{
			dialogueText.text = "Ты проиграл";
			Lose();
		}
	}

	IEnumerator PlayerAttack()
	{
		
		enemyPrefab.GetComponent<Animator>().Play("hurt");
		
		bool isDead = enemyUnit.TakeDamage(playerUnit.damage);
		
		enemyHUD.SetHP(enemyUnit.currentHP);
		enemyHUD.UpdateHealthDisplay(enemyUnit);

		dialogueText.text = "Успешная атака!";

		yield return new WaitForSeconds(2f);

		if(isDead)
		{
			//enemyPrefab.GetComponent<Animator>().Play("die");
			state = BattleState.WON;
			EndBattle();
		} else
		{
			state = BattleState.ENEMYTURN;
			StartCoroutine(EnemyTurn());
		}
	}

	IEnumerator PlayerStrongAttack()
	{
		enemyPrefab.GetComponent<Animator>().Play("hurt");
		bool isDead = enemyUnit.TakeStrongDamage(playerUnit.damage);

		enemyHUD.SetHP(enemyUnit.currentHP);
		enemyHUD.UpdateHealthDisplay(enemyUnit);
		dialogueText.text = "Успешная сильная атака!";

		yield return new WaitForSeconds(2f);

		if(isDead)
		{
			//enemyPrefab.GetComponent<Animator>().Play("die");
			state = BattleState.WON;
			EndBattle();
		} else
		{
			state = BattleState.ENEMYTURN;
			StartCoroutine(EnemyTurn());
		}
	}

	IEnumerator PlayerMagicAttack()
	{
		enemyPrefab.GetComponent<Animator>().Play("hurt");
		bool isDead = enemyUnit.TakeMagicDamage(playerUnit.damage);
		
		if(playerUnit.currentMana >= 20){
			playerUnit.currentMana -= 20;
		}else{
			playerUnit.currentMana -= 20;
			playerUnit.currentMana = 0;
		}
		
		playerHUD.SetMana(playerUnit.currentMana);
		playerHUD.UpdateManaDisplay(playerUnit);
		enemyHUD.SetHP(enemyUnit.currentHP);
		enemyHUD.UpdateHealthDisplay(enemyUnit);
		
		dialogueText.text = "Успешная магическая атака!";

		yield return new WaitForSeconds(2f);

		if(isDead)
		{
			//enemyPrefab.GetComponent<Animator>().Play("die");
			state = BattleState.WON;
			EndBattle();
		} else
		{
			state = BattleState.ENEMYTURN;
			StartCoroutine(EnemyTurn());
		}
	}

	IEnumerator PlayerHeal()
	{
		playerUnit.Heal(25);

		playerHUD.SetHP(playerUnit.currentHP);
		playerUnit.currentMana -= 15;
		playerHUD.SetMana(playerUnit.currentMana);
		playerHUD.UpdateHealthDisplay(playerUnit);
		playerHUD.UpdateManaDisplay(playerUnit);
		dialogueText.text = "Ты чувствуешь прилив жизни!";

		yield return new WaitForSeconds(2f);

		state = BattleState.ENEMYTURN;
		StartCoroutine(EnemyTurn());
	}

	IEnumerator PlayerFireball()
	{
		bool isDead = enemyUnit.TakeMagicDamage(30);
		
		if(playerUnit.currentMana >= 20){
			playerUnit.currentMana -= 20;
		}else{
			playerUnit.currentMana -= 20;
			playerUnit.currentMana = 0;
		}
		
		playerHUD.SetMana(playerUnit.currentMana);
		playerHUD.UpdateManaDisplay(playerUnit);
		enemyHUD.SetHP(enemyUnit.currentHP);
		enemyHUD.UpdateHealthDisplay(enemyUnit);
		
		dialogueText.text = "Успешная атака Огненным шаром!";

		yield return new WaitForSeconds(2f);

		if(isDead)
		{
			//enemyPrefab.GetComponent<Animator>().Play("die");
			state = BattleState.WON;
			EndBattle();
		} else
		{
			state = BattleState.ENEMYTURN;
			StartCoroutine(EnemyTurn());
		}
	}

	public void OnAttackButton()
	{
		playerPrefab.GetComponent<Animator>().Play("player_attack");
		clickCount1++;
		if(clickCount1 == 1)
		{
			image1.interactable = false;
			image2.interactable = false;
			image3.interactable = false;
			image4.interactable = false;
		}

		if (state != BattleState.PLAYERTURN)
			return;

		StartCoroutine(PlayerAttack());
	}

	public void OnStrongAttackButton()
	{
		playerPrefab.GetComponent<Animator>().Play("player_attack");
		clickCount2++;
		if(clickCount2 == 1)
		{
			image1.interactable = false;
			image2.interactable = false;
			image3.interactable = false;
			image4.interactable = false;
		}
		
		if (state != BattleState.PLAYERTURN)
			return;

		StartCoroutine(PlayerStrongAttack());
	}

	public void OnMagicAttackButton()
	{
		playerPrefab.GetComponent<Animator>().Play("player_attack");
		clickCount3++;
		if(clickCount3 == 1)
		{
			image1.interactable = false;
			image2.interactable = false;
			image3.interactable = false;
			image4.interactable = false;
		}

		if (state != BattleState.PLAYERTURN)
			return;

		StartCoroutine(PlayerMagicAttack());
	}

	public void OnHealButton()
	{
		if (state != BattleState.PLAYERTURN)
			return;
		if(playerUnit.currentLevel >= 3)
        {
            StartCoroutine(PlayerHeal());
        }
	}
	public void OnFiraballButton()
	{
		if (state != BattleState.PLAYERTURN)
			return;
		if(playerUnit.currentLevel >= 5)
        {
            StartCoroutine(PlayerFireball());
        }
	}

	public void Victory()
    {
		levelCompletion.ShowWindow("Победа! Уровень пройден!");
    }

	public void Lose()
    {
		levelFailed.ShowWindow("Ты проиграл!");
    }

}
