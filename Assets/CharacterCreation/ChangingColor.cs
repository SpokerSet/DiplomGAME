using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangingColor : MonoBehaviour
{
    public GameObject panel;
    public Image squareHeadDisplay;
    public SpriteRenderer head;
    public SpriteRenderer leftLeg;
    public SpriteRenderer rightLeg;
    public int whatColor = 1;
    public Color white;
    public Color black;

    void Update()
    {
        squareHeadDisplay.color = head.color;

        if(whatColor == 1){
            head.color = white;
            leftLeg.color = white;
            rightLeg.color = white;
            PlayerPrefs.SetInt("whatColor", whatColor);
            PlayerPrefs.Save();
        }else if(whatColor == 2){
            head.color = black;
            leftLeg.color = black;
            rightLeg.color = black;
            PlayerPrefs.SetInt("whatColor", whatColor);
            PlayerPrefs.Save();
        }
    }

    public void OpenPanel()
    {
        panel.SetActive(true);
    }
    public void ClosePanel()
    {
        panel.SetActive(false);
    }

    public void ChangeHeadWhite()
    {
        whatColor = 1;
    }
    public void ChangeHeadBlack()
    {
        whatColor = 2;
    }
}
