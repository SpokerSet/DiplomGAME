using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void toBackScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void toNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void toBackScenetoMap2()
    {
        SceneManager.LoadScene("LevelMap2");
    }

    public void toSelectLevelMenu()
    {
        SceneManager.LoadScene("SelectLevelMenu");
    }
}
