using UnityEngine;
using System.Collections;

public class LevelScript : MonoBehaviour 
{
	public GameObject[] levels;

	public int META = 0;

	void Start()
	{
		PlayerPrefs.SetInt ("currentLevel", META);
		Instantiate(levels[META-1], new Vector3 (-2.756885f, 1.298685f, 0f), Quaternion.identity);  
	}

	public void progress()
	{
		Instantiate(levels[PlayerPrefs.GetInt ("currentLevel")], new Vector3 (-2.756885f, 1.298685f, 0f), Quaternion.identity);
	}
}
