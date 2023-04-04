using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelBTN : MonoBehaviour
{
    public int sceneIndex;
    public void OpenScene() 
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void DeleteAllDAta()
    {
        PlayerPrefs.DeleteAll();
        Application.LoadLevel("LevelManager");


    }
}
