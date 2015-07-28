using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour 
{
	GameObject cam;

	void Start()
	{
		cam = GameObject.Find("Main Camera");
	}

	public void ReRender () 
	{
		cam.GetComponent<Camera>().orthographicSize = 1; 
	}

	public void PostRender()
	{
		cam.GetComponent<Camera>().orthographicSize = 5;
	}
}
