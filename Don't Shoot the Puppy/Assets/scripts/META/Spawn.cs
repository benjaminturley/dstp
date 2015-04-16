using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour 
{
	public GameObject[] itemList;

	public void go(int level)
	{
		Instantiate(itemList[level], transform.position, transform.rotation);
	}
}
