using UnityEngine;
using System.Collections;

public class LevelCase : MonoBehaviour 
{
	public bool playDefault = true;
	GameObject gm;
	int[] levels = {1};

	void Start()
	{
		gm = GameObject.Find ("GameManager");
	}

	void Update ()
	{
		if(checkLevels())
			playDefault = false;
		else
			playDefault = true;
	}

	bool checkLevels()
	{
		for(int i = 0; i < levels.Length; i++)
			if(levels[i] == gm.GetComponent<LevelScript>().currentLevel)
				return true;
		return false;
	}
}
