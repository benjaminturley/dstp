using UnityEngine;
using System.Collections;

public class TurnOnArrow : MonoBehaviour 
{

	public GameObject arrow;

public void turnOn ()
	{
		arrow.SetActive (true);
	}
}
