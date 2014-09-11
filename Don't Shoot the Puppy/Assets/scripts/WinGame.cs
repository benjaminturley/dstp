using UnityEngine;
using System.Collections;

public class WinGame : MonoBehaviour 
{
	public void Win (int level)
	{
		GameObject.Find ("start_button").GetComponent<PlayGame>().WinGame(level);
	}
}
