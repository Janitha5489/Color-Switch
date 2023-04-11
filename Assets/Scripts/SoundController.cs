using UnityEngine;
using UnityEngine.UI;
public class SoundController : MonoBehaviour
{
    private Sprite m_SoundOnButton;
    private bool isOn = true;

    public AudioSource audioSource;
    public Sprite SoundOffButton;
    public Button button;
    private void Start()
    {
        m_SoundOnButton = button.image.sprite;
    }
    public void BUttonClicked()
    {
        if (isOn)
        {
            button.image.sprite = SoundOffButton;
            isOn = false;
            audioSource.mute = true;
        }
        else
        {
            button.image.sprite = m_SoundOnButton;
            isOn = true;
            audioSource.mute = false;
        }
    }
}
