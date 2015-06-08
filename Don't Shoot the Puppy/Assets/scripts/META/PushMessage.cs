using UnityEngine;
using System;

public class PushMessage : MonoBehaviour 
{
	public void throwNote()
	{
		UnityEngine.iOS.LocalNotification notif = new UnityEngine.iOS.LocalNotification();
		notif.alertAction = "iAlert Notification";
		notif.alertBody = "This app is attempting to steal your credit card number";
		notif.fireDate = DateTime.Now;
		UnityEngine.iOS.NotificationServices.ScheduleLocalNotification(notif);
		Debug.Log("Threw Note");
	}

	void Update()
	{
		if (UnityEngine.iOS.NotificationServices.localNotificationCount > 0) 
		{
			Debug.Log(UnityEngine.iOS.NotificationServices.localNotifications[0].alertBody);
			Debug.Log ("Working!");
			UnityEngine.iOS.NotificationServices.ClearLocalNotifications();
		}

		if(UnityEngine.iOS.NotificationServices.localNotificationCount > 0)
		{
			GetComponent<AcheivementSaver>().Save("j");
		}
	}
}
