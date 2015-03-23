using UnityEngine;
using System.Collections;

public class RotateTurret : MonoBehaviour 
{

	public Transform targetTransform;
	public float speed = 1.0f;

	void Update () 
	{
		targetTransform = GameObject.Find("Puppy(Clone)").transform;
		Vector3 vectorToTarget = targetTransform.position - transform.position;
		float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * speed);
	}
}
