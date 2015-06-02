using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour 
{
	public GameObject deathParticle;
	public GameObject failMenu;

	public GameObject happySign;
	public GameObject puppy;
	public GameObject leftArrow, rightArrow;

	public GameObject flare;

	public ThrowAd ta;

	int timer = 0;
	int downTime = 0;

	public LevelScript ls;

	public bool canLose;

	Color color;

	void Start()
	{
		failMenu = GameObject.Find ("GameManager").GetComponent<NullObjectHolder>().failMenu;
	}

	void Update ()
	{
		timer = (int)Time.time;

		puppy = GameObject.FindGameObjectWithTag ("Puppy");
		happySign = GameObject.Find ("sign_happy");
		
		color = happySign.GetComponent<SpriteRenderer>().color;

		flare = GameObject.Find("muzzle_flare_0");
	}

	public void StartGame () 
	{
		GetComponent<Text>().enabled = false;
		rightArrow.SetActive(false);
		leftArrow.SetActive(false);

		if(puppy.GetComponent<LevelCase>().playDefault)
			puppy.GetComponent<Animator>().SetBool ("default", true);
		else
			puppy.GetComponent<Animator>().SetBool ("l"+GameObject.Find ("GameManager").GetComponent<LevelScript>().currentLevel, true);

		canLose = true;

	}
	
	public void FailGame () 
	{
		StartCoroutine (doFailGame ());
		PlayerPrefs.SetInt ("time", PlayerPrefs.GetInt ("time") + (timer - downTime));

		rightArrow.SetActive(true);
		leftArrow.SetActive(true);
	}

	public void reset()
	{
		GetComponent<Text>().enabled = true;
		happySign.GetComponent<SpriteRenderer>().color = color;
		failMenu.SetActive (false);

		Destroy(GameObject.FindGameObjectWithTag("Puppy"));
		Destroy(GameObject.FindGameObjectWithTag("Sign"));
		Destroy(GameObject.FindGameObjectWithTag("Turret"));

		rightArrow.SetActive(true);
		leftArrow.SetActive(true);
	}

	IEnumerator doFailGame()
	{
		if (canLose) 
		{
			color.a = 0;
			PlayerPrefs.SetInt ("killed", PlayerPrefs.GetInt ("killed") + 1);
			Handheld.Vibrate ();
			puppy.GetComponent<SpriteRenderer>().color = color;
			puppy.GetComponent<Animator>().SetBool ("idle", true);

			if(GameObject.Find ("GameManager").GetComponent<LevelScript>().currentLevel == 5)
				GameObject.Find("arrow").SetActive(false);
			else if(GameObject.Find ("GameManager").GetComponent<LevelScript>().currentLevel == 10)
				GameObject.Find("Timer").SetActive(false);
			else if(GameObject.Find ("GameManager").GetComponent<LevelScript>().currentLevel == 15)
				GameObject.Find("bug_0").SetActive(false);
			else if(GameObject.Find ("GameManager").GetComponent<LevelScript>().currentLevel == 16)
				GameObject.Find("about_menu_button").GetComponent<Animator>().SetBool("open", false);
			else if(GameObject.Find ("GameManager").GetComponent<LevelScript>().currentLevel == 19)
				GameObject.Find("title").GetComponent<Text>().text = "Don't Shoot the Puppy";
			else if(GameObject.Find ("GameManager").GetComponent<LevelScript>().currentLevel == 21)
				Destroy (GameObject.Find("anvil"));

			spawnParticle();
			canLose = false;
			happySign.GetComponent<SpriteRenderer>().color = color;

			flare.GetComponent<Animator>().SetTrigger("fire");

			yield return new WaitForSeconds (1);
			PlayerPrefs.SetInt("ads", PlayerPrefs.GetInt("ads")+1);
			if (PlayerPrefs.GetInt("ads") >= 4)
			{
				ta.throwAd();
				PlayerPrefs.SetInt("ads", 0);
			}
			failMenu.SetActive (true);
		}
	}
	
	public void WinGame () 
	{
		canLose = false;
		reset ();
		ls.progress ();

		PlayerPrefs.SetInt ("time", PlayerPrefs.GetInt ("time") + (timer - downTime));
		downTime = (int)Time.time;               
	}

	public void spawnParticle()
	{
		Instantiate (deathParticle, puppy.transform.position, Quaternion.identity);
	}
}