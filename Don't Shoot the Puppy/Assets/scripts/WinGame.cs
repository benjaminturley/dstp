using UnityEngine;
using System.Collections;

public class WinGame : MonoBehaviour 
{
	public int currentLevel;

	public void goWin()
	{
		Win (currentLevel);
	}

	void Win (int level)
	{
		GameObject.Find ("start_button").GetComponent<PlayGame>().WinGame();
		PlayerPrefs.SetInt ("currentLevel", level + 1);
		
		if(PlayerPrefs.GetInt ("currentLevel") > PlayerPrefs.GetInt ("bestLevel"))
		{
			PlayerPrefs.SetInt ("bestLevel", PlayerPrefs.GetInt ("currentLevel"));
		}
		Destroy (GameObject.Find("Level_"+(level)+"(Clone)"));
	}
}
