using UnityEngine;
using System.Collections;

public class SetSomethingActive : MonoBehaviour 
{	
	public GameObject something;
	public bool startActive = false;

	void Awake()
	{
		if(startActive)
			something.SetActive(true);
	}

	void Activate()
	{
		something.SetActive (true);
	}
}
