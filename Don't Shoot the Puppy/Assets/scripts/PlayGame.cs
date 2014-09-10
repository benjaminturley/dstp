using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour 
{
	public GameObject deathParticle;
	public GameObject failMenu;

	GameObject puppy;
	GameObject pivotPoint;

	bool canLose;
	
	void Start ()
	{
		puppy = GameObject.Find ("puppy");
		pivotPoint = GameObject.Find ("Pivot Point");
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
			GameObject.Destroy (puppy);
			canLose = false;
		}
		yield return new WaitForSeconds (1);
		failMenu.SetActive (true);
	}

	public void WinGame () 
	{
		Application.LoadLevel ("Level_2");
	}
}