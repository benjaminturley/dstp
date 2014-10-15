using UnityEngine;
using System.Collections;

public class ChieveScroller : MonoBehaviour 
{
	public GameObject scroller;

	void scrollerOn()
	{
		scroller.GetComponent<MenuScroller> ().enabled = false;
	}

	public void scrollerOff()
	{
		scroller.GetComponent<MenuScroller> ().enabled = false;
	}

}
