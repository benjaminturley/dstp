using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		((MovieTexture)GameObject.Find ("ad").GetComponent<CanvasRenderer>().GetMaterial().mainTexture).Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
