using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class CastomChanger : MonoBehaviour
{
    public GameObject character;
    [Header("Sprite To Change")]
    public SpriteRenderer bodyPart;

    [Header("Sprites to Cycle Through")]
    public List<Sprite> options = new List<Sprite>();

    public int currentOption = 0;
    public void NextOption()
    {
        currentOption++;
        if(currentOption >= options.Count)
        {
            currentOption = 0;
        }
        bodyPart.sprite = options[currentOption];
    }

    public void PreviousOption()
    {
        currentOption--;
        if(currentOption <= 0)
        {
            currentOption = options.Count - 1;
        }
        bodyPart.sprite = options[currentOption];
    }

    public void Submit()
    {
        //PrefabUtility.SaveAsPrefabAsset(character, "Assets/CharacterCreation/NewPlayer/Player.prefab");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
