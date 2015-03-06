using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeLevelDirections : MonoBehaviour {

	GameObject title;

	void Start () 
	{
		title = GameObject.Find("title");
		title.GetComponent<Text>().text = "Shoot the Puppy";
	}
}
