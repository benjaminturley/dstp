using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DoSomething : MonoBehaviour {

	public void startTimer()
	{
		GameObject.Find("Timer").GetComponent<CountDownTimer>().enabled = true;
	}

	public void stopTimer()
	{
		GameObject.Find("Timer").GetComponent<Text>().enabled = false;
	}
}
