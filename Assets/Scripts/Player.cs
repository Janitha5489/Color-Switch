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
	public ParticleSystem Boom;
	public GameObject jump;
	public ParticleSystem Dust;

	private void Awake()
	{
		rb.gravityScale = 0;
	}

	void Start()
	{
		SetRandomColor();
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "ColorChanger")
		{
			SetRandomColor();
			Destroy(col.gameObject);
			return;
		}

		if (col.tag != currentColor && col.tag != "levelpasser" && col.tag != "ScoreCount")
		{
			AudioSound.PlaySound("dead");
			Debug.Log(col.tag);
			Debug.Log("GAME OVER!");
			Boom.Play();
			Dust.Stop();
			gameObject.GetComponent<SpriteRenderer>().enabled = false;
			pausegame();
			Invoke(nameof(playerPlay), 2f);
		}
		if (col.tag == "levelpasser")
		{
			AudioSound.PlaySound("win");
			Time.timeScale = 0; levelpasspopup.SetActive(true);
		}
	}
	private void pausegame()
	{
		spikebar.gameObject.SetActive(false);
		OnPouse?.Invoke(false);
	}
	private void playerPlay()
	{
		gameoverpopup.gameObject.SetActive(true);
	}
	public void restartGame()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
	void SetRandomColor()
	{
		int index = Random.Range(0, 4);
		switch (index)
		{
			case 0:
				currentColor = "Cyan";
				sr.color = colorCyan;
				Dust.startColor = colorCyan;
				break;
			case 1:
				currentColor = "Yellow";
				sr.color = colorYellow;
                Dust.startColor = colorYellow;
                break;
			case 2:
				currentColor = "Magenta";
				sr.color = colorMagenta;
                Dust.startColor = colorMagenta;
                break;
			case 3:
				currentColor = "Pink";
				sr.color = colorPink;
                Dust.startColor = colorPink;
                break;
		}
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





