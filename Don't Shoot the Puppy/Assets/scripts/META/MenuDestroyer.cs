using UnityEngine;
using System.Collections;

public class MenuDestroyer : MonoBehaviour 
{
	public GameObject menuObject;

	public void OnPress ()
	{
		menuObject.GetComponent<Animator>().SetBool ("open", false);
	}
}
