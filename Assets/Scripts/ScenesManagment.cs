using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScenesManagment : MonoBehaviour
{
   /* Button[] LevelButtons;

    // Start is called before the first frame update
    private void Awake()
    {
        int ReachedLevel = PlayerPrefs.GetInt("ReachedLevel", 1);
        if (PlayerPrefs.GetInt("Level") >= 2)
        {
            ReachedLevel = PlayerPrefs.GetInt("level");
        }

        LevelButtons = new Button[transform.childCount];
        for (int i = 0; i < LevelButtons.Length; i++)
        {
            LevelButtons[i] = transform.GetChild(i).GetComponent<Button>();
            LevelButtons[i].GetComponentInChildren<Text>().text = (i + 1).ToString();
            if (i + 1 > ReachedLevel)
            {
                LevelButtons[i].interactable = false;
            }

        }
    }
    public void LoadScene(int Level)
    {
        PlayerPrefs.SetInt("Level", Level);
        Application.LoadLevel("Loading");
    }
    void Update()
    {

    }

    public void nextlevel()
    {
        PlayerPrefs.SetInt("ReachedLevel", PlayerPrefs.GetInt("ReachedLevel") + 1);
        Application.LoadLevel("level");
    }*/
}


  
