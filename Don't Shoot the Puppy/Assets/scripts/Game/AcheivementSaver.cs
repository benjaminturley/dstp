using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AcheivementSaver : MonoBehaviour 
{
	public bool isLabel = false;
	public string key = "";
	
	public Texture winTex;

	void Start()
	{
		//PlayerPrefs.SetString("ach", "");
		//Debug.Log(PlayerPrefs.GetString("ach"));
		//PlayerPrefs.SetString("ach", "abcdefghijklmnopqrstuvw");

		updateTex();
	}

	public void Save(string str)
	{
		if(!PlayerPrefs.GetString("ach").Contains(str))
		{
			PlayerPrefs.SetString("ach", PlayerPrefs.GetString("ach") + str);

			AcheivementSaver[] chieves = FindObjectsOfType(typeof(AcheivementSaver)) as AcheivementSaver[];

			foreach(AcheivementSaver i in chieves)
			{
				i.updateTex();
				i.broadcast(str);
			}
		}

		PlayerPrefs.Save();
	}

	public void broadcast(string str)
	{
		if(key == str)
		{
			GameObject.Find("AchieveBanner").GetComponent<Animator>().SetTrigger("go");
			GameObject.Find("thetext").GetComponent<Animator>().SetTrigger("go");
			GameObject.Find("thetext").GetComponent<Text>().text = name +"\nachieved!";
		}
	}

	public void updateTex()
	{
		if(isLabel && PlayerPrefs.GetString("ach").Contains(key))
			GetComponent<RawImage>().texture = winTex;
	}
}
