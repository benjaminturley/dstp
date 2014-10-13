using UnityEngine;
using System.Collections;

public class LevelScript : MonoBehaviour 
{
	public GameObject[] levels;

	void Start()
	{
		Instantiate(levels[0], new Vector3 (-2.756885f, 1.298685f, 0f), Quaternion.identity);  
	}

	public void progress()
	{
		Instantiate(levels[PlayerPrefs.GetInt ("currentLevel") - 1], new Vector3 (-2.756885f, 1.298685f, 0f), Quaternion.identity);
	}
}
