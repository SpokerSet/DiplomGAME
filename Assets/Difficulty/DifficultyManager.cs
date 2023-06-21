using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultyManager : MonoBehaviour
{
    public enum DifficultyLevel
    {
        Easy,
        Normal,
        Hard
    }
    [SerializeField]
    public static float healthmultiplier;
    [SerializeField]
    public static float manamultiplier;
    [SerializeField]
    public static float enemyhealthmultiplier;
    [SerializeField]
    public static float attackmultiplier;
    [SerializeField]
    public static float enemyattackmultiplier;
    [SerializeField]
    public static float rewardmultiplier;
    [SerializeField]
    public DifficultyLevel currentDifficulty;

    public void SetDifficulty(DifficultyLevel difficulty)
    {
        currentDifficulty = difficulty;

        switch (currentDifficulty)
        {
            case DifficultyLevel.Easy:
                rewardmultiplier = 1.0f;
                healthmultiplier = 1.1f;
                manamultiplier = 1.1f;
                attackmultiplier = 1.1f;
                enemyhealthmultiplier = 1.0f;
                enemyattackmultiplier = 1.0f;
                break;

            case DifficultyLevel.Normal:
                rewardmultiplier = 1.1f;
                healthmultiplier = 1.0f;
                manamultiplier = 1.0f;
                attackmultiplier = 1.0f;
                enemyhealthmultiplier = 1.1f;
                enemyattackmultiplier = 1.1f;
                break;

            case DifficultyLevel.Hard:
                rewardmultiplier = 1.2f;
                healthmultiplier = 0.9f;
                manamultiplier = 0.9f;
                attackmultiplier = 0.9f;
                enemyhealthmultiplier = 1.2f;
                enemyattackmultiplier = 1.2f;
                break;
        }
    }

    public void OnEasyButton()
    {
        SetDifficulty(DifficultyLevel.Easy);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OnNormalButton()
    {
        SetDifficulty(DifficultyLevel.Normal);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OnHardButton()
    {
        SetDifficulty(DifficultyLevel.Hard);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
