using TMPro;
using UnityEngine;


public class Counter : MonoBehaviour
{
    [SerializeField]
    private TMP_Text MyscoreText;
    private int ScoreNum;
    void Start(){
        ScoreNum = 0; 
    }
    private void OnTriggerEnter2D(Collider2D ScoreCount) {
        if (ScoreCount.tag == "ScoreCount") {
            ScoreNum += 1;
            Destroy(ScoreCount.gameObject);
            MyscoreText.text = "" + ScoreNum;
        }
   }
}
