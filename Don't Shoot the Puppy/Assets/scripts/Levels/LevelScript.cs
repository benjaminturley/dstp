using UnityEngine;
using System.Collections;

public class LevelScript : MonoBehaviour 
{
	public GameObject puppySpawn;
	public GameObject signSpawn;
	public GameObject turretSpawn;

	public int currentLevel = 0;

	void Start()
	{
		puppySpawn.GetComponent<Spawn>().go(currentLevel);
		signSpawn.GetComponent<Spawn>().go(currentLevel);
		turretSpawn.GetComponent<Spawn>().go(currentLevel);
	}

	public void progress()
	{
		if(currentLevel < 29)
			currentLevel++;
		else
			currentLevel = 0;

		puppySpawn.GetComponent<Spawn>().go(currentLevel);
		signSpawn.GetComponent<Spawn>().go(currentLevel);
		turretSpawn.GetComponent<Spawn>().go(currentLevel);
	}
}
