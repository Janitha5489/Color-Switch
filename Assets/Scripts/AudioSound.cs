using UnityEngine;
public class AudioSound : MonoBehaviour{
    public static AudioClip JumpSound;
    public static AudioClip WinSound;
    public static AudioClip FailSound;
    public static AudioClip  BgSound;

    static AudioSource audiosrc;
    void Start()
    {
        JumpSound = Resources.Load<AudioClip>("jump");
        WinSound = Resources.Load<AudioClip>("win");
        FailSound = Resources.Load<AudioClip>("dead");
        BgSound = Resources.Load<AudioClip>("bg");
        audiosrc = GetComponent<AudioSource>();
    }
    public static void PlaySound (string clip){
        switch (clip) { 
            case "jump":
                audiosrc.PlayOneShot(JumpSound);
                break;
            case "win":
                audiosrc.PlayOneShot(WinSound);
                break;
            case "dead":
                audiosrc.PlayOneShot(FailSound);
                break;
        }
    }
}

