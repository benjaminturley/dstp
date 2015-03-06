using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour 
{
	public GameObject deathParticle;
	public GameObject failMenu;

	public GameObject sadSign;
	public GameObject puppy;
	public GameObject scroller;

	int timer = 0;
	int downTime = 0;

	public LevelScript ls;

	public bool canLose;

	Color color;

	void Start ()
	{
		//PlayerPrefs.SetInt ("currentLevel", 1);
	}

	void Update ()
	{
		timer = (int)Time.time;

		puppy = GameObject.Find ("puppy");
		sadSign = GameObject.Find ("sign_sad");
		
		color = sadSign.GetComponent<SpriteRenderer>().color;
		
		failMenu = GameObject.Find ("GameManager").GetComponent<NullObjectHolder>().failMenu;
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

	public void reset()
	{
		GetComponent<Text>().enabled = true;
		sadSign.GetComponent<SpriteRenderer>().color = color;
		failMenu.SetActive (false);
		scroller.SetActive(true);
	}

	IEnumerator doFailGame()
	{
		color.a = 255;
		PlayerPrefs.SetInt ("killed", PlayerPrefs.GetInt ("killed") + 1);

		if (canLose) 
		{
			Handheld.Vibrate ();
			puppy.SetActive(false);
			Instantiate (deathParticle, puppy.transform.position, Quaternion.identity);
			canLose = false;
			sadSign.GetComponent<SpriteRenderer>().color = color;
			color.a = 0;
			yield return new WaitForSeconds (1);
			scroller.SetActive(false);
			Destroy (GameObject.Find("Level_"+(PlayerPrefs.GetInt("currentLevel"))+"(Clone)"));
			sadSign.GetComponent<SpriteRenderer>().color = color;
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