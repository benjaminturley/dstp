using UnityEngine;
using System.Collections;

public class FailGameScript : MonoBehaviour 
{

 public void failGame()
	{
		GameObject.Find("start_button").GetComponent<PlayGame>().canLose = true;
		GameObject.Find("start_button").GetComponent<PlayGame>().FailGame();

		Destroy(gameObject);
	}

}
