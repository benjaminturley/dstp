using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PuppiesKilled : MonoBehaviour 
{
	void Start()
	{
		GetComponent<Text> ().text = "Total puppies killed: "+PlayerPrefs.GetInt ("killed");
	}
}
