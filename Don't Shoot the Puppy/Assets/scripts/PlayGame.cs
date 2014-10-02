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
	GameObject aboutButton;

	bool canLose;
	
	void Update ()
	{
		puppy = GameObject.Find ("puppy");
		happySign = GameObject.Find ("sign_happy");
		turret = GameObject.Find ("Turret");
		aboutButton = GameObject.Find ("about_button");
		sadSign = GameObject.Find ("sign_sad");

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
	}

	IEnumerator doFailGame()
	{
		Color color = sadSign.GetComponent<SpriteRenderer>().color;
		color.a = 255;

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
		PlayerPrefs.SetInt ("playerLevel", level);
		Application.LoadLevel (0);
	}
}