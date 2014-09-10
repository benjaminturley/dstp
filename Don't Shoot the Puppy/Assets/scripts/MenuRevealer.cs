using UnityEngine;
using System.Collections;

public class MenuRevealer : MonoBehaviour 
{
	public GameObject menuObject;

	public void OnPress () 
	{
		menuObject.GetComponent<Animator>().SetBool ("open", true);
	}
}