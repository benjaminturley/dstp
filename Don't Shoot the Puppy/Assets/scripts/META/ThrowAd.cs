using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class ThrowAd : MonoBehaviour 
{

	public void Start()
	{
		#if UNITY_IOS
		Advertisement.Initialize ("16868");
		#endif

		#if UNITY_ANDROID
		Advertisement.Initialize ("53919");
		#endif
	}

	public void throwAd() 
	{
		if (Advertisement.isSupported) 
			Advertisement.Show();
		
		else
			Debug.Log("Platform not supported");
	}	
}
