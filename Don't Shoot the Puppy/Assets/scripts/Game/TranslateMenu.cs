using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TranslateMenu : MonoBehaviour 
{
	public GameObject scroller;
	public bool leftButton;

	public void MoveLeft()
	{
		scroller.transform.position = new Vector3(scroller.transform.position.x + 17.7f, scroller.transform.position.y, scroller.transform.position.z);
	}

	public void MoveRight()
	{
		scroller.transform.position = new Vector3(scroller.transform.position.x - 17.7f, scroller.transform.position.y, scroller.transform.position.z);
	}
	void Update()
	{
		if(leftButton && scroller.transform.position.x >= 17.7)
			GetComponent<Button>().interactable = false;
		else if(!leftButton && scroller.transform.position.x <= -17.7)
			GetComponent<Button>().interactable = false;
		else 
			GetComponent<Button>().interactable = true;
	}
}
