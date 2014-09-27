/*using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class CreateAd : MonoBehaviour 
{
	public bool showAd = false;

	void Awake() 
	{
		if (Advertisement.isSupported && showAd) 
		{
			Advertisement.Initialize ("16868");
			Advertisement.allowPrecache = true;
		}
	}

	void Update()
	{
		if (Advertisement.isReady())
		{
				Advertisement.Show ();
		}
	}
}
*/