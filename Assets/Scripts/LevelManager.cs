using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private Button[] Buttons;
    private int m_UnlockedLevelsNumber;
  private void Awake() {
        for (int i = 0; i < Buttons.Length; i++){
            Buttons[i].interactable = false;
        }
    }
    private void Start(){
        m_UnlockedLevelsNumber = PlayerPrefs.GetInt("Levels Unlocked", 0);
        for(int i=0;i <= m_UnlockedLevelsNumber; i++){
            Buttons[i].interactable = true;
        }
    }
}









   /* private void Update()
    {
        unlockedLevelsNumber = PlayerPrefs.GetInt("LevelsUnlocked");
        for (int i = 0; i < unlockedLevelsNumber; i++) 
        {
            buttons[i].interactable = true;
        }
    }*/



    /*int levelUnlocked;

    public Button[] LevelButtons;
    private int i;

    // Start is called before the first frame update
    private void Awake()
    {
        int ReachedLevel = PlayerPrefs.GetInt("ReachLevel", 1);
        if (PlayerPrefs.GetInt("Level") >= 10)
        {
            ReachedLevel = PlayerPrefs.GetInt("Level");
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
    void update()
    {

    }*/
