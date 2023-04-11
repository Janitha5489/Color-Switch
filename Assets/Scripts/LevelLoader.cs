using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    public List<GameObject> Levels = new List<GameObject>();

    [SerializeField]
    private GameObject LevelParent;

    private string LevelId = "LevelId";
    public static int ThisLevel;


    private void Awake()
    {
        if (PlayerPrefs.HasKey(LevelId))
        {
            ThisLevel = PlayerPrefs.GetInt(LevelId, 0) - 1;
        }
        else
        {

            ThisLevel = PlayerPrefs.GetInt(LevelId, 0);
        }
        LoadLevel(ThisLevel);
    }

    private void LoadLevel(int levelNumber)
    {
        Instantiate(Levels[levelNumber], LevelParent.transform);
    }
}
