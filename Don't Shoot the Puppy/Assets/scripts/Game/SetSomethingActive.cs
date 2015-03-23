using UnityEngine;
using System.Collections;

public class SetSomethingActive : MonoBehaviour {

	public GameObject something;

	void Activate()
	{
		something.SetActive (true);
	}
}
