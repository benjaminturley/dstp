using UnityEngine;
using System.Collections;

public class MenuScroller : MonoBehaviour 
{
	public float posOnDown;
	public float posOnUp;

	string currentPos = "center";

	public void pointerDown()
	{
		posOnDown = Input.mousePosition.x;
	}

	public void pointerUp()
	{
		posOnUp = Input.mousePosition.x;

		if(posOnDown < posOnUp)
		{
			if(currentPos == "center")
			{
				GetComponent<Animator>().SetTrigger("leftleft");
				currentPos = "left";
			}

			else if(currentPos == "right")
			{
				GetComponent<Animator>().SetTrigger("rightcenter");
				currentPos = "center";
			}
		}

		if(posOnDown > posOnUp)
		{
			if(currentPos == "center")
			{
				GetComponent<Animator>().SetTrigger("rightright");
				currentPos = "right";
			}

			else if(currentPos == "left")
			{
				GetComponent<Animator>().SetTrigger("leftcenter");
				currentPos = "center";
			}
		}

		Debug.Log ("Current Position: " + currentPos);

		posOnDown = 0;
		posOnUp = 0;
	}
}
