using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour 
{

	void Start () 
	{
		/*
		if (PlayerPrefs.GetInt ("playerLevel") == 0) 
		{
			PlayerPrefs.SetInt ("playerLevel", 1);
		}
		*/
		//Application.LoadLevel(PlayerPrefs.GetInt ("playerLevel"));
		Application.LoadLevel(1);
	}

}
