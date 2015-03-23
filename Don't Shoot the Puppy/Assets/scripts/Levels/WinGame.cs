using UnityEngine;
using System.Collections;

public class WinGame : MonoBehaviour 
{
	int currentLevel = 0;

	void Start()
	{
		currentLevel = GameObject.Find("GameManager").GetComponent<LevelScript>().currentLevel;
	}
	public void Win ()
	{
		GameObject.Find ("start_button").GetComponent<PlayGame>().WinGame();
		
		if(currentLevel > PlayerPrefs.GetInt ("bestLevel"))
		{
			PlayerPrefs.SetInt ("bestLevel", currentLevel);
		}
		Destroy (GameObject.Find("Level_"+(currentLevel + 1)+"(Clone)"));
	}
}
