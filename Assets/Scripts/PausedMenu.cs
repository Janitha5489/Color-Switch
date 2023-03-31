using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedMenu : MonoBehaviour
{
    public bool GameIsPaused;
    public static event Action<bool> OnResume;
    public GameObject gameIsResum;
    public GameObject pauseBTN;
    public GameObject Ball;
public void PauseGame() {
        if (!GameIsPaused){
            GameIsPaused = true;
            OnResume.Invoke(false);
            Time.timeScale = 0f;
            Debug.Log("pausemenuOpen");
            pauseBTN.gameObject.SetActive(true);    
        }
        else {
            Time.timeScale = 1;
            OnResume?.Invoke(true);
            pauseBTN.gameObject.SetActive(false);
            GameIsPaused =false;    
        }
    }
    public void RestartGame(){
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }  
}
