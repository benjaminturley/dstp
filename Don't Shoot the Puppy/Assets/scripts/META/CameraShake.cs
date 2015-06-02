using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour
{
	public Transform camTransform;

	public float shake = 0f;
	public float temp = 0f;
	

	public float shakeAmount = 0.7f;
	public float decreaseFactor = 1.0f;
	
	Vector3 originalPos;

	void Awake()
	{
		temp = shake;
	}
	
	void OnEnable()
	{
		originalPos = camTransform.localPosition;
		shake = temp;
	}

	void Update()
	{
		if (shake > 0)
		{
			camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;
			
			shake -= Time.deltaTime * decreaseFactor;
		}
		else
		{
			shake = 0f;
			camTransform.localPosition = originalPos;
			GetComponent<CameraShake>().enabled = false;
		}
	}
}
