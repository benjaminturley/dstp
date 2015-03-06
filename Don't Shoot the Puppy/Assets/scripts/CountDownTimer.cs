using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour 
{
	public double delay;
	public int startTime;
	public int remaining;

	void Start()
	{
		delay = Time.deltaTime;
	}

	void Update () 
	{
		delay -= Time.deltaTime;
		remaining = startTime - (int)(Time.deltaTime - delay);
		Debug.Log ("Delay: "+ delay + " Time: "+ Time.time + " Remaining: "+ remaining);
		GetComponent<Text> ().text = "" + (remaining);
	}
}
