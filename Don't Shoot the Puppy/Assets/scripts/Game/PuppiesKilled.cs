﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PuppiesKilled : MonoBehaviour 
{
	void Start()
	{
		int killed = PlayerPrefs.GetInt ("killed");
		GetComponent<Text> ().text = "Total puppies killed: "+killed;
		GetComponent<AcheivementSaver>().Save ("g");

		if(killed >= 20)
			GetComponent<AcheivementSaver>().Save ("a");
		if(killed >= 60)
			GetComponent<AcheivementSaver>().Save ("b");
		if(killed >= 180)
			GetComponent<AcheivementSaver>().Save ("c");
	}
}
