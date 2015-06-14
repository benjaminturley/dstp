using UnityEngine;
using System;

public class PushMessage : MonoBehaviour 
{
	public void throwNote()
	{
		MobileNativeMessage msg = new MobileNativeMessage("iAlert Notification", "This app is attempting to steal your credit card number");
	}
}
