using UnityEngine;
using System.Collections;

public class PauseTime : MonoBehaviour 
{
	public float pauseLength = 1.8f;
	IEnumerator doPause()
	{
		Time.timeScale = 0f;
		float pauseEndTime = Time.realtimeSinceStartup + pauseLength;
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
