using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour 
{
	public GameObject deathParticle;
	public GameObject sadSign;

	GameObject failMenu;
	GameObject puppy;
	GameObject pivotPoint;
	GameObject happySign;
	GameObject turret;
	GameObject aboutButton;

	bool canLose;
	
	void Start ()
	{
		puppy = GameObject.Find ("puppy");
		pivotPoint = GameObject.Find ("Pivot Point");
		happySign = GameObject.Find ("sign_happy");
		turret = GameObject.Find ("Turret");
		aboutButton = GameObject.Find ("about_button");

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
		if (canLose) 
		{
			pivotPoint.GetComponent<Animator> ().SetBool ("fire", true);
			pivotPoint.GetComponent<RotateTurret> ().enabled = false;
			Instantiate (deathParticle, puppy.transform.position, Quaternion.identity);
			puppy.SetActive(false);
			canLose = false;
			happySign.SetActive(false);
			sadSign.SetActive(true);
			yield return new WaitForSeconds (1);
			sadSign.SetActive(false);
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