using UnityEngine;
using System.Collections;

public class SkipButton : MonoBehaviour 
{
	public PlayGame pg;

	void Start()
	{
		pg = GameObject.Find ("start_button").GetComponent<PlayGame> ();
	}

	public void SkipLevel()
	{
		pg.canLose = true;
		pg.FailGame ();
	}
}
