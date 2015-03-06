using UnityEngine;
using System.Collections;

public class META : MonoBehaviour 
{
	public int gameSpeed;
	void Start()
	{
		if (gameSpeed > 0)
			Time.timeScale = gameSpeed;
	}

}
