using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelBTN : MonoBehaviour
{
    public int sceneIndex;
    public void OpenScene() 
    {
        SceneManager.LoadScene(sceneIndex);
        Time.timeScale = 1f;

    }
}
