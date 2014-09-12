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
		GameObject.Find ("start_button").GetComponent<PlayGame>().WinGame(level);
	}
}
