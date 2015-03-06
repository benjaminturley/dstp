using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ChangeLevelNumber : MonoBehaviour 
{
	public string levelNumber;
	GameObject title;

	void Start()
	{
		title = GameObject.Find("title");
	}

	void Update()
	{
		levelNumber = PlayerPrefs.GetInt("currentLevel").ToString ();
		GetComponent<Text>().text = "Level " + levelNumber;

		if(int.Parse(levelNumber) != 13 && title.GetComponent<Text>().text.Equals("Shoot the Puppy"))
			title.GetComponent<Text>().text = "Don't Shoot the Puppy";
	}
}
