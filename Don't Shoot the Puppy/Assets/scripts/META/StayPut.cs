using UnityEngine;
using System.Collections;

public class StayPut : MonoBehaviour 
{
	Vector3 pos;
	
	void Start () 
	{
		pos = transform.position;
	}

	void Update () 
	{
		transform.position = pos;
	}
}
