using UnityEngine;

public class Rotator : MonoBehaviour {

	public bool isrotate;
	public float speed = 100f;
    private void Awake(){
        isrotate = true;
    }
    private void OnEnable(){
		Player.OnPouse += OnPouse;
    }
    private void OnDisable(){
		Player.OnPouse -= OnPouse;
            }
    private void OnPouse(bool b){
         isrotate = b;  
    }
    void Update () {
		if (!isrotate)
		{
			return;
		}
		transform.Rotate(0f, 0f,-speed * Time.deltaTime);
	}
}
