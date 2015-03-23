using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Replay : MonoBehaviour
{
	public void ChangeLevel()
	{
		Application.LoadLevel (0);
		PlayerPrefs.SetInt ("currentLevel", 1);
	}

}
