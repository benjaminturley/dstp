using UnityEngine;
using System.Collections;

public class SetCurrentLevelMETA : MonoBehaviour 
{
	public int level;

	void Start () 
	{
		PlayerPrefs.SetInt ("currentLevel", level);
	}

}
