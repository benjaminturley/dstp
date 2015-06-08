using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TranslateMenu : MonoBehaviour 
{
	public GameObject chieves, select, title, level;
	public static int position = 0;
	public bool isRight = false, interactable = true;

	public void MoveLeft()
	{
		if(interactable)
		{
			if(position == 0)
			{
				chieves.SetActive(true);
				title.SetActive(false);
				level.SetActive(false);

				position = -1;
			}

			else 
			{
				select.SetActive(false);
				title.SetActive(true);
				level.SetActive(true);

				position = 0;
			}
		}
	}

	public void MoveRight()
	{
		if(interactable)
		{
			if(position == 0)
			{
				select.SetActive(true);
				title.SetActive(false);
				level.SetActive(false);

				position = 1;
			}
			
			else 
			{
				chieves.SetActive(false);
				title.SetActive(true);
				level.SetActive(true);

				position = 0;
			}
		}
	}
	void Update()
	{
		if((isRight && position == 1) || (!isRight && position == -1))
		{
			interactable = false;
			GetComponent<Image>().enabled = false;
		}

		else
		{
			interactable = true;
			GetComponent<Image>().enabled = true;
		}


	}
}
