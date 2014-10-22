using UnityEngine;
using System.Collections;

public class MenuScroller : MonoBehaviour 
{
	public float posOnDown;
	public float posOnUp;

	public GameObject puppy;
	public GameObject turret;

	public PlayGame pg;

	string currentPos = "center";

	void Update()
	{
		puppy = pg.puppy;
	}

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
				puppy.transform.Rotate(0, 90, 0);
			}

			else if(currentPos == "right")
			{
				GetComponent<Animator>().SetTrigger("rightcenter");
				currentPos = "center";
				puppy.transform.Rotate(0, -90, 0);
			}
		}

		if(posOnDown > posOnUp)
		{
			if(currentPos == "center")
			{
				GetComponent<Animator>().SetTrigger("rightright");
				currentPos = "right";
				puppy.transform.Rotate(0, 90, 0);
			}

			else if(currentPos == "left")
			{
				GetComponent<Animator>().SetTrigger("leftcenter");
				currentPos = "center";
				puppy.transform.Rotate(0, -90, 0);
			}
		}

		posOnDown = 0;
		posOnUp = 0;
	}
}
