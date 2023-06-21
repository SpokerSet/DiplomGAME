using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstallCustom : MonoBehaviour
{
    public SpriteRenderer head;
	public SpriteRenderer leftleg;
	public SpriteRenderer rightleg;
    public SpriteRenderer hair;
    public SpriteRenderer eyes;
    public SpriteRenderer armor;
	public Color white;
    public Color black;
    public Sprite[] optionsHair;
    public Sprite[] optionsEyes;
    public Sprite[] optionsArmor;
    public int indexHair;
    public int indexEyes;
    public int indexArmor = 0;
    

    public void InstCustomColor()
	{
		int whatColor = PlayerPrefs.GetInt("whatColor");
		if(whatColor == 1){
            head.color = white;
            leftleg.color = white;
            rightleg.color = white;
        }else if(whatColor == 2){
            head.color = black;
            leftleg.color = black;
            rightleg.color = black;
        }
	}

    public void InstCustomParts()
	{
        int indexHair = PlayerPrefs.GetInt("HairIndex");
        int indexEyes = PlayerPrefs.GetInt("EyesIndex");
        int indArmor = PlayerPrefs.GetInt("indexArmor");
        hair.sprite = optionsHair[indexHair];
        eyes.sprite = optionsEyes[indexEyes];
        armor.sprite = optionsArmor[indArmor];
	}

    public void InstArmor1()
    {
        armor.sprite = optionsArmor[0];
        indexArmor = 0;
        PlayerPrefs.SetInt("indexArmor", indexArmor);
        PlayerPrefs.Save();
    }
    public void InstArmor2()
    {
        armor.sprite = optionsArmor[1];
        indexArmor = 1;
        PlayerPrefs.SetInt("indexArmor", indexArmor);
        PlayerPrefs.Save();
    }
    public void InstArmor3()
    {
        armor.sprite = optionsArmor[2];
        indexArmor = 2;
        PlayerPrefs.SetInt("indexArmor", indexArmor);
        PlayerPrefs.Save();
    }
    public void InstArmor4()
    {
        armor.sprite = optionsArmor[3];
        indexArmor = 3;
        PlayerPrefs.SetInt("indexArmor", indexArmor);
        PlayerPrefs.Save();
    }
    public void InstArmor5()
    {
        armor.sprite = optionsArmor[4];
        indexArmor = 4;
        PlayerPrefs.SetInt("indexArmor", indexArmor);
        PlayerPrefs.Save();
    }
}
