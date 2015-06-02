using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HideStartButton : MonoBehaviour 
{
	public void ReEnable () 
	{
		GameObject.Find ("start_button").GetComponent<Text>().enabled = true;
	}
}
