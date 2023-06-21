using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ChangingAppearence : MonoBehaviour
{
    public TMP_InputField input;
    string EmptyName;
    public SpriteRenderer hair;
    public SpriteRenderer eyes;
    public Sprite[] optionsHair;
    public Sprite[] optionsEyes;
    public int indexHair;
    public int indexEyes;
    public int indexArmor = 0;

    private void Start()
    {
        input.characterLimit = 10;
        input.onValueChanged.AddListener(ValidateInput);
    }

    private void ValidateInput(string inputField)
    {
        string filteredValue = "";

        // Проходимся по каждому символу в строке и проверяем, является ли он буквенным символом
        foreach (char c in inputField)
        {
            if (char.IsLetter(c))
            {
                filteredValue += c;
            }
        }

        // Устанавливаем отфильтрованное значение в поле InputField
        input.text = filteredValue;
    }


    void Update()
    {
        if (string.IsNullOrEmpty(input.text))
        {
            EmptyName = "Empty";
        }else{
            EmptyName = "noup";
        }

        for (int i = 0; i < optionsHair.Length; i++)
        {
            if(i == indexHair)
            {
                hair.sprite = optionsHair[i];
            }
        }
        for (int i = 0; i < optionsEyes.Length; i++)
        {
            if(i == indexEyes)
            {
                eyes.sprite = optionsEyes[i];
            }
        }
    }

    public void SwapHair()
    {
        if(indexHair < optionsHair.Length - 1)
        {
            indexHair++;
        }else{
            indexHair = 0;
        }
    }

    public void SwapEyes()
    {
        if(indexEyes < optionsEyes.Length - 1)
        {
            indexEyes++;
        }else{
            indexEyes = 0;
        }
    }


    public void Submit()
    {
        string playerName = input.text;
        if(EmptyName == "Empty"){
            playerName = "Player";
        }
        PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("HairIndex", indexHair);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("EyesIndex", indexEyes);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("indexArmor", indexArmor);
        PlayerPrefs.Save();
        PlayerPrefs.DeleteKey("exp");
        PlayerPrefs.DeleteKey("lvl");
        PlayerPrefs.DeleteKey("maxHP");
        PlayerPrefs.DeleteKey("maxMana");
        PlayerPrefs.DeleteKey("damage");
        PlayerPrefs.DeleteKey("coins");
        PlayerPrefs.DeleteKey("mapstorybutton1");
        PlayerPrefs.DeleteKey("mapstorybutton2");
        PlayerPrefs.DeleteKey("mapstorybutton3");
        PlayerPrefs.DeleteKey("mapstorybutton4");
        PlayerPrefs.DeleteKey("mapstorybutton5");
        PlayerPrefs.DeleteKey("mapselectbutton2");
        PlayerPrefs.DeleteKey("mapselectbutton3");
        PlayerPrefs.DeleteKey("mapselectbutton4");
        PlayerPrefs.DeleteKey("mapselectbutton5");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
