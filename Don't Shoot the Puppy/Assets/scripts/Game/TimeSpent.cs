using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeSpent : MonoBehaviour 
{
	void Start()
	{
		int s = PlayerPrefs.GetInt ("time");
		int m = s / 60;
		int h = m / 60;
		GetComponent<Text> ().text = "Time spent not shooting the puppy: " + h + "h "+ (m - (h * 60)) +"m "+ (s - (m * 60)) +"s";

		if(m >= 10)
			GetComponent<AcheivementSaver>().Save ("d");
		if(m >= 30)
			GetComponent<AcheivementSaver>().Save ("e");
		if(m >= 60)
			GetComponent<AcheivementSaver>().Save ("f");
	}
}
