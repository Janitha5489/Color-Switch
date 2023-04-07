using TMPro;
using UnityEngine;

public class InputName : MonoBehaviour
{
    public string theName;
    public TMP_InputField inputField;
    public TextMeshProUGUI textDisplay;
    public GameObject PlayerNameP;
    /*public GameObject PlayerNP;*/
    private void Awake()
    {
        if (!PlayerPrefs.HasKey("player_name"))
        {
            PlayerNameP.gameObject.SetActive(true);

        }
        else {
            string playerN = PlayerPrefs.GetString("player_name", "player");
            textDisplay.text = "Hi " + playerN + " ...";
        }
            

    }
    public void PlayerName()
    {
        theName = inputField.text;
            PlayerPrefs.SetString("player_name", theName);
            string playerN = PlayerPrefs.GetString("player_name", "player");
            textDisplay.text = "Hi " + playerN + " ...";
            PlayerNameP.gameObject.SetActive(false);

    }
    /*public void PlayerNPc() {
        Debug.Log("Reset confirm MSG");
        PlayerNP.gameObject.SetActive(true);
    }*/
    
}
