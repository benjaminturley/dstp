using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class ThrowAd : MonoBehaviour {

	public class AdvertisementTest : MonoBehaviour {
		void Awake() {
			if (Advertisement.isSupported) 
			{
				Advertisement.allowPrecache = true;
				Advertisement.Initialize ("16868");

				Advertisement.Show("pictureZone", null);
			} 
			else 
			{
				Debug.Log("Platform not supported");
			}
		}
	}
}
