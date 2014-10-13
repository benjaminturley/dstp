using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour 
{
	public GameObject deathParticle;
	public GameObject failMenu;

	public GameObject sadSign;
	GameObject puppy;
	GameObject happySign;
	GameObject turret;
	public GameObject aboutButton;

	int timer = 0;

	public LevelScript ls;

	bool canLose;

	Color color;

	void Update ()
	{
		puppy = GameObject.Find ("puppy");
		happySign = GameObject.Find ("sign_happy");
		turret = GameObject.Find ("Turret");
		aboutButton = GameObject.Find ("about_button");
		sadSign = GameObject.Find ("sign_sad");

		color = sadSign.GetComponent<SpriteRenderer>().color;

		failMenu = GameObject.Find ("GameManager").GetComponent<NullObjectHolder>().failMenu;

		timer = (int)Time.time;
	}

	public void StartGame () 
	{
		GetComponent<Text>().enabled = false;
		puppy.GetComponent<Animator>().SetBool ("go", true);
		canLose = true;
	}
	
	public void FailGame () 
	{
		StartCoroutine (doFailGame ());

		PlayerPrefs.SetInt ("time", PlayerPrefs.GetInt ("time") + timer);
	}

	IEnumerator doFailGame()
	{
		color.a = 255;
		PlayerPrefs.SetInt ("killed", PlayerPrefs.GetInt ("killed") + 1);

		if (canLose) 
		{
			Instantiate (deathParticle, puppy.transform.position, Quaternion.identity);
			puppy.SetActive(false);
			canLose = false;
			happySign.SetActive(false);
			sadSign.GetComponent<SpriteRenderer>().color = color;
			color.a = 0;
			yield return new WaitForSeconds (1);
			sadSign.GetComponent<SpriteRenderer>().color = color;
			turret.SetActive(false);
			aboutButton.SetActive(false);
			failMenu.SetActive (true);
		}
	}


	public void WinGame (int level) 
	{
		Destroy (GameObject.Find("Level_"+PlayerPrefs.GetInt("currentLevel")+"(Clone)"));
		PlayerPrefs.SetInt ("currentLevel", level);

		if(PlayerPrefs.GetInt ("currentLevel") > PlayerPrefs.GetInt ("bestLevel"))
		{
			PlayerPrefs.SetInt ("bestLevel", PlayerPrefs.GetInt ("currentLevel"));
		}
		ls.progress ();

		PlayerPrefs.SetInt ("time", PlayerPrefs.GetInt ("time") + timer);
	}
}