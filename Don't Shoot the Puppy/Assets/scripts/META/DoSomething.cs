using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DoSomething : MonoBehaviour 
{

	public void startTimer()
	{
		GameObject.Find("Timer").GetComponent<CountDownTimer>().enabled = true;
	}

	public void stopTimer()
	{
		GameObject.Find("Timer").GetComponent<Text>().enabled = false;
	}

	public void vibrate()
	{
		Handheld.Vibrate ();
	}

	public void scare()
	{
		GameObject dog = GameObject.Find("scary-dog");
		dog.GetComponent<Animator>().SetTrigger("scare");
		dog.GetComponent<AudioSource>().Play();
		Handheld.Vibrate ();
	}

	public void fire()
	{
		GameObject.Find("muzzle_flare_0").GetComponent<Animator>().SetTrigger("fire");
	}

	public void bugs()
	{
		GameObject.Find("bug_0").GetComponent<Animator>().SetTrigger("go");
	}

	public void openHelp()
	{
		GameObject.Find("about_menu_button").GetComponent<Animator>().SetBool("open", true);
	}

	public void closeHelp()
	{
		GameObject.Find("about_menu_button").GetComponent<Animator>().SetBool("open", false);
	}
}
