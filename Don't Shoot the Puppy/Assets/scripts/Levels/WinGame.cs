using UnityEngine;
using System.Collections;

public class WinGame : MonoBehaviour 
{
	int currentLevel = 0;
	
	public void Win ()
	{
		currentLevel = GameObject.Find("GameManager").GetComponent<LevelScript>().currentLevel;
		GameObject.Find ("start_button").GetComponent<PlayGame>().WinGame();
		
		if(currentLevel > PlayerPrefs.GetInt ("bestLevel"))
		{
			PlayerPrefs.SetInt ("bestLevel", currentLevel);
		}
	}
}
