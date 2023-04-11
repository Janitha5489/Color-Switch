using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private Button[] Buttons;
    private int m_UnlockedLevelsNumber;
    public GameObject M_ResetConfirmPannel;
    private readonly string m_LevelId = "LevelId";

    private void Awake()
    {
        for (int i = 0; i < Buttons.Length; i++)
        {
            Buttons[i].interactable = false;
        }
    }
    private void Start()
    {
        m_UnlockedLevelsNumber = PlayerPrefs.GetInt("Levels_Unlocked", 1);
        for (int i = 0; i < m_UnlockedLevelsNumber; i++)
        {
            Buttons[i].interactable = true;
        }
    }
    public void ResetConfirm()
    {
        M_ResetConfirmPannel.gameObject.SetActive(true);
    }
    public void ExitGame()
    {
        Application.Quit();
    }


    public void LoadLevel(int id)
    {
        PlayerPrefs.SetInt(m_LevelId, id);
        SceneChanger.LoadGameScene();
    }
}

