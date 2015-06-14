using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class ThrowAd : MonoBehaviour 
{

	public void Start()
	{
		Advertisement.allowPrecache = true;
		Advertisement.Initialize ("16868");
	}

	public void throwAd() 
	{
		if (Advertisement.isSupported && Advertisement.isReady()) 
			Advertisement.Show();

		else
			Debug.Log("Platform not supported");
	}	
}
