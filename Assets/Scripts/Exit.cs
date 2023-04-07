using UnityEngine;
public class Exit : MonoBehaviour{
    public GameObject ExitConfirmPanel;

    public void ExitGame(){
        Debug.Log("ExitGame");
        Application.Quit();
    }

    public void ExitConfirm() {
        Debug.Log("Exit Confirm MSG");
        ExitConfirmPanel.gameObject.SetActive(true);
    } 
    
}