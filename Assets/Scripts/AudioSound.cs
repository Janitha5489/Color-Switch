using UnityEngine;
public class AudioSound : MonoBehaviour{
    public static AudioClip JumpSound, WinSound, FailSound,bgsound;

    static AudioSource audiosrc;
    void Start(){
        JumpSound = Resources.Load<AudioClip>("jump");
        WinSound = Resources.Load<AudioClip>("win");
        FailSound = Resources.Load<AudioClip>("dead");
        bgsound = Resources.Load<AudioClip>("bg");

        audiosrc = GetComponent<AudioSource>();
    }
    public static void playSound (string clip){
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

