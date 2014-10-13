using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BestLevel : MonoBehaviour {


	void Start () 
	{
		GetComponent<Text> ().text = "Best level: "+PlayerPrefs.GetInt ("bestLevel");
	}
}
