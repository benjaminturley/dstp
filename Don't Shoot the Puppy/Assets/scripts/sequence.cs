using UnityEngine;
using System.Collections; 
using UnityEngine.UI;

public class sequence : MonoBehaviour  
{  
	public bool go = false; 
	private Sprite sprite;    
	private int frameCounter; 
	private string zeros = "00";
	public string folderName;  
	public string imageSequenceName;   
	public int numberOfFrames;   
	private string baseName;  
	
	void Awake()  
	{  
		baseName = folderName + "/" + imageSequenceName;  
	}  
	
	void Start ()  
	{    
		sprite = (Sprite)Resources.Load(baseName + " " + zeros + "" + frameCounter, typeof(Sprite));  
	}  
	
	void Update ()  
	{  
		if(go)
		{
			StartCoroutine("Play", 0.008f);  
			GetComponent<Image>().sprite = sprite;
		}
	}  
	 
	IEnumerator Play(float delay)  
	{  
		yield return new WaitForSeconds(delay);    
		  
		if(frameCounter < numberOfFrames-1)  
		{  
			++frameCounter;  

			if(frameCounter == 10)
				zeros = "0";
			if(frameCounter == 100)
				zeros = "";

			sprite = (Sprite)Resources.Load(baseName + " " + zeros + "" + frameCounter, typeof(Sprite));  
		}  

		StopCoroutine("Play");  
	} 

	public void back()
	{
		frameCounter = 1;
	}
}
