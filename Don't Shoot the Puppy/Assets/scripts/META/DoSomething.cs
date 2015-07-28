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
		GameObject.Find("bug").GetComponent<Animator>().SetBool("go", true);
	}

	public void killbugs()
	{
		GameObject.Find("bug").GetComponent<Animator>().SetBool("go", false);
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

	public void unplay()
	{
		GameObject.Find("play").GetComponent<Text>().enabled = false;
	}

	public void shake()
	{
		GameObject.Find("Main Camera").GetComponent<CameraShake>().enabled = true;
	}

	public void changeNumber()
	{
		GameObject level = GameObject.Find ("level");
		level.GetComponent<ChangeLevelNumber>().enabled = false;
		level.GetComponent<Text>().text = "Level "+Random.Range(1, 15);
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

	public void throwNote()
	{
		GameObject.Find("popup").GetComponent<Animator>().SetBool("open", true);
	}

	public void closeNote()
	{
		GameObject.Find("popup").GetComponent<Animator>().SetBool("open", false);
	}

	public void throwAd()
	{
		GameObject ad = GameObject.Find("ad");
		ad.GetComponent<sequence>().back();
		ad.GetComponent<RectTransform>().rotation = new Quaternion(0f, 0f, 0f, 0f);
		ad.GetComponent<sequence>().go = true;
		ad.GetComponent<AudioSource>().Play();
	}

	public void closeAd()
	{
		GameObject ad = GameObject.Find("ad");
		ad.GetComponent<AudioSource>().Stop();
		ad.GetComponent<sequence>().go = false;
		ad.GetComponent<RectTransform>().Rotate(0, 90, 0);
	}
}
