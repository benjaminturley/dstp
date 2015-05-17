using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour 
{
	public double delay;
	public int startTime;
	public int remaining;
	public bool count;

	void Start()
	{
		delay = Time.deltaTime;
	}

	void Update () 
	{
		delay -= Time.deltaTime;
		remaining = startTime - (int)(Time.deltaTime - delay);
		GetComponent<Text> ().text = "" + (remaining);
	}
}
