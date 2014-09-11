using UnityEngine;
using System.Collections;

public class ClearLevel : MonoBehaviour 
{
	
	void Start () 
	{
		PlayerPrefs.SetInt("playerLevel", 0);
	}
	
}
