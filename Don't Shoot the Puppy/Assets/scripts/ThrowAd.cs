using UnityEngine;
using System.Collections;

public class ThrowAd : MonoBehaviour {

	public GameObject ad;

	public void throwAd () 
	{
		Debug.Log ("IOS AD HERE: PLACEHOLDER");
		ad.SetActive(true);
	}
}
