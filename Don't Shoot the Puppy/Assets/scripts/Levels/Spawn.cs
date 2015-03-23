using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour 
{
	public GameObject objectToSpawn;

	public void go(int level)
	{
		Instantiate(objectToSpawn, transform.position, transform.rotation);
	}
}
