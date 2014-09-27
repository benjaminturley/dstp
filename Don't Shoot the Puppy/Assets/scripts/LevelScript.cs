using UnityEngine;
using System.Collections;

public class LevelScript : MonoBehaviour 
{
	public GameObject[] levels;

	void Start() 
	{
		Instantiate(levels[PlayerPrefs.GetInt ("playerLevel") - 1], new Vector3 (-2.756885f, 1.298685f, 0f), Quaternion.identity);  
		GameObject.Find ("THE Canvas").transform.position = new Vector3 (0f, 0f, 0f);
	}
}
