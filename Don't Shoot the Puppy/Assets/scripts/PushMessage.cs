using UnityEngine;
using System.Collections;

public class PushMessage : MonoBehaviour 
{

	public GameObject note;

	public void throwNote()
	{
		note.SetActive (true);
	}

}
