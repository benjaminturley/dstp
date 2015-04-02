using UnityEngine;
using System;

public class PushMessage : MonoBehaviour 
{
	public void throwNote()
	{
		LocalNotification notif = new LocalNotification();
		notif.alertAction = "iAlert Notification";
		notif.alertBody = "This app is attempting to steal your credit card number";
		notif.fireDate = DateTime.Now;
		NotificationServices.ScheduleLocalNotification(notif);
		Debug.Log("THROWN");
	}

	void Update()
	{
		if (NotificationServices.localNotificationCount > 0) 
		{
			Debug.Log(NotificationServices.localNotifications[0].alertBody);
			Debug.Log ("Working!");
			NotificationServices.ClearLocalNotifications();
		}
	}
}
