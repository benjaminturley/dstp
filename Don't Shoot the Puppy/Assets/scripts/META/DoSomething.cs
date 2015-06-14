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
		GameObject.Find("bug").GetComponent<Animator>().SetTrigger("go");
	}

	public void killbugs()
	{
		GameObject.Find("bug").GetComponent<Animator>().SetTrigger("stop");
	}

	public void openHelp()
	{
		GameObject.Find("about_menu_button").GetComponent<Animator>().SetBool("open", true);
	}

	public void closeHelp()
	{
		GameObject.Find("about_menu_button").GetComponent<Animator>().SetBool("open", false);
	}

	public void changeDirectionsY()
	{
		GameObject.Find("title").GetComponent<Text>().text = "Shoot the Puppy";
	}

	public void changeDirectionsN()
	{
		GameObject.Find("title").GetComponent<Text>().text = "Don't Shoot the Puppy";
	}

	public void spawnParticle()
	{
		GameObject.Find("start_button").GetComponent<PlayGame>().spawnParticle();
	}

	public void dropAnvil()
	{
		GameObject anvil = GameObject.Find("anvil");
		anvil.GetComponent<Image>().enabled = true;
		anvil.GetComponent<Animator>().SetTrigger("fall");
	}

	public void hideAnvil()
	{
		GameObject.Find("anvil").GetComponent<Image>().enabled = false;
	}

	public void play()
	{
		GameObject.Find("play").GetComponent<Text>().enabled = true;
	}

	public void shake()
	{
		GameObject.Find("Main Camera").GetComponent<CameraShake>().enabled = true;
	}

	public void changeNumber()
	{
		GameObject level = GameObject.Find ("level");
		level.GetComponent<ChangeLevelNumber>().enabled = false;
		level.GetComponent<Text>().text = "Level "+Random.Range(1, 30);
	}

	public void killNumber()
	{
		GameObject level = GameObject.Find ("level");
		level.GetComponent<Text>().text = "Level "+(GameObject.Find("GameManager").GetComponent<LevelScript>().currentLevel + 1);
		level.GetComponent<ChangeLevelNumber>().enabled = true;
	}

	public void slowTime()
	{
		Time.timeScale -= .19f;
	}

	public void resetTime()
	{
		Time.timeScale = 1;
	
	}
}
