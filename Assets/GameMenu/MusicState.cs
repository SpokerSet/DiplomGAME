using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicState : MonoBehaviour
{
    public Image musicButtonImage;
    public Sprite musicOnSprite;
    public Sprite musicOffSprite;

    public bool isMusicOn = true;

    private void Start()
    {
        // Загрузка сохраненного состояния музыки
        if (PlayerPrefs.HasKey("MusicState"))
        {
            int savedState = PlayerPrefs.GetInt("MusicState");
            isMusicOn = savedState == 1 ? true : false;
        }

        UpdateMusicButtonGraphics();
    }

    public void ToggleMusic()
    {
        // Переключение состояния музыки
        isMusicOn = !isMusicOn;

        // Обновление графики кнопки в соответствии с новым состоянием музыки
        UpdateMusicButtonGraphics();

        // Сохранение состояния музыки
        int musicState = isMusicOn ? 1 : 0;
        PlayerPrefs.SetInt("MusicState", musicState);
    }

    private void UpdateMusicButtonGraphics()
    {
        // Обновление графики кнопки в соответствии с состоянием музыки
        musicButtonImage.sprite = isMusicOn ? musicOnSprite : musicOffSprite;
    }
}
