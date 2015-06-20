using UnityEngine;
using System.Collections;

public class WarningScript : MonoBehaviour 
{
	public void Start()
	{

		#if UNITY_IOS

		if(!(PlayerPrefs.GetInt("warned") == 1) &&
			(UnityEngine.iOS.Device.generation == UnityEngine.iOS.DeviceGeneration.iPhone
		   || UnityEngine.iOS.Device.generation == UnityEngine.iOS.DeviceGeneration.iPhone3G
		   || UnityEngine.iOS.Device.generation == UnityEngine.iOS.DeviceGeneration.iPhone3GS
		   || UnityEngine.iOS.Device.generation == UnityEngine.iOS.DeviceGeneration.iPhone4
		   || UnityEngine.iOS.Device.generation == UnityEngine.iOS.DeviceGeneration.iPhone4S
		   || UnityEngine.iOS.Device.generation == UnityEngine.iOS.DeviceGeneration.iPodTouch1Gen
		   || UnityEngine.iOS.Device.generation == UnityEngine.iOS.DeviceGeneration.iPodTouch2Gen
		   || UnityEngine.iOS.Device.generation == UnityEngine.iOS.DeviceGeneration.iPodTouch3Gen
		   || UnityEngine.iOS.Device.generation == UnityEngine.iOS.DeviceGeneration.iPodTouch4Gen))
		{
			PlayerPrefs.SetInt("warned", 1);
		}

		else
			Destroy(gameObject);

		#endif

	}

	public void close()
	{
		Destroy(gameObject);
	}
	
}

