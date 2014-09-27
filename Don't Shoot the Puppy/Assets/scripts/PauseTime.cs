using UnityEngine;
using System.Collections;

public class PauseTime : MonoBehaviour 
{
	public void pause()
	{
		StartCoroutine (doPause ());
	}
	
	IEnumerator doPause()
	{
		Time.timeScale = 0f;
		float pauseEndTime = Time.realtimeSinceStartup + 1.8f;
		while (Time.realtimeSinceStartup < pauseEndTime)
		{
			yield return 0;
		}
		Time.timeScale = 1;
	}

	public void returnTime ()
	{
		Time.timeScale = 1;
	}
	
}
