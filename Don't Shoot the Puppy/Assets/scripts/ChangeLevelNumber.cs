﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ChangeLevelNumber : MonoBehaviour 
{
	public string levelNumber;

	void Update()
	{
		levelNumber = PlayerPrefs.GetInt("currentLevel").ToString ();
		GetComponent<Text>().text = "Level " + levelNumber;
	}
}
