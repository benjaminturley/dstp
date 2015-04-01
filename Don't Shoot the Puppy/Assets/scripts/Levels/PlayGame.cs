using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour 
{
	public GameObject deathParticle;
	public GameObject failMenu;

	public GameObject happySign;
	public GameObject puppy;
	//public GameObject scroller;

	int timer = 0;
	int downTime = 0;

	public LevelScript ls;

	public bool canLose;

	Color color;

	void Update ()
	{
		timer = (int)Time.time;

		puppy = GameObject.Find ("Puppy(Clone)");
		happySign = GameObject.Find ("sign_happy");
		
		color = happySign.GetComponent<SpriteRenderer>().color;
		
		failMenu = GameObject.Find ("GameManager").GetComponent<NullObjectHolder>().failMenu;
	}

	public void StartGame () 
	{
		GetComponent<Text>().enabled = false;

		if(puppy.GetComponent<LevelCase>().playDefault)
			puppy.GetComponent<Animator>().SetBool ("default", true);
		else
			puppy.GetComponent<Animator>().SetBool ("l"+GameObject.Find ("GameManager").GetComponent<LevelScript>().currentLevel, true);
		canLose = true;
	}
	
	public void FailGame () 
	{
		StartCoroutine (doFailGame ());
		PlayerPrefs.SetInt ("time", PlayerPrefs.GetInt ("time") + timer);
	}

	public void reset()
	{
		GetComponent<Text>().enabled = true;
		happySign.GetComponent<SpriteRenderer>().color = color;
		failMenu.SetActive (false);
		//scroller.SetActive(true);

		Destroy(GameObject.Find("Puppy(Clone)"));
		Destroy(GameObject.Find("Sign(Clone)"));
		Destroy(GameObject.Find("Turret(Clone)"));
	}

	IEnumerator doFailGame()
	{
		if (canLose) 
		{
			color.a = 0;
			PlayerPrefs.SetInt ("killed", PlayerPrefs.GetInt ("killed") + 1);
			Handheld.Vibrate ();
			puppy.GetComponent<SpriteRenderer>().color = color;
			Instantiate (deathParticle, puppy.transform.position, Quaternion.identity);
			canLose = false;
			happySign.GetComponent<SpriteRenderer>().color = color;
			yield return new WaitForSeconds (1);
			//scroller.SetActive(false);
			failMenu.SetActive (true);
		}
	}
	
	public void WinGame () 
	{
		canLose = false;
		ls.progress ();
		reset ();

		PlayerPrefs.SetInt ("time", PlayerPrefs.GetInt ("time") + (timer - downTime));
		downTime = (int)Time.time;               
	}
}