using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GoToLevel : MonoBehaviour 
{
	bool clickable = false;
	
	GameObject warning;

	Color temp;

	
	public void Update()
	{

		GetComponent<Image>().color = Color.white;

		if(PlayerPrefs.GetInt ("bestLevel") >= 29)
			clickable = true;

		else if(PlayerPrefs.GetInt ("bestLevel") >= 20 && int.Parse(this.name) <= 19)
			clickable = true;

		else if(PlayerPrefs.GetInt ("bestLevel") >= 10 && int.Parse(this.name) <= 9)
			clickable = true;

		else if(int.Parse(this.name) == 1)
		        clickable = true;

		if(!clickable)
			GetComponent<Image>().color = Color.gray;

		warning = GameObject.Find ("warning");
	}
	public void clicked()
	{
		if(clickable)
			GameObject.Find ("GameManager").GetComponent<LevelScript>().currentLevel = (int.Parse(this.name)-2);

		else
		{
			GameObject.Find ("GameManager").GetComponent<LevelScript>().currentLevel = GameObject.Find ("GameManager").GetComponent<LevelScript>().currentLevel - 1;

			warning.GetComponent<Animator>().SetTrigger("fade");
		
			GameObject.Find("start_button").GetComponent<PlayGame>().levelCount = 0;
		}

	}
}
