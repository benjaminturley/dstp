using UnityEngine;
using System.Collections;

public class TriggerBlack : MonoBehaviour 
{
	public GameObject panel;

	public void createBlind()
	{
		panel.SetActive (true);
	}
}
