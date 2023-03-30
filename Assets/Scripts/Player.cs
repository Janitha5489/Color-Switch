using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class Player : MonoBehaviour 
{
	public static event Action<bool> OnPouse;
	public float jumpForce = 10f;

    public Rigidbody2D rb;
	public SpriteRenderer sr;

	public string currentColor;


	public Color colorCyan;
	public Color colorYellow;
	public Color colorMagenta;
	public Color colorPink;


	public GameObject gameoverpopup;
	public GameObject spikebar;
	public GameObject levelpasspopup;
	public ParticleSystem ParticleSystem;
	public GameObject jump;
    /*private GameObject gameCompletedMessage;*/

    private void Awake()
    {
		rb.gravityScale = 0;
    }
	//random color set in player

    void Start ()
	{
		SetRandomColor();
	}
	
	// Update is called once per frame
	void Update () {

		//this code is past in jump script

		/*if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
		{
			AudioSound.playSound("jump");
			rb.gravityScale = 3;
			rb.velocity = Vector2.up * jumpForce;
		}*/
	}
	//Color change to player 
    void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "ColorChanger")
		{
			SetRandomColor();
			Destroy(col.gameObject);


			return;
		}
		//Check Player Color and wheel color to same.
		if (col.tag != currentColor && col.tag !="levelpasser" && col.tag !="ScoreCount")
		{
			/*jump.SetActive(false);*/
          
            AudioSound.playSound("dead");
			Debug.Log(col.tag);
			Debug.Log("GAME OVER!");
			
			ParticleSystem.Play();
			gameObject.GetComponent<SpriteRenderer>().enabled = false;
		


			pausegame();
			Invoke(nameof(playerPlay), 2f);
		}
		if (col.tag == "levelpasser") {


			AudioSound.playSound("win");
            Time.timeScale = 0; levelpasspopup.SetActive(true);
        }
	}

	private void pausegame() 
	{
        spikebar.gameObject.SetActive(false);
        OnPouse?.Invoke(false);
	} 
	private void playerPlay() {
        
        gameoverpopup.gameObject.SetActive(true);
        
    }
	public void restartGame() {
        Time.timeScale = 1;      
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); }

	void SetRandomColor ()
	{
		int index = Random.Range(0, 4);

		switch (index)
		{
			case 0:
				currentColor = "Cyan";
				sr.color = colorCyan;
				break;
			case 1:
				currentColor = "Yellow";
				sr.color = colorYellow;
				break;
			case 2:
				currentColor = "Magenta";
				sr.color = colorMagenta;
				break;
			case 3:
				currentColor = "Pink";
				sr.color = colorPink;
				break;
		}
	}

	
	/*public void LoadNextLevel()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene("Level2", LoadSceneMode.Single);
	}*/


	/*private void GoToNextLevel()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {

            // If we have a next scene to load, load it.
            SceneManager.LoadScene(nextSceneIndex);

        }
		else
		{

			// Otherwise, display your "you win" message.
			gameCompletedMessage.SetActive(true);

		}
	}*/




}
