using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TranslateMenu : MonoBehaviour 
{
	public GameObject chieves, select, title, level;
	public static int position = 0;
	public bool isRight = false;

	public void MoveLeft()
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
			title.SetActive(false);
			level.SetActive(false);

			position = 0;
		}

	}

	public void MoveRight()
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
	void Update()
	{
		if((isRight && position == 1) || (!isRight && position == -1))
			GetComponent<Button>().interactable = false;

		else
			GetComponent<Button>().interactable = true;


	}
}
