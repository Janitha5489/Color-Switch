using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public int LevelToUnlock;
    private int NumberOfUnlockedLevels;
    public void UnlockNextLevel() {
        NumberOfUnlockedLevels = PlayerPrefs.GetInt("Levels_Unlocked");
        Debug.Log(NumberOfUnlockedLevels <= LevelToUnlock);
        if (NumberOfUnlockedLevels < LevelToUnlock)
        { 
            PlayerPrefs.SetInt("Levels_Unlocked", NumberOfUnlockedLevels + 1);
        }
        SceneManager.LoadScene("LevelManager");
    }
    public void Scene1(){
        SceneManager.LoadScene("LevelManager");
    }
    public void Scene2() {
        SceneManager.LoadScene("Home");
        Time.timeScale = 1.0f;
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1.0f;
    }
}

