using UnityEngine;
public class Exit : MonoBehaviour
{
    public GameObject ExitConfirmPanel;

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ExitConfirm()
    {
        ExitConfirmPanel.gameObject.SetActive(true);
    }

}