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

	public GameObject flare, gm, crown;

	public int levelCount = 0;

	public ThrowAd ta;

	int timer = 0;
	int downTime = 0;

	public LevelScript ls;

	public bool canLose;

	Color color;

	void Start()
	{
		gm = GameObject.Find ("GameManager");
		failMenu = gm.GetComponent<NullObjectHolder>().failMenu;
		crown = GameObject.Find("crown");

		//PlayerPrefs.SetString("ach", "");
		//PlayerPrefs.SetInt("killed", 0);
		//PlayerPrefs.SetInt("time", 0);
	}

	void Update ()
	{
		timer = (int)Time.time;

		puppy = GameObject.FindGameObjectWithTag ("Puppy");
		happySign = GameObject.Find ("sign_happy");
		
		color = happySign.GetComponent<SpriteRenderer>().color;

		flare = GameObject.Find("muzzle_flare_0");

		if(PlayerPrefs.GetInt ("bestLevel") >= 29)
		{
			crown.GetComponent<SpriteRenderer>().enabled = true;
			GetComponent<AcheivementSaver>().Save("v");
		}
	}

	public void StartGame () 
	{
		GetComponent<Text>().enabled = false;
		rightArrow.SetActive(false);
		leftArrow.SetActive(false);

		if(puppy.GetComponent<LevelCase>().playDefault)
			puppy.GetComponent<Animator>().SetBool ("default", true);
		else
			puppy.GetComponent<Animator>().SetBool ("l"+gm.GetComponent<LevelScript>().currentLevel, true);

		canLose = true;
		downTime = timer;

	}
	
	public void FailGame () 
	{
		if(gm.GetComponent<LevelScript>().currentLevel == 29)
			Time.timeScale = 1;
		if(gm.GetComponent<LevelScript>().currentLevel == 23)
			Destroy (GameObject.Find("play"));
		if(gm.GetComponent<LevelScript>().currentLevel == 5)
			GameObject.Find("arrow").SetActive(false);
		if(gm.GetComponent<LevelScript>().currentLevel == 10)
			GameObject.Find("Timer").SetActive(false);
		if(gm.GetComponent<LevelScript>().currentLevel == 15)
			GameObject.Find("bug").GetComponent<Animator>().SetTrigger("stop");
		if(gm.GetComponent<LevelScript>().currentLevel == 16)
			GameObject.Find("about_menu_button").GetComponent<Animator>().SetBool("open", false);
		if(gm.GetComponent<LevelScript>().currentLevel == 19)
			GameObject.Find("title").GetComponent<Text>().text = "Don't Shoot the Puppy";
		if(gm.GetComponent<LevelScript>().currentLevel == 21)
			GameObject.Find("anvil").GetComponent<Image>().enabled = false;
		if(gm.GetComponent<LevelScript>().currentLevel == 24)
			GameObject.Find("Main Camera").GetComponent<CameraShake>().enabled = false;
		if(gm.GetComponent<LevelScript>().currentLevel == 25)
		{
			GameObject level = GameObject.Find ("level");
			level.GetComponent<Text>().text = "Level "+(gm.GetComponent<LevelScript>().currentLevel + 1);
			level.GetComponent<ChangeLevelNumber>().enabled = true;
		}

		if(gm.GetComponent<LevelScript>().currentLevel == 23)
			Destroy (GameObject.Find("play"));

		if(gm.GetComponent<LevelScript>().currentLevel == 28)
			Destroy(GameObject.Find ("click"));

		PlayerPrefs.SetInt ("time", PlayerPrefs.GetInt ("time") + (timer - downTime));

		StartCoroutine (doFailGame ());

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

		GameObject.Find("about_button").GetComponent<Button>().interactable = true;
	}

	IEnumerator doFailGame()
	{
		if (canLose) 
		{
			if(gm.GetComponent<LevelScript>().currentLevel == 2)
				GetComponent<AcheivementSaver>().Save("h");
			
			if(gm.GetComponent<LevelScript>().currentLevel == 15)
				GetComponent<AcheivementSaver>().Save("k");
			
			if(gm.GetComponent<LevelScript>().currentLevel == 11)
				GetComponent<AcheivementSaver>().Save("m");
			
			if(gm.GetComponent<LevelScript>().currentLevel == 13)
				GetComponent<AcheivementSaver>().Save("l");
			
			if(gm.GetComponent<LevelScript>().currentLevel == 27 || gm.GetComponent<LevelScript>().currentLevel == 22)
				GetComponent<AcheivementSaver>().Save("o");
			
			if(gm.GetComponent<LevelScript>().currentLevel == 21)
				GetComponent<AcheivementSaver>().Save("p");
			
			if(gm.GetComponent<LevelScript>().currentLevel == 3)
				GetComponent<AcheivementSaver>().Save("q");
			
			if(gm.GetComponent<LevelScript>().currentLevel == 19)
				GetComponent<AcheivementSaver>().Save("w");

			if(gm.GetComponent<LevelScript>().currentLevel == 29)
				GetComponent<AcheivementSaver>().Save("n");
			
			if(gm.GetComponent<LevelScript>().currentLevel == 28)
				GetComponent<AcheivementSaver>().Save("u");

			levelCount = 0;
			gm.GetComponent<LevelScript>().currentLevel = 0;
			color.a = 0;
			PlayerPrefs.SetInt ("killed", PlayerPrefs.GetInt ("killed") + 1);
			Handheld.Vibrate ();
			puppy.GetComponent<SpriteRenderer>().color = color;
			puppy.GetComponent<Animator>().SetBool ("idle", true);

			spawnParticle();
			canLose = false;
			happySign.GetComponent<SpriteRenderer>().color = color;

			flare.GetComponent<Animator>().SetTrigger("fire");

			GameObject.Find("about_button").GetComponent<Button>().interactable = false;

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

	public void levelWin()
	{
		canLose = false;
		reset ();
		ls.progress ();
	}
	
	public void WinGame () 
	{
		canLose = false;
		reset ();
		ls.progress ();

		PlayerPrefs.SetInt ("time", PlayerPrefs.GetInt ("time") + (timer - downTime)); 

		levelCount++;

		if(levelCount >= 30)
			GetComponent<AcheivementSaver>().Save("r");
	}

	public void spawnParticle()
	{
		Instantiate (deathParticle, puppy.transform.position, Quaternion.identity);
	}
}