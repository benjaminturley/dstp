﻿using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour 
{

	public void ReRender () 
	{
		GameObject.Find("Main Camera").GetComponent<Camera>().orthographicSize = 1; 
	}
}