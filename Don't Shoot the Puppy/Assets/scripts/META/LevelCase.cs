using UnityEngine;
using System.Collections;

public class LevelCase : MonoBehaviour 
{
	public bool playDefault = true;
	GameObject gm;
	int[] levels = {1, 3, 4, 5, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 28, 29};

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
