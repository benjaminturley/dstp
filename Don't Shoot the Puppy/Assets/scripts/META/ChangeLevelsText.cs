using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeLevelsText : MonoBehaviour 
{
	
	void Start () 
	{
		GetComponent<Text>().text = this.name;
	}

}
