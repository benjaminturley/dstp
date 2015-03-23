using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ChangeLevelNumber : MonoBehaviour 
{
	int levelNumber;
	public GameObject levelText;
	public GameObject gameManager;

	void Update()
	{
		levelNumber = gameManager.GetComponent<LevelScript>().currentLevel;
		levelText.GetComponent<Text>().text = "Level " + (levelNumber + 1);
	}
}
