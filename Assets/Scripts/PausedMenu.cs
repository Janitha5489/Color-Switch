using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedMenu : MonoBehaviour
{
    public bool GameIsPaused;
    public static event Action<bool> OnResume;
    public GameObject pauseBTN;
    public GameObject Ball;
    public List<Rotator> Rotators = new List<Rotator>();
    public void PauseGame()
    {

        if (!GameIsPaused)
        {
            GameIsPaused = true;
            OnResume.Invoke(false);
            foreach (var item in Rotators)
            {
                item.isrotate = false;
            }
            pauseBTN.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            OnResume?.Invoke(true);
            pauseBTN.SetActive(false);
            GameIsPaused = false;
        }
    }
    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
